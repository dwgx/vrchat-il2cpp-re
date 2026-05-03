// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 11
// Methods: 90

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class Label : TextElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87EE6FD0 | overloaded x2
        public void .cctor(){} // RVA: 0x7FFE87EE7090
    }

    public class LayoutData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFE87F9EBB0
        public void CopyFrom(){} // RVA: 0x7FFE87F9EC30
        public void op_Equality(){} // RVA: 0x7FFE87F9ED40
        public void Equals(){} // RVA: 0x7FFE87FA1860 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87FA1990
    }

    public class Length : ValueType
    {
        public float k_MaxValue;
        public float m_Value; // 0x10

        // ── Methods ──
        public void Percent(){} // RVA: 0x7FFE87FA5210
        public void Auto(){} // RVA: 0x7FFE87FA5250
        public void None(){} // RVA: 0x7FFE87FA5270
        public void get_value(){} // RVA: 0x7FFE82AB44F0
        public void set_value(){} // RVA: 0x7FFE87FA5290
        public void get_unit(){} // RVA: 0x7FFE826F42A0
        public void IsAuto(){} // RVA: 0x7FFE87FA52C0
        public void IsNone(){} // RVA: 0x7FFE87FA52D0
        public void .ctor(){} // RVA: 0x7FFE87FA5310 | overloaded x3
        public void op_Implicit(){} // RVA: 0x7FFE87FA5340
        public void op_Equality(){} // RVA: 0x7FFE87F7C0B0
        public void op_Inequality(){} // RVA: 0x7FFE87FA5380
        public void Equals(){} // RVA: 0x7FFE87FA53B0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87F7C1C0
        public void ToString(){} // RVA: 0x7FFE87FA5460
    }

    public class ListView : BaseListView
    {
        public System.Func`1<UnityEngine.UIElements.VisualElement> m_MakeItem; // 0x540
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> m_BindItem; // 0x548
        public System.Action`2<UnityEngine.UIElements.VisualElement,int> _unbindItem; // 0x550
        public System.Action`1<UnityEngine.UIElements.VisualElement> _destroyItem; // 0x558

        // ── Methods ──
        public void get_makeItem(){} // RVA: 0x7FFE81B26880
        public void get_bindItem(){} // RVA: 0x7FFE81B16550
        public void get_unbindItem(){} // RVA: 0x7FFE81B24550
        public void get_destroyItem(){} // RVA: 0x7FFE81B2D840
        public void HasValidDataAndBindings(){} // RVA: 0x7FFE87EE71A0
        public void CreateViewController(){} // RVA: 0x7FFE87EE7200
        public void .ctor(){} // RVA: 0x7FFE87EE7240
    }

    public class ListViewController : BaseListViewController
    {
        // ── Methods ──
        public void get_listView(){} // RVA: 0x7FFE87E32DB0
        public void MakeItem(){} // RVA: 0x7FFE87E32E40
        public void BindItem(){} // RVA: 0x7FFE87E32F80
        public void UnbindItem(){} // RVA: 0x7FFE87E331F0
        public void DestroyItem(){} // RVA: 0x7FFE87E33240
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class ListViewDragger : DragEventsProcessor
    {
        public DragPosition m_LastDragPosition; // 0x30
        public UnityEngine.UIElements.VisualElement m_DragHoverBar; // 0x50
        public UnityEngine.UIElements.VisualElement m_DragHoverItemMarker; // 0x58

        // ── Methods ──
        public void get_targetView(){} // RVA: 0x7FFE87F1A8D0
        public void get_targetScrollView(){} // RVA: 0x7FFE87F1A960
        public void get_dragAndDropController(){} // RVA: 0x7FFE811C3590
        public void set_dragAndDropController(){} // RVA: 0x7FFE811C35A0
        public void .ctor(){} // RVA: 0x7FFE87F1A990
        public void CanStartDrag(){} // RVA: 0x7FFE87F1AB20
        public void StartDrag(){} // RVA: 0x7FFE87F1AE60
        public void UpdateDrag(){} // RVA: 0x7FFE87F1B140
        public void GetVisualMode(){} // RVA: 0x7FFE87F1B450
        public void OnDrop(){} // RVA: 0x7FFE87F1B660
        public void HandleDragAndScroll(){} // RVA: 0x7FFE87F1B910
        public void HandleAutoExpansion(){} // RVA: 0x7FFE87F1BB60
        public void ApplyDragAndDropUI(){} // RVA: 0x7FFE87F1BC70
        public void TryGetDragPosition(){} // RVA: 0x7FFE87F1C610
        public void HandleTreePosition(){} // RVA: 0x7FFE87F1CA10
        public void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(){} // RVA: 0x7FFE87F1CB40
        public void GetPreviousAndNextItemsIgnoringDraggedItems(){} // RVA: 0x7FFE87F1D2D0
        public void MakeDragAndDropArgs(){} // RVA: 0x7FFE87F1D4C0
        public void GetHoverBarTopPosition(){} // RVA: 0x7FFE87F1D6A0
        public void PlaceHoverBarAtElement(){} // RVA: 0x7FFE87F1D870
        public void PlaceHoverBarAt(){} // RVA: 0x7FFE87F1DA60
        public void ClearDragAndDropUI(){} // RVA: 0x7FFE87F1E140
        public void GetRecycledItem(){} // RVA: 0x7FFE87F1E500
        public void <ApplyDragAndDropUI>g__GeometryChangedCallback|27_0(){} // RVA: 0x7FFE87F1E720
    }

    public class ListViewDraggerAnimated : ListViewDragger
    {
        public int m_DragStartIndex; // 0x78
        public int m_CurrentIndex; // 0x7C
        public float m_SelectionHeight; // 0x80

        // ── Methods ──
        public void get_isDragging(){} // RVA: 0x7FFE813A1D80
        public void set_isDragging(){} // RVA: 0x7FFE813AB660
        public void get_draggedItem(){} // RVA: 0x7FFE817AE360
        public void get_supportsDragEvents(){} // RVA: 0x7FFE810FB320
        public void .ctor(){} // RVA: 0x7FFE87F1ED90
        public void StartDrag(){} // RVA: 0x7FFE87F1EDA0
        public void UpdateDrag(){} // RVA: 0x7FFE87F1F700
        public void Animate(){} // RVA: 0x7FFE87F1FEC0
        public void OnDrop(){} // RVA: 0x7FFE87F202E0
        public void ClearDragAndDropUI(){} // RVA: 0x7FFE810FB310
        public void TryGetDragPosition(){} // RVA: 0x7FFE87F207E0
    }

    public class ListViewDraggerExtension : Object
    {
        // ── Methods ──
        public void GetRecycledItemFromId(){} // RVA: 0x7FFE87F1EA90
        public void GetRecycledItemFromIndex(){} // RVA: 0x7FFE87F1EC10
    }

    public class ListViewReorderableDragAndDropController : BaseReorderableDragAndDropController
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F20850
        public void HandleDragAndDrop(){} // RVA: 0x7FFE87F208C0
        public void OnDrop(){} // RVA: 0x7FFE87F20990
    }

    public class LoadResourceFunction : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F50AE0
        public void Invoke(){} // RVA: 0x7FFE8401E840
    }

    public class LongField : TextValueField`1
    {
        public string ussClassName;

        // ── Methods ──
        public void get_longInput(){} // RVA: 0x7FFE87EE7310
        public void ValueToString(){} // RVA: 0x7FFE87EE73A0
        public void StringToValue(){} // RVA: 0x7FFE87EE75B0
        public void .ctor(){} // RVA: 0x7FFE87EE76A0 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFE87EE79A0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE87EE7A70
        public void .cctor(){} // RVA: 0x7FFE87EE7B60
    }

}