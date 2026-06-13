// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.Internal
// Classes: 10
// Methods: 138

namespace ThirdParty.Unity.UnityEngine.UIElements.Internal
{
    public class ColumnMover
    {
        public float m_StartPos; // 0x38
        public float m_LastPos; // 0x3C
        public bool m_Active; // 0x40

        // ── Methods ──
        public void get_columnLayout(){} // RVA: 0x462D00
        public void set_columnLayout(){} // RVA: 0x464450
        public void get_active(){} // RVA: 0x398C00
        public void set_active(){} // RVA: 0x7392280
        public void get_moving(){} // RVA: 0x65EEC0
        public void set_moving(){} // RVA: 0x73922B0
        public void add_activeChanged(){} // RVA: 0x73922E0
        public void remove_activeChanged(){} // RVA: 0x73923E0
        public void add_movingChanged(){} // RVA: 0x73924E0
        public void remove_movingChanged(){} // RVA: 0x73925E0
        public void .ctor(){} // RVA: 0x73926E0
        public void RegisterCallbacksOnTarget(){} // RVA: 0x73927D0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7392CC0
        public void OnMouseDown(){} // RVA: 0x7393280
        public void OnMouseMove(){} // RVA: 0x7393360
        public void OnMouseUp(){} // RVA: 0x73933E0
        public void OnMouseCaptureOut(){} // RVA: 0x7393500
        public void OnPointerDown(){} // RVA: 0x7393580
        public void OnPointerMove(){} // RVA: 0x7393700
        public void OnPointerUp(){} // RVA: 0x7393850
        public void OnPointerCancel(){} // RVA: 0x7393A00
        public void OnPointerCaptureOut(){} // RVA: 0x7393B10
        public void IsNotMouseEvent(){} // RVA: 0x7393BD0
        public void ProcessCancelEvent(){} // RVA: 0x7393C30
        public void OnKeyDown(){} // RVA: 0x7393D80
        public void ProcessDownEvent(){} // RVA: 0x7393DF0
        public void ProcessMoveEvent(){} // RVA: 0x73940D0
        public void ProcessUpEvent(){} // RVA: 0x7394210
        public void BeginDragMove(){} // RVA: 0x7394390
        public void DragMove(){} // RVA: 0x7394B20
        public void UpdatePreviewPosition(){} // RVA: 0x7394B30
        public void UpdateMoveLocation(){} // RVA: 0x7394E20
        public void EndDragMove(){} // RVA: 0x73950B0
    }

    public class ColumnResizer
    {
        public UnityEngine.Vector2 m_Start; // 0x38
        public bool m_Active; // 0x40

        // ── Methods ──
        public void get_columnLayout(){} // RVA: 0x37B370
        public void set_columnLayout(){} // RVA: 0x37B380
        public void get_preview(){} // RVA: 0x3A5570
        public void set_preview(){} // RVA: 0x3A5580
        public void .ctor(){} // RVA: 0x73955D0
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7395730
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7395950
        public void OnKeyDown(){} // RVA: 0x7395B80
        public void OnPointerDown(){} // RVA: 0x7395C60
        public void OnPointerMove(){} // RVA: 0x73961A0
        public void OnPointerUp(){} // RVA: 0x7396340
        public void BeginDragResize(){} // RVA: 0x7396530
        public void DragResize(){} // RVA: 0x7396580
        public void UpdatePreviewPosition(){} // RVA: 0x73965D0
        public void EndDragResize(){} // RVA: 0x7396710
    }

    public class MultiColumnCollectionHeader
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
        public void get_isApplyingViewState(){} // RVA: 0x73967C0
        public void get_columnDataMap(){} // RVA: 0xD8BD40
        public void get_columnLayout(){} // RVA: 0xDB4C80
        public void get_columnContainer(){} // RVA: 0xDB45F0
        public void get_resizeHandleContainer(){} // RVA: 0xDA6540
        public void get_sortedColumns(){} // RVA: 0xD8F1C0
        public void get_sortDescriptions(){} // RVA: 0xDA0010
        public void set_sortDescriptions(){} // RVA: 0x73967D0
        public void get_columns(){} // RVA: 0xD97D80
        public void get_sortingEnabled(){} // RVA: 0x73969B0
        public void set_sortingEnabled(){} // RVA: 0x73969C0
        public void add_columnResized(){} // RVA: 0x7396A00
        public void remove_columnResized(){} // RVA: 0x7396B00
        public void add_columnSortingChanged(){} // RVA: 0x7396C00
        public void remove_columnSortingChanged(){} // RVA: 0x7396CF0
        public void add_contextMenuPopulateEvent(){} // RVA: 0x7396DE0
        public void remove_contextMenuPopulateEvent(){} // RVA: 0x7396EE0
        public void add_viewDataRestored(){} // RVA: 0x7396FE0
        public void remove_viewDataRestored(){} // RVA: 0x73970D0
        public void .ctor(){} // RVA: 0x73971C0
        public void ScheduleDoLayout(){} // RVA: 0x7397DE0
        public void ResizeToFit(){} // RVA: 0x7397E80
        public void UpdateSortedColumns(){} // RVA: 0x7397FB0
        public void UpdateColumnControls(){} // RVA: 0x73986F0
        public void OnColumnAdded(){} // RVA: 0x7398CF0 | overloaded x2
        public void OnColumnRemoved(){} // RVA: 0x73995C0
        public void OnColumnChanged(){} // RVA: 0x7399870
        public void OnColumnReordered(){} // RVA: 0x7399900
        public void OnColumnResized(){} // RVA: 0x7399AE0
        public void OnContextualMenuManipulator(){} // RVA: 0x7399B20
        public void OnMoveManipulatorActivated(){} // RVA: 0x739A490
        public void OnGeometryChanged(){} // RVA: 0x739A520
        public void DoLayout(){} // RVA: 0x739A650
        public void OnColumnControlGeometryChanged(){} // RVA: 0x739A6B0
        public void OnColumnClicked(){} // RVA: 0x739AA00
        public void UpdateSortColumnDescriptionsOnClick(){} // RVA: 0x739ABD0
        public void ScrollHorizontally(){} // RVA: 0x739AF10
        public void RaiseColumnResized(){} // RVA: 0x739B050
        public void RaiseColumnSortingChanged(){} // RVA: 0x739B0F0
        public void ApplyColumnSorting(){} // RVA: 0x739B130
        public void UpdateSortingStatus(){} // RVA: 0x739B920
        public void OnViewDataReady(){} // RVA: 0x739BE70
        public void SaveViewState(){} // RVA: 0x7399AE0
        public void Dispose(){} // RVA: 0x739BFB0
        public void .cctor(){} // RVA: 0x739C7E0
        public void <OnContextualMenuManipulator>b__65_0(){} // RVA: 0x7397E80
    }

    public class MultiColumnHeaderColumn
    {
        public string ussClassName;
        public string sortableUssClassName; // 0x8
        public string sortedAscendingUssClassName; // 0x10
        public string sortedDescendingUssClassName; // 0x18
        public string movingUssClassName; // 0x20
        public string contentContainerUssClassName; // 0x28

        // ── Methods ──
        public void get_clickable(){} // RVA: 0xD82EC0
        public void set_clickable(){} // RVA: 0xD8AC30
        public void get_mover(){} // RVA: 0xD9AA80
        public void set_mover(){} // RVA: 0xDA3230
        public void set_sortOrderLabel(){} // RVA: 0x739E430
        public void get_column(){} // RVA: 0xDB41B0
        public void set_column(){} // RVA: 0xD89FD0
        public void get_content(){} // RVA: 0xD8F1C0
        public void set_content(){} // RVA: 0x739E470
        public void get_isContentBound(){} // RVA: 0x739EB70
        public void set_isContentBound(){} // RVA: 0x739EC50
        public void .ctor(){} // RVA: 0x739ED10
        public void InitManipulators(){} // RVA: 0x739F520
        public void UpdateDataFromColumn(){} // RVA: 0x739FB00
        public void BindHeaderContent(){} // RVA: 0x739FC10
        public void UnbindHeaderContent(){} // RVA: 0x739FD00
        public void DestroyHeaderContent(){} // RVA: 0x739FDF0
        public void CreateDefaultHeaderContent(){} // RVA: 0x739FF20
        public void DefaultBindHeaderContent(){} // RVA: 0x73A0280
        public void UpdateHeaderTemplate(){} // RVA: 0x73A06F0
        public void UpdateGeometryFromColumn(){} // RVA: 0x73A0A50
        public void .cctor(){} // RVA: 0x73A0B70
        public void <.ctor>b__45_0(){} // RVA: 0x73A15C0
        public void <.ctor>b__45_1(){} // RVA: 0x73A16F0
        public void <InitManipulators>b__46_0(){} // RVA: 0x73A1700
    }

    public class MultiColumnHeaderColumnIcon
    {
        public string ussClassName;

        // ── Methods ──
        public void get_isImageInline(){} // RVA: 0x55CB6E0
        public void set_isImageInline(){} // RVA: 0x739DF60
        public void .ctor(){} // RVA: 0x739DF70
        public void UpdateClassList(){} // RVA: 0x739E080
        public void .cctor(){} // RVA: 0x739E330
        public void <.ctor>b__5_0(){} // RVA: 0x739E420
    }

    public class MultiColumnHeaderColumnMoveLocationPreview
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7391F80
        public void .cctor(){} // RVA: 0x73920F0
    }

    public class MultiColumnHeaderColumnMovePreview
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7391DC0
        public void .cctor(){} // RVA: 0x7391E90
    }

    public class MultiColumnHeaderColumnResizeHandle
    {
        public string ussClassName;

        // ── Methods ──
        public void get_dragArea(){} // RVA: 0xD96B00
        public void .ctor(){} // RVA: 0x73A17B0
        public void .cctor(){} // RVA: 0x73A1910
    }

    public class MultiColumnHeaderColumnResizePreview
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73952D0
        public void .cctor(){} // RVA: 0x7395440
    }

    public class MultiColumnHeaderColumnSortIndicator
    {
        public string ussClassName;

        // ── Methods ──
        public void set_sortOrderLabel(){} // RVA: 0x739DA60
        public void .ctor(){} // RVA: 0x739DA90
        public void .cctor(){} // RVA: 0x739DD20
    }

}