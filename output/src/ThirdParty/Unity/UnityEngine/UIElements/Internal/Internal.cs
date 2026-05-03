// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.Internal
// Classes: 10
// Methods: 138

namespace ThirdParty.Unity.UnityEngine.UIElements.Internal
{
    public class ColumnMover : PointerManipulator
    {
        public float m_StartPos; // 0x38
        public float m_LastPos; // 0x3C
        public bool m_Active; // 0x40

        // ── Methods ──
        public void get_columnLayout(){} // RVA: 0x7FFE81280C30
        public void set_columnLayout(){} // RVA: 0x7FFE81282380
        public void get_active(){} // RVA: 0x7FFE811B6C00
        public void set_active(){} // RVA: 0x7FFE87ED2400
        public void get_moving(){} // RVA: 0x7FFE814645D0
        public void set_moving(){} // RVA: 0x7FFE87ED2430
        public void add_activeChanged(){} // RVA: 0x7FFE87ED2460
        public void remove_activeChanged(){} // RVA: 0x7FFE87ED2560
        public void add_movingChanged(){} // RVA: 0x7FFE87ED2660
        public void remove_movingChanged(){} // RVA: 0x7FFE87ED2760
        public void .ctor(){} // RVA: 0x7FFE87ED2860
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFE87ED2950
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFE87ED2E40
        public void OnMouseDown(){} // RVA: 0x7FFE87ED3400
        public void OnMouseMove(){} // RVA: 0x7FFE87ED34E0
        public void OnMouseUp(){} // RVA: 0x7FFE87ED3560
        public void OnMouseCaptureOut(){} // RVA: 0x7FFE87ED3680
        public void OnPointerDown(){} // RVA: 0x7FFE87ED3700
        public void OnPointerMove(){} // RVA: 0x7FFE87ED3880
        public void OnPointerUp(){} // RVA: 0x7FFE87ED39D0
        public void OnPointerCancel(){} // RVA: 0x7FFE87ED3B80
        public void OnPointerCaptureOut(){} // RVA: 0x7FFE87ED3C90
        public void IsNotMouseEvent(){} // RVA: 0x7FFE87ED3D50
        public void ProcessCancelEvent(){} // RVA: 0x7FFE87ED3DB0
        public void OnKeyDown(){} // RVA: 0x7FFE87ED3F00
        public void ProcessDownEvent(){} // RVA: 0x7FFE87ED3F70
        public void ProcessMoveEvent(){} // RVA: 0x7FFE87ED4250
        public void ProcessUpEvent(){} // RVA: 0x7FFE87ED4390
        public void BeginDragMove(){} // RVA: 0x7FFE87ED4510
        public void DragMove(){} // RVA: 0x7FFE87ED4CA0
        public void UpdatePreviewPosition(){} // RVA: 0x7FFE87ED4CB0
        public void UpdateMoveLocation(){} // RVA: 0x7FFE87ED4FA0
        public void EndDragMove(){} // RVA: 0x7FFE87ED5230
    }

    public class ColumnResizer : PointerManipulator
    {
        public UnityEngine.Vector2 m_Start; // 0x38
        public bool m_Active; // 0x40

        // ── Methods ──
        public void get_columnLayout(){} // RVA: 0x7FFE81199370
        public void set_columnLayout(){} // RVA: 0x7FFE81199380
        public void get_preview(){} // RVA: 0x7FFE811C3570
        public void set_preview(){} // RVA: 0x7FFE811C3580
        public void .ctor(){} // RVA: 0x7FFE87ED5750
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFE87ED58B0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFE87ED5AD0
        public void OnKeyDown(){} // RVA: 0x7FFE87ED5D00
        public void OnPointerDown(){} // RVA: 0x7FFE87ED5DE0
        public void OnPointerMove(){} // RVA: 0x7FFE87ED6320
        public void OnPointerUp(){} // RVA: 0x7FFE87ED64C0
        public void BeginDragResize(){} // RVA: 0x7FFE87ED66B0
        public void DragResize(){} // RVA: 0x7FFE87ED6700
        public void UpdatePreviewPosition(){} // RVA: 0x7FFE87ED6750
        public void EndDragResize(){} // RVA: 0x7FFE87ED6890
    }

    public class MultiColumnCollectionHeader : VisualElement
    {
        public string ussClassName;
        public string columnContainerUssClassName; // 0x8
        public string handleContainerUssClassName; // 0x10
        public string reorderableUssClassName; // 0x18
        public bool m_SortingEnabled; // 0x3C8
        public System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription> m_SortedColumns; // 0x3D0
        public UnityEngine.UIElements.SortColumnDescriptions m_SortDescriptions; // 0x3D8
        public System.Collections.Generic.List`1<SortedColumnState> m_OldSortedColumnStates; // 0x3E0
        public bool m_SortingUpdatesTemporarilyDisabled; // 0x3E8

        // ── Methods ──
        public void get_isApplyingViewState(){} // RVA: 0x7FFE87ED6940
        public void get_columnDataMap(){} // RVA: 0x7FFE81B0EA50
        public void get_columnLayout(){} // RVA: 0x7FFE81B0AAA0
        public void get_columnContainer(){} // RVA: 0x7FFE81B0E510
        public void get_resizeHandleContainer(){} // RVA: 0x7FFE81B23520
        public void get_sortedColumns(){} // RVA: 0x7FFE81B0DE50
        public void get_sortDescriptions(){} // RVA: 0x7FFE81B0E4A0
        public void set_sortDescriptions(){} // RVA: 0x7FFE87ED6950
        public void get_columns(){} // RVA: 0x7FFE81B33330
        public void get_sortingEnabled(){} // RVA: 0x7FFE87ED6B30
        public void set_sortingEnabled(){} // RVA: 0x7FFE87ED6B40
        public void add_columnResized(){} // RVA: 0x7FFE87ED6B80
        public void remove_columnResized(){} // RVA: 0x7FFE87ED6C80
        public void add_columnSortingChanged(){} // RVA: 0x7FFE87ED6D80
        public void remove_columnSortingChanged(){} // RVA: 0x7FFE87ED6E70
        public void add_contextMenuPopulateEvent(){} // RVA: 0x7FFE87ED6F60
        public void remove_contextMenuPopulateEvent(){} // RVA: 0x7FFE87ED7060
        public void add_viewDataRestored(){} // RVA: 0x7FFE87ED7160
        public void remove_viewDataRestored(){} // RVA: 0x7FFE87ED7250
        public void .ctor(){} // RVA: 0x7FFE87ED7340
        public void ScheduleDoLayout(){} // RVA: 0x7FFE87ED7F60
        public void ResizeToFit(){} // RVA: 0x7FFE87ED8000
        public void UpdateSortedColumns(){} // RVA: 0x7FFE87ED8130
        public void UpdateColumnControls(){} // RVA: 0x7FFE87ED8870
        public void OnColumnAdded(){} // RVA: 0x7FFE87ED8E70 | overloaded x2
        public void OnColumnRemoved(){} // RVA: 0x7FFE87ED9740
        public void OnColumnChanged(){} // RVA: 0x7FFE87ED99F0
        public void OnColumnReordered(){} // RVA: 0x7FFE87ED9A80
        public void OnColumnResized(){} // RVA: 0x7FFE87ED9C60
        public void OnContextualMenuManipulator(){} // RVA: 0x7FFE87ED9CA0
        public void OnMoveManipulatorActivated(){} // RVA: 0x7FFE87EDA610
        public void OnGeometryChanged(){} // RVA: 0x7FFE87EDA6A0
        public void DoLayout(){} // RVA: 0x7FFE87EDA7D0
        public void OnColumnControlGeometryChanged(){} // RVA: 0x7FFE87EDA830
        public void OnColumnClicked(){} // RVA: 0x7FFE87EDAB80
        public void UpdateSortColumnDescriptionsOnClick(){} // RVA: 0x7FFE87EDAD50
        public void ScrollHorizontally(){} // RVA: 0x7FFE87EDB090
        public void RaiseColumnResized(){} // RVA: 0x7FFE87EDB1D0
        public void RaiseColumnSortingChanged(){} // RVA: 0x7FFE87EDB270
        public void ApplyColumnSorting(){} // RVA: 0x7FFE87EDB2B0
        public void UpdateSortingStatus(){} // RVA: 0x7FFE87EDBAA0
        public void OnViewDataReady(){} // RVA: 0x7FFE87EDBFF0
        public void SaveViewState(){} // RVA: 0x7FFE87ED9C60
        public void Dispose(){} // RVA: 0x7FFE87EDC130
        public void .cctor(){} // RVA: 0x7FFE87EDC960
        public void <OnContextualMenuManipulator>b__65_0(){} // RVA: 0x7FFE87ED8000
    }

    public class MultiColumnHeaderColumn : VisualElement
    {
        public string ussClassName;
        public string sortableUssClassName; // 0x8
        public string sortedAscendingUssClassName; // 0x10
        public string sortedDescendingUssClassName; // 0x18
        public string movingUssClassName; // 0x20
        public string contentContainerUssClassName; // 0x28

        // ── Methods ──
        public void get_clickable(){} // RVA: 0x7FFE81B36F60
        public void set_clickable(){} // RVA: 0x7FFE81B26900
        public void get_mover(){} // RVA: 0x7FFE81B2D3E0
        public void set_mover(){} // RVA: 0x7FFE81B15370
        public void set_sortOrderLabel(){} // RVA: 0x7FFE87EDE5B0
        public void get_column(){} // RVA: 0x7FFE81B33040
        public void set_column(){} // RVA: 0x7FFE81B161D0
        public void get_content(){} // RVA: 0x7FFE81B0DE50
        public void set_content(){} // RVA: 0x7FFE87EDE5F0
        public void get_isContentBound(){} // RVA: 0x7FFE87EDECF0
        public void set_isContentBound(){} // RVA: 0x7FFE87EDEDD0
        public void .ctor(){} // RVA: 0x7FFE87EDEE90
        public void InitManipulators(){} // RVA: 0x7FFE87EDF6A0
        public void UpdateDataFromColumn(){} // RVA: 0x7FFE87EDFC80
        public void BindHeaderContent(){} // RVA: 0x7FFE87EDFD90
        public void UnbindHeaderContent(){} // RVA: 0x7FFE87EDFE80
        public void DestroyHeaderContent(){} // RVA: 0x7FFE87EDFF70
        public void CreateDefaultHeaderContent(){} // RVA: 0x7FFE87EE00A0
        public void DefaultBindHeaderContent(){} // RVA: 0x7FFE87EE0400
        public void UpdateHeaderTemplate(){} // RVA: 0x7FFE87EE0870
        public void UpdateGeometryFromColumn(){} // RVA: 0x7FFE87EE0BD0
        public void .cctor(){} // RVA: 0x7FFE87EE0CF0
        public void <.ctor>b__45_0(){} // RVA: 0x7FFE87EE1740
        public void <.ctor>b__45_1(){} // RVA: 0x7FFE87EE1870
        public void <InitManipulators>b__46_0(){} // RVA: 0x7FFE87EE1880
    }

    public class MultiColumnHeaderColumnIcon : Image
    {
        public string ussClassName;

        // ── Methods ──
        public void get_isImageInline(){} // RVA: 0x7FFE86082080
        public void set_isImageInline(){} // RVA: 0x7FFE87EDE0E0
        public void .ctor(){} // RVA: 0x7FFE87EDE0F0
        public void UpdateClassList(){} // RVA: 0x7FFE87EDE200
        public void .cctor(){} // RVA: 0x7FFE87EDE4B0
        public void <.ctor>b__5_0(){} // RVA: 0x7FFE87EDE5A0
    }

    public class MultiColumnHeaderColumnMoveLocationPreview : VisualElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87ED2100
        public void .cctor(){} // RVA: 0x7FFE87ED2270
    }

    public class MultiColumnHeaderColumnMovePreview : VisualElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87ED1F40
        public void .cctor(){} // RVA: 0x7FFE87ED2010
    }

    public class MultiColumnHeaderColumnResizeHandle : VisualElement
    {
        public string ussClassName;

        // ── Methods ──
        public void get_dragArea(){} // RVA: 0x7FFE81B2D3F0
        public void .ctor(){} // RVA: 0x7FFE87EE1930
        public void .cctor(){} // RVA: 0x7FFE87EE1A90
    }

    public class MultiColumnHeaderColumnResizePreview : VisualElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87ED5450
        public void .cctor(){} // RVA: 0x7FFE87ED55C0
    }

    public class MultiColumnHeaderColumnSortIndicator : VisualElement
    {
        public string ussClassName;

        // ── Methods ──
        public void set_sortOrderLabel(){} // RVA: 0x7FFE87EDDBE0
        public void .ctor(){} // RVA: 0x7FFE87EDDC10
        public void .cctor(){} // RVA: 0x7FFE87EDDEA0
    }

}