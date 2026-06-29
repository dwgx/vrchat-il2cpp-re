// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 11
// Methods: 84

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Label : TextElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF186080
        public void .cctor(){} // RVA: 0x7AF186140
    }

    public class LayoutData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7A7F074E0
        public void CopyFrom(){} // RVA: 0x7A7F07570
        public void op_Equality(){} // RVA: 0x7AF23E1B0
        public void Equals(){} // RVA: 0x7A7F07720
        public void GetHashCode(){} // RVA: 0x7A7F07850
    }

    public class Length : ValueType
    {
        // ── Methods ──
        public void Percent(){} // RVA: 0x7AF244690
        public void Auto(){} // RVA: 0x7AF2446D0
        public void None(){} // RVA: 0x7AF2446F0
        public void get_value(){} // RVA: 0x7A7673D20
        public void set_value(){} // RVA: 0x7A7F080A0
        public void get_unit(){} // RVA: 0x7A765F0A0
        public void IsAuto(){} // RVA: 0x7A7F080D0
        public void IsNone(){} // RVA: 0x7A7F080E0
        public void .ctor(){} // RVA: 0x7A7F08120
        public void op_Implicit(){} // RVA: 0x7AF2447C0
        public void op_Equality(){} // RVA: 0x7AF21B340
        public void op_Inequality(){} // RVA: 0x7AF244800
        public void Equals(){} // RVA: 0x7A7F08150
        public void GetHashCode(){} // RVA: 0x7A7F06660
        public void ToString(){} // RVA: 0x7A7F08160
    }

    public class ListView : BaseListView
    {
        // ── Methods ──
        public void get_makeItem(){} // RVA: 0x7A8B65870
        public void get_bindItem(){} // RVA: 0x7A8B67720
        public void get_unbindItem(){} // RVA: 0x7A8B76290
        public void get_destroyItem(){} // RVA: 0x7A8B54620
        public void HasValidDataAndBindings(){} // RVA: 0x7AF186250
        public void CreateViewController(){} // RVA: 0x7AF1862B0
        public void .ctor(){} // RVA: 0x7AF1862F0
    }

    public class ListViewController : BaseListViewController
    {
        // ── Methods ──
        public void get_listView(){} // RVA: 0x7AF0D2E00
        public void MakeItem(){} // RVA: 0x7AF0D2E80
        public void BindItem(){} // RVA: 0x7AF0D2FC0
        public void UnbindItem(){} // RVA: 0x7AF0D3220
        public void DestroyItem(){} // RVA: 0x7AF0D3270
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class ListViewDragger : DragEventsProcessor
    {
        // ── Methods ──
        public void get_targetView(){} // RVA: 0x7AF1B97E0
        public void get_targetScrollView(){} // RVA: 0x7AF1B9860
        public void get_dragAndDropController(){} // RVA: 0x7A81A00E0
        public void set_dragAndDropController(){} // RVA: 0x7A81A00F0
        public void .ctor(){} // RVA: 0x7AF1B9890
        public void CanStartDrag(){} // RVA: 0x7AF1B9A20
        public void StartDrag(){} // RVA: 0x7AF1B9D60
        public void UpdateDrag(){} // RVA: 0x7AF1BA040
        public void GetVisualMode(){} // RVA: 0x7AF1BA350
        public void OnDrop(){} // RVA: 0x7AF1BA570
        public void HandleDragAndScroll(){} // RVA: 0x7AF1BA820
        public void HandleAutoExpansion(){} // RVA: 0x7AF1BAA60
        public void ApplyDragAndDropUI(){} // RVA: 0x7AF1BAB70
        public void TryGetDragPosition(){} // RVA: 0x7AF1BB510
        public void HandleTreePosition(){} // RVA: 0x7AF1BB920
        public void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(){} // RVA: 0x7AF1BBA40
        public void GetPreviousAndNextItemsIgnoringDraggedItems(){} // RVA: 0x7AF1BC1B0
        public void MakeDragAndDropArgs(){} // RVA: 0x7AF1BC3A0
        public void GetHoverBarTopPosition(){} // RVA: 0x7AF1BC590
        public void PlaceHoverBarAtElement(){} // RVA: 0x7AF1BC760
        public void PlaceHoverBarAt(){} // RVA: 0x7AF1BC950
        public void ClearDragAndDropUI(){} // RVA: 0x7AF1BD060
        public void GetRecycledItem(){} // RVA: 0x7AF1BD4E0
        public void <ApplyDragAndDropUI>g__GeometryChangedCallback|27_0(){} // RVA: 0x7AF1BD710
    }

    public class ListViewDraggerAnimated : ListViewDragger
    {
        // ── Methods ──
        public void get_isDragging(){} // RVA: 0x7A835F4E0
        public void set_isDragging(){} // RVA: 0x7A8357960
        public void get_draggedItem(){} // RVA: 0x7A87D9C10
        public void get_supportsDragEvents(){} // RVA: 0x7A80D7320
        public void .ctor(){} // RVA: 0x7AF1BDDA0
        public void StartDrag(){} // RVA: 0x7AF1BDDB0
        public void UpdateDrag(){} // RVA: 0x7AF1BE710
        public void Animate(){} // RVA: 0x7AF1BEEC0
        public void OnDrop(){} // RVA: 0x7AF1BF2E0
        public void ClearDragAndDropUI(){} // RVA: 0x7A80D7310
        public void TryGetDragPosition(){} // RVA: 0x7AF1BF7F0
    }

    public class ListViewDraggerExtension : Object
    {
        // ── Methods ──
        public void GetRecycledItemFromId(){} // RVA: 0x7AF1BDA80
        public void GetRecycledItemFromIndex(){} // RVA: 0x7AF1BDC10
    }

    public class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF1BF860
        public void HandleDragAndDrop(){} // RVA: 0x7AF1BF8D0
        public void OnDrop(){} // RVA: 0x7AF1BF9A0
    }

    public class LoadResourceFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF1EFA30
        public void Invoke(){} // RVA: 0x7AB1A8400
    }

    public class LongField : TextValueField`1
    {
        // ── Methods ──
        public void get_longInput(){} // RVA: 0x7AF1863C0
        public void ValueToString(){} // RVA: 0x7AF186450
        public void StringToValue(){} // RVA: 0x7AF186660
        public void .ctor(){} // RVA: 0x7AF186750
        public void CanTryParse(){} // RVA: 0x7AF186A50
        public void ApplyInputDeviceDelta(){} // RVA: 0x7AF186B20
        public void .cctor(){} // RVA: 0x7AF186C10
    }

}