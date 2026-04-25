// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 34
// Methods: 818

namespace ThirdParty.Unity.UnityEngine
{
    public class GL : Object
    {
        public object sRGBWrite;
        public object invertCulling;
        public object modelview;

        // ── Methods ──
        public void Vertex3(){} // RVA: 0x7FFAC9870D20
        public void TexCoord3(){} // RVA: 0x7FFAC9870DA0
        public void TexCoord(){} // RVA: 0x7FFAC9870E20
        public void TexCoord2(){} // RVA: 0x7FFAC9870E40
        public void ImmediateColor(){} // RVA: 0x7FFAC9870E50
        public void Color(){} // RVA: 0x7FFAC9870EE0
        public void get_sRGBWrite(){} // RVA: 0x7FFAC9870F40
        public void set_sRGBWrite(){} // RVA: 0x7FFAC9870F90
        public void get_invertCulling(){} // RVA: 0x7FFAC9870FE0
        public void set_invertCulling(){} // RVA: 0x7FFAC9871030
        public void Flush(){} // RVA: 0x7FFAC9871080
        public void SetViewMatrix(){} // RVA: 0x7FFAC98710D0
        public void set_modelview(){} // RVA: 0x7FFAC9871120
        public void PushMatrix(){} // RVA: 0x7FFAC9871190
        public void PopMatrix(){} // RVA: 0x7FFAC98711E0
        public void LoadOrtho(){} // RVA: 0x7FFAC9871230
        public void LoadProjectionMatrix(){} // RVA: 0x7FFAC9871280
        public void InvalidateState(){} // RVA: 0x7FFAC98712D0
        public void GetGPUProjectionMatrix(){} // RVA: 0x7FFAC9871320
        public void GLLoadPixelMatrixScript(){} // RVA: 0x7FFAC98713B0
        public void LoadPixelMatrix(){} // RVA: 0x7FFAC98713B0
        public void GLIssuePluginEvent(){} // RVA: 0x7FFAC9871440
        public void IssuePluginEvent(){} // RVA: 0x7FFAC98714A0
        public void Begin(){} // RVA: 0x7FFAC9871560
        public void End(){} // RVA: 0x7FFAC98715B0
        public void GLClear(){} // RVA: 0x7FFAC9871600
        public void Clear(){} // RVA: 0x7FFAC9871700 | overloaded x2
        public void Viewport(){} // RVA: 0x7FFAC9871780
        public void SetViewMatrix_Injected(){} // RVA: 0x7FFAC98717D0
        public void LoadProjectionMatrix_Injected(){} // RVA: 0x7FFAC9871820
        public void GetGPUProjectionMatrix_Injected(){} // RVA: 0x7FFAC9871870
        public void GLClear_Injected(){} // RVA: 0x7FFAC98718E0
        public void Viewport_Injected(){} // RVA: 0x7FFAC9871960
    }

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
        public UnityEngineInternal.GenericStack matrix; // 0x50

        // ── Methods ──
        public void get_color(){} // RVA: 0x7FFAC99091B0
        public void set_color(){} // RVA: 0x7FFAC9909240
        public void get_backgroundColor(){} // RVA: 0x7FFAC99092D0
        public void set_backgroundColor(){} // RVA: 0x7FFAC9909360
        public void get_contentColor(){} // RVA: 0x7FFAC99093F0
        public void set_contentColor(){} // RVA: 0x7FFAC9909480
        public void get_changed(){} // RVA: 0x7FFAC9909510
        public void set_changed(){} // RVA: 0x7FFAC9909560
        public void get_enabled(){} // RVA: 0x7FFAC99095B0
        public void set_enabled(){} // RVA: 0x7FFAC9909600
        public void set_depth(){} // RVA: 0x7FFAC9909650
        public void get_usePageScrollbars(){} // RVA: 0x7FFAC99096A0
        public void get_blendMaterial(){} // RVA: 0x7FFAC99096F0
        public void get_blitMaterial(){} // RVA: 0x7FFAC9909740
        public void get_roundedRectMaterial(){} // RVA: 0x7FFAC9909790
        public void get_roundedRectWithColorPerBorderMaterial(){} // RVA: 0x7FFAC99097E0
        public void GrabMouseControl(){} // RVA: 0x7FFAC9909830
        public void HasMouseControl(){} // RVA: 0x7FFAC9909880
        public void ReleaseMouseControl(){} // RVA: 0x7FFAC99098D0
        public void SetNextControlName(){} // RVA: 0x7FFAC9909920
        public void InternalRepaintEditorWindow(){} // RVA: 0x7FFAC9909970
        public void Internal_DoWindow(){} // RVA: 0x7FFAC99099C0
        public void .cctor(){} // RVA: 0x7FFAC9909AC0
        public void get_scrollTroughSide(){} // RVA: 0x7FFAC9909E00
        public void set_scrollTroughSide(){} // RVA: 0x7FFAC9909E60
        public void get_nextScrollStepTime(){} // RVA: 0x7FFAC9909EC0
        public void set_nextScrollStepTime(){} // RVA: 0x7FFAC9909F20
        public void set_skin(){} // RVA: 0x7FFAC9909F80
        public void get_skin(){} // RVA: 0x7FFAC990A000
        public void DoSetSkin(){} // RVA: 0x7FFAC990A090
        public void get_matrix(){} // RVA: 0x7FFAC990A410
        public void set_matrix(){} // RVA: 0x7FFAC990A4B0
        public void Label(){} // RVA: 0x7FFAC990A880 | overloaded x4
        public void DrawTexture(){} // RVA: 0x7FFAC990B5E0 | overloaded x9
        public void CalculateScaledTextureRects(){} // RVA: 0x7FFAC990BE80
        public void DrawTextureWithTexCoords(){} // RVA: 0x7FFAC990C0C0 | overloaded x2
        public void Box(){} // RVA: 0x7FFAC990C820 | overloaded x3
        public void Button(){} // RVA: 0x7FFAC990CBE0 | overloaded x3
        public void DoRepeatButton(){} // RVA: 0x7FFAC990CE10
        public void PasswordFieldGetStrToShow(){} // RVA: 0x7FFAC990D170
        public void DoTextField(){} // RVA: 0x7FFAC990D4A0 | overloaded x3
        public void HandleTextFieldEventForTouchscreen(){} // RVA: 0x7FFAC990DB10
        public void HandleTextFieldEventForDesktop(){} // RVA: 0x7FFAC990E1B0
        public void HandleTextFieldEventForDesktopWithForcedKeyboard(){} // RVA: 0x7FFAC990EB10
        public void Toggle(){} // RVA: 0x7FFAC990EFC0
        public void SelectionGrid(){} // RVA: 0x7FFAC990F220
        public void CalcTotalHorizSpacing(){} // RVA: 0x7FFAC990F320
        public void DoControl(){} // RVA: 0x7FFAC990F6B0
        public void DoLabel(){} // RVA: 0x7FFAC990FB00
        public void DoToggle(){} // RVA: 0x7FFAC990FEE0
        public void DoButton(){} // RVA: 0x7FFAC9910050
        public void DoButtonGrid(){} // RVA: 0x7FFAC99101C0
        public void CalcGridRects(){} // RVA: 0x7FFAC9910E40
        public void HorizontalSlider(){} // RVA: 0x7FFAC99111E0
        public void Slider(){} // RVA: 0x7FFAC99112B0
        public void HorizontalScrollbar(){} // RVA: 0x7FFAC9911590
        public void ScrollerRepeatButton(){} // RVA: 0x7FFAC9911790
        public void VerticalScrollbar(){} // RVA: 0x7FFAC9911AD0
        public void Scroller(){} // RVA: 0x7FFAC9911CD0
        public void BeginGroup(){} // RVA: 0x7FFAC9912690 | overloaded x2
        public void EndGroup(){} // RVA: 0x7FFAC99129F0
        public void get_scrollViewStates(){} // RVA: 0x7FFAC9912A80
        public void BeginScrollView(){} // RVA: 0x7FFAC9912AE0
        public void EndScrollView(){} // RVA: 0x7FFAC9913B20
        public void Window(){} // RVA: 0x7FFAC9914F70 | overloaded x2
        public void DoWindow(){} // RVA: 0x7FFAC9915070
        public void CallWindowDelegate(){} // RVA: 0x7FFAC9915210
        public void get_color_Injected(){} // RVA: 0x7FFAC9915540
        public void set_color_Injected(){} // RVA: 0x7FFAC9915590
        public void get_backgroundColor_Injected(){} // RVA: 0x7FFAC99155E0
        public void set_backgroundColor_Injected(){} // RVA: 0x7FFAC9915630
        public void get_contentColor_Injected(){} // RVA: 0x7FFAC9915680
        public void set_contentColor_Injected(){} // RVA: 0x7FFAC99156D0
        public void Internal_DoWindow_Injected(){} // RVA: 0x7FFAC9915720
    }

    public class GUIClip : Object
    {
        public object visibleRect;

        // ── Methods ──
        public void get_visibleRect(){} // RVA: 0x7FFAC99157B0
        public void Internal_Push(){} // RVA: 0x7FFAC9915810
        public void Internal_Pop(){} // RVA: 0x7FFAC9915890
        public void Internal_GetCount(){} // RVA: 0x7FFAC99158E0
        public void Unclip_Vector2(){} // RVA: 0x7FFAC9915930
        public void UnclipToWindow_Vector2(){} // RVA: 0x7FFAC99159A0
        public void GetMatrix(){} // RVA: 0x7FFAC9915A10
        public void SetMatrix(){} // RVA: 0x7FFAC9915A80
        public void Internal_PushParentClip(){} // RVA: 0x7FFAC9915B80 | overloaded x2
        public void Internal_PopParentClip(){} // RVA: 0x7FFAC9915BF0
        public void Push(){} // RVA: 0x7FFAC9915C40
        public void Pop(){} // RVA: 0x7FFAC9915890
        public void Unclip(){} // RVA: 0x7FFAC9915CC0
        public void UnclipToWindow(){} // RVA: 0x7FFAC9915D30
        public void get_visibleRect_Injected(){} // RVA: 0x7FFAC9915DA0
        public void Internal_Push_Injected(){} // RVA: 0x7FFAC9915DF0
        public void Unclip_Vector2_Injected(){} // RVA: 0x7FFAC9915E70
        public void UnclipToWindow_Vector2_Injected(){} // RVA: 0x7FFAC9915ED0
        public void GetMatrix_Injected(){} // RVA: 0x7FFAC9915F30
        public void SetMatrix_Injected(){} // RVA: 0x7FFAC9915F80
        public void Internal_PushParentClip_Injected(){} // RVA: 0x7FFAC9915FD0
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
        public void get_text(){} // RVA: 0x7FFAC5CC4750
        public void set_text(){} // RVA: 0x7FFAC9916150
        public void set_image(){} // RVA: 0x7FFAC2F87E80
        public void get_tooltip(){} // RVA: 0x7FFAC91BAEE0
        public void set_tooltip(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC99165C0 | overloaded x5
        public void Temp(){} // RVA: 0x7FFAC9916DA0 | overloaded x3
        public void ClearStaticCache(){} // RVA: 0x7FFAC9916A70
        public void ToString(){} // RVA: 0x7FFAC9916F60
        public void .cctor(){} // RVA: 0x7FFAC9916FB0
    }

    public class GUIElement : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class GUIGridSizer : GUILayoutEntry
    {
        public int rows; // 0x48
        public int m_XCount; // 0x4C
        public float m_MinButtonWidth; // 0x50
        public float m_MaxButtonWidth; // 0x54
        public float m_MinButtonHeight; // 0x58
        public float m_MaxButtonHeight; // 0x5C

        // ── Methods ──
        public void GetRect(){} // RVA: 0x7FFAC99299B0
        public void .ctor(){} // RVA: 0x7FFAC9929BE0
        public void get_rows(){} // RVA: 0x7FFAC992A350
    }

    public class GUILayer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class GUILayout : Object
    {
        // ── Methods ──
        public void Label(){} // RVA: 0x7FFAC9917310 | overloaded x2
        public void DoLabel(){} // RVA: 0x7FFAC9917390
        public void Box(){} // RVA: 0x7FFAC99174F0
        public void DoBox(){} // RVA: 0x7FFAC99177B0
        public void Button(){} // RVA: 0x7FFAC99178B0
        public void DoButton(){} // RVA: 0x7FFAC9917A30
        public void TextField(){} // RVA: 0x7FFAC9917BC0 | overloaded x2
        public void DoTextField(){} // RVA: 0x7FFAC9917C50
        public void Toggle(){} // RVA: 0x7FFAC9917FA0
        public void DoToggle(){} // RVA: 0x7FFAC9918140
        public void SelectionGrid(){} // RVA: 0x7FFAC99185C0 | overloaded x2
        public void HorizontalSlider(){} // RVA: 0x7FFAC9918730
        public void DoHorizontalSlider(){} // RVA: 0x7FFAC99189A0
        public void Space(){} // RVA: 0x7FFAC9918B80
        public void FlexibleSpace(){} // RVA: 0x7FFAC9918ED0
        public void BeginHorizontal(){} // RVA: 0x7FFAC99192D0 | overloaded x2
        public void EndHorizontal(){} // RVA: 0x7FFAC99194B0
        public void BeginVertical(){} // RVA: 0x7FFAC9919610 | overloaded x3
        public void EndVertical(){} // RVA: 0x7FFAC99197F0
        public void BeginArea(){} // RVA: 0x7FFAC99198F0 | overloaded x2
        public void EndArea(){} // RVA: 0x7FFAC9919C20
        public void BeginScrollView(){} // RVA: 0x7FFAC9919EB0 | overloaded x2
        public void EndScrollView(){} // RVA: 0x7FFAC991A340 | overloaded x2
        public void Window(){} // RVA: 0x7FFAC991A3C0
        public void DoWindow(){} // RVA: 0x7FFAC991A4E0
        public void Width(){} // RVA: 0x7FFAC991A7D0
        public void Height(){} // RVA: 0x7FFAC991A8A0
        public void ExpandWidth(){} // RVA: 0x7FFAC991A970
        public void ExpandHeight(){} // RVA: 0x7FFAC991AA30
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
        public void get_style(){} // RVA: 0x7FFAC991F730
        public void set_style(){} // RVA: 0x7FFAC9928890
        public void get_marginLeft(){} // RVA: 0x7FFAC9928900
        public void get_marginRight(){} // RVA: 0x7FFAC9928970
        public void get_marginTop(){} // RVA: 0x7FFAC99289E0
        public void get_marginBottom(){} // RVA: 0x7FFAC9928A50
        public void get_marginHorizontal(){} // RVA: 0x7FFAC9928AC0
        public void get_marginVertical(){} // RVA: 0x7FFAC9928B10
        public void .ctor(){} // RVA: 0x7FFAC9928C80 | overloaded x2
        public void CalcWidth(){} // RVA: 0x7FFAC2F21310
        public void CalcHeight(){} // RVA: 0x7FFAC2F21310
        public void SetHorizontal(){} // RVA: 0x7FFAC9928DA0
        public void SetVertical(){} // RVA: 0x7FFAC9928DB0
        public void ApplyStyleSettings(){} // RVA: 0x7FFAC9928DC0
        public void ApplyOptions(){} // RVA: 0x7FFAC9928F90
        public void ToString(){} // RVA: 0x7FFAC9929320
        public void .cctor(){} // RVA: 0x7FFAC9929950
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
        public void get_marginLeft(){} // RVA: 0x7FFAC35729C0
        public void get_marginRight(){} // RVA: 0x7FFAC46D5110
        public void get_marginTop(){} // RVA: 0x7FFAC37EE8C0
        public void get_marginBottom(){} // RVA: 0x7FFAC5F56E80
        public void .ctor(){} // RVA: 0x7FFAC992A620
        public void ApplyOptions(){} // RVA: 0x7FFAC992A7A0
        public void ApplyStyleSettings(){} // RVA: 0x7FFAC992A8B0
        public void ResetCursor(){} // RVA: 0x7FFAC992AA20
        public void GetNext(){} // RVA: 0x7FFAC992AA30
        public void Add(){} // RVA: 0x7FFAC992AD80
        public void CalcWidth(){} // RVA: 0x7FFAC992AE20
        public void SetHorizontal(){} // RVA: 0x7FFAC992B770
        public void CalcHeight(){} // RVA: 0x7FFAC992C1D0
        public void SetVertical(){} // RVA: 0x7FFAC992CA90
        public void ToString(){} // RVA: 0x7FFAC992D440
        public void .cctor(){} // RVA: 0x7FFAC992D850
    }

    public class GUILayoutOption : Object
    {
        public 0x6B27FA00 type; // 0x10
        public object value; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC47EB5F0
    }

    public class GUILayoutUtility : Object
    {
        public System.Collections.Generic.Dictionary`2<int,LayoutCache> unbalancedgroupscount;
        public System.Collections.Generic.Dictionary`2<int,LayoutCache> spaceStyle; // 0x8
        public LayoutCache current; // 0x10
        public UnityEngine.Rect kDummyRect; // 0x18
        public int <unbalancedgroupscount>k__BackingField; // 0x28
        public UnityEngine.GUIStyle s_SpaceStyle; // 0x30

        // ── Methods ──
        public void Internal_GetWindowRect(){} // RVA: 0x7FFAC991AD80
        public void Internal_MoveWindow(){} // RVA: 0x7FFAC991AE20
        public void get_unbalancedgroupscount(){} // RVA: 0x7FFAC991AEC0
        public void set_unbalancedgroupscount(){} // RVA: 0x7FFAC991AF20
        public void SelectIDList(){} // RVA: 0x7FFAC991AF80
        public void Begin(){} // RVA: 0x7FFAC991B270
        public void BeginContainer(){} // RVA: 0x7FFAC991B760
        public void BeginWindow(){} // RVA: 0x7FFAC991BAE0
        public void Layout(){} // RVA: 0x7FFAC991C0C0
        public void LayoutFromEditorWindow(){} // RVA: 0x7FFAC991C440
        public void LayoutFromContainer(){} // RVA: 0x7FFAC991C780
        public void LayoutFreeGroup(){} // RVA: 0x7FFAC991C970
        public void LayoutSingleGroup(){} // RVA: 0x7FFAC991CB70
        public void CreateGUILayoutGroupInstanceOfType(){} // RVA: 0x7FFAC991CE40
        public void BeginLayoutGroup(){} // RVA: 0x7FFAC991CFE0
        public void EndLayoutGroup(){} // RVA: 0x7FFAC991D3E0
        public void BeginLayoutArea(){} // RVA: 0x7FFAC991D7C0
        public void EndLayoutArea(){} // RVA: 0x7FFAC991DB80
        public void GetRect(){} // RVA: 0x7FFAC991E510 | overloaded x3
        public void DoGetRect(){} // RVA: 0x7FFAC991E5D0 | overloaded x2
        public void get_spaceStyle(){} // RVA: 0x7FFAC991E820
        public void .cctor(){} // RVA: 0x7FFAC991E9B0
        public void Internal_GetWindowRect_Injected(){} // RVA: 0x7FFAC991EBE0
        public void Internal_MoveWindow_Injected(){} // RVA: 0x7FFAC991EC40
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
        public void .ctor(){} // RVA: 0x7FFAC992D980
        public void CalcWidth(){} // RVA: 0x7FFAC992D9E0
        public void SetHorizontal(){} // RVA: 0x7FFAC992DA80
        public void CalcHeight(){} // RVA: 0x7FFAC992DC60
        public void SetVertical(){} // RVA: 0x7FFAC992DE10
    }

    public class GUISettings : Object
    {
        public bool doubleClickSelectsWord; // 0x10
        public bool tripleClickSelectsLine; // 0x11
        public UnityEngine.Color cursorColor; // 0x14
        public float cursorFlashSpeed; // 0x24
        public UnityEngine.Color selectionColor; // 0x28

        // ── Methods ──
        public void Internal_GetCursorFlashSpeed(){} // RVA: 0x7FFAC991F0C0
        public void get_doubleClickSelectsWord(){} // RVA: 0x7FFAC991F110
        public void get_tripleClickSelectsLine(){} // RVA: 0x7FFAC991F120
        public void get_cursorColor(){} // RVA: 0x7FFAC5871D80
        public void get_cursorFlashSpeed(){} // RVA: 0x7FFAC991F130
        public void get_selectionColor(){} // RVA: 0x7FFAC991F190
        public void .ctor(){} // RVA: 0x7FFAC991F1A0
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
        public UnityEngine.GUISettings settings; // 0xE0
        public UnityEngine.GUIStyle error;
        public System.Collections.Generic.Dictionary`2<string,UnityEngine.GUIStyle> m_Styles; // 0xE8
        public SkinChangedDelegate m_SkinChanged; // 0x8
        public UnityEngine.GUISkin current; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC991F1D0
        public void OnEnable(){} // RVA: 0x7FFAC991F380
        public void CleanupRoots(){} // RVA: 0x7FFAC991F390
        public void get_font(){} // RVA: 0x7FFAC58A1130
        public void set_font(){} // RVA: 0x7FFAC991F490
        public void get_box(){} // RVA: 0x7FFAC91BAEE0
        public void set_box(){} // RVA: 0x7FFAC991F660
        public void get_label(){} // RVA: 0x7FFAC991F6C0
        public void set_label(){} // RVA: 0x7FFAC991F6D0
        public void get_textField(){} // RVA: 0x7FFAC991F730
        public void set_textField(){} // RVA: 0x7FFAC991F740
        public void get_textArea(){} // RVA: 0x7FFAC991F7A0
        public void set_textArea(){} // RVA: 0x7FFAC991F7B0
        public void get_button(){} // RVA: 0x7FFAC98DDAD0
        public void set_button(){} // RVA: 0x7FFAC991F810
        public void get_toggle(){} // RVA: 0x7FFAC98DE3D0
        public void set_toggle(){} // RVA: 0x7FFAC991F870
        public void get_window(){} // RVA: 0x7FFAC991F8D0
        public void set_window(){} // RVA: 0x7FFAC991F8E0
        public void get_horizontalSlider(){} // RVA: 0x7FFAC991F940
        public void set_horizontalSlider(){} // RVA: 0x7FFAC991F950
        public void get_horizontalSliderThumb(){} // RVA: 0x7FFAC991F9B0
        public void set_horizontalSliderThumb(){} // RVA: 0x7FFAC991F9C0
        public void get_horizontalSliderThumbExtent(){} // RVA: 0x7FFAC991FA20
        public void set_horizontalSliderThumbExtent(){} // RVA: 0x7FFAC991FA30
        public void get_sliderMixed(){} // RVA: 0x7FFAC991FA90
        public void set_sliderMixed(){} // RVA: 0x7FFAC991FAA0
        public void get_verticalSlider(){} // RVA: 0x7FFAC991FB00
        public void set_verticalSlider(){} // RVA: 0x7FFAC991FB10
        public void get_verticalSliderThumb(){} // RVA: 0x7FFAC991FB70
        public void set_verticalSliderThumb(){} // RVA: 0x7FFAC991FB80
        public void get_verticalSliderThumbExtent(){} // RVA: 0x7FFAC991FBE0
        public void set_verticalSliderThumbExtent(){} // RVA: 0x7FFAC991FBF0
        public void get_horizontalScrollbar(){} // RVA: 0x7FFAC991FC50
        public void set_horizontalScrollbar(){} // RVA: 0x7FFAC991FC60
        public void get_horizontalScrollbarThumb(){} // RVA: 0x7FFAC991FCC0
        public void set_horizontalScrollbarThumb(){} // RVA: 0x7FFAC991FCD0
        public void get_horizontalScrollbarLeftButton(){} // RVA: 0x7FFAC991FD30
        public void set_horizontalScrollbarLeftButton(){} // RVA: 0x7FFAC991FD40
        public void get_horizontalScrollbarRightButton(){} // RVA: 0x7FFAC991FDA0
        public void set_horizontalScrollbarRightButton(){} // RVA: 0x7FFAC991FDB0
        public void get_verticalScrollbar(){} // RVA: 0x7FFAC991FE10
        public void set_verticalScrollbar(){} // RVA: 0x7FFAC991FE20
        public void get_verticalScrollbarThumb(){} // RVA: 0x7FFAC991FE80
        public void set_verticalScrollbarThumb(){} // RVA: 0x7FFAC991FE90
        public void get_verticalScrollbarUpButton(){} // RVA: 0x7FFAC991FEF0
        public void set_verticalScrollbarUpButton(){} // RVA: 0x7FFAC991FF00
        public void get_verticalScrollbarDownButton(){} // RVA: 0x7FFAC991FF60
        public void set_verticalScrollbarDownButton(){} // RVA: 0x7FFAC991FF70
        public void get_scrollView(){} // RVA: 0x7FFAC991FFD0
        public void set_scrollView(){} // RVA: 0x7FFAC991FFE0
        public void get_customStyles(){} // RVA: 0x7FFAC9920040
        public void set_customStyles(){} // RVA: 0x7FFAC9920050
        public void get_settings(){} // RVA: 0x7FFAC99200B0
        public void get_error(){} // RVA: 0x7FFAC99200C0
        public void Apply(){} // RVA: 0x7FFAC99201F0
        public void BuildStyleCache(){} // RVA: 0x7FFAC9920270
        public void GetStyle(){} // RVA: 0x7FFAC9921C50
        public void FindStyle(){} // RVA: 0x7FFAC9921F30
        public void MakeCurrent(){} // RVA: 0x7FFAC9921FD0
        public void GetEnumerator(){} // RVA: 0x7FFAC9922100
    }

    public class GUIStateObjects : Object
    {
        public System.Collections.Generic.Dictionary`2<int,object> s_StateCache;

        // ── Methods ──
        public void GetStateObject(){} // RVA: 0x7FFAC9922240
        public void .cctor(){} // RVA: 0x7FFAC99223C0
    }

    public class GUIStyle : Object
    {
        public UIntPtr rawName; // 0x10
        public UnityEngine.GUIStyleState font; // 0x18
        public UnityEngine.GUIStyleState imagePosition; // 0x20
        public UnityEngine.GUIStyleState wordWrap; // 0x28
        public UnityEngine.GUIStyleState contentOffset; // 0x30
        public UnityEngine.GUIStyleState fixedWidth; // 0x38
        public UnityEngine.GUIStyleState fixedHeight; // 0x40
        public UnityEngine.GUIStyleState stretchWidth; // 0x48
        public UnityEngine.GUIStyleState stretchHeight; // 0x50
        public UnityEngine.RectOffset Internal_clipOffset; // 0x58
        public UnityEngine.RectOffset name; // 0x60
        public UnityEngine.RectOffset normal; // 0x68
        public UnityEngine.RectOffset border; // 0x70
        public string margin; // 0x78
        public bool padding;
        public UnityEngine.GUIStyle lineHeight; // 0x8

        // ── Methods ──
        public void get_rawName(){} // RVA: 0x7FFAC9922800
        public void set_rawName(){} // RVA: 0x7FFAC9922850
        public void get_font(){} // RVA: 0x7FFAC99228B0
        public void get_imagePosition(){} // RVA: 0x7FFAC9922900
        public void get_wordWrap(){} // RVA: 0x7FFAC9922950
        public void get_contentOffset(){} // RVA: 0x7FFAC99229A0
        public void set_contentOffset(){} // RVA: 0x7FFAC9922A00
        public void get_fixedWidth(){} // RVA: 0x7FFAC9922A60
        public void get_fixedHeight(){} // RVA: 0x7FFAC9922AB0
        public void get_stretchWidth(){} // RVA: 0x7FFAC9922B00
        public void set_stretchWidth(){} // RVA: 0x7FFAC9922B50
        public void get_stretchHeight(){} // RVA: 0x7FFAC9922BB0
        public void set_stretchHeight(){} // RVA: 0x7FFAC9922C00
        public void set_Internal_clipOffset(){} // RVA: 0x7FFAC9922C60
        public void Internal_Create(){} // RVA: 0x7FFAC9922CC0
        public void Internal_Copy(){} // RVA: 0x7FFAC9922D10
        public void Internal_Destroy(){} // RVA: 0x7FFAC9922D70
        public void GetStyleStatePtr(){} // RVA: 0x7FFAC9922DC0
        public void GetRectOffsetPtr(){} // RVA: 0x7FFAC9922E20
        public void Internal_GetLineHeight(){} // RVA: 0x7FFAC9922E80
        public void Internal_Draw(){} // RVA: 0x7FFAC9922ED0
        public void Internal_Draw2(){} // RVA: 0x7FFAC9922F80
        public void Internal_DrawCursor(){} // RVA: 0x7FFAC9923010
        public void Internal_DrawWithTextSelection(){} // RVA: 0x7FFAC99230A0
        public void Internal_GetCursorPixelPosition(){} // RVA: 0x7FFAC9923190
        public void Internal_GetCursorStringIndex(){} // RVA: 0x7FFAC9923230
        public void Internal_GetSelectedRenderedText(){} // RVA: 0x7FFAC99232B0
        public void Internal_CalcSize(){} // RVA: 0x7FFAC9923340
        public void Internal_CalcSizeWithConstraints(){} // RVA: 0x7FFAC99233B0
        public void Internal_CalcHeight(){} // RVA: 0x7FFAC9923430
        public void Internal_CalcMinMaxWidth(){} // RVA: 0x7FFAC99234A0
        public void SetMouseTooltip(){} // RVA: 0x7FFAC9923510
        public void IsTooltipActive(){} // RVA: 0x7FFAC99235B0
        public void Internal_GetCursorFlashOffset(){} // RVA: 0x7FFAC9923600
        public void SetDefaultFont(){} // RVA: 0x7FFAC9923650
        public void .ctor(){} // RVA: 0x7FFAC9923730 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFAC9923820
        public void get_name(){} // RVA: 0x7FFAC99238F0
        public void set_name(){} // RVA: 0x7FFAC99239B0
        public void get_normal(){} // RVA: 0x7FFAC9923A60
        public void get_border(){} // RVA: 0x7FFAC9923BC0
        public void get_margin(){} // RVA: 0x7FFAC9923D20
        public void get_padding(){} // RVA: 0x7FFAC9923E80
        public void get_lineHeight(){} // RVA: 0x7FFAC9923FE0
        public void Draw(){} // RVA: 0x7FFAC9924440 | overloaded x6
        public void DrawCursor(){} // RVA: 0x7FFAC9924560
        public void DrawWithTextSelection(){} // RVA: 0x7FFAC9924ED0 | overloaded x3
        public void get_none(){} // RVA: 0x7FFAC9924F10
        public void GetCursorPixelPosition(){} // RVA: 0x7FFAC9925010
        public void GetCursorStringIndex(){} // RVA: 0x7FFAC99250B0
        public void CalcSize(){} // RVA: 0x7FFAC9923340
        public void CalcSizeWithConstraints(){} // RVA: 0x7FFAC99233B0
        public void CalcHeight(){} // RVA: 0x7FFAC9923430
        public void get_isHeightDependantOnWidth(){} // RVA: 0x7FFAC9925130
        public void CalcMinMaxWidth(){} // RVA: 0x7FFAC9925230
        public void ToString(){} // RVA: 0x7FFAC99252D0
        public void .cctor(){} // RVA: 0x7FFAC9925390
        public void get_contentOffset_Injected(){} // RVA: 0x7FFAC99253D0
        public void set_contentOffset_Injected(){} // RVA: 0x7FFAC9925430
        public void set_Internal_clipOffset_Injected(){} // RVA: 0x7FFAC9925490
        public void Internal_Draw_Injected(){} // RVA: 0x7FFAC99254F0
        public void Internal_Draw2_Injected(){} // RVA: 0x7FFAC99255A0
        public void Internal_DrawCursor_Injected(){} // RVA: 0x7FFAC9925630
        public void Internal_DrawWithTextSelection_Injected(){} // RVA: 0x7FFAC99256C0
        public void Internal_GetCursorPixelPosition_Injected(){} // RVA: 0x7FFAC9925790
        public void Internal_GetCursorStringIndex_Injected(){} // RVA: 0x7FFAC9925820
        public void Internal_GetSelectedRenderedText_Injected(){} // RVA: 0x7FFAC99258A0
        public void Internal_CalcSize_Injected(){} // RVA: 0x7FFAC9925930
        public void Internal_CalcSizeWithConstraints_Injected(){} // RVA: 0x7FFAC99259A0
        public void Internal_CalcMinMaxWidth_Injected(){} // RVA: 0x7FFAC9925A20
        public void SetMouseTooltip_Injected(){} // RVA: 0x7FFAC9925A90
    }

    public class GUIStyleState : Object
    {
        public UIntPtr background; // 0x10
        public UnityEngine.GUIStyle textColor; // 0x18

        // ── Methods ──
        public void set_background(){} // RVA: 0x7FFAC99224A0
        public void set_textColor(){} // RVA: 0x7FFAC9922500
        public void Init(){} // RVA: 0x7FFAC9922560
        public void Cleanup(){} // RVA: 0x7FFAC99225B0
        public void .ctor(){} // RVA: 0x7FFAC9867A50 | overloaded x2
        public void GetGUIStyleState(){} // RVA: 0x7FFAC9922650
        public void Finalize(){} // RVA: 0x7FFAC9922710
        public void set_textColor_Injected(){} // RVA: 0x7FFAC99227A0
    }

    public class GUITargetAttribute : Attribute
    {
        public int displayMask; // 0x10

        // ── Methods ──
        public void GetGUITargetAttrValue(){} // RVA: 0x7FFAC9925AF0
    }

    public class GUIText : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class GUITexture : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
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
        public System.Action`2<0x6B27F530,0x6B17D1A8> hotControl; // 0x40
        public UnityEngine.Event keyboardControl; // 0x48
        public bool <guiIsExiting>k__BackingField; // 0x50
        public System.Func`1<bool> s_HasCurrentWindowKeyFocusFunc; // 0x58

        // ── Methods ──
        public void get_pixelsPerPoint(){} // RVA: 0x7FFAC9925D50
        public void get_guiDepth(){} // RVA: 0x7FFAC9925DA0
        public void set_mouseUsed(){} // RVA: 0x7FFAC9925DF0
        public void get_textFieldInput(){} // RVA: 0x7FFAC9925E40
        public void set_textFieldInput(){} // RVA: 0x7FFAC9925E90
        public void get_systemCopyBuffer(){} // RVA: 0x7FFAC9925EE0
        public void set_systemCopyBuffer(){} // RVA: 0x7FFAC9925F30
        public void Internal_GetControlID(){} // RVA: 0x7FFAC9925F80
        public void GetControlID(){} // RVA: 0x7FFAC9926830 | overloaded x3
        public void BeginContainerFromOwner(){} // RVA: 0x7FFAC9926120
        public void BeginContainer(){} // RVA: 0x7FFAC9926170
        public void Internal_EndContainer(){} // RVA: 0x7FFAC99261C0
        public void CheckForTabEvent(){} // RVA: 0x7FFAC9926210
        public void SetKeyboardControlToFirstControlId(){} // RVA: 0x7FFAC9926260
        public void SetKeyboardControlToLastControlId(){} // RVA: 0x7FFAC99262B0
        public void HasFocusableControls(){} // RVA: 0x7FFAC9926300
        public void OwnsId(){} // RVA: 0x7FFAC9926350
        public void AlignRectToDevice(){} // RVA: 0x7FFAC9927FE0 | overloaded x2
        public void get_compositionString(){} // RVA: 0x7FFAC9926460
        public void set_imeCompositionMode(){} // RVA: 0x7FFAC99264B0
        public void set_compositionCursorPos(){} // RVA: 0x7FFAC9926500
        public void Internal_GetHotControl(){} // RVA: 0x7FFAC9926590
        public void Internal_GetKeyboardControl(){} // RVA: 0x7FFAC99265E0
        public void Internal_SetHotControl(){} // RVA: 0x7FFAC9926630
        public void Internal_SetKeyboardControl(){} // RVA: 0x7FFAC9926680
        public void Internal_GetDefaultSkin(){} // RVA: 0x7FFAC99266D0
        public void Internal_ExitGUI(){} // RVA: 0x7FFAC9926720
        public void MarkGUIChanged(){} // RVA: 0x7FFAC9926770
        public void GetStateObject(){} // RVA: 0x7FFAC99268B0
        public void set_guiIsExiting(){} // RVA: 0x7FFAC9926A70
        public void get_hotControl(){} // RVA: 0x7FFAC9926AD0
        public void set_hotControl(){} // RVA: 0x7FFAC9926B50
        public void TakeCapture(){} // RVA: 0x7FFAC9926BE0
        public void RemoveCapture(){} // RVA: 0x7FFAC9926C50
        public void get_keyboardControl(){} // RVA: 0x7FFAC9926CC0
        public void set_keyboardControl(){} // RVA: 0x7FFAC9926D40
        public void HasKeyFocus(){} // RVA: 0x7FFAC9926DD0
        public void ExitGUI(){} // RVA: 0x7FFAC9926EB0
        public void GetDefaultSkin(){} // RVA: 0x7FFAC9926EF0
        public void ProcessEvent(){} // RVA: 0x7FFAC9926FC0
        public void EndContainer(){} // RVA: 0x7FFAC9927210
        public void BeginGUI(){} // RVA: 0x7FFAC99272D0
        public void EndGUI(){} // RVA: 0x7FFAC9927390
        public void EndGUIFromException(){} // RVA: 0x7FFAC99275B0
        public void EndContainerGUIFromException(){} // RVA: 0x7FFAC9927640
        public void ResetGlobalState(){} // RVA: 0x7FFAC99276E0
        public void IsExitGUIException(){} // RVA: 0x7FFAC9927840
        public void ShouldRethrowException(){} // RVA: 0x7FFAC99278D0
        public void CheckOnGUI(){} // RVA: 0x7FFAC9927990
        public void RoundToPixelGrid(){} // RVA: 0x7FFAC9927A70
        public void ScaleAroundPivot(){} // RVA: 0x7FFAC9927B60
        public void HitTest(){} // RVA: 0x7FFAC9928230 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFAC9928310
        public void Internal_GetControlID_Injected(){} // RVA: 0x7FFAC9928420
        public void AlignRectToDevice_Injected(){} // RVA: 0x7FFAC9928490
        public void set_compositionCursorPos_Injected(){} // RVA: 0x7FFAC9928510
    }

    public class GUIWordWrapSizer : GUILayoutEntry
    {
        public UnityEngine.GUIContent m_Content; // 0x48
        public float m_ForcedMinHeight; // 0x50
        public float m_ForcedMaxHeight; // 0x54

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC992A370
        public void CalcWidth(){} // RVA: 0x7FFAC992A4A0
        public void CalcHeight(){} // RVA: 0x7FFAC992A5A0
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
        public void CreatePrimitive(){} // RVA: 0x7FFAC98C0060
        public void GetComponent(){} // RVA: 0x7FFAC98C0180 | overloaded x3
        public void GetComponentFastPath(){} // RVA: 0x7FFAC98C0110
        public void GetComponentByName(){} // RVA: 0x7FFAC98C0180
        public void GetComponentInChildren(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void GetComponentInParent(){} // RVA: 0x7FFAC2E8DC40 | overloaded x4
        public void GetComponentsInternal(){} // RVA: 0x7FFAC98C03A0
        public void GetComponents(){} // RVA: 0x7FFAC2C70A40 | overloaded x4
        public void GetComponentsInChildren(){} // RVA: 0x7FFAC2C70A40 | overloaded x6
        public void GetComponentsInParent(){} // RVA: 0x7FFAC2C58E90 | overloaded x5
        public void TryGetComponent(){} // RVA: 0x7FFAC98C0770 | overloaded x2
        public void TryGetComponentInternal(){} // RVA: 0x7FFAC98C08F0
        public void TryGetComponentFastPath(){} // RVA: 0x7FFAC98C0950
        public void FindWithTag(){} // RVA: 0x7FFAC98C09C0
        public void SendMessageUpwards(){} // RVA: 0x7FFAC98C1360 | overloaded x4
        public void SendMessage(){} // RVA: 0x7FFAC98C1420 | overloaded x4
        public void BroadcastMessage(){} // RVA: 0x7FFAC98C14E0 | overloaded x4
        public void AddComponentInternal(){} // RVA: 0x7FFAC98C0A70
        public void Internal_AddComponentWithType(){} // RVA: 0x7FFAC98C0AD0
        public void AddComponent(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetComponentCount(){} // RVA: 0x7FFAC98C0B30
        public void QueryComponentAtIndex(){} // RVA: 0x7FFAC98C0B80
        public void GetComponentAtIndex(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void GetComponentIndex(){} // RVA: 0x7FFAC98C0CF0
        public void get_transform(){} // RVA: 0x7FFAC98C0D50
        public void get_layer(){} // RVA: 0x7FFAC98C0DA0
        public void set_layer(){} // RVA: 0x7FFAC98C0DF0
        public void get_active(){} // RVA: 0x7FFAC98C0E50
        public void set_active(){} // RVA: 0x7FFAC98C0EA0
        public void SetActive(){} // RVA: 0x7FFAC98C0F00
        public void get_activeSelf(){} // RVA: 0x7FFAC98C0F60
        public void get_activeInHierarchy(){} // RVA: 0x7FFAC98C0FB0
        public void SetActiveRecursively(){} // RVA: 0x7FFAC98C1000
        public void get_isStatic(){} // RVA: 0x7FFAC98C1060
        public void set_isStatic(){} // RVA: 0x7FFAC98C10B0
        public void get_isStaticBatchable(){} // RVA: 0x7FFAC98C1110
        public void get_tag(){} // RVA: 0x7FFAC98C1160
        public void set_tag(){} // RVA: 0x7FFAC98C11B0
        public void CompareTag(){} // RVA: 0x7FFAC98C1210
        public void FindGameObjectWithTag(){} // RVA: 0x7FFAC98C09C0
        public void FindGameObjectsWithTag(){} // RVA: 0x7FFAC98C1270
        public void .ctor(){} // RVA: 0x7FFAC98C1630 | overloaded x3
        public void Internal_CreateGameObject(){} // RVA: 0x7FFAC98C1760
        public void Find(){} // RVA: 0x7FFAC98C17C0
        public void SetGameObjectsActive(){} // RVA: 0x7FFAC98C1950 | overloaded x3
        public void InstantiateGameObjects(){} // RVA: 0x7FFAC98C1A50 | overloaded x2
        public void GetScene(){} // RVA: 0x7FFAC98C1C60
        public void get_scene(){} // RVA: 0x7FFAC98C1CC0
        public void get_sceneCullingMask(){} // RVA: 0x7FFAC98C1D20
        public void get_gameObject(){} // RVA: 0x7FFAC869D800
        public void InstantiateGameObjects_Injected(){} // RVA: 0x7FFAC98C1D70
        public void GetScene_Injected(){} // RVA: 0x7FFAC98C1DF0
        public void get_scene_Injected(){} // RVA: 0x7FFAC98C1E50
    }

    public class GeometryUtility : Object
    {
        // ── Methods ──
        public void CalculateFrustumPlanes(){} // RVA: 0x7FFAC9865290 | overloaded x4
        public void CalculateBounds(){} // RVA: 0x7FFAC98653D0
        public void TryCreatePlaneFromPolygon(){} // RVA: 0x7FFAC9865550
        public void TestPlanesAABB(){} // RVA: 0x7FFAC9865A00
        public void Internal_ExtractPlanes(){} // RVA: 0x7FFAC9865A60
        public void Internal_CalculateBounds(){} // RVA: 0x7FFAC9865AC0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void TestPlanesAABB_Injected(){} // RVA: 0x7FFAC9865B40
        public void Internal_ExtractPlanes_Injected(){} // RVA: 0x7FFAC9865BA0
        public void Internal_CalculateBounds_Injected(){} // RVA: 0x7FFAC9865C00
    }

    public class Gizmos : Object
    {
        public object color;
        public object matrix;
        public object probeSize;

        // ── Methods ──
        public void DrawLine(){} // RVA: 0x7FFAC98687C0
        public void DrawWireSphere(){} // RVA: 0x7FFAC9868820
        public void DrawSphere(){} // RVA: 0x7FFAC9868880
        public void DrawWireCube(){} // RVA: 0x7FFAC98688E0
        public void DrawCube(){} // RVA: 0x7FFAC9868940
        public void DrawMesh(){} // RVA: 0x7FFAC9869180 | overloaded x3
        public void DrawWireMesh(){} // RVA: 0x7FFAC9869820 | overloaded x8
        public void DrawIcon(){} // RVA: 0x7FFAC9869970 | overloaded x3
        public void DrawGUITexture(){} // RVA: 0x7FFAC9869AF0 | overloaded x4
        public void get_color(){} // RVA: 0x7FFAC9868C70
        public void set_color(){} // RVA: 0x7FFAC9868CD0
        public void get_matrix(){} // RVA: 0x7FFAC9868D20
        public void set_matrix(){} // RVA: 0x7FFAC9868D90
        public void get_probeSize(){} // RVA: 0x7FFAC9868DE0
        public void DrawFrustum(){} // RVA: 0x7FFAC9868E30
        public void DrawRay(){} // RVA: 0x7FFAC9868F80 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void DrawLine_Injected(){} // RVA: 0x7FFAC9869B90
        public void DrawWireSphere_Injected(){} // RVA: 0x7FFAC9869BF0
        public void DrawSphere_Injected(){} // RVA: 0x7FFAC9869C50
        public void DrawWireCube_Injected(){} // RVA: 0x7FFAC9869CB0
        public void DrawCube_Injected(){} // RVA: 0x7FFAC9869D10
        public void DrawMesh_Injected(){} // RVA: 0x7FFAC9869D70
        public void DrawWireMesh_Injected(){} // RVA: 0x7FFAC9869DF0
        public void DrawIcon_Injected(){} // RVA: 0x7FFAC9869E70
        public void DrawGUITexture_Injected(){} // RVA: 0x7FFAC9869EF0
        public void get_color_Injected(){} // RVA: 0x7FFAC9869F80
        public void set_color_Injected(){} // RVA: 0x7FFAC9869FD0
        public void get_matrix_Injected(){} // RVA: 0x7FFAC986A020
        public void set_matrix_Injected(){} // RVA: 0x7FFAC986A070
        public void DrawFrustum_Injected(){} // RVA: 0x7FFAC986A0C0
    }

    public class GlobalJavaObjectRef : Object
    {
        public bool m_disposed; // 0x10
        public UIntPtr m_jobject; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98150F0
        public void Finalize(){} // RVA: 0x7FFAC9815170
        public void op_Implicit(){} // RVA: 0x7FFAC38DFDA0
        public void Dispose(){} // RVA: 0x7FFAC98151B0
    }

    public class Gradient : Object
    {
        public UIntPtr colorKeys; // 0x10

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC98A9EA0
        public void Cleanup(){} // RVA: 0x7FFAC98A9EF0
        public void Internal_Equals(){} // RVA: 0x7FFAC98A9F40
        public void .ctor(){} // RVA: 0x7FFAC98A9FA0
        public void Finalize(){} // RVA: 0x7FFAC98A9FF0
        public void Evaluate(){} // RVA: 0x7FFAC98AA070
        public void get_colorKeys(){} // RVA: 0x7FFAC98AA0F0
        public void set_colorKeys(){} // RVA: 0x7FFAC98AA140
        public void get_alphaKeys(){} // RVA: 0x7FFAC98AA1A0
        public void set_alphaKeys(){} // RVA: 0x7FFAC98AA1F0
        public void get_mode(){} // RVA: 0x7FFAC98AA250
        public void set_mode(){} // RVA: 0x7FFAC98AA2A0
        public void get_colorSpace(){} // RVA: 0x7FFAC98AA300
        public void set_colorSpace(){} // RVA: 0x7FFAC98AA350
        public void SetKeys(){} // RVA: 0x7FFAC98AA3B0
        public void Equals(){} // RVA: 0x7FFAC98AA530 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9851CE0
        public void Evaluate_Injected(){} // RVA: 0x7FFAC98AA670
    }

    public class GradientAlphaKey : ValueType
    {
        public float alpha; // 0x10
        public float time; // 0x14

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F44D10
    }

    public class GradientColorKey : ValueType
    {
        public UnityEngine.Color color; // 0x10
        public float time; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC98A9E90
    }

    public class Graphics : Object
    {
        public int kMaxDrawMeshInstanceCount;
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.RenderInstancedDataLayout> s_RenderInstancedDataLayouts; // 0x8

        // ── Methods ──
        public void Internal_GetMaxDrawMeshInstanceCount(){} // RVA: 0x7FFAC986CA30
        public void Internal_SetNullRT(){} // RVA: 0x7FFAC986CA80
        public void Internal_SetRTSimple(){} // RVA: 0x7FFAC986CAD0
        public void Internal_SetRandomWriteTargetBuffer(){} // RVA: 0x7FFAC986CB90
        public void ClearRandomWriteTargets(){} // RVA: 0x7FFAC986CC00
        public void CopyTexture_Full(){} // RVA: 0x7FFAC986CC50
        public void CopyTexture_Slice(){} // RVA: 0x7FFAC986CCB0
        public void CopyTexture_Region(){} // RVA: 0x7FFAC986CD30
        public void ConvertTexture_Full(){} // RVA: 0x7FFAC986CDC0
        public void Internal_DrawMeshNow2(){} // RVA: 0x7FFAC986CE20
        public void Internal_DrawTexture(){} // RVA: 0x7FFAC986CED0
        public void Internal_RenderMeshPrimitives(){} // RVA: 0x7FFAC986CF20
        public void Internal_DrawMesh(){} // RVA: 0x7FFAC986CFE0
        public void Internal_DrawMeshInstanced(){} // RVA: 0x7FFAC986D100
        public void Internal_DrawProcedural(){} // RVA: 0x7FFAC986D1A0
        public void Internal_DrawProceduralIndirect(){} // RVA: 0x7FFAC986D2A0
        public void Internal_BlitMaterial5(){} // RVA: 0x7FFAC986D3A0
        public void Internal_BlitMaterial6(){} // RVA: 0x7FFAC986D430
        public void Blit2(){} // RVA: 0x7FFAC986D4C0
        public void Blit3(){} // RVA: 0x7FFAC986D520
        public void Blit4(){} // RVA: 0x7FFAC986D5A0
        public void Blit5(){} // RVA: 0x7FFAC986D650
        public void ExecuteCommandBuffer(){} // RVA: 0x7FFAC986D710
        public void ExecuteCommandBufferAsync(){} // RVA: 0x7FFAC986D760
        public void SetRenderTargetImpl(){} // RVA: 0x7FFAC986D8D0 | overloaded x2
        public void SetRenderTarget(){} // RVA: 0x7FFAC9870640 | overloaded x3
        public void SetRandomWriteTarget(){} // RVA: 0x7FFAC98706C0 | overloaded x2
        public void CopyTexture(){} // RVA: 0x7FFAC986DF90 | overloaded x3
        public void ConvertTexture(){} // RVA: 0x7FFAC986E050
        public void DrawTextureImpl(){} // RVA: 0x7FFAC986E0F0
        public void DrawTexture(){} // RVA: 0x7FFAC9870480 | overloaded x7
        public void RenderMeshPrimitives(){} // RVA: 0x7FFAC986E740
        public void DrawMeshNow(){} // RVA: 0x7FFAC986EB40 | overloaded x2
        public void DrawMesh(){} // RVA: 0x7FFAC986EF00 | overloaded x3
        public void DrawMeshInstanced(){} // RVA: 0x7FFAC986F1A0
        public void DrawProcedural(){} // RVA: 0x7FFAC986F870
        public void DrawProceduralIndirect(){} // RVA: 0x7FFAC986F9C0
        public void Blit(){} // RVA: 0x7FFAC98701D0 | overloaded x9
        public void .cctor(){} // RVA: 0x7FFAC9870720
        public void Internal_SetRTSimple_Injected(){} // RVA: 0x7FFAC98708D0
        public void Internal_DrawMeshNow2_Injected(){} // RVA: 0x7FFAC9870960
        public void Internal_RenderMeshPrimitives_Injected(){} // RVA: 0x7FFAC98709D0
        public void Internal_DrawMesh_Injected(){} // RVA: 0x7FFAC9870A50
        public void Internal_DrawProcedural_Injected(){} // RVA: 0x7FFAC9870AF0
        public void Internal_DrawProceduralIndirect_Injected(){} // RVA: 0x7FFAC9870B80
        public void Blit4_Injected(){} // RVA: 0x7FFAC9870C10
        public void Blit5_Injected(){} // RVA: 0x7FFAC9870C90
    }

    public class GraphicsBuffer : Object
    {
        public UIntPtr count; // 0x10

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFAC9887880
        public void Dispose(){} // RVA: 0x7FFAC98879F0 | overloaded x2
        public void RequiresCompute(){} // RVA: 0x7FFAC9887AD0
        public void IsVertexIndexOrCopyOnly(){} // RVA: 0x7FFAC9887AE0
        public void InitBuffer(){} // RVA: 0x7FFAC9887AF0
        public void DestroyBuffer(){} // RVA: 0x7FFAC9887B70
        public void .ctor(){} // RVA: 0x7FFAC9887BF0 | overloaded x2
        public void InternalInitialization(){} // RVA: 0x7FFAC9887C00
        public void Release(){} // RVA: 0x7FFAC9888060
        public void IsValidBuffer(){} // RVA: 0x7FFAC9888070
        public void IsValid(){} // RVA: 0x7FFAC98880C0
        public void get_count(){} // RVA: 0x7FFAC9888130
        public void get_stride(){} // RVA: 0x7FFAC9888180
        public void GetUsageFlags(){} // RVA: 0x7FFAC98881D0
        public void get_usageFlags(){} // RVA: 0x7FFAC98881D0
        public void SetData(){} // RVA: 0x7FFAC9888220
        public void InternalSetData(){} // RVA: 0x7FFAC9888400
        public void BeginBufferWrite(){} // RVA: 0x7FFAC9888490
        public void LockBufferForWrite(){} // RVA: 0x7FFAC2E8DC40
        public void EndBufferWrite(){} // RVA: 0x7FFAC9888500
        public void UnlockBufferAfterWrite(){} // RVA: 0x7FFAC2C70ED0
    }

    public class Grid : GridLayout
    {
        public object cellSize;
        public object cellGap;
        public object cellLayout;
        public object cellSwizzle;

        // ── Methods ──
        public void GetCellCenterLocal(){} // RVA: 0x7FFAC9903930
        public void GetCellCenterWorld(){} // RVA: 0x7FFAC9903AA0
        public void get_cellSize(){} // RVA: 0x7FFAC9903C70
        public void set_cellSize(){} // RVA: 0x7FFAC9903CE0
        public void get_cellGap(){} // RVA: 0x7FFAC9903D40
        public void set_cellGap(){} // RVA: 0x7FFAC9903DB0
        public void get_cellLayout(){} // RVA: 0x7FFAC9903E10
        public void set_cellLayout(){} // RVA: 0x7FFAC9903E60
        public void get_cellSwizzle(){} // RVA: 0x7FFAC9903EC0
        public void set_cellSwizzle(){} // RVA: 0x7FFAC9903F10
        public void Swizzle(){} // RVA: 0x7FFAC9903F70
        public void InverseSwizzle(){} // RVA: 0x7FFAC9903FF0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_cellSize_Injected(){} // RVA: 0x7FFAC9904070
        public void set_cellSize_Injected(){} // RVA: 0x7FFAC99040D0
        public void get_cellGap_Injected(){} // RVA: 0x7FFAC9904130
        public void set_cellGap_Injected(){} // RVA: 0x7FFAC9904190
        public void Swizzle_Injected(){} // RVA: 0x7FFAC99041F0
        public void InverseSwizzle_Injected(){} // RVA: 0x7FFAC9904260
    }

    public class GridLayout : Behaviour
    {
        public object cellSize;
        public object cellGap;
        public object cellLayout;
        public object cellSwizzle;

        // ── Methods ──
        public void get_cellSize(){} // RVA: 0x7FFAC99042D0
        public void get_cellGap(){} // RVA: 0x7FFAC9904340
        public void get_cellLayout(){} // RVA: 0x7FFAC99043B0
        public void get_cellSwizzle(){} // RVA: 0x7FFAC9904400
        public void GetBoundsLocal(){} // RVA: 0x7FFAC99044D0 | overloaded x2
        public void GetBoundsLocalOriginSize(){} // RVA: 0x7FFAC99045A0
        public void CellToLocal(){} // RVA: 0x7FFAC9904630
        public void LocalToCell(){} // RVA: 0x7FFAC99046B0
        public void CellToLocalInterpolated(){} // RVA: 0x7FFAC9904730
        public void LocalToCellInterpolated(){} // RVA: 0x7FFAC99047B0
        public void CellToWorld(){} // RVA: 0x7FFAC9904830
        public void WorldToCell(){} // RVA: 0x7FFAC99048B0
        public void LocalToWorld(){} // RVA: 0x7FFAC9904930
        public void WorldToLocal(){} // RVA: 0x7FFAC99049B0
        public void GetLayoutCellCenter(){} // RVA: 0x7FFAC9904A30
        public void DoNothing(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_cellSize_Injected(){} // RVA: 0x7FFAC9904AA0
        public void get_cellGap_Injected(){} // RVA: 0x7FFAC9904B00
        public void GetBoundsLocal_Injected(){} // RVA: 0x7FFAC9904B60
        public void GetBoundsLocalOriginSize_Injected(){} // RVA: 0x7FFAC9904BD0
        public void CellToLocal_Injected(){} // RVA: 0x7FFAC9904C50
        public void LocalToCell_Injected(){} // RVA: 0x7FFAC9904CC0
        public void CellToLocalInterpolated_Injected(){} // RVA: 0x7FFAC9904D30
        public void LocalToCellInterpolated_Injected(){} // RVA: 0x7FFAC9904DA0
        public void CellToWorld_Injected(){} // RVA: 0x7FFAC9904E10
        public void WorldToCell_Injected(){} // RVA: 0x7FFAC9904E80
        public void LocalToWorld_Injected(){} // RVA: 0x7FFAC9904EF0
        public void WorldToLocal_Injected(){} // RVA: 0x7FFAC9904F60
        public void GetLayoutCellCenter_Injected(){} // RVA: 0x7FFAC9904FD0
    }

}