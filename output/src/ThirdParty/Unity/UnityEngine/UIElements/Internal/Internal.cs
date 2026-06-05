// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.Internal
// Classes: 10
// Methods: 138

namespace ThirdParty.Unity.UnityEngine.UIElements.Internal
{
    public class ColumnMover
    {
        // ── Methods ──
        public void get_columnLayout(){} // RVA: 0x7FFAF2F12D00
        public void set_columnLayout(){} // RVA: 0x7FFAF2F14450
        public void get_active(){} // RVA: 0x7FFAF2E48C00
        public void set_active(){} // RVA: 0x7FFAF9E42280
        public void get_moving(){} // RVA: 0x7FFAF310EEC0
        public void set_moving(){} // RVA: 0x7FFAF9E422B0
        public void add_activeChanged(){} // RVA: 0x7FFAF9E422E0
        public void remove_activeChanged(){} // RVA: 0x7FFAF9E423E0
        public void add_movingChanged(){} // RVA: 0x7FFAF9E424E0
        public void remove_movingChanged(){} // RVA: 0x7FFAF9E425E0
        public void .ctor(){} // RVA: 0x7FFAF9E426E0
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFAF9E427D0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFAF9E42CC0
        public void OnMouseDown(){} // RVA: 0x7FFAF9E43280
        public void OnMouseMove(){} // RVA: 0x7FFAF9E43360
        public void OnMouseUp(){} // RVA: 0x7FFAF9E433E0
        public void OnMouseCaptureOut(){} // RVA: 0x7FFAF9E43500
        public void OnPointerDown(){} // RVA: 0x7FFAF9E43580
        public void OnPointerMove(){} // RVA: 0x7FFAF9E43700
        public void OnPointerUp(){} // RVA: 0x7FFAF9E43850
        public void OnPointerCancel(){} // RVA: 0x7FFAF9E43A00
        public void OnPointerCaptureOut(){} // RVA: 0x7FFAF9E43B10
        public void IsNotMouseEvent(){} // RVA: 0x7FFAF9E43BD0
        public void ProcessCancelEvent(){} // RVA: 0x7FFAF9E43C30
        public void OnKeyDown(){} // RVA: 0x7FFAF9E43D80
        public void ProcessDownEvent(){} // RVA: 0x7FFAF9E43DF0
        public void ProcessMoveEvent(){} // RVA: 0x7FFAF9E440D0
        public void ProcessUpEvent(){} // RVA: 0x7FFAF9E44210
        public void BeginDragMove(){} // RVA: 0x7FFAF9E44390
        public void DragMove(){} // RVA: 0x7FFAF9E44B20
        public void UpdatePreviewPosition(){} // RVA: 0x7FFAF9E44B30
        public void UpdateMoveLocation(){} // RVA: 0x7FFAF9E44E20
        public void EndDragMove(){} // RVA: 0x7FFAF9E450B0
    }

    public class ColumnResizer
    {
        // ── Methods ──
        public void get_columnLayout(){} // RVA: 0x7FFAF2E2B370
        public void set_columnLayout(){} // RVA: 0x7FFAF2E2B380
        public void get_preview(){} // RVA: 0x7FFAF2E55570
        public void set_preview(){} // RVA: 0x7FFAF2E55580
        public void .ctor(){} // RVA: 0x7FFAF9E455D0
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFAF9E45730
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFAF9E45950
        public void OnKeyDown(){} // RVA: 0x7FFAF9E45B80
        public void OnPointerDown(){} // RVA: 0x7FFAF9E45C60
        public void OnPointerMove(){} // RVA: 0x7FFAF9E461A0
        public void OnPointerUp(){} // RVA: 0x7FFAF9E46340
        public void BeginDragResize(){} // RVA: 0x7FFAF9E46530
        public void DragResize(){} // RVA: 0x7FFAF9E46580
        public void UpdatePreviewPosition(){} // RVA: 0x7FFAF9E465D0
        public void EndDragResize(){} // RVA: 0x7FFAF9E46710
    }

    public class MultiColumnCollectionHeader
    {
        // ── Methods ──
        public void get_isApplyingViewState(){} // RVA: 0x7FFAF9E467C0
        public void get_columnDataMap(){} // RVA: 0x7FFAF383BD40
        public void get_columnLayout(){} // RVA: 0x7FFAF3864C80
        public void get_columnContainer(){} // RVA: 0x7FFAF38645F0
        public void get_resizeHandleContainer(){} // RVA: 0x7FFAF3856540
        public void get_sortedColumns(){} // RVA: 0x7FFAF383F1C0
        public void get_sortDescriptions(){} // RVA: 0x7FFAF3850010
        public void set_sortDescriptions(){} // RVA: 0x7FFAF9E467D0
        public void get_columns(){} // RVA: 0x7FFAF3847D80
        public void get_sortingEnabled(){} // RVA: 0x7FFAF9E469B0
        public void set_sortingEnabled(){} // RVA: 0x7FFAF9E469C0
        public void add_columnResized(){} // RVA: 0x7FFAF9E46A00
        public void remove_columnResized(){} // RVA: 0x7FFAF9E46B00
        public void add_columnSortingChanged(){} // RVA: 0x7FFAF9E46C00
        public void remove_columnSortingChanged(){} // RVA: 0x7FFAF9E46CF0
        public void add_contextMenuPopulateEvent(){} // RVA: 0x7FFAF9E46DE0
        public void remove_contextMenuPopulateEvent(){} // RVA: 0x7FFAF9E46EE0
        public void add_viewDataRestored(){} // RVA: 0x7FFAF9E46FE0
        public void remove_viewDataRestored(){} // RVA: 0x7FFAF9E470D0
        public void .ctor(){} // RVA: 0x7FFAF9E471C0
        public void ScheduleDoLayout(){} // RVA: 0x7FFAF9E47DE0
        public void ResizeToFit(){} // RVA: 0x7FFAF9E47E80
        public void UpdateSortedColumns(){} // RVA: 0x7FFAF9E47FB0
        public void UpdateColumnControls(){} // RVA: 0x7FFAF9E486F0
        public void OnColumnAdded(){} // RVA: 0x7FFAF9E48CF0 | overloaded x2
        public void OnColumnRemoved(){} // RVA: 0x7FFAF9E495C0
        public void OnColumnChanged(){} // RVA: 0x7FFAF9E49870
        public void OnColumnReordered(){} // RVA: 0x7FFAF9E49900
        public void OnColumnResized(){} // RVA: 0x7FFAF9E49AE0
        public void OnContextualMenuManipulator(){} // RVA: 0x7FFAF9E49B20
        public void OnMoveManipulatorActivated(){} // RVA: 0x7FFAF9E4A490
        public void OnGeometryChanged(){} // RVA: 0x7FFAF9E4A520
        public void DoLayout(){} // RVA: 0x7FFAF9E4A650
        public void OnColumnControlGeometryChanged(){} // RVA: 0x7FFAF9E4A6B0
        public void OnColumnClicked(){} // RVA: 0x7FFAF9E4AA00
        public void UpdateSortColumnDescriptionsOnClick(){} // RVA: 0x7FFAF9E4ABD0
        public void ScrollHorizontally(){} // RVA: 0x7FFAF9E4AF10
        public void RaiseColumnResized(){} // RVA: 0x7FFAF9E4B050
        public void RaiseColumnSortingChanged(){} // RVA: 0x7FFAF9E4B0F0
        public void ApplyColumnSorting(){} // RVA: 0x7FFAF9E4B130
        public void UpdateSortingStatus(){} // RVA: 0x7FFAF9E4B920
        public void OnViewDataReady(){} // RVA: 0x7FFAF9E4BE70
        public void SaveViewState(){} // RVA: 0x7FFAF9E49AE0
        public void Dispose(){} // RVA: 0x7FFAF9E4BFB0
        public void .cctor(){} // RVA: 0x7FFAF9E4C7E0
        public void <OnContextualMenuManipulator>b__65_0(){} // RVA: 0x7FFAF9E47E80
    }

    public class MultiColumnHeaderColumn
    {
        // ── Methods ──
        public void get_clickable(){} // RVA: 0x7FFAF3832EC0
        public void set_clickable(){} // RVA: 0x7FFAF383AC30
        public void get_mover(){} // RVA: 0x7FFAF384AA80
        public void set_mover(){} // RVA: 0x7FFAF3853230
        public void set_sortOrderLabel(){} // RVA: 0x7FFAF9E4E430
        public void get_column(){} // RVA: 0x7FFAF38641B0
        public void set_column(){} // RVA: 0x7FFAF3839FD0
        public void get_content(){} // RVA: 0x7FFAF383F1C0
        public void set_content(){} // RVA: 0x7FFAF9E4E470
        public void get_isContentBound(){} // RVA: 0x7FFAF9E4EB70
        public void set_isContentBound(){} // RVA: 0x7FFAF9E4EC50
        public void .ctor(){} // RVA: 0x7FFAF9E4ED10
        public void InitManipulators(){} // RVA: 0x7FFAF9E4F520
        public void UpdateDataFromColumn(){} // RVA: 0x7FFAF9E4FB00
        public void BindHeaderContent(){} // RVA: 0x7FFAF9E4FC10
        public void UnbindHeaderContent(){} // RVA: 0x7FFAF9E4FD00
        public void DestroyHeaderContent(){} // RVA: 0x7FFAF9E4FDF0
        public void CreateDefaultHeaderContent(){} // RVA: 0x7FFAF9E4FF20
        public void DefaultBindHeaderContent(){} // RVA: 0x7FFAF9E50280
        public void UpdateHeaderTemplate(){} // RVA: 0x7FFAF9E506F0
        public void UpdateGeometryFromColumn(){} // RVA: 0x7FFAF9E50A50
        public void .cctor(){} // RVA: 0x7FFAF9E50B70
        public void <.ctor>b__45_0(){} // RVA: 0x7FFAF9E515C0
        public void <.ctor>b__45_1(){} // RVA: 0x7FFAF9E516F0
        public void <InitManipulators>b__46_0(){} // RVA: 0x7FFAF9E51700
    }

    public class MultiColumnHeaderColumnIcon
    {
        // ── Methods ──
        public void get_isImageInline(){} // RVA: 0x7FFAF807B6E0
        public void set_isImageInline(){} // RVA: 0x7FFAF9E4DF60
        public void .ctor(){} // RVA: 0x7FFAF9E4DF70
        public void UpdateClassList(){} // RVA: 0x7FFAF9E4E080
        public void .cctor(){} // RVA: 0x7FFAF9E4E330
        public void <.ctor>b__5_0(){} // RVA: 0x7FFAF9E4E420
    }

    public class MultiColumnHeaderColumnMoveLocationPreview
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9E41F80
        public void .cctor(){} // RVA: 0x7FFAF9E420F0
    }

    public class MultiColumnHeaderColumnMovePreview
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9E41DC0
        public void .cctor(){} // RVA: 0x7FFAF9E41E90
    }

    public class MultiColumnHeaderColumnResizeHandle
    {
        // ── Methods ──
        public void get_dragArea(){} // RVA: 0x7FFAF3846B00
        public void .ctor(){} // RVA: 0x7FFAF9E517B0
        public void .cctor(){} // RVA: 0x7FFAF9E51910
    }

    public class MultiColumnHeaderColumnResizePreview
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9E452D0
        public void .cctor(){} // RVA: 0x7FFAF9E45440
    }

    public class MultiColumnHeaderColumnSortIndicator
    {
        // ── Methods ──
        public void set_sortOrderLabel(){} // RVA: 0x7FFAF9E4DA60
        public void .ctor(){} // RVA: 0x7FFAF9E4DA90
        public void .cctor(){} // RVA: 0x7FFAF9E4DD20
    }

}