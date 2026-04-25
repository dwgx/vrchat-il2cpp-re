// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements.Internal
// Classes: 10
// Methods: 138

namespace ThirdParty.Unity.UnityEngine.UIElements.Internal
{
    public class ColumnMover : PointerManipulator
    {
        public float columnLayout; // 0x38
        public float active; // 0x3C
        public bool moving; // 0x40
        public bool m_Moving; // 0x41
        public bool m_Cancelled; // 0x42
        public UnityEngine.UIElements.Internal.MultiColumnCollectionHeader m_Header; // 0x48
        public UnityEngine.UIElements.VisualElement m_PreviewElement; // 0x50
        public UnityEngine.UIElements.Internal.MultiColumnHeaderColumnMoveLocationPreview m_LocationPreviewElement; // 0x58
        public UnityEngine.UIElements.Column m_ColumnToMove; // 0x60
        public float m_ColumnToMovePos; // 0x68
        public float m_ColumnToMoveWidth; // 0x6C
        public UnityEngine.UIElements.Column m_DestinationColumn; // 0x70
        public bool m_MoveBeforeDestination; // 0x78
        public UnityEngine.UIElements.ColumnLayout <columnLayout>k__BackingField; // 0x80
        public System.Action`1<UnityEngine.UIElements.Internal.ColumnMover> activeChanged; // 0x88
        public System.Action`1<UnityEngine.UIElements.Internal.ColumnMover> movingChanged; // 0x90

        // ── Methods ──
        public void get_columnLayout(){} // RVA: 0x7FFAC32EF410
        public void set_columnLayout(){} // RVA: 0x7FFAC34D4AA0
        public void get_active(){} // RVA: 0x7FFAC2FDCC00
        public void set_active(){} // RVA: 0x7FFAC9B29B60
        public void get_moving(){} // RVA: 0x7FFAC31D8A60
        public void set_moving(){} // RVA: 0x7FFAC9B29B90
        public void add_activeChanged(){} // RVA: 0x7FFAC9B29BC0
        public void remove_activeChanged(){} // RVA: 0x7FFAC9B29CC0
        public void add_movingChanged(){} // RVA: 0x7FFAC9B29DC0
        public void remove_movingChanged(){} // RVA: 0x7FFAC9B29EC0
        public void .ctor(){} // RVA: 0x7FFAC9B29FC0
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFAC9B2A0B0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFAC9B2A5A0
        public void OnMouseDown(){} // RVA: 0x7FFAC9B2AB60
        public void OnMouseMove(){} // RVA: 0x7FFAC9B2AC40
        public void OnMouseUp(){} // RVA: 0x7FFAC9B2ACC0
        public void OnMouseCaptureOut(){} // RVA: 0x7FFAC9B2ADE0
        public void OnPointerDown(){} // RVA: 0x7FFAC9B2AE60
        public void OnPointerMove(){} // RVA: 0x7FFAC9B2AFE0
        public void OnPointerUp(){} // RVA: 0x7FFAC9B2B130
        public void OnPointerCancel(){} // RVA: 0x7FFAC9B2B2E0
        public void OnPointerCaptureOut(){} // RVA: 0x7FFAC9B2B3F0
        public void IsNotMouseEvent(){} // RVA: 0x7FFAC9B2B4B0
        public void ProcessCancelEvent(){} // RVA: 0x7FFAC9B2B510
        public void OnKeyDown(){} // RVA: 0x7FFAC9B2B660
        public void ProcessDownEvent(){} // RVA: 0x7FFAC9B2B6D0
        public void ProcessMoveEvent(){} // RVA: 0x7FFAC9B2B9B0
        public void ProcessUpEvent(){} // RVA: 0x7FFAC9B2BAF0
        public void BeginDragMove(){} // RVA: 0x7FFAC9B2BC70
        public void DragMove(){} // RVA: 0x7FFAC9B2C400
        public void UpdatePreviewPosition(){} // RVA: 0x7FFAC9B2C410
        public void UpdateMoveLocation(){} // RVA: 0x7FFAC9B2C700
        public void EndDragMove(){} // RVA: 0x7FFAC9B2C990
    }

    public class ColumnResizer : PointerManipulator
    {
        public UnityEngine.Vector2 columnLayout; // 0x38
        public bool preview; // 0x40
        public bool m_Resizing; // 0x41
        public UnityEngine.UIElements.Internal.MultiColumnCollectionHeader m_Header; // 0x48
        public UnityEngine.UIElements.Column m_Column; // 0x50
        public UnityEngine.UIElements.VisualElement m_PreviewElement; // 0x58
        public UnityEngine.UIElements.ColumnLayout <columnLayout>k__BackingField; // 0x60
        public bool <preview>k__BackingField; // 0x68

        // ── Methods ──
        public void get_columnLayout(){} // RVA: 0x7FFAC2FBF370
        public void set_columnLayout(){} // RVA: 0x7FFAC2FBF380
        public void get_preview(){} // RVA: 0x7FFAC2FE9570
        public void set_preview(){} // RVA: 0x7FFAC2FE9580
        public void .ctor(){} // RVA: 0x7FFAC9B2CEB0
        public void RegisterCallbacksOnTarget(){} // RVA: 0x7FFAC9B2D010
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFAC9B2D230
        public void OnKeyDown(){} // RVA: 0x7FFAC9B2D460
        public void OnPointerDown(){} // RVA: 0x7FFAC9B2D540
        public void OnPointerMove(){} // RVA: 0x7FFAC9B2DA80
        public void OnPointerUp(){} // RVA: 0x7FFAC9B2DC20
        public void BeginDragResize(){} // RVA: 0x7FFAC9B2DE10
        public void DragResize(){} // RVA: 0x7FFAC9B2DE60
        public void UpdatePreviewPosition(){} // RVA: 0x7FFAC9B2DEB0
        public void EndDragResize(){} // RVA: 0x7FFAC9B2DFF0
    }

    public class MultiColumnCollectionHeader : VisualElement
    {
        public string isApplyingViewState;
        public string columnDataMap; // 0x8
        public string columnLayout; // 0x10
        public string columnContainer; // 0x18
        public bool resizeHandleContainer; // 0x3C8
        public System.Collections.Generic.List`1<UnityEngine.UIElements.SortColumnDescription> sortedColumns; // 0x3D0
        public UnityEngine.UIElements.SortColumnDescriptions sortDescriptions; // 0x3D8
        public System.Collections.Generic.List`1<SortedColumnState> columns; // 0x3E0
        public bool sortingEnabled; // 0x3E8
        public ViewState m_ViewState; // 0x3F0
        public bool m_ApplyingViewState; // 0x3F8
        public bool m_DoLayoutScheduled; // 0x3F9
        public System.Collections.Generic.Dictionary`2<UnityEngine.UIElements.Column,ColumnData> <columnDataMap>k__BackingField; // 0x400
        public UnityEngine.UIElements.ColumnLayout <columnLayout>k__BackingField; // 0x408
        public UnityEngine.UIElements.VisualElement <columnContainer>k__BackingField; // 0x410
        public UnityEngine.UIElements.VisualElement <resizeHandleContainer>k__BackingField; // 0x418
        public UnityEngine.UIElements.Columns <columns>k__BackingField; // 0x420
        public System.Action`2<int,float> columnResized; // 0x428
        public System.Action columnSortingChanged; // 0x430
        public System.Action`2<UnityEngine.UIElements.ContextualMenuPopulateEvent,UnityEngine.UIElements.Column> contextMenuPopulateEvent; // 0x438
        public System.Action viewDataRestored; // 0x440

        // ── Methods ──
        public void get_isApplyingViewState(){} // RVA: 0x7FFAC9B2E0A0
        public void get_columnDataMap(){} // RVA: 0x7FFAC39AABE0
        public void get_columnLayout(){} // RVA: 0x7FFAC39CF630
        public void get_columnContainer(){} // RVA: 0x7FFAC39C4810
        public void get_resizeHandleContainer(){} // RVA: 0x7FFAC39B5300
        public void get_sortedColumns(){} // RVA: 0x7FFAC39C1CA0
        public void get_sortDescriptions(){} // RVA: 0x7FFAC39AD490
        public void set_sortDescriptions(){} // RVA: 0x7FFAC9B2E0B0
        public void get_columns(){} // RVA: 0x7FFAC39CADC0
        public void get_sortingEnabled(){} // RVA: 0x7FFAC9B2E290
        public void set_sortingEnabled(){} // RVA: 0x7FFAC9B2E2A0
        public void add_columnResized(){} // RVA: 0x7FFAC9B2E2E0
        public void remove_columnResized(){} // RVA: 0x7FFAC9B2E3E0
        public void add_columnSortingChanged(){} // RVA: 0x7FFAC9B2E4E0
        public void remove_columnSortingChanged(){} // RVA: 0x7FFAC9B2E5D0
        public void add_contextMenuPopulateEvent(){} // RVA: 0x7FFAC9B2E6C0
        public void remove_contextMenuPopulateEvent(){} // RVA: 0x7FFAC9B2E7C0
        public void add_viewDataRestored(){} // RVA: 0x7FFAC9B2E8C0
        public void remove_viewDataRestored(){} // RVA: 0x7FFAC9B2E9B0
        public void .ctor(){} // RVA: 0x7FFAC9B2EAA0
        public void ScheduleDoLayout(){} // RVA: 0x7FFAC9B2F6C0
        public void ResizeToFit(){} // RVA: 0x7FFAC9B2F760
        public void UpdateSortedColumns(){} // RVA: 0x7FFAC9B2F890
        public void UpdateColumnControls(){} // RVA: 0x7FFAC9B2FFD0
        public void OnColumnAdded(){} // RVA: 0x7FFAC9B305D0 | overloaded x2
        public void OnColumnRemoved(){} // RVA: 0x7FFAC9B30EA0
        public void OnColumnChanged(){} // RVA: 0x7FFAC9B31150
        public void OnColumnReordered(){} // RVA: 0x7FFAC9B311E0
        public void OnColumnResized(){} // RVA: 0x7FFAC9B313C0
        public void OnContextualMenuManipulator(){} // RVA: 0x7FFAC9B31400
        public void OnMoveManipulatorActivated(){} // RVA: 0x7FFAC9B31D70
        public void OnGeometryChanged(){} // RVA: 0x7FFAC9B31E00
        public void DoLayout(){} // RVA: 0x7FFAC9B31F30
        public void OnColumnControlGeometryChanged(){} // RVA: 0x7FFAC9B31F90
        public void OnColumnClicked(){} // RVA: 0x7FFAC9B322E0
        public void UpdateSortColumnDescriptionsOnClick(){} // RVA: 0x7FFAC9B324B0
        public void ScrollHorizontally(){} // RVA: 0x7FFAC9B327F0
        public void RaiseColumnResized(){} // RVA: 0x7FFAC9B32930
        public void RaiseColumnSortingChanged(){} // RVA: 0x7FFAC9B329D0
        public void ApplyColumnSorting(){} // RVA: 0x7FFAC9B32A10
        public void UpdateSortingStatus(){} // RVA: 0x7FFAC9B33200
        public void OnViewDataReady(){} // RVA: 0x7FFAC9B33750
        public void SaveViewState(){} // RVA: 0x7FFAC9B313C0
        public void Dispose(){} // RVA: 0x7FFAC9B33890
        public void .cctor(){} // RVA: 0x7FFAC9B340C0
        public void <OnContextualMenuManipulator>b__65_0(){} // RVA: 0x7FFAC9B2F760
    }

    public class MultiColumnHeaderColumn : VisualElement
    {
        public string clickable;
        public string mover; // 0x8
        public string sortOrderLabel; // 0x10
        public string column; // 0x18
        public string content; // 0x20
        public string isContentBound; // 0x28
        public string contentUssClassName; // 0x30
        public string defaultContentUssClassName; // 0x38
        public string hasIconUssClassName; // 0x40
        public string hasTitleUssClassName; // 0x48
        public string titleUssClassName; // 0x50
        public string iconElementName; // 0x58
        public string titleElementName; // 0x60
        public string s_BoundVEPropertyName; // 0x68
        public string s_BindingCallbackVEPropertyName; // 0x70
        public string s_UnbindingCallbackVEPropertyName; // 0x78
        public string s_DestroyCallbackVEPropertyName; // 0x80
        public UnityEngine.UIElements.VisualElement m_ContentContainer; // 0x3C8
        public UnityEngine.UIElements.VisualElement m_Content; // 0x3D0
        public UnityEngine.UIElements.Internal.MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer; // 0x3D8
        public UnityEngine.UIElements.IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate; // 0x3E0
        public UnityEngine.UIElements.Clickable <clickable>k__BackingField; // 0x3E8
        public UnityEngine.UIElements.Internal.ColumnMover <mover>k__BackingField; // 0x3F0
        public UnityEngine.UIElements.Column <column>k__BackingField; // 0x3F8

        // ── Methods ──
        public void get_clickable(){} // RVA: 0x7FFAC39B0920
        public void set_clickable(){} // RVA: 0x7FFAC39CD160
        public void get_mover(){} // RVA: 0x7FFAC39BFEF0
        public void set_mover(){} // RVA: 0x7FFAC39CC6D0
        public void set_sortOrderLabel(){} // RVA: 0x7FFAC9B35D10
        public void get_column(){} // RVA: 0x7FFAC39C9850
        public void set_column(){} // RVA: 0x7FFAC39AF5E0
        public void get_content(){} // RVA: 0x7FFAC39C1CA0
        public void set_content(){} // RVA: 0x7FFAC9B35D50
        public void get_isContentBound(){} // RVA: 0x7FFAC9B36450
        public void set_isContentBound(){} // RVA: 0x7FFAC9B36530
        public void .ctor(){} // RVA: 0x7FFAC9B365F0
        public void InitManipulators(){} // RVA: 0x7FFAC9B36E00
        public void UpdateDataFromColumn(){} // RVA: 0x7FFAC9B373E0
        public void BindHeaderContent(){} // RVA: 0x7FFAC9B374F0
        public void UnbindHeaderContent(){} // RVA: 0x7FFAC9B375E0
        public void DestroyHeaderContent(){} // RVA: 0x7FFAC9B376D0
        public void CreateDefaultHeaderContent(){} // RVA: 0x7FFAC9B37800
        public void DefaultBindHeaderContent(){} // RVA: 0x7FFAC9B37B60
        public void UpdateHeaderTemplate(){} // RVA: 0x7FFAC9B37FD0
        public void UpdateGeometryFromColumn(){} // RVA: 0x7FFAC9B38330
        public void .cctor(){} // RVA: 0x7FFAC9B38450
        public void <.ctor>b__45_0(){} // RVA: 0x7FFAC9B38EA0
        public void <.ctor>b__45_1(){} // RVA: 0x7FFAC9B38FD0
        public void <InitManipulators>b__46_0(){} // RVA: 0x7FFAC9B38FE0
    }

    public class MultiColumnHeaderColumnIcon : Image
    {
        public string isImageInline;
        public bool <isImageInline>k__BackingField; // 0x410

        // ── Methods ──
        public void get_isImageInline(){} // RVA: 0x7FFAC7C597A0
        public void set_isImageInline(){} // RVA: 0x7FFAC9B35840
        public void .ctor(){} // RVA: 0x7FFAC9B35850
        public void UpdateClassList(){} // RVA: 0x7FFAC9B35960
        public void .cctor(){} // RVA: 0x7FFAC9B35C10
        public void <.ctor>b__5_0(){} // RVA: 0x7FFAC9B35D00
    }

    public class MultiColumnHeaderColumnMoveLocationPreview : VisualElement
    {
        public string ussClassName;
        public string visualUssClassName; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B29860
        public void .cctor(){} // RVA: 0x7FFAC9B299D0
    }

    public class MultiColumnHeaderColumnMovePreview : VisualElement
    {
        public string ussClassName;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B296A0
        public void .cctor(){} // RVA: 0x7FFAC9B29770
    }

    public class MultiColumnHeaderColumnResizeHandle : VisualElement
    {
        public string dragArea;
        public string dragAreaUssClassName; // 0x8
        public UnityEngine.UIElements.VisualElement <dragArea>k__BackingField; // 0x3C8

        // ── Methods ──
        public void get_dragArea(){} // RVA: 0x7FFAC39C0A20
        public void .ctor(){} // RVA: 0x7FFAC9B39090
        public void .cctor(){} // RVA: 0x7FFAC9B391F0
    }

    public class MultiColumnHeaderColumnResizePreview : VisualElement
    {
        public string ussClassName;
        public string visualUssClassName; // 0x8

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B2CBB0
        public void .cctor(){} // RVA: 0x7FFAC9B2CD20
    }

    public class MultiColumnHeaderColumnSortIndicator : VisualElement
    {
        public string sortOrderLabel;
        public string arrowUssClassName; // 0x8
        public string indexLabelUssClassName; // 0x10
        public UnityEngine.UIElements.Label m_IndexLabel; // 0x3C8

        // ── Methods ──
        public void set_sortOrderLabel(){} // RVA: 0x7FFAC9B35340
        public void .ctor(){} // RVA: 0x7FFAC9B35370
        public void .cctor(){} // RVA: 0x7FFAC9B35600
    }

}