// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 17
// Methods: 126

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class RadioButton : BaseBoolField
    {
        public string ussClassName;

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE87EFA6F0
        public void set_value(){} // RVA: 0x7FFE87EFA740
        public void .ctor(){} // RVA: 0x7FFE87EFA910 | overloaded x2
        public void OnOptionAttachToPanel(){} // RVA: 0x7FFE87EFAC60
        public void OnOptionDetachFromPanel(){} // RVA: 0x7FFE87EFAE20
        public void InitLabel(){} // RVA: 0x7FFE87EFAFC0
        public void ToggleValue(){} // RVA: 0x7FFE87EFB040
        public void UnityEngine.UIElements.IGroupBoxOption.SetSelected(){} // RVA: 0x7FFE87EFB090
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE87EFB0B0
        public void UpdateCheckmark(){} // RVA: 0x7FFE87EFB210
        public void UpdateMixedValueContent(){} // RVA: 0x7FFE87EFB2B0
        public void .cctor(){} // RVA: 0x7FFE87EFB360
    }

    public class RadioButtonGroup : BaseField`1
    {
        public string ussClassName;
        public string containerUssClassName; // 0x8

        // ── Methods ──
        public void set_choices(){} // RVA: 0x7FFE87EFBA00
        public void get_contentContainer(){} // RVA: 0x7FFE87EFC080
        public void .ctor(){} // RVA: 0x7FFE87EFC0B0 | overloaded x2
        public void RadioButtonValueChangedCallback(){} // RVA: 0x7FFE87EFC430
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE87EFC550
        public void UpdateRadioButtons(){} // RVA: 0x7FFE87EFC5A0
        public void UnityEngine.UIElements.IGroupBox.OnOptionAdded(){} // RVA: 0x7FFE87EFC7F0
        public void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(){} // RVA: 0x7FFE87EFCA20
        public void .cctor(){} // RVA: 0x7FFE87EFCBE0
    }

    public class RareData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFE87FA1E20
        public void CopyFrom(){} // RVA: 0x7FFE8602B8E0
        public void op_Equality(){} // RVA: 0x7FFE87FA1E50
        public void Equals(){} // RVA: 0x7FFE87FA2170 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA2280
    }

    public class RectField : BaseCompositeField`3
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFE87E4AAE0
        public void .ctor(){} // RVA: 0x7FFE87E4B7E0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87E4B930
    }

    public class RectIntField : BaseCompositeField`3
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7FFE87E4C530
        public void .ctor(){} // RVA: 0x7FFE87E4D230 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87E4D380
    }

    public class RepaintData : Object
    {
        public UnityEngine.Matrix4x4 _currentOffset; // 0x10
        public UnityEngine.Vector2 _mousePosition; // 0x50
        public UnityEngine.Rect _currentWorldClip; // 0x58

        // ── Methods ──
        public void get_currentOffset(){} // RVA: 0x7FFE83BB1A00
        public void get_currentWorldClip(){} // RVA: 0x7FFE81E90B10
        public void get_repaintEvent(){} // RVA: 0x7FFE81176D50
        public void set_repaintEvent(){} // RVA: 0x7FFE81176D60
        public void .ctor(){} // RVA: 0x7FFE87F4F010
    }

    public class RepeatButton : TextElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87EFD0B0 | overloaded x2
        public void SetAction(){} // RVA: 0x7FFE87EFD190
        public void AddAction(){} // RVA: 0x7FFE87EFD2F0
        public void .cctor(){} // RVA: 0x7FFE87EFD3F0
    }

    public class ReusableCollectionItem : Object
    {
        public UnityEngine.UIElements.VisualElement _bindableElement; // 0x10
        public UnityEngine.UIElements.Experimental.ValueAnimation`1<UnityEngine.UIElements.Experimental.StyleValues> _animator; // 0x18
        public int _index; // 0x20
        public int _id; // 0x24
        public bool _isDragGhost; // 0x28
        public System.Action`1<UnityEngine.UIElements.ReusableCollectionItem> onGeometryChanged; // 0x30

        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7FFE81116380
        public void get_bindableElement(){} // RVA: 0x7FFE81116380
        public void set_bindableElement(){} // RVA: 0x7FFE810FCE30
        public void get_animator(){} // RVA: 0x7FFE810FE7C0
        public void set_animator(){} // RVA: 0x7FFE81161E80
        public void get_index(){} // RVA: 0x7FFE8151D690
        public void set_index(){} // RVA: 0x7FFE8170B670
        public void get_id(){} // RVA: 0x7FFE81A56130
        public void set_id(){} // RVA: 0x7FFE82447980
        public void get_isDragGhost(){} // RVA: 0x7FFE815F1380
        public void set_isDragGhost(){} // RVA: 0x7FFE81C15740
        public void add_onGeometryChanged(){} // RVA: 0x7FFE87E342C0
        public void remove_onGeometryChanged(){} // RVA: 0x7FFE87E343C0
        public void add_onDestroy(){} // RVA: 0x7FFE87E344C0
        public void remove_onDestroy(){} // RVA: 0x7FFE87E345C0
        public void .ctor(){} // RVA: 0x7FFE87E346C0
        public void Init(){} // RVA: 0x7FFE810FCE30
        public void PreAttachElement(){} // RVA: 0x7FFE87E34780
        public void DetachElement(){} // RVA: 0x7FFE87E34860
        public void DestroyElement(){} // RVA: 0x7FFE87E349E0
        public void SetSelected(){} // RVA: 0x7FFE87E34A00
        public void SetDragGhost(){} // RVA: 0x7FFE87E34B30
        public void OnGeometryChanged(){} // RVA: 0x7FFE82BA5BE0
    }

    public class ReusableListViewItem : ReusableCollectionItem
    {
        public UnityEngine.UIElements.VisualElement m_Container; // 0x48

        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7FFE87E34C30
        public void Init(){} // RVA: 0x7FFE87E34C40
        public void UpdateHierarchy(){} // RVA: 0x7FFE87E34D60
        public void UpdateDragHandle(){} // RVA: 0x7FFE87E35180
        public void PreAttachElement(){} // RVA: 0x7FFE87E352E0
        public void DetachElement(){} // RVA: 0x7FFE87E35380
        public void SetDragGhost(){} // RVA: 0x7FFE87E35420
        public void .ctor(){} // RVA: 0x7FFE87E35590
    }

    public class ReusableMultiColumnListViewItem : ReusableListViewItem
    {
        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7FFE81116380
        public void Init(){} // RVA: 0x7FFE87E355A0 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87E35590
    }

    public class ReusableMultiColumnTreeViewItem : ReusableTreeViewItem
    {
        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7FFE81116380
        public void Init(){} // RVA: 0x7FFE87E35850 | overloaded x2
        public void .ctor(){} // RVA: 0x7FFE87E35AF0
    }

    public class ReusableTreeViewItem : ReusableCollectionItem
    {
        public UnityEngine.UIElements.Toggle m_Toggle; // 0x48

        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7FFE87E35B00
        public void add_onPointerUp(){} // RVA: 0x7FFE87E35B10
        public void remove_onPointerUp(){} // RVA: 0x7FFE87E35C10
        public void add_onToggleValueChanged(){} // RVA: 0x7FFE87E35D10
        public void remove_onToggleValueChanged(){} // RVA: 0x7FFE87E35E10
        public void .ctor(){} // RVA: 0x7FFE87E35F10
        public void Init(){} // RVA: 0x7FFE87E36140
        public void InitExpandHierarchy(){} // RVA: 0x7FFE87E36270
        public void PreAttachElement(){} // RVA: 0x7FFE87E36960
        public void DetachElement(){} // RVA: 0x7FFE87E36B30
        public void Indent(){} // RVA: 0x7FFE87E36CE0
        public void SetExpandedWithoutNotify(){} // RVA: 0x7FFE87E36D00
        public void SetToggleVisibility(){} // RVA: 0x7FFE87E36D20
        public void OnToggleGeometryChanged(){} // RVA: 0x7FFE87E36D40
        public void UpdateIndentLayout(){} // RVA: 0x7FFE87E36E60
        public void OnPointerUp(){} // RVA: 0x7FFE87E36FE0
        public void OnToggleValueChanged(){} // RVA: 0x7FFE87E37000
    }

    public class Rotate : ValueType
    {
        public UnityEngine.UIElements.Angle m_Angle; // 0x10
        public UnityEngine.Vector3 m_Axis; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87FA5650
        public void Initial(){} // RVA: 0x7FFE87FA56B0
        public void None(){} // RVA: 0x7FFE87FA5750
        public void get_angle(){} // RVA: 0x7FFE8284EF60
        public void set_angle(){} // RVA: 0x7FFE82889220
        public void get_axis(){} // RVA: 0x7FFE8445AD40
        public void op_Equality(){} // RVA: 0x7FFE87FA5820
        public void op_Inequality(){} // RVA: 0x7FFE87FA5920
        public void Equals(){} // RVA: 0x7FFE87FA59C0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA5A80
        public void ToString(){} // RVA: 0x7FFE87FA5B70
        public void ToQuaternion(){} // RVA: 0x7FFE87FA5BE0
    }

    public class RuleMatcher : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7FFE87FCC970
    }

    public class RuntimeEventDispatcher : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7FFE87F427E0
    }

    public class RuntimePanel : BaseRuntimePanel
    {
        public UnityEngine.UIElements.EventDispatcher s_EventDispatcher;

        // ── Methods ──
        public void get_panelSettings(){} // RVA: 0x7FFE81B27D50
        public void Create(){} // RVA: 0x7FFE87F429F0
        public void .ctor(){} // RVA: 0x7FFE87F42A50
        public void Update(){} // RVA: 0x7FFE87F43240
        public void OnElementFocus(){} // RVA: 0x7FFE87F433E0
        public void .cctor(){} // RVA: 0x7FFE87F43450
    }

    public class RuntimeUIElementsBridge : UIElementsBridge
    {
        // ── Methods ──
        public void SetWantsMouseJumping(){} // RVA: 0x7FFE810FB310
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}