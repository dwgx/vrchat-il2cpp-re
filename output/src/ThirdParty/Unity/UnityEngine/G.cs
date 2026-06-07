// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 34
// Methods: 822

namespace ThirdParty.Unity.UnityEngine
{
    public class GL
    {
        public object widthScaleFactor;
        public object heightScaleFactor;

        // ── Methods ──
        public void Vertex3(){} // RVA: 0x70D85E0
        public void TexCoord3(){} // RVA: 0x70D8660
        public void TexCoord(){} // RVA: 0x70D86E0
        public void TexCoord2(){} // RVA: 0x70D8700
        public void ImmediateColor(){} // RVA: 0x70D8710
        public void Color(){} // RVA: 0x70D87A0
        public void get_sRGBWrite(){} // RVA: 0x70D8800
        public void set_sRGBWrite(){} // RVA: 0x70D8850
        public void get_invertCulling(){} // RVA: 0x70D88A0
        public void set_invertCulling(){} // RVA: 0x70D88F0
        public void Flush(){} // RVA: 0x70D8940
        public void SetViewMatrix(){} // RVA: 0x70D8990
        public void set_modelview(){} // RVA: 0x70D89E0
        public void PushMatrix(){} // RVA: 0x70D8A50
        public void PopMatrix(){} // RVA: 0x70D8AA0
        public void LoadOrtho(){} // RVA: 0x70D8AF0
        public void LoadProjectionMatrix(){} // RVA: 0x70D8B40
        public void InvalidateState(){} // RVA: 0x70D8B90
        public void GetGPUProjectionMatrix(){} // RVA: 0x70D8BE0
        public void GLLoadPixelMatrixScript(){} // RVA: 0x70D8C70
        public void LoadPixelMatrix(){} // RVA: 0x70D8C70
        public void GLIssuePluginEvent(){} // RVA: 0x70D8D00
        public void IssuePluginEvent(){} // RVA: 0x70D8D60
        public void Begin(){} // RVA: 0x70D8E20
        public void End(){} // RVA: 0x70D8E70
        public void GLClear(){} // RVA: 0x70D8EC0
        public void Clear(){} // RVA: 0x70D8FC0 | overloaded x2
        public void Viewport(){} // RVA: 0x70D9040
        public void SetViewMatrix_Injected(){} // RVA: 0x70D9090
        public void LoadProjectionMatrix_Injected(){} // RVA: 0x70D90E0
        public void GetGPUProjectionMatrix_Injected(){} // RVA: 0x70D9130
        public void GLClear_Injected(){} // RVA: 0x70D91A0
        public void Viewport_Injected(){} // RVA: 0x70D9220
    }

    public class GUI
    {
        // ── Methods ──
        public void get_color(){} // RVA: 0x71718B0
        public void set_color(){} // RVA: 0x7171940
        public void get_backgroundColor(){} // RVA: 0x71719D0
        public void set_backgroundColor(){} // RVA: 0x7171A60
        public void get_contentColor(){} // RVA: 0x7171AF0
        public void set_contentColor(){} // RVA: 0x7171B80
        public void get_changed(){} // RVA: 0x7171C10
        public void set_changed(){} // RVA: 0x7171C60
        public void get_enabled(){} // RVA: 0x7171CB0
        public void set_enabled(){} // RVA: 0x7171D00
        public void set_depth(){} // RVA: 0x7171D50
        public void get_usePageScrollbars(){} // RVA: 0x7171DA0
        public void get_blendMaterial(){} // RVA: 0x7171DF0
        public void get_blitMaterial(){} // RVA: 0x7171E40
        public void get_roundedRectMaterial(){} // RVA: 0x7171E90
        public void get_roundedRectWithColorPerBorderMaterial(){} // RVA: 0x7171EE0
        public void GrabMouseControl(){} // RVA: 0x7171F30
        public void HasMouseControl(){} // RVA: 0x7171F80
        public void ReleaseMouseControl(){} // RVA: 0x7171FD0
        public void SetNextControlName(){} // RVA: 0x7172020
        public void InternalRepaintEditorWindow(){} // RVA: 0x7172070
        public void Internal_DoWindow(){} // RVA: 0x71720C0
        public void .cctor(){} // RVA: 0x71721C0
        public void get_scrollTroughSide(){} // RVA: 0x7172500
        public void set_scrollTroughSide(){} // RVA: 0x7172560
        public void get_nextScrollStepTime(){} // RVA: 0x71725C0
        public void set_nextScrollStepTime(){} // RVA: 0x7172620
        public void set_skin(){} // RVA: 0x7172680
        public void get_skin(){} // RVA: 0x7172700
        public void DoSetSkin(){} // RVA: 0x7172790
        public void get_matrix(){} // RVA: 0x7172B10
        public void set_matrix(){} // RVA: 0x7172BB0
        public void Label(){} // RVA: 0x7172F80 | overloaded x4
        public void DrawTexture(){} // RVA: 0x7173CE0 | overloaded x9
        public void CalculateScaledTextureRects(){} // RVA: 0x7174580
        public void DrawTextureWithTexCoords(){} // RVA: 0x71747C0 | overloaded x2
        public void Box(){} // RVA: 0x7174F20 | overloaded x3
        public void Button(){} // RVA: 0x71752E0 | overloaded x3
        public void DoRepeatButton(){} // RVA: 0x7175510
        public void PasswordFieldGetStrToShow(){} // RVA: 0x7175870
        public void DoTextField(){} // RVA: 0x7175BA0 | overloaded x3
        public void HandleTextFieldEventForTouchscreen(){} // RVA: 0x7176210
        public void HandleTextFieldEventForDesktop(){} // RVA: 0x71768B0
        public void HandleTextFieldEventForDesktopWithForcedKeyboard(){} // RVA: 0x7177210
        public void Toggle(){} // RVA: 0x71776C0
        public void SelectionGrid(){} // RVA: 0x7177920
        public void CalcTotalHorizSpacing(){} // RVA: 0x7177A20
        public void DoControl(){} // RVA: 0x7177DB0
        public void DoLabel(){} // RVA: 0x7178200
        public void DoToggle(){} // RVA: 0x71785E0
        public void DoButton(){} // RVA: 0x7178750
        public void DoButtonGrid(){} // RVA: 0x71788C0
        public void CalcGridRects(){} // RVA: 0x7179540
        public void HorizontalSlider(){} // RVA: 0x71798E0
        public void Slider(){} // RVA: 0x71799B0
        public void HorizontalScrollbar(){} // RVA: 0x7179C90
        public void ScrollerRepeatButton(){} // RVA: 0x7179E90
        public void VerticalScrollbar(){} // RVA: 0x717A1D0
        public void Scroller(){} // RVA: 0x717A3D0
        public void BeginGroup(){} // RVA: 0x717AD90 | overloaded x2
        public void EndGroup(){} // RVA: 0x717B0F0
        public void get_scrollViewStates(){} // RVA: 0x717B180
        public void BeginScrollView(){} // RVA: 0x717B1E0
        public void EndScrollView(){} // RVA: 0x717C220
        public void Window(){} // RVA: 0x717D670 | overloaded x2
        public void DoWindow(){} // RVA: 0x717D770
        public void CallWindowDelegate(){} // RVA: 0x717D910
        public void get_color_Injected(){} // RVA: 0x717DC40
        public void set_color_Injected(){} // RVA: 0x717DC90
        public void get_backgroundColor_Injected(){} // RVA: 0x717DCE0
        public void set_backgroundColor_Injected(){} // RVA: 0x717DD30
        public void get_contentColor_Injected(){} // RVA: 0x717DD80
        public void set_contentColor_Injected(){} // RVA: 0x717DDD0
        public void Internal_DoWindow_Injected(){} // RVA: 0x717DE20
    }

    public class GUIClip
    {
        // ── Methods ──
        public void get_visibleRect(){} // RVA: 0x717DEB0
        public void Internal_Push(){} // RVA: 0x717DF10
        public void Internal_Pop(){} // RVA: 0x717DF90
        public void Internal_GetCount(){} // RVA: 0x717DFE0
        public void Unclip_Vector2(){} // RVA: 0x717E030
        public void UnclipToWindow_Vector2(){} // RVA: 0x717E0A0
        public void GetMatrix(){} // RVA: 0x717E110
        public void SetMatrix(){} // RVA: 0x717E180
        public void Internal_PushParentClip(){} // RVA: 0x717E280 | overloaded x2
        public void Internal_PopParentClip(){} // RVA: 0x717E2F0
        public void Push(){} // RVA: 0x717E340
        public void Pop(){} // RVA: 0x717DF90
        public void Unclip(){} // RVA: 0x717E3C0
        public void UnclipToWindow(){} // RVA: 0x717E430
        public void get_visibleRect_Injected(){} // RVA: 0x717E4A0
        public void Internal_Push_Injected(){} // RVA: 0x717E4F0
        public void Unclip_Vector2_Injected(){} // RVA: 0x717E570
        public void UnclipToWindow_Vector2_Injected(){} // RVA: 0x717E5D0
        public void GetMatrix_Injected(){} // RVA: 0x717E630
        public void SetMatrix_Injected(){} // RVA: 0x717E680
        public void Internal_PushParentClip_Injected(){} // RVA: 0x717E6D0
    }

    public class GUIContent
    {
        // ── Methods ──
        public void get_text(){} // RVA: 0x33B6D40
        public void set_text(){} // RVA: 0x717E850
        public void set_image(){} // RVA: 0x343E80
        public void get_tooltip(){} // RVA: 0x6A24380
        public void set_tooltip(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x717ECC0 | overloaded x5
        public void Temp(){} // RVA: 0x717F4A0 | overloaded x3
        public void ClearStaticCache(){} // RVA: 0x717F170
        public void ToString(){} // RVA: 0x717F660
        public void .cctor(){} // RVA: 0x717F6B0
    }

    public class GUIElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class GUIGridSizer
    {
        // ── Methods ──
        public void GetRect(){} // RVA: 0x71920B0
        public void .ctor(){} // RVA: 0x71922E0
        public void get_rows(){} // RVA: 0x7192A50
    }

    public class GUILayer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class GUILayout
    {
        // ── Methods ──
        public void Label(){} // RVA: 0x717FA10 | overloaded x2
        public void DoLabel(){} // RVA: 0x717FA90
        public void Box(){} // RVA: 0x717FBF0
        public void DoBox(){} // RVA: 0x717FEB0
        public void Button(){} // RVA: 0x717FFB0
        public void DoButton(){} // RVA: 0x7180130
        public void TextField(){} // RVA: 0x71802C0 | overloaded x2
        public void DoTextField(){} // RVA: 0x7180350
        public void Toggle(){} // RVA: 0x71806A0
        public void DoToggle(){} // RVA: 0x7180840
        public void SelectionGrid(){} // RVA: 0x7180CC0 | overloaded x2
        public void HorizontalSlider(){} // RVA: 0x7180E30
        public void DoHorizontalSlider(){} // RVA: 0x71810A0
        public void Space(){} // RVA: 0x7181280
        public void FlexibleSpace(){} // RVA: 0x71815D0
        public void BeginHorizontal(){} // RVA: 0x71819D0 | overloaded x2
        public void EndHorizontal(){} // RVA: 0x7181BB0
        public void BeginVertical(){} // RVA: 0x7181D10 | overloaded x3
        public void EndVertical(){} // RVA: 0x7181EF0
        public void BeginArea(){} // RVA: 0x7181FF0 | overloaded x2
        public void EndArea(){} // RVA: 0x7182320
        public void BeginScrollView(){} // RVA: 0x71825B0 | overloaded x2
        public void EndScrollView(){} // RVA: 0x7182A40 | overloaded x2
        public void Window(){} // RVA: 0x7182AC0
        public void DoWindow(){} // RVA: 0x7182BE0
        public void Width(){} // RVA: 0x7182ED0
        public void Height(){} // RVA: 0x7182FA0
        public void ExpandWidth(){} // RVA: 0x7183070
        public void ExpandHeight(){} // RVA: 0x7183130
    }

    public class GUILayoutEntry
    {
        // ── Methods ──
        public void get_style(){} // RVA: 0x7187E30
        public void set_style(){} // RVA: 0x7190F90
        public void get_marginLeft(){} // RVA: 0x7191000
        public void get_marginRight(){} // RVA: 0x7191070
        public void get_marginTop(){} // RVA: 0x71910E0
        public void get_marginBottom(){} // RVA: 0x7191150
        public void get_marginHorizontal(){} // RVA: 0x71911C0
        public void get_marginVertical(){} // RVA: 0x7191210
        public void .ctor(){} // RVA: 0x7191380 | overloaded x2
        public void CalcWidth(){} // RVA: 0x2DD310
        public void CalcHeight(){} // RVA: 0x2DD310
        public void SetHorizontal(){} // RVA: 0x71914A0
        public void SetVertical(){} // RVA: 0x71914B0
        public void ApplyStyleSettings(){} // RVA: 0x71914C0
        public void ApplyOptions(){} // RVA: 0x7191690
        public void ToString(){} // RVA: 0x7191A20
        public void .cctor(){} // RVA: 0x7192050
    }

    public class GUILayoutGroup
    {
        // ── Methods ──
        public void get_marginLeft(){} // RVA: 0xFC4570
        public void get_marginRight(){} // RVA: 0x1C5A600
        public void get_marginTop(){} // RVA: 0xBB90C0
        public void get_marginBottom(){} // RVA: 0x363A7C0
        public void .ctor(){} // RVA: 0x7192D20
        public void ApplyOptions(){} // RVA: 0x7192EA0
        public void ApplyStyleSettings(){} // RVA: 0x7192FB0
        public void ResetCursor(){} // RVA: 0x7193120
        public void GetNext(){} // RVA: 0x7193130
        public void Add(){} // RVA: 0x7193480
        public void CalcWidth(){} // RVA: 0x7193520
        public void SetHorizontal(){} // RVA: 0x7193E70
        public void CalcHeight(){} // RVA: 0x71948D0
        public void SetVertical(){} // RVA: 0x7195190
        public void ToString(){} // RVA: 0x7195B40
        public void .cctor(){} // RVA: 0x7195F50
    }

    public class GUILayoutOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x1CC5AF0
    }

    public class GUILayoutUtility
    {
        // ── Methods ──
        public void Internal_GetWindowRect(){} // RVA: 0x7183480
        public void Internal_MoveWindow(){} // RVA: 0x7183520
        public void get_unbalancedgroupscount(){} // RVA: 0x71835C0
        public void set_unbalancedgroupscount(){} // RVA: 0x7183620
        public void SelectIDList(){} // RVA: 0x7183680
        public void Begin(){} // RVA: 0x7183970
        public void BeginContainer(){} // RVA: 0x7183E60
        public void BeginWindow(){} // RVA: 0x71841E0
        public void Layout(){} // RVA: 0x71847C0
        public void LayoutFromEditorWindow(){} // RVA: 0x7184B40
        public void LayoutFromContainer(){} // RVA: 0x7184E80
        public void LayoutFreeGroup(){} // RVA: 0x7185070
        public void LayoutSingleGroup(){} // RVA: 0x7185270
        public void CreateGUILayoutGroupInstanceOfType(){} // RVA: 0x7185540
        public void BeginLayoutGroup(){} // RVA: 0x71856E0
        public void EndLayoutGroup(){} // RVA: 0x7185AE0
        public void BeginLayoutArea(){} // RVA: 0x7185EC0
        public void EndLayoutArea(){} // RVA: 0x7186280
        public void GetRect(){} // RVA: 0x7186C10 | overloaded x3
        public void DoGetRect(){} // RVA: 0x7186CD0 | overloaded x2
        public void get_spaceStyle(){} // RVA: 0x7186F20
        public void .cctor(){} // RVA: 0x71870B0
        public void Internal_GetWindowRect_Injected(){} // RVA: 0x71872E0
        public void Internal_MoveWindow_Injected(){} // RVA: 0x7187340
    }

    public class GUIScrollGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7196080
        public void CalcWidth(){} // RVA: 0x71960E0
        public void SetHorizontal(){} // RVA: 0x7196180
        public void CalcHeight(){} // RVA: 0x7196360
        public void SetVertical(){} // RVA: 0x7196510
    }

    public class GUISettings
    {
        // ── Methods ──
        public void Internal_GetCursorFlashSpeed(){} // RVA: 0x71877C0
        public void get_doubleClickSelectsWord(){} // RVA: 0x7187810
        public void get_tripleClickSelectsLine(){} // RVA: 0x7187820
        public void get_cursorColor(){} // RVA: 0x2EDFC90
        public void get_cursorFlashSpeed(){} // RVA: 0x7187830
        public void get_selectionColor(){} // RVA: 0x7187890
        public void .ctor(){} // RVA: 0x71878A0
    }

    public class GUISkin
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x71878D0
        public void OnEnable(){} // RVA: 0x7187A80
        public void CleanupRoots(){} // RVA: 0x7187A90
        public void get_font(){} // RVA: 0x2F0F420
        public void set_font(){} // RVA: 0x7187B90
        public void get_box(){} // RVA: 0x6A24380
        public void set_box(){} // RVA: 0x7187D60
        public void get_label(){} // RVA: 0x7187DC0
        public void set_label(){} // RVA: 0x7187DD0
        public void get_textField(){} // RVA: 0x7187E30
        public void set_textField(){} // RVA: 0x7187E40
        public void get_textArea(){} // RVA: 0x7187EA0
        public void set_textArea(){} // RVA: 0x7187EB0
        public void get_button(){} // RVA: 0x7145590
        public void set_button(){} // RVA: 0x7187F10
        public void get_toggle(){} // RVA: 0x7145E90
        public void set_toggle(){} // RVA: 0x7187F70
        public void get_window(){} // RVA: 0x7187FD0
        public void set_window(){} // RVA: 0x7187FE0
        public void get_horizontalSlider(){} // RVA: 0x7188040
        public void set_horizontalSlider(){} // RVA: 0x7188050
        public void get_horizontalSliderThumb(){} // RVA: 0x71880B0
        public void set_horizontalSliderThumb(){} // RVA: 0x71880C0
        public void get_horizontalSliderThumbExtent(){} // RVA: 0x7188120
        public void set_horizontalSliderThumbExtent(){} // RVA: 0x7188130
        public void get_sliderMixed(){} // RVA: 0x7188190
        public void set_sliderMixed(){} // RVA: 0x71881A0
        public void get_verticalSlider(){} // RVA: 0x7188200
        public void set_verticalSlider(){} // RVA: 0x7188210
        public void get_verticalSliderThumb(){} // RVA: 0x7188270
        public void set_verticalSliderThumb(){} // RVA: 0x7188280
        public void get_verticalSliderThumbExtent(){} // RVA: 0x71882E0
        public void set_verticalSliderThumbExtent(){} // RVA: 0x71882F0
        public void get_horizontalScrollbar(){} // RVA: 0x7188350
        public void set_horizontalScrollbar(){} // RVA: 0x7188360
        public void get_horizontalScrollbarThumb(){} // RVA: 0x71883C0
        public void set_horizontalScrollbarThumb(){} // RVA: 0x71883D0
        public void get_horizontalScrollbarLeftButton(){} // RVA: 0x7188430
        public void set_horizontalScrollbarLeftButton(){} // RVA: 0x7188440
        public void get_horizontalScrollbarRightButton(){} // RVA: 0x71884A0
        public void set_horizontalScrollbarRightButton(){} // RVA: 0x71884B0
        public void get_verticalScrollbar(){} // RVA: 0x7188510
        public void set_verticalScrollbar(){} // RVA: 0x7188520
        public void get_verticalScrollbarThumb(){} // RVA: 0x7188580
        public void set_verticalScrollbarThumb(){} // RVA: 0x7188590
        public void get_verticalScrollbarUpButton(){} // RVA: 0x71885F0
        public void set_verticalScrollbarUpButton(){} // RVA: 0x7188600
        public void get_verticalScrollbarDownButton(){} // RVA: 0x7188660
        public void set_verticalScrollbarDownButton(){} // RVA: 0x7188670
        public void get_scrollView(){} // RVA: 0x71886D0
        public void set_scrollView(){} // RVA: 0x71886E0
        public void get_customStyles(){} // RVA: 0x7188740
        public void set_customStyles(){} // RVA: 0x7188750
        public void get_settings(){} // RVA: 0x71887B0
        public void get_error(){} // RVA: 0x71887C0
        public void Apply(){} // RVA: 0x71888F0
        public void BuildStyleCache(){} // RVA: 0x7188970
        public void GetStyle(){} // RVA: 0x718A350
        public void FindStyle(){} // RVA: 0x718A630
        public void MakeCurrent(){} // RVA: 0x718A6D0
        public void GetEnumerator(){} // RVA: 0x718A800
    }

    public class GUIStateObjects
    {
        // ── Methods ──
        public void GetStateObject(){} // RVA: 0x718A940
        public void .cctor(){} // RVA: 0x718AAC0
    }

    public class GUIStyle
    {
        // ── Methods ──
        public void get_rawName(){} // RVA: 0x718AF00
        public void set_rawName(){} // RVA: 0x718AF50
        public void get_font(){} // RVA: 0x718AFB0
        public void get_imagePosition(){} // RVA: 0x718B000
        public void get_wordWrap(){} // RVA: 0x718B050
        public void get_contentOffset(){} // RVA: 0x718B0A0
        public void set_contentOffset(){} // RVA: 0x718B100
        public void get_fixedWidth(){} // RVA: 0x718B160
        public void get_fixedHeight(){} // RVA: 0x718B1B0
        public void get_stretchWidth(){} // RVA: 0x718B200
        public void set_stretchWidth(){} // RVA: 0x718B250
        public void get_stretchHeight(){} // RVA: 0x718B2B0
        public void set_stretchHeight(){} // RVA: 0x718B300
        public void set_Internal_clipOffset(){} // RVA: 0x718B360
        public void Internal_Create(){} // RVA: 0x718B3C0
        public void Internal_Copy(){} // RVA: 0x718B410
        public void Internal_Destroy(){} // RVA: 0x718B470
        public void GetStyleStatePtr(){} // RVA: 0x718B4C0
        public void GetRectOffsetPtr(){} // RVA: 0x718B520
        public void Internal_GetLineHeight(){} // RVA: 0x718B580
        public void Internal_Draw(){} // RVA: 0x718B5D0
        public void Internal_Draw2(){} // RVA: 0x718B680
        public void Internal_DrawCursor(){} // RVA: 0x718B710
        public void Internal_DrawWithTextSelection(){} // RVA: 0x718B7A0
        public void Internal_GetCursorPixelPosition(){} // RVA: 0x718B890
        public void Internal_GetCursorStringIndex(){} // RVA: 0x718B930
        public void Internal_GetSelectedRenderedText(){} // RVA: 0x718B9B0
        public void Internal_CalcSize(){} // RVA: 0x718BA40
        public void Internal_CalcSizeWithConstraints(){} // RVA: 0x718BAB0
        public void Internal_CalcHeight(){} // RVA: 0x718BB30
        public void Internal_CalcMinMaxWidth(){} // RVA: 0x718BBA0
        public void SetMouseTooltip(){} // RVA: 0x718BC10
        public void IsTooltipActive(){} // RVA: 0x718BCB0
        public void Internal_GetCursorFlashOffset(){} // RVA: 0x718BD00
        public void SetDefaultFont(){} // RVA: 0x718BD50
        public void .ctor(){} // RVA: 0x718BE30 | overloaded x2
        public void Finalize(){} // RVA: 0x718BF20
        public void get_name(){} // RVA: 0x718BFF0
        public void set_name(){} // RVA: 0x718C0B0
        public void get_normal(){} // RVA: 0x718C160
        public void get_border(){} // RVA: 0x718C2C0
        public void get_margin(){} // RVA: 0x718C420
        public void get_padding(){} // RVA: 0x718C580
        public void get_lineHeight(){} // RVA: 0x718C6E0
        public void Draw(){} // RVA: 0x718CB40 | overloaded x6
        public void DrawCursor(){} // RVA: 0x718CC60
        public void DrawWithTextSelection(){} // RVA: 0x718D5D0 | overloaded x3
        public void get_none(){} // RVA: 0x718D610
        public void GetCursorPixelPosition(){} // RVA: 0x718D710
        public void GetCursorStringIndex(){} // RVA: 0x718D7B0
        public void CalcSize(){} // RVA: 0x718BA40
        public void CalcSizeWithConstraints(){} // RVA: 0x718BAB0
        public void CalcHeight(){} // RVA: 0x718BB30
        public void get_isHeightDependantOnWidth(){} // RVA: 0x718D830
        public void CalcMinMaxWidth(){} // RVA: 0x718D930
        public void ToString(){} // RVA: 0x718D9D0
        public void .cctor(){} // RVA: 0x718DA90
        public void get_contentOffset_Injected(){} // RVA: 0x718DAD0
        public void set_contentOffset_Injected(){} // RVA: 0x718DB30
        public void set_Internal_clipOffset_Injected(){} // RVA: 0x718DB90
        public void Internal_Draw_Injected(){} // RVA: 0x718DBF0
        public void Internal_Draw2_Injected(){} // RVA: 0x718DCA0
        public void Internal_DrawCursor_Injected(){} // RVA: 0x718DD30
        public void Internal_DrawWithTextSelection_Injected(){} // RVA: 0x718DDC0
        public void Internal_GetCursorPixelPosition_Injected(){} // RVA: 0x718DE90
        public void Internal_GetCursorStringIndex_Injected(){} // RVA: 0x718DF20
        public void Internal_GetSelectedRenderedText_Injected(){} // RVA: 0x718DFA0
        public void Internal_CalcSize_Injected(){} // RVA: 0x718E030
        public void Internal_CalcSizeWithConstraints_Injected(){} // RVA: 0x718E0A0
        public void Internal_CalcMinMaxWidth_Injected(){} // RVA: 0x718E120
        public void SetMouseTooltip_Injected(){} // RVA: 0x718E190
    }

    public class GUIStyleState
    {
        public object doubleClickSelectsWord;
        public object tripleClickSelectsLine;

        // ── Methods ──
        public void set_background(){} // RVA: 0x718ABA0
        public void set_textColor(){} // RVA: 0x718AC00
        public void Init(){} // RVA: 0x718AC60
        public void Cleanup(){} // RVA: 0x718ACB0
        public void .ctor(){} // RVA: 0x70CF080 | overloaded x2
        public void GetGUIStyleState(){} // RVA: 0x718AD50
        public void Finalize(){} // RVA: 0x718AE10
        public void set_textColor_Injected(){} // RVA: 0x718AEA0
    }

    public class GUITargetAttribute
    {
        // ── Methods ──
        public void GetGUITargetAttrValue(){} // RVA: 0x718E1F0
    }

    public class GUIText
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class GUITexture
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class GUIUtility
    {
        // ── Methods ──
        public void get_pixelsPerPoint(){} // RVA: 0x718E450
        public void get_guiDepth(){} // RVA: 0x718E4A0
        public void set_mouseUsed(){} // RVA: 0x718E4F0
        public void get_textFieldInput(){} // RVA: 0x718E540
        public void set_textFieldInput(){} // RVA: 0x718E590
        public void get_systemCopyBuffer(){} // RVA: 0x718E5E0
        public void set_systemCopyBuffer(){} // RVA: 0x718E630
        public void Internal_GetControlID(){} // RVA: 0x718E680
        public void GetControlID(){} // RVA: 0x718EF30 | overloaded x3
        public void BeginContainerFromOwner(){} // RVA: 0x718E820
        public void BeginContainer(){} // RVA: 0x718E870
        public void Internal_EndContainer(){} // RVA: 0x718E8C0
        public void CheckForTabEvent(){} // RVA: 0x718E910
        public void SetKeyboardControlToFirstControlId(){} // RVA: 0x718E960
        public void SetKeyboardControlToLastControlId(){} // RVA: 0x718E9B0
        public void HasFocusableControls(){} // RVA: 0x718EA00
        public void OwnsId(){} // RVA: 0x718EA50
        public void AlignRectToDevice(){} // RVA: 0x71906E0 | overloaded x2
        public void get_compositionString(){} // RVA: 0x718EB60
        public void set_imeCompositionMode(){} // RVA: 0x718EBB0
        public void set_compositionCursorPos(){} // RVA: 0x718EC00
        public void Internal_GetHotControl(){} // RVA: 0x718EC90
        public void Internal_GetKeyboardControl(){} // RVA: 0x718ECE0
        public void Internal_SetHotControl(){} // RVA: 0x718ED30
        public void Internal_SetKeyboardControl(){} // RVA: 0x718ED80
        public void Internal_GetDefaultSkin(){} // RVA: 0x718EDD0
        public void Internal_ExitGUI(){} // RVA: 0x718EE20
        public void MarkGUIChanged(){} // RVA: 0x718EE70
        public void GetStateObject(){} // RVA: 0x718EFB0
        public void set_guiIsExiting(){} // RVA: 0x718F170
        public void get_hotControl(){} // RVA: 0x718F1D0
        public void set_hotControl(){} // RVA: 0x718F250
        public void TakeCapture(){} // RVA: 0x718F2E0
        public void RemoveCapture(){} // RVA: 0x718F350
        public void get_keyboardControl(){} // RVA: 0x718F3C0
        public void set_keyboardControl(){} // RVA: 0x718F440
        public void HasKeyFocus(){} // RVA: 0x718F4D0
        public void ExitGUI(){} // RVA: 0x718F5B0
        public void GetDefaultSkin(){} // RVA: 0x718F5F0
        public void ProcessEvent(){} // RVA: 0x718F6C0
        public void EndContainer(){} // RVA: 0x718F910
        public void BeginGUI(){} // RVA: 0x718F9D0
        public void EndGUI(){} // RVA: 0x718FA90
        public void EndGUIFromException(){} // RVA: 0x718FCB0
        public void EndContainerGUIFromException(){} // RVA: 0x718FD40
        public void ResetGlobalState(){} // RVA: 0x718FDE0
        public void IsExitGUIException(){} // RVA: 0x718FF40
        public void ShouldRethrowException(){} // RVA: 0x718FFD0
        public void CheckOnGUI(){} // RVA: 0x7190090
        public void RoundToPixelGrid(){} // RVA: 0x7190170
        public void ScaleAroundPivot(){} // RVA: 0x7190260
        public void HitTest(){} // RVA: 0x7190930 | overloaded x3
        public void .cctor(){} // RVA: 0x7190A10
        public void Internal_GetControlID_Injected(){} // RVA: 0x7190B20
        public void AlignRectToDevice_Injected(){} // RVA: 0x7190B90
        public void set_compositionCursorPos_Injected(){} // RVA: 0x7190C10
    }

    public class GUIWordWrapSizer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7192A70
        public void CalcWidth(){} // RVA: 0x7192BA0
        public void CalcHeight(){} // RVA: 0x7192CA0
    }

    public class GameObject
    {
        public object count;
        public object stride;
        public object usageFlags;

        // ── Methods ──
        public void CreatePrimitive(){} // RVA: 0x7127AD0
        public void GetComponent(){} // RVA: 0x7127BF0 | overloaded x3
        public void GetComponentFastPath(){} // RVA: 0x7127B80
        public void GetComponentByName(){} // RVA: 0x7127BF0
        public void GetComponentInChildren(){} // RVA: 0x283FA0 | overloaded x4
        public void GetComponentInParent(){} // RVA: 0x283FA0 | overloaded x4
        public void GetComponentsInternal(){} // RVA: 0x7127E10
        public void GetComponents(){} // RVA: 0x24B10 | overloaded x4
        public void GetComponentsInChildren(){} // RVA: 0x24B10 | overloaded x6
        public void GetComponentsInParent(){} // RVA: 0xCD60 | overloaded x5
        public void TryGetComponent(){} // RVA: 0x71281E0 | overloaded x2
        public void TryGetComponentInternal(){} // RVA: 0x7128360
        public void TryGetComponentFastPath(){} // RVA: 0x71283C0
        public void FindWithTag(){} // RVA: 0x7128430
        public void SendMessageUpwards(){} // RVA: 0x7128DD0 | overloaded x4
        public void SendMessage(){} // RVA: 0x7128E90 | overloaded x4
        public void BroadcastMessage(){} // RVA: 0x7128F50 | overloaded x4
        public void AddComponentInternal(){} // RVA: 0x71284E0
        public void Internal_AddComponentWithType(){} // RVA: 0x7128540
        public void AddComponent(){} // RVA: 0x283FA0 | overloaded x2
        public void GetComponentCount(){} // RVA: 0x71285A0
        public void QueryComponentAtIndex(){} // RVA: 0x71285F0
        public void GetComponentAtIndex(){} // RVA: 0x283FA0 | overloaded x2
        public void GetComponentIndex(){} // RVA: 0x7128760
        public void get_transform(){} // RVA: 0x71287C0
        public void get_layer(){} // RVA: 0x7128810
        public void set_layer(){} // RVA: 0x7128860
        public void get_active(){} // RVA: 0x71288C0
        public void set_active(){} // RVA: 0x7128910
        public void SetActive(){} // RVA: 0x7128970
        public void get_activeSelf(){} // RVA: 0x71289D0
        public void get_activeInHierarchy(){} // RVA: 0x7128A20
        public void SetActiveRecursively(){} // RVA: 0x7128A70
        public void get_isStatic(){} // RVA: 0x7128AD0
        public void set_isStatic(){} // RVA: 0x7128B20
        public void get_isStaticBatchable(){} // RVA: 0x7128B80
        public void get_tag(){} // RVA: 0x7128BD0
        public void set_tag(){} // RVA: 0x7128C20
        public void CompareTag(){} // RVA: 0x7128C80
        public void FindGameObjectWithTag(){} // RVA: 0x7128430
        public void FindGameObjectsWithTag(){} // RVA: 0x7128CE0
        public void .ctor(){} // RVA: 0x71290A0 | overloaded x3
        public void Internal_CreateGameObject(){} // RVA: 0x71291D0
        public void Find(){} // RVA: 0x7129230
        public void SetGameObjectsActive(){} // RVA: 0x71293C0 | overloaded x3
        public void InstantiateGameObjects(){} // RVA: 0x71294C0 | overloaded x2
        public void GetScene(){} // RVA: 0x71296D0
        public void get_scene(){} // RVA: 0x7129730
        public void get_sceneCullingMask(){} // RVA: 0x7129790
        public void get_gameObject(){} // RVA: 0x5F061A0
        public void InstantiateGameObjects_Injected(){} // RVA: 0x71297E0
        public void GetScene_Injected(){} // RVA: 0x7129860
        public void get_scene_Injected(){} // RVA: 0x71298C0
    }

    public class GeometryUtility
    {
        // ── Methods ──
        public void CalculateFrustumPlanes(){} // RVA: 0x70CC8C0 | overloaded x4
        public void CalculateBounds(){} // RVA: 0x70CCA00
        public void TryCreatePlaneFromPolygon(){} // RVA: 0x70CCB80
        public void TestPlanesAABB(){} // RVA: 0x70CD030
        public void Internal_ExtractPlanes(){} // RVA: 0x70CD090
        public void Internal_CalculateBounds(){} // RVA: 0x70CD0F0
        public void .ctor(){} // RVA: 0x2DD310
        public void TestPlanesAABB_Injected(){} // RVA: 0x70CD170
        public void Internal_ExtractPlanes_Injected(){} // RVA: 0x70CD1D0
        public void Internal_CalculateBounds_Injected(){} // RVA: 0x70CD230
    }

    public class Gizmos
    {
        public object order;
        public object callback;

        // ── Methods ──
        public void DrawLine(){} // RVA: 0x70CFE40
        public void DrawWireSphere(){} // RVA: 0x70CFEA0
        public void DrawSphere(){} // RVA: 0x70CFF00
        public void DrawWireCube(){} // RVA: 0x70CFF60
        public void DrawCube(){} // RVA: 0x70CFFC0
        public void DrawMesh(){} // RVA: 0x70D0800 | overloaded x3
        public void DrawWireMesh(){} // RVA: 0x70D0EA0 | overloaded x8
        public void DrawIcon(){} // RVA: 0x70D0FF0 | overloaded x3
        public void DrawGUITexture(){} // RVA: 0x70D1170 | overloaded x4
        public void get_color(){} // RVA: 0x70D02F0
        public void set_color(){} // RVA: 0x70D0350
        public void get_matrix(){} // RVA: 0x70D03A0
        public void set_matrix(){} // RVA: 0x70D0410
        public void get_probeSize(){} // RVA: 0x70D0460
        public void DrawFrustum(){} // RVA: 0x70D04B0
        public void DrawRay(){} // RVA: 0x70D0600 | overloaded x2
        public void .ctor(){} // RVA: 0x2DD310
        public void DrawLine_Injected(){} // RVA: 0x70D1210
        public void DrawWireSphere_Injected(){} // RVA: 0x70D1270
        public void DrawSphere_Injected(){} // RVA: 0x70D12D0
        public void DrawWireCube_Injected(){} // RVA: 0x70D1330
        public void DrawCube_Injected(){} // RVA: 0x70D1390
        public void DrawMesh_Injected(){} // RVA: 0x70D13F0
        public void DrawWireMesh_Injected(){} // RVA: 0x70D1470
        public void DrawIcon_Injected(){} // RVA: 0x70D14F0
        public void DrawGUITexture_Injected(){} // RVA: 0x70D1570
        public void get_color_Injected(){} // RVA: 0x70D1600
        public void set_color_Injected(){} // RVA: 0x70D1650
        public void get_matrix_Injected(){} // RVA: 0x70D16A0
        public void set_matrix_Injected(){} // RVA: 0x70D16F0
        public void DrawFrustum_Injected(){} // RVA: 0x70D1740
    }

    public class GlobalJavaObjectRef
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x707C7A0
        public void Finalize(){} // RVA: 0x707C820
        public void op_Implicit(){} // RVA: 0x100A1F0
        public void Dispose(){} // RVA: 0x707C860
    }

    public class Gradient
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7111AE0
        public void Cleanup(){} // RVA: 0x7111B30
        public void Internal_Equals(){} // RVA: 0x7111B80
        public void .ctor(){} // RVA: 0x7111BE0
        public void Finalize(){} // RVA: 0x7111C30
        public void Evaluate(){} // RVA: 0x7111CB0
        public void get_colorKeys(){} // RVA: 0x7111D30
        public void set_colorKeys(){} // RVA: 0x7111D80
        public void get_alphaKeys(){} // RVA: 0x7111DE0
        public void set_alphaKeys(){} // RVA: 0x7111E30
        public void get_mode(){} // RVA: 0x7111E90
        public void set_mode(){} // RVA: 0x7111EE0
        public void get_colorSpace(){} // RVA: 0x7111F40
        public void set_colorSpace(){} // RVA: 0x7111F90
        public void SetKeys(){} // RVA: 0x7111FF0
        public void Equals(){} // RVA: 0x7112170 | overloaded x2
        public void GetHashCode(){} // RVA: 0x70B92A0
        public void Evaluate_Injected(){} // RVA: 0x71122B0
    }

    public class GradientAlphaKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x300D10
    }

    public class GradientColorKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7111AD0
    }

    public class Graphics
    {
        // ── Methods ──
        public void Internal_GetMaxDrawMeshInstanceCount(){} // RVA: 0x70D40B0
        public void Internal_SetNullRT(){} // RVA: 0x70D4100
        public void Internal_SetRTSimple(){} // RVA: 0x70D4150
        public void Internal_SetRandomWriteTargetBuffer(){} // RVA: 0x70D4210
        public void ClearRandomWriteTargets(){} // RVA: 0x70D4280
        public void CopyTexture_Full(){} // RVA: 0x70D42D0
        public void CopyTexture_Slice(){} // RVA: 0x70D4330
        public void CopyTexture_Region(){} // RVA: 0x70D43B0
        public void ConvertTexture_Full(){} // RVA: 0x70D4440
        public void Internal_DrawMeshNow2(){} // RVA: 0x70D44A0
        public void Internal_DrawTexture(){} // RVA: 0x70D4550
        public void Internal_RenderMeshPrimitives(){} // RVA: 0x70D45A0
        public void Internal_DrawMesh(){} // RVA: 0x70D4660
        public void Internal_DrawMeshInstanced(){} // RVA: 0x70D4780
        public void Internal_DrawProcedural(){} // RVA: 0x70D4820
        public void Internal_DrawProceduralIndirect(){} // RVA: 0x70D4920
        public void Internal_BlitMaterial5(){} // RVA: 0x70D4A20
        public void Internal_BlitMaterial6(){} // RVA: 0x70D4AB0
        public void Blit2(){} // RVA: 0x70D4B40
        public void Blit3(){} // RVA: 0x70D4BA0
        public void Blit4(){} // RVA: 0x70D4C20
        public void Blit5(){} // RVA: 0x70D4CD0
        public void CreateGPUFenceImpl(){} // RVA: 0x70D4D90
        public void ExecuteCommandBuffer(){} // RVA: 0x70D4DF0
        public void ExecuteCommandBufferAsync(){} // RVA: 0x70D4E40
        public void SetRenderTargetImpl(){} // RVA: 0x70D4FB0 | overloaded x2
        public void SetRenderTarget(){} // RVA: 0x70D7F00 | overloaded x3
        public void SetRandomWriteTarget(){} // RVA: 0x70D7F80 | overloaded x2
        public void CopyTexture(){} // RVA: 0x70D5670 | overloaded x3
        public void ConvertTexture(){} // RVA: 0x70D5730
        public void CreateGraphicsFence(){} // RVA: 0x70D57D0
        public void DrawTextureImpl(){} // RVA: 0x70D58B0
        public void DrawTexture(){} // RVA: 0x70D7D40 | overloaded x7
        public void RenderMeshPrimitives(){} // RVA: 0x70D5F00
        public void DrawMeshNow(){} // RVA: 0x70D6300 | overloaded x2
        public void DrawMesh(){} // RVA: 0x70D7A40 | overloaded x4
        public void DrawMeshInstanced(){} // RVA: 0x70D6960
        public void DrawProcedural(){} // RVA: 0x70D7030
        public void DrawProceduralIndirect(){} // RVA: 0x70D7180
        public void Blit(){} // RVA: 0x70D7990 | overloaded x9
        public void .cctor(){} // RVA: 0x70D7FE0
        public void Internal_SetRTSimple_Injected(){} // RVA: 0x70D8190
        public void Internal_DrawMeshNow2_Injected(){} // RVA: 0x70D8220
        public void Internal_RenderMeshPrimitives_Injected(){} // RVA: 0x70D8290
        public void Internal_DrawMesh_Injected(){} // RVA: 0x70D8310
        public void Internal_DrawProcedural_Injected(){} // RVA: 0x70D83B0
        public void Internal_DrawProceduralIndirect_Injected(){} // RVA: 0x70D8440
        public void Blit4_Injected(){} // RVA: 0x70D84D0
        public void Blit5_Injected(){} // RVA: 0x70D8550
    }

    public class GraphicsBuffer
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x70EF4E0
        public void Dispose(){} // RVA: 0x70EF650 | overloaded x2
        public void RequiresCompute(){} // RVA: 0x70EF730
        public void IsVertexIndexOrCopyOnly(){} // RVA: 0x70EF740
        public void InitBuffer(){} // RVA: 0x70EF750
        public void DestroyBuffer(){} // RVA: 0x70EF7D0
        public void .ctor(){} // RVA: 0x70EF850 | overloaded x2
        public void InternalInitialization(){} // RVA: 0x70EF860
        public void Release(){} // RVA: 0x70EFCC0
        public void IsValidBuffer(){} // RVA: 0x70EFCD0
        public void IsValid(){} // RVA: 0x70EFD20
        public void get_count(){} // RVA: 0x70EFD90
        public void get_stride(){} // RVA: 0x70EFDE0
        public void GetUsageFlags(){} // RVA: 0x70EFE30
        public void get_usageFlags(){} // RVA: 0x70EFE30
        public void SetData(){} // RVA: 0x70EFE80
        public void InternalSetData(){} // RVA: 0x70F0060
        public void GetNativeBufferPtr(){} // RVA: 0x70F00F0
        public void BeginBufferWrite(){} // RVA: 0x70F0140
        public void LockBufferForWrite(){} // RVA: 0x283FA0
        public void EndBufferWrite(){} // RVA: 0x70F01B0
        public void UnlockBufferAfterWrite(){} // RVA: 0x24FA0
    }

    public class Grid
    {
        // ── Methods ──
        public void GetCellCenterLocal(){} // RVA: 0x716C030
        public void GetCellCenterWorld(){} // RVA: 0x716C1A0
        public void get_cellSize(){} // RVA: 0x716C370
        public void set_cellSize(){} // RVA: 0x716C3E0
        public void get_cellGap(){} // RVA: 0x716C440
        public void set_cellGap(){} // RVA: 0x716C4B0
        public void get_cellLayout(){} // RVA: 0x716C510
        public void set_cellLayout(){} // RVA: 0x716C560
        public void get_cellSwizzle(){} // RVA: 0x716C5C0
        public void set_cellSwizzle(){} // RVA: 0x716C610
        public void Swizzle(){} // RVA: 0x716C670
        public void InverseSwizzle(){} // RVA: 0x716C6F0
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_cellSize_Injected(){} // RVA: 0x716C770
        public void set_cellSize_Injected(){} // RVA: 0x716C7D0
        public void get_cellGap_Injected(){} // RVA: 0x716C830
        public void set_cellGap_Injected(){} // RVA: 0x716C890
        public void Swizzle_Injected(){} // RVA: 0x716C8F0
        public void InverseSwizzle_Injected(){} // RVA: 0x716C960
    }

    public class GridLayout
    {
        public object x;
        public object y;
        public object z;
        public object Item;

        // ── Methods ──
        public void get_cellSize(){} // RVA: 0x716C9D0
        public void get_cellGap(){} // RVA: 0x716CA40
        public void get_cellLayout(){} // RVA: 0x716CAB0
        public void get_cellSwizzle(){} // RVA: 0x716CB00
        public void GetBoundsLocal(){} // RVA: 0x716CBD0 | overloaded x2
        public void GetBoundsLocalOriginSize(){} // RVA: 0x716CCA0
        public void CellToLocal(){} // RVA: 0x716CD30
        public void LocalToCell(){} // RVA: 0x716CDB0
        public void CellToLocalInterpolated(){} // RVA: 0x716CE30
        public void LocalToCellInterpolated(){} // RVA: 0x716CEB0
        public void CellToWorld(){} // RVA: 0x716CF30
        public void WorldToCell(){} // RVA: 0x716CFB0
        public void LocalToWorld(){} // RVA: 0x716D030
        public void WorldToLocal(){} // RVA: 0x716D0B0
        public void GetLayoutCellCenter(){} // RVA: 0x716D130
        public void DoNothing(){} // RVA: 0x2DD310
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_cellSize_Injected(){} // RVA: 0x716D1A0
        public void get_cellGap_Injected(){} // RVA: 0x716D200
        public void GetBoundsLocal_Injected(){} // RVA: 0x716D260
        public void GetBoundsLocalOriginSize_Injected(){} // RVA: 0x716D2D0
        public void CellToLocal_Injected(){} // RVA: 0x716D350
        public void LocalToCell_Injected(){} // RVA: 0x716D3C0
        public void CellToLocalInterpolated_Injected(){} // RVA: 0x716D430
        public void LocalToCellInterpolated_Injected(){} // RVA: 0x716D4A0
        public void CellToWorld_Injected(){} // RVA: 0x716D510
        public void WorldToCell_Injected(){} // RVA: 0x716D580
        public void LocalToWorld_Injected(){} // RVA: 0x716D5F0
        public void WorldToLocal_Injected(){} // RVA: 0x716D660
        public void GetLayoutCellCenter_Injected(){} // RVA: 0x716D6D0
    }

}