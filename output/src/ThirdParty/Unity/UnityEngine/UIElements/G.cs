// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 6
// Methods: 56

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class GenericDropdownMenu : Object
    {
        public string isSingleSelectionDropdown;
        public string closeOnParentResize; // 0x8
        public string contentContainer; // 0x10
        public string containerInnerUssClassName; // 0x18
        public string containerOuterUssClassName; // 0x20
        public string checkmarkUssClassName; // 0x28
        public string separatorUssClassName; // 0x30
        public System.Collections.Generic.List`1<MenuItem> m_Items; // 0x10
        public UnityEngine.UIElements.VisualElement m_MenuContainer; // 0x18
        public UnityEngine.UIElements.VisualElement m_OuterContainer; // 0x20
        public UnityEngine.UIElements.ScrollView m_ScrollView; // 0x28
        public UnityEngine.UIElements.VisualElement m_PanelRootVisualContainer; // 0x30
        public UnityEngine.UIElements.VisualElement m_TargetElement; // 0x38
        public UnityEngine.Rect m_DesiredRect; // 0x40
        public UnityEngine.UIElements.KeyboardNavigationManipulator m_NavigationManipulator; // 0x50
        public bool <isSingleSelectionDropdown>k__BackingField; // 0x58
        public bool <closeOnParentResize>k__BackingField; // 0x59
        public UnityEngine.Vector2 m_MousePosition; // 0x5C

        // ── Methods ──
        public void get_isSingleSelectionDropdown(){} // RVA: 0x7FFAC313F600
        public void set_isSingleSelectionDropdown(){} // RVA: 0x7FFAC3892770
        public void get_closeOnParentResize(){} // RVA: 0x7FFAC778CF40
        public void set_closeOnParentResize(){} // RVA: 0x7FFAC87B5A20
        public void get_contentContainer(){} // RVA: 0x7FFAC9AB23B0
        public void .ctor(){} // RVA: 0x7FFAC9AB23E0
        public void OnAttachToPanel(){} // RVA: 0x7FFAC9AB2990
        public void OnDetachFromPanel(){} // RVA: 0x7FFAC9AB2E50
        public void Hide(){} // RVA: 0x7FFAC9AB31D0
        public void Apply(){} // RVA: 0x7FFAC9AB3300 | overloaded x2
        public void OnPointerDown(){} // RVA: 0x7FFAC9AB3570
        public void OnPointerMove(){} // RVA: 0x7FFAC9AB3730
        public void OnPointerUp(){} // RVA: 0x7FFAC9AB38F0
        public void OnFocusOut(){} // RVA: 0x7FFAC9AB3AD0
        public void OnParentResized(){} // RVA: 0x7FFAC9AB3C60
        public void UpdateSelection(){} // RVA: 0x7FFAC9AB3C80
        public void ChangeSelectedIndex(){} // RVA: 0x7FFAC9AB3DD0
        public void GetSelectedIndex(){} // RVA: 0x7FFAC9AB3F30
        public void AddItem(){} // RVA: 0x7FFAC9AB41E0 | overloaded x3
        public void AddSeparator(){} // RVA: 0x7FFAC9AB40E0
        public void DropDown(){} // RVA: 0x7FFAC9AB4780
        public void OnTargetElementDetachFromPanel(){} // RVA: 0x7FFAC9AB5400
        public void OnContainerGeometryChanged(){} // RVA: 0x7FFAC9AB5490
        public void EnsureVisibilityInParent(){} // RVA: 0x7FFAC9AB54A0
        public void .cctor(){} // RVA: 0x7FFAC9AB5AF0
        public void <Apply>g__UpdateSelectionDown|39_0(){} // RVA: 0x7FFAC9AB5F70
        public void <Apply>g__UpdateSelectionUp|39_1(){} // RVA: 0x7FFAC9AB6040
    }

    public class GeometryChangedEvent : EventBase`1
    {
        public UnityEngine.Rect oldRect; // 0x88
        public UnityEngine.Rect newRect; // 0x98
        public int layoutPass; // 0xA8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B854B0
        public void GetPooled(){} // RVA: 0x7FFAC9B855A0
        public void Init(){} // RVA: 0x7FFAC9B85630
        public void LocalInit(){} // RVA: 0x7FFAC9B85700
        public void get_oldRect(){} // RVA: 0x7FFAC7DF99E0
        public void set_oldRect(){} // RVA: 0x7FFAC7DF99F0
        public void get_newRect(){} // RVA: 0x7FFAC4B5E6B0
        public void set_newRect(){} // RVA: 0x7FFAC4B5E720
        public void get_layoutPass(){} // RVA: 0x7FFAC39055C0
        public void set_layoutPass(){} // RVA: 0x7FFAC38FD010
        public void .ctor(){} // RVA: 0x7FFAC9B85720
    }

    public class GetViewDataDictionary : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3AD07E0
        public void Invoke(){} // RVA: 0x7FFAC2F7FA50
    }

    public class GradientSettings : ValueType
    {
        public 0x6B126490 gradientType; // 0x10
        public 0x6B1264E8 addressMode; // 0x14
        public UnityEngine.Vector2 radialFocus; // 0x18
        public UnityEngine.RectInt location; // 0x20
    }

    public class GroupBox : BindableElement
    {
        public string text;
        public string labelUssClassName; // 0x8
        public UnityEngine.UIElements.Label m_TitleLabel; // 0x3D8

        // ── Methods ──
        public void set_text(){} // RVA: 0x7FFAC9AB6100
        public void .ctor(){} // RVA: 0x7FFAC9AB6450 | overloaded x2
        public void UnityEngine.UIElements.IGroupBox.OnOptionAdded(){} // RVA: 0x7FFAC2F21310
        public void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC9AB6510
    }

    public class GroupBoxUtility : Object
    {
        public System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.IGroupBox,UnityEngine.UIElements.IGroupManager> s_GroupManagers;
        public System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.IGroupBoxOption,UnityEngine.UIElements.IGroupManager> s_GroupOptionManagerCache; // 0x8
        public System.Type k_GenericGroupBoxType; // 0x10

        // ── Methods ──
        public void RegisterGroupBoxOption(){} // RVA: 0x7FFAC2E8DC40
        public void UnregisterGroupBoxOption(){} // RVA: 0x7FFAC2E8DC40
        public void OnOptionSelected(){} // RVA: 0x7FFAC2E8DC40
        public void FindOrCreateGroupManager(){} // RVA: 0x7FFAC9B9D850
        public void OnGroupBoxDetachedFromPanel(){} // RVA: 0x7FFAC9B9DEA0
        public void OnPanelDestroyed(){} // RVA: 0x7FFAC9B9DF70
        public void .cctor(){} // RVA: 0x7FFAC9B9E160
    }

}