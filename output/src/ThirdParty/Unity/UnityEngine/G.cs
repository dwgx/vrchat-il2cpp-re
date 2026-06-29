// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 49
// Methods: 909

namespace ThirdParty.Unity.UnityEngine
{
    public class GL : Object
    {
        // ── Methods ──
        public void Vertex3(){} // RVA: 0x7AEEB7490
        public void TexCoord3(){} // RVA: 0x7AEEB7510
        public void TexCoord(){} // RVA: 0x7AEEB7590
        public void TexCoord2(){} // RVA: 0x7AEEB75B0
        public void ImmediateColor(){} // RVA: 0x7AEEB75C0
        public void Color(){} // RVA: 0x7AEEB7650
        public void get_sRGBWrite(){} // RVA: 0x7AEEB76B0
        public void set_sRGBWrite(){} // RVA: 0x7AEEB7700
        public void get_invertCulling(){} // RVA: 0x7AEEB7750
        public void set_invertCulling(){} // RVA: 0x7AEEB77A0
        public void Flush(){} // RVA: 0x7AEEB77F0
        public void SetViewMatrix(){} // RVA: 0x7AEEB7840
        public void set_modelview(){} // RVA: 0x7AEEB7890
        public void PushMatrix(){} // RVA: 0x7AEEB7900
        public void PopMatrix(){} // RVA: 0x7AEEB7950
        public void LoadOrtho(){} // RVA: 0x7AEEB79A0
        public void LoadProjectionMatrix(){} // RVA: 0x7AEEB79F0
        public void InvalidateState(){} // RVA: 0x7AEEB7A40
        public void GetGPUProjectionMatrix(){} // RVA: 0x7AEEB7A90
        public void GLLoadPixelMatrixScript(){} // RVA: 0x7AEEB7B20
        public void LoadPixelMatrix(){} // RVA: 0x7AEEB7B20
        public void GLIssuePluginEvent(){} // RVA: 0x7AEEB7BB0
        public void IssuePluginEvent(){} // RVA: 0x7AEEB7C10
        public void Begin(){} // RVA: 0x7AEEB7CD0
        public void End(){} // RVA: 0x7AEEB7D20
        public void GLClear(){} // RVA: 0x7AEEB7D70
        public void Clear(){} // RVA: 0x7AEEB7E70
        public void Viewport(){} // RVA: 0x7AEEB7EF0
        public void SetViewMatrix_Injected(){} // RVA: 0x7AEEB7F40
        public void LoadProjectionMatrix_Injected(){} // RVA: 0x7AEEB7F90
        public void GetGPUProjectionMatrix_Injected(){} // RVA: 0x7AEEB7FE0
        public void GLClear_Injected(){} // RVA: 0x7AEEB8050
        public void Viewport_Injected(){} // RVA: 0x7AEEB80D0
    }

    public class GUI : Object
    {
        // ── Methods ──
        public void get_color(){} // RVA: 0x7AEF50A20
        public void set_color(){} // RVA: 0x7AEF50AB0
        public void get_backgroundColor(){} // RVA: 0x7AEF50B40
        public void set_backgroundColor(){} // RVA: 0x7AEF50BD0
        public void get_contentColor(){} // RVA: 0x7AEF50C60
        public void set_contentColor(){} // RVA: 0x7AEF50CF0
        public void get_changed(){} // RVA: 0x7AEF50D80
        public void set_changed(){} // RVA: 0x7AEF50DD0
        public void get_enabled(){} // RVA: 0x7AEF50E20
        public void set_enabled(){} // RVA: 0x7AEF50E70
        public void set_depth(){} // RVA: 0x7AEF50EC0
        public void get_usePageScrollbars(){} // RVA: 0x7AEF50F10
        public void get_blendMaterial(){} // RVA: 0x7AEF50F60
        public void get_blitMaterial(){} // RVA: 0x7AEF50FB0
        public void get_roundedRectMaterial(){} // RVA: 0x7AEF51000
        public void get_roundedRectWithColorPerBorderMaterial(){} // RVA: 0x7AEF51050
        public void GrabMouseControl(){} // RVA: 0x7AEF510A0
        public void HasMouseControl(){} // RVA: 0x7AEF510F0
        public void ReleaseMouseControl(){} // RVA: 0x7AEF51140
        public void SetNextControlName(){} // RVA: 0x7AEF51190
        public void InternalRepaintEditorWindow(){} // RVA: 0x7AEF511E0
        public void Internal_DoWindow(){} // RVA: 0x7AEF51230
        public void .cctor(){} // RVA: 0x7AEF51330
        public void get_scrollTroughSide(){} // RVA: 0x7AEF51670
        public void set_scrollTroughSide(){} // RVA: 0x7AEF516D0
        public void get_nextScrollStepTime(){} // RVA: 0x7AEF51730
        public void set_nextScrollStepTime(){} // RVA: 0x7AEF51790
        public void set_skin(){} // RVA: 0x7AEF517F0
        public void get_skin(){} // RVA: 0x7AEF51870
        public void DoSetSkin(){} // RVA: 0x7AEF51900
        public void get_matrix(){} // RVA: 0x7AEF51C80
        public void set_matrix(){} // RVA: 0x7AEF51D20
        public void Label(){} // RVA: 0x7AEF520F0
        public void DrawTexture(){} // RVA: 0x7AEF52E50
        public void CalculateScaledTextureRects(){} // RVA: 0x7AEF53730
        public void DrawTextureWithTexCoords(){} // RVA: 0x7AEF53970
        public void Box(){} // RVA: 0x7AEF540E0
        public void Button(){} // RVA: 0x7AEF544A0
        public void DoRepeatButton(){} // RVA: 0x7AEF546D0
        public void PasswordFieldGetStrToShow(){} // RVA: 0x7AEF54A30
        public void DoTextField(){} // RVA: 0x7AEF54D60
        public void HandleTextFieldEventForTouchscreen(){} // RVA: 0x7AEF553D0
        public void HandleTextFieldEventForDesktop(){} // RVA: 0x7AEF55A70
        public void HandleTextFieldEventForDesktopWithForcedKeyboard(){} // RVA: 0x7AEF563C0
        public void Toggle(){} // RVA: 0x7AEF56880
        public void SelectionGrid(){} // RVA: 0x7AEF56AE0
        public void CalcTotalHorizSpacing(){} // RVA: 0x7AEF56BE0
        public void DoControl(){} // RVA: 0x7AEF56F70
        public void DoLabel(){} // RVA: 0x7AEF573C0
        public void DoToggle(){} // RVA: 0x7AEF577B0
        public void DoButton(){} // RVA: 0x7AEF57920
        public void DoButtonGrid(){} // RVA: 0x7AEF57A90
        public void CalcGridRects(){} // RVA: 0x7AEF58780
        public void HorizontalSlider(){} // RVA: 0x7AEF58B40
        public void Slider(){} // RVA: 0x7AEF58C10
        public void HorizontalScrollbar(){} // RVA: 0x7AEF58F10
        public void ScrollerRepeatButton(){} // RVA: 0x7AEF59110
        public void VerticalScrollbar(){} // RVA: 0x7AEF59450
        public void Scroller(){} // RVA: 0x7AEF59650
        public void BeginGroup(){} // RVA: 0x7AEF5A000
        public void EndGroup(){} // RVA: 0x7AEF5A360
        public void get_scrollViewStates(){} // RVA: 0x7AEF5A3F0
        public void BeginScrollView(){} // RVA: 0x7AEF5A450
        public void EndScrollView(){} // RVA: 0x7AEF5B480
        public void Window(){} // RVA: 0x7AEF5C8C0
        public void DoWindow(){} // RVA: 0x7AEF5C9C0
        public void CallWindowDelegate(){} // RVA: 0x7AEF5CB60
        public void get_color_Injected(){} // RVA: 0x7AEF5CE90
        public void set_color_Injected(){} // RVA: 0x7AEF5CEE0
        public void get_backgroundColor_Injected(){} // RVA: 0x7AEF5CF30
        public void set_backgroundColor_Injected(){} // RVA: 0x7AEF5CF80
        public void get_contentColor_Injected(){} // RVA: 0x7AEF5CFD0
        public void set_contentColor_Injected(){} // RVA: 0x7AEF5D020
        public void Internal_DoWindow_Injected(){} // RVA: 0x7AEF5D070
    }

    public class GUIClip : Object
    {
        // ── Methods ──
        public void get_visibleRect(){} // RVA: 0x7AEF5D100
        public void Internal_Push(){} // RVA: 0x7AEF5D160
        public void Internal_Pop(){} // RVA: 0x7AEF5D1E0
        public void Internal_GetCount(){} // RVA: 0x7AEF5D230
        public void Unclip_Vector2(){} // RVA: 0x7AEF5D280
        public void UnclipToWindow_Vector2(){} // RVA: 0x7AEF5D2F0
        public void GetMatrix(){} // RVA: 0x7AEF5D360
        public void SetMatrix(){} // RVA: 0x7AEF5D3D0
        public void Internal_PushParentClip(){} // RVA: 0x7AEF5D4D0
        public void Internal_PopParentClip(){} // RVA: 0x7AEF5D540
        public void Push(){} // RVA: 0x7AEF5D590
        public void Pop(){} // RVA: 0x7AEF5D1E0
        public void Unclip(){} // RVA: 0x7AEF5D610
        public void UnclipToWindow(){} // RVA: 0x7AEF5D680
        public void get_visibleRect_Injected(){} // RVA: 0x7AEF5D6F0
        public void Internal_Push_Injected(){} // RVA: 0x7AEF5D740
        public void Unclip_Vector2_Injected(){} // RVA: 0x7AEF5D7C0
        public void UnclipToWindow_Vector2_Injected(){} // RVA: 0x7AEF5D820
        public void GetMatrix_Injected(){} // RVA: 0x7AEF5D880
        public void SetMatrix_Injected(){} // RVA: 0x7AEF5D8D0
        public void Internal_PushParentClip_Injected(){} // RVA: 0x7AEF5D920
    }

    public class GUIContent : Object
    {
        // ── Methods ──
        public void get_text(){} // RVA: 0x7AB1AC740
        public void set_text(){} // RVA: 0x7AEF5DAA0
        public void set_image(){} // RVA: 0x7A813E420
        public void get_tooltip(){} // RVA: 0x7AE8145B0
        public void set_tooltip(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7AEF5DF20
        public void Temp(){} // RVA: 0x7AEF5E700
        public void ClearStaticCache(){} // RVA: 0x7AEF5E3D0
        public void ToString(){} // RVA: 0x7AEF5E8E0
        public void .cctor(){} // RVA: 0x7AEF5E930
    }

    public class GUIContent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GUIElement : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class GUIGridSizer : GUILayoutEntry
    {
        // ── Methods ──
        public void GetRect(){} // RVA: 0x7AEF71260
        public void .ctor(){} // RVA: 0x7AEF71490
        public void get_rows(){} // RVA: 0x7AEF71C00
    }

    public class GUILayer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class GUILayout : Object
    {
        // ── Methods ──
        public void Label(){} // RVA: 0x7AEF5EC90
        public void DoLabel(){} // RVA: 0x7AEF5ED10
        public void Box(){} // RVA: 0x7AEF5EE70
        public void DoBox(){} // RVA: 0x7AEF5F130
        public void Button(){} // RVA: 0x7AEF5F230
        public void DoButton(){} // RVA: 0x7AEF5F3B0
        public void TextField(){} // RVA: 0x7AEF5F540
        public void DoTextField(){} // RVA: 0x7AEF5F5D0
        public void Toggle(){} // RVA: 0x7AEF5F920
        public void DoToggle(){} // RVA: 0x7AEF5FAC0
        public void SelectionGrid(){} // RVA: 0x7AEF5FF70
        public void HorizontalSlider(){} // RVA: 0x7AEF600E0
        public void DoHorizontalSlider(){} // RVA: 0x7AEF60350
        public void Space(){} // RVA: 0x7AEF60530
        public void FlexibleSpace(){} // RVA: 0x7AEF60880
        public void BeginHorizontal(){} // RVA: 0x7AEF60C80
        public void EndHorizontal(){} // RVA: 0x7AEF60E60
        public void BeginVertical(){} // RVA: 0x7AEF60FC0
        public void EndVertical(){} // RVA: 0x7AEF611A0
        public void BeginArea(){} // RVA: 0x7AEF612A0
        public void EndArea(){} // RVA: 0x7AEF615D0
        public void BeginScrollView(){} // RVA: 0x7AEF61860
        public void EndScrollView(){} // RVA: 0x7AEF61CF0
        public void Window(){} // RVA: 0x7AEF61D70
        public void DoWindow(){} // RVA: 0x7AEF61E90
        public void Width(){} // RVA: 0x7AEF62180
        public void Height(){} // RVA: 0x7AEF62250
        public void ExpandWidth(){} // RVA: 0x7AEF62320
        public void ExpandHeight(){} // RVA: 0x7AEF623E0
    }

    public class GUILayoutEntry : Object
    {
        // ── Methods ──
        public void get_style(){} // RVA: 0x7AEF66FF0
        public void set_style(){} // RVA: 0x7AEF70120
        public void get_marginLeft(){} // RVA: 0x7AEF70190
        public void get_marginRight(){} // RVA: 0x7AEF70200
        public void get_marginTop(){} // RVA: 0x7AEF70270
        public void get_marginBottom(){} // RVA: 0x7AEF702E0
        public void get_marginHorizontal(){} // RVA: 0x7AEF70350
        public void get_marginVertical(){} // RVA: 0x7AEF703A0
        public void .ctor(){} // RVA: 0x7AEF70510
        public void CalcWidth(){} // RVA: 0x7A80D7310
        public void CalcHeight(){} // RVA: 0x7A80D7310
        public void SetHorizontal(){} // RVA: 0x7AEF70630
        public void SetVertical(){} // RVA: 0x7AEF70640
        public void ApplyStyleSettings(){} // RVA: 0x7AEF70650
        public void ApplyOptions(){} // RVA: 0x7AEF70820
        public void ToString(){} // RVA: 0x7AEF70BD0
        public void .cctor(){} // RVA: 0x7AEF71200
    }

    public class GUILayoutEntry[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GUILayoutGroup : GUILayoutEntry
    {
        // ── Methods ──
        public void get_marginLeft(){} // RVA: 0x7A8D6DF30
        public void get_marginRight(){} // RVA: 0x7A9A18C60
        public void get_marginTop(){} // RVA: 0x7A897F560
        public void get_marginBottom(){} // RVA: 0x7AB40DAB0
        public void .ctor(){} // RVA: 0x7AEF72090
        public void ApplyOptions(){} // RVA: 0x7AEF72210
        public void ApplyStyleSettings(){} // RVA: 0x7AEF72320
        public void ResetCursor(){} // RVA: 0x7AEF72490
        public void GetNext(){} // RVA: 0x7AEF724A0
        public void Add(){} // RVA: 0x7AEF727F0
        public void CalcWidth(){} // RVA: 0x7AEF72890
        public void SetHorizontal(){} // RVA: 0x7AEF73180
        public void CalcHeight(){} // RVA: 0x7AEF73B70
        public void SetVertical(){} // RVA: 0x7AEF74400
        public void ToString(){} // RVA: 0x7AEF74D30
        public void .cctor(){} // RVA: 0x7AEF75130
    }

    public class GUILayoutGroup[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GUILayoutOption : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A9AC8120
    }

    public class GUILayoutUtility : Object
    {
        // ── Methods ──
        public void Internal_GetWindowRect(){} // RVA: 0x7AEF62730
        public void Internal_MoveWindow(){} // RVA: 0x7AEF627D0
        public void get_unbalancedgroupscount(){} // RVA: 0x7AEF62870
        public void set_unbalancedgroupscount(){} // RVA: 0x7AEF628D0
        public void SelectIDList(){} // RVA: 0x7AEF62930
        public void Begin(){} // RVA: 0x7AEF62C20
        public void BeginContainer(){} // RVA: 0x7AEF63110
        public void BeginWindow(){} // RVA: 0x7AEF63490
        public void Layout(){} // RVA: 0x7AEF63A70
        public void LayoutFromEditorWindow(){} // RVA: 0x7AEF63DF0
        public void LayoutFromContainer(){} // RVA: 0x7AEF64130
        public void LayoutFreeGroup(){} // RVA: 0x7AEF64320
        public void LayoutSingleGroup(){} // RVA: 0x7AEF64520
        public void CreateGUILayoutGroupInstanceOfType(){} // RVA: 0x7AEF647F0
        public void BeginLayoutGroup(){} // RVA: 0x7AEF64990
        public void EndLayoutGroup(){} // RVA: 0x7AEF64D80
        public void BeginLayoutArea(){} // RVA: 0x7AEF65160
        public void EndLayoutArea(){} // RVA: 0x7AEF65510
        public void GetRect(){} // RVA: 0x7AEF65DD0
        public void DoGetRect(){} // RVA: 0x7AEF65E90
        public void get_spaceStyle(){} // RVA: 0x7AEF660E0
        public void .cctor(){} // RVA: 0x7AEF66270
        public void Internal_GetWindowRect_Injected(){} // RVA: 0x7AEF664A0
        public void Internal_MoveWindow_Injected(){} // RVA: 0x7AEF66500
    }

    public class GUIScrollGroup : GUILayoutGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEF75260
        public void CalcWidth(){} // RVA: 0x7AEF752C0
        public void SetHorizontal(){} // RVA: 0x7AEF75360
        public void CalcHeight(){} // RVA: 0x7AEF75540
        public void SetVertical(){} // RVA: 0x7AEF756F0
    }

    public class GUIScrollGroup[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GUISettings : Object
    {
        // ── Methods ──
        public void Internal_GetCursorFlashSpeed(){} // RVA: 0x7AEF66970
        public void get_doubleClickSelectsWord(){} // RVA: 0x7AEF669C0
        public void get_tripleClickSelectsLine(){} // RVA: 0x7AEF669D0
        public void get_cursorColor(){} // RVA: 0x7AACD6AC0
        public void get_cursorFlashSpeed(){} // RVA: 0x7AEF669E0
        public void get_selectionColor(){} // RVA: 0x7AEF66A50
        public void .ctor(){} // RVA: 0x7AEF66A60
    }

    public class GUISkin : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEF66A90
        public void OnEnable(){} // RVA: 0x7AEF66C40
        public void CleanupRoots(){} // RVA: 0x7AEF66C50
        public void get_font(){} // RVA: 0x7AACE3A80
        public void set_font(){} // RVA: 0x7AEF66D50
        public void get_box(){} // RVA: 0x7AE8145B0
        public void set_box(){} // RVA: 0x7AEF66F20
        public void get_label(){} // RVA: 0x7AEF66F80
        public void set_label(){} // RVA: 0x7AEF66F90
        public void get_textField(){} // RVA: 0x7AEF66FF0
        public void set_textField(){} // RVA: 0x7AEF67000
        public void get_textArea(){} // RVA: 0x7AEF67060
        public void set_textArea(){} // RVA: 0x7AEF67070
        public void get_button(){} // RVA: 0x7AEF244A0
        public void set_button(){} // RVA: 0x7AEF670D0
        public void get_toggle(){} // RVA: 0x7AEF24D90
        public void set_toggle(){} // RVA: 0x7AEF67130
        public void get_window(){} // RVA: 0x7AEF67190
        public void set_window(){} // RVA: 0x7AEF671A0
        public void get_horizontalSlider(){} // RVA: 0x7AEF67200
        public void set_horizontalSlider(){} // RVA: 0x7AEF67210
        public void get_horizontalSliderThumb(){} // RVA: 0x7AEF67270
        public void set_horizontalSliderThumb(){} // RVA: 0x7AEF67280
        public void get_horizontalSliderThumbExtent(){} // RVA: 0x7AEF672E0
        public void set_horizontalSliderThumbExtent(){} // RVA: 0x7AEF672F0
        public void get_sliderMixed(){} // RVA: 0x7AEF67350
        public void set_sliderMixed(){} // RVA: 0x7AEF67360
        public void get_verticalSlider(){} // RVA: 0x7AEF673C0
        public void set_verticalSlider(){} // RVA: 0x7AEF673D0
        public void get_verticalSliderThumb(){} // RVA: 0x7AEF67430
        public void set_verticalSliderThumb(){} // RVA: 0x7AEF67440
        public void get_verticalSliderThumbExtent(){} // RVA: 0x7AEF674A0
        public void set_verticalSliderThumbExtent(){} // RVA: 0x7AEF674B0
        public void get_horizontalScrollbar(){} // RVA: 0x7AEF67510
        public void set_horizontalScrollbar(){} // RVA: 0x7AEF67520
        public void get_horizontalScrollbarThumb(){} // RVA: 0x7AEF67580
        public void set_horizontalScrollbarThumb(){} // RVA: 0x7AEF67590
        public void get_horizontalScrollbarLeftButton(){} // RVA: 0x7AEF675F0
        public void set_horizontalScrollbarLeftButton(){} // RVA: 0x7AEF67600
        public void get_horizontalScrollbarRightButton(){} // RVA: 0x7AEF67660
        public void set_horizontalScrollbarRightButton(){} // RVA: 0x7AEF67670
        public void get_verticalScrollbar(){} // RVA: 0x7AEF676D0
        public void set_verticalScrollbar(){} // RVA: 0x7AEF676E0
        public void get_verticalScrollbarThumb(){} // RVA: 0x7AEF67740
        public void set_verticalScrollbarThumb(){} // RVA: 0x7AEF67750
        public void get_verticalScrollbarUpButton(){} // RVA: 0x7AEF677B0
        public void set_verticalScrollbarUpButton(){} // RVA: 0x7AEF677C0
        public void get_verticalScrollbarDownButton(){} // RVA: 0x7AEF67820
        public void set_verticalScrollbarDownButton(){} // RVA: 0x7AEF67830
        public void get_scrollView(){} // RVA: 0x7AEF67890
        public void set_scrollView(){} // RVA: 0x7AEF678A0
        public void get_customStyles(){} // RVA: 0x7AEF67900
        public void set_customStyles(){} // RVA: 0x7AEF67910
        public void get_settings(){} // RVA: 0x7AEF67970
        public void get_error(){} // RVA: 0x7AEF67980
        public void Apply(){} // RVA: 0x7AEF67AB0
        public void BuildStyleCache(){} // RVA: 0x7AEF67B30
        public void GetStyle(){} // RVA: 0x7AEF69530
        public void FindStyle(){} // RVA: 0x7AEF69810
        public void MakeCurrent(){} // RVA: 0x7AEF698B0
        public void GetEnumerator(){} // RVA: 0x7AEF699E0
    }

    public class GUISkin[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GUIStateObjects : Object
    {
        // ── Methods ──
        public void GetStateObject(){} // RVA: 0x7AEF69B20
        public void .cctor(){} // RVA: 0x7AEF69CA0
    }

    public class GUIStyle : Object
    {
        // ── Methods ──
        public void get_rawName(){} // RVA: 0x7AEF6A0E0
        public void set_rawName(){} // RVA: 0x7AEF6A130
        public void get_font(){} // RVA: 0x7AEF6A190
        public void get_imagePosition(){} // RVA: 0x7AEF6A1E0
        public void get_wordWrap(){} // RVA: 0x7AEF6A230
        public void get_contentOffset(){} // RVA: 0x7AEF6A280
        public void set_contentOffset(){} // RVA: 0x7AEF6A2E0
        public void get_fixedWidth(){} // RVA: 0x7AEF6A340
        public void get_fixedHeight(){} // RVA: 0x7AEF6A390
        public void get_stretchWidth(){} // RVA: 0x7AEF6A3E0
        public void set_stretchWidth(){} // RVA: 0x7AEF6A430
        public void get_stretchHeight(){} // RVA: 0x7AEF6A490
        public void set_stretchHeight(){} // RVA: 0x7AEF6A4E0
        public void set_Internal_clipOffset(){} // RVA: 0x7AEF6A540
        public void Internal_Create(){} // RVA: 0x7AEF6A5A0
        public void Internal_Copy(){} // RVA: 0x7AEF6A5F0
        public void Internal_Destroy(){} // RVA: 0x7AEF6A650
        public void GetStyleStatePtr(){} // RVA: 0x7AEF6A6A0
        public void GetRectOffsetPtr(){} // RVA: 0x7AEF6A700
        public void Internal_GetLineHeight(){} // RVA: 0x7AEF6A760
        public void Internal_Draw(){} // RVA: 0x7AEF6A7B0
        public void Internal_Draw2(){} // RVA: 0x7AEF6A860
        public void Internal_DrawCursor(){} // RVA: 0x7AEF6A8F0
        public void Internal_DrawWithTextSelection(){} // RVA: 0x7AEF6A980
        public void Internal_GetCursorPixelPosition(){} // RVA: 0x7AEF6AA70
        public void Internal_GetCursorStringIndex(){} // RVA: 0x7AEF6AB10
        public void Internal_GetSelectedRenderedText(){} // RVA: 0x7AEF6AB90
        public void Internal_CalcSize(){} // RVA: 0x7AEF6AC20
        public void Internal_CalcSizeWithConstraints(){} // RVA: 0x7AEF6AC90
        public void Internal_CalcHeight(){} // RVA: 0x7AEF6AD10
        public void Internal_CalcMinMaxWidth(){} // RVA: 0x7AEF6AD80
        public void SetMouseTooltip(){} // RVA: 0x7AEF6ADF0
        public void IsTooltipActive(){} // RVA: 0x7AEF6AE90
        public void Internal_GetCursorFlashOffset(){} // RVA: 0x7AEF6AEE0
        public void SetDefaultFont(){} // RVA: 0x7AEF6AF30
        public void .ctor(){} // RVA: 0x7AEF6B010
        public void Finalize(){} // RVA: 0x7AEF6B100
        public void get_name(){} // RVA: 0x7AEF6B1D0
        public void set_name(){} // RVA: 0x7AEF6B290
        public void get_normal(){} // RVA: 0x7AEF6B340
        public void get_border(){} // RVA: 0x7AEF6B4A0
        public void get_margin(){} // RVA: 0x7AEF6B600
        public void get_padding(){} // RVA: 0x7AEF6B760
        public void get_lineHeight(){} // RVA: 0x7AEF6B8C0
        public void Draw(){} // RVA: 0x7AEF6BD20
        public void DrawCursor(){} // RVA: 0x7AEF6BE40
        public void DrawWithTextSelection(){} // RVA: 0x7AEF6C770
        public void get_none(){} // RVA: 0x7AEF6C7B0
        public void GetCursorPixelPosition(){} // RVA: 0x7AEF6C8B0
        public void GetCursorStringIndex(){} // RVA: 0x7AEF6C950
        public void CalcSize(){} // RVA: 0x7AEF6AC20
        public void CalcSizeWithConstraints(){} // RVA: 0x7AEF6AC90
        public void CalcHeight(){} // RVA: 0x7AEF6AD10
        public void get_isHeightDependantOnWidth(){} // RVA: 0x7AEF6C9D0
        public void CalcMinMaxWidth(){} // RVA: 0x7AEF6CAD0
        public void ToString(){} // RVA: 0x7AEF6CB70
        public void .cctor(){} // RVA: 0x7AEF6CC30
        public void get_contentOffset_Injected(){} // RVA: 0x7AEF6CC70
        public void set_contentOffset_Injected(){} // RVA: 0x7AEF6CCD0
        public void set_Internal_clipOffset_Injected(){} // RVA: 0x7AEF6CD30
        public void Internal_Draw_Injected(){} // RVA: 0x7AEF6CD90
        public void Internal_Draw2_Injected(){} // RVA: 0x7AEF6CE40
        public void Internal_DrawCursor_Injected(){} // RVA: 0x7AEF6CED0
        public void Internal_DrawWithTextSelection_Injected(){} // RVA: 0x7AEF6CF60
        public void Internal_GetCursorPixelPosition_Injected(){} // RVA: 0x7AEF6D030
        public void Internal_GetCursorStringIndex_Injected(){} // RVA: 0x7AEF6D0C0
        public void Internal_GetSelectedRenderedText_Injected(){} // RVA: 0x7AEF6D140
        public void Internal_CalcSize_Injected(){} // RVA: 0x7AEF6D1D0
        public void Internal_CalcSizeWithConstraints_Injected(){} // RVA: 0x7AEF6D240
        public void Internal_CalcMinMaxWidth_Injected(){} // RVA: 0x7AEF6D2C0
        public void SetMouseTooltip_Injected(){} // RVA: 0x7AEF6D330
    }

    public class GUIStyleState : Object
    {
        // ── Methods ──
        public void set_background(){} // RVA: 0x7AEF69D80
        public void set_textColor(){} // RVA: 0x7AEF69DE0
        public void Init(){} // RVA: 0x7AEF69E40
        public void Cleanup(){} // RVA: 0x7AEF69E90
        public void .ctor(){} // RVA: 0x7AEEADF40
        public void GetGUIStyleState(){} // RVA: 0x7AEF69F30
        public void Finalize(){} // RVA: 0x7AEF69FF0
        public void set_textColor_Injected(){} // RVA: 0x7AEF6A080
    }

    public class GUIStyle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GUITargetAttribute : Attribute
    {
        // ── Methods ──
        public void GetGUITargetAttrValue(){} // RVA: 0x7AEF6D390
    }

    public class GUITargetAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GUIText : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class GUITexture : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class GUIUtility : Object
    {
        // ── Methods ──
        public void get_pixelsPerPoint(){} // RVA: 0x7AEF6D5F0
        public void get_guiDepth(){} // RVA: 0x7AEF6D640
        public void set_mouseUsed(){} // RVA: 0x7AEF6D690
        public void get_textFieldInput(){} // RVA: 0x7AEF6D6E0
        public void set_textFieldInput(){} // RVA: 0x7AEF6D730
        public void get_systemCopyBuffer(){} // RVA: 0x7AEF6D780
        public void set_systemCopyBuffer(){} // RVA: 0x7AEF6D7D0
        public void Internal_GetControlID(){} // RVA: 0x7AEF6D820
        public void GetControlID(){} // RVA: 0x7AEF6E0D0
        public void BeginContainerFromOwner(){} // RVA: 0x7AEF6D9C0
        public void BeginContainer(){} // RVA: 0x7AEF6DA10
        public void Internal_EndContainer(){} // RVA: 0x7AEF6DA60
        public void CheckForTabEvent(){} // RVA: 0x7AEF6DAB0
        public void SetKeyboardControlToFirstControlId(){} // RVA: 0x7AEF6DB00
        public void SetKeyboardControlToLastControlId(){} // RVA: 0x7AEF6DB50
        public void HasFocusableControls(){} // RVA: 0x7AEF6DBA0
        public void OwnsId(){} // RVA: 0x7AEF6DBF0
        public void AlignRectToDevice(){} // RVA: 0x7AEF6F870
        public void get_compositionString(){} // RVA: 0x7AEF6DD00
        public void set_imeCompositionMode(){} // RVA: 0x7AEF6DD50
        public void set_compositionCursorPos(){} // RVA: 0x7AEF6DDA0
        public void Internal_GetHotControl(){} // RVA: 0x7AEF6DE30
        public void Internal_GetKeyboardControl(){} // RVA: 0x7AEF6DE80
        public void Internal_SetHotControl(){} // RVA: 0x7AEF6DED0
        public void Internal_SetKeyboardControl(){} // RVA: 0x7AEF6DF20
        public void Internal_GetDefaultSkin(){} // RVA: 0x7AEF6DF70
        public void Internal_ExitGUI(){} // RVA: 0x7AEF6DFC0
        public void MarkGUIChanged(){} // RVA: 0x7AEF6E010
        public void GetStateObject(){} // RVA: 0x7AEF6E150
        public void set_guiIsExiting(){} // RVA: 0x7AEF6E310
        public void get_hotControl(){} // RVA: 0x7AEF6E370
        public void set_hotControl(){} // RVA: 0x7AEF6E3F0
        public void TakeCapture(){} // RVA: 0x7AEF6E480
        public void RemoveCapture(){} // RVA: 0x7AEF6E4F0
        public void get_keyboardControl(){} // RVA: 0x7AEF6E560
        public void set_keyboardControl(){} // RVA: 0x7AEF6E5E0
        public void HasKeyFocus(){} // RVA: 0x7AEF6E670
        public void ExitGUI(){} // RVA: 0x7AEF6E750
        public void GetDefaultSkin(){} // RVA: 0x7AEF6E790
        public void ProcessEvent(){} // RVA: 0x7AEF6E860
        public void EndContainer(){} // RVA: 0x7AEF6EAB0
        public void BeginGUI(){} // RVA: 0x7AEF6EB70
        public void EndGUI(){} // RVA: 0x7AEF6EC30
        public void EndGUIFromException(){} // RVA: 0x7AEF6EE50
        public void EndContainerGUIFromException(){} // RVA: 0x7AEF6EEE0
        public void ResetGlobalState(){} // RVA: 0x7AEF6EF80
        public void IsExitGUIException(){} // RVA: 0x7AEF6F0E0
        public void ShouldRethrowException(){} // RVA: 0x7AEF6F160
        public void CheckOnGUI(){} // RVA: 0x7AEF6F220
        public void RoundToPixelGrid(){} // RVA: 0x7AEF6F300
        public void ScaleAroundPivot(){} // RVA: 0x7AEF6F3F0
        public void HitTest(){} // RVA: 0x7AEF6FAC0
        public void .cctor(){} // RVA: 0x7AEF6FBA0
        public void Internal_GetControlID_Injected(){} // RVA: 0x7AEF6FCB0
        public void AlignRectToDevice_Injected(){} // RVA: 0x7AEF6FD20
        public void set_compositionCursorPos_Injected(){} // RVA: 0x7AEF6FDA0
    }

    public class GUIUtility[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GUIWordWrapSizer : GUILayoutEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEF71C20
        public void CalcWidth(){} // RVA: 0x7AEF71F10
        public void CalcHeight(){} // RVA: 0x7AEF72010
    }

    public class GUI[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GameObject : Object
    {
        // ── Methods ──
        public void GetComponent(){} // RVA: 0x7AA4B06A0
        public void CreatePrimitive(){} // RVA: 0x7AEF06910
        public void GetComponentFastPath(){} // RVA: 0x7AEF069C0
        public void GetComponentByName(){} // RVA: 0x7AEF06A30
        public void GetComponentInChildren(){} // RVA: 0x7AA4B0C80
        public void GetComponentInParent(){} // RVA: 0x7AA4B1060
        public void GetComponentsInternal(){} // RVA: 0x7AEF06C50
        public void GetComponents(){} // RVA: 0x7AA4B1570
        public void GetComponentsInChildren(){} // RVA: 0x7AA4B1690
        public void GetComponentsInParent(){} // RVA: 0x7AA4B1A10
        public void TryGetComponent(){} // RVA: 0x7AA4B1CC0
        public void TryGetComponentInternal(){} // RVA: 0x7AEF071A0
        public void TryGetComponentFastPath(){} // RVA: 0x7AEF07200
        public void FindWithTag(){} // RVA: 0x7AEF07270
        public void SendMessageUpwards(){} // RVA: 0x7AEF07C10
        public void SendMessage(){} // RVA: 0x7AEF07CD0
        public void BroadcastMessage(){} // RVA: 0x7AEF07D90
        public void AddComponentInternal(){} // RVA: 0x7AEF07320
        public void Internal_AddComponentWithType(){} // RVA: 0x7AEF07380
        public void AddComponent(){} // RVA: 0x7AA4B0520
        public void GetComponentCount(){} // RVA: 0x7AEF073E0
        public void QueryComponentAtIndex(){} // RVA: 0x7AEF07430
        public void GetComponentAtIndex(){} // RVA: 0x7A8051B10
        public void GetComponentIndex(){} // RVA: 0x7AEF075A0
        public void get_transform(){} // RVA: 0x7AEF07600
        public void get_layer(){} // RVA: 0x7AEF07650
        public void set_layer(){} // RVA: 0x7AEF076A0
        public void get_active(){} // RVA: 0x7AEF07700
        public void set_active(){} // RVA: 0x7AEF07750
        public void SetActive(){} // RVA: 0x7AEF077B0
        public void get_activeSelf(){} // RVA: 0x7AEF07810
        public void get_activeInHierarchy(){} // RVA: 0x7AEF07860
        public void SetActiveRecursively(){} // RVA: 0x7AEF078B0
        public void get_isStatic(){} // RVA: 0x7AEF07910
        public void set_isStatic(){} // RVA: 0x7AEF07960
        public void get_isStaticBatchable(){} // RVA: 0x7AEF079C0
        public void get_tag(){} // RVA: 0x7AEF07A10
        public void set_tag(){} // RVA: 0x7AEF07A60
        public void CompareTag(){} // RVA: 0x7AEF07AC0
        public void FindGameObjectWithTag(){} // RVA: 0x7AEF07270
        public void FindGameObjectsWithTag(){} // RVA: 0x7AEF07B20
        public void .ctor(){} // RVA: 0x7AEF07EE0
        public void Internal_CreateGameObject(){} // RVA: 0x7AEF08020
        public void Find(){} // RVA: 0x7AEF08080
        public void SetGameObjectsActive(){} // RVA: 0x7AEF08210
        public void InstantiateGameObjects(){} // RVA: 0x7AEF08310
        public void GetScene(){} // RVA: 0x7AEF08520
        public void get_scene(){} // RVA: 0x7AEF08580
        public void get_sceneCullingMask(){} // RVA: 0x7AEF085E0
        public void get_gameObject(){} // RVA: 0x7ADCF4DD0
        public void InstantiateGameObjects_Injected(){} // RVA: 0x7AEF08630
        public void GetScene_Injected(){} // RVA: 0x7AEF086B0
        public void get_scene_Injected(){} // RVA: 0x7AEF08710
    }

    public class GameObject[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GeometryUtility : Object
    {
        // ── Methods ──
        public void CalculateFrustumPlanes(){} // RVA: 0x7AEEAB780
        public void CalculateBounds(){} // RVA: 0x7AEEAB8C0
        public void TryCreatePlaneFromPolygon(){} // RVA: 0x7AEEABA40
        public void TestPlanesAABB(){} // RVA: 0x7AEEABEE0
        public void Internal_ExtractPlanes(){} // RVA: 0x7AEEABF40
        public void Internal_CalculateBounds(){} // RVA: 0x7AEEABFA0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void TestPlanesAABB_Injected(){} // RVA: 0x7AEEAC020
        public void Internal_ExtractPlanes_Injected(){} // RVA: 0x7AEEAC080
        public void Internal_CalculateBounds_Injected(){} // RVA: 0x7AEEAC0E0
    }

    public class Gizmos : Object
    {
        // ── Methods ──
        public void DrawLine(){} // RVA: 0x7AEEAED00
        public void DrawWireSphere(){} // RVA: 0x7AEEAED60
        public void DrawSphere(){} // RVA: 0x7AEEAEDC0
        public void DrawWireCube(){} // RVA: 0x7AEEAEE20
        public void DrawCube(){} // RVA: 0x7AEEAEE80
        public void DrawMesh(){} // RVA: 0x7AEEAF6C0
        public void DrawWireMesh(){} // RVA: 0x7AEEAFD60
        public void DrawIcon(){} // RVA: 0x7AEEAFEB0
        public void DrawGUITexture(){} // RVA: 0x7AEEB0030
        public void get_color(){} // RVA: 0x7AEEAF1B0
        public void set_color(){} // RVA: 0x7AEEAF210
        public void get_matrix(){} // RVA: 0x7AEEAF260
        public void set_matrix(){} // RVA: 0x7AEEAF2D0
        public void get_probeSize(){} // RVA: 0x7AEEAF320
        public void DrawFrustum(){} // RVA: 0x7AEEAF370
        public void DrawRay(){} // RVA: 0x7AEEAF4C0
        public void .ctor(){} // RVA: 0x7A80D7310
        public void DrawLine_Injected(){} // RVA: 0x7AEEB00D0
        public void DrawWireSphere_Injected(){} // RVA: 0x7AEEB0130
        public void DrawSphere_Injected(){} // RVA: 0x7AEEB0190
        public void DrawWireCube_Injected(){} // RVA: 0x7AEEB01F0
        public void DrawCube_Injected(){} // RVA: 0x7AEEB0250
        public void DrawMesh_Injected(){} // RVA: 0x7AEEB02B0
        public void DrawWireMesh_Injected(){} // RVA: 0x7AEEB0330
        public void DrawIcon_Injected(){} // RVA: 0x7AEEB03B0
        public void DrawGUITexture_Injected(){} // RVA: 0x7AEEB0430
        public void get_color_Injected(){} // RVA: 0x7AEEB04C0
        public void set_color_Injected(){} // RVA: 0x7AEEB0510
        public void get_matrix_Injected(){} // RVA: 0x7AEEB0560
        public void set_matrix_Injected(){} // RVA: 0x7AEEB05B0
        public void DrawFrustum_Injected(){} // RVA: 0x7AEEB0600
    }

    public class GlobalJavaObjectRef : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AEE5B810
        public void Finalize(){} // RVA: 0x7AEE5B890
        public void op_Implicit(){} // RVA: 0x7A8DC0790
        public void Dispose(){} // RVA: 0x7AEE5B8D0
    }

    public class Gradient : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7AEEF08F0
        public void Cleanup(){} // RVA: 0x7AEEF0940
        public void Internal_Equals(){} // RVA: 0x7AEEF0990
        public void .ctor(){} // RVA: 0x7AEEF09F0
        public void Finalize(){} // RVA: 0x7AEEF0A40
        public void Evaluate(){} // RVA: 0x7AEEF0AC0
        public void get_colorKeys(){} // RVA: 0x7AEEF0B40
        public void set_colorKeys(){} // RVA: 0x7AEEF0B90
        public void get_alphaKeys(){} // RVA: 0x7AEEF0BF0
        public void set_alphaKeys(){} // RVA: 0x7AEEF0C40
        public void get_mode(){} // RVA: 0x7AEEF0CA0
        public void set_mode(){} // RVA: 0x7AEEF0CF0
        public void get_colorSpace(){} // RVA: 0x7AEEF0D50
        public void set_colorSpace(){} // RVA: 0x7AEEF0DA0
        public void SetKeys(){} // RVA: 0x7AEEF0E00
        public void Equals(){} // RVA: 0x7AEEF0F80
        public void GetHashCode(){} // RVA: 0x7AEE980C0
        public void Evaluate_Injected(){} // RVA: 0x7AEEF10C0
    }

    public class GradientAlphaKey : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7663240
    }

    public class GradientAlphaKey[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2CE990
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29F890
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6120
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA27DF80
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29F890
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class GradientColorKey : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7EDD830
    }

    public class GradientColorKey[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A23D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E490
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E35B0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA251170
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E490
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Gradient[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Graphics : Object
    {
        // ── Methods ──
        public void Internal_GetMaxDrawMeshInstanceCount(){} // RVA: 0x7AEEB2ED0
        public void Internal_SetNullRT(){} // RVA: 0x7AEEB2F20
        public void Internal_SetRTSimple(){} // RVA: 0x7AEEB2F70
        public void Internal_SetRandomWriteTargetBuffer(){} // RVA: 0x7AEEB3030
        public void ClearRandomWriteTargets(){} // RVA: 0x7AEEB30A0
        public void CopyTexture_Full(){} // RVA: 0x7AEEB30F0
        public void CopyTexture_Slice(){} // RVA: 0x7AEEB3150
        public void CopyTexture_Region(){} // RVA: 0x7AEEB31D0
        public void ConvertTexture_Full(){} // RVA: 0x7AEEB3260
        public void Internal_DrawMeshNow2(){} // RVA: 0x7AEEB32C0
        public void Internal_DrawTexture(){} // RVA: 0x7AEEB3370
        public void Internal_RenderMeshPrimitives(){} // RVA: 0x7AEEB33C0
        public void Internal_DrawMesh(){} // RVA: 0x7AEEB3480
        public void Internal_DrawMeshInstanced(){} // RVA: 0x7AEEB35A0
        public void Internal_DrawProcedural(){} // RVA: 0x7AEEB3640
        public void Internal_DrawProceduralIndirect(){} // RVA: 0x7AEEB3740
        public void Internal_BlitMaterial5(){} // RVA: 0x7AEEB3840
        public void Internal_BlitMaterial6(){} // RVA: 0x7AEEB38D0
        public void Blit2(){} // RVA: 0x7AEEB3960
        public void Blit3(){} // RVA: 0x7AEEB39C0
        public void Blit4(){} // RVA: 0x7AEEB3A40
        public void Blit5(){} // RVA: 0x7AEEB3AF0
        public void CreateGPUFenceImpl(){} // RVA: 0x7AEEB3BB0
        public void ExecuteCommandBuffer(){} // RVA: 0x7AEEB3C10
        public void ExecuteCommandBufferAsync(){} // RVA: 0x7AEEB3C60
        public void SetRenderTargetImpl(){} // RVA: 0x7AEEB3DD0
        public void SetRenderTarget(){} // RVA: 0x7AEEB6DB0
        public void SetRandomWriteTarget(){} // RVA: 0x7AEEB6E30
        public void CopyTexture(){} // RVA: 0x7AEEB4490
        public void ConvertTexture(){} // RVA: 0x7AEEB4550
        public void CreateGraphicsFence(){} // RVA: 0x7AEEB45F0
        public void DrawTextureImpl(){} // RVA: 0x7AEEB4760
        public void DrawTexture(){} // RVA: 0x7AEEB6BF0
        public void RenderMeshPrimitives(){} // RVA: 0x7AEEB4DB0
        public void DrawMeshNow(){} // RVA: 0x7AEEB51B0
        public void DrawMesh(){} // RVA: 0x7AEEB68F0
        public void DrawMeshInstanced(){} // RVA: 0x7AEEB5810
        public void DrawProcedural(){} // RVA: 0x7AEEB5EE0
        public void DrawProceduralIndirect(){} // RVA: 0x7AEEB6030
        public void Blit(){} // RVA: 0x7AEEB6840
        public void .cctor(){} // RVA: 0x7AEEB6E90
        public void Internal_SetRTSimple_Injected(){} // RVA: 0x7AEEB7040
        public void Internal_DrawMeshNow2_Injected(){} // RVA: 0x7AEEB70D0
        public void Internal_RenderMeshPrimitives_Injected(){} // RVA: 0x7AEEB7140
        public void Internal_DrawMesh_Injected(){} // RVA: 0x7AEEB71C0
        public void Internal_DrawProcedural_Injected(){} // RVA: 0x7AEEB7260
        public void Internal_DrawProceduralIndirect_Injected(){} // RVA: 0x7AEEB72F0
        public void Blit4_Injected(){} // RVA: 0x7AEEB7380
        public void Blit5_Injected(){} // RVA: 0x7AEEB7400
    }

    public class GraphicsBuffer : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7AEECE3A0
        public void Dispose(){} // RVA: 0x7AEECE510
        public void RequiresCompute(){} // RVA: 0x7AEECE5F0
        public void IsVertexIndexOrCopyOnly(){} // RVA: 0x7AEECE600
        public void InitBuffer(){} // RVA: 0x7AEECE610
        public void DestroyBuffer(){} // RVA: 0x7AEECE690
        public void .ctor(){} // RVA: 0x7AEECE710
        public void InternalInitialization(){} // RVA: 0x7AEECE720
        public void Release(){} // RVA: 0x7AEECEB80
        public void IsValidBuffer(){} // RVA: 0x7AEECEB90
        public void IsValid(){} // RVA: 0x7AEECEBE0
        public void get_count(){} // RVA: 0x7AEECEC50
        public void get_stride(){} // RVA: 0x7AEECECA0
        public void GetUsageFlags(){} // RVA: 0x7AEECECF0
        public void get_usageFlags(){} // RVA: 0x7AEECECF0
        public void SetData(){} // RVA: 0x7AEECED40
        public void InternalSetData(){} // RVA: 0x7AEECEF20
        public void GetNativeBufferPtr(){} // RVA: 0x7AEECEFB0
        public void BeginBufferWrite(){} // RVA: 0x7AEECF000
        public void LockBufferForWrite(){} // RVA: 0x7AA4B2D70
        public void EndBufferWrite(){} // RVA: 0x7AEECF070
        public void UnlockBufferAfterWrite(){} // RVA: 0x7AA4B3300
    }

    public class GraphicsBuffer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class Grid : GridLayout
    {
        // ── Methods ──
        public void GetCellCenterLocal(){} // RVA: 0x7AEF4B180
        public void GetCellCenterWorld(){} // RVA: 0x7AEF4B2F0
        public void get_cellSize(){} // RVA: 0x7AEF4B4C0
        public void set_cellSize(){} // RVA: 0x7AEF4B530
        public void get_cellGap(){} // RVA: 0x7AEF4B590
        public void set_cellGap(){} // RVA: 0x7AEF4B600
        public void get_cellLayout(){} // RVA: 0x7AEF4B660
        public void set_cellLayout(){} // RVA: 0x7AEF4B6B0
        public void get_cellSwizzle(){} // RVA: 0x7AEF4B710
        public void set_cellSwizzle(){} // RVA: 0x7AEF4B760
        public void Swizzle(){} // RVA: 0x7AEF4B7C0
        public void InverseSwizzle(){} // RVA: 0x7AEF4B840
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_cellSize_Injected(){} // RVA: 0x7AEF4B8C0
        public void set_cellSize_Injected(){} // RVA: 0x7AEF4B920
        public void get_cellGap_Injected(){} // RVA: 0x7AEF4B980
        public void set_cellGap_Injected(){} // RVA: 0x7AEF4B9E0
        public void Swizzle_Injected(){} // RVA: 0x7AEF4BA40
        public void InverseSwizzle_Injected(){} // RVA: 0x7AEF4BAB0
    }

    public class GridLayout : Behaviour
    {
        // ── Methods ──
        public void get_cellSize(){} // RVA: 0x7AEF4BB20
        public void get_cellGap(){} // RVA: 0x7AEF4BB90
        public void get_cellLayout(){} // RVA: 0x7AEF4BC00
        public void get_cellSwizzle(){} // RVA: 0x7AEF4BC50
        public void GetBoundsLocal(){} // RVA: 0x7AEF4BD20
        public void GetBoundsLocalOriginSize(){} // RVA: 0x7AEF4BDF0
        public void CellToLocal(){} // RVA: 0x7AEF4BE80
        public void LocalToCell(){} // RVA: 0x7AEF4BF00
        public void CellToLocalInterpolated(){} // RVA: 0x7AEF4BF80
        public void LocalToCellInterpolated(){} // RVA: 0x7AEF4C000
        public void CellToWorld(){} // RVA: 0x7AEF4C080
        public void WorldToCell(){} // RVA: 0x7AEF4C100
        public void LocalToWorld(){} // RVA: 0x7AEF4C180
        public void WorldToLocal(){} // RVA: 0x7AEF4C200
        public void GetLayoutCellCenter(){} // RVA: 0x7AEF4C280
        public void DoNothing(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_cellSize_Injected(){} // RVA: 0x7AEF4C2F0
        public void get_cellGap_Injected(){} // RVA: 0x7AEF4C350
        public void GetBoundsLocal_Injected(){} // RVA: 0x7AEF4C3B0
        public void GetBoundsLocalOriginSize_Injected(){} // RVA: 0x7AEF4C420
        public void CellToLocal_Injected(){} // RVA: 0x7AEF4C4A0
        public void LocalToCell_Injected(){} // RVA: 0x7AEF4C510
        public void CellToLocalInterpolated_Injected(){} // RVA: 0x7AEF4C580
        public void LocalToCellInterpolated_Injected(){} // RVA: 0x7AEF4C5F0
        public void CellToWorld_Injected(){} // RVA: 0x7AEF4C660
        public void WorldToCell_Injected(){} // RVA: 0x7AEF4C6D0
        public void LocalToWorld_Injected(){} // RVA: 0x7AEF4C740
        public void WorldToLocal_Injected(){} // RVA: 0x7AEF4C7B0
        public void GetLayoutCellCenter_Injected(){} // RVA: 0x7AEF4C820
    }

    public class GridLayout[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

}