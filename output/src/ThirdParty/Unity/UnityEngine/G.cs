// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 34
// Methods: 819

namespace ThirdParty.Unity.UnityEngine
{
    public class GL : Object
    {
        // ── Methods ──
        public void Vertex3(){} // RVA: 0x7FFE87C19370
        public void TexCoord3(){} // RVA: 0x7FFE87C193F0
        public void TexCoord(){} // RVA: 0x7FFE87C19470
        public void TexCoord2(){} // RVA: 0x7FFE87C19490
        public void ImmediateColor(){} // RVA: 0x7FFE87C194A0
        public void Color(){} // RVA: 0x7FFE87C19530
        public void get_sRGBWrite(){} // RVA: 0x7FFE87C19590
        public void set_sRGBWrite(){} // RVA: 0x7FFE87C195E0
        public void get_invertCulling(){} // RVA: 0x7FFE87C19630
        public void set_invertCulling(){} // RVA: 0x7FFE87C19680
        public void Flush(){} // RVA: 0x7FFE87C196D0
        public void SetViewMatrix(){} // RVA: 0x7FFE87C19720
        public void set_modelview(){} // RVA: 0x7FFE87C19770
        public void PushMatrix(){} // RVA: 0x7FFE87C197E0
        public void PopMatrix(){} // RVA: 0x7FFE87C19830
        public void LoadOrtho(){} // RVA: 0x7FFE87C19880
        public void LoadProjectionMatrix(){} // RVA: 0x7FFE87C198D0
        public void InvalidateState(){} // RVA: 0x7FFE87C19920
        public void GetGPUProjectionMatrix(){} // RVA: 0x7FFE87C19970
        public void GLLoadPixelMatrixScript(){} // RVA: 0x7FFE87C19A00
        public void LoadPixelMatrix(){} // RVA: 0x7FFE87C19A00
        public void GLIssuePluginEvent(){} // RVA: 0x7FFE87C19A90
        public void IssuePluginEvent(){} // RVA: 0x7FFE87C19AF0
        public void Begin(){} // RVA: 0x7FFE87C19BB0
        public void End(){} // RVA: 0x7FFE87C19C00
        public void GLClear(){} // RVA: 0x7FFE87C19C50
        public void Clear(){} // RVA: 0x7FFE87C19D50 | overloaded x2
        public void Viewport(){} // RVA: 0x7FFE87C19DD0
        public void SetViewMatrix_Injected(){} // RVA: 0x7FFE87C19E20
        public void LoadProjectionMatrix_Injected(){} // RVA: 0x7FFE87C19E70
        public void GetGPUProjectionMatrix_Injected(){} // RVA: 0x7FFE87C19EC0
        public void GLClear_Injected(){} // RVA: 0x7FFE87C19F30
        public void Viewport_Injected(){} // RVA: 0x7FFE87C19FB0
    }

    public class GUI : Object
    {
        public int s_ScrollControlId;
        public int s_HotTextField; // 0x4
        public int s_BoxHash; // 0x8
        public int s_ButonHash; // 0xC
        public int s_RepeatButtonHash; // 0x10
        public int s_ToggleHash; // 0x14
        public int s_ButtonGridHash; // 0x18
        public int s_SliderHash; // 0x1C
        public int s_BeginGroupHash; // 0x20
        public int s_ScrollviewHash; // 0x24
        public int _scrollTroughSide; // 0x28
        public System.DateTime _nextScrollStepTime; // 0x30
        public UnityEngine.GUISkin s_Skin; // 0x38
        public UnityEngine.Rect s_ToolTipRect; // 0x40
        public UnityEngineInternal.GenericStack _scrollViewStates; // 0x50
        public long TicksPerMillisecond;

        // ── Methods ──
        public void get_color(){} // RVA: 0x7FFE87CB1A50
        public void set_color(){} // RVA: 0x7FFE87CB1AE0
        public void get_backgroundColor(){} // RVA: 0x7FFE87CB1B70
        public void set_backgroundColor(){} // RVA: 0x7FFE87CB1C00
        public void get_contentColor(){} // RVA: 0x7FFE87CB1C90
        public void set_contentColor(){} // RVA: 0x7FFE87CB1D20
        public void get_changed(){} // RVA: 0x7FFE87CB1DB0
        public void set_changed(){} // RVA: 0x7FFE87CB1E00
        public void get_enabled(){} // RVA: 0x7FFE87CB1E50
        public void set_enabled(){} // RVA: 0x7FFE87CB1EA0
        public void set_depth(){} // RVA: 0x7FFE87CB1EF0
        public void get_usePageScrollbars(){} // RVA: 0x7FFE87CB1F40
        public void get_blendMaterial(){} // RVA: 0x7FFE87CB1F90
        public void get_blitMaterial(){} // RVA: 0x7FFE87CB1FE0
        public void get_roundedRectMaterial(){} // RVA: 0x7FFE87CB2030
        public void get_roundedRectWithColorPerBorderMaterial(){} // RVA: 0x7FFE87CB2080
        public void GrabMouseControl(){} // RVA: 0x7FFE87CB20D0
        public void HasMouseControl(){} // RVA: 0x7FFE87CB2120
        public void ReleaseMouseControl(){} // RVA: 0x7FFE87CB2170
        public void SetNextControlName(){} // RVA: 0x7FFE87CB21C0
        public void InternalRepaintEditorWindow(){} // RVA: 0x7FFE87CB2210
        public void Internal_DoWindow(){} // RVA: 0x7FFE87CB2260
        public void .cctor(){} // RVA: 0x7FFE87CB2360
        public void get_scrollTroughSide(){} // RVA: 0x7FFE87CB26A0
        public void set_scrollTroughSide(){} // RVA: 0x7FFE87CB2700
        public void get_nextScrollStepTime(){} // RVA: 0x7FFE87CB2760
        public void set_nextScrollStepTime(){} // RVA: 0x7FFE87CB27C0
        public void set_skin(){} // RVA: 0x7FFE87CB2820
        public void get_skin(){} // RVA: 0x7FFE87CB28A0
        public void DoSetSkin(){} // RVA: 0x7FFE87CB2930
        public void get_matrix(){} // RVA: 0x7FFE87CB2CB0
        public void set_matrix(){} // RVA: 0x7FFE87CB2D50
        public void Label(){} // RVA: 0x7FFE87CB3120 | overloaded x4
        public void DrawTexture(){} // RVA: 0x7FFE87CB3E80 | overloaded x9
        public void CalculateScaledTextureRects(){} // RVA: 0x7FFE87CB4720
        public void DrawTextureWithTexCoords(){} // RVA: 0x7FFE87CB4960 | overloaded x2
        public void Box(){} // RVA: 0x7FFE87CB50C0 | overloaded x3
        public void Button(){} // RVA: 0x7FFE87CB5480 | overloaded x3
        public void DoRepeatButton(){} // RVA: 0x7FFE87CB56B0
        public void PasswordFieldGetStrToShow(){} // RVA: 0x7FFE87CB5A10
        public void DoTextField(){} // RVA: 0x7FFE87CB5D40 | overloaded x3
        public void HandleTextFieldEventForTouchscreen(){} // RVA: 0x7FFE87CB63B0
        public void HandleTextFieldEventForDesktop(){} // RVA: 0x7FFE87CB6A50
        public void HandleTextFieldEventForDesktopWithForcedKeyboard(){} // RVA: 0x7FFE87CB73B0
        public void Toggle(){} // RVA: 0x7FFE87CB7860
        public void SelectionGrid(){} // RVA: 0x7FFE87CB7AC0
        public void CalcTotalHorizSpacing(){} // RVA: 0x7FFE87CB7BC0
        public void DoControl(){} // RVA: 0x7FFE87CB7F50
        public void DoLabel(){} // RVA: 0x7FFE87CB83A0
        public void DoToggle(){} // RVA: 0x7FFE87CB8780
        public void DoButton(){} // RVA: 0x7FFE87CB88F0
        public void DoButtonGrid(){} // RVA: 0x7FFE87CB8A60
        public void CalcGridRects(){} // RVA: 0x7FFE87CB96E0
        public void HorizontalSlider(){} // RVA: 0x7FFE87CB9A80
        public void Slider(){} // RVA: 0x7FFE87CB9B50
        public void HorizontalScrollbar(){} // RVA: 0x7FFE87CB9E30
        public void ScrollerRepeatButton(){} // RVA: 0x7FFE87CBA030
        public void VerticalScrollbar(){} // RVA: 0x7FFE87CBA370
        public void Scroller(){} // RVA: 0x7FFE87CBA570
        public void BeginGroup(){} // RVA: 0x7FFE87CBAF30 | overloaded x2
        public void EndGroup(){} // RVA: 0x7FFE87CBB290
        public void get_scrollViewStates(){} // RVA: 0x7FFE87CBB320
        public void BeginScrollView(){} // RVA: 0x7FFE87CBB380
        public void EndScrollView(){} // RVA: 0x7FFE87CBC3C0
        public void Window(){} // RVA: 0x7FFE87CBD810 | overloaded x2
        public void DoWindow(){} // RVA: 0x7FFE87CBD910
        public void CallWindowDelegate(){} // RVA: 0x7FFE87CBDAB0
        public void get_color_Injected(){} // RVA: 0x7FFE87CBDDE0
        public void set_color_Injected(){} // RVA: 0x7FFE87CBDE30
        public void get_backgroundColor_Injected(){} // RVA: 0x7FFE87CBDE80
        public void set_backgroundColor_Injected(){} // RVA: 0x7FFE87CBDED0
        public void get_contentColor_Injected(){} // RVA: 0x7FFE87CBDF20
        public void set_contentColor_Injected(){} // RVA: 0x7FFE87CBDF70
        public void Internal_DoWindow_Injected(){} // RVA: 0x7FFE87CBDFC0
    }

    public class GUIClip : Object
    {
        // ── Methods ──
        public void get_visibleRect(){} // RVA: 0x7FFE87CBE050
        public void Internal_Push(){} // RVA: 0x7FFE87CBE0B0
        public void Internal_Pop(){} // RVA: 0x7FFE87CBE130
        public void Internal_GetCount(){} // RVA: 0x7FFE87CBE180
        public void Unclip_Vector2(){} // RVA: 0x7FFE87CBE1D0
        public void UnclipToWindow_Vector2(){} // RVA: 0x7FFE87CBE240
        public void GetMatrix(){} // RVA: 0x7FFE87CBE2B0
        public void SetMatrix(){} // RVA: 0x7FFE87CBE320
        public void Internal_PushParentClip(){} // RVA: 0x7FFE87CBE420 | overloaded x2
        public void Internal_PopParentClip(){} // RVA: 0x7FFE87CBE490
        public void Push(){} // RVA: 0x7FFE87CBE4E0
        public void Pop(){} // RVA: 0x7FFE87CBE130
        public void Unclip(){} // RVA: 0x7FFE87CBE560
        public void UnclipToWindow(){} // RVA: 0x7FFE87CBE5D0
        public void get_visibleRect_Injected(){} // RVA: 0x7FFE87CBE640
        public void Internal_Push_Injected(){} // RVA: 0x7FFE87CBE690
        public void Unclip_Vector2_Injected(){} // RVA: 0x7FFE87CBE710
        public void UnclipToWindow_Vector2_Injected(){} // RVA: 0x7FFE87CBE770
        public void GetMatrix_Injected(){} // RVA: 0x7FFE87CBE7D0
        public void SetMatrix_Injected(){} // RVA: 0x7FFE87CBE820
        public void Internal_PushParentClip_Injected(){} // RVA: 0x7FFE87CBE870
    }

    public class GUIContent : Object
    {
        public string m_Text; // 0x10
        public UnityEngine.Texture m_Image; // 0x18
        public string m_Tooltip; // 0x20

        // ── Methods ──
        public void get_text(){} // RVA: 0x7FFE84022BE0
        public void set_text(){} // RVA: 0x7FFE87CBE9F0
        public void set_image(){} // RVA: 0x7FFE81161E80
        public void get_tooltip(){} // RVA: 0x7FFE87563690
        public void set_tooltip(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE87CBEE60 | overloaded x5
        public void Temp(){} // RVA: 0x7FFE87CBF640 | overloaded x3
        public void ClearStaticCache(){} // RVA: 0x7FFE87CBF310
        public void ToString(){} // RVA: 0x7FFE87CBF800
        public void .cctor(){} // RVA: 0x7FFE87CBF850
    }

    public class GUIElement : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class GUIGridSizer : GUILayoutEntry
    {
        public int m_Count; // 0x48

        // ── Methods ──
        public void GetRect(){} // RVA: 0x7FFE87CD2250
        public void .ctor(){} // RVA: 0x7FFE87CD2480
        public void get_rows(){} // RVA: 0x7FFE87CD2BF0
    }

    public class GUILayer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class GUILayout : Object
    {
        // ── Methods ──
        public void Label(){} // RVA: 0x7FFE87CBFBB0 | overloaded x2
        public void DoLabel(){} // RVA: 0x7FFE87CBFC30
        public void Box(){} // RVA: 0x7FFE87CBFD90
        public void DoBox(){} // RVA: 0x7FFE87CC0050
        public void Button(){} // RVA: 0x7FFE87CC0150
        public void DoButton(){} // RVA: 0x7FFE87CC02D0
        public void TextField(){} // RVA: 0x7FFE87CC0460 | overloaded x2
        public void DoTextField(){} // RVA: 0x7FFE87CC04F0
        public void Toggle(){} // RVA: 0x7FFE87CC0840
        public void DoToggle(){} // RVA: 0x7FFE87CC09E0
        public void SelectionGrid(){} // RVA: 0x7FFE87CC0E60 | overloaded x2
        public void HorizontalSlider(){} // RVA: 0x7FFE87CC0FD0
        public void DoHorizontalSlider(){} // RVA: 0x7FFE87CC1240
        public void Space(){} // RVA: 0x7FFE87CC1420
        public void FlexibleSpace(){} // RVA: 0x7FFE87CC1770
        public void BeginHorizontal(){} // RVA: 0x7FFE87CC1B70 | overloaded x2
        public void EndHorizontal(){} // RVA: 0x7FFE87CC1D50
        public void BeginVertical(){} // RVA: 0x7FFE87CC1EB0 | overloaded x3
        public void EndVertical(){} // RVA: 0x7FFE87CC2090
        public void BeginArea(){} // RVA: 0x7FFE87CC2190 | overloaded x2
        public void EndArea(){} // RVA: 0x7FFE87CC24C0
        public void BeginScrollView(){} // RVA: 0x7FFE87CC2750 | overloaded x2
        public void EndScrollView(){} // RVA: 0x7FFE87CC2BE0 | overloaded x2
        public void Window(){} // RVA: 0x7FFE87CC2C60
        public void DoWindow(){} // RVA: 0x7FFE87CC2D80
        public void Width(){} // RVA: 0x7FFE87CC3070
        public void Height(){} // RVA: 0x7FFE87CC3140
        public void ExpandWidth(){} // RVA: 0x7FFE87CC3210
        public void ExpandHeight(){} // RVA: 0x7FFE87CC32D0
    }

    public class GUILayoutEntry : Object
    {
        public float minWidth; // 0x10
        public float maxWidth; // 0x14
        public float minHeight; // 0x18
        public float maxHeight; // 0x1C
        public UnityEngine.Rect rect; // 0x20
        public int stretchWidth; // 0x30
        public int stretchHeight; // 0x34

        // ── Methods ──
        public void get_style(){} // RVA: 0x7FFE87CC7FD0
        public void set_style(){} // RVA: 0x7FFE87CD1130
        public void get_marginLeft(){} // RVA: 0x7FFE87CD11A0
        public void get_marginRight(){} // RVA: 0x7FFE87CD1210
        public void get_marginTop(){} // RVA: 0x7FFE87CD1280
        public void get_marginBottom(){} // RVA: 0x7FFE87CD12F0
        public void get_marginHorizontal(){} // RVA: 0x7FFE87CD1360
        public void get_marginVertical(){} // RVA: 0x7FFE87CD13B0
        public void .ctor(){} // RVA: 0x7FFE87CD1520 | overloaded x2
        public void CalcWidth(){} // RVA: 0x7FFE810FB310
        public void CalcHeight(){} // RVA: 0x7FFE810FB310
        public void SetHorizontal(){} // RVA: 0x7FFE87CD1640
        public void SetVertical(){} // RVA: 0x7FFE87CD1650
        public void ApplyStyleSettings(){} // RVA: 0x7FFE87CD1660
        public void ApplyOptions(){} // RVA: 0x7FFE87CD1830
        public void ToString(){} // RVA: 0x7FFE87CD1BC0
        public void .cctor(){} // RVA: 0x7FFE87CD21F0
    }

    public class GUILayoutGroup : GUILayoutEntry
    {
        public System.Collections.Generic.List`1<UnityEngine.GUILayoutEntry> entries; // 0x48
        public bool isVertical; // 0x50
        public bool resetCoords; // 0x51
        public float spacing; // 0x54

        // ── Methods ──
        public void get_marginLeft(){} // RVA: 0x7FFE81D30560
        public void get_marginRight(){} // RVA: 0x7FFE829DF2E0
        public void get_marginTop(){} // RVA: 0x7FFE8194AD00
        public void get_marginBottom(){} // RVA: 0x7FFE842B66B0
        public void .ctor(){} // RVA: 0x7FFE87CD2EC0
        public void ApplyOptions(){} // RVA: 0x7FFE87CD3040
        public void ApplyStyleSettings(){} // RVA: 0x7FFE87CD3150
        public void ResetCursor(){} // RVA: 0x7FFE87CD32C0
        public void GetNext(){} // RVA: 0x7FFE87CD32D0
        public void Add(){} // RVA: 0x7FFE87CD3620
        public void CalcWidth(){} // RVA: 0x7FFE87CD36C0
        public void SetHorizontal(){} // RVA: 0x7FFE87CD4010
        public void CalcHeight(){} // RVA: 0x7FFE87CD4A70
        public void SetVertical(){} // RVA: 0x7FFE87CD5330
        public void ToString(){} // RVA: 0x7FFE87CD5CE0
        public void .cctor(){} // RVA: 0x7FFE87CD60F0
    }

    public class GUILayoutOption : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE82A53990
    }

    public class GUILayoutUtility : Object
    {
        public System.Collections.Generic.Dictionary`2<int,LayoutCache> s_StoredLayouts;
        public System.Collections.Generic.Dictionary`2<int,LayoutCache> s_StoredWindows; // 0x8

        // ── Methods ──
        public void Internal_GetWindowRect(){} // RVA: 0x7FFE87CC3620
        public void Internal_MoveWindow(){} // RVA: 0x7FFE87CC36C0
        public void get_unbalancedgroupscount(){} // RVA: 0x7FFE87CC3760
        public void set_unbalancedgroupscount(){} // RVA: 0x7FFE87CC37C0
        public void SelectIDList(){} // RVA: 0x7FFE87CC3820
        public void Begin(){} // RVA: 0x7FFE87CC3B10
        public void BeginContainer(){} // RVA: 0x7FFE87CC4000
        public void BeginWindow(){} // RVA: 0x7FFE87CC4380
        public void Layout(){} // RVA: 0x7FFE87CC4960
        public void LayoutFromEditorWindow(){} // RVA: 0x7FFE87CC4CE0
        public void LayoutFromContainer(){} // RVA: 0x7FFE87CC5020
        public void LayoutFreeGroup(){} // RVA: 0x7FFE87CC5210
        public void LayoutSingleGroup(){} // RVA: 0x7FFE87CC5410
        public void CreateGUILayoutGroupInstanceOfType(){} // RVA: 0x7FFE87CC56E0
        public void BeginLayoutGroup(){} // RVA: 0x7FFE87CC5880
        public void EndLayoutGroup(){} // RVA: 0x7FFE87CC5C80
        public void BeginLayoutArea(){} // RVA: 0x7FFE87CC6060
        public void EndLayoutArea(){} // RVA: 0x7FFE87CC6420
        public void GetRect(){} // RVA: 0x7FFE87CC6DB0 | overloaded x3
        public void DoGetRect(){} // RVA: 0x7FFE87CC6E70 | overloaded x2
        public void get_spaceStyle(){} // RVA: 0x7FFE87CC70C0
        public void .cctor(){} // RVA: 0x7FFE87CC7250
        public void Internal_GetWindowRect_Injected(){} // RVA: 0x7FFE87CC7480
        public void Internal_MoveWindow_Injected(){} // RVA: 0x7FFE87CC74E0
    }

    public class GUIScrollGroup : GUILayoutGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87CD6220
        public void CalcWidth(){} // RVA: 0x7FFE87CD6280
        public void SetHorizontal(){} // RVA: 0x7FFE87CD6320
        public void CalcHeight(){} // RVA: 0x7FFE87CD6500
        public void SetVertical(){} // RVA: 0x7FFE87CD66B0
    }

    public class GUISettings : Object
    {
        public bool m_DoubleClickSelectsWord; // 0x10
        public bool m_TripleClickSelectsLine; // 0x11
        public UnityEngine.Color m_CursorColor; // 0x14
        public float m_CursorFlashSpeed; // 0x24
        public UnityEngine.Color m_SelectionColor; // 0x28

        // ── Methods ──
        public void Internal_GetCursorFlashSpeed(){} // RVA: 0x7FFE87CC7960
        public void get_doubleClickSelectsWord(){} // RVA: 0x7FFE87CC79B0
        public void get_tripleClickSelectsLine(){} // RVA: 0x7FFE87CC79C0
        public void get_cursorColor(){} // RVA: 0x7FFE83BAEEE0
        public void get_cursorFlashSpeed(){} // RVA: 0x7FFE87CC79D0
        public void get_selectionColor(){} // RVA: 0x7FFE87CC7A30
        public void .ctor(){} // RVA: 0x7FFE87CC7A40
    }

    public class GUISkin : ScriptableObject
    {
        public UnityEngine.Font m_Font; // 0x18
        public UnityEngine.GUIStyle m_box; // 0x20
        public UnityEngine.GUIStyle m_button; // 0x28
        public UnityEngine.GUIStyle m_toggle; // 0x30
        public UnityEngine.GUIStyle m_label; // 0x38
        public UnityEngine.GUIStyle m_textField; // 0x40
        public UnityEngine.GUIStyle m_textArea; // 0x48
        public UnityEngine.GUIStyle m_window; // 0x50
        public UnityEngine.GUIStyle m_horizontalSlider; // 0x58
        public UnityEngine.GUIStyle m_horizontalSliderThumb; // 0x60
        public UnityEngine.GUIStyle m_horizontalSliderThumbExtent; // 0x68
        public UnityEngine.GUIStyle m_verticalSlider; // 0x70
        public UnityEngine.GUIStyle m_verticalSliderThumb; // 0x78
        public UnityEngine.GUIStyle m_verticalSliderThumbExtent; // 0x80
        public UnityEngine.GUIStyle m_SliderMixed; // 0x88
        public UnityEngine.GUIStyle m_horizontalScrollbar; // 0x90
        public UnityEngine.GUIStyle m_horizontalScrollbarThumb; // 0x98
        public UnityEngine.GUIStyle m_horizontalScrollbarLeftButton; // 0xA0
        public UnityEngine.GUIStyle m_horizontalScrollbarRightButton; // 0xA8
        public UnityEngine.GUIStyle m_verticalScrollbar; // 0xB0
        public UnityEngine.GUIStyle m_verticalScrollbarThumb; // 0xB8
        public UnityEngine.GUIStyle m_verticalScrollbarUpButton; // 0xC0
        public UnityEngine.GUIStyle m_verticalScrollbarDownButton; // 0xC8
        public UnityEngine.GUIStyle m_ScrollView; // 0xD0
        public UnityEngine.GUIStyle[] m_CustomStyles; // 0xD8
        public UnityEngine.GUISettings m_Settings; // 0xE0
        public UnityEngine.GUIStyle ms_Error;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87CC7A70
        public void OnEnable(){} // RVA: 0x7FFE87CC7C20
        public void CleanupRoots(){} // RVA: 0x7FFE87CC7C30
        public void get_font(){} // RVA: 0x7FFE83BBC680
        public void set_font(){} // RVA: 0x7FFE87CC7D30
        public void get_box(){} // RVA: 0x7FFE87563690
        public void set_box(){} // RVA: 0x7FFE87CC7F00
        public void get_label(){} // RVA: 0x7FFE87CC7F60
        public void set_label(){} // RVA: 0x7FFE87CC7F70
        public void get_textField(){} // RVA: 0x7FFE87CC7FD0
        public void set_textField(){} // RVA: 0x7FFE87CC7FE0
        public void get_textArea(){} // RVA: 0x7FFE87CC8040
        public void set_textArea(){} // RVA: 0x7FFE87CC8050
        public void get_button(){} // RVA: 0x7FFE87C86200
        public void set_button(){} // RVA: 0x7FFE87CC80B0
        public void get_toggle(){} // RVA: 0x7FFE87C86B00
        public void set_toggle(){} // RVA: 0x7FFE87CC8110
        public void get_window(){} // RVA: 0x7FFE87CC8170
        public void set_window(){} // RVA: 0x7FFE87CC8180
        public void get_horizontalSlider(){} // RVA: 0x7FFE87CC81E0
        public void set_horizontalSlider(){} // RVA: 0x7FFE87CC81F0
        public void get_horizontalSliderThumb(){} // RVA: 0x7FFE87CC8250
        public void set_horizontalSliderThumb(){} // RVA: 0x7FFE87CC8260
        public void get_horizontalSliderThumbExtent(){} // RVA: 0x7FFE87CC82C0
        public void set_horizontalSliderThumbExtent(){} // RVA: 0x7FFE87CC82D0
        public void get_sliderMixed(){} // RVA: 0x7FFE87CC8330
        public void set_sliderMixed(){} // RVA: 0x7FFE87CC8340
        public void get_verticalSlider(){} // RVA: 0x7FFE87CC83A0
        public void set_verticalSlider(){} // RVA: 0x7FFE87CC83B0
        public void get_verticalSliderThumb(){} // RVA: 0x7FFE87CC8410
        public void set_verticalSliderThumb(){} // RVA: 0x7FFE87CC8420
        public void get_verticalSliderThumbExtent(){} // RVA: 0x7FFE87CC8480
        public void set_verticalSliderThumbExtent(){} // RVA: 0x7FFE87CC8490
        public void get_horizontalScrollbar(){} // RVA: 0x7FFE87CC84F0
        public void set_horizontalScrollbar(){} // RVA: 0x7FFE87CC8500
        public void get_horizontalScrollbarThumb(){} // RVA: 0x7FFE87CC8560
        public void set_horizontalScrollbarThumb(){} // RVA: 0x7FFE87CC8570
        public void get_horizontalScrollbarLeftButton(){} // RVA: 0x7FFE87CC85D0
        public void set_horizontalScrollbarLeftButton(){} // RVA: 0x7FFE87CC85E0
        public void get_horizontalScrollbarRightButton(){} // RVA: 0x7FFE87CC8640
        public void set_horizontalScrollbarRightButton(){} // RVA: 0x7FFE87CC8650
        public void get_verticalScrollbar(){} // RVA: 0x7FFE87CC86B0
        public void set_verticalScrollbar(){} // RVA: 0x7FFE87CC86C0
        public void get_verticalScrollbarThumb(){} // RVA: 0x7FFE87CC8720
        public void set_verticalScrollbarThumb(){} // RVA: 0x7FFE87CC8730
        public void get_verticalScrollbarUpButton(){} // RVA: 0x7FFE87CC8790
        public void set_verticalScrollbarUpButton(){} // RVA: 0x7FFE87CC87A0
        public void get_verticalScrollbarDownButton(){} // RVA: 0x7FFE87CC8800
        public void set_verticalScrollbarDownButton(){} // RVA: 0x7FFE87CC8810
        public void get_scrollView(){} // RVA: 0x7FFE87CC8870
        public void set_scrollView(){} // RVA: 0x7FFE87CC8880
        public void get_customStyles(){} // RVA: 0x7FFE87CC88E0
        public void set_customStyles(){} // RVA: 0x7FFE87CC88F0
        public void get_settings(){} // RVA: 0x7FFE87CC8950
        public void get_error(){} // RVA: 0x7FFE87CC8960
        public void Apply(){} // RVA: 0x7FFE87CC8A90
        public void BuildStyleCache(){} // RVA: 0x7FFE87CC8B10
        public void GetStyle(){} // RVA: 0x7FFE87CCA4F0
        public void FindStyle(){} // RVA: 0x7FFE87CCA7D0
        public void MakeCurrent(){} // RVA: 0x7FFE87CCA870
        public void GetEnumerator(){} // RVA: 0x7FFE87CCA9A0
    }

    public class GUIStateObjects : Object
    {
        // ── Methods ──
        public void GetStateObject(){} // RVA: 0x7FFE87CCAAE0
        public void .cctor(){} // RVA: 0x7FFE87CCAC60
    }

    public class GUIStyle : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public UnityEngine.GUIStyleState m_Normal; // 0x18
        public UnityEngine.GUIStyleState m_Hover; // 0x20
        public UnityEngine.GUIStyleState m_Active; // 0x28
        public UnityEngine.GUIStyleState m_Focused; // 0x30
        public UnityEngine.GUIStyleState m_OnNormal; // 0x38
        public UnityEngine.GUIStyleState m_OnHover; // 0x40
        public UnityEngine.GUIStyleState m_OnActive; // 0x48
        public UnityEngine.GUIStyleState m_OnFocused; // 0x50
        public UnityEngine.RectOffset m_Border; // 0x58
        public UnityEngine.RectOffset m_Padding; // 0x60
        public UnityEngine.RectOffset m_Margin; // 0x68
        public UnityEngine.RectOffset m_Overflow; // 0x70
        public string m_Name; // 0x78
        public bool showKeyboardFocus;
        public UnityEngine.GUIStyle s_None; // 0x8
        public object field_16; // 0x6580
        public object field_17; // 0x6738

        // ── Methods ──
        public void get_rawName(){} // RVA: 0x7FFE87CCB0A0
        public void set_rawName(){} // RVA: 0x7FFE87CCB0F0
        public void get_font(){} // RVA: 0x7FFE87CCB150
        public void get_imagePosition(){} // RVA: 0x7FFE87CCB1A0
        public void get_wordWrap(){} // RVA: 0x7FFE87CCB1F0
        public void get_contentOffset(){} // RVA: 0x7FFE87CCB240
        public void set_contentOffset(){} // RVA: 0x7FFE87CCB2A0
        public void get_fixedWidth(){} // RVA: 0x7FFE87CCB300
        public void get_fixedHeight(){} // RVA: 0x7FFE87CCB350
        public void get_stretchWidth(){} // RVA: 0x7FFE87CCB3A0
        public void set_stretchWidth(){} // RVA: 0x7FFE87CCB3F0
        public void get_stretchHeight(){} // RVA: 0x7FFE87CCB450
        public void set_stretchHeight(){} // RVA: 0x7FFE87CCB4A0
        public void set_Internal_clipOffset(){} // RVA: 0x7FFE87CCB500
        public void Internal_Create(){} // RVA: 0x7FFE87CCB560
        public void Internal_Copy(){} // RVA: 0x7FFE87CCB5B0
        public void Internal_Destroy(){} // RVA: 0x7FFE87CCB610
        public void GetStyleStatePtr(){} // RVA: 0x7FFE87CCB660
        public void GetRectOffsetPtr(){} // RVA: 0x7FFE87CCB6C0
        public void Internal_GetLineHeight(){} // RVA: 0x7FFE87CCB720
        public void Internal_Draw(){} // RVA: 0x7FFE87CCB770
        public void Internal_Draw2(){} // RVA: 0x7FFE87CCB820
        public void Internal_DrawCursor(){} // RVA: 0x7FFE87CCB8B0
        public void Internal_DrawWithTextSelection(){} // RVA: 0x7FFE87CCB940
        public void Internal_GetCursorPixelPosition(){} // RVA: 0x7FFE87CCBA30
        public void Internal_GetCursorStringIndex(){} // RVA: 0x7FFE87CCBAD0
        public void Internal_GetSelectedRenderedText(){} // RVA: 0x7FFE87CCBB50
        public void Internal_CalcSize(){} // RVA: 0x7FFE87CCBBE0
        public void Internal_CalcSizeWithConstraints(){} // RVA: 0x7FFE87CCBC50
        public void Internal_CalcHeight(){} // RVA: 0x7FFE87CCBCD0
        public void Internal_CalcMinMaxWidth(){} // RVA: 0x7FFE87CCBD40
        public void SetMouseTooltip(){} // RVA: 0x7FFE87CCBDB0
        public void IsTooltipActive(){} // RVA: 0x7FFE87CCBE50
        public void Internal_GetCursorFlashOffset(){} // RVA: 0x7FFE87CCBEA0
        public void SetDefaultFont(){} // RVA: 0x7FFE87CCBEF0
        public void .ctor(){} // RVA: 0x7FFE87CCBFD0 | overloaded x2
        public void Finalize(){} // RVA: 0x7FFE87CCC0C0
        public void get_name(){} // RVA: 0x7FFE87CCC190
        public void set_name(){} // RVA: 0x7FFE87CCC250
        public void get_normal(){} // RVA: 0x7FFE87CCC300
        public void get_border(){} // RVA: 0x7FFE87CCC460
        public void get_margin(){} // RVA: 0x7FFE87CCC5C0
        public void get_padding(){} // RVA: 0x7FFE87CCC720
        public void get_lineHeight(){} // RVA: 0x7FFE87CCC880
        public void Draw(){} // RVA: 0x7FFE87CCCCE0 | overloaded x6
        public void DrawCursor(){} // RVA: 0x7FFE87CCCE00
        public void DrawWithTextSelection(){} // RVA: 0x7FFE87CCD770 | overloaded x3
        public void get_none(){} // RVA: 0x7FFE87CCD7B0
        public void GetCursorPixelPosition(){} // RVA: 0x7FFE87CCD8B0
        public void GetCursorStringIndex(){} // RVA: 0x7FFE87CCD950
        public void CalcSize(){} // RVA: 0x7FFE87CCBBE0
        public void CalcSizeWithConstraints(){} // RVA: 0x7FFE87CCBC50
        public void CalcHeight(){} // RVA: 0x7FFE87CCBCD0
        public void get_isHeightDependantOnWidth(){} // RVA: 0x7FFE87CCD9D0
        public void CalcMinMaxWidth(){} // RVA: 0x7FFE87CCDAD0
        public void ToString(){} // RVA: 0x7FFE87CCDB70
        public void .cctor(){} // RVA: 0x7FFE87CCDC30
        public void get_contentOffset_Injected(){} // RVA: 0x7FFE87CCDC70
        public void set_contentOffset_Injected(){} // RVA: 0x7FFE87CCDCD0
        public void set_Internal_clipOffset_Injected(){} // RVA: 0x7FFE87CCDD30
        public void Internal_Draw_Injected(){} // RVA: 0x7FFE87CCDD90
        public void Internal_Draw2_Injected(){} // RVA: 0x7FFE87CCDE40
        public void Internal_DrawCursor_Injected(){} // RVA: 0x7FFE87CCDED0
        public void Internal_DrawWithTextSelection_Injected(){} // RVA: 0x7FFE87CCDF60
        public void Internal_GetCursorPixelPosition_Injected(){} // RVA: 0x7FFE87CCE030
        public void Internal_GetCursorStringIndex_Injected(){} // RVA: 0x7FFE87CCE0C0
        public void Internal_GetSelectedRenderedText_Injected(){} // RVA: 0x7FFE87CCE140
        public void Internal_CalcSize_Injected(){} // RVA: 0x7FFE87CCE1D0
        public void Internal_CalcSizeWithConstraints_Injected(){} // RVA: 0x7FFE87CCE240
        public void Internal_CalcMinMaxWidth_Injected(){} // RVA: 0x7FFE87CCE2C0
        public void SetMouseTooltip_Injected(){} // RVA: 0x7FFE87CCE330
    }

    public class GUIStyleState : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public UnityEngine.GUIStyle m_SourceStyle; // 0x18

        // ── Methods ──
        public void set_background(){} // RVA: 0x7FFE87CCAD40
        public void set_textColor(){} // RVA: 0x7FFE87CCADA0
        public void Init(){} // RVA: 0x7FFE87CCAE00
        public void Cleanup(){} // RVA: 0x7FFE87CCAE50
        public void .ctor(){} // RVA: 0x7FFE87C0FFA0 | overloaded x2
        public void GetGUIStyleState(){} // RVA: 0x7FFE87CCAEF0
        public void Finalize(){} // RVA: 0x7FFE87CCAFB0
        public void set_textColor_Injected(){} // RVA: 0x7FFE87CCB040
    }

    public class GUITargetAttribute : Attribute
    {
        // ── Methods ──
        public void GetGUITargetAttrValue(){} // RVA: 0x7FFE87CCE390
    }

    public class GUIText : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class GUITexture : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class GUIUtility : Object
    {
        public int s_ControlCount;
        public int s_SkinMode; // 0x4
        public int s_OriginalID; // 0x8
        public System.Action takeCapture; // 0x10
        public System.Action releaseCapture; // 0x18
        public System.Func`3<int,UIntPtr,bool> processEvent; // 0x20
        public System.Action cleanupRoots; // 0x28
        public System.Func`2<System.Exception,bool> endContainerGUIFromException; // 0x30
        public System.Action guiChanged; // 0x38
        public System.Action`2<0x6667931C,0x66576A14> beforeEventProcessed; // 0x40
        public UnityEngine.Event m_Event; // 0x48

        // ── Methods ──
        public void get_pixelsPerPoint(){} // RVA: 0x7FFE87CCE5F0
        public void get_guiDepth(){} // RVA: 0x7FFE87CCE640
        public void set_mouseUsed(){} // RVA: 0x7FFE87CCE690
        public void get_textFieldInput(){} // RVA: 0x7FFE87CCE6E0
        public void set_textFieldInput(){} // RVA: 0x7FFE87CCE730
        public void get_systemCopyBuffer(){} // RVA: 0x7FFE87CCE780
        public void set_systemCopyBuffer(){} // RVA: 0x7FFE87CCE7D0
        public void Internal_GetControlID(){} // RVA: 0x7FFE87CCE820
        public void GetControlID(){} // RVA: 0x7FFE87CCF0D0 | overloaded x3
        public void BeginContainerFromOwner(){} // RVA: 0x7FFE87CCE9C0
        public void BeginContainer(){} // RVA: 0x7FFE87CCEA10
        public void Internal_EndContainer(){} // RVA: 0x7FFE87CCEA60
        public void CheckForTabEvent(){} // RVA: 0x7FFE87CCEAB0
        public void SetKeyboardControlToFirstControlId(){} // RVA: 0x7FFE87CCEB00
        public void SetKeyboardControlToLastControlId(){} // RVA: 0x7FFE87CCEB50
        public void HasFocusableControls(){} // RVA: 0x7FFE87CCEBA0
        public void OwnsId(){} // RVA: 0x7FFE87CCEBF0
        public void AlignRectToDevice(){} // RVA: 0x7FFE87CD0880 | overloaded x2
        public void get_compositionString(){} // RVA: 0x7FFE87CCED00
        public void set_imeCompositionMode(){} // RVA: 0x7FFE87CCED50
        public void set_compositionCursorPos(){} // RVA: 0x7FFE87CCEDA0
        public void Internal_GetHotControl(){} // RVA: 0x7FFE87CCEE30
        public void Internal_GetKeyboardControl(){} // RVA: 0x7FFE87CCEE80
        public void Internal_SetHotControl(){} // RVA: 0x7FFE87CCEED0
        public void Internal_SetKeyboardControl(){} // RVA: 0x7FFE87CCEF20
        public void Internal_GetDefaultSkin(){} // RVA: 0x7FFE87CCEF70
        public void Internal_ExitGUI(){} // RVA: 0x7FFE87CCEFC0
        public void MarkGUIChanged(){} // RVA: 0x7FFE87CCF010
        public void GetStateObject(){} // RVA: 0x7FFE87CCF150
        public void set_guiIsExiting(){} // RVA: 0x7FFE87CCF310
        public void get_hotControl(){} // RVA: 0x7FFE87CCF370
        public void set_hotControl(){} // RVA: 0x7FFE87CCF3F0
        public void TakeCapture(){} // RVA: 0x7FFE87CCF480
        public void RemoveCapture(){} // RVA: 0x7FFE87CCF4F0
        public void get_keyboardControl(){} // RVA: 0x7FFE87CCF560
        public void set_keyboardControl(){} // RVA: 0x7FFE87CCF5E0
        public void HasKeyFocus(){} // RVA: 0x7FFE87CCF670
        public void ExitGUI(){} // RVA: 0x7FFE87CCF750
        public void GetDefaultSkin(){} // RVA: 0x7FFE87CCF790
        public void ProcessEvent(){} // RVA: 0x7FFE87CCF860
        public void EndContainer(){} // RVA: 0x7FFE87CCFAB0
        public void BeginGUI(){} // RVA: 0x7FFE87CCFB70
        public void EndGUI(){} // RVA: 0x7FFE87CCFC30
        public void EndGUIFromException(){} // RVA: 0x7FFE87CCFE50
        public void EndContainerGUIFromException(){} // RVA: 0x7FFE87CCFEE0
        public void ResetGlobalState(){} // RVA: 0x7FFE87CCFF80
        public void IsExitGUIException(){} // RVA: 0x7FFE87CD00E0
        public void ShouldRethrowException(){} // RVA: 0x7FFE87CD0170
        public void CheckOnGUI(){} // RVA: 0x7FFE87CD0230
        public void RoundToPixelGrid(){} // RVA: 0x7FFE87CD0310
        public void ScaleAroundPivot(){} // RVA: 0x7FFE87CD0400
        public void HitTest(){} // RVA: 0x7FFE87CD0AD0 | overloaded x3
        public void .cctor(){} // RVA: 0x7FFE87CD0BB0
        public void Internal_GetControlID_Injected(){} // RVA: 0x7FFE87CD0CC0
        public void AlignRectToDevice_Injected(){} // RVA: 0x7FFE87CD0D30
        public void set_compositionCursorPos_Injected(){} // RVA: 0x7FFE87CD0DB0
    }

    public class GUIWordWrapSizer : GUILayoutEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87CD2C10
        public void CalcWidth(){} // RVA: 0x7FFE87CD2D40
        public void CalcHeight(){} // RVA: 0x7FFE87CD2E40
    }

    public class GameObject : Object
    {
        // ── Methods ──
        public void CreatePrimitive(){} // RVA: 0x7FFE87C68790
        public void GetComponent(){} // RVA: 0x7FFE87C688B0 | overloaded x3
        public void GetComponentFastPath(){} // RVA: 0x7FFE87C68840
        public void GetComponentByName(){} // RVA: 0x7FFE87C688B0
        public void GetComponentInChildren(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void GetComponentInParent(){} // RVA: 0x7FFE810A1420 | overloaded x4
        public void GetComponentsInternal(){} // RVA: 0x7FFE87C68AD0
        public void GetComponents(){} // RVA: 0x7FFE80E460A0 | overloaded x4
        public void GetComponentsInChildren(){} // RVA: 0x7FFE80E460A0 | overloaded x6
        public void GetComponentsInParent(){} // RVA: 0x7FFE80E2E2E0 | overloaded x5
        public void TryGetComponent(){} // RVA: 0x7FFE87C68EA0 | overloaded x2
        public void TryGetComponentInternal(){} // RVA: 0x7FFE87C69020
        public void TryGetComponentFastPath(){} // RVA: 0x7FFE87C69080
        public void FindWithTag(){} // RVA: 0x7FFE87C690F0
        public void SendMessageUpwards(){} // RVA: 0x7FFE87C69A90 | overloaded x4
        public void SendMessage(){} // RVA: 0x7FFE87C69B50 | overloaded x4
        public void BroadcastMessage(){} // RVA: 0x7FFE87C69C10 | overloaded x4
        public void AddComponentInternal(){} // RVA: 0x7FFE87C691A0
        public void Internal_AddComponentWithType(){} // RVA: 0x7FFE87C69200
        public void AddComponent(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetComponentCount(){} // RVA: 0x7FFE87C69260
        public void QueryComponentAtIndex(){} // RVA: 0x7FFE87C692B0
        public void GetComponentAtIndex(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void GetComponentIndex(){} // RVA: 0x7FFE87C69420
        public void get_transform(){} // RVA: 0x7FFE87C69480
        public void get_layer(){} // RVA: 0x7FFE87C694D0
        public void set_layer(){} // RVA: 0x7FFE87C69520
        public void get_active(){} // RVA: 0x7FFE87C69580
        public void set_active(){} // RVA: 0x7FFE87C695D0
        public void SetActive(){} // RVA: 0x7FFE87C69630
        public void get_activeSelf(){} // RVA: 0x7FFE87C69690
        public void get_activeInHierarchy(){} // RVA: 0x7FFE87C696E0
        public void SetActiveRecursively(){} // RVA: 0x7FFE87C69730
        public void get_isStatic(){} // RVA: 0x7FFE87C69790
        public void set_isStatic(){} // RVA: 0x7FFE87C697E0
        public void get_isStaticBatchable(){} // RVA: 0x7FFE87C69840
        public void get_tag(){} // RVA: 0x7FFE87C69890
        public void set_tag(){} // RVA: 0x7FFE87C698E0
        public void CompareTag(){} // RVA: 0x7FFE87C69940
        public void FindGameObjectWithTag(){} // RVA: 0x7FFE87C690F0
        public void FindGameObjectsWithTag(){} // RVA: 0x7FFE87C699A0
        public void .ctor(){} // RVA: 0x7FFE87C69D60 | overloaded x3
        public void Internal_CreateGameObject(){} // RVA: 0x7FFE87C69E90
        public void Find(){} // RVA: 0x7FFE87C69EF0
        public void SetGameObjectsActive(){} // RVA: 0x7FFE87C6A080 | overloaded x3
        public void InstantiateGameObjects(){} // RVA: 0x7FFE87C6A180 | overloaded x2
        public void GetScene(){} // RVA: 0x7FFE87C6A390
        public void get_scene(){} // RVA: 0x7FFE87C6A3F0
        public void get_sceneCullingMask(){} // RVA: 0x7FFE87C6A450
        public void get_gameObject(){} // RVA: 0x7FFE86A47010
        public void InstantiateGameObjects_Injected(){} // RVA: 0x7FFE87C6A4A0
        public void GetScene_Injected(){} // RVA: 0x7FFE87C6A520
        public void get_scene_Injected(){} // RVA: 0x7FFE87C6A580
    }

    public class GeometryUtility : Object
    {
        // ── Methods ──
        public void CalculateFrustumPlanes(){} // RVA: 0x7FFE87C0D7E0 | overloaded x4
        public void CalculateBounds(){} // RVA: 0x7FFE87C0D920
        public void TryCreatePlaneFromPolygon(){} // RVA: 0x7FFE87C0DAA0
        public void TestPlanesAABB(){} // RVA: 0x7FFE87C0DF50
        public void Internal_ExtractPlanes(){} // RVA: 0x7FFE87C0DFB0
        public void Internal_CalculateBounds(){} // RVA: 0x7FFE87C0E010
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void TestPlanesAABB_Injected(){} // RVA: 0x7FFE87C0E090
        public void Internal_ExtractPlanes_Injected(){} // RVA: 0x7FFE87C0E0F0
        public void Internal_CalculateBounds_Injected(){} // RVA: 0x7FFE87C0E150
    }

    public class Gizmos : Object
    {
        // ── Methods ──
        public void DrawLine(){} // RVA: 0x7FFE87C10D10
        public void DrawWireSphere(){} // RVA: 0x7FFE87C10D70
        public void DrawSphere(){} // RVA: 0x7FFE87C10DD0
        public void DrawWireCube(){} // RVA: 0x7FFE87C10E30
        public void DrawCube(){} // RVA: 0x7FFE87C10E90
        public void DrawMesh(){} // RVA: 0x7FFE87C116D0 | overloaded x3
        public void DrawWireMesh(){} // RVA: 0x7FFE87C11D70 | overloaded x8
        public void DrawIcon(){} // RVA: 0x7FFE87C11EC0 | overloaded x3
        public void DrawGUITexture(){} // RVA: 0x7FFE87C12040 | overloaded x4
        public void get_color(){} // RVA: 0x7FFE87C111C0
        public void set_color(){} // RVA: 0x7FFE87C11220
        public void get_matrix(){} // RVA: 0x7FFE87C11270
        public void set_matrix(){} // RVA: 0x7FFE87C112E0
        public void get_probeSize(){} // RVA: 0x7FFE87C11330
        public void DrawFrustum(){} // RVA: 0x7FFE87C11380
        public void DrawRay(){} // RVA: 0x7FFE87C114D0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void DrawLine_Injected(){} // RVA: 0x7FFE87C120E0
        public void DrawWireSphere_Injected(){} // RVA: 0x7FFE87C12140
        public void DrawSphere_Injected(){} // RVA: 0x7FFE87C121A0
        public void DrawWireCube_Injected(){} // RVA: 0x7FFE87C12200
        public void DrawCube_Injected(){} // RVA: 0x7FFE87C12260
        public void DrawMesh_Injected(){} // RVA: 0x7FFE87C122C0
        public void DrawWireMesh_Injected(){} // RVA: 0x7FFE87C12340
        public void DrawIcon_Injected(){} // RVA: 0x7FFE87C123C0
        public void DrawGUITexture_Injected(){} // RVA: 0x7FFE87C12440
        public void get_color_Injected(){} // RVA: 0x7FFE87C124D0
        public void set_color_Injected(){} // RVA: 0x7FFE87C12520
        public void get_matrix_Injected(){} // RVA: 0x7FFE87C12570
        public void set_matrix_Injected(){} // RVA: 0x7FFE87C125C0
        public void DrawFrustum_Injected(){} // RVA: 0x7FFE87C12610
    }

    public class GlobalJavaObjectRef : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87BBD660
        public void Finalize(){} // RVA: 0x7FFE87BBD6E0
        public void op_Implicit(){} // RVA: 0x7FFE81D7E800
        public void Dispose(){} // RVA: 0x7FFE87BBD720
    }

    public class Gradient : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public object field_1; // 0xBC88
        public object field_2; // 0xBE40
        public object field_3; // 0xBFF8

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE87C527A0
        public void Cleanup(){} // RVA: 0x7FFE87C527F0
        public void Internal_Equals(){} // RVA: 0x7FFE87C52840
        public void .ctor(){} // RVA: 0x7FFE87C528A0
        public void Finalize(){} // RVA: 0x7FFE87C528F0
        public void Evaluate(){} // RVA: 0x7FFE87C52970
        public void get_colorKeys(){} // RVA: 0x7FFE87C529F0
        public void set_colorKeys(){} // RVA: 0x7FFE87C52A40
        public void get_alphaKeys(){} // RVA: 0x7FFE87C52AA0
        public void set_alphaKeys(){} // RVA: 0x7FFE87C52AF0
        public void get_mode(){} // RVA: 0x7FFE87C52B50
        public void set_mode(){} // RVA: 0x7FFE87C52BA0
        public void get_colorSpace(){} // RVA: 0x7FFE87C52C00
        public void set_colorSpace(){} // RVA: 0x7FFE87C52C50
        public void SetKeys(){} // RVA: 0x7FFE87C52CB0
        public void Equals(){} // RVA: 0x7FFE87C52E30 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87BFA280
        public void Evaluate_Injected(){} // RVA: 0x7FFE87C52F70
    }

    public class GradientAlphaKey : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8111ED10
    }

    public class GradientColorKey : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87C52790
    }

    public class Graphics : Object
    {
        // ── Methods ──
        public void Internal_GetMaxDrawMeshInstanceCount(){} // RVA: 0x7FFE87C14F80
        public void Internal_SetNullRT(){} // RVA: 0x7FFE87C14FD0
        public void Internal_SetRTSimple(){} // RVA: 0x7FFE87C15020
        public void Internal_SetRandomWriteTargetBuffer(){} // RVA: 0x7FFE87C150E0
        public void ClearRandomWriteTargets(){} // RVA: 0x7FFE87C15150
        public void CopyTexture_Full(){} // RVA: 0x7FFE87C151A0
        public void CopyTexture_Slice(){} // RVA: 0x7FFE87C15200
        public void CopyTexture_Region(){} // RVA: 0x7FFE87C15280
        public void ConvertTexture_Full(){} // RVA: 0x7FFE87C15310
        public void Internal_DrawMeshNow2(){} // RVA: 0x7FFE87C15370
        public void Internal_DrawTexture(){} // RVA: 0x7FFE87C15420
        public void Internal_RenderMeshPrimitives(){} // RVA: 0x7FFE87C15470
        public void Internal_DrawMesh(){} // RVA: 0x7FFE87C15530
        public void Internal_DrawMeshInstanced(){} // RVA: 0x7FFE87C15650
        public void Internal_DrawProcedural(){} // RVA: 0x7FFE87C156F0
        public void Internal_DrawProceduralIndirect(){} // RVA: 0x7FFE87C157F0
        public void Internal_BlitMaterial5(){} // RVA: 0x7FFE87C158F0
        public void Internal_BlitMaterial6(){} // RVA: 0x7FFE87C15980
        public void Blit2(){} // RVA: 0x7FFE87C15A10
        public void Blit3(){} // RVA: 0x7FFE87C15A70
        public void Blit4(){} // RVA: 0x7FFE87C15AF0
        public void Blit5(){} // RVA: 0x7FFE87C15BA0
        public void ExecuteCommandBuffer(){} // RVA: 0x7FFE87C15C60
        public void ExecuteCommandBufferAsync(){} // RVA: 0x7FFE87C15CB0
        public void SetRenderTargetImpl(){} // RVA: 0x7FFE87C15E20 | overloaded x2
        public void SetRenderTarget(){} // RVA: 0x7FFE87C18C90 | overloaded x3
        public void SetRandomWriteTarget(){} // RVA: 0x7FFE87C18D10 | overloaded x2
        public void CopyTexture(){} // RVA: 0x7FFE87C164E0 | overloaded x3
        public void ConvertTexture(){} // RVA: 0x7FFE87C165A0
        public void DrawTextureImpl(){} // RVA: 0x7FFE87C16640
        public void DrawTexture(){} // RVA: 0x7FFE87C18AD0 | overloaded x7
        public void RenderMeshPrimitives(){} // RVA: 0x7FFE87C16C90
        public void DrawMeshNow(){} // RVA: 0x7FFE87C17090 | overloaded x2
        public void DrawMesh(){} // RVA: 0x7FFE87C187D0 | overloaded x4
        public void DrawMeshInstanced(){} // RVA: 0x7FFE87C176F0
        public void DrawProcedural(){} // RVA: 0x7FFE87C17DC0
        public void DrawProceduralIndirect(){} // RVA: 0x7FFE87C17F10
        public void Blit(){} // RVA: 0x7FFE87C18720 | overloaded x9
        public void .cctor(){} // RVA: 0x7FFE87C18D70
        public void Internal_SetRTSimple_Injected(){} // RVA: 0x7FFE87C18F20
        public void Internal_DrawMeshNow2_Injected(){} // RVA: 0x7FFE87C18FB0
        public void Internal_RenderMeshPrimitives_Injected(){} // RVA: 0x7FFE87C19020
        public void Internal_DrawMesh_Injected(){} // RVA: 0x7FFE87C190A0
        public void Internal_DrawProcedural_Injected(){} // RVA: 0x7FFE87C19140
        public void Internal_DrawProceduralIndirect_Injected(){} // RVA: 0x7FFE87C191D0
        public void Blit4_Injected(){} // RVA: 0x7FFE87C19260
        public void Blit5_Injected(){} // RVA: 0x7FFE87C192E0
    }

    public class GraphicsBuffer : Object
    {
        public UIntPtr m_Ptr; // 0x10
        public object field_1; // 0xE660
        public object field_2; // 0xE660

        // ── Methods ──
        public void Finalize(){} // RVA: 0x7FFE87C30180
        public void Dispose(){} // RVA: 0x7FFE87C302F0 | overloaded x2
        public void RequiresCompute(){} // RVA: 0x7FFE87C303D0
        public void IsVertexIndexOrCopyOnly(){} // RVA: 0x7FFE87C303E0
        public void InitBuffer(){} // RVA: 0x7FFE87C303F0
        public void DestroyBuffer(){} // RVA: 0x7FFE87C30470
        public void .ctor(){} // RVA: 0x7FFE87C304F0 | overloaded x2
        public void InternalInitialization(){} // RVA: 0x7FFE87C30500
        public void Release(){} // RVA: 0x7FFE87C30960
        public void IsValidBuffer(){} // RVA: 0x7FFE87C30970
        public void IsValid(){} // RVA: 0x7FFE87C309C0
        public void get_count(){} // RVA: 0x7FFE87C30A30
        public void get_stride(){} // RVA: 0x7FFE87C30A80
        public void GetUsageFlags(){} // RVA: 0x7FFE87C30AD0
        public void get_usageFlags(){} // RVA: 0x7FFE87C30AD0
        public void SetData(){} // RVA: 0x7FFE87C30B20
        public void InternalSetData(){} // RVA: 0x7FFE87C30D00
        public void BeginBufferWrite(){} // RVA: 0x7FFE87C30D90
        public void LockBufferForWrite(){} // RVA: 0x7FFE810A1420
        public void EndBufferWrite(){} // RVA: 0x7FFE87C30E00
        public void UnlockBufferAfterWrite(){} // RVA: 0x7FFE80E46530
    }

    public class Grid : GridLayout
    {
        // ── Methods ──
        public void GetCellCenterLocal(){} // RVA: 0x7FFE87CAC1D0
        public void GetCellCenterWorld(){} // RVA: 0x7FFE87CAC340
        public void get_cellSize(){} // RVA: 0x7FFE87CAC510
        public void set_cellSize(){} // RVA: 0x7FFE87CAC580
        public void get_cellGap(){} // RVA: 0x7FFE87CAC5E0
        public void set_cellGap(){} // RVA: 0x7FFE87CAC650
        public void get_cellLayout(){} // RVA: 0x7FFE87CAC6B0
        public void set_cellLayout(){} // RVA: 0x7FFE87CAC700
        public void get_cellSwizzle(){} // RVA: 0x7FFE87CAC760
        public void set_cellSwizzle(){} // RVA: 0x7FFE87CAC7B0
        public void Swizzle(){} // RVA: 0x7FFE87CAC810
        public void InverseSwizzle(){} // RVA: 0x7FFE87CAC890
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_cellSize_Injected(){} // RVA: 0x7FFE87CAC910
        public void set_cellSize_Injected(){} // RVA: 0x7FFE87CAC970
        public void get_cellGap_Injected(){} // RVA: 0x7FFE87CAC9D0
        public void set_cellGap_Injected(){} // RVA: 0x7FFE87CACA30
        public void Swizzle_Injected(){} // RVA: 0x7FFE87CACA90
        public void InverseSwizzle_Injected(){} // RVA: 0x7FFE87CACB00
    }

    public class GridLayout : Behaviour
    {
        // ── Methods ──
        public void get_cellSize(){} // RVA: 0x7FFE87CACB70
        public void get_cellGap(){} // RVA: 0x7FFE87CACBE0
        public void get_cellLayout(){} // RVA: 0x7FFE87CACC50
        public void get_cellSwizzle(){} // RVA: 0x7FFE87CACCA0
        public void GetBoundsLocal(){} // RVA: 0x7FFE87CACD70 | overloaded x2
        public void GetBoundsLocalOriginSize(){} // RVA: 0x7FFE87CACE40
        public void CellToLocal(){} // RVA: 0x7FFE87CACED0
        public void LocalToCell(){} // RVA: 0x7FFE87CACF50
        public void CellToLocalInterpolated(){} // RVA: 0x7FFE87CACFD0
        public void LocalToCellInterpolated(){} // RVA: 0x7FFE87CAD050
        public void CellToWorld(){} // RVA: 0x7FFE87CAD0D0
        public void WorldToCell(){} // RVA: 0x7FFE87CAD150
        public void LocalToWorld(){} // RVA: 0x7FFE87CAD1D0
        public void WorldToLocal(){} // RVA: 0x7FFE87CAD250
        public void GetLayoutCellCenter(){} // RVA: 0x7FFE87CAD2D0
        public void DoNothing(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_cellSize_Injected(){} // RVA: 0x7FFE87CAD340
        public void get_cellGap_Injected(){} // RVA: 0x7FFE87CAD3A0
        public void GetBoundsLocal_Injected(){} // RVA: 0x7FFE87CAD400
        public void GetBoundsLocalOriginSize_Injected(){} // RVA: 0x7FFE87CAD470
        public void CellToLocal_Injected(){} // RVA: 0x7FFE87CAD4F0
        public void LocalToCell_Injected(){} // RVA: 0x7FFE87CAD560
        public void CellToLocalInterpolated_Injected(){} // RVA: 0x7FFE87CAD5D0
        public void LocalToCellInterpolated_Injected(){} // RVA: 0x7FFE87CAD640
        public void CellToWorld_Injected(){} // RVA: 0x7FFE87CAD6B0
        public void WorldToCell_Injected(){} // RVA: 0x7FFE87CAD720
        public void LocalToWorld_Injected(){} // RVA: 0x7FFE87CAD790
        public void WorldToLocal_Injected(){} // RVA: 0x7FFE87CAD800
        public void GetLayoutCellCenter_Injected(){} // RVA: 0x7FFE87CAD870
    }

}