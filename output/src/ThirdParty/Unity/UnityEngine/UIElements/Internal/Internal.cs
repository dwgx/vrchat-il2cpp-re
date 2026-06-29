// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.Internal
// Classes: 12
// Methods: 156

namespace ThirdParty.Unity.UnityEngine.UIElements.Internal
{
    public class AutoCompletePathVisitor : Object
    {
        public object m_VisitContext;
        public object _maxDepth;

        // ── Methods ──
        public void get_maxDepth(){} // RVA: 0xE62D00
        public void HasReachedEnd(){} // RVA: 0x7FABFA0
        public void Reset(){} // RVA: 0x7FAC020
        public void Unity.Properties.ITypeVisitor.Visit(){} // RVA: 0x894290
        public void Unity.Properties.IPropertyBagVisitor.Visit(){} // RVA: 0x8943B0
        public void Unity.Properties.IPropertyVisitor.Visit(){} // RVA: 0x8943B0
        public void Unity.Properties.IListPropertyVisitor.Visit(){} // RVA: 0x8954D0
        public void VisitPropertyType(){} // RVA: 0x7FAC180
        public void .ctor(){} // RVA: 0x7FAC4D0
    }

    public class ColumnMover : PointerManipulator
    {
        public object m_StartPos;
        public object m_LastPos;
        public object m_Active;
        public object m_Moving;
        public object m_Cancelled;
        public object m_Header;
        public object m_PreviewElement;
        public object m_LocationPreviewElement;
        public object m_ColumnToMove;
        public object m_ColumnToMovePos;
        public object m_ColumnToMoveWidth;
        public object m_DestinationColumn;
        public object m_MoveBeforeDestination;
        public object _columnLayout;
        public object activeChanged;
        public object movingChanged;

        // ── Methods ──
        public void get_columnLayout(){} // RVA: 0xC10050
        public void set_columnLayout(){} // RVA: 0xC10060
        public void get_active(){} // RVA: 0xB68DF0
        public void set_active(){} // RVA: 0x7FADAA0
        public void get_moving(){} // RVA: 0xB68E10
        public void set_moving(){} // RVA: 0x7FADAD0
        public void add_activeChanged(){} // RVA: 0x7FADB00
        public void remove_activeChanged(){} // RVA: 0x7FADC10
        public void add_movingChanged(){} // RVA: 0x7FADD20
        public void remove_movingChanged(){} // RVA: 0x7FADE40
        public void .ctor(){} // RVA: 0x7FADF60
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FAE060
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FAE370
        public void OnPointerDown(){} // RVA: 0x7FAEAB0
        public void OnPointerMove(){} // RVA: 0x7FAEB50
        public void OnPointerUp(){} // RVA: 0x7FAECF0
        public void OnPointerCancel(){} // RVA: 0x7FAEEA0
        public void OnPointerCaptureOut(){} // RVA: 0x7FAEF40
        public void ProcessCancelEvent(){} // RVA: 0x7FAEFA0
        public void OnKeyDown(){} // RVA: 0x7FAF0C0
        public void ProcessDownEvent(){} // RVA: 0x7FAF120
        public void ProcessMoveEvent(){} // RVA: 0x7FAF400
        public void ProcessUpEvent(){} // RVA: 0x7FAF560
        public void BeginDragMove(){} // RVA: 0x7FAF6A0
        public void DragMove(){} // RVA: 0x7FAFEA0
        public void UpdatePreviewPosition(){} // RVA: 0x7FAFEB0
        public void UpdateMoveLocation(){} // RVA: 0x7FB01A0
        public void EndDragMove(){} // RVA: 0x7FB0430
    }

    public class ColumnResizer : PointerManipulator
    {
        public object m_Start;
        public object m_Active;
        public object m_Resizing;
        public object m_Header;
        public object m_Column;
        public object m_PreviewElement;
        public object _columnLayout;
        public object _preview;

        // ── Methods ──
        public void get_columnLayout(){} // RVA: 0xBE58B0
        public void set_columnLayout(){} // RVA: 0xCA4DF0
        public void get_preview(){} // RVA: 0xE3F480
        public void set_preview(){} // RVA: 0x1546550
        public void .ctor(){} // RVA: 0x7FB0970
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FB0AD0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FB0CF0
        public void OnKeyDown(){} // RVA: 0x7FB11F0
        public void OnPointerDown(){} // RVA: 0x7FB12D0
        public void OnPointerMove(){} // RVA: 0x7FB1840
        public void OnPointerUp(){} // RVA: 0x7FB19B0
        public void BeginDragResize(){} // RVA: 0x7FB1B50
        public void DragResize(){} // RVA: 0x7FB1BA0
        public void UpdatePreviewPosition(){} // RVA: 0x7FB1BF0
        public void EndDragResize(){} // RVA: 0x7FB1D30
    }

    public class MultiColumnCollectionHeader : VisualElement
    {
        public object ussClassName;
        public object columnContainerUssClassName;
        public object handleContainerUssClassName;
        public object reorderableUssClassName;
        public object m_SortingEnabled;
        public object m_SortedColumns;
        public object m_SortDescriptions;
        public object m_OldSortedColumnStates;
        public object m_SortingUpdatesTemporarilyDisabled;
        public object m_ViewState;
        public object m_ApplyingViewState;
        public object m_DoLayoutScheduled;
        public object _columnDataMap;
        public object _columnLayout;
        public object _columnContainer;
        public object _resizeHandleContainer;
        public object _columns;
        public object columnResized;
        public object columnSortingChanged;
        public object contextMenuPopulateEvent;
        public object viewDataRestored;

        // ── Methods ──
        public void get_isApplyingViewState(){} // RVA: 0x7FB1DE0
        public void get_columnDataMap(){} // RVA: 0x163D1E0
        public void get_columnLayout(){} // RVA: 0x166DF10
        public void get_columnContainer(){} // RVA: 0x165E400
        public void get_resizeHandleContainer(){} // RVA: 0x163BC90
        public void get_sortedColumns(){} // RVA: 0x166C430
        public void get_sortedColumnReadonly(){} // RVA: 0x166C430
        public void get_sortDescriptions(){} // RVA: 0x16686F0
        public void set_sortDescriptions(){} // RVA: 0x7FB1DF0
        public void get_columns(){} // RVA: 0x1651990
        public void get_sortingEnabled(){} // RVA: 0x7FB1FD0
        public void set_sortingEnabled(){} // RVA: 0x7FB1FE0
        public void add_columnResized(){} // RVA: 0x7FB2020
        public void remove_columnResized(){} // RVA: 0x7FB2140
        public void add_columnSortingChanged(){} // RVA: 0x7FB2260
        public void remove_columnSortingChanged(){} // RVA: 0x7FB2360
        public void add_contextMenuPopulateEvent(){} // RVA: 0x7FB2460
        public void remove_contextMenuPopulateEvent(){} // RVA: 0x7FB2580
        public void add_viewDataRestored(){} // RVA: 0x7FB26A0
        public void remove_viewDataRestored(){} // RVA: 0x7FB27A0
        public void .ctor(){} // RVA: 0x7FB28A0
        public void ScheduleDoLayout(){} // RVA: 0x7FB3480
        public void ResizeToFit(){} // RVA: 0x7FB3520
        public void UpdateSortedColumns(){} // RVA: 0x7FB3560
        public void UpdateColumnControls(){} // RVA: 0x7FB3CB0
        public void OnColumnAdded(){} // RVA: 0x7FB42A0
        public void OnColumnRemoved(){} // RVA: 0x7FB4AA0
        public void OnColumnChanged(){} // RVA: 0x7FB4EF0
        public void OnColumnReordered(){} // RVA: 0x7FB4F80
        public void OnColumnResized(){} // RVA: 0x7FB5160
        public void OnContextualMenuManipulator(){} // RVA: 0x7FB51A0
        public void OnMoveManipulatorActivated(){} // RVA: 0x7FB5B10
        public void OnGeometryChanged(){} // RVA: 0x7FB5BA0
        public void DoLayout(){} // RVA: 0x7FB5D10
        public void OnColumnControlGeometryChanged(){} // RVA: 0x7FB5D70
        public void OnColumnClicked(){} // RVA: 0x7FB6050
        public void UpdateSortColumnDescriptionsOnClick(){} // RVA: 0x7FB6210
        public void ScrollHorizontally(){} // RVA: 0x7FB6530
        public void RaiseColumnResized(){} // RVA: 0x7FB6670
        public void RaiseColumnSortingChanged(){} // RVA: 0x7FB6720
        public void ApplyColumnSorting(){} // RVA: 0x7FB6760
        public void UpdateSortingStatus(){} // RVA: 0x7FB6F60
        public void OnViewDataReady(){} // RVA: 0x7FB74B0
        public void SaveViewState(){} // RVA: 0x7FB5160
        public void CleanupColumnData(){} // RVA: 0x7FB75F0
        public void Dispose(){} // RVA: 0x7FB7960
        public void .cctor(){} // RVA: 0x7FB80E0
        public void <OnContextualMenuManipulator>b__67_0(){} // RVA: 0x7FB3520
    }

    public class MultiColumnHeaderColumn : VisualElement
    {
        public object ussClassName;
        public object sortableUssClassName;
        public object sortedAscendingUssClassName;
        public object sortedDescendingUssClassName;
        public object movingUssClassName;
        public object contentContainerUssClassName;
        public object contentUssClassName;
        public object defaultContentUssClassName;
        public object hasIconUssClassName;
        public object hasTitleUssClassName;
        public object titleUssClassName;
        public object iconElementName;
        public object titleElementName;
        public object s_BoundVEPropertyName;
        public object s_BindingCallbackVEPropertyName;
        public object s_UnbindingCallbackVEPropertyName;
        public object s_DestroyCallbackVEPropertyName;
        public object m_ContentContainer;
        public object m_Content;
        public object m_SortIndicatorContainer;
        public object m_ScheduledHeaderTemplateUpdate;
        public object _clickable;
        public object _mover;
        public object _column;

        // ── Methods ──
        public void get_clickable(){} // RVA: 0x1667CC0
        public void set_clickable(){} // RVA: 0x1649C60
        public void get_mover(){} // RVA: 0x1662E30
        public void set_mover(){} // RVA: 0x1649320
        public void set_sortOrderLabel(){} // RVA: 0x7FB9CA0
        public void get_column(){} // RVA: 0x1663D60
        public void set_column(){} // RVA: 0x165A6E0
        public void get_content(){} // RVA: 0x166C430
        public void set_content(){} // RVA: 0x7FB9CE0
        public void get_isContentBound(){} // RVA: 0x7FBA4D0
        public void set_isContentBound(){} // RVA: 0x7FBA5A0
        public void .ctor(){} // RVA: 0x7FBA650
        public void OnColumnChanged(){} // RVA: 0x7FBAE50
        public void OnColumnResized(){} // RVA: 0x7FBAFA0
        public void InitManipulators(){} // RVA: 0x7FBAFB0
        public void OnMoverChanged(){} // RVA: 0x7FBB560
        public void UpdateDataFromColumn(){} // RVA: 0x7FBB610
        public void BindHeaderContent(){} // RVA: 0x7FBB720
        public void UnbindHeaderContent(){} // RVA: 0x7FBB810
        public void DestroyHeaderContent(){} // RVA: 0x7FBB900
        public void CreateDefaultHeaderContent(){} // RVA: 0x7FBBAC0
        public void DefaultBindHeaderContent(){} // RVA: 0x7FBBD70
        public void UpdateHeaderTemplate(){} // RVA: 0x7FBC1E0
        public void UpdateGeometryFromColumn(){} // RVA: 0x7FBC460
        public void Dispose(){} // RVA: 0x7FBC580
        public void .cctor(){} // RVA: 0x7FBC930
    }

    public class MultiColumnHeaderColumnIcon : Image
    {
        public object ussClassName;
        public object _isImageInline;

        // ── Methods ──
        public void get_isImageInline(){} // RVA: 0x7FB97D0
        public void set_isImageInline(){} // RVA: 0x7FB97E0
        public void .ctor(){} // RVA: 0x7FB97F0
        public void UpdateClassList(){} // RVA: 0x7FB9900
        public void .cctor(){} // RVA: 0x7FB9BA0
        public void <.ctor>b__5_0(){} // RVA: 0x7FB9C90
    }

    public class MultiColumnHeaderColumnMoveLocationPreview : VisualElement
    {
        public object ussClassName;
        public object visualUssClassName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FAD780
        public void .cctor(){} // RVA: 0x7FAD910
    }

    public class MultiColumnHeaderColumnMovePreview : VisualElement
    {
        public object ussClassName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FAD560
        public void .cctor(){} // RVA: 0x7FAD690
    }

    public class MultiColumnHeaderColumnResizeHandle : VisualElement
    {
        public object ussClassName;
        public object dragAreaUssClassName;
        public object _dragArea;

        // ── Methods ──
        public void get_dragArea(){} // RVA: 0x1667E80
        public void .ctor(){} // RVA: 0x7FBD370
        public void .cctor(){} // RVA: 0x7FBD4F0
    }

    public class MultiColumnHeaderColumnResizePreview : VisualElement
    {
        public object ussClassName;
        public object visualUssClassName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FB0650
        public void .cctor(){} // RVA: 0x7FB07E0
    }

    public class MultiColumnHeaderColumnSortIndicator : VisualElement
    {
        public object ussClassName;
        public object arrowUssClassName;
        public object indexLabelUssClassName;
        public object m_IndexLabel;

        // ── Methods ──
        public void set_sortOrderLabel(){} // RVA: 0x7FB92F0
        public void .ctor(){} // RVA: 0x7FB9320
        public void .cctor(){} // RVA: 0x7FB95A0
    }

    public class TypePathVisitor : Object
    {
        public object _path;
        public object _resolvedType;
        public object _returnCode;
        public object m_LastType;
        public object m_PathIndex;

        // ── Methods ──
        public void get_Path(){} // RVA: 0x3931470
        public void set_Path(){} // RVA: 0x7FAD0A0
        public void set_resolvedType(){} // RVA: 0xD5CCD0
        public void get_ReturnCode(){} // RVA: 0x158C700
        public void set_ReturnCode(){} // RVA: 0x158BEC0
        public void Reset(){} // RVA: 0x7FAD140
        public void Unity.Properties.IPropertyBagVisitor.Visit(){} // RVA: 0x8943B0
        public void Unity.Properties.IPropertyVisitor.Visit(){} // RVA: 0x8943B0
        public void Unity.Properties.ITypeVisitor.Visit(){} // RVA: 0x894290
        public void IsLastPartReached(){} // RVA: 0x7FAD290
        public void GetElementType(){} // RVA: 0x7FAD360
        public void .ctor(){} // RVA: 0xB43310
    }

}