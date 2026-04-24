// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 16
// Methods: 535

namespace ThirdParty.Unity.UnityEngine
{
    public class GUI : Object
    {
        public int color;
        public int backgroundColor; // 0x4
        public int contentColor; // 0x8
        public int changed; // 0xC
        public int enabled; // 0x10
        public int depth; // 0x14
        public int usePageScrollbars; // 0x18
        public int blendMaterial; // 0x1C
        public int blitMaterial; // 0x20
        public int roundedRectMaterial; // 0x24
        public int roundedRectWithColorPerBorderMaterial; // 0x28
        public System.DateTime scrollTroughSide; // 0x30
        public UnityEngine.GUISkin nextScrollStepTime; // 0x38
        public UnityEngine.Rect skin; // 0x40
        public 0x664D6A88 matrix; // 0x50

        // ── Methods ──
        public void get_color(){} // RVA: 0x7FFD54D291B0
        public void set_color(){} // RVA: 0x7FFD54D29240
        public void get_backgroundColor(){} // RVA: 0x7FFD54D292D0
        public void set_backgroundColor(){} // RVA: 0x7FFD54D29360
        public void get_contentColor(){} // RVA: 0x7FFD54D293F0
        public void set_contentColor(){} // RVA: 0x7FFD54D29480
        public void get_changed(){} // RVA: 0x7FFD54D29510
        public void set_changed(){} // RVA: 0x7FFD54D29560
        public void get_enabled(){} // RVA: 0x7FFD54D295B0
        public void set_enabled(){} // RVA: 0x7FFD54D29600
        public void set_depth(){} // RVA: 0x7FFD54D29650
        public void get_usePageScrollbars(){} // RVA: 0x7FFD54D296A0
        public void get_blendMaterial(){} // RVA: 0x7FFD54D296F0
        public void get_blitMaterial(){} // RVA: 0x7FFD54D29740
        public void get_roundedRectMaterial(){} // RVA: 0x7FFD54D29790
        public void get_roundedRectWithColorPerBorderMaterial(){} // RVA: 0x7FFD54D297E0
        public void GrabMouseControl(){} // RVA: 0x7FFD54D29830
        public void HasMouseControl(){} // RVA: 0x7FFD54D29880
        public void ReleaseMouseControl(){} // RVA: 0x7FFD54D298D0
        public void SetNextControlName(){} // RVA: 0x7FFD54D29920
        public void InternalRepaintEditorWindow(){} // RVA: 0x7FFD54D29970
        public void Internal_DoWindow(){} // RVA: 0x7FFD54D299C0
        public void .cctor(){} // RVA: 0x7FFD54D29AC0
        public void get_scrollTroughSide(){} // RVA: 0x7FFD54D29E00
        public void set_scrollTroughSide(){} // RVA: 0x7FFD54D29E60
        public void get_nextScrollStepTime(){} // RVA: 0x7FFD54D29EC0
        public void set_nextScrollStepTime(){} // RVA: 0x7FFD54D29F20
        public void set_skin(){} // RVA: 0x7FFD54D29F80
        public void get_skin(){} // RVA: 0x7FFD54D2A000
        public void DoSetSkin(){} // RVA: 0x7FFD54D2A090
        public void get_matrix(){} // RVA: 0x7FFD54D2A410
        public void set_matrix(){} // RVA: 0x7FFD54D2A4B0
        public void Label(){} // RVA: 0x7FFD54D2A880 | overloaded x4
        public void DrawTexture(){} // RVA: 0x7FFD54D2B5E0 | overloaded x9
        public void CalculateScaledTextureRects(){} // RVA: 0x7FFD54D2BE80
        public void DrawTextureWithTexCoords(){} // RVA: 0x7FFD54D2C0C0 | overloaded x2
        public void Box(){} // RVA: 0x7FFD54D2C820 | overloaded x3
        public void Button(){} // RVA: 0x7FFD54D2CBE0 | overloaded x3
        public void DoRepeatButton(){} // RVA: 0x7FFD54D2CE10
        public void PasswordFieldGetStrToShow(){} // RVA: 0x7FFD54D2D170
        public void DoTextField(){} // RVA: 0x7FFD54D2D4A0 | overloaded x3
        public void HandleTextFieldEventForTouchscreen(){} // RVA: 0x7FFD54D2DB10
        public void HandleTextFieldEventForDesktop(){} // RVA: 0x7FFD54D2E1B0
        public void HandleTextFieldEventForDesktopWithForcedKeyboard(){} // RVA: 0x7FFD54D2EB10
        public void Toggle(){} // RVA: 0x7FFD54D2EFC0
        public void SelectionGrid(){} // RVA: 0x7FFD54D2F220
        public void CalcTotalHorizSpacing(){} // RVA: 0x7FFD54D2F320
        public void DoControl(){} // RVA: 0x7FFD54D2F6B0
        public void DoLabel(){} // RVA: 0x7FFD54D2FB00
        public void DoToggle(){} // RVA: 0x7FFD54D2FEE0
        public void DoButton(){} // RVA: 0x7FFD54D30050
        public void DoButtonGrid(){} // RVA: 0x7FFD54D301C0
        public void CalcGridRects(){} // RVA: 0x7FFD54D30E40
        public void HorizontalSlider(){} // RVA: 0x7FFD54D311E0
        public void Slider(){} // RVA: 0x7FFD54D312B0
        public void HorizontalScrollbar(){} // RVA: 0x7FFD54D31590
        public void ScrollerRepeatButton(){} // RVA: 0x7FFD54D31790
        public void VerticalScrollbar(){} // RVA: 0x7FFD54D31AD0
        public void Scroller(){} // RVA: 0x7FFD54D31CD0
        public void BeginGroup(){} // RVA: 0x7FFD54D32690 | overloaded x2
        public void EndGroup(){} // RVA: 0x7FFD54D329F0
        public void get_scrollViewStates(){} // RVA: 0x7FFD54D32A80
        public void BeginScrollView(){} // RVA: 0x7FFD54D32AE0
        public void EndScrollView(){} // RVA: 0x7FFD54D33B20
        public void Window(){} // RVA: 0x7FFD54D34F70 | overloaded x2
        public void DoWindow(){} // RVA: 0x7FFD54D35070
        public void CallWindowDelegate(){} // RVA: 0x7FFD54D35210
        public void get_color_Injected(){} // RVA: 0x7FFD54D35540
        public void set_color_Injected(){} // RVA: 0x7FFD54D35590
        public void get_backgroundColor_Injected(){} // RVA: 0x7FFD54D355E0
        public void set_backgroundColor_Injected(){} // RVA: 0x7FFD54D35630
        public void get_contentColor_Injected(){} // RVA: 0x7FFD54D35680
        public void set_contentColor_Injected(){} // RVA: 0x7FFD54D356D0
        public void Internal_DoWindow_Injected(){} // RVA: 0x7FFD54D35720
    }

    public class GUIContent : Object
    {
        public string text; // 0x10
        public UnityEngine.Texture image; // 0x18
        public string tooltip; // 0x20
        public System.Action OnTextChanged; // 0x28
        public UnityEngine.GUIContent s_Text;
        public UnityEngine.GUIContent s_Image; // 0x8
        public UnityEngine.GUIContent s_TextImage; // 0x10
        public UnityEngine.GUIContent none; // 0x18

        // ── Methods ──
        public void get_text(){} // RVA: 0x7FFD510E4750
        public void set_text(){} // RVA: 0x7FFD54D36150
        public void set_image(){} // RVA: 0x7FFD4E3A7E80
        public void get_tooltip(){} // RVA: 0x7FFD545DAEE0
        public void set_tooltip(){} // RVA: 0x7FFD4E36F0D0
        public void .ctor(){} // RVA: 0x7FFD54D365C0 | overloaded x5
        public void Temp(){} // RVA: 0x7FFD54D36DA0 | overloaded x3
        public void ClearStaticCache(){} // RVA: 0x7FFD54D36A70
        public void ToString(){} // RVA: 0x7FFD54D36F60
        public void .cctor(){} // RVA: 0x7FFD54D36FB0
    }

    public class GUILayoutEntry : Object
    {
        public float style; // 0x10
        public float marginLeft; // 0x14
        public float marginRight; // 0x18
        public float marginTop; // 0x1C
        public UnityEngine.Rect marginBottom; // 0x20
        public int marginHorizontal; // 0x30
        public int marginVertical; // 0x34
        public bool consideredForMargin; // 0x38
        public UnityEngine.GUIStyle m_Style; // 0x40
        public UnityEngine.Rect kDummyRect;
        public int indent; // 0x10

        // ── Methods ──
        public void get_style(){} // RVA: 0x7FFD54D3F730
        public void set_style(){} // RVA: 0x7FFD54D48890
        public void get_marginLeft(){} // RVA: 0x7FFD54D48900
        public void get_marginRight(){} // RVA: 0x7FFD54D48970
        public void get_marginTop(){} // RVA: 0x7FFD54D489E0
        public void get_marginBottom(){} // RVA: 0x7FFD54D48A50
        public void get_marginHorizontal(){} // RVA: 0x7FFD54D48AC0
        public void get_marginVertical(){} // RVA: 0x7FFD54D48B10
        public void .ctor(){} // RVA: 0x7FFD54D48C80 | overloaded x2
        public void CalcWidth(){} // RVA: 0x7FFD4E341310
        public void CalcHeight(){} // RVA: 0x7FFD4E341310
        public void SetHorizontal(){} // RVA: 0x7FFD54D48DA0
        public void SetVertical(){} // RVA: 0x7FFD54D48DB0
        public void ApplyStyleSettings(){} // RVA: 0x7FFD54D48DC0
        public void ApplyOptions(){} // RVA: 0x7FFD54D48F90
        public void ToString(){} // RVA: 0x7FFD54D49320
        public void .cctor(){} // RVA: 0x7FFD54D49950
    }

    public class GUILayoutGroup : GUILayoutEntry
    {
        public System.Collections.Generic.List`1<UnityEngine.GUILayoutEntry> marginLeft; // 0x48
        public bool marginRight; // 0x50
        public bool marginTop; // 0x51
        public float marginBottom; // 0x54
        public bool sameSize; // 0x58
        public bool isWindow; // 0x59
        public int windowID; // 0x5C
        public int m_Cursor; // 0x60
        public int m_StretchableCountX; // 0x64
        public int m_StretchableCountY; // 0x68
        public bool m_UserSpecifiedWidth; // 0x6C
        public bool m_UserSpecifiedHeight; // 0x6D
        public float m_ChildMinWidth; // 0x70
        public float m_ChildMaxWidth; // 0x74
        public float m_ChildMinHeight; // 0x78
        public float m_ChildMaxHeight; // 0x7C
        public int m_MarginLeft; // 0x80
        public int m_MarginRight; // 0x84
        public int m_MarginTop; // 0x88
        public int m_MarginBottom; // 0x8C
        public UnityEngine.GUILayoutEntry none;

        // ── Methods ──
        public void get_marginLeft(){} // RVA: 0x7FFD4E9929C0
        public void get_marginRight(){} // RVA: 0x7FFD4FAF5110
        public void get_marginTop(){} // RVA: 0x7FFD4EC0E8C0
        public void get_marginBottom(){} // RVA: 0x7FFD51376E80
        public void .ctor(){} // RVA: 0x7FFD54D4A620
        public void ApplyOptions(){} // RVA: 0x7FFD54D4A7A0
        public void ApplyStyleSettings(){} // RVA: 0x7FFD54D4A8B0
        public void ResetCursor(){} // RVA: 0x7FFD54D4AA20
        public void GetNext(){} // RVA: 0x7FFD54D4AA30
        public void Add(){} // RVA: 0x7FFD54D4AD80
        public void CalcWidth(){} // RVA: 0x7FFD54D4AE20
        public void SetHorizontal(){} // RVA: 0x7FFD54D4B770
        public void CalcHeight(){} // RVA: 0x7FFD54D4C1D0
        public void SetVertical(){} // RVA: 0x7FFD54D4CA90
        public void ToString(){} // RVA: 0x7FFD54D4D440
        public void .cctor(){} // RVA: 0x7FFD54D4D850
    }

    public class GUIScrollGroup : GUILayoutGroup
    {
        public float calcMinWidth; // 0x90
        public float calcMaxWidth; // 0x94
        public float calcMinHeight; // 0x98
        public float calcMaxHeight; // 0x9C
        public float clientWidth; // 0xA0
        public float clientHeight; // 0xA4
        public bool allowHorizontalScroll; // 0xA8
        public bool allowVerticalScroll; // 0xA9
        public bool needsHorizontalScrollbar; // 0xAA
        public bool needsVerticalScrollbar; // 0xAB
        public UnityEngine.GUIStyle horizontalScrollbar; // 0xB0
        public UnityEngine.GUIStyle verticalScrollbar; // 0xB8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54D4D980
        public void CalcWidth(){} // RVA: 0x7FFD54D4D9E0
        public void SetHorizontal(){} // RVA: 0x7FFD54D4DA80
        public void CalcHeight(){} // RVA: 0x7FFD54D4DC60
        public void SetVertical(){} // RVA: 0x7FFD54D4DE10
    }

    public class GUISkin : ScriptableObject
    {
        public UnityEngine.Font font; // 0x18
        public UnityEngine.GUIStyle box; // 0x20
        public UnityEngine.GUIStyle label; // 0x28
        public UnityEngine.GUIStyle textField; // 0x30
        public UnityEngine.GUIStyle textArea; // 0x38
        public UnityEngine.GUIStyle button; // 0x40
        public UnityEngine.GUIStyle toggle; // 0x48
        public UnityEngine.GUIStyle window; // 0x50
        public UnityEngine.GUIStyle horizontalSlider; // 0x58
        public UnityEngine.GUIStyle horizontalSliderThumb; // 0x60
        public UnityEngine.GUIStyle horizontalSliderThumbExtent; // 0x68
        public UnityEngine.GUIStyle sliderMixed; // 0x70
        public UnityEngine.GUIStyle verticalSlider; // 0x78
        public UnityEngine.GUIStyle verticalSliderThumb; // 0x80
        public UnityEngine.GUIStyle verticalSliderThumbExtent; // 0x88
        public UnityEngine.GUIStyle horizontalScrollbar; // 0x90
        public UnityEngine.GUIStyle horizontalScrollbarThumb; // 0x98
        public UnityEngine.GUIStyle horizontalScrollbarLeftButton; // 0xA0
        public UnityEngine.GUIStyle horizontalScrollbarRightButton; // 0xA8
        public UnityEngine.GUIStyle verticalScrollbar; // 0xB0
        public UnityEngine.GUIStyle verticalScrollbarThumb; // 0xB8
        public UnityEngine.GUIStyle verticalScrollbarUpButton; // 0xC0
        public UnityEngine.GUIStyle verticalScrollbarDownButton; // 0xC8
        public UnityEngine.GUIStyle scrollView; // 0xD0
        public UnityEngine.GUIStyle[] customStyles; // 0xD8
        public 0x665DFB60 settings; // 0xE0
        public UnityEngine.GUIStyle error;
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.GUIStyle> m_Styles; // 0xE8
        public SkinChangedDelegate m_SkinChanged; // 0x8
        public UnityEngine.GUISkin current; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54D3F1D0
        public void OnEnable(){} // RVA: 0x7FFD54D3F380
        public void CleanupRoots(){} // RVA: 0x7FFD54D3F390
        public void get_font(){} // RVA: 0x7FFD50CC1130
        public void set_font(){} // RVA: 0x7FFD54D3F490
        public void get_box(){} // RVA: 0x7FFD545DAEE0
        public void set_box(){} // RVA: 0x7FFD54D3F660
        public void get_label(){} // RVA: 0x7FFD54D3F6C0
        public void set_label(){} // RVA: 0x7FFD54D3F6D0
        public void get_textField(){} // RVA: 0x7FFD54D3F730
        public void set_textField(){} // RVA: 0x7FFD54D3F740
        public void get_textArea(){} // RVA: 0x7FFD54D3F7A0
        public void set_textArea(){} // RVA: 0x7FFD54D3F7B0
        public void get_button(){} // RVA: 0x7FFD54CFDAD0
        public void set_button(){} // RVA: 0x7FFD54D3F810
        public void get_toggle(){} // RVA: 0x7FFD54CFE3D0
        public void set_toggle(){} // RVA: 0x7FFD54D3F870
        public void get_window(){} // RVA: 0x7FFD54D3F8D0
        public void set_window(){} // RVA: 0x7FFD54D3F8E0
        public void get_horizontalSlider(){} // RVA: 0x7FFD54D3F940
        public void set_horizontalSlider(){} // RVA: 0x7FFD54D3F950
        public void get_horizontalSliderThumb(){} // RVA: 0x7FFD54D3F9B0
        public void set_horizontalSliderThumb(){} // RVA: 0x7FFD54D3F9C0
        public void get_horizontalSliderThumbExtent(){} // RVA: 0x7FFD54D3FA20
        public void set_horizontalSliderThumbExtent(){} // RVA: 0x7FFD54D3FA30
        public void get_sliderMixed(){} // RVA: 0x7FFD54D3FA90
        public void set_sliderMixed(){} // RVA: 0x7FFD54D3FAA0
        public void get_verticalSlider(){} // RVA: 0x7FFD54D3FB00
        public void set_verticalSlider(){} // RVA: 0x7FFD54D3FB10
        public void get_verticalSliderThumb(){} // RVA: 0x7FFD54D3FB70
        public void set_verticalSliderThumb(){} // RVA: 0x7FFD54D3FB80
        public void get_verticalSliderThumbExtent(){} // RVA: 0x7FFD54D3FBE0
        public void set_verticalSliderThumbExtent(){} // RVA: 0x7FFD54D3FBF0
        public void get_horizontalScrollbar(){} // RVA: 0x7FFD54D3FC50
        public void set_horizontalScrollbar(){} // RVA: 0x7FFD54D3FC60
        public void get_horizontalScrollbarThumb(){} // RVA: 0x7FFD54D3FCC0
        public void set_horizontalScrollbarThumb(){} // RVA: 0x7FFD54D3FCD0
        public void get_horizontalScrollbarLeftButton(){} // RVA: 0x7FFD54D3FD30
        public void set_horizontalScrollbarLeftButton(){} // RVA: 0x7FFD54D3FD40
        public void get_horizontalScrollbarRightButton(){} // RVA: 0x7FFD54D3FDA0
        public void set_horizontalScrollbarRightButton(){} // RVA: 0x7FFD54D3FDB0
        public void get_verticalScrollbar(){} // RVA: 0x7FFD54D3FE10
        public void set_verticalScrollbar(){} // RVA: 0x7FFD54D3FE20
        public void get_verticalScrollbarThumb(){} // RVA: 0x7FFD54D3FE80
        public void set_verticalScrollbarThumb(){} // RVA: 0x7FFD54D3FE90
        public void get_verticalScrollbarUpButton(){} // RVA: 0x7FFD54D3FEF0
        public void set_verticalScrollbarUpButton(){} // RVA: 0x7FFD54D3FF00
        public void get_verticalScrollbarDownButton(){} // RVA: 0x7FFD54D3FF60
        public void set_verticalScrollbarDownButton(){} // RVA: 0x7FFD54D3FF70
        public void get_scrollView(){} // RVA: 0x7FFD54D3FFD0
        public void set_scrollView(){} // RVA: 0x7FFD54D3FFE0
        public void get_customStyles(){} // RVA: 0x7FFD54D40040
        public void set_customStyles(){} // RVA: 0x7FFD54D40050
        public void get_settings(){} // RVA: 0x7FFD54D400B0
        public void get_error(){} // RVA: 0x7FFD54D400C0
        public void Apply(){} // RVA: 0x7FFD54D401F0
        public void BuildStyleCache(){} // RVA: 0x7FFD54D40270
        public void GetStyle(){} // RVA: 0x7FFD54D41C50
        public void FindStyle(){} // RVA: 0x7FFD54D41F30
        public void MakeCurrent(){} // RVA: 0x7FFD54D41FD0
        public void GetEnumerator(){} // RVA: 0x7FFD54D42100
    }

    public class GUIStyle : Object
    {
        public UIntPtr rawName; // 0x10
        public 0x665DFCC0 font; // 0x18
        public 0x665DFCC0 imagePosition; // 0x20
        public 0x665DFCC0 wordWrap; // 0x28
        public 0x665DFCC0 contentOffset; // 0x30
        public 0x665DFCC0 fixedWidth; // 0x38
        public 0x665DFCC0 fixedHeight; // 0x40
        public 0x665DFCC0 stretchWidth; // 0x48
        public 0x665DFCC0 stretchHeight; // 0x50
        public UnityEngine.RectOffset Internal_clipOffset; // 0x58
        public UnityEngine.RectOffset name; // 0x60
        public UnityEngine.RectOffset normal; // 0x68
        public UnityEngine.RectOffset border; // 0x70
        public string margin; // 0x78
        public bool padding;
        public UnityEngine.GUIStyle lineHeight; // 0x8

        // ── Methods ──
        public void get_rawName(){} // RVA: 0x7FFD54D42800
        public void set_rawName(){} // RVA: 0x7FFD54D42850
        public void get_font(){} // RVA: 0x7FFD54D428B0
        public void get_imagePosition(){} // RVA: 0x7FFD54D42900
        public void get_wordWrap(){} // RVA: 0x7FFD54D42950
        public void get_contentOffset(){} // RVA: 0x7FFD54D429A0
        public void set_contentOffset(){} // RVA: 0x7FFD54D42A00
        public void get_fixedWidth(){} // RVA: 0x7FFD54D42A60
        public void get_fixedHeight(){} // RVA: 0x7FFD54D42AB0
        public void get_stretchWidth(){} // RVA: 0x7FFD54D42B00
        public void set_stretchWidth(){} // RVA: 0x7FFD54D42B50
        public void get_stretchHeight(){} // RVA: 0x7FFD54D42BB0
        public void set_stretchHeight(){} // RVA: 0x7FFD54D42C00
        public void set_Internal_clipOffset(){} // RVA: 0x7FFD54D42C60
        public void Internal_Create(){} // RVA: 0x7FFD54D42CC0
        public void Internal_Copy(){} // RVA: 0x7FFD54D42D10
        public void Internal_Destroy(){} // RVA: 0x7FFD54D42D70
        public void GetStyleStatePtr(){} // RVA: 0x7FFD54D42DC0
        public void GetRectOffsetPtr(){} // RVA: 0x7FFD54D42E20
        public void Internal_GetLineHeight(){} // RVA: 0x7FFD54D42E80
        public void Internal_Draw(){} // RVA: 0x7FFD54D42ED0
        public void Internal_Draw2(){} // RVA: 0x7FFD54D42F80
        public void Internal_DrawCursor(){} // RVA: 0x7FFD54D43010
        public void Internal_DrawWithTextSelection(){} // RVA: 0x7FFD54D430A0
        public void Internal_GetCursorPixelPosition(){} // RVA: 0x7FFD54D43190
        public void Internal_GetCursorStringIndex(){} // RVA: 0x7FFD54D43230
        public void Internal_GetSelectedRenderedText(){} // RVA: 0x7FFD54D432B0
        public void Internal_CalcSize(){} // RVA: 0x7FFD54D43340
        public void Internal_CalcSizeWithConstraints(){} // RVA: 0x7FFD54D433B0
        public void Internal_CalcHeight(){} // RVA: 0x7FFD54D43430
        public void Internal_CalcMinMaxWidth(){} // RVA: 0x7FFD54D434A0
        public void SetMouseTooltip(){} // RVA: 0x7FFD54D43510
        public void IsTooltipActive(){} // RVA: 0x7FFD54D435B0
        public void Internal_GetCursorFlashOffset(){} // RVA: 0x7FFD54D43600
        public void SetDefaultFont(){} // RVA: 0x7FFD54D43650
        public void .ctor(){} // RVA: 0x7FFD54D43730 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFD54D43820
        public void get_name(){} // RVA: 0x7FFD54D438F0
        public void set_name(){} // RVA: 0x7FFD54D439B0
        public void get_normal(){} // RVA: 0x7FFD54D43A60
        public void get_border(){} // RVA: 0x7FFD54D43BC0
        public void get_margin(){} // RVA: 0x7FFD54D43D20
        public void get_padding(){} // RVA: 0x7FFD54D43E80
        public void get_lineHeight(){} // RVA: 0x7FFD54D43FE0
        public void Draw(){} // RVA: 0x7FFD54D44440 | overloaded x6
        public void DrawCursor(){} // RVA: 0x7FFD54D44560
        public void DrawWithTextSelection(){} // RVA: 0x7FFD54D44ED0 | overloaded x3
        public void get_none(){} // RVA: 0x7FFD54D44F10
        public void GetCursorPixelPosition(){} // RVA: 0x7FFD54D45010
        public void GetCursorStringIndex(){} // RVA: 0x7FFD54D450B0
        public void CalcSize(){} // RVA: 0x7FFD54D43340
        public void CalcSizeWithConstraints(){} // RVA: 0x7FFD54D433B0
        public void CalcHeight(){} // RVA: 0x7FFD54D43430
        public void get_isHeightDependantOnWidth(){} // RVA: 0x7FFD54D45130
        public void CalcMinMaxWidth(){} // RVA: 0x7FFD54D45230
        public void ToString(){} // RVA: 0x7FFD54D452D0
        public void .cctor(){} // RVA: 0x7FFD54D45390
        public void get_contentOffset_Injected(){} // RVA: 0x7FFD54D453D0
        public void set_contentOffset_Injected(){} // RVA: 0x7FFD54D45430
        public void set_Internal_clipOffset_Injected(){} // RVA: 0x7FFD54D45490
        public void Internal_Draw_Injected(){} // RVA: 0x7FFD54D454F0
        public void Internal_Draw2_Injected(){} // RVA: 0x7FFD54D455A0
        public void Internal_DrawCursor_Injected(){} // RVA: 0x7FFD54D45630
        public void Internal_DrawWithTextSelection_Injected(){} // RVA: 0x7FFD54D456C0
        public void Internal_GetCursorPixelPosition_Injected(){} // RVA: 0x7FFD54D45790
        public void Internal_GetCursorStringIndex_Injected(){} // RVA: 0x7FFD54D45820
        public void Internal_GetSelectedRenderedText_Injected(){} // RVA: 0x7FFD54D458A0
        public void Internal_CalcSize_Injected(){} // RVA: 0x7FFD54D45930
        public void Internal_CalcSizeWithConstraints_Injected(){} // RVA: 0x7FFD54D459A0
        public void Internal_CalcMinMaxWidth_Injected(){} // RVA: 0x7FFD54D45A20
        public void SetMouseTooltip_Injected(){} // RVA: 0x7FFD54D45A90
    }

    public class GUITargetAttribute : Attribute
    {
        public int displayMask; // 0x10

        // ── Methods ──
        public void GetGUITargetAttrValue(){} // RVA: 0x7FFD54D45AF0
    }

    public class GUIUtility : Object
    {
        public int pixelsPerPoint;
        public int guiDepth; // 0x4
        public int mouseUsed; // 0x8
        public System.Action textFieldInput; // 0x10
        public System.Action systemCopyBuffer; // 0x18
        public System.Func`3<int,UIntPtr,bool> compositionString; // 0x20
        public System.Action imeCompositionMode; // 0x28
        public System.Func`2<System.Exception,bool> compositionCursorPos; // 0x30
        public System.Action guiIsExiting; // 0x38
        public System.Action`2<0x665DF530,0x664DD1A8> hotControl; // 0x40
        public UnityEngine.Event keyboardControl; // 0x48
        public bool <guiIsExiting>k__BackingField; // 0x50
        public System.Func`1<bool> s_HasCurrentWindowKeyFocusFunc; // 0x58

        // ── Methods ──
        public void get_pixelsPerPoint(){} // RVA: 0x7FFD54D45D50
        public void get_guiDepth(){} // RVA: 0x7FFD54D45DA0
        public void set_mouseUsed(){} // RVA: 0x7FFD54D45DF0
        public void get_textFieldInput(){} // RVA: 0x7FFD54D45E40
        public void set_textFieldInput(){} // RVA: 0x7FFD54D45E90
        public void get_systemCopyBuffer(){} // RVA: 0x7FFD54D45EE0
        public void set_systemCopyBuffer(){} // RVA: 0x7FFD54D45F30
        public void Internal_GetControlID(){} // RVA: 0x7FFD54D45F80
        public void GetControlID(){} // RVA: 0x7FFD54D46830 | overloaded x3
        public void BeginContainerFromOwner(){} // RVA: 0x7FFD54D46120
        public void BeginContainer(){} // RVA: 0x7FFD54D46170
        public void Internal_EndContainer(){} // RVA: 0x7FFD54D461C0
        public void CheckForTabEvent(){} // RVA: 0x7FFD54D46210
        public void SetKeyboardControlToFirstControlId(){} // RVA: 0x7FFD54D46260
        public void SetKeyboardControlToLastControlId(){} // RVA: 0x7FFD54D462B0
        public void HasFocusableControls(){} // RVA: 0x7FFD54D46300
        public void OwnsId(){} // RVA: 0x7FFD54D46350
        public void AlignRectToDevice(){} // RVA: 0x7FFD54D47FE0 | overloaded x2
        public void get_compositionString(){} // RVA: 0x7FFD54D46460
        public void set_imeCompositionMode(){} // RVA: 0x7FFD54D464B0
        public void set_compositionCursorPos(){} // RVA: 0x7FFD54D46500
        public void Internal_GetHotControl(){} // RVA: 0x7FFD54D46590
        public void Internal_GetKeyboardControl(){} // RVA: 0x7FFD54D465E0
        public void Internal_SetHotControl(){} // RVA: 0x7FFD54D46630
        public void Internal_SetKeyboardControl(){} // RVA: 0x7FFD54D46680
        public void Internal_GetDefaultSkin(){} // RVA: 0x7FFD54D466D0
        public void Internal_ExitGUI(){} // RVA: 0x7FFD54D46720
        public void MarkGUIChanged(){} // RVA: 0x7FFD54D46770
        public void GetStateObject(){} // RVA: 0x7FFD54D468B0
        public void set_guiIsExiting(){} // RVA: 0x7FFD54D46A70
        public void get_hotControl(){} // RVA: 0x7FFD54D46AD0
        public void set_hotControl(){} // RVA: 0x7FFD54D46B50
        public void TakeCapture(){} // RVA: 0x7FFD54D46BE0
        public void RemoveCapture(){} // RVA: 0x7FFD54D46C50
        public void get_keyboardControl(){} // RVA: 0x7FFD54D46CC0
        public void set_keyboardControl(){} // RVA: 0x7FFD54D46D40
        public void HasKeyFocus(){} // RVA: 0x7FFD54D46DD0
        public void ExitGUI(){} // RVA: 0x7FFD54D46EB0
        public void GetDefaultSkin(){} // RVA: 0x7FFD54D46EF0
        public void ProcessEvent(){} // RVA: 0x7FFD54D46FC0
        public void EndContainer(){} // RVA: 0x7FFD54D47210
        public void BeginGUI(){} // RVA: 0x7FFD54D472D0
        public void EndGUI(){} // RVA: 0x7FFD54D47390
        public void EndGUIFromException(){} // RVA: 0x7FFD54D475B0
        public void EndContainerGUIFromException(){} // RVA: 0x7FFD54D47640
        public void ResetGlobalState(){} // RVA: 0x7FFD54D476E0
        public void IsExitGUIException(){} // RVA: 0x7FFD54D47840
        public void ShouldRethrowException(){} // RVA: 0x7FFD54D478D0
        public void CheckOnGUI(){} // RVA: 0x7FFD54D47990
        public void RoundToPixelGrid(){} // RVA: 0x7FFD54D47A70
        public void ScaleAroundPivot(){} // RVA: 0x7FFD54D47B60
        public void HitTest(){} // RVA: 0x7FFD54D48230 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFD54D48310
        public void Internal_GetControlID_Injected(){} // RVA: 0x7FFD54D48420
        public void AlignRectToDevice_Injected(){} // RVA: 0x7FFD54D48490
        public void set_compositionCursorPos_Injected(){} // RVA: 0x7FFD54D48510
    }

    public class GameObject : Object
    {
        public object transform;
        public object layer;
        public object active;
        public object activeSelf;
        public object activeInHierarchy;
        public object isStatic;
        public object isStaticBatchable;
        public object tag;
        public object scene;
        public object sceneCullingMask;
        public object gameObject;

        // ── Methods ──
        public void CreatePrimitive(){} // RVA: 0x7FFD54CE0060
        public void GetComponent(){} // RVA: 0x7FFD54CE0180 | overloaded x3
        public void GetComponentFastPath(){} // RVA: 0x7FFD54CE0110
        public void GetComponentByName(){} // RVA: 0x7FFD54CE0180
        public void GetComponentInChildren(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void GetComponentInParent(){} // RVA: 0x7FFD4E2ADC40 | overloaded x4
        public void GetComponentsInternal(){} // RVA: 0x7FFD54CE03A0
        public void GetComponents(){} // RVA: 0x7FFD4E090A40 | overloaded x4
        public void GetComponentsInChildren(){} // RVA: 0x7FFD4E090A40 | overloaded x6
        public void GetComponentsInParent(){} // RVA: 0x7FFD4E078E90 | overloaded x5
        public void TryGetComponent(){} // RVA: 0x7FFD54CE0770 | overloaded x2
        public void TryGetComponentInternal(){} // RVA: 0x7FFD54CE08F0
        public void TryGetComponentFastPath(){} // RVA: 0x7FFD54CE0950
        public void FindWithTag(){} // RVA: 0x7FFD54CE09C0
        public void SendMessageUpwards(){} // RVA: 0x7FFD54CE1360 | overloaded x4
        public void SendMessage(){} // RVA: 0x7FFD54CE1420 | overloaded x4
        public void BroadcastMessage(){} // RVA: 0x7FFD54CE14E0 | overloaded x4
        public void AddComponentInternal(){} // RVA: 0x7FFD54CE0A70
        public void Internal_AddComponentWithType(){} // RVA: 0x7FFD54CE0AD0
        public void AddComponent(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetComponentCount(){} // RVA: 0x7FFD54CE0B30
        public void QueryComponentAtIndex(){} // RVA: 0x7FFD54CE0B80
        public void GetComponentAtIndex(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void GetComponentIndex(){} // RVA: 0x7FFD54CE0CF0
        public void get_transform(){} // RVA: 0x7FFD54CE0D50
        public void get_layer(){} // RVA: 0x7FFD54CE0DA0
        public void set_layer(){} // RVA: 0x7FFD54CE0DF0
        public void get_active(){} // RVA: 0x7FFD54CE0E50
        public void set_active(){} // RVA: 0x7FFD54CE0EA0
        public void SetActive(){} // RVA: 0x7FFD54CE0F00
        public void get_activeSelf(){} // RVA: 0x7FFD54CE0F60
        public void get_activeInHierarchy(){} // RVA: 0x7FFD54CE0FB0
        public void SetActiveRecursively(){} // RVA: 0x7FFD54CE1000
        public void get_isStatic(){} // RVA: 0x7FFD54CE1060
        public void set_isStatic(){} // RVA: 0x7FFD54CE10B0
        public void get_isStaticBatchable(){} // RVA: 0x7FFD54CE1110
        public void get_tag(){} // RVA: 0x7FFD54CE1160
        public void set_tag(){} // RVA: 0x7FFD54CE11B0
        public void CompareTag(){} // RVA: 0x7FFD54CE1210
        public void FindGameObjectWithTag(){} // RVA: 0x7FFD54CE09C0
        public void FindGameObjectsWithTag(){} // RVA: 0x7FFD54CE1270
        public void .ctor(){} // RVA: 0x7FFD54CE1630 | overloaded x3
        public void Internal_CreateGameObject(){} // RVA: 0x7FFD54CE1760
        public void Find(){} // RVA: 0x7FFD54CE17C0
        public void SetGameObjectsActive(){} // RVA: 0x7FFD54CE1950 | overloaded x3
        public void InstantiateGameObjects(){} // RVA: 0x7FFD54CE1A50 | overloaded x2
        public void GetScene(){} // RVA: 0x7FFD54CE1C60
        public void get_scene(){} // RVA: 0x7FFD54CE1CC0
        public void get_sceneCullingMask(){} // RVA: 0x7FFD54CE1D20
        public void get_gameObject(){} // RVA: 0x7FFD53ABD800
        public void InstantiateGameObjects_Injected(){} // RVA: 0x7FFD54CE1D70
        public void GetScene_Injected(){} // RVA: 0x7FFD54CE1DF0
        public void get_scene_Injected(){} // RVA: 0x7FFD54CE1E50
    }

    public class Gradient : Object
    {
        public UIntPtr colorKeys; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFD54CC9EA0
        public void Cleanup(){} // RVA: 0x7FFD54CC9EF0
        public void Internal_Equals(){} // RVA: 0x7FFD54CC9F40
        public void .ctor(){} // RVA: 0x7FFD54CC9FA0
        public void Finalize(){} // RVA: 0x7FFD54CC9FF0
        public void Evaluate(){} // RVA: 0x7FFD54CCA070
        public void get_colorKeys(){} // RVA: 0x7FFD54CCA0F0
        public void set_colorKeys(){} // RVA: 0x7FFD54CCA140
        public void get_alphaKeys(){} // RVA: 0x7FFD54CCA1A0
        public void set_alphaKeys(){} // RVA: 0x7FFD54CCA1F0
        public void get_mode(){} // RVA: 0x7FFD54CCA250
        public void set_mode(){} // RVA: 0x7FFD54CCA2A0
        public void get_colorSpace(){} // RVA: 0x7FFD54CCA300
        public void set_colorSpace(){} // RVA: 0x7FFD54CCA350
        public void SetKeys(){} // RVA: 0x7FFD54CCA3B0
        public void Equals(){} // RVA: 0x7FFD54CCA530 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFD54C71CE0
        public void Evaluate_Injected(){} // RVA: 0x7FFD54CCA670
    }

    public class GradientAlphaKey : ValueType
    {
        public float alpha; // 0x10
        public float time; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E364D10
    }

    public class GradientColorKey : ValueType
    {
        public UnityEngine.Color color; // 0x10
        public float time; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54CC9E90
    }

    public class GraphicsBuffer : Object
    {
        public UIntPtr count; // 0x10

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFD54CA7880
        public void Dispose(){} // RVA: 0x7FFD54CA79F0 | overloaded x2
        public void RequiresCompute(){} // RVA: 0x7FFD54CA7AD0
        public void IsVertexIndexOrCopyOnly(){} // RVA: 0x7FFD54CA7AE0
        public void InitBuffer(){} // RVA: 0x7FFD54CA7AF0
        public void DestroyBuffer(){} // RVA: 0x7FFD54CA7B70
        public void .ctor(){} // RVA: 0x7FFD54CA7BF0 | overloaded x2
        public void InternalInitialization(){} // RVA: 0x7FFD54CA7C00
        public void Release(){} // RVA: 0x7FFD54CA8060
        public void IsValidBuffer(){} // RVA: 0x7FFD54CA8070
        public void IsValid(){} // RVA: 0x7FFD54CA80C0
        public void get_count(){} // RVA: 0x7FFD54CA8130
        public void get_stride(){} // RVA: 0x7FFD54CA8180
        public void GetUsageFlags(){} // RVA: 0x7FFD54CA81D0
        public void get_usageFlags(){} // RVA: 0x7FFD54CA81D0
        public void SetData(){} // RVA: 0x7FFD54CA8220
        public void InternalSetData(){} // RVA: 0x7FFD54CA8400
        public void BeginBufferWrite(){} // RVA: 0x7FFD54CA8490
        public void LockBufferForWrite(){} // RVA: 0x7FFD4E2ADC40
        public void EndBufferWrite(){} // RVA: 0x7FFD54CA8500
        public void UnlockBufferAfterWrite(){} // RVA: 0x7FFD4E090ED0
    }

    public class Grid : GridLayout
    {
        public object cellSize;
        public object cellGap;
        public object cellLayout;
        public object cellSwizzle;

        // ── Methods ──
        public void GetCellCenterLocal(){} // RVA: 0x7FFD54D23930
        public void GetCellCenterWorld(){} // RVA: 0x7FFD54D23AA0
        public void get_cellSize(){} // RVA: 0x7FFD54D23C70
        public void set_cellSize(){} // RVA: 0x7FFD54D23CE0
        public void get_cellGap(){} // RVA: 0x7FFD54D23D40
        public void set_cellGap(){} // RVA: 0x7FFD54D23DB0
        public void get_cellLayout(){} // RVA: 0x7FFD54D23E10
        public void set_cellLayout(){} // RVA: 0x7FFD54D23E60
        public void get_cellSwizzle(){} // RVA: 0x7FFD54D23EC0
        public void set_cellSwizzle(){} // RVA: 0x7FFD54D23F10
        public void Swizzle(){} // RVA: 0x7FFD54D23F70
        public void InverseSwizzle(){} // RVA: 0x7FFD54D23FF0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_cellSize_Injected(){} // RVA: 0x7FFD54D24070
        public void set_cellSize_Injected(){} // RVA: 0x7FFD54D240D0
        public void get_cellGap_Injected(){} // RVA: 0x7FFD54D24130
        public void set_cellGap_Injected(){} // RVA: 0x7FFD54D24190
        public void Swizzle_Injected(){} // RVA: 0x7FFD54D241F0
        public void InverseSwizzle_Injected(){} // RVA: 0x7FFD54D24260
    }

    public class GridLayout : Behaviour
    {
        public object cellSize;
        public object cellGap;
        public object cellLayout;
        public object cellSwizzle;

        // ── Methods ──
        public void get_cellSize(){} // RVA: 0x7FFD54D242D0
        public void get_cellGap(){} // RVA: 0x7FFD54D24340
        public void get_cellLayout(){} // RVA: 0x7FFD54D243B0
        public void get_cellSwizzle(){} // RVA: 0x7FFD54D24400
        public void GetBoundsLocal(){} // RVA: 0x7FFD54D244D0 | overloaded x2
        public void GetBoundsLocalOriginSize(){} // RVA: 0x7FFD54D245A0
        public void CellToLocal(){} // RVA: 0x7FFD54D24630
        public void LocalToCell(){} // RVA: 0x7FFD54D246B0
        public void CellToLocalInterpolated(){} // RVA: 0x7FFD54D24730
        public void LocalToCellInterpolated(){} // RVA: 0x7FFD54D247B0
        public void CellToWorld(){} // RVA: 0x7FFD54D24830
        public void WorldToCell(){} // RVA: 0x7FFD54D248B0
        public void LocalToWorld(){} // RVA: 0x7FFD54D24930
        public void WorldToLocal(){} // RVA: 0x7FFD54D249B0
        public void GetLayoutCellCenter(){} // RVA: 0x7FFD54D24A30
        public void DoNothing(){} // RVA: 0x7FFD4E341310
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_cellSize_Injected(){} // RVA: 0x7FFD54D24AA0
        public void get_cellGap_Injected(){} // RVA: 0x7FFD54D24B00
        public void GetBoundsLocal_Injected(){} // RVA: 0x7FFD54D24B60
        public void GetBoundsLocalOriginSize_Injected(){} // RVA: 0x7FFD54D24BD0
        public void CellToLocal_Injected(){} // RVA: 0x7FFD54D24C50
        public void LocalToCell_Injected(){} // RVA: 0x7FFD54D24CC0
        public void CellToLocalInterpolated_Injected(){} // RVA: 0x7FFD54D24D30
        public void LocalToCellInterpolated_Injected(){} // RVA: 0x7FFD54D24DA0
        public void CellToWorld_Injected(){} // RVA: 0x7FFD54D24E10
        public void WorldToCell_Injected(){} // RVA: 0x7FFD54D24E80
        public void LocalToWorld_Injected(){} // RVA: 0x7FFD54D24EF0
        public void WorldToLocal_Injected(){} // RVA: 0x7FFD54D24F60
        public void GetLayoutCellCenter_Injected(){} // RVA: 0x7FFD54D24FD0
    }

}