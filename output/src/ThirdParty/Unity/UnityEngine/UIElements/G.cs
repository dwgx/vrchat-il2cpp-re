// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 6
// Methods: 56

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class GenericDropdownMenu : Object
    {
        public string ussClassName;
        public string itemUssClassName; // 0x8
        public string labelUssClassName; // 0x10

        // ── Methods ──
        public void get_isSingleSelectionDropdown(){} // RVA: 0x7FFE813A1140
        public void set_isSingleSelectionDropdown(){} // RVA: 0x7FFE819E83C0
        public void get_closeOnParentResize(){} // RVA: 0x7FFE85BA8C00
        public void set_closeOnParentResize(){} // RVA: 0x7FFE86B5F180
        public void get_contentContainer(){} // RVA: 0x7FFE87E5AC50
        public void .ctor(){} // RVA: 0x7FFE87E5AC80
        public void OnAttachToPanel(){} // RVA: 0x7FFE87E5B230
        public void OnDetachFromPanel(){} // RVA: 0x7FFE87E5B6F0
        public void Hide(){} // RVA: 0x7FFE87E5BA70
        public void Apply(){} // RVA: 0x7FFE87E5BBA0 | overloaded x2
        public void OnPointerDown(){} // RVA: 0x7FFE87E5BE10
        public void OnPointerMove(){} // RVA: 0x7FFE87E5BFD0
        public void OnPointerUp(){} // RVA: 0x7FFE87E5C190
        public void OnFocusOut(){} // RVA: 0x7FFE87E5C370
        public void OnParentResized(){} // RVA: 0x7FFE87E5C500
        public void UpdateSelection(){} // RVA: 0x7FFE87E5C520
        public void ChangeSelectedIndex(){} // RVA: 0x7FFE87E5C670
        public void GetSelectedIndex(){} // RVA: 0x7FFE87E5C7D0
        public void AddItem(){} // RVA: 0x7FFE87E5CA80 | overloaded x3
        public void AddSeparator(){} // RVA: 0x7FFE87E5C980
        public void DropDown(){} // RVA: 0x7FFE87E5D020
        public void OnTargetElementDetachFromPanel(){} // RVA: 0x7FFE87E5DCA0
        public void OnContainerGeometryChanged(){} // RVA: 0x7FFE87E5DD30
        public void EnsureVisibilityInParent(){} // RVA: 0x7FFE87E5DD40
        public void .cctor(){} // RVA: 0x7FFE87E5E390
        public void <Apply>g__UpdateSelectionDown|39_0(){} // RVA: 0x7FFE87E5E810
        public void <Apply>g__UpdateSelectionUp|39_1(){} // RVA: 0x7FFE87E5E8E0
    }

    public class GeometryChangedEvent : EventBase`1
    {
        public UnityEngine.Rect _oldRect; // 0x88
        public UnityEngine.Rect _newRect; // 0x98
        public int _layoutPass; // 0xA8

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F2DD60
        public void GetPooled(){} // RVA: 0x7FFE87F2DE50
        public void Init(){} // RVA: 0x7FFE87F2DEE0
        public void LocalInit(){} // RVA: 0x7FFE87F2DFB0
        public void get_oldRect(){} // RVA: 0x7FFE8621CDA0
        public void set_oldRect(){} // RVA: 0x7FFE8621CDB0
        public void get_newRect(){} // RVA: 0x7FFE82DC88E0
        public void set_newRect(){} // RVA: 0x7FFE82DC88F0
        public void get_layoutPass(){} // RVA: 0x7FFE81A338E0
        public void set_layoutPass(){} // RVA: 0x7FFE81A34770
        public void .ctor(){} // RVA: 0x7FFE87F2DFD0
    }

    public class GetViewDataDictionary : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE828B3700
        public void Invoke(){} // RVA: 0x7FFE81159A50
    }

    public class GradientSettings : ValueType
    {
    }

    public class GroupBox : BindableElement
    {
        public string ussClassName;

        // ── Methods ──
        public void set_text(){} // RVA: 0x7FFE87E5E9A0
        public void .ctor(){} // RVA: 0x7FFE87E5ECF0 | overloaded x2
        public void UnityEngine.UIElements.IGroupBox.OnOptionAdded(){} // RVA: 0x7FFE810FB310
        public void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE87E5EDB0
    }

    public class GroupBoxUtility : Object
    {
        // ── Methods ──
        public void RegisterGroupBoxOption(){} // RVA: 0x7FFE810A1420
        public void UnregisterGroupBoxOption(){} // RVA: 0x7FFE810A1420
        public void OnOptionSelected(){} // RVA: 0x7FFE810A1420
        public void FindOrCreateGroupManager(){} // RVA: 0x7FFE87F46100
        public void OnGroupBoxDetachedFromPanel(){} // RVA: 0x7FFE87F46750
        public void OnPanelDestroyed(){} // RVA: 0x7FFE87F46820
        public void .cctor(){} // RVA: 0x7FFE87F46A10
    }

}