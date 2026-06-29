// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 12
// Methods: 97

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Label : TextElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FF3500
        public void .cctor(){} // RVA: 0x7FF35C0
    }

    public class LanguageDirectionExtensions : Object
    {
        // ── Methods ──
        public void toTextCore(){} // RVA: 0x7F2C250
    }

    public class LayoutData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x9960C0
        public void CopyFrom(){} // RVA: 0x996150
        public void op_Equality(){} // RVA: 0x7ECFB00
        public void Equals(){} // RVA: 0x996300
        public void GetHashCode(){} // RVA: 0x996430
    }

    public class Length : ValueType
    {
        // ── Methods ──
        public void Percent(){} // RVA: 0x7ED6870
        public void Auto(){} // RVA: 0x7ED68B0
        public void None(){} // RVA: 0x7ED68D0
        public void get_value(){} // RVA: 0x88D10
        public void set_value(){} // RVA: 0x996E30
        public void get_unit(){} // RVA: 0x77E50
        public void set_unit(){} // RVA: 0x77EE0
        public void IsAuto(){} // RVA: 0x996E60
        public void IsNone(){} // RVA: 0x996E70
        public void .ctor(){} // RVA: 0x996EB0
        public void op_Implicit(){} // RVA: 0x7ED69A0
        public void op_Equality(){} // RVA: 0x7ED69E0
        public void op_Inequality(){} // RVA: 0x7ED6A10
        public void Equals(){} // RVA: 0x996F10
        public void GetHashCode(){} // RVA: 0x996F20
        public void ToString(){} // RVA: 0x996F50
    }

    public class ListView : BaseListView
    {
        // ── Methods ──
        public void get_makeItem(){} // RVA: 0x164ECC0
        public void set_makeItem(){} // RVA: 0x7FF36D0
        public void get_itemTemplate(){} // RVA: 0x165DB50
        public void set_itemTemplate(){} // RVA: 0x7FF37E0
        public void TemplateMakeItem(){} // RVA: 0x7FF3B00
        public void get_bindItem(){} // RVA: 0x7FF3C60
        public void set_bindItem(){} // RVA: 0x7FF3C70
        public void get_unbindItem(){} // RVA: 0x7FF3D80
        public void set_unbindItem(){} // RVA: 0x7FF3D90
        public void get_destroyItem(){} // RVA: 0x7FF3EA0
        public void set_destroyItem(){} // RVA: 0x7FF3EB0
        public void HasValidDataAndBindings(){} // RVA: 0x7FF3FC0
        public void CreateViewController(){} // RVA: 0x7FF4040
        public void .ctor(){} // RVA: 0x7FF4080
        public void .cctor(){} // RVA: 0x7FF41A0
    }

    public class ListViewController : BaseListViewController
    {
        // ── Methods ──
        public void get_listView(){} // RVA: 0x7E8B980
        public void MakeItem(){} // RVA: 0x7E8BA00
        public void BindItem(){} // RVA: 0x7E8BB10
        public void UnbindItem(){} // RVA: 0x7E8BDA0
        public void DestroyItem(){} // RVA: 0x7E8BDF0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class ListViewDragger : DragEventsProcessor
    {
        // ── Methods ──
        public void get_targetView(){} // RVA: 0x804A010
        public void get_targetScrollView(){} // RVA: 0x804A090
        public void get_dragAndDropController(){} // RVA: 0xCD3320
        public void set_dragAndDropController(){} // RVA: 0xCD4740
        public void get_enabled(){} // RVA: 0xBC03E0
        public void set_enabled(){} // RVA: 0x804A0C0
        public void .ctor(){} // RVA: 0x804A390
        public void CanStartDrag(){} // RVA: 0x804A520
        public void StartDrag(){} // RVA: 0x804A8C0
        public void UpdateDrag(){} // RVA: 0x804ACB0
        public void GetVisualMode(){} // RVA: 0x804AFC0
        public void OnDrop(){} // RVA: 0x804B1E0
        public void HandleDragAndScroll(){} // RVA: 0x804B4A0
        public void HandleAutoExpansion(){} // RVA: 0x804B6E0
        public void ApplyDragAndDropUI(){} // RVA: 0x804B7F0
        public void TryGetDragPosition(){} // RVA: 0x804C130
        public void HandleTreePosition(){} // RVA: 0x804C4F0
        public void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(){} // RVA: 0x804C610
        public void GetPreviousAndNextItemsIgnoringDraggedItems(){} // RVA: 0x804CE40
        public void MakeDragAndDropArgs(){} // RVA: 0x804D030
        public void GetHoverBarTopPosition(){} // RVA: 0x804D220
        public void PlaceHoverBarAtElement(){} // RVA: 0x804D3F0
        public void PlaceHoverBarAt(){} // RVA: 0x804D5E0
        public void ClearDragAndDropUI(){} // RVA: 0x804DCF0
        public void GetRecycledItem(){} // RVA: 0x804E170
        public void IsDraggingDisabled(){} // RVA: 0x804E3A0
        public void <ApplyDragAndDropUI>g__GeometryChangedCallback|31_0(){} // RVA: 0x804E460
    }

    public class ListViewDraggerAnimated : ListViewDragger
    {
        // ── Methods ──
        public void get_isDragging(){} // RVA: 0x2009180
        public void set_isDragging(){} // RVA: 0x20097F0
        public void get_draggedItem(){} // RVA: 0x106A050
        public void get_supportsDragEvents(){} // RVA: 0xB43320
        public void .ctor(){} // RVA: 0x804EAF0
        public void StartDrag(){} // RVA: 0x804EB00
        public void UpdateDrag(){} // RVA: 0x804F420
        public void Animate(){} // RVA: 0x804FC30
        public void OnDrop(){} // RVA: 0x8050010
        public void ClearDragAndDropUI(){} // RVA: 0xB43310
        public void TryGetDragPosition(){} // RVA: 0x8050540
    }

    public class ListViewDraggerExtension : Object
    {
        // ── Methods ──
        public void GetRecycledItemFromId(){} // RVA: 0x804E7D0
        public void GetRecycledItemFromIndex(){} // RVA: 0x804E960
    }

    public class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x80505B0
        public void HandleDragAndDrop(){} // RVA: 0x8050620
        public void OnDrop(){} // RVA: 0x80506F0
    }

    public class LoadResourceFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8086210
        public void Invoke(){} // RVA: 0x3E3DC60
    }

    public class LongField : TextValueField`1
    {
        // ── Methods ──
        public void get_longInput(){} // RVA: 0x7FF4A60
        public void ValueToString(){} // RVA: 0x7FF4AF0
        public void StringToValue(){} // RVA: 0x7FF4D00
        public void .ctor(){} // RVA: 0x7FF4F90
        public void CanTryParse(){} // RVA: 0x7FF52B0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FF5380
        public void .cctor(){} // RVA: 0x7FF5470
    }

}