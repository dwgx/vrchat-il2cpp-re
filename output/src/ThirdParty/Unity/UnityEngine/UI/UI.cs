// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UI
// Classes: 66
// Methods: 1219

namespace ThirdParty.Unity.UnityEngine.UI
{
    public class AnimationTriggers : Object
    {
        public string kDefaultNormalAnimName;
        public string kDefaultHighlightedAnimName;
        public string kDefaultPressedAnimName;
        public string kDefaultSelectedAnimName;
        public string kDefaultDisabledAnimName;

        // ── Methods ──
        public void get_normalTrigger(){} // RVA: 0x7FFE81116380
        public void set_normalTrigger(){} // RVA: 0x7FFE810FCE30
        public void get_highlightedTrigger(){} // RVA: 0x7FFE810FE7C0
        public void set_highlightedTrigger(){} // RVA: 0x7FFE81161E80
        public void get_pressedTrigger(){} // RVA: 0x7FFE811290C0
        public void set_pressedTrigger(){} // RVA: 0x7FFE811290D0
        public void get_selectedTrigger(){} // RVA: 0x7FFE81129130
        public void set_selectedTrigger(){} // RVA: 0x7FFE810FCE90
        public void get_disabledTrigger(){} // RVA: 0x7FFE8144E200
        public void set_disabledTrigger(){} // RVA: 0x7FFE81129890
        public void .ctor(){} // RVA: 0x7FFE87DFA8E0
    }

    public class AspectRatioFitter : UIBehaviour
    {
        public 0x666437BC m_AspectMode; // 0x20
        public float m_AspectRatio; // 0x24
        public UnityEngine.RectTransform m_Rect; // 0x28

        // ── Methods ──
        public void get_aspectMode(){} // RVA: 0x7FFE8151D690
        public void set_aspectMode(){} // RVA: 0x7FFE87FF0700
        public void get_aspectRatio(){} // RVA: 0x7FFE81268F50
        public void set_aspectRatio(){} // RVA: 0x7FFE87FF0760
        public void get_rectTransform(){} // RVA: 0x7FFE87FF07C0
        public void .ctor(){} // RVA: 0x7FFE8129EE50
        public void OnEnable(){} // RVA: 0x7FFE87FF0900
        public void Start(){} // RVA: 0x7FFE87FF0A40
        public void OnDisable(){} // RVA: 0x7FFE87FF0AC0
        public void OnTransformParentChanged(){} // RVA: 0x7FFE87FF0B20
        public void Update(){} // RVA: 0x7FFE87FF0C60
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFE87FF0C80
        public void UpdateRect(){} // RVA: 0x7FFE87FF0C90
        public void GetSizeDeltaToProduceSize(){} // RVA: 0x7FFE87FF1080
        public void GetParentSize(){} // RVA: 0x7FFE87FF12F0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFE810FB310
        public void SetLayoutVertical(){} // RVA: 0x7FFE810FB310
        public void SetDirty(){} // RVA: 0x7FFE87FF0C80
        public void IsComponentValidOnObject(){} // RVA: 0x7FFE87FF14F0
        public void IsAspectModeValid(){} // RVA: 0x7FFE87FF16C0
        public void DoesParentExists(){} // RVA: 0x7FFE81121470
    }

    public class BaseMeshEffect : UIBehaviour
    {
        public UnityEngine.UI.Graphic m_Graphic; // 0x20

        // ── Methods ──
        public void get_graphic(){} // RVA: 0x7FFE8801D7A0
        public void OnEnable(){} // RVA: 0x7FFE8801D8E0
        public void OnDisable(){} // RVA: 0x7FFE8801D9E0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFE8801DAE0
        public void ModifyMesh(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class BaseVertexEffect : Object
    {
        // ── Methods ──
        public void ModifyVertices(){} // RVA: 0x7FFE80E460A0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class Button : Selectable
    {
        public ButtonClickedEvent m_OnClick; // 0x100

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87DFAB30
        public void get_onClick(){} // RVA: 0x7FFE81828B50
        public void set_onClick(){} // RVA: 0x7FFE81A58AB0
        public void Press(){} // RVA: 0x7FFE87DFAC70
        public void OnPointerClick(){} // RVA: 0x7FFE87DFAD10
        public void OnSubmit(){} // RVA: 0x7FFE87DFAD40
        public void OnFinishSubmit(){} // RVA: 0x7FFE87DFAE50
    }

    public class CanvasScaler : UIBehaviour
    {
        public 0x6664386C m_UiScaleMode; // 0x20
        public float m_ReferencePixelsPerUnit; // 0x24
        public float m_ScaleFactor; // 0x28
        public UnityEngine.Vector2 m_ReferenceResolution; // 0x2C
        public 0x666438C4 m_ScreenMatchMode; // 0x34
        public float m_MatchWidthOrHeight; // 0x38
        public float kLogBase;
        public 0x6664391C m_PhysicalUnit; // 0x3C
        public float m_FallbackScreenDPI; // 0x40
        public float m_DefaultSpriteDPI; // 0x44

        // ── Methods ──
        public void get_uiScaleMode(){} // RVA: 0x7FFE8151D690
        public void set_uiScaleMode(){} // RVA: 0x7FFE8170B670
        public void get_referencePixelsPerUnit(){} // RVA: 0x7FFE81268F50
        public void set_referencePixelsPerUnit(){} // RVA: 0x7FFE81268F60
        public void get_scaleFactor(){} // RVA: 0x7FFE811DA210
        public void set_scaleFactor(){} // RVA: 0x7FFE87FF16E0
        public void get_referenceResolution(){} // RVA: 0x7FFE87FF1700
        public void set_referenceResolution(){} // RVA: 0x7FFE87FF1720
        public void get_screenMatchMode(){} // RVA: 0x7FFE82447220
        public void set_screenMatchMode(){} // RVA: 0x7FFE82443340
        public void get_matchWidthOrHeight(){} // RVA: 0x7FFE8130ACF0
        public void set_matchWidthOrHeight(){} // RVA: 0x7FFE8130A000
        public void get_physicalUnit(){} // RVA: 0x7FFE816311C0
        public void set_physicalUnit(){} // RVA: 0x7FFE82A4B070
        public void get_fallbackScreenDPI(){} // RVA: 0x7FFE815E8460
        public void set_fallbackScreenDPI(){} // RVA: 0x7FFE815E8470
        public void get_defaultSpriteDPI(){} // RVA: 0x7FFE81103970
        public void set_defaultSpriteDPI(){} // RVA: 0x7FFE87FF17A0
        public void get_dynamicPixelsPerUnit(){} // RVA: 0x7FFE81C1C360
        public void set_dynamicPixelsPerUnit(){} // RVA: 0x7FFE81C1C2E0
        public void .ctor(){} // RVA: 0x7FFE87FF17C0
        public void OnEnable(){} // RVA: 0x7FFE87FF1850
        public void Canvas_preWillRenderCanvases(){} // RVA: 0x7FFE818572C0
        public void OnDisable(){} // RVA: 0x7FFE87FF1950
        public void Handle(){} // RVA: 0x7FFE87FF1A20
        public void HandleWorldCanvas(){} // RVA: 0x7FFE87FF1C30
        public void HandleConstantPixelSize(){} // RVA: 0x7FFE87FF1CA0
        public void HandleScaleWithScreenSize(){} // RVA: 0x7FFE87FF1D10
        public void HandleConstantPhysicalSize(){} // RVA: 0x7FFE87FF1FD0
        public void SetScaleFactor(){} // RVA: 0x7FFE87FF20F0
        public void SetReferencePixelsPerUnit(){} // RVA: 0x7FFE87FF2130
    }

    public class CanvasUpdateRegistry : Object
    {
        public UnityEngine.UI.CanvasUpdateRegistry s_Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87DFB0E0
        public void get_instance(){} // RVA: 0x7FFE87DFB3B0
        public void ObjectValidForUpdate(){} // RVA: 0x7FFE87DFB4D0
        public void CleanInvalidItems(){} // RVA: 0x7FFE87DFB640
        public void PerformUpdate(){} // RVA: 0x7FFE87DFB810
        public void ParentCount(){} // RVA: 0x7FFE87DFBF80
        public void SortLayoutList(){} // RVA: 0x7FFE87DFC180
        public void RegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFE87DFC240
        public void TryRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFE87DFC2B0
        public void InternalRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFE87DFC320
        public void RegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFE87DFC3E0
        public void TryRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFE87DFC450
        public void InternalRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFE87DFC4C0
        public void UnRegisterCanvasElementForRebuild(){} // RVA: 0x7FFE87DFC5D0
        public void DisableCanvasElementForRebuild(){} // RVA: 0x7FFE87DFC8C0
        public void InternalUnRegisterCanvasElementForLayoutRebuild(){} // RVA: 0x7FFE87DFCBB0
        public void InternalUnRegisterCanvasElementForGraphicRebuild(){} // RVA: 0x7FFE87DFCD10
        public void InternalDisableCanvasElementForLayoutRebuild(){} // RVA: 0x7FFE87DFCE70
        public void InternalDisableCanvasElementForGraphicRebuild(){} // RVA: 0x7FFE87DFCFD0
        public void IsRebuildingLayout(){} // RVA: 0x7FFE87DFD130
        public void IsRebuildingGraphics(){} // RVA: 0x7FFE87DFD190
        public void .cctor(){} // RVA: 0x7FFE87DFD1F0
    }

    public class ClipperRegistry : Object
    {
        public UnityEngine.UI.ClipperRegistry s_Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87DFDBD0
        public void get_instance(){} // RVA: 0x7FFE87DFDC90
        public void Cull(){} // RVA: 0x7FFE87DFDE10
        public void Register(){} // RVA: 0x7FFE87DFDFF0
        public void Unregister(){} // RVA: 0x7FFE87DFE060
        public void Disable(){} // RVA: 0x7FFE87DFE0C0
    }

    public class Clipping : Object
    {
        // ── Methods ──
        public void FindCullAndClipWorldRect(){} // RVA: 0x7FFE87DFE120
    }

    public class ColorBlock : ValueType
    {
        public UnityEngine.Color m_NormalColor; // 0x10
        public UnityEngine.Color m_HighlightedColor; // 0x20
        public UnityEngine.Color m_PressedColor; // 0x30
        public UnityEngine.Color m_SelectedColor; // 0x40
        public UnityEngine.Color m_DisabledColor; // 0x50
        public float m_ColorMultiplier; // 0x60
        public float m_FadeDuration; // 0x64

        // ── Methods ──
        public void get_normalColor(){} // RVA: 0x7FFE8151C410
        public void set_normalColor(){} // RVA: 0x7FFE827D9C10
        public void get_highlightedColor(){} // RVA: 0x7FFE826F6B90
        public void set_highlightedColor(){} // RVA: 0x7FFE826F6BA0
        public void get_pressedColor(){} // RVA: 0x7FFE82C84C90
        public void set_pressedColor(){} // RVA: 0x7FFE8671A610
        public void get_selectedColor(){} // RVA: 0x7FFE86809840
        public void set_selectedColor(){} // RVA: 0x7FFE86809850
        public void get_disabledColor(){} // RVA: 0x7FFE82D32FA0
        public void set_disabledColor(){} // RVA: 0x7FFE850A4980
        public void get_colorMultiplier(){} // RVA: 0x7FFE81163460
        public void set_colorMultiplier(){} // RVA: 0x7FFE81163470
        public void get_fadeDuration(){} // RVA: 0x7FFE81604410
        public void set_fadeDuration(){} // RVA: 0x7FFE816031A0
        public void .cctor(){} // RVA: 0x7FFE87DFD2D0
        public void Equals(){} // RVA: 0x7FFE87DFD6E0 | overloaded x2
        public void op_Equality(){} // RVA: 0x7FFE87DFD9E0
        public void op_Inequality(){} // RVA: 0x7FFE87DFDA90
        public void GetHashCode(){} // RVA: 0x7FFE87DFDB40
    }

    public class ContentSizeFitter : UIBehaviour
    {
        public 0x666439CC m_HorizontalFit; // 0x20
        public 0x666439CC m_VerticalFit; // 0x24
        public UnityEngine.RectTransform m_Rect; // 0x28

        // ── Methods ──
        public void get_horizontalFit(){} // RVA: 0x7FFE8151D690
        public void set_horizontalFit(){} // RVA: 0x7FFE87FF2170
        public void get_verticalFit(){} // RVA: 0x7FFE81A56130
        public void set_verticalFit(){} // RVA: 0x7FFE87FF21D0
        public void get_rectTransform(){} // RVA: 0x7FFE87FF2230
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void OnEnable(){} // RVA: 0x7FFE87FF2370
        public void OnDisable(){} // RVA: 0x7FFE87FF2380
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFE87FF2370
        public void HandleSelfFittingAlongAxis(){} // RVA: 0x7FFE87FF23E0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFE87FF2480
        public void SetLayoutVertical(){} // RVA: 0x7FFE87FF24F0
        public void SetDirty(){} // RVA: 0x7FFE87FF2560
    }

    public class DefaultControls : Object
    {
        public IFactoryControls m_CurrentFactory;

        // ── Methods ──
        public void get_factory(){} // RVA: 0x7FFE87DFE860
        public void CreateUIElementRoot(){} // RVA: 0x7FFE87DFE8C0
        public void CreateUIObject(){} // RVA: 0x7FFE87DFEA10
        public void SetDefaultTextValues(){} // RVA: 0x7FFE87DFEB00
        public void SetDefaultColorTransitionValues(){} // RVA: 0x7FFE87DFEC90
        public void SetParentAndAlign(){} // RVA: 0x7FFE87DFECF0
        public void SetLayerRecursively(){} // RVA: 0x7FFE87DFEEF0
        public void CreatePanel(){} // RVA: 0x7FFE87DFF100
        public void CreateButton(){} // RVA: 0x7FFE87DFF600
        public void CreateText(){} // RVA: 0x7FFE87DFFD30
        public void CreateImage(){} // RVA: 0x7FFE87DFFF40
        public void CreateRawImage(){} // RVA: 0x7FFE87E000E0
        public void CreateSlider(){} // RVA: 0x7FFE87E00280
        public void CreateScrollbar(){} // RVA: 0x7FFE87E01100
        public void CreateToggle(){} // RVA: 0x7FFE87E019D0
        public void CreateInputField(){} // RVA: 0x7FFE87E02570
        public void CreateDropdown(){} // RVA: 0x7FFE87E03100
        public void CreateScrollView(){} // RVA: 0x7FFE87E05450
        public void .cctor(){} // RVA: 0x7FFE87E06680
    }

    public class Dropdown : Selectable
    {
        public UnityEngine.RectTransform m_Template; // 0x100
        public UnityEngine.UI.Text m_CaptionText; // 0x108
        public UnityEngine.UI.Image m_CaptionImage; // 0x110
        public UnityEngine.UI.Text m_ItemText; // 0x118
        public UnityEngine.UI.Image m_ItemImage; // 0x120
        public int m_Value; // 0x128
        public OptionDataList m_Options; // 0x130
        public DropdownEvent m_OnValueChanged; // 0x138
        public float m_AlphaFadeSpeed; // 0x140

        // ── Methods ──
        public void get_template(){} // RVA: 0x7FFE81828B50
        public void set_template(){} // RVA: 0x7FFE87E06900
        public void get_captionText(){} // RVA: 0x7FFE8181E3D0
        public void set_captionText(){} // RVA: 0x7FFE87E06960
        public void get_captionImage(){} // RVA: 0x7FFE81317980
        public void set_captionImage(){} // RVA: 0x7FFE87E069C0
        public void get_itemText(){} // RVA: 0x7FFE81318010
        public void set_itemText(){} // RVA: 0x7FFE87E06A20
        public void get_itemImage(){} // RVA: 0x7FFE813A1DA0
        public void set_itemImage(){} // RVA: 0x7FFE87E06A80
        public void get_options(){} // RVA: 0x7FFE87E06AE0
        public void set_options(){} // RVA: 0x7FFE87E06B00
        public void get_onValueChanged(){} // RVA: 0x7FFE8181EA70
        public void set_onValueChanged(){} // RVA: 0x7FFE818254E0
        public void get_alphaFadeSpeed(){} // RVA: 0x7FFE87E06B80
        public void set_alphaFadeSpeed(){} // RVA: 0x7FFE87E06B90
        public void get_value(){} // RVA: 0x7FFE86DBB070
        public void set_value(){} // RVA: 0x7FFE87E06BA0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE87E06BB0
        public void Set(){} // RVA: 0x7FFE87E06BC0
        public void .ctor(){} // RVA: 0x7FFE87E06D40
        public void Awake(){} // RVA: 0x7FFE87E06F70
        public void Start(){} // RVA: 0x7FFE87E07280
        public void OnDisable(){} // RVA: 0x7FFE87E073B0
        public void RefreshShownValue(){} // RVA: 0x7FFE87E07510
        public void AddOptions(){} // RVA: 0x7FFE87E07B40 | overloaded x3
        public void ClearOptions(){} // RVA: 0x7FFE87E07D10
        public void SetupTemplate(){} // RVA: 0x7FFE87E07D90
        public void GetOrAddComponent(){} // RVA: 0x7FFE810A1420
        public void OnPointerClick(){} // RVA: 0x7FFE87E08BC0
        public void OnSubmit(){} // RVA: 0x7FFE87E08BC0
        public void OnCancel(){} // RVA: 0x7FFE87E08BD0
        public void Show(){} // RVA: 0x7FFE87E08BE0
        public void CreateBlocker(){} // RVA: 0x7FFE87E0A470
        public void DestroyBlocker(){} // RVA: 0x7FFE87E0AFF0
        public void CreateDropdownList(){} // RVA: 0x7FFE87E0B040
        public void DestroyDropdownList(){} // RVA: 0x7FFE87E0B0B0
        public void CreateItem(){} // RVA: 0x7FFE87E0B100
        public void DestroyItem(){} // RVA: 0x7FFE810FB310
        public void AddItem(){} // RVA: 0x7FFE87E0B170
        public void AlphaFadeList(){} // RVA: 0x7FFE87E0B900 | overloaded x2
        public void SetAlpha(){} // RVA: 0x7FFE87E0BAC0
        public void Hide(){} // RVA: 0x7FFE87E0BBE0
        public void DelayedDestroyDropdownList(){} // RVA: 0x7FFE87E0BF70
        public void ImmediateDestroyDropdownList(){} // RVA: 0x7FFE87E0C030
        public void OnSelectItem(){} // RVA: 0x7FFE87E0C320
        public void .cctor(){} // RVA: 0x7FFE87E0C5B0
    }

    public class FontData : Object
    {
        public UnityEngine.Font m_Font; // 0x10
        public int m_FontSize; // 0x18
        public 0x666D2FA4 m_FontStyle; // 0x1C
        public bool m_BestFit; // 0x20
        public int m_MinSize; // 0x24
        public int m_MaxSize; // 0x28
        public 0x666D315C m_Alignment; // 0x2C
        public bool m_AlignByGeometry; // 0x30
        public bool m_RichText; // 0x31
        public 0x666D31B4 m_HorizontalOverflow; // 0x34
        public 0x666D320C m_VerticalOverflow; // 0x38
        public float m_LineSpacing; // 0x3C
        public object field_12; // 0x28

        // ── Methods ──
        public void get_defaultFontData(){} // RVA: 0x7FFE87E0CA60
        public void get_font(){} // RVA: 0x7FFE81116380
        public void set_font(){} // RVA: 0x7FFE810FCE30
        public void get_fontSize(){} // RVA: 0x7FFE813DB630
        public void set_fontSize(){} // RVA: 0x7FFE8144DF00
        public void get_fontStyle(){} // RVA: 0x7FFE82707EE0
        public void set_fontStyle(){} // RVA: 0x7FFE82717690
        public void get_bestFit(){} // RVA: 0x7FFE811E99D0
        public void set_bestFit(){} // RVA: 0x7FFE811E99E0
        public void get_minSize(){} // RVA: 0x7FFE81A56130
        public void set_minSize(){} // RVA: 0x7FFE82447980
        public void get_maxSize(){} // RVA: 0x7FFE81549710
        public void set_maxSize(){} // RVA: 0x7FFE817E4800
        public void get_alignment(){} // RVA: 0x7FFE81F84A50
        public void set_alignment(){} // RVA: 0x7FFE82883A50
        public void get_alignByGeometry(){} // RVA: 0x7FFE81121450
        public void set_alignByGeometry(){} // RVA: 0x7FFE81121460
        public void get_richText(){} // RVA: 0x7FFE81121470
        public void set_richText(){} // RVA: 0x7FFE81121480
        public void get_horizontalOverflow(){} // RVA: 0x7FFE82447220
        public void set_horizontalOverflow(){} // RVA: 0x7FFE82443340
        public void get_verticalOverflow(){} // RVA: 0x7FFE81D46090
        public void set_verticalOverflow(){} // RVA: 0x7FFE81D46A00
        public void get_lineSpacing(){} // RVA: 0x7FFE8178C5D0
        public void set_lineSpacing(){} // RVA: 0x7FFE8178C310
        public void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize(){} // RVA: 0x7FFE87E0CAD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class FontUpdateTracker : Object
    {
        // ── Methods ──
        public void TrackText(){} // RVA: 0x7FFE87E0CB20
        public void RebuildForFont(){} // RVA: 0x7FFE87E0CF60
        public void UntrackText(){} // RVA: 0x7FFE87E0D120
        public void .cctor(){} // RVA: 0x7FFE87E0D4F0
    }

    public class Graphic : UIBehaviour
    {
        public UnityEngine.Material s_DefaultUI;
        public UnityEngine.Texture2D s_WhiteTexture; // 0x8
        public UnityEngine.Material m_Material; // 0x20
        public UnityEngine.Color m_Color; // 0x28
        public bool m_SkipLayoutUpdate; // 0x38
        public bool m_SkipMaterialUpdate; // 0x39
        public bool m_RaycastTarget; // 0x3A
        public bool m_RaycastTargetCache; // 0x3B
        public UnityEngine.Vector4 m_RaycastPadding; // 0x3C
        public UnityEngine.RectTransform m_RectTransform; // 0x50
        public UnityEngine.CanvasRenderer m_CanvasRenderer; // 0x58
        public UnityEngine.Canvas m_Canvas; // 0x60
        public bool m_VertsDirty; // 0x68
        public bool m_MaterialDirty; // 0x69

        // ── Methods ──
        public void get_defaultGraphicMaterial(){} // RVA: 0x7FFE87E0D5D0
        public void get_color(){} // RVA: 0x7FFE81E90600
        public void set_color(){} // RVA: 0x7FFE87E0D7B0
        public void get_raycastTarget(){} // RVA: 0x7FFE82230840
        public void set_raycastTarget(){} // RVA: 0x7FFE87E0D820
        public void get_raycastPadding(){} // RVA: 0x7FFE86CF05A0
        public void set_raycastPadding(){} // RVA: 0x7FFE86CF05B0
        public void get_useLegacyMeshGeneration(){} // RVA: 0x7FFE820E9360
        public void set_useLegacyMeshGeneration(){} // RVA: 0x7FFE818DBD80
        public void .ctor(){} // RVA: 0x7FFE87E0D930
        public void SetAllDirty(){} // RVA: 0x7FFE87E0DAC0
        public void SetLayoutDirty(){} // RVA: 0x7FFE87E0DB30
        public void SetVerticesDirty(){} // RVA: 0x7FFE87E0DBD0
        public void SetMaterialDirty(){} // RVA: 0x7FFE87E0DC60
        public void SetRaycastDirty(){} // RVA: 0x7FFE87E0DD00
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFE87E0DE20
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7FFE87E0DF90
        public void OnTransformParentChanged(){} // RVA: 0x7FFE87E0E040
        public void get_depth(){} // RVA: 0x7FFE87E0E140
        public void get_rectTransform(){} // RVA: 0x7FFE87E0E1B0
        public void get_canvas(){} // RVA: 0x7FFE87E0E250
        public void CacheCanvas(){} // RVA: 0x7FFE87E0E330
        public void get_canvasRenderer(){} // RVA: 0x7FFE87E0E5B0
        public void get_defaultMaterial(){} // RVA: 0x7FFE87E0E740
        public void get_material(){} // RVA: 0x7FFE87E0E790
        public void set_material(){} // RVA: 0x7FFE87E0E880
        public void get_materialForRendering(){} // RVA: 0x7FFE87E0EA00
        public void get_mainTexture(){} // RVA: 0x7FFE87E0EC10
        public void OnEnable(){} // RVA: 0x7FFE87E0EC70
        public void OnDisable(){} // RVA: 0x7FFE87E0EEA0
        public void OnDestroy(){} // RVA: 0x7FFE87E0F080
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFE87E0F240
        public void OnCullingChanged(){} // RVA: 0x7FFE87E0F490
        public void Rebuild(){} // RVA: 0x7FFE87E0F550
        public void LayoutComplete(){} // RVA: 0x7FFE810FB310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFE810FB310
        public void UpdateMaterial(){} // RVA: 0x7FFE87E0F6E0
        public void UpdateGeometry(){} // RVA: 0x7FFE87E0F870
        public void DoMeshGeneration(){} // RVA: 0x7FFE87E0F890
        public void DoLegacyMeshGeneration(){} // RVA: 0x7FFE87E0FE80
        public void get_workerMesh(){} // RVA: 0x7FFE87E10460
        public void OnFillVBO(){} // RVA: 0x7FFE810FB310
        public void OnPopulateMesh(){} // RVA: 0x7FFE87E10710 | overloaded x2
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFE8762C860
        public void SetNativeSize(){} // RVA: 0x7FFE810FB310
        public void Raycast(){} // RVA: 0x7FFE87E10920
        public void PixelAdjustPoint(){} // RVA: 0x7FFE87E10E50
        public void GetPixelAdjustedRect(){} // RVA: 0x7FFE87E11120
        public void CrossFadeColor(){} // RVA: 0x7FFE87E11480 | overloaded x2
        public void CreateColorFromAlpha(){} // RVA: 0x7FFE87E11950
        public void CrossFadeAlpha(){} // RVA: 0x7FFE87E11970
        public void RegisterDirtyLayoutCallback(){} // RVA: 0x7FFE87E11A40
        public void UnregisterDirtyLayoutCallback(){} // RVA: 0x7FFE87E11B30
        public void RegisterDirtyVerticesCallback(){} // RVA: 0x7FFE87E11C20
        public void UnregisterDirtyVerticesCallback(){} // RVA: 0x7FFE87E11D10
        public void RegisterDirtyMaterialCallback(){} // RVA: 0x7FFE87E11E00
        public void UnregisterDirtyMaterialCallback(){} // RVA: 0x7FFE87E11F00
        public void .cctor(){} // RVA: 0x7FFE87E12000
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFE816315C0
    }

    public class GraphicRaycaster : BaseRaycaster
    {
        public int kNoEventMaskSet;
        public bool m_IgnoreReversedGraphics; // 0x28
        public 0x66642E74 m_BlockingObjects; // 0x2C
        public UnityEngine.LayerMask m_BlockingMask; // 0x30
        public UnityEngine.Canvas m_Canvas; // 0x38
        public System.Collections.Generic.List`1<UnityEngine.UI.Graphic> m_RaycastResults; // 0x40
        public System.Collections.Generic.List`1<UnityEngine.UI.Graphic> s_SortedGraphics;

        // ── Methods ──
        public void get_sortOrderPriority(){} // RVA: 0x7FFE87E121A0
        public void get_renderOrderPriority(){} // RVA: 0x7FFE87E12280
        public void get_ignoreReversedGraphics(){} // RVA: 0x7FFE815F1380
        public void set_ignoreReversedGraphics(){} // RVA: 0x7FFE81C15740
        public void get_blockingObjects(){} // RVA: 0x7FFE81F84A50
        public void set_blockingObjects(){} // RVA: 0x7FFE82883A50
        public void get_blockingMask(){} // RVA: 0x7FFE81156CD0
        public void set_blockingMask(){} // RVA: 0x7FFE81156CE0
        public void .ctor(){} // RVA: 0x7FFE87E123B0
        public void get_canvas(){} // RVA: 0x7FFE87E124B0
        public void Raycast(){} // RVA: 0x7FFE87E13C30 | overloaded x2
        public void get_eventCamera(){} // RVA: 0x7FFE87E13A50
        public void .cctor(){} // RVA: 0x7FFE87E14370
    }

    public class GraphicRegistry : Object
    {
        public UnityEngine.UI.GraphicRegistry s_Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87E145F0
        public void get_instance(){} // RVA: 0x7FFE87E14810
        public void RegisterGraphicForCanvas(){} // RVA: 0x7FFE87E14930
        public void RegisterRaycastGraphicForCanvas(){} // RVA: 0x7FFE87E14CD0
        public void UnregisterGraphicForCanvas(){} // RVA: 0x7FFE87E15080
        public void UnregisterRaycastGraphicForCanvas(){} // RVA: 0x7FFE87E15330
        public void DisableGraphicForCanvas(){} // RVA: 0x7FFE87E155B0
        public void DisableRaycastGraphicForCanvas(){} // RVA: 0x7FFE87E157D0
        public void GetGraphicsForCanvas(){} // RVA: 0x7FFE87E159F0
        public void GetRaycastableGraphicsForCanvas(){} // RVA: 0x7FFE87E15AC0
        public void .cctor(){} // RVA: 0x7FFE87E15B90
    }

    public class GridLayoutGroup : LayoutGroup
    {
        public 0x66643A7C m_StartCorner; // 0x60
        public 0x66643AD4 m_StartAxis; // 0x64
        public UnityEngine.Vector2 m_CellSize; // 0x68
        public UnityEngine.Vector2 m_Spacing; // 0x70
        public 0x66643B2C m_Constraint; // 0x78
        public int m_ConstraintCount; // 0x7C

        // ── Methods ──
        public void get_startCorner(){} // RVA: 0x7FFE8139EA30
        public void set_startCorner(){} // RVA: 0x7FFE87FF25E0
        public void get_startAxis(){} // RVA: 0x7FFE8139DA60
        public void set_startAxis(){} // RVA: 0x7FFE87FF2630
        public void get_cellSize(){} // RVA: 0x7FFE87FF2680
        public void set_cellSize(){} // RVA: 0x7FFE87FF26A0
        public void get_spacing(){} // RVA: 0x7FFE87FF26F0
        public void set_spacing(){} // RVA: 0x7FFE87FF2710
        public void get_constraint(){} // RVA: 0x7FFE8286C0A0
        public void set_constraint(){} // RVA: 0x7FFE87FF2760
        public void get_constraintCount(){} // RVA: 0x7FFE8286B570
        public void set_constraintCount(){} // RVA: 0x7FFE87FF27B0
        public void .ctor(){} // RVA: 0x7FFE87FF28A0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFE87FF2910
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFE87FF2B20
        public void SetLayoutHorizontal(){} // RVA: 0x7FFE87FF2D50
        public void SetLayoutVertical(){} // RVA: 0x7FFE87FF2D60
        public void SetCellsAlongAxis(){} // RVA: 0x7FFE87FF2D70
    }

    public class HorizontalLayoutGroup : HorizontalOrVerticalLayoutGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FF3530
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFE87FF3540
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFE87FF3570
        public void SetLayoutHorizontal(){} // RVA: 0x7FFE87FF3580
        public void SetLayoutVertical(){} // RVA: 0x7FFE87FF3590
    }

    public class HorizontalOrVerticalLayoutGroup : LayoutGroup
    {
        public float m_Spacing; // 0x60
        public bool m_ChildForceExpandWidth; // 0x64
        public bool m_ChildForceExpandHeight; // 0x65
        public bool m_ChildControlWidth; // 0x66
        public bool m_ChildControlHeight; // 0x67
        public bool m_ChildScaleWidth; // 0x68
        public bool m_ChildScaleHeight; // 0x69
        public bool m_ReverseArrangement; // 0x6A

        // ── Methods ──
        public void get_spacing(){} // RVA: 0x7FFE8120BE10
        public void set_spacing(){} // RVA: 0x7FFE87FF35A0
        public void get_childForceExpandWidth(){} // RVA: 0x7FFE821FF050
        public void set_childForceExpandWidth(){} // RVA: 0x7FFE87FF3650
        public void get_childForceExpandHeight(){} // RVA: 0x7FFE872487A0
        public void set_childForceExpandHeight(){} // RVA: 0x7FFE87FF36A0
        public void get_childControlWidth(){} // RVA: 0x7FFE87248700
        public void set_childControlWidth(){} // RVA: 0x7FFE87FF36F0
        public void get_childControlHeight(){} // RVA: 0x7FFE872486F0
        public void set_childControlHeight(){} // RVA: 0x7FFE87FF3740
        public void get_childScaleWidth(){} // RVA: 0x7FFE811C3570
        public void set_childScaleWidth(){} // RVA: 0x7FFE87FF3790
        public void get_childScaleHeight(){} // RVA: 0x7FFE85B63B60
        public void set_childScaleHeight(){} // RVA: 0x7FFE87FF37E0
        public void get_reverseArrangement(){} // RVA: 0x7FFE8663A5A0
        public void set_reverseArrangement(){} // RVA: 0x7FFE87FF3830
        public void CalcAlongAxis(){} // RVA: 0x7FFE87FF3880
        public void SetChildrenAlongAxis(){} // RVA: 0x7FFE87FF3D30
        public void GetChildSizes(){} // RVA: 0x7FFE87FF48E0
        public void .ctor(){} // RVA: 0x7FFE87FF3530
    }

    public class ICanvasElement
    {
        // ── Methods ──
        public void Rebuild(){} // RVA: 0x7FFE80E46530
        public void get_transform(){} // RVA: 0x7FFE80E2E2E0
        public void LayoutComplete(){} // RVA: 0x7FFE80E45FE0
        public void GraphicUpdateComplete(){} // RVA: 0x7FFE80E45FE0
        public void IsDestroyed(){} // RVA: 0x7FFE80E2F150
    }

    public class IClippable
    {
        // ── Methods ──
        public void get_gameObject(){} // RVA: 0x7FFE80E2E2E0
        public void RecalculateClipping(){} // RVA: 0x7FFE80E45FE0
        public void get_rectTransform(){} // RVA: 0x7FFE80E2E2E0
        public void Cull(){}
        public void SetClipRect(){}
        public void SetClipSoftness(){} // RVA: 0x7FFE80E54AE0
    }

    public class IClipper
    {
        // ── Methods ──
        public void PerformClipping(){} // RVA: 0x7FFE80E45FE0
    }

    public class IGraphicEnabledDisabled
    {
        // ── Methods ──
        public void OnSiblingGraphicEnabledDisabled(){} // RVA: 0x7FFE80E45FE0
    }

    public class ILayoutController
    {
        // ── Methods ──
        public void SetLayoutHorizontal(){} // RVA: 0x7FFE80E45FE0
        public void SetLayoutVertical(){} // RVA: 0x7FFE80E45FE0
    }

    public class ILayoutElement
    {
        // ── Methods ──
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFE80E45FE0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFE80E45FE0
        public void get_minWidth(){} // RVA: 0x7FFE80E42E10
        public void get_preferredWidth(){} // RVA: 0x7FFE80E42E10
        public void get_flexibleWidth(){} // RVA: 0x7FFE80E42E10
        public void get_minHeight(){} // RVA: 0x7FFE80E42E10
        public void get_preferredHeight(){} // RVA: 0x7FFE80E42E10
        public void get_flexibleHeight(){} // RVA: 0x7FFE80E42E10
        public void get_layoutPriority(){} // RVA: 0x7FFE80E2EDB0
    }

    public class ILayoutGroup
    {
    }

    public class ILayoutIgnorer
    {
        // ── Methods ──
        public void get_ignoreLayout(){} // RVA: 0x7FFE80E2F150
    }

    public class ILayoutSelfController
    {
    }

    public class IMask
    {
        // ── Methods ──
        public void Enabled(){} // RVA: 0x7FFE80E2F150
        public void get_rectTransform(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IMaskable
    {
        // ── Methods ──
        public void RecalculateMasking(){} // RVA: 0x7FFE80E45FE0
    }

    public class IMaterialModifier
    {
        // ── Methods ──
        public void GetModifiedMaterial(){} // RVA: 0x7FFE80E2E390
    }

    public class IMeshModifier
    {
        // ── Methods ──
        public void ModifyMesh(){} // RVA: 0x7FFE80E460A0 | overloaded x2
    }

    public class IVertexModifier
    {
        // ── Methods ──
        public void ModifyVertices(){} // RVA: 0x7FFE80E460A0
    }

    public class Image : MaskableGraphic
    {
        public UnityEngine.Material s_ETC1DefaultUI;
        public UnityEngine.Sprite m_Sprite; // 0xE0
        public UnityEngine.Sprite m_OverrideSprite; // 0xE8
        public dFixup.ties m_Type; // 0xF0
        public bool m_PreserveAspect; // 0xF4
        public bool m_FillCenter; // 0xF5
        public 0x66643084 m_FillMethod; // 0xF8
        public float m_FillAmount; // 0xFC
        public bool m_FillClockwise; // 0x100
        public int m_FillOrigin; // 0x104
        public float m_AlphaHitTestMinimumThreshold; // 0x108
        public bool m_Tracked; // 0x10C
        public bool m_UseSpriteMesh; // 0x10D
        public float m_PixelsPerUnitMultiplier; // 0x110
        public float m_CachedReferencePixelsPerUnit; // 0x114
        public UnityEngine.Vector2[] s_VertScratch; // 0x8
        public UnityEngine.Vector2[] s_UVScratch; // 0x10
        public UnityEngine.Vector3[] s_Xy; // 0x18
        public UnityEngine.Vector3[] s_Uv; // 0x20
        public System.Collections.Generic.List`1<UnityEngine.UI.Image> m_TrackedTexturelessImages; // 0x28
        public bool s_Initialized; // 0x30
        public object field_21; // 0x4B
        public object field_22; // 0x4C
        public object field_23; // 0x4D
        public object field_24; // 0x4E
        public object field_25; // 0x4F
        public object field_26; // 0x50

        // ── Methods ──
        public void get_sprite(){} // RVA: 0x7FFE8117C900
        public void set_sprite(){} // RVA: 0x7FFE87E15C70
        public void DisableSpriteOptimizations(){} // RVA: 0x7FFE87E16410
        public void get_overrideSprite(){} // RVA: 0x7FFE87E16420
        public void set_overrideSprite(){} // RVA: 0x7FFE87E16430
        public void get_activeSprite(){} // RVA: 0x7FFE87E164B0
        public void get_type(){} // RVA: 0x7FFE843B5350
        public void set_type(){} // RVA: 0x7FFE87E165A0
        public void get_preserveAspect(){} // RVA: 0x7FFE8213E270
        public void set_preserveAspect(){} // RVA: 0x7FFE87E16610
        public void get_fillCenter(){} // RVA: 0x7FFE8213D240
        public void set_fillCenter(){} // RVA: 0x7FFE87E16680
        public void get_fillMethod(){} // RVA: 0x7FFE82144660
        public void set_fillMethod(){} // RVA: 0x7FFE87E166F0
        public void get_fillAmount(){} // RVA: 0x7FFE815ED8E0
        public void set_fillAmount(){} // RVA: 0x7FFE87E16770
        public void get_fillClockwise(){} // RVA: 0x7FFE81F84400
        public void set_fillClockwise(){} // RVA: 0x7FFE87E16800
        public void get_fillOrigin(){} // RVA: 0x7FFE82A184B0
        public void set_fillOrigin(){} // RVA: 0x7FFE87E16870
        public void get_eventAlphaThreshold(){} // RVA: 0x7FFE87E168E0
        public void set_eventAlphaThreshold(){} // RVA: 0x7FFE87E16900
        public void get_alphaHitTestMinimumThreshold(){} // RVA: 0x7FFE82BD1CD0
        public void set_alphaHitTestMinimumThreshold(){} // RVA: 0x7FFE87E16920
        public void get_useSpriteMesh(){} // RVA: 0x7FFE84A62120
        public void set_useSpriteMesh(){} // RVA: 0x7FFE87E16BF0
        public void .ctor(){} // RVA: 0x7FFE87E16C60
        public void get_defaultETC1GraphicMaterial(){} // RVA: 0x7FFE87E16CC0
        public void get_mainTexture(){} // RVA: 0x7FFE87E16EA0
        public void get_hasBorder(){} // RVA: 0x7FFE87E171B0
        public void get_pixelsPerUnitMultiplier(){} // RVA: 0x7FFE87E17340
        public void set_pixelsPerUnitMultiplier(){} // RVA: 0x7FFE87E17350
        public void get_pixelsPerUnit(){} // RVA: 0x7FFE87E17380
        public void get_multipliedPixelsPerUnit(){} // RVA: 0x7FFE87E175D0
        public void get_material(){} // RVA: 0x7FFE87E175F0
        public void set_material(){} // RVA: 0x7FFE87E178B0
        public void OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void OnAfterDeserialize(){} // RVA: 0x7FFE87E178C0
        public void PreserveSpriteAspectRatio(){} // RVA: 0x7FFE81843DC0
        public void GetDrawingDimensions(){} // RVA: 0x7FFE87E17930
        public void SetNativeSize(){} // RVA: 0x7FFE87E17E60
        public void OnPopulateMesh(){} // RVA: 0x7FFE87E18150
        public void TrackSprite(){} // RVA: 0x7FFE87E18310
        public void OnEnable(){} // RVA: 0x7FFE87E18670
        public void OnDisable(){} // RVA: 0x7FFE87E186D0
        public void UpdateMaterial(){} // RVA: 0x7FFE87E187B0
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFE87E18B80
        public void GenerateSimpleSprite(){} // RVA: 0x7FFE87E18D90
        public void GenerateSprite(){} // RVA: 0x7FFE87E19210
        public void GenerateSlicedSprite(){} // RVA: 0x7FFE87E19970
        public void GenerateTiledSprite(){} // RVA: 0x7FFE87E1A470
        public void AddQuad(){} // RVA: 0x7FFE818437F0 | overloaded x2
        public void GetAdjustedBorders(){} // RVA: 0x7FFE81843EB0
        public void GenerateFilledSprite(){} // RVA: 0x7FFE87E1BC30
        public void RadialCut(){} // RVA: 0x7FFE87E1D090 | overloaded x2
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFE810FB310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFE810FB310
        public void get_minWidth(){} // RVA: 0x7FFE8186F320
        public void get_preferredWidth(){} // RVA: 0x7FFE87E1D550
        public void get_flexibleWidth(){} // RVA: 0x7FFE878F7A90
        public void get_minHeight(){} // RVA: 0x7FFE8186F320
        public void get_preferredHeight(){} // RVA: 0x7FFE87E1D710
        public void get_flexibleHeight(){} // RVA: 0x7FFE878F7A90
        public void get_layoutPriority(){} // RVA: 0x7FFE813240E0
        public void IsRaycastLocationValid(){} // RVA: 0x7FFE87E1D8D0
        public void MapCoordinate(){} // RVA: 0x7FFE87E1DD70
        public void RebuildImage(){} // RVA: 0x7FFE87E1E480
        public void TrackImage(){} // RVA: 0x7FFE87E1E6F0
        public void UnTrackImage(){} // RVA: 0x7FFE87E1E860
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFE87E1E8F0
        public void .cctor(){} // RVA: 0x7FFE87E1E940
        public void <set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0(){} // RVA: 0x7FFE87E1ECD0
        public void <set_sprite>g__SpriteSupportsAlphaHitTest|11_1(){} // RVA: 0x7FFE87E1ED60
    }

    public class InputField : Selectable
    {
        public UnityEngine.TouchScreenKeyboard m_Keyboard; // 0x100
        public char[] kSeparators;
        public bool s_IsQuestDevice; // 0x8
        public bool s_IsPicoDevice; // 0x9
        public UnityEngine.UI.Text m_TextComponent; // 0x108
        public UnityEngine.UI.Graphic m_Placeholder; // 0x110
        public 0x6664339C m_ContentType; // 0x118
        public 0x666433F4 m_InputType; // 0x11C
        public char m_AsteriskChar; // 0x120
        public 0x66579C9C m_KeyboardType; // 0x124
        public 0x666434A4 m_LineType; // 0x128
        public bool m_HideMobileInput; // 0x12C
        public 0x6664344C m_CharacterValidation; // 0x130
        public int m_CharacterLimit; // 0x134
        public SubmitEvent m_OnSubmit; // 0x138
        public SubmitEvent m_OnEndEdit; // 0x140
        public EndEditEvent m_OnDidEndEdit; // 0x148
        public OnChangeEvent m_OnValueChanged; // 0x150
        public OnValidateInput m_OnValidateInput; // 0x158
        public UnityEngine.Color m_CaretColor; // 0x160
        public bool m_CustomCaretColor; // 0x170
        public UnityEngine.Color m_SelectionColor; // 0x174
        public string m_Text; // 0x188
        public float m_CaretBlinkRate; // 0x190
        public int m_CaretWidth; // 0x194
        public bool m_ReadOnly; // 0x198
        public bool m_ShouldActivateOnSelect; // 0x199
        public int m_CaretPosition; // 0x19C
        public int m_CaretSelectPosition; // 0x1A0
        public UnityEngine.RectTransform caretRectTrans; // 0x1A8
        public UnityEngine.UIVertex[] m_CursorVerts; // 0x1B0
        public UnityEngine.TextGenerator m_InputTextCache; // 0x1B8
        public UnityEngine.CanvasRenderer m_CachedInputRenderer; // 0x1C0
        public bool m_PreventFontCallback; // 0x1C8
        public UnityEngine.Mesh m_Mesh; // 0x1D0
        public bool m_AllowInput; // 0x1D8
        public bool m_ShouldActivateNextUpdate; // 0x1D9
        public bool m_UpdateDrag; // 0x1DA
        public bool m_DragPositionOutOfBounds; // 0x1DB
        public float kHScrollSpeed;
        public float kVScrollSpeed;
        public bool m_CaretVisible; // 0x1DC
        public UnityEngine.Coroutine m_BlinkCoroutine; // 0x1E0
        public float m_BlinkStartTime; // 0x1E8
        public int m_DrawStart; // 0x1EC

        // ── Methods ──
        public void get_input(){} // RVA: 0x7FFE87FE19D0
        public void get_compositionString(){} // RVA: 0x7FFE87FE1BC0
        public void .ctor(){} // RVA: 0x7FFE87FE1D10
        public void get_mesh(){} // RVA: 0x7FFE87FE21E0
        public void get_cachedInputTextGenerator(){} // RVA: 0x7FFE87FE2350
        public void set_shouldHideMobileInput(){} // RVA: 0x7FFE87FE2410
        public void get_shouldHideMobileInput(){} // RVA: 0x7FFE87FE2460
        public void set_shouldActivateOnSelect(){} // RVA: 0x7FFE86FECE30
        public void get_shouldActivateOnSelect(){} // RVA: 0x7FFE87FE2500
        public void get_text(){} // RVA: 0x7FFE81B295E0
        public void set_text(){} // RVA: 0x7FFE87FE25A0
        public void SetTextWithoutNotify(){} // RVA: 0x7FFE87FE25B0
        public void SetText(){} // RVA: 0x7FFE87FE25C0
        public void get_isFocused(){} // RVA: 0x7FFE82A2C670
        public void get_caretBlinkRate(){} // RVA: 0x7FFE87FE2AB0
        public void set_caretBlinkRate(){} // RVA: 0x7FFE87FE2AC0
        public void get_caretWidth(){} // RVA: 0x7FFE879EE3B0
        public void set_caretWidth(){} // RVA: 0x7FFE87FE2B30
        public void get_textComponent(){} // RVA: 0x7FFE8181E3D0
        public void set_textComponent(){} // RVA: 0x7FFE87FE2B90
        public void get_placeholder(){} // RVA: 0x7FFE81317980
        public void set_placeholder(){} // RVA: 0x7FFE87FE2F20
        public void get_caretColor(){} // RVA: 0x7FFE87FE2F80
        public void set_caretColor(){} // RVA: 0x7FFE87FE2FE0
        public void get_customCaretColor(){} // RVA: 0x7FFE81B42530
        public void set_customCaretColor(){} // RVA: 0x7FFE87FE3050
        public void get_selectionColor(){} // RVA: 0x7FFE87FE3070
        public void set_selectionColor(){} // RVA: 0x7FFE87FE3080
        public void get_onEndEdit(){} // RVA: 0x7FFE81166660
        public void set_onEndEdit(){} // RVA: 0x7FFE87FE30F0
        public void get_onSubmit(){} // RVA: 0x7FFE8181EA70
        public void set_onSubmit(){} // RVA: 0x7FFE87FE3150
        public void get_onValueChange(){} // RVA: 0x7FFE81790740
        public void set_onValueChange(){} // RVA: 0x7FFE87FE31B0
        public void get_onValueChanged(){} // RVA: 0x7FFE81790740
        public void set_onValueChanged(){} // RVA: 0x7FFE87FE31B0
        public void get_onValidateInput(){} // RVA: 0x7FFE81B16560
        public void set_onValidateInput(){} // RVA: 0x7FFE87FE3210
        public void get_characterLimit(){} // RVA: 0x7FFE8769D550
        public void set_characterLimit(){} // RVA: 0x7FFE87FE3270
        public void get_contentType(){} // RVA: 0x7FFE812BC010
        public void set_contentType(){} // RVA: 0x7FFE87FE3320
        public void get_lineType(){} // RVA: 0x7FFE86DBB070
        public void set_lineType(){} // RVA: 0x7FFE87FE34D0
        public void get_inputType(){} // RVA: 0x7FFE87EA3510
        public void set_inputType(){} // RVA: 0x7FFE87FE35C0
        public void get_touchScreenKeyboard(){} // RVA: 0x7FFE81828B50
        public void get_keyboardType(){} // RVA: 0x7FFE86C7E580
        public void set_keyboardType(){} // RVA: 0x7FFE87FE3630
        public void get_characterValidation(){} // RVA: 0x7FFE8162C320
        public void set_characterValidation(){} // RVA: 0x7FFE87FE36A0
        public void get_readOnly(){} // RVA: 0x7FFE86EE8260
        public void set_readOnly(){} // RVA: 0x7FFE86EE8270
        public void get_multiLine(){} // RVA: 0x7FFE87FE3710
        public void get_asteriskChar(){} // RVA: 0x7FFE87FE3730
        public void set_asteriskChar(){} // RVA: 0x7FFE87FE3740
        public void get_wasCanceled(){} // RVA: 0x7FFE86FECE80
        public void ClampPos(){} // RVA: 0x7FFE87FE37F0
        public void get_caretPositionInternal(){} // RVA: 0x7FFE87FE3830
        public void set_caretPositionInternal(){} // RVA: 0x7FFE87FE3860
        public void get_caretSelectPositionInternal(){} // RVA: 0x7FFE87FE38B0
        public void set_caretSelectPositionInternal(){} // RVA: 0x7FFE87FE38E0
        public void get_hasSelection(){} // RVA: 0x7FFE87FE3930
        public void get_caretPosition(){} // RVA: 0x7FFE87FE38B0
        public void set_caretPosition(){} // RVA: 0x7FFE87FE3990
        public void get_selectionAnchorPosition(){} // RVA: 0x7FFE87FE3830
        public void set_selectionAnchorPosition(){} // RVA: 0x7FFE87FE39C0
        public void get_selectionFocusPosition(){} // RVA: 0x7FFE87FE38B0
        public void set_selectionFocusPosition(){} // RVA: 0x7FFE87FE3A30
        public void OnBeforeSerialize(){} // RVA: 0x7FFE810FB310
        public void OnAfterDeserialize(){} // RVA: 0x7FFE87FE3AA0
        public void OnEnable(){} // RVA: 0x7FFE87FE3C00
        public void OnDisable(){} // RVA: 0x7FFE87FE3FF0
        public void OnDestroy(){} // RVA: 0x7FFE87FE4490
        public void CaretBlink(){} // RVA: 0x7FFE87FE44E0
        public void SetCaretVisible(){} // RVA: 0x7FFE87FE4580
        public void SetCaretActive(){} // RVA: 0x7FFE87FE4600
        public void UpdateCaretMaterial(){} // RVA: 0x7FFE87FE46F0
        public void OnFocus(){} // RVA: 0x7FFE87FE4920
        public void SelectAll(){} // RVA: 0x7FFE87FE4930
        public void MoveTextEnd(){} // RVA: 0x7FFE87FE49C0
        public void MoveTextStart(){} // RVA: 0x7FFE87FE4AE0
        public void get_clipboard(){} // RVA: 0x7FFE87FE4BD0
        public void set_clipboard(){} // RVA: 0x7FFE87FE4C50
        public void TouchScreenKeyboardShouldBeUsed(){} // RVA: 0x7FFE87FE4CE0
        public void InPlaceEditing(){} // RVA: 0x7FFE87FE4E00
        public void InPlaceEditingChanged(){} // RVA: 0x7FFE87FE4E30
        public void GetInternalSelection(){} // RVA: 0x7FFE87FE4EE0
        public void UpdateKeyboardCaret(){} // RVA: 0x7FFE87FE4FD0
        public void UpdateCaretFromKeyboard(){} // RVA: 0x7FFE87FE50E0
        public void LateUpdate(){} // RVA: 0x7FFE87FE5290
        public void ScreenToLocal(){} // RVA: 0x7FFE87FE5AD0
        public void GetUnclampedCharacterLineFromPosition(){} // RVA: 0x7FFE87FE62A0
        public void GetCharacterIndexFromPosition(){} // RVA: 0x7FFE87FE65A0
        public void MayDrag(){} // RVA: 0x7FFE87FE68B0
        public void OnBeginDrag(){} // RVA: 0x7FFE87FE6A10
        public void OnDrag(){} // RVA: 0x7FFE87FE6A40
        public void MouseDragOutsideRect(){} // RVA: 0x7FFE87FE6DF0
        public void OnEndDrag(){} // RVA: 0x7FFE87FE6EF0
        public void OnPointerDown(){} // RVA: 0x7FFE87FE6F20
        public void KeyPressed(){} // RVA: 0x7FFE87FE7210
        public void IsValidChar(){} // RVA: 0x7FFE87FE7820
        public void ProcessEvent(){} // RVA: 0x7FFE87FE7880
        public void OnUpdateSelected(){} // RVA: 0x7FFE87FE7890
        public void GetSelectedString(){} // RVA: 0x7FFE87FE7B20
        public void FindtNextWordBegin(){} // RVA: 0x7FFE87FE7C20
        public void MoveRight(){} // RVA: 0x7FFE87FE7D30
        public void FindtPrevWordBegin(){} // RVA: 0x7FFE87FE7FD0
        public void MoveLeft(){} // RVA: 0x7FFE87FE80D0
        public void DetermineCharacterLine(){} // RVA: 0x7FFE87FE8360
        public void LineUpCharacterPosition(){} // RVA: 0x7FFE87FE8500
        public void LineDownCharacterPosition(){} // RVA: 0x7FFE87FE87A0
        public void MoveDown(){} // RVA: 0x7FFE87FE8AD0 | overloaded x2
        public void MoveUp(){} // RVA: 0x7FFE87FE8D00 | overloaded x2
        public void Delete(){} // RVA: 0x7FFE87FE8EE0
        public void ForwardSpace(){} // RVA: 0x7FFE87FE91A0
        public void Backspace(){} // RVA: 0x7FFE87FE92B0
        public void Insert(){} // RVA: 0x7FFE87FE9430
        public void UpdateTouchKeyboardFromEditChanges(){} // RVA: 0x7FFE87FE9660
        public void SendOnValueChangedAndUpdateLabel(){} // RVA: 0x7FFE87FE96C0
        public void SendOnValueChanged(){} // RVA: 0x7FFE87FE96E0
        public void SendOnEndEdit(){} // RVA: 0x7FFE87FE97A0
        public void SendOnSubmit(){} // RVA: 0x7FFE87FE9860
        public void Append(){} // RVA: 0x7FFE87FE9A00 | overloaded x2
        public void UpdateLabel(){} // RVA: 0x7FFE87FE9D90
        public void IsSelectionVisible(){} // RVA: 0x7FFE87FEA550
        public void GetLineStartPosition(){} // RVA: 0x7FFE87FEA620
        public void GetLineEndPosition(){} // RVA: 0x7FFE87FEA750
        public void SetDrawRangeToContainCaretPosition(){} // RVA: 0x7FFE87FEA8D0
        public void ForceLabelUpdate(){} // RVA: 0x7FFE87FEB2F0
        public void MarkGeometryAsDirty(){} // RVA: 0x7FFE87FEB300
        public void Rebuild(){} // RVA: 0x7FFE87FEB3A0
        public void LayoutComplete(){} // RVA: 0x7FFE810FB310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFE810FB310
        public void UpdateGeometry(){} // RVA: 0x7FFE87FEB3B0
        public void AssignPositioningIfNeeded(){} // RVA: 0x7FFE87FEBA20
        public void OnFillVBO(){} // RVA: 0x7FFE87FEC510
        public void GenerateCaret(){} // RVA: 0x7FFE87FEC720
        public void CreateCursorVerts(){} // RVA: 0x7FFE87FED4F0
        public void GenerateHighlight(){} // RVA: 0x7FFE87FED700
        public void Validate(){} // RVA: 0x7FFE87FEDFA0
        public void ActivateInputField(){} // RVA: 0x7FFE87FEE680
        public void ActivateInputFieldInternal(){} // RVA: 0x7FFE87FEE8B0
        public void OnSelect(){} // RVA: 0x7FFE87FEF0F0
        public void OnPointerClick(){} // RVA: 0x7FFE87FEF140
        public void DeactivateInputField(){} // RVA: 0x7FFE87FEF170
        public void OnDeselect(){} // RVA: 0x7FFE87FEF510
        public void OnSubmit(){} // RVA: 0x7FFE87FEF540
        public void EnforceContentType(){} // RVA: 0x7FFE87FEF590
        public void EnforceTextHOverflow(){} // RVA: 0x7FFE87FEF700
        public void SetToCustomIfContentTypeIsNot(){} // RVA: 0x7FFE87FEF860
        public void SetToCustom(){} // RVA: 0x7FFE87FEF8D0
        public void DoStateTransition(){} // RVA: 0x7FFE87FEF8F0
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFE810FB310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFE810FB310
        public void get_minWidth(){} // RVA: 0x7FFE87FEF920
        public void get_preferredWidth(){} // RVA: 0x7FFE87FEF930
        public void get_flexibleWidth(){} // RVA: 0x7FFE878F7A90
        public void get_minHeight(){} // RVA: 0x7FFE8186F320
        public void get_preferredHeight(){} // RVA: 0x7FFE87FEFB90
        public void get_flexibleHeight(){} // RVA: 0x7FFE878F7A90
        public void get_layoutPriority(){} // RVA: 0x7FFE811EDAF0
        public void .cctor(){} // RVA: 0x7FFE87FEFE30
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFE816315C0
    }

    public class LayoutElement : UIBehaviour
    {
        public bool m_IgnoreLayout; // 0x20
        public float m_MinWidth; // 0x24
        public float m_MinHeight; // 0x28
        public float m_PreferredWidth; // 0x2C
        public float m_PreferredHeight; // 0x30
        public float m_FlexibleWidth; // 0x34
        public float m_FlexibleHeight; // 0x38
        public int m_LayoutPriority; // 0x3C

        // ── Methods ──
        public void get_ignoreLayout(){} // RVA: 0x7FFE811E99D0
        public void set_ignoreLayout(){} // RVA: 0x7FFE87FF4A20
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFE810FB310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFE810FB310
        public void get_minWidth(){} // RVA: 0x7FFE81268F50
        public void set_minWidth(){} // RVA: 0x7FFE87FF4A80
        public void get_minHeight(){} // RVA: 0x7FFE811DA210
        public void set_minHeight(){} // RVA: 0x7FFE87FF4AE0
        public void get_preferredWidth(){} // RVA: 0x7FFE812846C0
        public void set_preferredWidth(){} // RVA: 0x7FFE87FF4B40
        public void get_preferredHeight(){} // RVA: 0x7FFE81284640
        public void set_preferredHeight(){} // RVA: 0x7FFE87FF4BA0
        public void get_flexibleWidth(){} // RVA: 0x7FFE811C5630
        public void set_flexibleWidth(){} // RVA: 0x7FFE87FF4C00
        public void get_flexibleHeight(){} // RVA: 0x7FFE8130ACF0
        public void set_flexibleHeight(){} // RVA: 0x7FFE87FF4C60
        public void get_layoutPriority(){} // RVA: 0x7FFE816311C0
        public void set_layoutPriority(){} // RVA: 0x7FFE87FF4CC0
        public void .ctor(){} // RVA: 0x7FFE87FF4D20
        public void OnEnable(){} // RVA: 0x7FFE87FF4DA0
        public void OnTransformParentChanged(){} // RVA: 0x7FFE87FF4DA0
        public void OnDisable(){} // RVA: 0x7FFE87FF4DA0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFE87FF4DA0
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7FFE87FF4DA0
        public void SetDirty(){} // RVA: 0x7FFE87FF4DB0
    }

    public class LayoutGroup : UIBehaviour
    {
        public UnityEngine.RectOffset m_Padding; // 0x20
        public 0x666D315C m_ChildAlignment; // 0x28
        public UnityEngine.RectTransform m_Rect; // 0x30
        public UnityEngine.DrivenRectTransformTracker m_Tracker; // 0x38
        public UnityEngine.Vector2 m_TotalMinSize; // 0x3C
        public UnityEngine.Vector2 m_TotalPreferredSize; // 0x44
        public UnityEngine.Vector2 m_TotalFlexibleSize; // 0x4C
        public System.Collections.Generic.List`1<UnityEngine.RectTransform> m_RectChildren; // 0x58
        public object field_8; // 0xC6
        public object field_9; // 0xC7
        public object field_10; // 0xC8
        public object field_11; // 0xC9

        // ── Methods ──
        public void get_padding(){} // RVA: 0x7FFE811290C0
        public void set_padding(){} // RVA: 0x7FFE87FF4E90
        public void get_childAlignment(){} // RVA: 0x7FFE81549710
        public void set_childAlignment(){} // RVA: 0x7FFE87FF4F60
        public void get_rectTransform(){} // RVA: 0x7FFE87FF4FB0
        public void get_rectChildren(){} // RVA: 0x7FFE811C3500
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFE87FF50F0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFE80E45FE0
        public void get_minWidth(){} // RVA: 0x7FFE87AC4CB0
        public void get_preferredWidth(){} // RVA: 0x7FFE87D2FEE0
        public void get_flexibleWidth(){} // RVA: 0x7FFE87DA2AC0
        public void get_minHeight(){} // RVA: 0x7FFE87CE83D0
        public void get_preferredHeight(){} // RVA: 0x7FFE87DA2AB0
        public void get_flexibleHeight(){} // RVA: 0x7FFE87DA2AD0
        public void get_layoutPriority(){} // RVA: 0x7FFE813240E0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFE80E45FE0
        public void SetLayoutVertical(){} // RVA: 0x7FFE80E45FE0
        public void .ctor(){} // RVA: 0x7FFE87FF5530
        public void OnEnable(){} // RVA: 0x7FFE87FF5860
        public void OnDisable(){} // RVA: 0x7FFE87FF5870
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFE87FF5860
        public void GetTotalMinSize(){} // RVA: 0x7FFE87FF58D0
        public void GetTotalPreferredSize(){} // RVA: 0x7FFE87FF58E0
        public void GetTotalFlexibleSize(){} // RVA: 0x7FFE87FF58F0
        public void GetStartOffset(){} // RVA: 0x7FFE87FF5900
        public void GetAlignmentOnAxis(){} // RVA: 0x7FFE87FF5BB0
        public void SetLayoutInputForAxis(){} // RVA: 0x7FFE87FF5C00
        public void SetChildAlongAxis(){} // RVA: 0x7FFE87FF60A0 | overloaded x2
        public void SetChildAlongAxisWithScale(){} // RVA: 0x7FFE87FF61C0 | overloaded x2
        public void get_isRootLayoutGroup(){} // RVA: 0x7FFE87FF65C0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFE87FF68C0
        public void OnTransformChildrenChanged(){} // RVA: 0x7FFE87FF5860
        public void SetProperty(){} // RVA: 0x7FFE810A1420
        public void SetDirty(){} // RVA: 0x7FFE87FF68F0
        public void DelayedSetDirty(){} // RVA: 0x7FFE87FF6A90
    }

    public class LayoutRebuilder : Object
    {
        public UnityEngine.RectTransform m_ToRebuild; // 0x10

        // ── Methods ──
        public void Initialize(){} // RVA: 0x7FFE87FF6C40
        public void Clear(){} // RVA: 0x7FFE87FF6CC0
        public void .cctor(){} // RVA: 0x7FFE87FF6D20
        public void ReapplyDrivenProperties(){} // RVA: 0x7FFE87FF7250
        public void get_transform(){} // RVA: 0x7FFE81116380
        public void IsDestroyed(){} // RVA: 0x7FFE87FF72A0
        public void StripDisabledBehavioursFromList(){} // RVA: 0x7FFE87FF7370
        public void ForceRebuildLayoutImmediate(){} // RVA: 0x7FFE87FF74E0
        public void Rebuild(){} // RVA: 0x7FFE87FF7630
        public void VRC_RegisterCachedLayoutTree(){} // RVA: 0x7FFE87FF7AB0
        public void VRC_UnregisterCachedLayoutTree(){} // RVA: 0x7FFE87FF7EA0
        public void PerformLayoutControl(){} // RVA: 0x7FFE87FF7FC0
        public void PerformLayoutCalculation(){} // RVA: 0x7FFE87FF8780
        public void MarkLayoutForRebuild(){} // RVA: 0x7FFE87FF8D80
        public void ValidController(){} // RVA: 0x7FFE87FF9500
        public void MarkLayoutRootForRebuild(){} // RVA: 0x7FFE87FF98B0
        public void LayoutComplete(){} // RVA: 0x7FFE87FF9B30
        public void GraphicUpdateComplete(){} // RVA: 0x7FFE810FB310
        public void GetHashCode(){} // RVA: 0x7FFE813DB630
        public void Equals(){} // RVA: 0x7FFE87FF9BC0
        public void ToString(){} // RVA: 0x7FFE87FF9C20
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class LayoutUtility : Object
    {
        // ── Methods ──
        public void GetMinSize(){} // RVA: 0x7FFE87FFA080
        public void GetPreferredSize(){} // RVA: 0x7FFE87FFA0A0
        public void GetFlexibleSize(){} // RVA: 0x7FFE87FFA0C0
        public void GetMinWidth(){} // RVA: 0x7FFE87FFA0E0
        public void GetPreferredWidth(){} // RVA: 0x7FFE87FFA240
        public void GetFlexibleWidth(){} // RVA: 0x7FFE87FFA4F0
        public void GetMinHeight(){} // RVA: 0x7FFE87FFA650
        public void GetPreferredHeight(){} // RVA: 0x7FFE87FFA7B0
        public void GetFlexibleHeight(){} // RVA: 0x7FFE87FFAA60
        public void GetLayoutProperty(){} // RVA: 0x7FFE87FFABE0 | overloaded x2
    }

    public class Mask : UIBehaviour
    {
        public UnityEngine.RectTransform m_RectTransform; // 0x20
        public bool m_ShowMaskGraphic; // 0x28
        public UnityEngine.UI.Graphic m_Graphic; // 0x30

        // ── Methods ──
        public void get_rectTransform(){} // RVA: 0x7FFE87FFB340
        public void get_showMaskGraphic(){} // RVA: 0x7FFE815F1380
        public void set_showMaskGraphic(){} // RVA: 0x7FFE87FFB3E0
        public void get_graphic(){} // RVA: 0x7FFE87FFB4F0
        public void .ctor(){} // RVA: 0x7FFE81132BB0
        public void MaskEnabled(){} // RVA: 0x7FFE87FFB590
        public void OnSiblingGraphicEnabledDisabled(){} // RVA: 0x7FFE810FB310
        public void OnEnable(){} // RVA: 0x7FFE87FFB690
        public void OnDisable(){} // RVA: 0x7FFE87FFB8D0
        public void IsRaycastLocationValid(){} // RVA: 0x7FFE87FFBC90
        public void GetModifiedMaterial(){} // RVA: 0x7FFE87FFBD70
    }

    public class MaskUtilities : Object
    {
        // ── Methods ──
        public void Notify2DMaskStateChanged(){} // RVA: 0x7FFE87FFD760
        public void NotifyStencilStateChanged(){} // RVA: 0x7FFE87FFDAE0
        public void FindRootSortOverrideCanvas(){} // RVA: 0x7FFE87FFDE60
        public void GetStencilDepth(){} // RVA: 0x7FFE87FFE100
        public void IsDescendantOrSelf(){} // RVA: 0x7FFE87FFE5D0
        public void GetRectMaskForClippable(){} // RVA: 0x7FFE87FFE9C0
        public void GetRectMasksForClip(){} // RVA: 0x7FFE87FFEE30
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class MaskableGraphic : Graphic
    {
        public bool m_ShouldRecalculateStencil; // 0xA8
        public UnityEngine.Material m_MaskMaterial; // 0xB0
        public UnityEngine.UI.RectMask2D m_ParentMask; // 0xB8
        public bool m_Maskable; // 0xC0

        // ── Methods ──
        public void get_onCullStateChanged(){} // RVA: 0x7FFE81253460
        public void set_onCullStateChanged(){} // RVA: 0x7FFE81253470
        public void get_maskable(){} // RVA: 0x7FFE8111C4C0
        public void set_maskable(){} // RVA: 0x7FFE87FFC140
        public void get_isMaskingGraphic(){} // RVA: 0x7FFE87413F50
        public void set_isMaskingGraphic(){} // RVA: 0x7FFE87FFC170
        public void GetModifiedMaterial(){} // RVA: 0x7FFE87FFC180
        public void Cull(){} // RVA: 0x7FFE87FFC390
        public void UpdateCull(){} // RVA: 0x7FFE87FFC3F0
        public void SetClipRect(){} // RVA: 0x7FFE87FFC590
        public void SetClipSoftness(){} // RVA: 0x7FFE87FFC680
        public void OnEnable(){} // RVA: 0x7FFE87FFC700
        public void OnDisable(){} // RVA: 0x7FFE87FFC760
        public void OnTransformParentChanged(){} // RVA: 0x7FFE87FFC860
        public void ParentMaskStateChanged(){} // RVA: 0x7FFE810FB310
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFE87FFC9D0
        public void get_rootCanvasRect(){} // RVA: 0x7FFE87FFCA60
        public void UpdateClipParent(){} // RVA: 0x7FFE87FFCFC0
        public void RecalculateClipping(){} // RVA: 0x7FFE87AD36C0
        public void RecalculateMasking(){} // RVA: 0x7FFE87FFD310
        public void .ctor(){} // RVA: 0x7FFE87FFD3F0
        public void UnityEngine.UI.IClippable.get_gameObject(){} // RVA: 0x7FFE81631490
    }

    public class Misc : Object
    {
        // ── Methods ──
        public void Destroy(){} // RVA: 0x7FFE87FFF220
        public void DestroyImmediate(){} // RVA: 0x7FFE87FFF3F0
    }

    public class MultipleDisplayUtilities : Object
    {
        // ── Methods ──
        public void GetRelativeMousePositionForDrag(){} // RVA: 0x7FFE87FFF500
        public void GetRelativeMousePositionForRaycast(){} // RVA: 0x7FFE87FFF5E0
        public void RelativeMouseAtScaled(){} // RVA: 0x7FFE87FFF710
    }

    public class Navigation : ValueType
    {
        public 0x6664436C m_Mode; // 0x10
        public bool m_WrapAround; // 0x14
        public UnityEngine.UI.Selectable m_SelectOnUp; // 0x18
        public UnityEngine.UI.Selectable m_SelectOnDown; // 0x20
        public UnityEngine.UI.Selectable m_SelectOnLeft; // 0x28
        public UnityEngine.UI.Selectable m_SelectOnRight; // 0x30
        public UnityEngine.Color m_NormalColor; // 0x10

        // ── Methods ──
        public void get_mode(){} // RVA: 0x7FFE826F4220
        public void set_mode(){} // RVA: 0x7FFE815BF990
        public void get_wrapAround(){} // RVA: 0x7FFE82C770F0
        public void set_wrapAround(){} // RVA: 0x7FFE81E63F40
        public void get_selectOnUp(){} // RVA: 0x7FFE826F4210
        public void set_selectOnUp(){} // RVA: 0x7FFE826F4230
        public void get_selectOnDown(){} // RVA: 0x7FFE81116380
        public void set_selectOnDown(){} // RVA: 0x7FFE810FCE30
        public void get_selectOnLeft(){} // RVA: 0x7FFE810FE7C0
        public void set_selectOnLeft(){} // RVA: 0x7FFE81161E80
        public void get_selectOnRight(){} // RVA: 0x7FFE811290C0
        public void set_selectOnRight(){} // RVA: 0x7FFE811290D0
        public void get_defaultNavigation(){} // RVA: 0x7FFE88000040
        public void Equals(){} // RVA: 0x7FFE88000060
    }

    public class Outline : Shadow
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8801DCF0
        public void ModifyMesh(){} // RVA: 0x7FFE8801DD60
    }

    public class PositionAsUV1 : BaseMeshEffect
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void ModifyMesh(){} // RVA: 0x7FFE8801E090
    }

    public class RawImage : MaskableGraphic
    {
        public UnityEngine.Texture m_Texture; // 0xE0
        public UnityEngine.Rect m_UVRect; // 0xE8
        public object field_2; // 0xE3

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88000440
        public void get_mainTexture(){} // RVA: 0x7FFE88000470
        public void get_texture(){} // RVA: 0x7FFE8117C900
        public void set_texture(){} // RVA: 0x7FFE88000730
        public void get_uvRect(){} // RVA: 0x7FFE86DDD560
        public void set_uvRect(){} // RVA: 0x7FFE880008E0
        public void SetNativeSize(){} // RVA: 0x7FFE88000950
        public void OnPopulateMesh(){} // RVA: 0x7FFE88000BA0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFE87E1E8F0
    }

    public class RectMask2D : UIBehaviour
    {
        public UnityEngine.UI.RectangularVertexClipper m_VertexClipper; // 0x20
        public UnityEngine.RectTransform m_RectTransform; // 0x28
        public System.Collections.Generic.HashSet`1<UnityEngine.UI.MaskableGraphic> m_MaskableTargets; // 0x30
        public System.Collections.Generic.HashSet`1<UnityEngine.UI.IClippable> m_ClipTargets; // 0x38
        public bool m_ShouldRecalculateClipRects; // 0x40
        public System.Collections.Generic.List`1<UnityEngine.UI.RectMask2D> m_Clippers; // 0x48

        // ── Methods ──
        public void get_padding(){} // RVA: 0x7FFE8120BE00
        public void set_padding(){} // RVA: 0x7FFE88001030
        public void get_softness(){} // RVA: 0x7FFE86F03330
        public void set_softness(){} // RVA: 0x7FFE88001040
        public void get_Canvas(){} // RVA: 0x7FFE88001070
        public void get_canvasRect(){} // RVA: 0x7FFE88001370
        public void get_rectTransform(){} // RVA: 0x7FFE880013F0
        public void .ctor(){} // RVA: 0x7FFE88001490
        public void OnEnable(){} // RVA: 0x7FFE88001890
        public void OnDisable(){} // RVA: 0x7FFE88001900
        public void OnDestroy(){} // RVA: 0x7FFE87DFE060
        public void IsRaycastLocationValid(){} // RVA: 0x7FFE88001A90
        public void get_rootCanvasRect(){} // RVA: 0x7FFE88001BA0
        public void PerformClipping(){} // RVA: 0x7FFE88001E30
        public void UpdateClipSoftness(){} // RVA: 0x7FFE880029C0
        public void AddClippable(){} // RVA: 0x7FFE88002D80
        public void RemoveClippable(){} // RVA: 0x7FFE88002F30
        public void OnTransformParentChanged(){} // RVA: 0x7FFE880030E0
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFE880030E0
    }

    public class RectangularVertexClipper : Object
    {
        // ── Methods ──
        public void GetCanvasRect(){} // RVA: 0x7FFE87DFE4B0
        public void .ctor(){} // RVA: 0x7FFE87DFE750
    }

    public class ReflectionMethodsCache : Object
    {
        public Raycast3DCallback raycast3D; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE880188C0
        public void get_Singleton(){} // RVA: 0x7FFE8801A230
    }

    public class ScrollRect : UIBehaviour
    {
        public UnityEngine.RectTransform m_Content; // 0x20
        public bool m_Horizontal; // 0x28
        public bool m_Vertical; // 0x29
        public 0x66644684 m_MovementType; // 0x2C
        public float m_Elasticity; // 0x30
        public bool m_Inertia; // 0x34
        public float m_DecelerationRate; // 0x38
        public float m_ScrollSensitivity; // 0x3C
        public UnityEngine.RectTransform m_Viewport; // 0x40
        public UnityEngine.UI.Scrollbar m_HorizontalScrollbar; // 0x48
        public UnityEngine.UI.Scrollbar m_VerticalScrollbar; // 0x50
        public dFixup. m_HorizontalScrollbarVisibility; // 0x58
        public dFixup. m_VerticalScrollbarVisibility; // 0x5C
        public float m_HorizontalScrollbarSpacing; // 0x60
        public float m_VerticalScrollbarSpacing; // 0x64
        public ScrollRectEvent m_OnValueChanged; // 0x68
        public UnityEngine.Vector2 m_PointerStartLocalCursor; // 0x70
        public UnityEngine.Vector2 m_ContentStartPosition; // 0x78
        public UnityEngine.RectTransform m_ViewRect; // 0x80
        public UnityEngine.Bounds m_ContentBounds; // 0x88
        public UnityEngine.Bounds m_ViewBounds; // 0xA0
        public UnityEngine.Vector2 m_Velocity; // 0xB8
        public bool m_Dragging; // 0xC0
        public bool m_Scrolling; // 0xC1
        public UnityEngine.Vector2 m_PrevPosition; // 0xC4
        public UnityEngine.Bounds m_PrevContentBounds; // 0xCC
        public UnityEngine.Bounds m_PrevViewBounds; // 0xE4
        public bool m_HasRebuiltLayout; // 0xFC
        public bool m_HSliderExpand; // 0xFD
        public bool m_VSliderExpand; // 0xFE
        public float m_HSliderHeight; // 0x100

        // ── Methods ──
        public void get_content(){} // RVA: 0x7FFE811290C0
        public void set_content(){} // RVA: 0x7FFE811290D0
        public void get_horizontal(){} // RVA: 0x7FFE815F1380
        public void set_horizontal(){} // RVA: 0x7FFE81C15740
        public void get_vertical(){} // RVA: 0x7FFE819C2EA0
        public void set_vertical(){} // RVA: 0x7FFE8268C820
        public void get_movementType(){} // RVA: 0x7FFE81F84A50
        public void set_movementType(){} // RVA: 0x7FFE82883A50
        public void get_elasticity(){} // RVA: 0x7FFE81284640
        public void set_elasticity(){} // RVA: 0x7FFE81308960
        public void get_inertia(){} // RVA: 0x7FFE81131C20
        public void set_inertia(){} // RVA: 0x7FFE81135AC0
        public void get_decelerationRate(){} // RVA: 0x7FFE8130ACF0
        public void set_decelerationRate(){} // RVA: 0x7FFE8130A000
        public void get_scrollSensitivity(){} // RVA: 0x7FFE8178C5D0
        public void set_scrollSensitivity(){} // RVA: 0x7FFE8178C310
        public void get_viewport(){} // RVA: 0x7FFE81178740
        public void set_viewport(){} // RVA: 0x7FFE88005860
        public void get_horizontalScrollbar(){} // RVA: 0x7FFE81176730
        public void set_horizontalScrollbar(){} // RVA: 0x7FFE880058C0
        public void get_verticalScrollbar(){} // RVA: 0x7FFE8119C0E0
        public void set_verticalScrollbar(){} // RVA: 0x7FFE88005BB0
        public void get_horizontalScrollbarVisibility(){} // RVA: 0x7FFE8175AC90
        public void set_horizontalScrollbarVisibility(){} // RVA: 0x7FFE88005EA0
        public void get_verticalScrollbarVisibility(){} // RVA: 0x7FFE813A7A20
        public void set_verticalScrollbarVisibility(){} // RVA: 0x7FFE88005EB0
        public void get_horizontalScrollbarSpacing(){} // RVA: 0x7FFE8120BE10
        public void set_horizontalScrollbarSpacing(){} // RVA: 0x7FFE88005EC0
        public void get_verticalScrollbarSpacing(){} // RVA: 0x7FFE81124040
        public void set_verticalScrollbarSpacing(){} // RVA: 0x7FFE88005ED0
        public void get_onValueChanged(){} // RVA: 0x7FFE81176D50
        public void set_onValueChanged(){} // RVA: 0x7FFE81176D60
        public void get_viewRect(){} // RVA: 0x7FFE88005EE0
        public void get_velocity(){} // RVA: 0x7FFE880061C0
        public void set_velocity(){} // RVA: 0x7FFE82904810
        public void get_rectTransform(){} // RVA: 0x7FFE880061E0
        public void .ctor(){} // RVA: 0x7FFE88006330
        public void Rebuild(){} // RVA: 0x7FFE88006580
        public void LayoutComplete(){} // RVA: 0x7FFE810FB310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFE810FB310
        public void UpdateCachedData(){} // RVA: 0x7FFE88006610
        public void OnEnable(){} // RVA: 0x7FFE880071E0
        public void OnDisable(){} // RVA: 0x7FFE880074D0
        public void IsActive(){} // RVA: 0x7FFE88007850
        public void EnsureLayoutHasRebuilt(){} // RVA: 0x7FFE88007970
        public void StopMovement(){} // RVA: 0x7FFE88007A20
        public void OnScroll(){} // RVA: 0x7FFE88007A80
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFE88007C90
        public void OnBeginDrag(){} // RVA: 0x7FFE88007D00
        public void OnEndDrag(){} // RVA: 0x7FFE88007E60
        public void OnDrag(){} // RVA: 0x7FFE88007E90
        public void SetContentAnchoredPosition(){} // RVA: 0x7FFE880080F0
        public void LateUpdate(){} // RVA: 0x7FFE880082A0
        public void UpdatePrevData(){} // RVA: 0x7FFE88008E20
        public void UpdateScrollbars(){} // RVA: 0x7FFE88008FB0
        public void get_normalizedPosition(){} // RVA: 0x7FFE88009290
        public void set_normalizedPosition(){} // RVA: 0x7FFE880092D0
        public void get_horizontalNormalizedPosition(){} // RVA: 0x7FFE88009330
        public void set_horizontalNormalizedPosition(){} // RVA: 0x7FFE88009440
        public void get_verticalNormalizedPosition(){} // RVA: 0x7FFE88009460
        public void set_verticalNormalizedPosition(){} // RVA: 0x7FFE88009580
        public void SetHorizontalNormalizedPosition(){} // RVA: 0x7FFE88009440
        public void SetVerticalNormalizedPosition(){} // RVA: 0x7FFE88009580
        public void SetNormalizedPosition(){} // RVA: 0x7FFE880095A0
        public void RubberDelta(){} // RVA: 0x7FFE88009B20
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFE88009B80
        public void get_hScrollingNeeded(){} // RVA: 0x7FFE88009B90
        public void get_vScrollingNeeded(){} // RVA: 0x7FFE88009C50
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFE810FB310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFE810FB310
        public void get_minWidth(){} // RVA: 0x7FFE878F7A90
        public void get_preferredWidth(){} // RVA: 0x7FFE878F7A90
        public void get_flexibleWidth(){} // RVA: 0x7FFE878F7A90
        public void get_minHeight(){} // RVA: 0x7FFE878F7A90
        public void get_preferredHeight(){} // RVA: 0x7FFE878F7A90
        public void get_flexibleHeight(){} // RVA: 0x7FFE878F7A90
        public void get_layoutPriority(){} // RVA: 0x7FFE81517DA0
        public void SetLayoutHorizontal(){} // RVA: 0x7FFE88009D10
        public void SetLayoutVertical(){} // RVA: 0x7FFE8800A6A0
        public void UpdateScrollbarVisibility(){} // RVA: 0x7FFE8800A870
        public void UpdateOneScrollbarVisibility(){} // RVA: 0x7FFE8800A8D0
        public void UpdateScrollbarLayout(){} // RVA: 0x7FFE8800AB30
        public void UpdateBounds(){} // RVA: 0x7FFE8800AFB0
        public void AdjustBounds(){} // RVA: 0x7FFE8800B6E0
        public void GetBounds(){} // RVA: 0x7FFE8800B790
        public void InternalGetBounds(){} // RVA: 0x7FFE8800B990
        public void CalculateOffset(){} // RVA: 0x7FFE8800BC30
        public void InternalCalculateOffset(){} // RVA: 0x7FFE8800BC80
        public void SetDirty(){} // RVA: 0x7FFE8800BE40
        public void SetDirtyCaching(){} // RVA: 0x7FFE8800BEC0
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFE816315C0
    }

    public class Scrollbar : Selectable
    {
        public UnityEngine.RectTransform m_HandleRect; // 0x100
        public 0x666444CC m_Direction; // 0x108
        public float m_Value; // 0x10C
        public float m_Size; // 0x110
        public int m_NumberOfSteps; // 0x114
        public ScrollEvent m_OnValueChanged; // 0x118
        public UnityEngine.RectTransform m_ContainerRect; // 0x120
        public UnityEngine.Vector2 m_Offset; // 0x128
        public UnityEngine.DrivenRectTransformTracker m_Tracker; // 0x130

        // ── Methods ──
        public void get_handleRect(){} // RVA: 0x7FFE81828B50
        public void set_handleRect(){} // RVA: 0x7FFE88003150
        public void get_direction(){} // RVA: 0x7FFE8285FF20
        public void set_direction(){} // RVA: 0x7FFE880031C0
        public void .ctor(){} // RVA: 0x7FFE88003220
        public void get_value(){} // RVA: 0x7FFE88003350
        public void set_value(){} // RVA: 0x7FFE880033B0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE880033C0
        public void get_size(){} // RVA: 0x7FFE87E17340
        public void set_size(){} // RVA: 0x7FFE880033D0
        public void get_numberOfSteps(){} // RVA: 0x7FFE87AEDA80
        public void set_numberOfSteps(){} // RVA: 0x7FFE88003450
        public void get_onValueChanged(){} // RVA: 0x7FFE81318010
        public void set_onValueChanged(){} // RVA: 0x7FFE81317920
        public void get_stepSize(){} // RVA: 0x7FFE880034C0
        public void Rebuild(){} // RVA: 0x7FFE810FB310
        public void LayoutComplete(){} // RVA: 0x7FFE810FB310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFE810FB310
        public void OnEnable(){} // RVA: 0x7FFE880034F0
        public void OnDisable(){} // RVA: 0x7FFE88003530
        public void Update(){} // RVA: 0x7FFE88003540
        public void UpdateCachedReferences(){} // RVA: 0x7FFE88003560
        public void Set(){} // RVA: 0x7FFE88003880
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFE880039C0
        public void get_axis(){} // RVA: 0x7FFE88003A00
        public void get_reverseValue(){} // RVA: 0x7FFE88003A20
        public void UpdateVisuals(){} // RVA: 0x7FFE88003A40
        public void UpdateDrag(){} // RVA: 0x7FFE88003D80
        public void DoUpdateDrag(){} // RVA: 0x7FFE88004230
        public void MayDrag(){} // RVA: 0x7FFE880042F0
        public void OnBeginDrag(){} // RVA: 0x7FFE88004360
        public void OnDrag(){} // RVA: 0x7FFE880046A0
        public void OnPointerDown(){} // RVA: 0x7FFE880047E0
        public void ClickRepeat(){} // RVA: 0x7FFE88004990 | overloaded x2
        public void OnPointerUp(){} // RVA: 0x7FFE88004AC0
        public void OnMove(){} // RVA: 0x7FFE88004B00
        public void FindSelectableOnLeft(){} // RVA: 0x7FFE880051B0
        public void FindSelectableOnRight(){} // RVA: 0x7FFE880051E0
        public void FindSelectableOnUp(){} // RVA: 0x7FFE88005210
        public void FindSelectableOnDown(){} // RVA: 0x7FFE88005240
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFE8186BE90
        public void SetDirection(){} // RVA: 0x7FFE88005270
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFE816315C0
    }

    public class Selectable : UIBehaviour
    {
        public UnityEngine.UI.Selectable[] s_Selectables;
        public int s_SelectableCount; // 0x8
        public bool m_EnableCalled; // 0x20
        public UnityEngine.UI.Navigation m_Navigation; // 0x28
        public 0x666447E4 m_Transition; // 0x50
        public UnityEngine.UI.ColorBlock m_Colors; // 0x54
        public UnityEngine.UI.SpriteState m_SpriteState; // 0xB0
        public UnityEngine.UI.AnimationTriggers m_AnimationTriggers; // 0xD0
        public bool m_Interactable; // 0xD8
        public UnityEngine.UI.Graphic m_TargetGraphic; // 0xE0
        public bool m_GroupsAllowInteraction; // 0xE8
        public int m_CurrentIndex; // 0xEC
        public bool _isPointerInside; // 0xF0
        public bool _isPointerDown; // 0xF1
        public bool _hasSelection; // 0xF2
        public System.Collections.Generic.List`1<UnityEngine.CanvasGroup> m_CanvasGroupCache; // 0xF8

        // ── Methods ──
        public void get_allSelectablesArray(){} // RVA: 0x7FFE8800C060
        public void get_allSelectableCount(){} // RVA: 0x7FFE8800C210
        public void get_allSelectables(){} // RVA: 0x7FFE8800C270
        public void AllSelectablesNoAlloc(){} // RVA: 0x7FFE8800C310
        public void get_navigation(){} // RVA: 0x7FFE8800C4A0
        public void set_navigation(){} // RVA: 0x7FFE8800C4C0
        public void get_transition(){} // RVA: 0x7FFE8139DAD0
        public void set_transition(){} // RVA: 0x7FFE8800C610
        public void get_colors(){} // RVA: 0x7FFE8800C670
        public void set_colors(){} // RVA: 0x7FFE8800C6B0
        public void get_spriteState(){} // RVA: 0x7FFE8800C830
        public void set_spriteState(){} // RVA: 0x7FFE8800C850
        public void get_animationTriggers(){} // RVA: 0x7FFE81218100
        public void set_animationTriggers(){} // RVA: 0x7FFE8800C980
        public void get_targetGraphic(){} // RVA: 0x7FFE8117C900
        public void set_targetGraphic(){} // RVA: 0x7FFE8800C9E0
        public void get_interactable(){} // RVA: 0x7FFE82078290
        public void set_interactable(){} // RVA: 0x7FFE8800CA40
        public void get_isPointerInside(){} // RVA: 0x7FFE8117CAD0
        public void set_isPointerInside(){} // RVA: 0x7FFE8117CAE0
        public void get_isPointerDown(){} // RVA: 0x7FFE82145E40
        public void set_isPointerDown(){} // RVA: 0x7FFE82145F60
        public void get_hasSelection(){} // RVA: 0x7FFE82144680
        public void set_hasSelection(){} // RVA: 0x7FFE82146D10
        public void .ctor(){} // RVA: 0x7FFE8800CCD0
        public void get_image(){} // RVA: 0x7FFE8800CF60
        public void set_image(){} // RVA: 0x7FFE8117C910
        public void get_animator(){} // RVA: 0x7FFE8800CFF0
        public void Awake(){} // RVA: 0x7FFE8800D030
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFE8800D170
        public void ParentGroupAllowsInteraction(){} // RVA: 0x7FFE8800D1B0
        public void IsInteractable(){} // RVA: 0x7FFE8800D3F0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFE8800D410
        public void OnEnable(){} // RVA: 0x7FFE8800D420
        public void OnTransformParentChanged(){} // RVA: 0x7FFE82215450
        public void OnSetProperty(){} // RVA: 0x7FFE8800D950
        public void OnDisable(){} // RVA: 0x7FFE8800D9D0
        public void OnApplicationFocus(){} // RVA: 0x7FFE8800DB50
        public void get_currentSelectionState(){} // RVA: 0x7FFE8800DBC0
        public void InstantClearState(){} // RVA: 0x7FFE8800DC30
        public void DoStateTransition(){} // RVA: 0x7FFE8800DCC0
        public void FindSelectable(){} // RVA: 0x7FFE8800DFE0
        public void GetPointOnRectEdge(){} // RVA: 0x7FFE8800E9A0
        public void Navigate(){} // RVA: 0x7FFE8800ECB0
        public void FindSelectableOnLeft(){} // RVA: 0x7FFE8800EE00
        public void FindSelectableOnRight(){} // RVA: 0x7FFE8800EF70
        public void FindSelectableOnUp(){} // RVA: 0x7FFE8800F0E0
        public void FindSelectableOnDown(){} // RVA: 0x7FFE8800F250
        public void OnMove(){} // RVA: 0x7FFE8800F3C0
        public void StartColorTween(){} // RVA: 0x7FFE8800F470
        public void DoSpriteSwap(){} // RVA: 0x7FFE8800F5E0
        public void TriggerAnimation(){} // RVA: 0x7FFE8800F6F0
        public void IsHighlighted(){} // RVA: 0x7FFE8800FA00
        public void IsPressed(){} // RVA: 0x7FFE8800FA70
        public void EvaluateAndTransitionToSelectionState(){} // RVA: 0x7FFE8800FAC0
        public void OnPointerDown(){} // RVA: 0x7FFE8800FB30
        public void OnPointerUp(){} // RVA: 0x7FFE8800FCD0
        public void OnPointerEnter(){} // RVA: 0x7FFE8800FD00
        public void OnPointerExit(){} // RVA: 0x7FFE8800FD10
        public void OnSelect(){} // RVA: 0x7FFE8800FD20
        public void OnDeselect(){} // RVA: 0x7FFE8800FD30
        public void Select(){} // RVA: 0x7FFE8800FD40
        public void .cctor(){} // RVA: 0x7FFE8800FEE0
    }

    public class SetPropertyUtility : Object
    {
        // ── Methods ──
        public void SetColor(){} // RVA: 0x7FFE87B2FCF0
        public void SetStruct(){} // RVA: 0x7FFE810A1420
        public void SetClass(){} // RVA: 0x7FFE810A1420
    }

    public class Shadow : BaseMeshEffect
    {
        public UnityEngine.Color m_EffectColor; // 0x28
        public UnityEngine.Vector2 m_EffectDistance; // 0x38
        public bool m_UseGraphicAlpha; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8801DCF0
        public void get_effectColor(){} // RVA: 0x7FFE81E90600
        public void set_effectColor(){} // RVA: 0x7FFE8801E1E0
        public void get_effectDistance(){} // RVA: 0x7FFE822B97B0
        public void set_effectDistance(){} // RVA: 0x7FFE8801E2F0
        public void get_useGraphicAlpha(){} // RVA: 0x7FFE811B6C00
        public void set_useGraphicAlpha(){} // RVA: 0x7FFE8801E4B0
        public void ApplyShadowZeroAlloc(){} // RVA: 0x7FFE8801E5C0
        public void ApplyShadow(){} // RVA: 0x7FFE8801E9D0
        public void ModifyMesh(){} // RVA: 0x7FFE8801E9E0
    }

    public class Slider : Selectable
    {
        public UnityEngine.RectTransform m_FillRect; // 0x100
        public UnityEngine.RectTransform m_HandleRect; // 0x108
        public 0x66644944 m_Direction; // 0x110
        public float m_MinValue; // 0x114
        public float m_MaxValue; // 0x118
        public bool m_WholeNumbers; // 0x11C
        public float m_Value; // 0x120
        public SliderEvent m_OnValueChanged; // 0x128
        public UnityEngine.UI.Image m_FillImage; // 0x130
        public UnityEngine.Transform m_FillTransform; // 0x138
        public UnityEngine.RectTransform m_FillContainerRect; // 0x140
        public UnityEngine.Transform m_HandleTransform; // 0x148

        // ── Methods ──
        public void get_fillRect(){} // RVA: 0x7FFE81828B50
        public void set_fillRect(){} // RVA: 0x7FFE8800FFB0
        public void get_handleRect(){} // RVA: 0x7FFE8181E3D0
        public void set_handleRect(){} // RVA: 0x7FFE88010020
        public void get_direction(){} // RVA: 0x7FFE81A812D0
        public void set_direction(){} // RVA: 0x7FFE88010090
        public void get_minValue(){} // RVA: 0x7FFE87AC23C0
        public void set_minValue(){} // RVA: 0x7FFE880100F0
        public void get_maxValue(){} // RVA: 0x7FFE86FAEAA0
        public void set_maxValue(){} // RVA: 0x7FFE88010170
        public void get_wholeNumbers(){} // RVA: 0x7FFE880101F0
        public void set_wholeNumbers(){} // RVA: 0x7FFE88010200
        public void get_value(){} // RVA: 0x7FFE88010280
        public void set_value(){} // RVA: 0x7FFE880102A0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE880102C0
        public void get_normalizedValue(){} // RVA: 0x7FFE880102E0
        public void set_normalizedValue(){} // RVA: 0x7FFE88010390
        public void get_onValueChanged(){} // RVA: 0x7FFE8182B890
        public void set_onValueChanged(){} // RVA: 0x7FFE81B31E10
        public void get_stepSize(){} // RVA: 0x7FFE880103E0
        public void .ctor(){} // RVA: 0x7FFE88010410
        public void Rebuild(){} // RVA: 0x7FFE810FB310
        public void LayoutComplete(){} // RVA: 0x7FFE810FB310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFE810FB310
        public void OnEnable(){} // RVA: 0x7FFE88010540
        public void OnDisable(){} // RVA: 0x7FFE88003530
        public void Update(){} // RVA: 0x7FFE88010590
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFE880105E0
        public void UpdateCachedReferences(){} // RVA: 0x7FFE88010A00
        public void ClampValue(){} // RVA: 0x7FFE88011450
        public void Set(){} // RVA: 0x7FFE88011480
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFE88011570
        public void get_axis(){} // RVA: 0x7FFE880115B0
        public void get_reverseValue(){} // RVA: 0x7FFE880115D0
        public void UpdateVisuals(){} // RVA: 0x7FFE880115F0
        public void UpdateDrag(){} // RVA: 0x7FFE88011C10
        public void MayDrag(){} // RVA: 0x7FFE880042F0
        public void OnPointerDown(){} // RVA: 0x7FFE88011F70
        public void OnDrag(){} // RVA: 0x7FFE88012250
        public void OnMove(){} // RVA: 0x7FFE880122D0
        public void FindSelectableOnLeft(){} // RVA: 0x7FFE880128D0
        public void FindSelectableOnRight(){} // RVA: 0x7FFE88012900
        public void FindSelectableOnUp(){} // RVA: 0x7FFE88012930
        public void FindSelectableOnDown(){} // RVA: 0x7FFE88012960
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFE8186BE90
        public void SetDirection(){} // RVA: 0x7FFE88012990
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFE816315C0
    }

    public class SpriteState : ValueType
    {
        public UnityEngine.Sprite m_HighlightedSprite; // 0x10
        public UnityEngine.Sprite m_PressedSprite; // 0x18
        public UnityEngine.Sprite m_SelectedSprite; // 0x20
        public UnityEngine.Sprite m_DisabledSprite; // 0x28

        // ── Methods ──
        public void get_highlightedSprite(){} // RVA: 0x7FFE8284EF60
        public void set_highlightedSprite(){} // RVA: 0x7FFE81D7E9E0
        public void get_pressedSprite(){} // RVA: 0x7FFE826F4210
        public void set_pressedSprite(){} // RVA: 0x7FFE826F4230
        public void get_selectedSprite(){} // RVA: 0x7FFE81116380
        public void set_selectedSprite(){} // RVA: 0x7FFE810FCE30
        public void get_disabledSprite(){} // RVA: 0x7FFE810FE7C0
        public void set_disabledSprite(){} // RVA: 0x7FFE81161E80
        public void Equals(){} // RVA: 0x7FFE88012C80
    }

    public class StencilMaterial : Object
    {
        // ── Methods ──
        public void Add(){} // RVA: 0x7FFE880131C0 | overloaded x3
        public void LogWarningWhenNotInBatchmode(){} // RVA: 0x7FFE880130F0
        public void Remove(){} // RVA: 0x7FFE88013DA0
        public void ClearAll(){} // RVA: 0x7FFE880140A0
        public void .cctor(){} // RVA: 0x7FFE880142A0
    }

    public class Text : MaskableGraphic
    {
        public UnityEngine.UI.FontData m_FontData; // 0xE0
        public string m_Text; // 0xE8
        public UnityEngine.TextGenerator m_TextCache; // 0xF0
        public UnityEngine.TextGenerator m_TextCacheForLayout; // 0xF8
        public UnityEngine.Material s_DefaultText;
        public bool m_DisableFontTextureRebuiltCallback; // 0x100
        public int MAX_TEXT_LENGTH;
        public UnityEngine.UIVertex[] m_TempVerts; // 0x108
        public object field_8; // 0x136
        public object field_9; // 0x137
        public object field_10; // 0x138
        public object field_11; // 0x139
        public object field_12; // 0x13A
        public object field_13; // 0x13B
        public object field_14; // 0x13C
        public object field_15; // 0x13D
        public object field_16; // 0x13E
        public object field_17; // 0x13F
        public object field_18; // 0x140
        public object field_19; // 0x141
        public object field_20; // 0x142
        public object field_21; // 0x143
        public object field_22; // 0x144
        public object field_23; // 0x145

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88014390
        public void get_cachedTextGenerator(){} // RVA: 0x7FFE88014530
        public void get_cachedTextGeneratorForLayout(){} // RVA: 0x7FFE88014630
        public void get_mainTexture(){} // RVA: 0x7FFE880146F0
        public void FontTextureChanged(){} // RVA: 0x7FFE88014B10
        public void get_font(){} // RVA: 0x7FFE88014CB0
        public void set_font(){} // RVA: 0x7FFE88014CD0
        public void get_text(){} // RVA: 0x7FFE8117C970
        public void set_text(){} // RVA: 0x7FFE88014F60
        public void get_supportRichText(){} // RVA: 0x7FFE88015140
        public void set_supportRichText(){} // RVA: 0x7FFE88015160
        public void get_resizeTextForBestFit(){} // RVA: 0x7FFE880151C0
        public void set_resizeTextForBestFit(){} // RVA: 0x7FFE880151E0
        public void get_resizeTextMinSize(){} // RVA: 0x7FFE88015240
        public void set_resizeTextMinSize(){} // RVA: 0x7FFE88015260
        public void get_resizeTextMaxSize(){} // RVA: 0x7FFE880152C0
        public void set_resizeTextMaxSize(){} // RVA: 0x7FFE880152E0
        public void get_alignment(){} // RVA: 0x7FFE88015340
        public void set_alignment(){} // RVA: 0x7FFE88015360
        public void get_alignByGeometry(){} // RVA: 0x7FFE880153C0
        public void set_alignByGeometry(){} // RVA: 0x7FFE880153E0
        public void get_fontSize(){} // RVA: 0x7FFE88015420
        public void set_fontSize(){} // RVA: 0x7FFE88015440
        public void get_horizontalOverflow(){} // RVA: 0x7FFE880154A0
        public void set_horizontalOverflow(){} // RVA: 0x7FFE880154C0
        public void get_verticalOverflow(){} // RVA: 0x7FFE88015520
        public void set_verticalOverflow(){} // RVA: 0x7FFE88015540
        public void get_lineSpacing(){} // RVA: 0x7FFE880155A0
        public void set_lineSpacing(){} // RVA: 0x7FFE880155C0
        public void get_fontStyle(){} // RVA: 0x7FFE88015630
        public void set_fontStyle(){} // RVA: 0x7FFE88015650
        public void get_pixelsPerUnit(){} // RVA: 0x7FFE880156B0
        public void OnEnable(){} // RVA: 0x7FFE880159A0
        public void OnDisable(){} // RVA: 0x7FFE88015A50
        public void UpdateGeometry(){} // RVA: 0x7FFE88015AB0
        public void AssignDefaultFont(){} // RVA: 0x7FFE88015BC0
        public void AssignDefaultFontIfNecessary(){} // RVA: 0x7FFE88015C20
        public void GetGenerationSettings(){} // RVA: 0x7FFE88015D40
        public void GetTextAnchorPivot(){} // RVA: 0x7FFE880160C0
        public void OnPopulateMesh(){} // RVA: 0x7FFE88016230
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFE810FB310
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFE810FB310
        public void get_minWidth(){} // RVA: 0x7FFE8186F320
        public void get_preferredWidth(){} // RVA: 0x7FFE88016A40
        public void get_flexibleWidth(){} // RVA: 0x7FFE878F7A90
        public void get_minHeight(){} // RVA: 0x7FFE8186F320
        public void get_preferredHeight(){} // RVA: 0x7FFE88016B70
        public void get_flexibleHeight(){} // RVA: 0x7FFE878F7A90
        public void get_layoutPriority(){} // RVA: 0x7FFE813240E0
    }

    public class Toggle : Selectable
    {
        public 0x66644C04 toggleTransition; // 0x100
        public UnityEngine.UI.Graphic graphic; // 0x108

        // ── Methods ──
        public void get_group(){} // RVA: 0x7FFE81317980
        public void set_group(){} // RVA: 0x7FFE88016C80
        public void .ctor(){} // RVA: 0x7FFE88016CB0
        public void Rebuild(){} // RVA: 0x7FFE810FB310
        public void LayoutComplete(){} // RVA: 0x7FFE810FB310
        public void GraphicUpdateComplete(){} // RVA: 0x7FFE810FB310
        public void OnDestroy(){} // RVA: 0x7FFE88016D90
        public void OnEnable(){} // RVA: 0x7FFE88016E80
        public void OnDisable(){} // RVA: 0x7FFE88016EC0
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFE88016EF0
        public void SetToggleGroup(){} // RVA: 0x7FFE88017080
        public void get_isOn(){} // RVA: 0x7FFE86B33050
        public void set_isOn(){} // RVA: 0x7FFE88017360
        public void SetIsOnWithoutNotify(){} // RVA: 0x7FFE88017370
        public void Set(){} // RVA: 0x7FFE88017380
        public void PlayEffect(){} // RVA: 0x7FFE880175C0
        public void Start(){} // RVA: 0x7FFE880176F0
        public void InternalToggle(){} // RVA: 0x7FFE88017700
        public void OnPointerClick(){} // RVA: 0x7FFE88017760
        public void OnSubmit(){} // RVA: 0x7FFE88017700
        public void UnityEngine.UI.ICanvasElement.get_transform(){} // RVA: 0x7FFE816315C0
    }

    public class ToggleGroup : UIBehaviour
    {
        public bool m_AllowSwitchOff; // 0x20

        // ── Methods ──
        public void get_allowSwitchOff(){} // RVA: 0x7FFE811E99D0
        public void set_allowSwitchOff(){} // RVA: 0x7FFE811E99E0
        public void .ctor(){} // RVA: 0x7FFE88017870
        public void Start(){} // RVA: 0x7FFE88017970
        public void OnEnable(){} // RVA: 0x7FFE88017970
        public void ValidateToggleIsInGroup(){} // RVA: 0x7FFE88017980
        public void NotifyToggleOn(){} // RVA: 0x7FFE88017B40
        public void UnregisterToggle(){} // RVA: 0x7FFE88017D60
        public void RegisterToggle(){} // RVA: 0x7FFE88017DE0
        public void EnsureValidState(){} // RVA: 0x7FFE88017EA0
        public void AnyTogglesOn(){} // RVA: 0x7FFE88018290
        public void ActiveToggles(){} // RVA: 0x7FFE880184C0
        public void GetFirstActiveToggle(){} // RVA: 0x7FFE88018630
        public void SetAllTogglesOff(){} // RVA: 0x7FFE880186B0
    }

    public class VertexHelper : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.Vector3> m_Positions; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.Color32> m_Colors; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8801ACE0 | overloaded x2
        public void InitializeListIfRequired(){} // RVA: 0x7FFE8801B030
        public void Dispose(){} // RVA: 0x7FFE8801B570
        public void Clear(){} // RVA: 0x7FFE8801BA90
        public void get_currentVertCount(){} // RVA: 0x7FFE8801BB90
        public void get_currentIndexCount(){} // RVA: 0x7FFE8801BBE0
        public void PopulateUIVertex(){} // RVA: 0x7FFE8801BC30
        public void SetUIVertex(){} // RVA: 0x7FFE8801BE80
        public void FillMesh(){} // RVA: 0x7FFE8801C290
        public void AddVert(){} // RVA: 0x7FFE8801CE50 | overloaded x4
        public void AddTriangle(){} // RVA: 0x7FFE8801CF00
        public void AddUIVertexQuad(){} // RVA: 0x7FFE8801D070
        public void AddUIVertexStream(){} // RVA: 0x7FFE8801D330
        public void AddUIVertexTriangleStream(){} // RVA: 0x7FFE8801D4B0
        public void GetUIVertexStream(){} // RVA: 0x7FFE8801D530
        public void .cctor(){} // RVA: 0x7FFE8801D640
    }

    public class VerticalLayoutGroup : HorizontalOrVerticalLayoutGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FF3530
        public void CalculateLayoutInputHorizontal(){} // RVA: 0x7FFE87FFB2E0
        public void CalculateLayoutInputVertical(){} // RVA: 0x7FFE87FFB310
        public void SetLayoutHorizontal(){} // RVA: 0x7FFE87FFB320
        public void SetLayoutVertical(){} // RVA: 0x7FFE87FFB330
    }

}