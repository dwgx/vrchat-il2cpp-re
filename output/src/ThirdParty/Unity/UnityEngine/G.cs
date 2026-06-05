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
        public void Vertex3(){} // RVA: 0x7FFAF9B885E0
        public void TexCoord3(){} // RVA: 0x7FFAF9B88660
        public void TexCoord(){} // RVA: 0x7FFAF9B886E0
        public void TexCoord2(){} // RVA: 0x7FFAF9B88700
        public void ImmediateColor(){} // RVA: 0x7FFAF9B88710
        public void Color(){} // RVA: 0x7FFAF9B887A0
        public void get_sRGBWrite(){} // RVA: 0x7FFAF9B88800
        public void set_sRGBWrite(){} // RVA: 0x7FFAF9B88850
        public void get_invertCulling(){} // RVA: 0x7FFAF9B888A0
        public void set_invertCulling(){} // RVA: 0x7FFAF9B888F0
        public void Flush(){} // RVA: 0x7FFAF9B88940
        public void SetViewMatrix(){} // RVA: 0x7FFAF9B88990
        public void set_modelview(){} // RVA: 0x7FFAF9B889E0
        public void PushMatrix(){} // RVA: 0x7FFAF9B88A50
        public void PopMatrix(){} // RVA: 0x7FFAF9B88AA0
        public void LoadOrtho(){} // RVA: 0x7FFAF9B88AF0
        public void LoadProjectionMatrix(){} // RVA: 0x7FFAF9B88B40
        public void InvalidateState(){} // RVA: 0x7FFAF9B88B90
        public void GetGPUProjectionMatrix(){} // RVA: 0x7FFAF9B88BE0
        public void GLLoadPixelMatrixScript(){} // RVA: 0x7FFAF9B88C70
        public void LoadPixelMatrix(){} // RVA: 0x7FFAF9B88C70
        public void GLIssuePluginEvent(){} // RVA: 0x7FFAF9B88D00
        public void IssuePluginEvent(){} // RVA: 0x7FFAF9B88D60
        public void Begin(){} // RVA: 0x7FFAF9B88E20
        public void End(){} // RVA: 0x7FFAF9B88E70
        public void GLClear(){} // RVA: 0x7FFAF9B88EC0
        public void Clear(){} // RVA: 0x7FFAF9B88FC0 | overloaded x2
        public void Viewport(){} // RVA: 0x7FFAF9B89040
        public void SetViewMatrix_Injected(){} // RVA: 0x7FFAF9B89090
        public void LoadProjectionMatrix_Injected(){} // RVA: 0x7FFAF9B890E0
        public void GetGPUProjectionMatrix_Injected(){} // RVA: 0x7FFAF9B89130
        public void GLClear_Injected(){} // RVA: 0x7FFAF9B891A0
        public void Viewport_Injected(){} // RVA: 0x7FFAF9B89220
    }

    public class GUI
    {
        // ── Methods ──
        public void get_color(){} // RVA: 0x7FFAF9C218B0
        public void set_color(){} // RVA: 0x7FFAF9C21940
        public void get_backgroundColor(){} // RVA: 0x7FFAF9C219D0
        public void set_backgroundColor(){} // RVA: 0x7FFAF9C21A60
        public void get_contentColor(){} // RVA: 0x7FFAF9C21AF0
        public void set_contentColor(){} // RVA: 0x7FFAF9C21B80
        public void get_changed(){} // RVA: 0x7FFAF9C21C10
        public void set_changed(){} // RVA: 0x7FFAF9C21C60
        public void get_enabled(){} // RVA: 0x7FFAF9C21CB0
        public void set_enabled(){} // RVA: 0x7FFAF9C21D00
        public void set_depth(){} // RVA: 0x7FFAF9C21D50
        public void get_usePageScrollbars(){} // RVA: 0x7FFAF9C21DA0
        public void get_blendMaterial(){} // RVA: 0x7FFAF9C21DF0
        public void get_blitMaterial(){} // RVA: 0x7FFAF9C21E40
        public void get_roundedRectMaterial(){} // RVA: 0x7FFAF9C21E90
        public void get_roundedRectWithColorPerBorderMaterial(){} // RVA: 0x7FFAF9C21EE0
        public void GrabMouseControl(){} // RVA: 0x7FFAF9C21F30
        public void HasMouseControl(){} // RVA: 0x7FFAF9C21F80
        public void ReleaseMouseControl(){} // RVA: 0x7FFAF9C21FD0
        public void SetNextControlName(){} // RVA: 0x7FFAF9C22020
        public void InternalRepaintEditorWindow(){} // RVA: 0x7FFAF9C22070
        public void Internal_DoWindow(){} // RVA: 0x7FFAF9C220C0
        public void .cctor(){} // RVA: 0x7FFAF9C221C0
        public void get_scrollTroughSide(){} // RVA: 0x7FFAF9C22500
        public void set_scrollTroughSide(){} // RVA: 0x7FFAF9C22560
        public void get_nextScrollStepTime(){} // RVA: 0x7FFAF9C225C0
        public void set_nextScrollStepTime(){} // RVA: 0x7FFAF9C22620
        public void set_skin(){} // RVA: 0x7FFAF9C22680
        public void get_skin(){} // RVA: 0x7FFAF9C22700
        public void DoSetSkin(){} // RVA: 0x7FFAF9C22790
        public void get_matrix(){} // RVA: 0x7FFAF9C22B10
        public void set_matrix(){} // RVA: 0x7FFAF9C22BB0
        public void Label(){} // RVA: 0x7FFAF9C22F80 | overloaded x4
        public void DrawTexture(){} // RVA: 0x7FFAF9C23CE0 | overloaded x9
        public void CalculateScaledTextureRects(){} // RVA: 0x7FFAF9C24580
        public void DrawTextureWithTexCoords(){} // RVA: 0x7FFAF9C247C0 | overloaded x2
        public void Box(){} // RVA: 0x7FFAF9C24F20 | overloaded x3
        public void Button(){} // RVA: 0x7FFAF9C252E0 | overloaded x3
        public void DoRepeatButton(){} // RVA: 0x7FFAF9C25510
        public void PasswordFieldGetStrToShow(){} // RVA: 0x7FFAF9C25870
        public void DoTextField(){} // RVA: 0x7FFAF9C25BA0 | overloaded x3
        public void HandleTextFieldEventForTouchscreen(){} // RVA: 0x7FFAF9C26210
        public void HandleTextFieldEventForDesktop(){} // RVA: 0x7FFAF9C268B0
        public void HandleTextFieldEventForDesktopWithForcedKeyboard(){} // RVA: 0x7FFAF9C27210
        public void Toggle(){} // RVA: 0x7FFAF9C276C0
        public void SelectionGrid(){} // RVA: 0x7FFAF9C27920
        public void CalcTotalHorizSpacing(){} // RVA: 0x7FFAF9C27A20
        public void DoControl(){} // RVA: 0x7FFAF9C27DB0
        public void DoLabel(){} // RVA: 0x7FFAF9C28200
        public void DoToggle(){} // RVA: 0x7FFAF9C285E0
        public void DoButton(){} // RVA: 0x7FFAF9C28750
        public void DoButtonGrid(){} // RVA: 0x7FFAF9C288C0
        public void CalcGridRects(){} // RVA: 0x7FFAF9C29540
        public void HorizontalSlider(){} // RVA: 0x7FFAF9C298E0
        public void Slider(){} // RVA: 0x7FFAF9C299B0
        public void HorizontalScrollbar(){} // RVA: 0x7FFAF9C29C90
        public void ScrollerRepeatButton(){} // RVA: 0x7FFAF9C29E90
        public void VerticalScrollbar(){} // RVA: 0x7FFAF9C2A1D0
        public void Scroller(){} // RVA: 0x7FFAF9C2A3D0
        public void BeginGroup(){} // RVA: 0x7FFAF9C2AD90 | overloaded x2
        public void EndGroup(){} // RVA: 0x7FFAF9C2B0F0
        public void get_scrollViewStates(){} // RVA: 0x7FFAF9C2B180
        public void BeginScrollView(){} // RVA: 0x7FFAF9C2B1E0
        public void EndScrollView(){} // RVA: 0x7FFAF9C2C220
        public void Window(){} // RVA: 0x7FFAF9C2D670 | overloaded x2
        public void DoWindow(){} // RVA: 0x7FFAF9C2D770
        public void CallWindowDelegate(){} // RVA: 0x7FFAF9C2D910
        public void get_color_Injected(){} // RVA: 0x7FFAF9C2DC40
        public void set_color_Injected(){} // RVA: 0x7FFAF9C2DC90
        public void get_backgroundColor_Injected(){} // RVA: 0x7FFAF9C2DCE0
        public void set_backgroundColor_Injected(){} // RVA: 0x7FFAF9C2DD30
        public void get_contentColor_Injected(){} // RVA: 0x7FFAF9C2DD80
        public void set_contentColor_Injected(){} // RVA: 0x7FFAF9C2DDD0
        public void Internal_DoWindow_Injected(){} // RVA: 0x7FFAF9C2DE20
    }

    public class GUIClip
    {
        // ── Methods ──
        public void get_visibleRect(){} // RVA: 0x7FFAF9C2DEB0
        public void Internal_Push(){} // RVA: 0x7FFAF9C2DF10
        public void Internal_Pop(){} // RVA: 0x7FFAF9C2DF90
        public void Internal_GetCount(){} // RVA: 0x7FFAF9C2DFE0
        public void Unclip_Vector2(){} // RVA: 0x7FFAF9C2E030
        public void UnclipToWindow_Vector2(){} // RVA: 0x7FFAF9C2E0A0
        public void GetMatrix(){} // RVA: 0x7FFAF9C2E110
        public void SetMatrix(){} // RVA: 0x7FFAF9C2E180
        public void Internal_PushParentClip(){} // RVA: 0x7FFAF9C2E280 | overloaded x2
        public void Internal_PopParentClip(){} // RVA: 0x7FFAF9C2E2F0
        public void Push(){} // RVA: 0x7FFAF9C2E340
        public void Pop(){} // RVA: 0x7FFAF9C2DF90
        public void Unclip(){} // RVA: 0x7FFAF9C2E3C0
        public void UnclipToWindow(){} // RVA: 0x7FFAF9C2E430
        public void get_visibleRect_Injected(){} // RVA: 0x7FFAF9C2E4A0
        public void Internal_Push_Injected(){} // RVA: 0x7FFAF9C2E4F0
        public void Unclip_Vector2_Injected(){} // RVA: 0x7FFAF9C2E570
        public void UnclipToWindow_Vector2_Injected(){} // RVA: 0x7FFAF9C2E5D0
        public void GetMatrix_Injected(){} // RVA: 0x7FFAF9C2E630
        public void SetMatrix_Injected(){} // RVA: 0x7FFAF9C2E680
        public void Internal_PushParentClip_Injected(){} // RVA: 0x7FFAF9C2E6D0
    }

    public class GUIContent
    {
        // ── Methods ──
        public void get_text(){} // RVA: 0x7FFAF5E66D40
        public void set_text(){} // RVA: 0x7FFAF9C2E850
        public void set_image(){} // RVA: 0x7FFAF2DF3E80
        public void get_tooltip(){} // RVA: 0x7FFAF94D4380
        public void set_tooltip(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAF9C2ECC0 | overloaded x5
        public void Temp(){} // RVA: 0x7FFAF9C2F4A0 | overloaded x3
        public void ClearStaticCache(){} // RVA: 0x7FFAF9C2F170
        public void ToString(){} // RVA: 0x7FFAF9C2F660
        public void .cctor(){} // RVA: 0x7FFAF9C2F6B0
    }

    public class GUIElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class GUIGridSizer
    {
        // ── Methods ──
        public void GetRect(){} // RVA: 0x7FFAF9C420B0
        public void .ctor(){} // RVA: 0x7FFAF9C422E0
        public void get_rows(){} // RVA: 0x7FFAF9C42A50
    }

    public class GUILayer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class GUILayout
    {
        // ── Methods ──
        public void Label(){} // RVA: 0x7FFAF9C2FA10 | overloaded x2
        public void DoLabel(){} // RVA: 0x7FFAF9C2FA90
        public void Box(){} // RVA: 0x7FFAF9C2FBF0
        public void DoBox(){} // RVA: 0x7FFAF9C2FEB0
        public void Button(){} // RVA: 0x7FFAF9C2FFB0
        public void DoButton(){} // RVA: 0x7FFAF9C30130
        public void TextField(){} // RVA: 0x7FFAF9C302C0 | overloaded x2
        public void DoTextField(){} // RVA: 0x7FFAF9C30350
        public void Toggle(){} // RVA: 0x7FFAF9C306A0
        public void DoToggle(){} // RVA: 0x7FFAF9C30840
        public void SelectionGrid(){} // RVA: 0x7FFAF9C30CC0 | overloaded x2
        public void HorizontalSlider(){} // RVA: 0x7FFAF9C30E30
        public void DoHorizontalSlider(){} // RVA: 0x7FFAF9C310A0
        public void Space(){} // RVA: 0x7FFAF9C31280
        public void FlexibleSpace(){} // RVA: 0x7FFAF9C315D0
        public void BeginHorizontal(){} // RVA: 0x7FFAF9C319D0 | overloaded x2
        public void EndHorizontal(){} // RVA: 0x7FFAF9C31BB0
        public void BeginVertical(){} // RVA: 0x7FFAF9C31D10 | overloaded x3
        public void EndVertical(){} // RVA: 0x7FFAF9C31EF0
        public void BeginArea(){} // RVA: 0x7FFAF9C31FF0 | overloaded x2
        public void EndArea(){} // RVA: 0x7FFAF9C32320
        public void BeginScrollView(){} // RVA: 0x7FFAF9C325B0 | overloaded x2
        public void EndScrollView(){} // RVA: 0x7FFAF9C32A40 | overloaded x2
        public void Window(){} // RVA: 0x7FFAF9C32AC0
        public void DoWindow(){} // RVA: 0x7FFAF9C32BE0
        public void Width(){} // RVA: 0x7FFAF9C32ED0
        public void Height(){} // RVA: 0x7FFAF9C32FA0
        public void ExpandWidth(){} // RVA: 0x7FFAF9C33070
        public void ExpandHeight(){} // RVA: 0x7FFAF9C33130
    }

    public class GUILayoutEntry
    {
        // ── Methods ──
        public void get_style(){} // RVA: 0x7FFAF9C37E30
        public void set_style(){} // RVA: 0x7FFAF9C40F90
        public void get_marginLeft(){} // RVA: 0x7FFAF9C41000
        public void get_marginRight(){} // RVA: 0x7FFAF9C41070
        public void get_marginTop(){} // RVA: 0x7FFAF9C410E0
        public void get_marginBottom(){} // RVA: 0x7FFAF9C41150
        public void get_marginHorizontal(){} // RVA: 0x7FFAF9C411C0
        public void get_marginVertical(){} // RVA: 0x7FFAF9C41210
        public void .ctor(){} // RVA: 0x7FFAF9C41380 | overloaded x2
        public void CalcWidth(){} // RVA: 0x7FFAF2D8D310
        public void CalcHeight(){} // RVA: 0x7FFAF2D8D310
        public void SetHorizontal(){} // RVA: 0x7FFAF9C414A0
        public void SetVertical(){} // RVA: 0x7FFAF9C414B0
        public void ApplyStyleSettings(){} // RVA: 0x7FFAF9C414C0
        public void ApplyOptions(){} // RVA: 0x7FFAF9C41690
        public void ToString(){} // RVA: 0x7FFAF9C41A20
        public void .cctor(){} // RVA: 0x7FFAF9C42050
    }

    public class GUILayoutGroup
    {
        // ── Methods ──
        public void get_marginLeft(){} // RVA: 0x7FFAF3A74570
        public void get_marginRight(){} // RVA: 0x7FFAF470A600
        public void get_marginTop(){} // RVA: 0x7FFAF36690C0
        public void get_marginBottom(){} // RVA: 0x7FFAF60EA7C0
        public void .ctor(){} // RVA: 0x7FFAF9C42D20
        public void ApplyOptions(){} // RVA: 0x7FFAF9C42EA0
        public void ApplyStyleSettings(){} // RVA: 0x7FFAF9C42FB0
        public void ResetCursor(){} // RVA: 0x7FFAF9C43120
        public void GetNext(){} // RVA: 0x7FFAF9C43130
        public void Add(){} // RVA: 0x7FFAF9C43480
        public void CalcWidth(){} // RVA: 0x7FFAF9C43520
        public void SetHorizontal(){} // RVA: 0x7FFAF9C43E70
        public void CalcHeight(){} // RVA: 0x7FFAF9C448D0
        public void SetVertical(){} // RVA: 0x7FFAF9C45190
        public void ToString(){} // RVA: 0x7FFAF9C45B40
        public void .cctor(){} // RVA: 0x7FFAF9C45F50
    }

    public class GUILayoutOption
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4775AF0
    }

    public class GUILayoutUtility
    {
        // ── Methods ──
        public void Internal_GetWindowRect(){} // RVA: 0x7FFAF9C33480
        public void Internal_MoveWindow(){} // RVA: 0x7FFAF9C33520
        public void get_unbalancedgroupscount(){} // RVA: 0x7FFAF9C335C0
        public void set_unbalancedgroupscount(){} // RVA: 0x7FFAF9C33620
        public void SelectIDList(){} // RVA: 0x7FFAF9C33680
        public void Begin(){} // RVA: 0x7FFAF9C33970
        public void BeginContainer(){} // RVA: 0x7FFAF9C33E60
        public void BeginWindow(){} // RVA: 0x7FFAF9C341E0
        public void Layout(){} // RVA: 0x7FFAF9C347C0
        public void LayoutFromEditorWindow(){} // RVA: 0x7FFAF9C34B40
        public void LayoutFromContainer(){} // RVA: 0x7FFAF9C34E80
        public void LayoutFreeGroup(){} // RVA: 0x7FFAF9C35070
        public void LayoutSingleGroup(){} // RVA: 0x7FFAF9C35270
        public void CreateGUILayoutGroupInstanceOfType(){} // RVA: 0x7FFAF9C35540
        public void BeginLayoutGroup(){} // RVA: 0x7FFAF9C356E0
        public void EndLayoutGroup(){} // RVA: 0x7FFAF9C35AE0
        public void BeginLayoutArea(){} // RVA: 0x7FFAF9C35EC0
        public void EndLayoutArea(){} // RVA: 0x7FFAF9C36280
        public void GetRect(){} // RVA: 0x7FFAF9C36C10 | overloaded x3
        public void DoGetRect(){} // RVA: 0x7FFAF9C36CD0 | overloaded x2
        public void get_spaceStyle(){} // RVA: 0x7FFAF9C36F20
        public void .cctor(){} // RVA: 0x7FFAF9C370B0
        public void Internal_GetWindowRect_Injected(){} // RVA: 0x7FFAF9C372E0
        public void Internal_MoveWindow_Injected(){} // RVA: 0x7FFAF9C37340
    }

    public class GUIScrollGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9C46080
        public void CalcWidth(){} // RVA: 0x7FFAF9C460E0
        public void SetHorizontal(){} // RVA: 0x7FFAF9C46180
        public void CalcHeight(){} // RVA: 0x7FFAF9C46360
        public void SetVertical(){} // RVA: 0x7FFAF9C46510
    }

    public class GUISettings
    {
        // ── Methods ──
        public void Internal_GetCursorFlashSpeed(){} // RVA: 0x7FFAF9C377C0
        public void get_doubleClickSelectsWord(){} // RVA: 0x7FFAF9C37810
        public void get_tripleClickSelectsLine(){} // RVA: 0x7FFAF9C37820
        public void get_cursorColor(){} // RVA: 0x7FFAF598FC90
        public void get_cursorFlashSpeed(){} // RVA: 0x7FFAF9C37830
        public void get_selectionColor(){} // RVA: 0x7FFAF9C37890
        public void .ctor(){} // RVA: 0x7FFAF9C378A0
    }

    public class GUISkin
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9C378D0
        public void OnEnable(){} // RVA: 0x7FFAF9C37A80
        public void CleanupRoots(){} // RVA: 0x7FFAF9C37A90
        public void get_font(){} // RVA: 0x7FFAF59BF420
        public void set_font(){} // RVA: 0x7FFAF9C37B90
        public void get_box(){} // RVA: 0x7FFAF94D4380
        public void set_box(){} // RVA: 0x7FFAF9C37D60
        public void get_label(){} // RVA: 0x7FFAF9C37DC0
        public void set_label(){} // RVA: 0x7FFAF9C37DD0
        public void get_textField(){} // RVA: 0x7FFAF9C37E30
        public void set_textField(){} // RVA: 0x7FFAF9C37E40
        public void get_textArea(){} // RVA: 0x7FFAF9C37EA0
        public void set_textArea(){} // RVA: 0x7FFAF9C37EB0
        public void get_button(){} // RVA: 0x7FFAF9BF5590
        public void set_button(){} // RVA: 0x7FFAF9C37F10
        public void get_toggle(){} // RVA: 0x7FFAF9BF5E90
        public void set_toggle(){} // RVA: 0x7FFAF9C37F70
        public void get_window(){} // RVA: 0x7FFAF9C37FD0
        public void set_window(){} // RVA: 0x7FFAF9C37FE0
        public void get_horizontalSlider(){} // RVA: 0x7FFAF9C38040
        public void set_horizontalSlider(){} // RVA: 0x7FFAF9C38050
        public void get_horizontalSliderThumb(){} // RVA: 0x7FFAF9C380B0
        public void set_horizontalSliderThumb(){} // RVA: 0x7FFAF9C380C0
        public void get_horizontalSliderThumbExtent(){} // RVA: 0x7FFAF9C38120
        public void set_horizontalSliderThumbExtent(){} // RVA: 0x7FFAF9C38130
        public void get_sliderMixed(){} // RVA: 0x7FFAF9C38190
        public void set_sliderMixed(){} // RVA: 0x7FFAF9C381A0
        public void get_verticalSlider(){} // RVA: 0x7FFAF9C38200
        public void set_verticalSlider(){} // RVA: 0x7FFAF9C38210
        public void get_verticalSliderThumb(){} // RVA: 0x7FFAF9C38270
        public void set_verticalSliderThumb(){} // RVA: 0x7FFAF9C38280
        public void get_verticalSliderThumbExtent(){} // RVA: 0x7FFAF9C382E0
        public void set_verticalSliderThumbExtent(){} // RVA: 0x7FFAF9C382F0
        public void get_horizontalScrollbar(){} // RVA: 0x7FFAF9C38350
        public void set_horizontalScrollbar(){} // RVA: 0x7FFAF9C38360
        public void get_horizontalScrollbarThumb(){} // RVA: 0x7FFAF9C383C0
        public void set_horizontalScrollbarThumb(){} // RVA: 0x7FFAF9C383D0
        public void get_horizontalScrollbarLeftButton(){} // RVA: 0x7FFAF9C38430
        public void set_horizontalScrollbarLeftButton(){} // RVA: 0x7FFAF9C38440
        public void get_horizontalScrollbarRightButton(){} // RVA: 0x7FFAF9C384A0
        public void set_horizontalScrollbarRightButton(){} // RVA: 0x7FFAF9C384B0
        public void get_verticalScrollbar(){} // RVA: 0x7FFAF9C38510
        public void set_verticalScrollbar(){} // RVA: 0x7FFAF9C38520
        public void get_verticalScrollbarThumb(){} // RVA: 0x7FFAF9C38580
        public void set_verticalScrollbarThumb(){} // RVA: 0x7FFAF9C38590
        public void get_verticalScrollbarUpButton(){} // RVA: 0x7FFAF9C385F0
        public void set_verticalScrollbarUpButton(){} // RVA: 0x7FFAF9C38600
        public void get_verticalScrollbarDownButton(){} // RVA: 0x7FFAF9C38660
        public void set_verticalScrollbarDownButton(){} // RVA: 0x7FFAF9C38670
        public void get_scrollView(){} // RVA: 0x7FFAF9C386D0
        public void set_scrollView(){} // RVA: 0x7FFAF9C386E0
        public void get_customStyles(){} // RVA: 0x7FFAF9C38740
        public void set_customStyles(){} // RVA: 0x7FFAF9C38750
        public void get_settings(){} // RVA: 0x7FFAF9C387B0
        public void get_error(){} // RVA: 0x7FFAF9C387C0
        public void Apply(){} // RVA: 0x7FFAF9C388F0
        public void BuildStyleCache(){} // RVA: 0x7FFAF9C38970
        public void GetStyle(){} // RVA: 0x7FFAF9C3A350
        public void FindStyle(){} // RVA: 0x7FFAF9C3A630
        public void MakeCurrent(){} // RVA: 0x7FFAF9C3A6D0
        public void GetEnumerator(){} // RVA: 0x7FFAF9C3A800
    }

    public class GUIStateObjects
    {
        // ── Methods ──
        public void GetStateObject(){} // RVA: 0x7FFAF9C3A940
        public void .cctor(){} // RVA: 0x7FFAF9C3AAC0
    }

    public class GUIStyle
    {
        // ── Methods ──
        public void get_rawName(){} // RVA: 0x7FFAF9C3AF00
        public void set_rawName(){} // RVA: 0x7FFAF9C3AF50
        public void get_font(){} // RVA: 0x7FFAF9C3AFB0
        public void get_imagePosition(){} // RVA: 0x7FFAF9C3B000
        public void get_wordWrap(){} // RVA: 0x7FFAF9C3B050
        public void get_contentOffset(){} // RVA: 0x7FFAF9C3B0A0
        public void set_contentOffset(){} // RVA: 0x7FFAF9C3B100
        public void get_fixedWidth(){} // RVA: 0x7FFAF9C3B160
        public void get_fixedHeight(){} // RVA: 0x7FFAF9C3B1B0
        public void get_stretchWidth(){} // RVA: 0x7FFAF9C3B200
        public void set_stretchWidth(){} // RVA: 0x7FFAF9C3B250
        public void get_stretchHeight(){} // RVA: 0x7FFAF9C3B2B0
        public void set_stretchHeight(){} // RVA: 0x7FFAF9C3B300
        public void set_Internal_clipOffset(){} // RVA: 0x7FFAF9C3B360
        public void Internal_Create(){} // RVA: 0x7FFAF9C3B3C0
        public void Internal_Copy(){} // RVA: 0x7FFAF9C3B410
        public void Internal_Destroy(){} // RVA: 0x7FFAF9C3B470
        public void GetStyleStatePtr(){} // RVA: 0x7FFAF9C3B4C0
        public void GetRectOffsetPtr(){} // RVA: 0x7FFAF9C3B520
        public void Internal_GetLineHeight(){} // RVA: 0x7FFAF9C3B580
        public void Internal_Draw(){} // RVA: 0x7FFAF9C3B5D0
        public void Internal_Draw2(){} // RVA: 0x7FFAF9C3B680
        public void Internal_DrawCursor(){} // RVA: 0x7FFAF9C3B710
        public void Internal_DrawWithTextSelection(){} // RVA: 0x7FFAF9C3B7A0
        public void Internal_GetCursorPixelPosition(){} // RVA: 0x7FFAF9C3B890
        public void Internal_GetCursorStringIndex(){} // RVA: 0x7FFAF9C3B930
        public void Internal_GetSelectedRenderedText(){} // RVA: 0x7FFAF9C3B9B0
        public void Internal_CalcSize(){} // RVA: 0x7FFAF9C3BA40
        public void Internal_CalcSizeWithConstraints(){} // RVA: 0x7FFAF9C3BAB0
        public void Internal_CalcHeight(){} // RVA: 0x7FFAF9C3BB30
        public void Internal_CalcMinMaxWidth(){} // RVA: 0x7FFAF9C3BBA0
        public void SetMouseTooltip(){} // RVA: 0x7FFAF9C3BC10
        public void IsTooltipActive(){} // RVA: 0x7FFAF9C3BCB0
        public void Internal_GetCursorFlashOffset(){} // RVA: 0x7FFAF9C3BD00
        public void SetDefaultFont(){} // RVA: 0x7FFAF9C3BD50
        public void .ctor(){} // RVA: 0x7FFAF9C3BE30 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAF9C3BF20
        public void get_name(){} // RVA: 0x7FFAF9C3BFF0
        public void set_name(){} // RVA: 0x7FFAF9C3C0B0
        public void get_normal(){} // RVA: 0x7FFAF9C3C160
        public void get_border(){} // RVA: 0x7FFAF9C3C2C0
        public void get_margin(){} // RVA: 0x7FFAF9C3C420
        public void get_padding(){} // RVA: 0x7FFAF9C3C580
        public void get_lineHeight(){} // RVA: 0x7FFAF9C3C6E0
        public void Draw(){} // RVA: 0x7FFAF9C3CB40 | overloaded x6
        public void DrawCursor(){} // RVA: 0x7FFAF9C3CC60
        public void DrawWithTextSelection(){} // RVA: 0x7FFAF9C3D5D0 | overloaded x3
        public void get_none(){} // RVA: 0x7FFAF9C3D610
        public void GetCursorPixelPosition(){} // RVA: 0x7FFAF9C3D710
        public void GetCursorStringIndex(){} // RVA: 0x7FFAF9C3D7B0
        public void CalcSize(){} // RVA: 0x7FFAF9C3BA40
        public void CalcSizeWithConstraints(){} // RVA: 0x7FFAF9C3BAB0
        public void CalcHeight(){} // RVA: 0x7FFAF9C3BB30
        public void get_isHeightDependantOnWidth(){} // RVA: 0x7FFAF9C3D830
        public void CalcMinMaxWidth(){} // RVA: 0x7FFAF9C3D930
        public void ToString(){} // RVA: 0x7FFAF9C3D9D0
        public void .cctor(){} // RVA: 0x7FFAF9C3DA90
        public void get_contentOffset_Injected(){} // RVA: 0x7FFAF9C3DAD0
        public void set_contentOffset_Injected(){} // RVA: 0x7FFAF9C3DB30
        public void set_Internal_clipOffset_Injected(){} // RVA: 0x7FFAF9C3DB90
        public void Internal_Draw_Injected(){} // RVA: 0x7FFAF9C3DBF0
        public void Internal_Draw2_Injected(){} // RVA: 0x7FFAF9C3DCA0
        public void Internal_DrawCursor_Injected(){} // RVA: 0x7FFAF9C3DD30
        public void Internal_DrawWithTextSelection_Injected(){} // RVA: 0x7FFAF9C3DDC0
        public void Internal_GetCursorPixelPosition_Injected(){} // RVA: 0x7FFAF9C3DE90
        public void Internal_GetCursorStringIndex_Injected(){} // RVA: 0x7FFAF9C3DF20
        public void Internal_GetSelectedRenderedText_Injected(){} // RVA: 0x7FFAF9C3DFA0
        public void Internal_CalcSize_Injected(){} // RVA: 0x7FFAF9C3E030
        public void Internal_CalcSizeWithConstraints_Injected(){} // RVA: 0x7FFAF9C3E0A0
        public void Internal_CalcMinMaxWidth_Injected(){} // RVA: 0x7FFAF9C3E120
        public void SetMouseTooltip_Injected(){} // RVA: 0x7FFAF9C3E190
    }

    public class GUIStyleState
    {
        public object doubleClickSelectsWord;
        public object tripleClickSelectsLine;

        // ── Methods ──
        public void set_background(){} // RVA: 0x7FFAF9C3ABA0
        public void set_textColor(){} // RVA: 0x7FFAF9C3AC00
        public void Init(){} // RVA: 0x7FFAF9C3AC60
        public void Cleanup(){} // RVA: 0x7FFAF9C3ACB0
        public void .ctor(){} // RVA: 0x7FFAF9B7F080 | overloaded x2
        public void GetGUIStyleState(){} // RVA: 0x7FFAF9C3AD50
        public void Finalize(){} // RVA: 0x7FFAF9C3AE10
        public void set_textColor_Injected(){} // RVA: 0x7FFAF9C3AEA0
    }

    public class GUITargetAttribute
    {
        // ── Methods ──
        public void GetGUITargetAttrValue(){} // RVA: 0x7FFAF9C3E1F0
    }

    public class GUIText
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class GUITexture
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class GUIUtility
    {
        // ── Methods ──
        public void get_pixelsPerPoint(){} // RVA: 0x7FFAF9C3E450
        public void get_guiDepth(){} // RVA: 0x7FFAF9C3E4A0
        public void set_mouseUsed(){} // RVA: 0x7FFAF9C3E4F0
        public void get_textFieldInput(){} // RVA: 0x7FFAF9C3E540
        public void set_textFieldInput(){} // RVA: 0x7FFAF9C3E590
        public void get_systemCopyBuffer(){} // RVA: 0x7FFAF9C3E5E0
        public void set_systemCopyBuffer(){} // RVA: 0x7FFAF9C3E630
        public void Internal_GetControlID(){} // RVA: 0x7FFAF9C3E680
        public void GetControlID(){} // RVA: 0x7FFAF9C3EF30 | overloaded x3
        public void BeginContainerFromOwner(){} // RVA: 0x7FFAF9C3E820
        public void BeginContainer(){} // RVA: 0x7FFAF9C3E870
        public void Internal_EndContainer(){} // RVA: 0x7FFAF9C3E8C0
        public void CheckForTabEvent(){} // RVA: 0x7FFAF9C3E910
        public void SetKeyboardControlToFirstControlId(){} // RVA: 0x7FFAF9C3E960
        public void SetKeyboardControlToLastControlId(){} // RVA: 0x7FFAF9C3E9B0
        public void HasFocusableControls(){} // RVA: 0x7FFAF9C3EA00
        public void OwnsId(){} // RVA: 0x7FFAF9C3EA50
        public void AlignRectToDevice(){} // RVA: 0x7FFAF9C406E0 | overloaded x2
        public void get_compositionString(){} // RVA: 0x7FFAF9C3EB60
        public void set_imeCompositionMode(){} // RVA: 0x7FFAF9C3EBB0
        public void set_compositionCursorPos(){} // RVA: 0x7FFAF9C3EC00
        public void Internal_GetHotControl(){} // RVA: 0x7FFAF9C3EC90
        public void Internal_GetKeyboardControl(){} // RVA: 0x7FFAF9C3ECE0
        public void Internal_SetHotControl(){} // RVA: 0x7FFAF9C3ED30
        public void Internal_SetKeyboardControl(){} // RVA: 0x7FFAF9C3ED80
        public void Internal_GetDefaultSkin(){} // RVA: 0x7FFAF9C3EDD0
        public void Internal_ExitGUI(){} // RVA: 0x7FFAF9C3EE20
        public void MarkGUIChanged(){} // RVA: 0x7FFAF9C3EE70
        public void GetStateObject(){} // RVA: 0x7FFAF9C3EFB0
        public void set_guiIsExiting(){} // RVA: 0x7FFAF9C3F170
        public void get_hotControl(){} // RVA: 0x7FFAF9C3F1D0
        public void set_hotControl(){} // RVA: 0x7FFAF9C3F250
        public void TakeCapture(){} // RVA: 0x7FFAF9C3F2E0
        public void RemoveCapture(){} // RVA: 0x7FFAF9C3F350
        public void get_keyboardControl(){} // RVA: 0x7FFAF9C3F3C0
        public void set_keyboardControl(){} // RVA: 0x7FFAF9C3F440
        public void HasKeyFocus(){} // RVA: 0x7FFAF9C3F4D0
        public void ExitGUI(){} // RVA: 0x7FFAF9C3F5B0
        public void GetDefaultSkin(){} // RVA: 0x7FFAF9C3F5F0
        public void ProcessEvent(){} // RVA: 0x7FFAF9C3F6C0
        public void EndContainer(){} // RVA: 0x7FFAF9C3F910
        public void BeginGUI(){} // RVA: 0x7FFAF9C3F9D0
        public void EndGUI(){} // RVA: 0x7FFAF9C3FA90
        public void EndGUIFromException(){} // RVA: 0x7FFAF9C3FCB0
        public void EndContainerGUIFromException(){} // RVA: 0x7FFAF9C3FD40
        public void ResetGlobalState(){} // RVA: 0x7FFAF9C3FDE0
        public void IsExitGUIException(){} // RVA: 0x7FFAF9C3FF40
        public void ShouldRethrowException(){} // RVA: 0x7FFAF9C3FFD0
        public void CheckOnGUI(){} // RVA: 0x7FFAF9C40090
        public void RoundToPixelGrid(){} // RVA: 0x7FFAF9C40170
        public void ScaleAroundPivot(){} // RVA: 0x7FFAF9C40260
        public void HitTest(){} // RVA: 0x7FFAF9C40930 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAF9C40A10
        public void Internal_GetControlID_Injected(){} // RVA: 0x7FFAF9C40B20
        public void AlignRectToDevice_Injected(){} // RVA: 0x7FFAF9C40B90
        public void set_compositionCursorPos_Injected(){} // RVA: 0x7FFAF9C40C10
    }

    public class GUIWordWrapSizer
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9C42A70
        public void CalcWidth(){} // RVA: 0x7FFAF9C42BA0
        public void CalcHeight(){} // RVA: 0x7FFAF9C42CA0
    }

    public class GameObject
    {
        public object count;
        public object stride;
        public object usageFlags;

        // ── Methods ──
        public void CreatePrimitive(){} // RVA: 0x7FFAF9BD7AD0
        public void GetComponent(){} // RVA: 0x7FFAF9BD7BF0 | overloaded x3
        public void GetComponentFastPath(){} // RVA: 0x7FFAF9BD7B80
        public void GetComponentByName(){} // RVA: 0x7FFAF9BD7BF0
        public void GetComponentInChildren(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void GetComponentInParent(){} // RVA: 0x7FFAF2D33FA0 | overloaded x4
        public void GetComponentsInternal(){} // RVA: 0x7FFAF9BD7E10
        public void GetComponents(){} // RVA: 0x7FFAF2AD4B10 | overloaded x4
        public void GetComponentsInChildren(){} // RVA: 0x7FFAF2AD4B10 | overloaded x6
        public void GetComponentsInParent(){} // RVA: 0x7FFAF2ABCD60 | overloaded x5
        public void TryGetComponent(){} // RVA: 0x7FFAF9BD81E0 | overloaded x2
        public void TryGetComponentInternal(){} // RVA: 0x7FFAF9BD8360
        public void TryGetComponentFastPath(){} // RVA: 0x7FFAF9BD83C0
        public void FindWithTag(){} // RVA: 0x7FFAF9BD8430
        public void SendMessageUpwards(){} // RVA: 0x7FFAF9BD8DD0 | overloaded x4
        public void SendMessage(){} // RVA: 0x7FFAF9BD8E90 | overloaded x4
        public void BroadcastMessage(){} // RVA: 0x7FFAF9BD8F50 | overloaded x4
        public void AddComponentInternal(){} // RVA: 0x7FFAF9BD84E0
        public void Internal_AddComponentWithType(){} // RVA: 0x7FFAF9BD8540
        public void AddComponent(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetComponentCount(){} // RVA: 0x7FFAF9BD85A0
        public void QueryComponentAtIndex(){} // RVA: 0x7FFAF9BD85F0
        public void GetComponentAtIndex(){} // RVA: 0x7FFAF2D33FA0 | overloaded x2
        public void GetComponentIndex(){} // RVA: 0x7FFAF9BD8760
        public void get_transform(){} // RVA: 0x7FFAF9BD87C0
        public void get_layer(){} // RVA: 0x7FFAF9BD8810
        public void set_layer(){} // RVA: 0x7FFAF9BD8860
        public void get_active(){} // RVA: 0x7FFAF9BD88C0
        public void set_active(){} // RVA: 0x7FFAF9BD8910
        public void SetActive(){} // RVA: 0x7FFAF9BD8970
        public void get_activeSelf(){} // RVA: 0x7FFAF9BD89D0
        public void get_activeInHierarchy(){} // RVA: 0x7FFAF9BD8A20
        public void SetActiveRecursively(){} // RVA: 0x7FFAF9BD8A70
        public void get_isStatic(){} // RVA: 0x7FFAF9BD8AD0
        public void set_isStatic(){} // RVA: 0x7FFAF9BD8B20
        public void get_isStaticBatchable(){} // RVA: 0x7FFAF9BD8B80
        public void get_tag(){} // RVA: 0x7FFAF9BD8BD0
        public void set_tag(){} // RVA: 0x7FFAF9BD8C20
        public void CompareTag(){} // RVA: 0x7FFAF9BD8C80
        public void FindGameObjectWithTag(){} // RVA: 0x7FFAF9BD8430
        public void FindGameObjectsWithTag(){} // RVA: 0x7FFAF9BD8CE0
        public void .ctor(){} // RVA: 0x7FFAF9BD90A0 | overloaded x3
        public void Internal_CreateGameObject(){} // RVA: 0x7FFAF9BD91D0
        public void Find(){} // RVA: 0x7FFAF9BD9230
        public void SetGameObjectsActive(){} // RVA: 0x7FFAF9BD93C0 | overloaded x3
        public void InstantiateGameObjects(){} // RVA: 0x7FFAF9BD94C0 | overloaded x2
        public void GetScene(){} // RVA: 0x7FFAF9BD96D0
        public void get_scene(){} // RVA: 0x7FFAF9BD9730
        public void get_sceneCullingMask(){} // RVA: 0x7FFAF9BD9790
        public void get_gameObject(){} // RVA: 0x7FFAF89B61A0
        public void InstantiateGameObjects_Injected(){} // RVA: 0x7FFAF9BD97E0
        public void GetScene_Injected(){} // RVA: 0x7FFAF9BD9860
        public void get_scene_Injected(){} // RVA: 0x7FFAF9BD98C0
    }

    public class GeometryUtility
    {
        // ── Methods ──
        public void CalculateFrustumPlanes(){} // RVA: 0x7FFAF9B7C8C0 | overloaded x4
        public void CalculateBounds(){} // RVA: 0x7FFAF9B7CA00
        public void TryCreatePlaneFromPolygon(){} // RVA: 0x7FFAF9B7CB80
        public void TestPlanesAABB(){} // RVA: 0x7FFAF9B7D030
        public void Internal_ExtractPlanes(){} // RVA: 0x7FFAF9B7D090
        public void Internal_CalculateBounds(){} // RVA: 0x7FFAF9B7D0F0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void TestPlanesAABB_Injected(){} // RVA: 0x7FFAF9B7D170
        public void Internal_ExtractPlanes_Injected(){} // RVA: 0x7FFAF9B7D1D0
        public void Internal_CalculateBounds_Injected(){} // RVA: 0x7FFAF9B7D230
    }

    public class Gizmos
    {
        public object order;
        public object callback;

        // ── Methods ──
        public void DrawLine(){} // RVA: 0x7FFAF9B7FE40
        public void DrawWireSphere(){} // RVA: 0x7FFAF9B7FEA0
        public void DrawSphere(){} // RVA: 0x7FFAF9B7FF00
        public void DrawWireCube(){} // RVA: 0x7FFAF9B7FF60
        public void DrawCube(){} // RVA: 0x7FFAF9B7FFC0
        public void DrawMesh(){} // RVA: 0x7FFAF9B80800 | overloaded x3
        public void DrawWireMesh(){} // RVA: 0x7FFAF9B80EA0 | overloaded x8
        public void DrawIcon(){} // RVA: 0x7FFAF9B80FF0 | overloaded x3
        public void DrawGUITexture(){} // RVA: 0x7FFAF9B81170 | overloaded x4
        public void get_color(){} // RVA: 0x7FFAF9B802F0
        public void set_color(){} // RVA: 0x7FFAF9B80350
        public void get_matrix(){} // RVA: 0x7FFAF9B803A0
        public void set_matrix(){} // RVA: 0x7FFAF9B80410
        public void get_probeSize(){} // RVA: 0x7FFAF9B80460
        public void DrawFrustum(){} // RVA: 0x7FFAF9B804B0
        public void DrawRay(){} // RVA: 0x7FFAF9B80600 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void DrawLine_Injected(){} // RVA: 0x7FFAF9B81210
        public void DrawWireSphere_Injected(){} // RVA: 0x7FFAF9B81270
        public void DrawSphere_Injected(){} // RVA: 0x7FFAF9B812D0
        public void DrawWireCube_Injected(){} // RVA: 0x7FFAF9B81330
        public void DrawCube_Injected(){} // RVA: 0x7FFAF9B81390
        public void DrawMesh_Injected(){} // RVA: 0x7FFAF9B813F0
        public void DrawWireMesh_Injected(){} // RVA: 0x7FFAF9B81470
        public void DrawIcon_Injected(){} // RVA: 0x7FFAF9B814F0
        public void DrawGUITexture_Injected(){} // RVA: 0x7FFAF9B81570
        public void get_color_Injected(){} // RVA: 0x7FFAF9B81600
        public void set_color_Injected(){} // RVA: 0x7FFAF9B81650
        public void get_matrix_Injected(){} // RVA: 0x7FFAF9B816A0
        public void set_matrix_Injected(){} // RVA: 0x7FFAF9B816F0
        public void DrawFrustum_Injected(){} // RVA: 0x7FFAF9B81740
    }

    public class GlobalJavaObjectRef
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9B2C7A0
        public void Finalize(){} // RVA: 0x7FFAF9B2C820
        public void op_Implicit(){} // RVA: 0x7FFAF3ABA1F0
        public void Dispose(){} // RVA: 0x7FFAF9B2C860
    }

    public class Gradient
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAF9BC1AE0
        public void Cleanup(){} // RVA: 0x7FFAF9BC1B30
        public void Internal_Equals(){} // RVA: 0x7FFAF9BC1B80
        public void .ctor(){} // RVA: 0x7FFAF9BC1BE0
        public void Finalize(){} // RVA: 0x7FFAF9BC1C30
        public void Evaluate(){} // RVA: 0x7FFAF9BC1CB0
        public void get_colorKeys(){} // RVA: 0x7FFAF9BC1D30
        public void set_colorKeys(){} // RVA: 0x7FFAF9BC1D80
        public void get_alphaKeys(){} // RVA: 0x7FFAF9BC1DE0
        public void set_alphaKeys(){} // RVA: 0x7FFAF9BC1E30
        public void get_mode(){} // RVA: 0x7FFAF9BC1E90
        public void set_mode(){} // RVA: 0x7FFAF9BC1EE0
        public void get_colorSpace(){} // RVA: 0x7FFAF9BC1F40
        public void set_colorSpace(){} // RVA: 0x7FFAF9BC1F90
        public void SetKeys(){} // RVA: 0x7FFAF9BC1FF0
        public void Equals(){} // RVA: 0x7FFAF9BC2170 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAF9B692A0
        public void Evaluate_Injected(){} // RVA: 0x7FFAF9BC22B0
    }

    public class GradientAlphaKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DB0D10
    }

    public class GradientColorKey
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9BC1AD0
    }

    public class Graphics
    {
        // ── Methods ──
        public void Internal_GetMaxDrawMeshInstanceCount(){} // RVA: 0x7FFAF9B840B0
        public void Internal_SetNullRT(){} // RVA: 0x7FFAF9B84100
        public void Internal_SetRTSimple(){} // RVA: 0x7FFAF9B84150
        public void Internal_SetRandomWriteTargetBuffer(){} // RVA: 0x7FFAF9B84210
        public void ClearRandomWriteTargets(){} // RVA: 0x7FFAF9B84280
        public void CopyTexture_Full(){} // RVA: 0x7FFAF9B842D0
        public void CopyTexture_Slice(){} // RVA: 0x7FFAF9B84330
        public void CopyTexture_Region(){} // RVA: 0x7FFAF9B843B0
        public void ConvertTexture_Full(){} // RVA: 0x7FFAF9B84440
        public void Internal_DrawMeshNow2(){} // RVA: 0x7FFAF9B844A0
        public void Internal_DrawTexture(){} // RVA: 0x7FFAF9B84550
        public void Internal_RenderMeshPrimitives(){} // RVA: 0x7FFAF9B845A0
        public void Internal_DrawMesh(){} // RVA: 0x7FFAF9B84660
        public void Internal_DrawMeshInstanced(){} // RVA: 0x7FFAF9B84780
        public void Internal_DrawProcedural(){} // RVA: 0x7FFAF9B84820
        public void Internal_DrawProceduralIndirect(){} // RVA: 0x7FFAF9B84920
        public void Internal_BlitMaterial5(){} // RVA: 0x7FFAF9B84A20
        public void Internal_BlitMaterial6(){} // RVA: 0x7FFAF9B84AB0
        public void Blit2(){} // RVA: 0x7FFAF9B84B40
        public void Blit3(){} // RVA: 0x7FFAF9B84BA0
        public void Blit4(){} // RVA: 0x7FFAF9B84C20
        public void Blit5(){} // RVA: 0x7FFAF9B84CD0
        public void CreateGPUFenceImpl(){} // RVA: 0x7FFAF9B84D90
        public void ExecuteCommandBuffer(){} // RVA: 0x7FFAF9B84DF0
        public void ExecuteCommandBufferAsync(){} // RVA: 0x7FFAF9B84E40
        public void SetRenderTargetImpl(){} // RVA: 0x7FFAF9B84FB0 | overloaded x2
        public void SetRenderTarget(){} // RVA: 0x7FFAF9B87F00 | overloaded x3
        public void SetRandomWriteTarget(){} // RVA: 0x7FFAF9B87F80 | overloaded x2
        public void CopyTexture(){} // RVA: 0x7FFAF9B85670 | overloaded x3
        public void ConvertTexture(){} // RVA: 0x7FFAF9B85730
        public void CreateGraphicsFence(){} // RVA: 0x7FFAF9B857D0
        public void DrawTextureImpl(){} // RVA: 0x7FFAF9B858B0
        public void DrawTexture(){} // RVA: 0x7FFAF9B87D40 | overloaded x7
        public void RenderMeshPrimitives(){} // RVA: 0x7FFAF9B85F00
        public void DrawMeshNow(){} // RVA: 0x7FFAF9B86300 | overloaded x2
        public void DrawMesh(){} // RVA: 0x7FFAF9B87A40 | overloaded x4
        public void DrawMeshInstanced(){} // RVA: 0x7FFAF9B86960
        public void DrawProcedural(){} // RVA: 0x7FFAF9B87030
        public void DrawProceduralIndirect(){} // RVA: 0x7FFAF9B87180
        public void Blit(){} // RVA: 0x7FFAF9B87990 | overloaded x9
        public void .cctor(){} // RVA: 0x7FFAF9B87FE0
        public void Internal_SetRTSimple_Injected(){} // RVA: 0x7FFAF9B88190
        public void Internal_DrawMeshNow2_Injected(){} // RVA: 0x7FFAF9B88220
        public void Internal_RenderMeshPrimitives_Injected(){} // RVA: 0x7FFAF9B88290
        public void Internal_DrawMesh_Injected(){} // RVA: 0x7FFAF9B88310
        public void Internal_DrawProcedural_Injected(){} // RVA: 0x7FFAF9B883B0
        public void Internal_DrawProceduralIndirect_Injected(){} // RVA: 0x7FFAF9B88440
        public void Blit4_Injected(){} // RVA: 0x7FFAF9B884D0
        public void Blit5_Injected(){} // RVA: 0x7FFAF9B88550
    }

    public class GraphicsBuffer
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAF9B9F4E0
        public void Dispose(){} // RVA: 0x7FFAF9B9F650 | overloaded x2
        public void RequiresCompute(){} // RVA: 0x7FFAF9B9F730
        public void IsVertexIndexOrCopyOnly(){} // RVA: 0x7FFAF9B9F740
        public void InitBuffer(){} // RVA: 0x7FFAF9B9F750
        public void DestroyBuffer(){} // RVA: 0x7FFAF9B9F7D0
        public void .ctor(){} // RVA: 0x7FFAF9B9F850 | overloaded x2
        public void InternalInitialization(){} // RVA: 0x7FFAF9B9F860
        public void Release(){} // RVA: 0x7FFAF9B9FCC0
        public void IsValidBuffer(){} // RVA: 0x7FFAF9B9FCD0
        public void IsValid(){} // RVA: 0x7FFAF9B9FD20
        public void get_count(){} // RVA: 0x7FFAF9B9FD90
        public void get_stride(){} // RVA: 0x7FFAF9B9FDE0
        public void GetUsageFlags(){} // RVA: 0x7FFAF9B9FE30
        public void get_usageFlags(){} // RVA: 0x7FFAF9B9FE30
        public void SetData(){} // RVA: 0x7FFAF9B9FE80
        public void InternalSetData(){} // RVA: 0x7FFAF9BA0060
        public void GetNativeBufferPtr(){} // RVA: 0x7FFAF9BA00F0
        public void BeginBufferWrite(){} // RVA: 0x7FFAF9BA0140
        public void LockBufferForWrite(){} // RVA: 0x7FFAF2D33FA0
        public void EndBufferWrite(){} // RVA: 0x7FFAF9BA01B0
        public void UnlockBufferAfterWrite(){} // RVA: 0x7FFAF2AD4FA0
    }

    public class Grid
    {
        // ── Methods ──
        public void GetCellCenterLocal(){} // RVA: 0x7FFAF9C1C030
        public void GetCellCenterWorld(){} // RVA: 0x7FFAF9C1C1A0
        public void get_cellSize(){} // RVA: 0x7FFAF9C1C370
        public void set_cellSize(){} // RVA: 0x7FFAF9C1C3E0
        public void get_cellGap(){} // RVA: 0x7FFAF9C1C440
        public void set_cellGap(){} // RVA: 0x7FFAF9C1C4B0
        public void get_cellLayout(){} // RVA: 0x7FFAF9C1C510
        public void set_cellLayout(){} // RVA: 0x7FFAF9C1C560
        public void get_cellSwizzle(){} // RVA: 0x7FFAF9C1C5C0
        public void set_cellSwizzle(){} // RVA: 0x7FFAF9C1C610
        public void Swizzle(){} // RVA: 0x7FFAF9C1C670
        public void InverseSwizzle(){} // RVA: 0x7FFAF9C1C6F0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_cellSize_Injected(){} // RVA: 0x7FFAF9C1C770
        public void set_cellSize_Injected(){} // RVA: 0x7FFAF9C1C7D0
        public void get_cellGap_Injected(){} // RVA: 0x7FFAF9C1C830
        public void set_cellGap_Injected(){} // RVA: 0x7FFAF9C1C890
        public void Swizzle_Injected(){} // RVA: 0x7FFAF9C1C8F0
        public void InverseSwizzle_Injected(){} // RVA: 0x7FFAF9C1C960
    }

    public class GridLayout
    {
        public object x;
        public object y;
        public object z;
        public object Item;

        // ── Methods ──
        public void get_cellSize(){} // RVA: 0x7FFAF9C1C9D0
        public void get_cellGap(){} // RVA: 0x7FFAF9C1CA40
        public void get_cellLayout(){} // RVA: 0x7FFAF9C1CAB0
        public void get_cellSwizzle(){} // RVA: 0x7FFAF9C1CB00
        public void GetBoundsLocal(){} // RVA: 0x7FFAF9C1CBD0 | overloaded x2
        public void GetBoundsLocalOriginSize(){} // RVA: 0x7FFAF9C1CCA0
        public void CellToLocal(){} // RVA: 0x7FFAF9C1CD30
        public void LocalToCell(){} // RVA: 0x7FFAF9C1CDB0
        public void CellToLocalInterpolated(){} // RVA: 0x7FFAF9C1CE30
        public void LocalToCellInterpolated(){} // RVA: 0x7FFAF9C1CEB0
        public void CellToWorld(){} // RVA: 0x7FFAF9C1CF30
        public void WorldToCell(){} // RVA: 0x7FFAF9C1CFB0
        public void LocalToWorld(){} // RVA: 0x7FFAF9C1D030
        public void WorldToLocal(){} // RVA: 0x7FFAF9C1D0B0
        public void GetLayoutCellCenter(){} // RVA: 0x7FFAF9C1D130
        public void DoNothing(){} // RVA: 0x7FFAF2D8D310
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_cellSize_Injected(){} // RVA: 0x7FFAF9C1D1A0
        public void get_cellGap_Injected(){} // RVA: 0x7FFAF9C1D200
        public void GetBoundsLocal_Injected(){} // RVA: 0x7FFAF9C1D260
        public void GetBoundsLocalOriginSize_Injected(){} // RVA: 0x7FFAF9C1D2D0
        public void CellToLocal_Injected(){} // RVA: 0x7FFAF9C1D350
        public void LocalToCell_Injected(){} // RVA: 0x7FFAF9C1D3C0
        public void CellToLocalInterpolated_Injected(){} // RVA: 0x7FFAF9C1D430
        public void LocalToCellInterpolated_Injected(){} // RVA: 0x7FFAF9C1D4A0
        public void CellToWorld_Injected(){} // RVA: 0x7FFAF9C1D510
        public void WorldToCell_Injected(){} // RVA: 0x7FFAF9C1D580
        public void LocalToWorld_Injected(){} // RVA: 0x7FFAF9C1D5F0
        public void WorldToLocal_Injected(){} // RVA: 0x7FFAF9C1D660
        public void GetLayoutCellCenter_Injected(){} // RVA: 0x7FFAF9C1D6D0
    }

}