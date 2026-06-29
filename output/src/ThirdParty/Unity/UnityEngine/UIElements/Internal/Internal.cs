// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.Internal
// Classes: 10
// Methods: 137

namespace ThirdParty.Unity.UnityEngine.UIElements.Internal
{
    public class ColumnMover : PointerManipulator
    {
        // ── Methods ──
        public void get_columnLayout(){} // RVA: 0x7A825E100
        public void set_columnLayout(){} // RVA: 0x7A825F860
        public void get_active(){} // RVA: 0x7A8193790
        public void set_active(){} // RVA: 0x7AF1717A0
        public void get_moving(){} // RVA: 0x7A83F3AD0
        public void set_moving(){} // RVA: 0x7AF1717D0
        public void add_activeChanged(){} // RVA: 0x7AF171800
        public void remove_activeChanged(){} // RVA: 0x7AF171920
        public void add_movingChanged(){} // RVA: 0x7AF171A40
        public void remove_movingChanged(){} // RVA: 0x7AF171B60
        public void .ctor(){} // RVA: 0x7AF171C80
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7AF171D80
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7AF172270
        public void OnMouseDown(){} // RVA: 0x7AF172830
        public void OnMouseMove(){} // RVA: 0x7AF172910
        public void OnMouseUp(){} // RVA: 0x7AF172990
        public void OnMouseCaptureOut(){} // RVA: 0x7AF172AA0
        public void OnPointerDown(){} // RVA: 0x7AF172B20
        public void OnPointerMove(){} // RVA: 0x7AF172CA0
        public void OnPointerUp(){} // RVA: 0x7AF172DF0
        public void OnPointerCancel(){} // RVA: 0x7AF172F90
        public void OnPointerCaptureOut(){} // RVA: 0x7AF173090
        public void IsNotMouseEvent(){} // RVA: 0x7AF173150
        public void ProcessCancelEvent(){} // RVA: 0x7AF1731B0
        public void OnKeyDown(){} // RVA: 0x7AF1732D0
        public void ProcessDownEvent(){} // RVA: 0x7AF173340
        public void ProcessMoveEvent(){} // RVA: 0x7AF173610
        public void ProcessUpEvent(){} // RVA: 0x7AF173750
        public void BeginDragMove(){} // RVA: 0x7AF173890
        public void DragMove(){} // RVA: 0x7AF174030
        public void UpdatePreviewPosition(){} // RVA: 0x7AF174040
        public void UpdateMoveLocation(){} // RVA: 0x7AF174330
        public void EndDragMove(){} // RVA: 0x7AF1745E0
    }

    public class ColumnResizer : PointerManipulator
    {
        // ── Methods ──
        public void get_columnLayout(){} // RVA: 0x7A8175DF0
        public void set_columnLayout(){} // RVA: 0x7A8175E00
        public void get_preview(){} // RVA: 0x7A81A00C0
        public void set_preview(){} // RVA: 0x7A81A00D0
        public void .ctor(){} // RVA: 0x7AF174B00
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7AF174C60
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7AF174E80
        public void OnKeyDown(){} // RVA: 0x7AF1750B0
        public void OnPointerDown(){} // RVA: 0x7AF175190
        public void OnPointerMove(){} // RVA: 0x7AF1756C0
        public void OnPointerUp(){} // RVA: 0x7AF175810
        public void BeginDragResize(){} // RVA: 0x7AF175990
        public void DragResize(){} // RVA: 0x7AF1759E0
        public void UpdatePreviewPosition(){} // RVA: 0x7AF175A30
        public void EndDragResize(){} // RVA: 0x7AF175B70
    }

    public class MultiColumnCollectionHeader : VisualElement
    {
        // ── Methods ──
        public void get_isApplyingViewState(){} // RVA: 0x7AF175C20
        public void get_columnDataMap(){} // RVA: 0x7A8B4F050
        public void get_columnLayout(){} // RVA: 0x7A8B7A130
        public void get_columnContainer(){} // RVA: 0x7A8B798E0
        public void get_resizeHandleContainer(){} // RVA: 0x7A8B6B210
        public void get_sortedColumns(){} // RVA: 0x7A8B52950
        public void get_sortDescriptions(){} // RVA: 0x7A8B64520
        public void set_sortDescriptions(){} // RVA: 0x7AF175C30
        public void get_columns(){} // RVA: 0x7A8B5BCB0
        public void get_sortingEnabled(){} // RVA: 0x7AF175E10
        public void set_sortingEnabled(){} // RVA: 0x7AF175E20
        public void add_columnResized(){} // RVA: 0x7AF175E60
        public void remove_columnResized(){} // RVA: 0x7AF175F80
        public void add_columnSortingChanged(){} // RVA: 0x7AF1760A0
        public void remove_columnSortingChanged(){} // RVA: 0x7AF1761A0
        public void add_contextMenuPopulateEvent(){} // RVA: 0x7AF1762A0
        public void remove_contextMenuPopulateEvent(){} // RVA: 0x7AF1763C0
        public void add_viewDataRestored(){} // RVA: 0x7AF1764E0
        public void remove_viewDataRestored(){} // RVA: 0x7AF1765E0
        public void .ctor(){} // RVA: 0x7AF1766E0
        public void ScheduleDoLayout(){} // RVA: 0x7AF177300
        public void ResizeToFit(){} // RVA: 0x7AF1773A0
        public void UpdateSortedColumns(){} // RVA: 0x7AF1774E0
        public void UpdateColumnControls(){} // RVA: 0x7AF177C30
        public void OnColumnAdded(){} // RVA: 0x7AF178220
        public void OnColumnRemoved(){} // RVA: 0x7AF178AF0
        public void OnColumnChanged(){} // RVA: 0x7AF178DA0
        public void OnColumnReordered(){} // RVA: 0x7AF178E30
        public void OnColumnResized(){} // RVA: 0x7AF179010
        public void OnContextualMenuManipulator(){} // RVA: 0x7AF179050
        public void OnMoveManipulatorActivated(){} // RVA: 0x7AF1799C0
        public void OnGeometryChanged(){} // RVA: 0x7AF179A50
        public void DoLayout(){} // RVA: 0x7AF179B80
        public void OnColumnControlGeometryChanged(){} // RVA: 0x7AF179BE0
        public void OnColumnClicked(){} // RVA: 0x7AF179F10
        public void UpdateSortColumnDescriptionsOnClick(){} // RVA: 0x7AF17A0D0
        public void ScrollHorizontally(){} // RVA: 0x7AF17A420
        public void RaiseColumnResized(){} // RVA: 0x7AF17A560
        public void RaiseColumnSortingChanged(){} // RVA: 0x7AF17A600
        public void ApplyColumnSorting(){} // RVA: 0x7AF17A640
        public void UpdateSortingStatus(){} // RVA: 0x7AF17AE40
        public void OnViewDataReady(){} // RVA: 0x7AF17B390
        public void SaveViewState(){} // RVA: 0x7AF179010
        public void Dispose(){} // RVA: 0x7AF17B4D0
        public void .cctor(){} // RVA: 0x7AF17BD00
        public void <OnContextualMenuManipulator>b__65_0(){} // RVA: 0x7AF1773A0
    }

    public class MultiColumnHeaderColumn : VisualElement
    {
        // ── Methods ──
        public void get_clickable(){} // RVA: 0x7A8B45DF0
        public void set_clickable(){} // RVA: 0x7A8B4DDD0
        public void get_mover(){} // RVA: 0x7A8B5EBF0
        public void set_mover(){} // RVA: 0x7A8B67AD0
        public void set_sortOrderLabel(){} // RVA: 0x7AF17D910
        public void get_column(){} // RVA: 0x7A8B794A0
        public void set_column(){} // RVA: 0x7A8B4D070
        public void get_content(){} // RVA: 0x7A8B52950
        public void set_content(){} // RVA: 0x7AF17D950
        public void get_isContentBound(){} // RVA: 0x7AF17E060
        public void set_isContentBound(){} // RVA: 0x7AF17E140
        public void .ctor(){} // RVA: 0x7AF17E200
        public void InitManipulators(){} // RVA: 0x7AF17E9E0
        public void UpdateDataFromColumn(){} // RVA: 0x7AF17EF90
        public void BindHeaderContent(){} // RVA: 0x7AF17F0A0
        public void UnbindHeaderContent(){} // RVA: 0x7AF17F190
        public void DestroyHeaderContent(){} // RVA: 0x7AF17F280
        public void CreateDefaultHeaderContent(){} // RVA: 0x7AF17F3B0
        public void DefaultBindHeaderContent(){} // RVA: 0x7AF17F710
        public void UpdateHeaderTemplate(){} // RVA: 0x7AF17FB80
        public void UpdateGeometryFromColumn(){} // RVA: 0x7AF17FEE0
        public void .cctor(){} // RVA: 0x7AF180000
        public void <.ctor>b__45_0(){} // RVA: 0x7AF180A40
        public void <.ctor>b__45_1(){} // RVA: 0x7AF180B70
        public void <InitManipulators>b__46_0(){} // RVA: 0x7AF180B80
    }

    public class MultiColumnHeaderColumnIcon : Image
    {
        // ── Methods ──
        public void get_isImageInline(){} // RVA: 0x7AD3A0B50
        public void set_isImageInline(){} // RVA: 0x7AF17D450
        public void .ctor(){} // RVA: 0x7AF17D460
        public void UpdateClassList(){} // RVA: 0x7AF17D570
        public void .cctor(){} // RVA: 0x7AF17D810
        public void <.ctor>b__5_0(){} // RVA: 0x7AF17D900
    }

    public class MultiColumnHeaderColumnMoveLocationPreview : VisualElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF1714A0
        public void .cctor(){} // RVA: 0x7AF171610
    }

    public class MultiColumnHeaderColumnMovePreview : VisualElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF1712E0
        public void .cctor(){} // RVA: 0x7AF1713B0
    }

    public class MultiColumnHeaderColumnResizeHandle : VisualElement
    {
        // ── Methods ──
        public void get_dragArea(){} // RVA: 0x7A8B5AB10
        public void .ctor(){} // RVA: 0x7AF180C30
        public void .cctor(){} // RVA: 0x7AF180D90
    }

    public class MultiColumnHeaderColumnResizePreview : VisualElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF174800
        public void .cctor(){} // RVA: 0x7AF174970
    }

    public class MultiColumnHeaderColumnSortIndicator : VisualElement
    {
        // ── Methods ──
        public void set_sortOrderLabel(){} // RVA: 0x7AF17CF60
        public void .ctor(){} // RVA: 0x7AF17CF90
        public void .cctor(){} // RVA: 0x7AF17D220
    }

}