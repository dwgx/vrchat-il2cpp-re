// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine
// Classes: 51
// Methods: 1053

namespace ThirdParty.Unity.UnityEngine
{
    public class GCHandlePool : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7B04460
        public void Alloc(){} // RVA: 0x7B044F0
        public void AllocHandleIfNotNull(){} // RVA: 0x7B04570
        public void Free(){} // RVA: 0x7B04580
    }

    public class GL : Object
    {
        // ── Methods ──
        public void Vertex3(){} // RVA: 0x7B80980
        public void TexCoord3(){} // RVA: 0x7B80A00
        public void TexCoord(){} // RVA: 0x7B80A80
        public void TexCoord2(){} // RVA: 0x7B80AA0
        public void ImmediateColor(){} // RVA: 0x7B80AB0
        public void Color(){} // RVA: 0x7B80B40
        public void get_sRGBWrite(){} // RVA: 0x7B80BA0
        public void set_sRGBWrite(){} // RVA: 0x7B80BF0
        public void get_invertCulling(){} // RVA: 0x7B80C40
        public void set_invertCulling(){} // RVA: 0x7B80C90
        public void Flush(){} // RVA: 0x7B80CE0
        public void SetViewMatrix(){} // RVA: 0x7B80D30
        public void set_modelview(){} // RVA: 0x7B80D80
        public void PushMatrix(){} // RVA: 0x7B80DF0
        public void PopMatrix(){} // RVA: 0x7B80E40
        public void LoadOrtho(){} // RVA: 0x7B80E90
        public void LoadProjectionMatrix(){} // RVA: 0x7B80EE0
        public void InvalidateState(){} // RVA: 0x7B80F30
        public void GetGPUProjectionMatrix(){} // RVA: 0x7B80F80
        public void GLLoadPixelMatrixScript(){} // RVA: 0x7B81010
        public void LoadPixelMatrix(){} // RVA: 0x7B81010
        public void GLIssuePluginEvent(){} // RVA: 0x7B810A0
        public void IssuePluginEvent(){} // RVA: 0x7B81100
        public void Begin(){} // RVA: 0x7B811C0
        public void End(){} // RVA: 0x7B81210
        public void GLClear(){} // RVA: 0x7B81260
        public void Clear(){} // RVA: 0x7B81360
        public void Viewport(){} // RVA: 0x7B813E0
        public void SetViewMatrix_Injected(){} // RVA: 0x7B81430
        public void LoadProjectionMatrix_Injected(){} // RVA: 0x7B81480
        public void GetGPUProjectionMatrix_Injected(){} // RVA: 0x7B814D0
        public void GLClear_Injected(){} // RVA: 0x7B81540
        public void Viewport_Injected(){} // RVA: 0x7B815C0
    }

    public class GUI : Object
    {
        // ── Methods ──
        public void get_color(){} // RVA: 0x7C670C0
        public void set_color(){} // RVA: 0x7C67150
        public void get_backgroundColor(){} // RVA: 0x7C671E0
        public void set_backgroundColor(){} // RVA: 0x7C67270
        public void get_contentColor(){} // RVA: 0x7C67300
        public void set_contentColor(){} // RVA: 0x7C67390
        public void get_changed(){} // RVA: 0x7C67420
        public void set_changed(){} // RVA: 0x7C67470
        public void get_enabled(){} // RVA: 0x7C674C0
        public void set_enabled(){} // RVA: 0x7C67510
        public void set_depth(){} // RVA: 0x7C67560
        public void get_usePageScrollbars(){} // RVA: 0x7C675B0
        public void get_blendMaterial(){} // RVA: 0x7C67600
        public void get_blitMaterial(){} // RVA: 0x7C676A0
        public void get_roundedRectMaterial(){} // RVA: 0x7C67740
        public void get_roundedRectWithColorPerBorderMaterial(){} // RVA: 0x7C677E0
        public void GrabMouseControl(){} // RVA: 0x7C67880
        public void HasMouseControl(){} // RVA: 0x7C678D0
        public void ReleaseMouseControl(){} // RVA: 0x7C67920
        public void SetNextControlName(){} // RVA: 0x7C67970
        public void InternalRepaintEditorWindow(){} // RVA: 0x7C67AD0
        public void Internal_DoWindow(){} // RVA: 0x7C67B20
        public void .cctor(){} // RVA: 0x7C67C20
        public void get_scrollTroughSide(){} // RVA: 0x7C67F60
        public void set_scrollTroughSide(){} // RVA: 0x7C67FC0
        public void get_nextScrollStepTime(){} // RVA: 0x7C68020
        public void set_nextScrollStepTime(){} // RVA: 0x7C68080
        public void set_skin(){} // RVA: 0x7C680E0
        public void get_skin(){} // RVA: 0x7C68160
        public void DoSetSkin(){} // RVA: 0x7C681F0
        public void get_matrix(){} // RVA: 0x7C68530
        public void set_matrix(){} // RVA: 0x7C685D0
        public void Label(){} // RVA: 0x7C689A0
        public void DrawTexture(){} // RVA: 0x7C69700
        public void CalculateScaledTextureRects(){} // RVA: 0x7C6A060
        public void DrawTextureWithTexCoords(){} // RVA: 0x7C6A2A0
        public void Box(){} // RVA: 0x7C6A9C0
        public void Button(){} // RVA: 0x7C6ADF0
        public void DoRepeatButton(){} // RVA: 0x7C6B040
        public void PasswordFieldGetStrToShow(){} // RVA: 0x7C6B410
        public void DoTextField(){} // RVA: 0x7C6B760
        public void HandleTextFieldEventForTouchscreen(){} // RVA: 0x7C6BC30
        public void HandleTextFieldEventForDesktop(){} // RVA: 0x7C6C240
        public void Toggle(){} // RVA: 0x7C6CAA0
        public void SelectionGrid(){} // RVA: 0x7C6CD10
        public void CalcTotalHorizSpacing(){} // RVA: 0x7C6CE10
        public void DoControl(){} // RVA: 0x7C6D250
        public void DoLabel(){} // RVA: 0x7C6D640
        public void DoToggle(){} // RVA: 0x7C6DB00
        public void DoButton(){} // RVA: 0x7C6DC90
        public void DoButtonGrid(){} // RVA: 0x7C6DE10
        public void CalcGridRects(){} // RVA: 0x7C6EAD0
        public void HorizontalSlider(){} // RVA: 0x7C6EE90
        public void Slider(){} // RVA: 0x7C6EF60
        public void HorizontalScrollbar(){} // RVA: 0x7C6F220
        public void ScrollerRepeatButton(){} // RVA: 0x7C6F420
        public void VerticalScrollbar(){} // RVA: 0x7C6F770
        public void Scroller(){} // RVA: 0x7C6F970
        public void BeginGroup(){} // RVA: 0x7C70070
        public void EndGroup(){} // RVA: 0x7C70440
        public void get_scrollViewStates(){} // RVA: 0x7C704D0
        public void BeginScrollView(){} // RVA: 0x7C70530
        public void EndScrollView(){} // RVA: 0x7C71760
        public void Window(){} // RVA: 0x7C72D30
        public void DoWindow(){} // RVA: 0x7C72E30
        public void CallWindowDelegate(){} // RVA: 0x7C72FD0
        public void get_color_Injected(){} // RVA: 0x7C73320
        public void set_color_Injected(){} // RVA: 0x7C73370
        public void get_backgroundColor_Injected(){} // RVA: 0x7C733C0
        public void set_backgroundColor_Injected(){} // RVA: 0x7C73410
        public void get_contentColor_Injected(){} // RVA: 0x7C73460
        public void set_contentColor_Injected(){} // RVA: 0x7C734B0
        public void get_blendMaterial_Injected(){} // RVA: 0x7C73500
        public void get_blitMaterial_Injected(){} // RVA: 0x7C73550
        public void get_roundedRectMaterial_Injected(){} // RVA: 0x7C735A0
        public void get_roundedRectWithColorPerBorderMaterial_Injected(){} // RVA: 0x7C735F0
        public void SetNextControlName_Injected(){} // RVA: 0x7C73640
        public void Internal_DoWindow_Injected(){} // RVA: 0x7C73690
    }

    public class GUIClip : Object
    {
        // ── Methods ──
        public void get_visibleRect(){} // RVA: 0x7C73720
        public void Internal_Push(){} // RVA: 0x7C73780
        public void Internal_Pop(){} // RVA: 0x7C73800
        public void Internal_GetCount(){} // RVA: 0x7C73850
        public void Unclip_Vector2(){} // RVA: 0x7C738A0
        public void UnclipToWindow_Vector2(){} // RVA: 0x7C73910
        public void GetMatrix(){} // RVA: 0x7C73980
        public void SetMatrix(){} // RVA: 0x7C739F0
        public void Internal_PushParentClip(){} // RVA: 0x7C73AF0
        public void Internal_PopParentClip(){} // RVA: 0x7C73B60
        public void Push(){} // RVA: 0x7C73BB0
        public void Pop(){} // RVA: 0x7C73800
        public void Unclip(){} // RVA: 0x7C73C30
        public void UnclipToWindow(){} // RVA: 0x7C73CA0
        public void get_visibleRect_Injected(){} // RVA: 0x7C73D10
        public void Internal_Push_Injected(){} // RVA: 0x7C73D60
        public void Unclip_Vector2_Injected(){} // RVA: 0x7C73DE0
        public void UnclipToWindow_Vector2_Injected(){} // RVA: 0x7C73E40
        public void GetMatrix_Injected(){} // RVA: 0x7C73EA0
        public void SetMatrix_Injected(){} // RVA: 0x7C73EF0
        public void Internal_PushParentClip_Injected(){} // RVA: 0x7C73F40
    }

    public class GUIContent : Object
    {
        // ── Methods ──
        public void add_OnTextChanged(){} // RVA: 0x7C740C0
        public void remove_OnTextChanged(){} // RVA: 0x7C741B0
        public void get_text(){} // RVA: 0x3E42230
        public void set_text(){} // RVA: 0x7C742A0
        public void get_textWithWhitespace(){} // RVA: 0x7C74370
        public void set_textWithWhitespace(){} // RVA: 0x7C743E0
        public void SetTextWithoutNotify(){} // RVA: 0x7C744A0
        public void set_image(){} // RVA: 0xBA9BA0
        public void get_tooltip(){} // RVA: 0x7489A40
        public void set_tooltip(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x7C748F0
        public void Temp(){} // RVA: 0x7C75250
        public void ClearStaticCache(){} // RVA: 0x7C74DE0
        public void ToString(){} // RVA: 0x7C75400
        public void .cctor(){} // RVA: 0x7C75450
    }

    public class GUIContent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GUIElement : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class GUIGridSizer : GUILayoutEntry
    {
        // ── Methods ──
        public void GetRect(){} // RVA: 0x7C8CE60
        public void .ctor(){} // RVA: 0x7C8D0A0
        public void get_rows(){} // RVA: 0x7C8D730
    }

    public class GUILayer : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class GUILayout : Object
    {
        // ── Methods ──
        public void Label(){} // RVA: 0x7C75800
        public void DoLabel(){} // RVA: 0x7C75880
        public void Box(){} // RVA: 0x7C759E0
        public void DoBox(){} // RVA: 0x7C75C90
        public void Button(){} // RVA: 0x7C75D90
        public void DoButton(){} // RVA: 0x7C75F10
        public void TextField(){} // RVA: 0x7C760A0
        public void DoTextField(){} // RVA: 0x7C76130
        public void Toggle(){} // RVA: 0x7C76440
        public void DoToggle(){} // RVA: 0x7C765E0
        public void SelectionGrid(){} // RVA: 0x7C76A70
        public void HorizontalSlider(){} // RVA: 0x7C76BE0
        public void DoHorizontalSlider(){} // RVA: 0x7C76E50
        public void Space(){} // RVA: 0x7C77030
        public void FlexibleSpace(){} // RVA: 0x7C773A0
        public void BeginHorizontal(){} // RVA: 0x7C77920
        public void EndHorizontal(){} // RVA: 0x7C77AD0
        public void BeginVertical(){} // RVA: 0x7C77C30
        public void EndVertical(){} // RVA: 0x7C77DE0
        public void BeginArea(){} // RVA: 0x7C77EE0
        public void EndArea(){} // RVA: 0x7C781F0
        public void BeginScrollView(){} // RVA: 0x7C78490
        public void EndScrollView(){} // RVA: 0x7C78900
        public void Window(){} // RVA: 0x7C78980
        public void DoWindow(){} // RVA: 0x7C78AA0
        public void Width(){} // RVA: 0x7C78D90
        public void Height(){} // RVA: 0x7C78E50
        public void ExpandWidth(){} // RVA: 0x7C78F10
        public void ExpandHeight(){} // RVA: 0x7C78FC0
    }

    public class GUILayoutEntry : Object
    {
        // ── Methods ──
        public void get_style(){} // RVA: 0x7C7DFA0
        public void set_style(){} // RVA: 0x7C8BD40
        public void get_marginLeft(){} // RVA: 0x7C8BDB0
        public void get_marginRight(){} // RVA: 0x7C8BE40
        public void get_marginTop(){} // RVA: 0x7C8BED0
        public void get_marginBottom(){} // RVA: 0x7C8BF60
        public void get_marginHorizontal(){} // RVA: 0x7C8BFF0
        public void get_marginVertical(){} // RVA: 0x7C8C040
        public void .ctor(){} // RVA: 0x7C8C1B0
        public void CalcWidth(){} // RVA: 0xB43310
        public void CalcHeight(){} // RVA: 0xB43310
        public void SetHorizontal(){} // RVA: 0x7C8C2D0
        public void SetVertical(){} // RVA: 0x7C8C2E0
        public void ApplyStyleSettings(){} // RVA: 0x7C8C2F0
        public void ApplyOptions(){} // RVA: 0x7C8C3E0
        public void ToString(){} // RVA: 0x7C8C780
        public void .cctor(){} // RVA: 0x7C8CE00
    }

    public class GUILayoutEntry[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GUILayoutGroup : GUILayoutEntry
    {
        // ── Methods ──
        public void get_marginLeft(){} // RVA: 0xD34760
        public void get_marginRight(){} // RVA: 0xD34730
        public void get_marginTop(){} // RVA: 0x14780B0
        public void get_marginBottom(){} // RVA: 0x40A8A30
        public void .ctor(){} // RVA: 0x7C8DA60
        public void ApplyOptions(){} // RVA: 0x7C8DBE0
        public void ApplyStyleSettings(){} // RVA: 0x7C8DCE0
        public void ResetCursor(){} // RVA: 0x7C8DF40
        public void GetNext(){} // RVA: 0x7C8DF50
        public void Add(){} // RVA: 0x7C8E2B0
        public void CalcWidth(){} // RVA: 0x7C8E350
        public void SetHorizontal(){} // RVA: 0x7C8EC50
        public void CalcHeight(){} // RVA: 0x7C8F6A0
        public void SetVertical(){} // RVA: 0x7C8FF40
        public void ToString(){} // RVA: 0x7C90930
        public void .cctor(){} // RVA: 0x7C90D30
    }

    public class GUILayoutGroup[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GUILayoutOption : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2574280
    }

    public class GUILayoutUtility : Object
    {
        // ── Methods ──
        public void Internal_GetWindowRect(){} // RVA: 0x7C79310
        public void Internal_MoveWindow(){} // RVA: 0x7C793B0
        public void get_unbalancedgroupscount(){} // RVA: 0x7C79450
        public void set_unbalancedgroupscount(){} // RVA: 0x7C794B0
        public void GetLayoutCache(){} // RVA: 0x7C79510
        public void SelectIDList(){} // RVA: 0x7C795E0
        public void RemoveSelectedIdList(){} // RVA: 0x7C79940
        public void Begin(){} // RVA: 0x7C79A40
        public void BeginContainer(){} // RVA: 0x7C79F50
        public void BeginWindow(){} // RVA: 0x7C7A2E0
        public void Layout(){} // RVA: 0x7C7A8E0
        public void LayoutFromEditorWindow(){} // RVA: 0x7C7AC60
        public void LayoutFromContainer(){} // RVA: 0x7C7AFA0
        public void LayoutFreeGroup(){} // RVA: 0x7C7B190
        public void LayoutSingleGroup(){} // RVA: 0x7C7B390
        public void CreateGUILayoutGroupInstanceOfType(){} // RVA: 0x7C7B660
        public void BeginLayoutGroup(){} // RVA: 0x7C7B7D0
        public void EndLayoutGroup(){} // RVA: 0x7C7BBE0
        public void BeginLayoutArea(){} // RVA: 0x7C7BFC0
        public void EndLayoutArea(){} // RVA: 0x7C7C380
        public void GetRect(){} // RVA: 0x7C7CD10
        public void DoGetRect(){} // RVA: 0x7C7CDD0
        public void get_spaceStyle(){} // RVA: 0x7C7D060
        public void .cctor(){} // RVA: 0x7C7D250
        public void Internal_GetWindowRect_Injected(){} // RVA: 0x7C7D480
        public void Internal_MoveWindow_Injected(){} // RVA: 0x7C7D4E0
    }

    public class GUIScrollGroup : GUILayoutGroup
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7C90E60
        public void CalcWidth(){} // RVA: 0x7C90EC0
        public void SetHorizontal(){} // RVA: 0x7C90F60
        public void CalcHeight(){} // RVA: 0x7C91110
        public void SetVertical(){} // RVA: 0x7C91290
    }

    public class GUIScrollGroup[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GUISettings : Object
    {
        // ── Methods ──
        public void Internal_GetCursorFlashSpeed(){} // RVA: 0x7C7D950
        public void get_doubleClickSelectsWord(){} // RVA: 0x7C7D9A0
        public void get_tripleClickSelectsLine(){} // RVA: 0x7C7D9B0
        public void get_cursorColor(){} // RVA: 0x3922450
        public void get_cursorFlashSpeed(){} // RVA: 0x7C7D9C0
        public void get_selectionColor(){} // RVA: 0x7C7DA30
        public void .ctor(){} // RVA: 0x7C7DA40
    }

    public class GUISkin : ScriptableObject
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7C7DA70
        public void OnEnable(){} // RVA: 0x7C7DC20
        public void CleanupRoots(){} // RVA: 0x7C7DC30
        public void get_font(){} // RVA: 0x3926770
        public void set_font(){} // RVA: 0x7C7DD30
        public void get_box(){} // RVA: 0x7489A40
        public void set_box(){} // RVA: 0x7C7DED0
        public void get_label(){} // RVA: 0x7C7DF30
        public void set_label(){} // RVA: 0x7C7DF40
        public void get_textField(){} // RVA: 0x7C7DFA0
        public void set_textField(){} // RVA: 0x7C7DFB0
        public void get_textArea(){} // RVA: 0x7C7E010
        public void set_textArea(){} // RVA: 0x7C7E020
        public void get_button(){} // RVA: 0x7C246A0
        public void set_button(){} // RVA: 0x7C7E080
        public void get_toggle(){} // RVA: 0x7C24F60
        public void set_toggle(){} // RVA: 0x7C7E0E0
        public void get_window(){} // RVA: 0x7C7E140
        public void set_window(){} // RVA: 0x7C7E150
        public void get_horizontalSlider(){} // RVA: 0x7C7E1B0
        public void set_horizontalSlider(){} // RVA: 0x7C7E1C0
        public void get_horizontalSliderThumb(){} // RVA: 0x7C7E220
        public void set_horizontalSliderThumb(){} // RVA: 0x7C7E230
        public void get_horizontalSliderThumbExtent(){} // RVA: 0x7C7E290
        public void set_horizontalSliderThumbExtent(){} // RVA: 0x7C7E2A0
        public void get_sliderMixed(){} // RVA: 0x7C7E300
        public void set_sliderMixed(){} // RVA: 0x7C7E310
        public void get_verticalSlider(){} // RVA: 0x7C7E370
        public void set_verticalSlider(){} // RVA: 0x7C7E380
        public void get_verticalSliderThumb(){} // RVA: 0x7C7E3E0
        public void set_verticalSliderThumb(){} // RVA: 0x7C7E3F0
        public void get_verticalSliderThumbExtent(){} // RVA: 0x7C7E450
        public void set_verticalSliderThumbExtent(){} // RVA: 0x7C7E460
        public void get_horizontalScrollbar(){} // RVA: 0x7C7E4C0
        public void set_horizontalScrollbar(){} // RVA: 0x7C7E4D0
        public void get_horizontalScrollbarThumb(){} // RVA: 0x7C7E530
        public void set_horizontalScrollbarThumb(){} // RVA: 0x7C7E540
        public void get_horizontalScrollbarLeftButton(){} // RVA: 0x7C7E5A0
        public void set_horizontalScrollbarLeftButton(){} // RVA: 0x7C7E5B0
        public void get_horizontalScrollbarRightButton(){} // RVA: 0x7C7E610
        public void set_horizontalScrollbarRightButton(){} // RVA: 0x7C7E620
        public void get_verticalScrollbar(){} // RVA: 0x7C7E680
        public void set_verticalScrollbar(){} // RVA: 0x7C7E690
        public void get_verticalScrollbarThumb(){} // RVA: 0x7C7E6F0
        public void set_verticalScrollbarThumb(){} // RVA: 0x7C7E700
        public void get_verticalScrollbarUpButton(){} // RVA: 0x7C7E760
        public void set_verticalScrollbarUpButton(){} // RVA: 0x7C7E770
        public void get_verticalScrollbarDownButton(){} // RVA: 0x7C7E7D0
        public void set_verticalScrollbarDownButton(){} // RVA: 0x7C7E7E0
        public void get_scrollView(){} // RVA: 0x7C7E840
        public void set_scrollView(){} // RVA: 0x7C7E850
        public void get_customStyles(){} // RVA: 0x7C7E8B0
        public void set_customStyles(){} // RVA: 0x7C7E8C0
        public void get_settings(){} // RVA: 0x7C7E920
        public void get_error(){} // RVA: 0x7C7E930
        public void Apply(){} // RVA: 0x7C7EA60
        public void BuildStyleCache(){} // RVA: 0x7C7EAE0
        public void GetStyle(){} // RVA: 0x7C80710
        public void FindStyle(){} // RVA: 0x7C80A00
        public void MakeCurrent(){} // RVA: 0x7C80AA0
        public void GetEnumerator(){} // RVA: 0x7C80BA0
    }

    public class GUISkin[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GUIStateObjects : Object
    {
        // ── Methods ──
        public void GetStateObject(){} // RVA: 0x7C80CE0
        public void .cctor(){} // RVA: 0x7C80E50
    }

    public class GUIStyle : Object
    {
        // ── Methods ──
        public void get_rawName(){} // RVA: 0x7C81400
        public void set_rawName(){} // RVA: 0x7C81540
        public void get_font(){} // RVA: 0x7C816E0
        public void get_imagePosition(){} // RVA: 0x7C817B0
        public void get_alignment(){} // RVA: 0x7C81860
        public void get_wordWrap(){} // RVA: 0x7C81910
        public void get_clipping(){} // RVA: 0x7C819C0
        public void get_contentOffset(){} // RVA: 0x7C81A70
        public void set_contentOffset(){} // RVA: 0x7C81B30
        public void get_fixedWidth(){} // RVA: 0x7C81BF0
        public void get_fixedHeight(){} // RVA: 0x7C81CA0
        public void get_stretchWidth(){} // RVA: 0x7C81D50
        public void set_stretchWidth(){} // RVA: 0x7C81E00
        public void get_stretchHeight(){} // RVA: 0x7C81EC0
        public void set_stretchHeight(){} // RVA: 0x7C81F70
        public void get_fontSize(){} // RVA: 0x7C82030
        public void get_fontStyle(){} // RVA: 0x7C820E0
        public void get_richText(){} // RVA: 0x7C82190
        public void get_Internal_clipOffset(){} // RVA: 0x7C82240
        public void set_Internal_clipOffset(){} // RVA: 0x7C82300
        public void Internal_Create(){} // RVA: 0x7C823C0
        public void Internal_Copy(){} // RVA: 0x7C82410
        public void Internal_Destroy(){} // RVA: 0x7C824B0
        public void GetStyleStatePtr(){} // RVA: 0x7C82500
        public void GetRectOffsetPtr(){} // RVA: 0x7C825C0
        public void Internal_Draw(){} // RVA: 0x7C82680
        public void Internal_Draw2(){} // RVA: 0x7C82790
        public void Internal_DrawCursor(){} // RVA: 0x7C82890
        public void Internal_DrawWithTextSelection(){} // RVA: 0x7C82980
        public void Internal_CalcSize(){} // RVA: 0x7C82AE0
        public void Internal_CalcSizeWithConstraints(){} // RVA: 0x7C82BB0
        public void Internal_CalcHeight(){} // RVA: 0x7C82C90
        public void Internal_CalcMinMaxWidth(){} // RVA: 0x7C82D60
        public void Internal_GetTextRectOffset(){} // RVA: 0x7C82E30
        public void SetMouseTooltip(){} // RVA: 0x7C82F20
        public void IsTooltipActive(){} // RVA: 0x7C83090
        public void Internal_GetCursorFlashOffset(){} // RVA: 0x7C83200
        public void SetDefaultFont(){} // RVA: 0x7C83250
        public void GetDefaultFont(){} // RVA: 0x7C83310
        public void Internal_DestroyTextGenerator(){} // RVA: 0x7C833B0
        public void .ctor(){} // RVA: 0x7C83490
        public void Finalize(){} // RVA: 0x7C835C0
        public void get_name(){} // RVA: 0x7C83690
        public void set_name(){} // RVA: 0x7C83700
        public void get_normal(){} // RVA: 0x7C83760
        public void get_border(){} // RVA: 0x7C83900
        public void get_margin(){} // RVA: 0x7C83A30
        public void get_padding(){} // RVA: 0x7C83B60
        public void get_lineHeight(){} // RVA: 0x7C83C90
        public void Draw(){} // RVA: 0x7C84250
        public void DrawCursor(){} // RVA: 0x7C84430
        public void DrawWithTextSelection(){} // RVA: 0x7C84FD0
        public void get_none(){} // RVA: 0x7C85010
        public void GetCursorPixelPosition(){} // RVA: 0x7C85110
        public void CalcSize(){} // RVA: 0x7C82AE0
        public void CalcSizeWithConstraints(){} // RVA: 0x7C854B0
        public void CalcHeight(){} // RVA: 0x7C82C90
        public void GetPreferredSize(){} // RVA: 0x7C855C0
        public void get_isHeightDependantOnWidth(){} // RVA: 0x7C85710
        public void CalcMinMaxWidth(){} // RVA: 0x7C85760
        public void ToString(){} // RVA: 0x7C85850
        public void GetMeshInfo(){} // RVA: 0x7C85910
        public void GetDimensions(){} // RVA: 0x7C85EF0
        public void GetLineHeight(){} // RVA: 0x7C85F30
        public void EmptyManagedCache(){} // RVA: 0x7C85F60
        public void .cctor(){} // RVA: 0x7C86050
        public void get_rawName_Injected(){} // RVA: 0x7C86090
        public void set_rawName_Injected(){} // RVA: 0x7C860F0
        public void get_font_Injected(){} // RVA: 0x7C86150
        public void get_imagePosition_Injected(){} // RVA: 0x7C861A0
        public void get_alignment_Injected(){} // RVA: 0x7C861F0
        public void get_wordWrap_Injected(){} // RVA: 0x7C86240
        public void get_clipping_Injected(){} // RVA: 0x7C86290
        public void get_contentOffset_Injected(){} // RVA: 0x7C862E0
        public void set_contentOffset_Injected(){} // RVA: 0x7C86340
        public void get_fixedWidth_Injected(){} // RVA: 0x7C863A0
        public void get_fixedHeight_Injected(){} // RVA: 0x7C863F0
        public void get_stretchWidth_Injected(){} // RVA: 0x7C86440
        public void set_stretchWidth_Injected(){} // RVA: 0x7C86490
        public void get_stretchHeight_Injected(){} // RVA: 0x7C864F0
        public void set_stretchHeight_Injected(){} // RVA: 0x7C86540
        public void get_fontSize_Injected(){} // RVA: 0x7C865A0
        public void get_fontStyle_Injected(){} // RVA: 0x7C865F0
        public void get_richText_Injected(){} // RVA: 0x7C86640
        public void get_Internal_clipOffset_Injected(){} // RVA: 0x7C86690
        public void set_Internal_clipOffset_Injected(){} // RVA: 0x7C866F0
        public void Internal_Copy_Injected(){} // RVA: 0x7C86750
        public void GetStyleStatePtr_Injected(){} // RVA: 0x7C867B0
        public void GetRectOffsetPtr_Injected(){} // RVA: 0x7C86810
        public void Internal_Draw_Injected(){} // RVA: 0x7C86870
        public void Internal_Draw2_Injected(){} // RVA: 0x7C86920
        public void Internal_DrawCursor_Injected(){} // RVA: 0x7C869B0
        public void Internal_DrawWithTextSelection_Injected(){} // RVA: 0x7C86A40
        public void Internal_CalcSize_Injected(){} // RVA: 0x7C86B10
        public void Internal_CalcSizeWithConstraints_Injected(){} // RVA: 0x7C86B80
        public void Internal_CalcHeight_Injected(){} // RVA: 0x7C86C00
        public void Internal_CalcMinMaxWidth_Injected(){} // RVA: 0x7C86C70
        public void Internal_GetTextRectOffset_Injected(){} // RVA: 0x7C86CE0
        public void SetMouseTooltip_Injected(){} // RVA: 0x7C86D70
        public void IsTooltipActive_Injected(){} // RVA: 0x7C86DD0
        public void SetDefaultFont_Injected(){} // RVA: 0x7C86E20
        public void GetDefaultFont_Injected(){} // RVA: 0x7C86E70
    }

    public class GUIStyleState : Object
    {
        // ── Methods ──
        public void set_background(){} // RVA: 0x7C80F30
        public void set_textColor(){} // RVA: 0x7C81000
        public void Init(){} // RVA: 0x7C81080
        public void Cleanup(){} // RVA: 0x7C810D0
        public void .ctor(){} // RVA: 0x7B74A10
        public void GetGUIStyleState(){} // RVA: 0x7C81190
        public void Finalize(){} // RVA: 0x7C81250
        public void set_background_Injected(){} // RVA: 0x7C812F0
        public void set_textColor_Injected(){} // RVA: 0x7C81350
        public void Cleanup_Injected(){} // RVA: 0x7C813B0
    }

    public class GUIStyle[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GUITargetAttribute : Attribute
    {
        // ── Methods ──
        public void GetGUITargetAttrValue(){} // RVA: 0x7C87040
    }

    public class GUITargetAttribute[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GUIText : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class GUITexture : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class GUIUtility : Object
    {
        // ── Methods ──
        public void get_pixelsPerPoint(){} // RVA: 0x7C87270
        public void set_pixelsPerPoint(){} // RVA: 0x7C872C0
        public void get_guiDepth(){} // RVA: 0x7C87320
        public void set_mouseUsed(){} // RVA: 0x7C87370
        public void get_textFieldInput(){} // RVA: 0x7C873C0
        public void set_textFieldInput(){} // RVA: 0x7C87410
        public void get_systemCopyBuffer(){} // RVA: 0x7C87460
        public void set_systemCopyBuffer(){} // RVA: 0x7C87560
        public void Internal_GetControlID(){} // RVA: 0x7C876C0
        public void GetControlID(){} // RVA: 0x7C88110
        public void BeginContainerFromOwner(){} // RVA: 0x7C87860
        public void BeginContainer(){} // RVA: 0x7C87920
        public void Internal_EndContainer(){} // RVA: 0x7C879B0
        public void CheckForTabEvent(){} // RVA: 0x7C87A00
        public void SetKeyboardControlToFirstControlId(){} // RVA: 0x7C87A90
        public void SetKeyboardControlToLastControlId(){} // RVA: 0x7C87AE0
        public void HasFocusableControls(){} // RVA: 0x7C87B30
        public void OwnsId(){} // RVA: 0x7C87B80
        public void AlignRectToDevice(){} // RVA: 0x7C89AA0
        public void get_compositionString(){} // RVA: 0x7C87C90
        public void set_imeCompositionMode(){} // RVA: 0x7C87D90
        public void set_compositionCursorPos(){} // RVA: 0x7C87DE0
        public void Internal_GetHotControl(){} // RVA: 0x7C87E70
        public void Internal_GetKeyboardControl(){} // RVA: 0x7C87EC0
        public void Internal_SetHotControl(){} // RVA: 0x7C87F10
        public void Internal_SetKeyboardControl(){} // RVA: 0x7C87F60
        public void Internal_GetDefaultSkin(){} // RVA: 0x7C87FB0
        public void Internal_ExitGUI(){} // RVA: 0x7C88000
        public void MarkGUIChanged(){} // RVA: 0x7C88050
        public void GetStateObject(){} // RVA: 0x7C88190
        public void set_guiIsExiting(){} // RVA: 0x7C88340
        public void get_hotControl(){} // RVA: 0x7C883A0
        public void set_hotControl(){} // RVA: 0x7C88420
        public void TakeCapture(){} // RVA: 0x7C884B0
        public void RemoveCapture(){} // RVA: 0x7C88520
        public void get_keyboardControl(){} // RVA: 0x7C88590
        public void set_keyboardControl(){} // RVA: 0x7C88610
        public void HasKeyFocus(){} // RVA: 0x7C886A0
        public void ExitGUI(){} // RVA: 0x7C88780
        public void GetDefaultSkin(){} // RVA: 0x7C887C0
        public void ProcessEvent(){} // RVA: 0x7C88890
        public void EndContainer(){} // RVA: 0x7C88BD0
        public void BeginGUI(){} // RVA: 0x7C88C90
        public void DestroyGUI(){} // RVA: 0x7C88D50
        public void EndGUI(){} // RVA: 0x7C88E50
        public void EndGUIFromException(){} // RVA: 0x7C89080
        public void EndContainerGUIFromException(){} // RVA: 0x7C89110
        public void ResetGlobalState(){} // RVA: 0x7C891B0
        public void IsExitGUIException(){} // RVA: 0x7C89310
        public void ShouldRethrowException(){} // RVA: 0x7C89390
        public void CheckOnGUI(){} // RVA: 0x7C89450
        public void RoundToPixelGrid(){} // RVA: 0x7C89530
        public void ScaleAroundPivot(){} // RVA: 0x7C89620
        public void HitTest(){} // RVA: 0x7C89CF0
        public void .cctor(){} // RVA: 0x7C89DF0
        public void get_systemCopyBuffer_Injected(){} // RVA: 0x7C89F00
        public void set_systemCopyBuffer_Injected(){} // RVA: 0x7C89F50
        public void Internal_GetControlID_Injected(){} // RVA: 0x7C89FA0
        public void BeginContainerFromOwner_Injected(){} // RVA: 0x7C8A010
        public void BeginContainer_Injected(){} // RVA: 0x7C8A060
        public void CheckForTabEvent_Injected(){} // RVA: 0x7C8A0B0
        public void AlignRectToDevice_Injected(){} // RVA: 0x7C8A100
        public void get_compositionString_Injected(){} // RVA: 0x7C8A180
        public void set_compositionCursorPos_Injected(){} // RVA: 0x7C8A1D0
    }

    public class GUIUtility[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GUIWordWrapSizer : GUILayoutEntry
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7C8D750
        public void CalcWidth(){} // RVA: 0x7C8D880
        public void CalcHeight(){} // RVA: 0x7C8D9E0
    }

    public class GUI[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GameObject : Object
    {
        // ── Methods ──
        public void CreatePrimitive(){} // RVA: 0x7BFEE10
        public void GetComponent(){} // RVA: 0x30DA9F0
        public void GetComponentFastPath(){} // RVA: 0x7BFEF60
        public void GetComponentByName(){} // RVA: 0x7BFF020
        public void GetComponentByNameWithCase(){} // RVA: 0x7BFF200
        public void GetComponentInChildren(){} // RVA: 0x30DAF50
        public void GetComponentInParent(){} // RVA: 0x30DB2C0
        public void GetComponentsInternal(){} // RVA: 0x7BFF5E0
        public void GetComponents(){} // RVA: 0x30DB770
        public void GetComponentsInChildren(){} // RVA: 0x30DB9C0
        public void GetComponentsInParent(){} // RVA: 0x30DBAC0
        public void TryGetComponent(){} // RVA: 0x30DBC90
        public void TryGetComponentInternal(){} // RVA: 0x7BFFB90
        public void TryGetComponentFastPath(){} // RVA: 0x7BFFC60
        public void FindWithTag(){} // RVA: 0x7BFFD20
        public void FindGameObjectsWithTagForListInternal(){} // RVA: 0x7BFFD30
        public void FindGameObjectsWithTag(){} // RVA: 0x7C014D0
        public void SendMessageUpwards(){} // RVA: 0x7C017D0
        public void SendMessage(){} // RVA: 0x7C019B0
        public void BroadcastMessage(){} // RVA: 0x7C01B90
        public void AddComponentInternal(){} // RVA: 0x7BFFEF0
        public void Internal_AddComponentWithType(){} // RVA: 0x7C000D0
        public void AddComponent(){} // RVA: 0x30DA930
        public void GetComponentCount(){} // RVA: 0x7C001A0
        public void QueryComponentAtIndex(){} // RVA: 0x7C00240
        public void GetComponentAtIndex(){} // RVA: 0xA94080
        public void GetComponentIndex(){} // RVA: 0x7C00460
        public void get_transform(){} // RVA: 0x7C00540
        public void get_layer(){} // RVA: 0x7C00600
        public void set_layer(){} // RVA: 0x7C006A0
        public void get_active(){} // RVA: 0x7C00750
        public void set_active(){} // RVA: 0x7C007F0
        public void SetActive(){} // RVA: 0x7C008A0
        public void get_activeSelf(){} // RVA: 0x7C00950
        public void get_activeInHierarchy(){} // RVA: 0x7C009F0
        public void SetActiveRecursively(){} // RVA: 0x7C00A90
        public void get_isStatic(){} // RVA: 0x7C00B40
        public void set_isStatic(){} // RVA: 0x7C00BE0
        public void get_isStaticBatchable(){} // RVA: 0x7C00C90
        public void get_tag(){} // RVA: 0x7C00D30
        public void set_tag(){} // RVA: 0x7C00E60
        public void CompareTag(){} // RVA: 0x7C01000
        public void CompareTag_Internal(){} // RVA: 0x7C010B0
        public void CompareTagHandle_Internal(){} // RVA: 0x7C01240
        public void FindGameObjectWithTag(){} // RVA: 0x7C012F0
        public void .ctor(){} // RVA: 0x7C01C70
        public void Internal_CreateGameObject(){} // RVA: 0x7C01DD0
        public void Find(){} // RVA: 0x7C01F20
        public void SetGameObjectsActive(){} // RVA: 0x7C02200
        public void InstantiateGameObjects(){} // RVA: 0x7C02300
        public void GetScene(){} // RVA: 0x7C02510
        public void get_scene(){} // RVA: 0x7C02570
        public void get_sceneCullingMask(){} // RVA: 0x7C02620
        public void get_gameObject(){} // RVA: 0x697DBA0
        public void CreatePrimitive_Injected(){} // RVA: 0x7C026C0
        public void GetComponent_Injected(){} // RVA: 0x7C02710
        public void GetComponentFastPath_Injected(){} // RVA: 0x7C02770
        public void GetComponentByName_Injected(){} // RVA: 0x7C027E0
        public void GetComponentByNameWithCase_Injected(){} // RVA: 0x7C02840
        public void GetComponentInChildren_Injected(){} // RVA: 0x7C028B0
        public void GetComponentInParent_Injected(){} // RVA: 0x7C02920
        public void GetComponentsInternal_Injected(){} // RVA: 0x7C02990
        public void TryGetComponentInternal_Injected(){} // RVA: 0x7C02A30
        public void TryGetComponentFastPath_Injected(){} // RVA: 0x7C02A90
        public void FindGameObjectsWithTagForListInternal_Injected(){} // RVA: 0x7C02B00
        public void AddComponentInternal_Injected(){} // RVA: 0x7C02B60
        public void Internal_AddComponentWithType_Injected(){} // RVA: 0x7C02BC0
        public void GetComponentCount_Injected(){} // RVA: 0x7C02C20
        public void QueryComponentAtIndex_Injected(){} // RVA: 0x7C02C70
        public void GetComponentIndex_Injected(){} // RVA: 0x7C02CD0
        public void get_transform_Injected(){} // RVA: 0x7C02D30
        public void get_layer_Injected(){} // RVA: 0x7C02D80
        public void set_layer_Injected(){} // RVA: 0x7C02DD0
        public void get_active_Injected(){} // RVA: 0x7C02E30
        public void set_active_Injected(){} // RVA: 0x7C02E80
        public void SetActive_Injected(){} // RVA: 0x7C02EE0
        public void get_activeSelf_Injected(){} // RVA: 0x7C02F40
        public void get_activeInHierarchy_Injected(){} // RVA: 0x7C02F90
        public void SetActiveRecursively_Injected(){} // RVA: 0x7C02FE0
        public void get_isStatic_Injected(){} // RVA: 0x7C03040
        public void set_isStatic_Injected(){} // RVA: 0x7C03090
        public void get_isStaticBatchable_Injected(){} // RVA: 0x7C030F0
        public void get_tag_Injected(){} // RVA: 0x7C03140
        public void set_tag_Injected(){} // RVA: 0x7C031A0
        public void CompareTag_Internal_Injected(){} // RVA: 0x7C03200
        public void CompareTagHandle_Internal_Injected(){} // RVA: 0x7C03260
        public void FindGameObjectWithTag_Injected(){} // RVA: 0x7C032C0
        public void FindGameObjectsWithTag_Injected(){} // RVA: 0x7C03310
        public void SendMessageUpwards_Injected(){} // RVA: 0x7C03360
        public void SendMessage_Injected(){} // RVA: 0x7C033E0
        public void BroadcastMessage_Injected(){} // RVA: 0x7C03460
        public void Internal_CreateGameObject_Injected(){} // RVA: 0x7C034E0
        public void Find_Injected(){} // RVA: 0x7C03540
        public void InstantiateGameObjects_Injected(){} // RVA: 0x7C03590
        public void GetScene_Injected(){} // RVA: 0x7C03610
        public void get_scene_Injected(){} // RVA: 0x7C03670
        public void get_sceneCullingMask_Injected(){} // RVA: 0x7C036D0
    }

    public class GameObject[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GeometryUtility : Object
    {
        // ── Methods ──
        public void CalculateFrustumPlanes(){} // RVA: 0x7B71640
        public void CalculateBounds(){} // RVA: 0x7B71740
        public void TryCreatePlaneFromPolygon(){} // RVA: 0x7B71930
        public void TestPlanesAABB(){} // RVA: 0x7B71DD0
        public void Internal_ExtractPlanes(){} // RVA: 0x7B71EB0
        public void Internal_CalculateBounds(){} // RVA: 0x7B72100
        public void .ctor(){} // RVA: 0xB43310
        public void TestPlanesAABB_Injected(){} // RVA: 0x7B72200
        public void Internal_ExtractPlanes_Injected(){} // RVA: 0x7B72260
        public void Internal_CalculateBounds_Injected(){} // RVA: 0x7B722C0
    }

    public class Gizmos : Object
    {
        // ── Methods ──
        public void DrawLine(){} // RVA: 0x7B75D10
        public void DrawWireSphere(){} // RVA: 0x7B75D70
        public void DrawSphere(){} // RVA: 0x7B75DD0
        public void DrawWireCube(){} // RVA: 0x7B75E30
        public void DrawCube(){} // RVA: 0x7B75E90
        public void DrawMesh(){} // RVA: 0x7B76900
        public void DrawWireMesh(){} // RVA: 0x7B77160
        public void DrawIcon(){} // RVA: 0x7B772F0
        public void DrawGUITexture(){} // RVA: 0x7B77520
        public void get_color(){} // RVA: 0x7B76350
        public void set_color(){} // RVA: 0x7B763B0
        public void get_matrix(){} // RVA: 0x7B76400
        public void set_matrix(){} // RVA: 0x7B76470
        public void get_probeSize(){} // RVA: 0x7B764C0
        public void DrawFrustum(){} // RVA: 0x7B76510
        public void CalculateLOD(){} // RVA: 0x7B765B0
        public void DrawRay(){} // RVA: 0x7B766C0
        public void .ctor(){} // RVA: 0xB43310
        public void DrawLine_Injected(){} // RVA: 0x7B77620
        public void DrawWireSphere_Injected(){} // RVA: 0x7B77680
        public void DrawSphere_Injected(){} // RVA: 0x7B776E0
        public void DrawWireCube_Injected(){} // RVA: 0x7B77740
        public void DrawCube_Injected(){} // RVA: 0x7B777A0
        public void DrawMesh_Injected(){} // RVA: 0x7B77800
        public void DrawWireMesh_Injected(){} // RVA: 0x7B77880
        public void DrawIcon_Injected(){} // RVA: 0x7B77900
        public void DrawGUITexture_Injected(){} // RVA: 0x7B77980
        public void get_color_Injected(){} // RVA: 0x7B77A10
        public void set_color_Injected(){} // RVA: 0x7B77A60
        public void get_matrix_Injected(){} // RVA: 0x7B77AB0
        public void set_matrix_Injected(){} // RVA: 0x7B77B00
        public void DrawFrustum_Injected(){} // RVA: 0x7B77B50
        public void CalculateLOD_Injected(){} // RVA: 0x7B77BE0
    }

    public class GlobalJavaObjectRef : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE83D0
        public void Finalize(){} // RVA: 0x7AE8450
        public void op_Implicit(){} // RVA: 0x18E1A10
        public void Dispose(){} // RVA: 0x7AE8490
    }

    public class Gradient : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7BE26B0
        public void Cleanup(){} // RVA: 0x7BE2700
        public void Internal_Equals(){} // RVA: 0x7BE2770
        public void .ctor(){} // RVA: 0x7BE2850
        public void Finalize(){} // RVA: 0x7BE2860
        public void Evaluate(){} // RVA: 0x7BE2900
        public void get_colorKeys(){} // RVA: 0x7BE29A0
        public void set_colorKeys(){} // RVA: 0x7BE2C10
        public void get_alphaKeys(){} // RVA: 0x7BE2D20
        public void set_alphaKeys(){} // RVA: 0x7BE2F90
        public void get_mode(){} // RVA: 0x7BE30A0
        public void set_mode(){} // RVA: 0x7BE3110
        public void get_colorSpace(){} // RVA: 0x7BE3190
        public void set_colorSpace(){} // RVA: 0x7BE3200
        public void SetKeys(){} // RVA: 0x7BE3280
        public void Equals(){} // RVA: 0x7BE3510
        public void GetHashCode(){} // RVA: 0x7B51740
        public void Cleanup_Injected(){} // RVA: 0x7BE3630
        public void Internal_Equals_Injected(){} // RVA: 0x7BE3680
        public void Evaluate_Injected(){} // RVA: 0x7BE36E0
        public void get_colorKeys_Injected(){} // RVA: 0x7BE3750
        public void set_colorKeys_Injected(){} // RVA: 0x7BE37B0
        public void get_alphaKeys_Injected(){} // RVA: 0x7BE3810
        public void set_alphaKeys_Injected(){} // RVA: 0x7BE3870
        public void get_mode_Injected(){} // RVA: 0x7BE38D0
        public void set_mode_Injected(){} // RVA: 0x7BE3920
        public void get_colorSpace_Injected(){} // RVA: 0x7BE3980
        public void set_colorSpace_Injected(){} // RVA: 0x7BE39D0
        public void SetKeys_Injected(){} // RVA: 0x7BE3A30
    }

    public class GradientAlphaKey : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7C540
    }

    public class GradientAlphaKey[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAC7E0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7C490
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC7BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E57A40
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7C490
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class GradientColorKey : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x963E80
    }

    public class GradientColorKey[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7E520
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A9B0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC42A0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E34760
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A9B0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Gradient[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Graphics : Object
    {
        // ── Methods ──
        public void Internal_GetMaxDrawMeshInstanceCount(){} // RVA: 0x7B7A830
        public void Internal_SetNullRT(){} // RVA: 0x7B7A880
        public void Internal_SetRTSimple(){} // RVA: 0x7B7A8D0
        public void Internal_SetRandomWriteTargetBuffer(){} // RVA: 0x7B7A990
        public void ClearRandomWriteTargets(){} // RVA: 0x7B7AA40
        public void CopyTexture_Full(){} // RVA: 0x7B7AA90
        public void CopyTexture_Slice(){} // RVA: 0x7B7AB80
        public void CopyTexture_Region(){} // RVA: 0x7B7ACA0
        public void ConvertTexture_Full(){} // RVA: 0x7B7ADD0
        public void Internal_DrawMeshNow2(){} // RVA: 0x7B7AEC0
        public void Internal_DrawTexture(){} // RVA: 0x7B7AFD0
        public void Internal_RenderMeshPrimitives(){} // RVA: 0x7B7B020
        public void Internal_DrawMesh(){} // RVA: 0x7B7B140
        public void Internal_DrawMeshInstanced(){} // RVA: 0x7B7B380
        public void Internal_DrawProcedural(){} // RVA: 0x7B7B660
        public void Internal_DrawProceduralIndirect(){} // RVA: 0x7B7B7E0
        public void Internal_BlitMaterial5(){} // RVA: 0x7B7B970
        public void Internal_BlitMaterial6(){} // RVA: 0x7B7BB00
        public void Blit2(){} // RVA: 0x7B7BC90
        public void Blit3(){} // RVA: 0x7B7BD90
        public void Blit4(){} // RVA: 0x7B7BEB0
        public void Blit5(){} // RVA: 0x7B7BFD0
        public void CreateGPUFenceImpl(){} // RVA: 0x7B7C100
        public void ExecuteCommandBuffer(){} // RVA: 0x7B7C160
        public void ExecuteCommandBufferAsync(){} // RVA: 0x7B7C240
        public void SetRenderTargetImpl(){} // RVA: 0x7B7C430
        public void SetRenderTarget(){} // RVA: 0x7B7FD10
        public void SetRandomWriteTarget(){} // RVA: 0x7B7FD90
        public void CopyTexture(){} // RVA: 0x7B7CCE0
        public void ConvertTexture(){} // RVA: 0x7B7CE40
        public void CreateGraphicsFence(){} // RVA: 0x7B7CF70
        public void DrawTextureImpl(){} // RVA: 0x7B7D0E0
        public void DrawTexture(){} // RVA: 0x7B7FB50
        public void RenderMeshPrimitives(){} // RVA: 0x7B7D730
        public void DrawMeshNow(){} // RVA: 0x7B7DC00
        public void DrawMesh(){} // RVA: 0x7B7F6A0
        public void DrawMeshInstanced(){} // RVA: 0x7B7E1F0
        public void DrawProcedural(){} // RVA: 0x7B7E880
        public void DrawProceduralIndirect(){} // RVA: 0x7B7EA50
        public void Blit(){} // RVA: 0x7B7F5F0
        public void .cctor(){} // RVA: 0x7B7FDF0
        public void Internal_SetRTSimple_Injected(){} // RVA: 0x7B7FFA0
        public void Internal_SetRandomWriteTargetBuffer_Injected(){} // RVA: 0x7B80030
        public void CopyTexture_Full_Injected(){} // RVA: 0x7B800A0
        public void CopyTexture_Slice_Injected(){} // RVA: 0x7B80100
        public void CopyTexture_Region_Injected(){} // RVA: 0x7B80180
        public void ConvertTexture_Full_Injected(){} // RVA: 0x7B80210
        public void Internal_DrawMeshNow2_Injected(){} // RVA: 0x7B80270
        public void Internal_RenderMeshPrimitives_Injected(){} // RVA: 0x7B802E0
        public void Internal_DrawMesh_Injected(){} // RVA: 0x7B80360
        public void Internal_DrawMeshInstanced_Injected(){} // RVA: 0x7B80400
        public void Internal_DrawProcedural_Injected(){} // RVA: 0x7B804A0
        public void Internal_DrawProceduralIndirect_Injected(){} // RVA: 0x7B80530
        public void Internal_BlitMaterial5_Injected(){} // RVA: 0x7B805C0
        public void Internal_BlitMaterial6_Injected(){} // RVA: 0x7B80650
        public void Blit2_Injected(){} // RVA: 0x7B806E0
        public void Blit3_Injected(){} // RVA: 0x7B80740
        public void Blit4_Injected(){} // RVA: 0x7B807C0
        public void Blit5_Injected(){} // RVA: 0x7B80840
        public void ExecuteCommandBuffer_Injected(){} // RVA: 0x7B808D0
        public void ExecuteCommandBufferAsync_Injected(){} // RVA: 0x7B80920
    }

    public class GraphicsBuffer : Object
    {
        // ── Methods ──
        public void Finalize(){} // RVA: 0x7BA71D0
        public void Dispose(){} // RVA: 0x7BA7350
        public void RequiresCompute(){} // RVA: 0x7BA7440
        public void IsVertexIndexOrCopyOnly(){} // RVA: 0x7BA7450
        public void InitBuffer(){} // RVA: 0x7BA7460
        public void DestroyBuffer(){} // RVA: 0x7BA74E0
        public void .ctor(){} // RVA: 0x7BA7570
        public void InternalInitialization(){} // RVA: 0x7BA7580
        public void Release(){} // RVA: 0x7BA79D0
        public void IsValidBuffer(){} // RVA: 0x7BA79E0
        public void IsValid(){} // RVA: 0x7BA7A40
        public void get_count(){} // RVA: 0x7BA7AB0
        public void get_stride(){} // RVA: 0x7BA7B20
        public void GetUsageFlags(){} // RVA: 0x7BA7B90
        public void get_usageFlags(){} // RVA: 0x7BA7B90
        public void SetData(){} // RVA: 0x30DD4D0
        public void InternalSetNativeData(){} // RVA: 0x7BA7E00
        public void InternalSetData(){} // RVA: 0x7BA7EA0
        public void GetNativeBufferPtr(){} // RVA: 0x7BA7F40
        public void BeginBufferWrite(){} // RVA: 0x7BA7FB0
        public void LockBufferForWrite(){} // RVA: 0x30DCF80
        public void EndBufferWrite(){} // RVA: 0x7BA8040
        public void UnlockBufferAfterWrite(){} // RVA: 0x30DDAE0
        public void DestroyBuffer_Injected(){} // RVA: 0x7BA80C0
        public void IsValidBuffer_Injected(){} // RVA: 0x7BA8110
        public void get_count_Injected(){} // RVA: 0x7BA8160
        public void get_stride_Injected(){} // RVA: 0x7BA81B0
        public void GetUsageFlags_Injected(){} // RVA: 0x7BA8200
        public void InternalSetNativeData_Injected(){} // RVA: 0x7BA8250
        public void InternalSetData_Injected(){} // RVA: 0x7BA82E0
        public void GetNativeBufferPtr_Injected(){} // RVA: 0x7BA8370
        public void BeginBufferWrite_Injected(){} // RVA: 0x7BA83C0
        public void EndBufferWrite_Injected(){} // RVA: 0x7BA8430
    }

    public class GraphicsBufferHandle : ValueType
    {
        // ── Methods ──
        public void GetHashCode(){} // RVA: 0x454FE0
        public void Equals(){} // RVA: 0x95FA90
    }

    public class GraphicsBuffer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class Grid : GridLayout
    {
        // ── Methods ──
        public void GetCellCenterLocal(){} // RVA: 0x7C55940
        public void GetCellCenterWorld(){} // RVA: 0x7C55B40
        public void get_cellSize(){} // RVA: 0x7C55DE0
        public void set_cellSize(){} // RVA: 0x7C55EA0
        public void get_cellGap(){} // RVA: 0x7C55F50
        public void set_cellGap(){} // RVA: 0x7C56010
        public void get_cellLayout(){} // RVA: 0x7C560C0
        public void set_cellLayout(){} // RVA: 0x7C56160
        public void get_cellSwizzle(){} // RVA: 0x7C56210
        public void set_cellSwizzle(){} // RVA: 0x7C562B0
        public void Swizzle(){} // RVA: 0x7C56360
        public void InverseSwizzle(){} // RVA: 0x7C563E0
        public void .ctor(){} // RVA: 0xB43D60
        public void get_cellSize_Injected(){} // RVA: 0x7C56460
        public void set_cellSize_Injected(){} // RVA: 0x7C564C0
        public void get_cellGap_Injected(){} // RVA: 0x7C56520
        public void set_cellGap_Injected(){} // RVA: 0x7C56580
        public void get_cellLayout_Injected(){} // RVA: 0x7C565E0
        public void set_cellLayout_Injected(){} // RVA: 0x7C56630
        public void get_cellSwizzle_Injected(){} // RVA: 0x7C56690
        public void set_cellSwizzle_Injected(){} // RVA: 0x7C566E0
        public void Swizzle_Injected(){} // RVA: 0x7C56740
        public void InverseSwizzle_Injected(){} // RVA: 0x7C567B0
    }

    public class GridLayout : Behaviour
    {
        // ── Methods ──
        public void get_cellSize(){} // RVA: 0x7C56820
        public void get_cellGap(){} // RVA: 0x7C568E0
        public void get_cellLayout(){} // RVA: 0x7C569A0
        public void get_cellSwizzle(){} // RVA: 0x7C56A40
        public void GetBoundsLocal(){} // RVA: 0x7C56BB0
        public void GetBoundsLocalOriginSize(){} // RVA: 0x7C56CC0
        public void CellToLocal(){} // RVA: 0x7C56DA0
        public void LocalToCell(){} // RVA: 0x7C56E70
        public void CellToLocalInterpolated(){} // RVA: 0x7C56F40
        public void LocalToCellInterpolated(){} // RVA: 0x7C57010
        public void CellToWorld(){} // RVA: 0x7C570E0
        public void WorldToCell(){} // RVA: 0x7C571B0
        public void LocalToWorld(){} // RVA: 0x7C57280
        public void WorldToLocal(){} // RVA: 0x7C57350
        public void GetLayoutCellCenter(){} // RVA: 0x7C57420
        public void DoNothing(){} // RVA: 0xB43310
        public void .ctor(){} // RVA: 0xB43D60
        public void get_cellSize_Injected(){} // RVA: 0x7C574E0
        public void get_cellGap_Injected(){} // RVA: 0x7C57540
        public void get_cellLayout_Injected(){} // RVA: 0x7C575A0
        public void get_cellSwizzle_Injected(){} // RVA: 0x7C575F0
        public void GetBoundsLocal_Injected(){} // RVA: 0x7C57640
        public void GetBoundsLocalOriginSize_Injected(){} // RVA: 0x7C576B0
        public void CellToLocal_Injected(){} // RVA: 0x7C57730
        public void LocalToCell_Injected(){} // RVA: 0x7C577A0
        public void CellToLocalInterpolated_Injected(){} // RVA: 0x7C57810
        public void LocalToCellInterpolated_Injected(){} // RVA: 0x7C57880
        public void CellToWorld_Injected(){} // RVA: 0x7C578F0
        public void WorldToCell_Injected(){} // RVA: 0x7C57960
        public void LocalToWorld_Injected(){} // RVA: 0x7C579D0
        public void WorldToLocal_Injected(){} // RVA: 0x7C57A40
        public void GetLayoutCellCenter_Injected(){} // RVA: 0x7C57AB0
    }

    public class GridLayout[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}