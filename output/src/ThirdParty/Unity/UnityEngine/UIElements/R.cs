// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 17
// Methods: 126

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class RadioButton : BaseBoolField
    {
        public string value;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10
        public string checkmarkBackgroundUssClassName; // 0x18
        public string checkmarkUssClassName; // 0x20
        public string textUssClassName; // 0x28
        public UnityEngine.UIElements.VisualElement m_CheckmarkBackground; // 0x460

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC9B51E50
        public void set_value(){} // RVA: 0x7FFAC9B51EA0
        public void .ctor(){} // RVA: 0x7FFAC9B52070 | overloaded x2
        public void OnOptionAttachToPanel(){} // RVA: 0x7FFAC9B523C0
        public void OnOptionDetachFromPanel(){} // RVA: 0x7FFAC9B52580
        public void InitLabel(){} // RVA: 0x7FFAC9B52720
        public void ToggleValue(){} // RVA: 0x7FFAC9B527A0
        public void UnityEngine.UIElements.IGroupBoxOption.SetSelected(){} // RVA: 0x7FFAC9B527F0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9B52810
        public void UpdateCheckmark(){} // RVA: 0x7FFAC9B52970
        public void UpdateMixedValueContent(){} // RVA: 0x7FFAC9B52A10
        public void .cctor(){} // RVA: 0x7FFAC9B52AC0
    }

    public class RadioButtonGroup : BaseField`1
    {
        public string choices;
        public string contentContainer; // 0x8
        public System.Collections.Generic.List`1<UnityEngine.UIElements.RadioButton> m_RadioButtons; // 0x440
        public UnityEngine.UIElements.EventCallback`1<UnityEngine.UIElements.ChangeEvent`1<bool>> m_RadioButtonValueChangedCallback; // 0x448
        public UnityEngine.UIElements.VisualElement m_RadioButtonContainer; // 0x450

        // ── Methods ──
        public void set_choices(){} // RVA: 0x7FFAC9B53160
        public void get_contentContainer(){} // RVA: 0x7FFAC9B537E0
        public void .ctor(){} // RVA: 0x7FFAC9B53810 | overloaded x2
        public void RadioButtonValueChangedCallback(){} // RVA: 0x7FFAC9B53B90
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9B53CB0
        public void UpdateRadioButtons(){} // RVA: 0x7FFAC9B53D00
        public void UnityEngine.UIElements.IGroupBox.OnOptionAdded(){} // RVA: 0x7FFAC9B53F50
        public void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(){} // RVA: 0x7FFAC9B54180
        public void .cctor(){} // RVA: 0x7FFAC9B54340
    }

    public class RareData : ValueType
    {
        public UnityEngine.UIElements.Cursor cursor; // 0x10
        public 0x6B122970 textOverflow; // 0x28
        public UnityEngine.Color unityBackgroundImageTintColor; // 0x2C
        public 0x6B122760 unityOverflowClipBox; // 0x3C
        public int unitySliceBottom; // 0x40
        public int unitySliceLeft; // 0x44
        public int unitySliceRight; // 0x48
        public float unitySliceScale; // 0x4C
        public int unitySliceTop; // 0x50
        public 0x6B122918 unityTextOverflowPosition; // 0x54

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFAC9BF95D0
        public void CopyFrom(){} // RVA: 0x7FFAC7C17AB0
        public void op_Equality(){} // RVA: 0x7FFAC9BF9600
        public void Equals(){} // RVA: 0x7FFAC9BF9920 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BF9A30
    }

    public class RectField : BaseCompositeField`3
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFAC9AA2240
        public void .ctor(){} // RVA: 0x7FFAC9AA2F40 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9AA3090
    }

    public class RectIntField : BaseCompositeField`3
    {
        public string ussClassName;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFAC9AA3C90
        public void .ctor(){} // RVA: 0x7FFAC9AA4990 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9AA4AE0
    }

    public class RepaintData : Object
    {
        public UnityEngine.Matrix4x4 currentOffset; // 0x10
        public UnityEngine.Vector2 currentWorldClip; // 0x50
        public UnityEngine.Rect repaintEvent; // 0x58
        public UnityEngine.Event <repaintEvent>k__BackingField; // 0x68

        // ── Methods ──
        public void get_currentOffset(){} // RVA: 0x7FFAC58748A0
        public void get_currentWorldClip(){} // RVA: 0x7FFAC3BCB4D0
        public void get_repaintEvent(){} // RVA: 0x7FFAC2F9CD50
        public void set_repaintEvent(){} // RVA: 0x7FFAC2F9CD60
        public void .ctor(){} // RVA: 0x7FFAC9BA6760
    }

    public class RepeatButton : TextElement
    {
        public UnityEngine.UIElements.Clickable m_Clickable; // 0x4A0
        public string ussClassName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B54810 | overloaded x2
        public void SetAction(){} // RVA: 0x7FFAC9B548F0
        public void AddAction(){} // RVA: 0x7FFAC9B54A50
        public void .cctor(){} // RVA: 0x7FFAC9B54B50
    }

    public class ReusableCollectionItem : Object
    {
        public UnityEngine.UIElements.VisualElement rootElement; // 0x10
        public UnityEngine.UIElements.Experimental.ValueAnimation`1<UnityEngine.UIElements.Experimental.StyleValues> bindableElement; // 0x18
        public int animator; // 0x20
        public int index; // 0x24
        public bool id; // 0x28
        public System.Action`1<UnityEngine.UIElements.ReusableCollectionItem> isDragGhost; // 0x30
        public UnityEngine.UIElements.EventCallback`1<UnityEngine.UIElements.GeometryChangedEvent> m_GeometryChangedEventCallback; // 0x38
        public System.Action`1<UnityEngine.UIElements.ReusableCollectionItem> onDestroy; // 0x40

        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7FFAC2F3C380
        public void get_bindableElement(){} // RVA: 0x7FFAC2F3C380
        public void set_bindableElement(){} // RVA: 0x7FFAC2F22E30
        public void get_animator(){} // RVA: 0x7FFAC2F247C0
        public void set_animator(){} // RVA: 0x7FFAC2F87E80
        public void get_index(){} // RVA: 0x7FFAC30DBBE0
        public void set_index(){} // RVA: 0x7FFAC35DB7A0
        public void get_id(){} // RVA: 0x7FFAC3921980
        public void set_id(){} // RVA: 0x7FFAC41674D0
        public void get_isDragGhost(){} // RVA: 0x7FFAC30F6BA0
        public void set_isDragGhost(){} // RVA: 0x7FFAC3C24F40
        public void add_onGeometryChanged(){} // RVA: 0x7FFAC9A8BA20
        public void remove_onGeometryChanged(){} // RVA: 0x7FFAC9A8BB20
        public void add_onDestroy(){} // RVA: 0x7FFAC9A8BC20
        public void remove_onDestroy(){} // RVA: 0x7FFAC9A8BD20
        public void .ctor(){} // RVA: 0x7FFAC9A8BE20
        public void Init(){} // RVA: 0x7FFAC2F22E30
        public void PreAttachElement(){} // RVA: 0x7FFAC9A8BEE0
        public void DetachElement(){} // RVA: 0x7FFAC9A8BFC0
        public void DestroyElement(){} // RVA: 0x7FFAC9A8C140
        public void SetSelected(){} // RVA: 0x7FFAC9A8C160
        public void SetDragGhost(){} // RVA: 0x7FFAC9A8C290
        public void OnGeometryChanged(){} // RVA: 0x7FFAC493BEB0
    }

    public class ReusableListViewItem : ReusableCollectionItem
    {
        public UnityEngine.UIElements.VisualElement rootElement; // 0x48
        public UnityEngine.UIElements.VisualElement m_DragHandle; // 0x50
        public UnityEngine.UIElements.VisualElement m_ItemContainer; // 0x58

        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7FFAC9A8C390
        public void Init(){} // RVA: 0x7FFAC9A8C3A0
        public void UpdateHierarchy(){} // RVA: 0x7FFAC9A8C4C0
        public void UpdateDragHandle(){} // RVA: 0x7FFAC9A8C8E0
        public void PreAttachElement(){} // RVA: 0x7FFAC9A8CA40
        public void DetachElement(){} // RVA: 0x7FFAC9A8CAE0
        public void SetDragGhost(){} // RVA: 0x7FFAC9A8CB80
        public void .ctor(){} // RVA: 0x7FFAC9A8CCF0
    }

    public class ReusableMultiColumnListViewItem : ReusableListViewItem
    {
        public object rootElement;

        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7FFAC2F3C380
        public void Init(){} // RVA: 0x7FFAC9A8CD00 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC9A8CCF0
    }

    public class ReusableMultiColumnTreeViewItem : ReusableTreeViewItem
    {
        public object rootElement;

        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7FFAC2F3C380
        public void Init(){} // RVA: 0x7FFAC9A8CFB0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFAC9A8D250
    }

    public class ReusableTreeViewItem : ReusableCollectionItem
    {
        public UnityEngine.UIElements.Toggle rootElement; // 0x48
        public UnityEngine.UIElements.VisualElement m_Container; // 0x50
        public UnityEngine.UIElements.VisualElement m_IndentElement; // 0x58
        public UnityEngine.UIElements.VisualElement m_BindableContainer; // 0x60
        public UnityEngine.UIElements.VisualElement m_Checkmark; // 0x68
        public System.Action`1<UnityEngine.UIElements.PointerUpEvent> onPointerUp; // 0x70
        public System.Action`1<UnityEngine.UIElements.ChangeEvent`1<bool>> onToggleValueChanged; // 0x78
        public int m_Depth; // 0x80
        public float m_IndentWidth; // 0x84
        public UnityEngine.UIElements.EventCallback`1<UnityEngine.UIElements.PointerUpEvent> m_PointerUpCallback; // 0x88
        public UnityEngine.UIElements.EventCallback`1<UnityEngine.UIElements.ChangeEvent`1<bool>> m_ToggleValueChangedCallback; // 0x90
        public UnityEngine.UIElements.EventCallback`1<UnityEngine.UIElements.GeometryChangedEvent> m_ToggleGeometryChangedCallback; // 0x98

        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7FFAC9A8D260
        public void add_onPointerUp(){} // RVA: 0x7FFAC9A8D270
        public void remove_onPointerUp(){} // RVA: 0x7FFAC9A8D370
        public void add_onToggleValueChanged(){} // RVA: 0x7FFAC9A8D470
        public void remove_onToggleValueChanged(){} // RVA: 0x7FFAC9A8D570
        public void .ctor(){} // RVA: 0x7FFAC9A8D670
        public void Init(){} // RVA: 0x7FFAC9A8D8A0
        public void InitExpandHierarchy(){} // RVA: 0x7FFAC9A8D9D0
        public void PreAttachElement(){} // RVA: 0x7FFAC9A8E0C0
        public void DetachElement(){} // RVA: 0x7FFAC9A8E290
        public void Indent(){} // RVA: 0x7FFAC9A8E440
        public void SetExpandedWithoutNotify(){} // RVA: 0x7FFAC9A8E460
        public void SetToggleVisibility(){} // RVA: 0x7FFAC9A8E480
        public void OnToggleGeometryChanged(){} // RVA: 0x7FFAC9A8E4A0
        public void UpdateIndentLayout(){} // RVA: 0x7FFAC9A8E5C0
        public void OnPointerUp(){} // RVA: 0x7FFAC9A8E740
        public void OnToggleValueChanged(){} // RVA: 0x7FFAC9A8E760
    }

    public class Rotate : ValueType
    {
        public UnityEngine.UIElements.Angle angle; // 0x10
        public UnityEngine.Vector3 axis; // 0x18
        public bool m_IsNone; // 0x24

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9BFCE00
        public void Initial(){} // RVA: 0x7FFAC9BFCE60
        public void None(){} // RVA: 0x7FFAC9BFCF00
        public void get_angle(){} // RVA: 0x7FFAC3AD9F60
        public void set_angle(){} // RVA: 0x7FFAC45BB120
        public void get_axis(){} // RVA: 0x7FFAC60F5A40
        public void op_Equality(){} // RVA: 0x7FFAC9BFCFD0
        public void op_Inequality(){} // RVA: 0x7FFAC9BFD0D0
        public void Equals(){} // RVA: 0x7FFAC9BFD170 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BFD230
        public void ToString(){} // RVA: 0x7FFAC9BFD320
        public void ToQuaternion(){} // RVA: 0x7FFAC9BFD390
    }

    public class RuleMatcher : ValueType
    {
        public UnityEngine.UIElements.StyleSheet sheet; // 0x10
        public UnityEngine.UIElements.StyleComplexSelector complexSelector; // 0x18

        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFAC9C24120
    }

    public class RuntimeEventDispatcher : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFAC9B99F30
    }

    public class RuntimePanel : BaseRuntimePanel
    {
        public UnityEngine.UIElements.EventDispatcher panelSettings;
        public UnityEngine.UIElements.PanelSettings m_PanelSettings; // 0x1E8

        // ── Methods ──
        public void get_panelSettings(){} // RVA: 0x7FFAC39B1060
        public void Create(){} // RVA: 0x7FFAC9B9A140
        public void .ctor(){} // RVA: 0x7FFAC9B9A1A0
        public void Update(){} // RVA: 0x7FFAC9B9A990
        public void OnElementFocus(){} // RVA: 0x7FFAC9B9AB30
        public void .cctor(){} // RVA: 0x7FFAC9B9ABA0
    }

    public class RuntimeUIElementsBridge : UIElementsBridge
    {
        // ── Methods ──
        public void SetWantsMouseJumping(){} // RVA: 0x7FFAC2F21310
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}