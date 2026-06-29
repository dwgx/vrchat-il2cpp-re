// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 17
// Methods: 117

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class RadioButton : BaseBoolField
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7AF199940
        public void set_value(){} // RVA: 0x7AF199990
        public void .ctor(){} // RVA: 0x7AF199B60
        public void OnOptionAttachToPanel(){} // RVA: 0x7AF199EB0
        public void OnOptionDetachFromPanel(){} // RVA: 0x7AF19A070
        public void InitLabel(){} // RVA: 0x7AF19A210
        public void ToggleValue(){} // RVA: 0x7AF19A290
        public void UnityEngine.UIElements.IGroupBoxOption.SetSelected(){} // RVA: 0x7AF19A2E0
        public void SetValueWithoutNotify(){} // RVA: 0x7AF19A300
        public void UpdateCheckmark(){} // RVA: 0x7AF19A460
        public void UpdateMixedValueContent(){} // RVA: 0x7AF19A500
        public void .cctor(){} // RVA: 0x7AF19A5A0
    }

    public class RadioButtonGroup : BaseField`1
    {
        // ── Methods ──
        public void set_choices(){} // RVA: 0x7AF19AC40
        public void get_contentContainer(){} // RVA: 0x7AF19B2C0
        public void .ctor(){} // RVA: 0x7AF19B2F0
        public void RadioButtonValueChangedCallback(){} // RVA: 0x7AF19B680
        public void SetValueWithoutNotify(){} // RVA: 0x7AF19B7A0
        public void UpdateRadioButtons(){} // RVA: 0x7AF19B7F0
        public void UnityEngine.UIElements.IGroupBox.OnOptionAdded(){} // RVA: 0x7AF19BA50
        public void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(){} // RVA: 0x7AF19BC60
        public void .cctor(){} // RVA: 0x7AF19BE10
    }

    public class RareData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7A7F07880
        public void CopyFrom(){} // RVA: 0x7A7F078B0
        public void op_Equality(){} // RVA: 0x7AF2412C0
        public void Equals(){} // RVA: 0x7A7F07940
        public void GetHashCode(){} // RVA: 0x7A7F07A50
    }

    public class RectField : BaseCompositeField`3
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7AF0EAB40
        public void .ctor(){} // RVA: 0x7AF0EB850
        public void .cctor(){} // RVA: 0x7AF0EB9A0
    }

    public class RectIntField : BaseCompositeField`3
    {
        // ── Methods ──
        public void DescribeFields(){} // RVA: 0x7AF0EC5A0
        public void .ctor(){} // RVA: 0x7AF0ED2B0
        public void .cctor(){} // RVA: 0x7AF0ED400
    }

    public class RepaintData : Object
    {
        // ── Methods ──
        public void get_currentOffset(){} // RVA: 0x7AACD92C0
        public void get_currentWorldClip(){} // RVA: 0x7A8EDB610
        public void get_repaintEvent(){} // RVA: 0x7A8153390
        public void set_repaintEvent(){} // RVA: 0x7A81533A0
        public void .ctor(){} // RVA: 0x7AF1EDEC0
    }

    public class RepeatButton : TextElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF19C2E0
        public void SetAction(){} // RVA: 0x7AF19C3C0
        public void AddAction(){} // RVA: 0x7AF19C520
        public void .cctor(){} // RVA: 0x7AF19C630
    }

    public class ReusableCollectionItem : Object
    {
        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7A80F2570
        public void get_bindableElement(){} // RVA: 0x7A80F2570
        public void set_bindableElement(){} // RVA: 0x7A80D8E20
        public void get_animator(){} // RVA: 0x7A80DA7B0
        public void set_animator(){} // RVA: 0x7A813E420
        public void get_index(){} // RVA: 0x7A851DB90
        public void set_index(){} // RVA: 0x7A8738180
        public void get_id(){} // RVA: 0x7A8AB15F0
        public void set_id(){} // RVA: 0x7A94794D0
        public void get_isDragGhost(){} // RVA: 0x7A84A5BD0
        public void set_isDragGhost(){} // RVA: 0x7A84A5CD0
        public void add_onGeometryChanged(){} // RVA: 0x7AF0D42A0
        public void remove_onGeometryChanged(){} // RVA: 0x7AF0D43B0
        public void add_onDestroy(){} // RVA: 0x7AF0D44C0
        public void remove_onDestroy(){} // RVA: 0x7AF0D45D0
        public void .ctor(){} // RVA: 0x7AF0D46E0
        public void Init(){} // RVA: 0x7A80D8E20
        public void PreAttachElement(){} // RVA: 0x7AF0D47A0
        public void DetachElement(){} // RVA: 0x7AF0D4880
        public void DestroyElement(){} // RVA: 0x7AF0D4A00
        public void SetSelected(){} // RVA: 0x7AF0D4A20
        public void SetDragGhost(){} // RVA: 0x7AF0D4B50
        public void OnGeometryChanged(){} // RVA: 0x7A9C1C950
    }

    public class ReusableListViewItem : ReusableCollectionItem
    {
        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7AF0D4C50
        public void Init(){} // RVA: 0x7AF0D4C60
        public void UpdateHierarchy(){} // RVA: 0x7AF0D4D80
        public void UpdateDragHandle(){} // RVA: 0x7AF0D51A0
        public void PreAttachElement(){} // RVA: 0x7AF0D5300
        public void DetachElement(){} // RVA: 0x7AF0D53A0
        public void SetDragGhost(){} // RVA: 0x7AF0D5440
        public void .ctor(){} // RVA: 0x7AF0D55A0
    }

    public class ReusableMultiColumnListViewItem : ReusableListViewItem
    {
        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7A80F2570
        public void Init(){} // RVA: 0x7AF0D55B0
        public void .ctor(){} // RVA: 0x7AF0D55A0
    }

    public class ReusableMultiColumnTreeViewItem : ReusableTreeViewItem
    {
        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7A80F2570
        public void Init(){} // RVA: 0x7AF0D5880
        public void .ctor(){} // RVA: 0x7AF0D5B40
    }

    public class ReusableTreeViewItem : ReusableCollectionItem
    {
        // ── Methods ──
        public void get_rootElement(){} // RVA: 0x7AF0D5B50
        public void add_onPointerUp(){} // RVA: 0x7AF0D5B60
        public void remove_onPointerUp(){} // RVA: 0x7AF0D5C70
        public void add_onToggleValueChanged(){} // RVA: 0x7AF0D5D80
        public void remove_onToggleValueChanged(){} // RVA: 0x7AF0D5E90
        public void .ctor(){} // RVA: 0x7AF0D5FA0
        public void Init(){} // RVA: 0x7AF0D61D0
        public void InitExpandHierarchy(){} // RVA: 0x7AF0D6300
        public void PreAttachElement(){} // RVA: 0x7AF0D6A50
        public void DetachElement(){} // RVA: 0x7AF0D6C20
        public void Indent(){} // RVA: 0x7AF0D6DD0
        public void SetExpandedWithoutNotify(){} // RVA: 0x7AF0D6DF0
        public void SetToggleVisibility(){} // RVA: 0x7AF0D6E10
        public void OnToggleGeometryChanged(){} // RVA: 0x7AF0D6E30
        public void UpdateIndentLayout(){} // RVA: 0x7AF0D6F50
        public void OnPointerUp(){} // RVA: 0x7AF0D70D0
        public void OnToggleValueChanged(){} // RVA: 0x7AF0D70F0
    }

    public class Rotate : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F081C0
        public void Initial(){} // RVA: 0x7AF244B30
        public void None(){} // RVA: 0x7AF244BD0
        public void get_angle(){} // RVA: 0x7A765F710
        public void set_angle(){} // RVA: 0x7A767FEF0
        public void get_axis(){} // RVA: 0x7A790DB00
        public void op_Equality(){} // RVA: 0x7AF244C80
        public void op_Inequality(){} // RVA: 0x7AF244D80
        public void Equals(){} // RVA: 0x7A7F08270
        public void GetHashCode(){} // RVA: 0x7A7F08280
        public void ToString(){} // RVA: 0x7A7F08290
        public void ToQuaternion(){} // RVA: 0x7A7F08300
    }

    public class RuleMatcher : ValueType
    {
        // ── Methods ──
        public void ToString(){} // RVA: 0x7A7F0B1F0
    }

    public class RuntimeEventDispatcher : Object
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7AF1E1720
    }

    public class RuntimePanel : BaseRuntimePanel
    {
        // ── Methods ──
        public void get_panelSettings(){} // RVA: 0x7A8B7A210
        public void Create(){} // RVA: 0x7AF1E1930
        public void .ctor(){} // RVA: 0x7AF1E1990
        public void Update(){} // RVA: 0x7AF1E2180
        public void OnElementFocus(){} // RVA: 0x7AF1E2320
        public void .cctor(){} // RVA: 0x7AF1E2390
    }

    public class RuntimeUIElementsBridge : UIElementsBridge
    {
        // ── Methods ──
        public void SetWantsMouseJumping(){} // RVA: 0x7A80D7310
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}