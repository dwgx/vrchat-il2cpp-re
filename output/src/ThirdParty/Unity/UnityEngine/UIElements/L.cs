// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 11
// Methods: 90

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Label : TextElement
    {
        public string ussClassName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B3E730 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFAC9B3E7F0
    }

    public class LayoutData : ValueType
    {
        public 0x6B122868 alignContent; // 0x10
        public 0x6B122868 alignItems; // 0x14
        public 0x6B122868 alignSelf; // 0x18
        public float borderBottomWidth; // 0x1C
        public float borderLeftWidth; // 0x20
        public float borderRightWidth; // 0x24
        public float borderTopWidth; // 0x28
        public UnityEngine.UIElements.Length bottom; // 0x2C
        public 0x6B122AD0 display; // 0x34
        public UnityEngine.UIElements.Length flexBasis; // 0x38
        public 0x6B1227B8 flexDirection; // 0x40
        public float flexGrow; // 0x44
        public float flexShrink; // 0x48
        public 0x6B122810 flexWrap; // 0x4C
        public UnityEngine.UIElements.Length height; // 0x50
        public 0x6B1228C0 justifyContent; // 0x58
        public UnityEngine.UIElements.Length left; // 0x5C
        public UnityEngine.UIElements.Length marginBottom; // 0x64
        public UnityEngine.UIElements.Length marginLeft; // 0x6C
        public UnityEngine.UIElements.Length marginRight; // 0x74
        public UnityEngine.UIElements.Length marginTop; // 0x7C
        public UnityEngine.UIElements.Length maxHeight; // 0x84
        public UnityEngine.UIElements.Length maxWidth; // 0x8C
        public UnityEngine.UIElements.Length minHeight; // 0x94
        public UnityEngine.UIElements.Length minWidth; // 0x9C
        public UnityEngine.UIElements.Length paddingBottom; // 0xA4
        public UnityEngine.UIElements.Length paddingLeft; // 0xAC
        public UnityEngine.UIElements.Length paddingRight; // 0xB4
        public UnityEngine.UIElements.Length paddingTop; // 0xBC
        public 0x6B122658 position; // 0xC4
        public UnityEngine.UIElements.Length right; // 0xC8
        public UnityEngine.UIElements.Length top; // 0xD0
        public UnityEngine.UIElements.Length width; // 0xD8

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFAC9BF6360
        public void CopyFrom(){} // RVA: 0x7FFAC9BF63E0
        public void op_Equality(){} // RVA: 0x7FFAC9BF64F0
        public void Equals(){} // RVA: 0x7FFAC9BF9010 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BF9140
    }

    public class Length : ValueType
    {
        public float value;
        public float unit; // 0x10
        public 0x6B121D10 m_Unit; // 0x14

        // ── Methods ──
        public void Percent(){} // RVA: 0x7FFAC9BFC9C0
        public void Auto(){} // RVA: 0x7FFAC9BFCA00
        public void None(){} // RVA: 0x7FFAC9BFCA20
        public void get_value(){} // RVA: 0x7FFAC484C150
        public void set_value(){} // RVA: 0x7FFAC9BFCA40
        public void get_unit(){} // RVA: 0x7FFAC44202A0
        public void IsAuto(){} // RVA: 0x7FFAC9BFCA70
        public void IsNone(){} // RVA: 0x7FFAC9BFCA80
        public void .ctor(){} // RVA: 0x7FFAC9BFCAC0 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFAC9BFCAF0
        public void op_Equality(){} // RVA: 0x7FFAC9BD3800
        public void op_Inequality(){} // RVA: 0x7FFAC9BFCB30
        public void Equals(){} // RVA: 0x7FFAC9BFCB60 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BD3910
        public void ToString(){} // RVA: 0x7FFAC9BFCC10
    }

    public class ListView : BaseListView
    {
        public System.Func`1<UnityEngine.UIElements.VisualElement> makeItem; // 0x540
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> bindItem; // 0x548
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> unbindItem; // 0x550
        public System.Action`1<UnityEngine.UIElements.VisualElement> destroyItem; // 0x558

        // ── Methods ──
        public void get_makeItem(){} // RVA: 0x7FFAC39B5F30
        public void get_bindItem(){} // RVA: 0x7FFAC39CE5B0
        public void get_unbindItem(){} // RVA: 0x7FFAC39C57A0
        public void get_destroyItem(){} // RVA: 0x7FFAC39B05E0
        public void HasValidDataAndBindings(){} // RVA: 0x7FFAC9B3E900
        public void CreateViewController(){} // RVA: 0x7FFAC9B3E960
        public void .ctor(){} // RVA: 0x7FFAC9B3E9A0
    }

    public class ListViewController : BaseListViewController
    {
        public object listView;

        // ── Methods ──
        public void get_listView(){} // RVA: 0x7FFAC9A8A510
        public void MakeItem(){} // RVA: 0x7FFAC9A8A5A0
        public void BindItem(){} // RVA: 0x7FFAC9A8A6E0
        public void UnbindItem(){} // RVA: 0x7FFAC9A8A950
        public void DestroyItem(){} // RVA: 0x7FFAC9A8A9A0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class ListViewDragger : DragEventsProcessor
    {
        public DragPosition targetView; // 0x30
        public UnityEngine.UIElements.VisualElement targetScrollView; // 0x50
        public UnityEngine.UIElements.VisualElement dragAndDropController; // 0x58
        public UnityEngine.UIElements.VisualElement m_DragHoverSiblingMarker; // 0x60
        public float m_LeftIndentation; // 0x68
        public float m_SiblingBottom; // 0x6C
        public UnityEngine.UIElements.ICollectionDragAndDropController <dragAndDropController>k__BackingField; // 0x70

        // ── Methods ──
        public void get_targetView(){} // RVA: 0x7FFAC9B72030
        public void get_targetScrollView(){} // RVA: 0x7FFAC9B720C0
        public void get_dragAndDropController(){} // RVA: 0x7FFAC2FE9590
        public void set_dragAndDropController(){} // RVA: 0x7FFAC2FE95A0
        public void .ctor(){} // RVA: 0x7FFAC9B720F0
        public void CanStartDrag(){} // RVA: 0x7FFAC9B72280
        public void StartDrag(){} // RVA: 0x7FFAC9B725C0
        public void UpdateDrag(){} // RVA: 0x7FFAC9B728A0
        public void GetVisualMode(){} // RVA: 0x7FFAC9B72BB0
        public void OnDrop(){} // RVA: 0x7FFAC9B72DC0
        public void HandleDragAndScroll(){} // RVA: 0x7FFAC9B73070
        public void HandleAutoExpansion(){} // RVA: 0x7FFAC9B732C0
        public void ApplyDragAndDropUI(){} // RVA: 0x7FFAC9B733D0
        public void TryGetDragPosition(){} // RVA: 0x7FFAC9B73D70
        public void HandleTreePosition(){} // RVA: 0x7FFAC9B74170
        public void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(){} // RVA: 0x7FFAC9B742A0
        public void GetPreviousAndNextItemsIgnoringDraggedItems(){} // RVA: 0x7FFAC9B74A30
        public void MakeDragAndDropArgs(){} // RVA: 0x7FFAC9B74C20
        public void GetHoverBarTopPosition(){} // RVA: 0x7FFAC9B74E00
        public void PlaceHoverBarAtElement(){} // RVA: 0x7FFAC9B74FD0
        public void PlaceHoverBarAt(){} // RVA: 0x7FFAC9B751C0
        public void ClearDragAndDropUI(){} // RVA: 0x7FFAC9B758A0
        public void GetRecycledItem(){} // RVA: 0x7FFAC9B75C60
        public void <ApplyDragAndDropUI>g__GeometryChangedCallback|27_0(){} // RVA: 0x7FFAC9B75E80
    }

    public class ListViewDraggerAnimated : ListViewDragger
    {
        public int isDragging; // 0x78
        public int draggedItem; // 0x7C
        public float supportsDragEvents; // 0x80
        public float m_LocalOffsetOnStart; // 0x84
        public UnityEngine.Vector3 m_CurrentPointerPosition; // 0x88
        public UnityEngine.UIElements.ReusableCollectionItem m_Item; // 0x98
        public UnityEngine.UIElements.ReusableCollectionItem m_OffsetItem; // 0xA0
        public bool <isDragging>k__BackingField; // 0xA8

        // ── Methods ──
        public void get_isDragging(){} // RVA: 0x7FFAC3141F10
        public void set_isDragging(){} // RVA: 0x7FFAC313FE60
        public void get_draggedItem(){} // RVA: 0x7FFAC354DFB0
        public void get_supportsDragEvents(){} // RVA: 0x7FFAC2F21320
        public void .ctor(){} // RVA: 0x7FFAC9B764F0
        public void StartDrag(){} // RVA: 0x7FFAC9B76500
        public void UpdateDrag(){} // RVA: 0x7FFAC9B76E60
        public void Animate(){} // RVA: 0x7FFAC9B77620
        public void OnDrop(){} // RVA: 0x7FFAC9B77A40
        public void ClearDragAndDropUI(){} // RVA: 0x7FFAC2F21310
        public void TryGetDragPosition(){} // RVA: 0x7FFAC9B77F40
    }

    public class ListViewDraggerExtension : Object
    {
        // ── Methods ──
        public void GetRecycledItemFromId(){} // RVA: 0x7FFAC9B761F0
        public void GetRecycledItemFromIndex(){} // RVA: 0x7FFAC9B76370
    }

    public class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
    {
        public UnityEngine.UIElements.BaseListView m_ListView; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B77FB0
        public void HandleDragAndDrop(){} // RVA: 0x7FFAC9B78020
        public void OnDrop(){} // RVA: 0x7FFAC9B780F0
    }

    public class LoadResourceFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9BA8230
        public void Invoke(){} // RVA: 0x7FFAC5CC0310
    }

    public class LongField : TextValueField`1
    {
        public string longInput;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void get_longInput(){} // RVA: 0x7FFAC9B3EA70
        public void ValueToString(){} // RVA: 0x7FFAC9B3EB00
        public void StringToValue(){} // RVA: 0x7FFAC9B3ED10
        public void .ctor(){} // RVA: 0x7FFAC9B3EE00 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFAC9B3F100
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC9B3F1D0
        public void .cctor(){} // RVA: 0x7FFAC9B3F2C0
    }

}