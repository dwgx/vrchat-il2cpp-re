// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 25
// Methods: 228

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class DefaultDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFAC9B7DE70
        public void DispatchEvent(){} // RVA: 0x7FFAC9B7DF00
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DefaultDragAndDropClient : DragAndDropData
    {
        public System.Collections.Hashtable source; // 0x10
        public UnityEngine.UIElements.Label data; // 0x18
        public 0x6B11A9E8 m_VisualMode; // 0x20
        public System.Collections.Generic.IEnumerable`1<UnityEngine.Object> m_UnityObjectReferences; // 0x28

        // ── Methods ──
        public void get_source(){} // RVA: 0x7FFAC9B6FA00
        public void GetGenericData(){} // RVA: 0x7FFAC9B6FA50
        public void StartDrag(){} // RVA: 0x7FFAC9B6FAC0
        public void UpdateDrag(){} // RVA: 0x7FFAC9B702F0
        public void AcceptDrag(){} // RVA: 0x7FFAC2F21310
        public void SetVisualMode(){} // RVA: 0x7FFAC35DB7A0
        public void DragCleanup(){} // RVA: 0x7FFAC9B704D0
        public void get_data(){} // RVA: 0x7FFAC44F81E0
        public void .ctor(){} // RVA: 0x7FFAC9B70570
    }

    public class DefaultEventSystem : Object
    {
        public System.Func`1<bool> isAppFocused;
        public IInput input; // 0x10
        public string focusedPanel; // 0x18
        public string m_VerticalAxis; // 0x20
        public string m_SubmitButton; // 0x28
        public string m_CancelButton; // 0x30
        public float m_InputActionsPerSecond; // 0x38
        public float m_RepeatDelay; // 0x3C
        public bool m_SendingTouchEvents; // 0x40
        public bool m_SendingPenEvent; // 0x41
        public UnityEngine.Event m_Event; // 0x48
        public UnityEngine.UIElements.BaseRuntimePanel m_FocusedPanel; // 0x50
        public UnityEngine.UIElements.BaseRuntimePanel m_PreviousFocusedPanel; // 0x58
        public UnityEngine.UIElements.Focusable m_PreviousFocusedElement; // 0x60
        public 0x6B27F588 m_CurrentModifiers; // 0x68
        public int m_LastMousePressButton; // 0x6C
        public float m_NextMousePressTime; // 0x70
        public int m_LastMouseClickCount; // 0x74
        public UnityEngine.Vector2 m_LastMousePosition; // 0x78
        public bool m_MouseProcessedAtLeastOnce; // 0x80
        public int m_ConsecutiveMoveCount; // 0x84
        public UnityEngine.Vector2 m_LastMoveVector; // 0x88
        public float m_PrevActionTime; // 0x90
        public bool m_IsMoveFromKeyboard; // 0x94

        // ── Methods ──
        public void get_isAppFocused(){} // RVA: 0x7FFAC9B6ACC0
        public void get_input(){} // RVA: 0x7FFAC9B6AD40
        public void GetDefaultInput(){} // RVA: 0x7FFAC9B6ADB0
        public void ShouldIgnoreEventsOnAppNotFocused(){} // RVA: 0x7FFAC9B6AE80
        public void get_focusedPanel(){} // RVA: 0x7FFAC2FC20E0
        public void set_focusedPanel(){} // RVA: 0x7FFAC9B6AED0
        public void Update(){} // RVA: 0x7FFAC9B6AF60
        public void FocusBasedEventSequence(){} // RVA: 0x7FFAC9B6B110
        public void SendIMGUIEvents(){} // RVA: 0x7FFAC9B6B140
        public void ProcessMouseEvents(){} // RVA: 0x7FFAC9B6B9B0
        public void SendInputEvents(){} // RVA: 0x7FFAC9B6C250
        public void OnFocusEvent(){} // RVA: 0x7FFAC9B6C680
        public void SendFocusBasedEvent(){} // RVA: 0x7FFAC2E8DC40
        public void SendPositionBasedEvent(){} // RVA: 0x7FFAC2E8DC40
        public void UpdateFocusedPanel(){} // RVA: 0x7FFAC9B6C690
        public void MakeTouchEvent(){} // RVA: 0x7FFAC9B6C730
        public void MakePenEvent(){} // RVA: 0x7FFAC9B6C850
        public void ProcessTouchEvents(){} // RVA: 0x7FFAC9B6C940
        public void ProcessPenEvents(){} // RVA: 0x7FFAC9B6CF50
        public void GetRawMoveVector(){} // RVA: 0x7FFAC9B6D420
        public void ShouldSendMoveFromInput(){} // RVA: 0x7FFAC9B6D580
        public void ProcessTabEvent(){} // RVA: 0x7FFAC9B6D810
        public void .ctor(){} // RVA: 0x7FFAC9B6DB50
        public void .cctor(){} // RVA: 0x7FFAC9B6DE60
    }

    public class DefaultGroupManager : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.IGroupBoxOption> m_GroupOptions; // 0x10
        public UnityEngine.UIElements.IGroupBoxOption m_SelectedOption; // 0x18
        public UnityEngine.UIElements.IGroupBox m_GroupBox; // 0x20

        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2F4F0D0
        public void OnOptionSelectionChanged(){} // RVA: 0x7FFAC9B9E540
        public void RegisterOption(){} // RVA: 0x7FFAC9B9E7C0
        public void UnregisterOption(){} // RVA: 0x7FFAC9B9E8F0
        public void .ctor(){} // RVA: 0x7FFAC9B9E980
    }

    public class DefaultMultiColumnTreeViewController`1 : MultiColumnTreeViewController
    {
        public UnityEngine.UIElements.TreeDataController`1<T> treeDataController;

        // ── Methods ──
        public void get_treeDataController(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2C7AF60
        public void get_itemsSource(){} // RVA: 0x7FFAC2C58E90
        public void set_itemsSource(){} // RVA: 0x7FFAC2C70A40
        public void SetRootItems(){} // RVA: 0x7FFAC2C70A40
        public void GetItemForIndex(){} // RVA: 0x7FFAC2C67DE0
        public void GetParentId(){} // RVA: 0x7FFAC2C600D0
        public void HasChildren(){} // RVA: 0x7FFAC2C5A310
        public void GetChildrenIds(){} // RVA: 0x7FFAC2C67DE0
        public void Move(){}
        public void IsChildOf(){}
        public void GetAllItemIds(){} // RVA: 0x7FFAC2C58F40
    }

    public class DefaultTreeViewController`1 : TreeViewController
    {
        public UnityEngine.UIElements.TreeDataController`1<T> treeDataController;

        // ── Methods ──
        public void get_treeDataController(){} // RVA: 0x7FFAC2C58E90
        public void get_itemsSource(){} // RVA: 0x7FFAC2C58E90
        public void set_itemsSource(){} // RVA: 0x7FFAC2C70A40
        public void SetRootItems(){} // RVA: 0x7FFAC2C70A40
        public void GetItemForIndex(){} // RVA: 0x7FFAC2C67DE0
        public void GetParentId(){} // RVA: 0x7FFAC2C600D0
        public void HasChildren(){} // RVA: 0x7FFAC2C5A310
        public void GetChildrenIds(){} // RVA: 0x7FFAC2C67DE0
        public void Move(){}
        public void IsChildOf(){}
        public void GetAllItemIds(){} // RVA: 0x7FFAC2C58F40
        public void .ctor(){} // RVA: 0x7FFAC2C70980
    }

    public class DetachFromPanelEvent : PanelChangedEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B8C1A0
        public void .ctor(){} // RVA: 0x7FFAC9B8C290
    }

    public class DisposeHelper : Object
    {
        // ── Methods ──
        public void NotifyDisposedUsed(){} // RVA: 0x7FFAC9B6F100
    }

    public class DoubleField : TextValueField`1
    {
        public string doubleInput;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void get_doubleInput(){} // RVA: 0x7FFAC9AABA50
        public void ValueToString(){} // RVA: 0x7FFAC9AABAE0
        public void StringToValue(){} // RVA: 0x7FFAC9AABCA0
        public void .ctor(){} // RVA: 0x7FFAC9AABDA0 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFAC9AAC0A0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC9AAC130
        public void .cctor(){} // RVA: 0x7FFAC9AAC220
    }

    public class DragAndDropArgs : ValueType
    {
        public object target; // 0x10
        public int insertAtIndex; // 0x18
        public int parentId; // 0x1C
        public int childIndex; // 0x20
        public 0x6B11A938 dragAndDropPosition; // 0x24
        public UnityEngine.UIElements.DragAndDropData dragAndDropData; // 0x28

        // ── Methods ──
        public void set_target(){} // RVA: 0x7FFAC38DFE40
        public void get_insertAtIndex(){} // RVA: 0x7FFAC49C7500
        public void set_insertAtIndex(){} // RVA: 0x7FFAC49C7510
        public void get_parentId(){} // RVA: 0x7FFAC49C7520
        public void set_parentId(){} // RVA: 0x7FFAC49C7530
        public void get_childIndex(){} // RVA: 0x7FFAC2F6E5C0
        public void set_childIndex(){} // RVA: 0x7FFAC2F240C0
        public void get_dragAndDropPosition(){} // RVA: 0x7FFAC33D5A20
        public void set_dragAndDropPosition(){} // RVA: 0x7FFAC33D4990
        public void get_dragAndDropData(){} // RVA: 0x7FFAC2F247C0
        public void set_dragAndDropData(){} // RVA: 0x7FFAC2F87E80
    }

    public class DragAndDropData : Object
    {
        public object source;

        // ── Methods ──
        public void GetGenericData(){} // RVA: 0x7FFAC2C58F40
        public void get_source(){} // RVA: 0x7FFAC2C58E90
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DragAndDropUtility : Object
    {
        public System.Func`1<UnityEngine.UIElements.IDragAndDrop> s_MakeDragAndDropClientFunc;
        public UnityEngine.UIElements.IDragAndDrop s_DragAndDropEditor; // 0x8
        public UnityEngine.UIElements.IDragAndDrop s_DragAndDropPlayMode; // 0x10

        // ── Methods ──
        public void GetDragAndDrop(){} // RVA: 0x7FFAC9B6F800
    }

    public class DragEventsProcessor : Object
    {
        public bool supportsDragEvents; // 0x10
        public 0x6B11A6D0 useDragEvents; // 0x14
        public UnityEngine.Vector3 dragAndDrop; // 0x18
        public UnityEngine.UIElements.VisualElement isEditorContext; // 0x28

        // ── Methods ──
        public void get_supportsDragEvents(){} // RVA: 0x7FFAC3006850
        public void get_useDragEvents(){} // RVA: 0x7FFAC9B70620
        public void get_dragAndDrop(){} // RVA: 0x7FFAC9B70680
        public void get_isEditorContext(){} // RVA: 0x7FFAC9B706B0
        public void .ctor(){} // RVA: 0x7FFAC9B70790
        public void RegisterCallbacksFromTarget(){} // RVA: 0x7FFAC9B70920 | overloaded x2
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x7FFAC9B70C50 | overloaded x2
        public void CanStartDrag(){} // RVA: 0x7FFAC2C59F60
        public void StartDrag(){}
        public void UpdateDrag(){} // RVA: 0x7FFAC2C70A40
        public void OnDrop(){} // RVA: 0x7FFAC2C70A40
        public void ClearDragAndDropUI(){} // RVA: 0x7FFAC2C71060
        public void OnPointerDownEvent(){} // RVA: 0x7FFAC9B710B0
        public void OnPointerUpEvent(){} // RVA: 0x7FFAC9B711F0
        public void OnPointerLeaveEvent(){} // RVA: 0x7FFAC9B71420
        public void OnPointerCancelEvent(){} // RVA: 0x7FFAC9B71440
        public void OnPointerCapturedOut(){} // RVA: 0x7FFAC9B715A0
        public void OnPointerMoveEvent(){} // RVA: 0x7FFAC9B71680
        public void GetDropTarget(){} // RVA: 0x7FFAC9B71AE0
    }

    public class DropdownField : PopupField`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9AACA60 | overloaded x2
    }

    public class DropdownMenu : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.DropdownMenuItem> m_MenuItems; // 0x10
        public UnityEngine.UIElements.DropdownMenuEventInfo m_DropdownMenuEventInfo; // 0x18

        // ── Methods ──
        public void MenuItems(){} // RVA: 0x7FFAC5CC4750
        public void AppendAction(){} // RVA: 0x7FFAC9B7A530 | overloaded x2
        public void AppendSeparator(){} // RVA: 0x7FFAC9B7A660
        public void InsertSeparator(){} // RVA: 0x7FFAC9B7A810
        public void PrepareForDisplay(){} // RVA: 0x7FFAC9B7A9D0
        public void .ctor(){} // RVA: 0x7FFAC9B7AEA0
    }

    public class DropdownMenuAction : DropdownMenuItem
    {
        public string status; // 0x10
        public 0x6B11AF68 eventInfo; // 0x18
        public UnityEngine.UIElements.DropdownMenuEventInfo userData; // 0x20
        public object <userData>k__BackingField; // 0x28
        public System.Action`1<UnityEngine.UIElements.DropdownMenuAction> actionCallback; // 0x30
        public System.Func`2<UnityEngine.UIElements.DropdownMenuAction,0x6B11AF68> actionStatusCallback; // 0x38

        // ── Methods ──
        public void set_status(){} // RVA: 0x7FFAC392CD10
        public void set_eventInfo(){} // RVA: 0x7FFAC2F4F0D0
        public void set_userData(){} // RVA: 0x7FFAC2F22E90
        public void AlwaysEnabled(){} // RVA: 0x7FFAC457C810
        public void AlwaysDisabled(){} // RVA: 0x7FFAC9B7A160
        public void .ctor(){} // RVA: 0x7FFAC9B7A170
        public void UpdateActionStatus(){} // RVA: 0x7FFAC9B7A2C0
    }

    public class DropdownMenuEventInfo : Object
    {
        public 0x6B27F588 <modifiers>k__BackingField; // 0x10
        public UnityEngine.Vector2 <mousePosition>k__BackingField; // 0x14
        public UnityEngine.Vector2 <localMousePosition>k__BackingField; // 0x1C
        public char <character>k__BackingField; // 0x24
        public 0x6B17D1A8 <keyCode>k__BackingField; // 0x28

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B79FC0
    }

    public class DropdownMenuItem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DropdownMenuSeparator : DropdownMenuItem
    {
        public string <subMenuPath>k__BackingField; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F22E30
    }

    public class DropdownUtility : Object
    {
        public System.Func`1<UnityEngine.UIElements.IGenericMenu> MakeDropdownFunc;

        // ── Methods ──
        public void CreateDropdown(){} // RVA: 0x7FFAC9B7AF60
    }

    public class DynamicAtlas : AtlasBase
    {
        public System.Collections.Generic.Dictionary`2<UnityEngine.Texture,TextureInfo> isInitialized; // 0x18
        public UnityEngine.UIElements.DynamicAtlasPage minAtlasSize; // 0x20
        public UnityEngine.UIElements.DynamicAtlasPage maxAtlasSize; // 0x28
        public 0x6B17BE68 defaultFilters; // 0x30
        public System.Collections.Generic.List`1<UnityEngine.UIElements.IPanel> activeFilters; // 0x38
        public int maxSubTextureSize; // 0x40
        public int customFilter; // 0x44
        public int m_MaxSubTextureSize; // 0x48
        public 0x6B114060 m_ActiveFilters; // 0x4C
        public UnityEngine.UIElements.DynamicAtlasCustomFilter m_CustomFilter; // 0x50

        // ── Methods ──
        public void get_isInitialized(){} // RVA: 0x7FFAC9A7B500
        public void OnAssignedToPanel(){} // RVA: 0x7FFAC9A7B520
        public void OnRemovedFromPanel(){} // RVA: 0x7FFAC9A7B620
        public void Reset(){} // RVA: 0x7FFAC9A7B6C0
        public void InitPages(){} // RVA: 0x7FFAC9A7B790
        public void DestroyPages(){} // RVA: 0x7FFAC9A7BA40
        public void TryGetAtlas(){} // RVA: 0x7FFAC9A7BB60
        public void ReturnAtlas(){} // RVA: 0x7FFAC9A7C080
        public void OnUpdateDynamicTextures(){} // RVA: 0x7FFAC9A7C370
        public void IsTextureFormatSupported(){} // RVA: 0x7FFAC9A7C3F0
        public void IsTextureValid(){} // RVA: 0x7FFAC9A7C470
        public void set_minAtlasSize(){} // RVA: 0x7FFAC9A7C6A0
        public void set_maxAtlasSize(){} // RVA: 0x7FFAC9A7C6C0
        public void get_defaultFilters(){} // RVA: 0x7FFAC8D97D00
        public void set_activeFilters(){} // RVA: 0x7FFAC9A7C6E0
        public void get_maxSubTextureSize(){} // RVA: 0x7FFAC9987B70
        public void set_maxSubTextureSize(){} // RVA: 0x7FFAC9A7C700
        public void set_customFilter(){} // RVA: 0x7FFAC9A7C720
        public void .ctor(){} // RVA: 0x7FFAC9A7C7D0
    }

    public class DynamicAtlasCustomFilter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC6CEBC10
        public void Invoke(){} // RVA: 0x7FFAC307D370
    }

    public class DynamicAtlasPage : Object
    {
        public UnityEngine.UIElements.TextureId textureId; // 0x10
        public UnityEngine.RenderTexture atlas; // 0x18
        public 0x6B17C180 format; // 0x20
        public 0x6B17BF70 filterMode; // 0x24
        public UnityEngine.Vector2Int disposed; // 0x28
        public UnityEngine.Vector2Int <maxSize>k__BackingField; // 0x30
        public int m_1Padding; // 0x38
        public int m_2Padding; // 0x3C
        public UnityEngine.UIElements.UIR.Allocator2D m_Allocator; // 0x40
        public UnityEngine.UIElements.UIR.TextureBlitter m_Blitter; // 0x48
        public UnityEngine.Vector2Int m_CurrentSize; // 0x50
        public int s_TextureCounter;
        public bool <disposed>k__BackingField; // 0x58

        // ── Methods ──
        public void get_textureId(){} // RVA: 0x7FFAC2F6E5C0
        public void set_textureId(){} // RVA: 0x7FFAC2F240C0
        public void get_atlas(){} // RVA: 0x7FFAC2F247C0
        public void set_atlas(){} // RVA: 0x7FFAC2F87E80
        public void get_format(){} // RVA: 0x7FFAC30DBBE0
        public void get_filterMode(){} // RVA: 0x7FFAC3921980
        public void .ctor(){} // RVA: 0x7FFAC9BC7870
        public void get_disposed(){} // RVA: 0x7FFAC313F600
        public void set_disposed(){} // RVA: 0x7FFAC3892770
        public void Dispose(){} // RVA: 0x7FFAC9BC7C60 | overloaded x2
        public void TryAdd(){} // RVA: 0x7FFAC9BC7ED0
        public void Update(){} // RVA: 0x7FFAC9BC80D0
        public void Remove(){} // RVA: 0x7FFAC9BC83D0
        public void Commit(){} // RVA: 0x7FFAC9BC84A0
        public void UpdateAtlasTexture(){} // RVA: 0x7FFAC9BC85D0
        public void CreateAtlasTexture(){} // RVA: 0x7FFAC9BC8C70
    }

    public class DynamicAtlasSettings : Object
    {
        public int minAtlasSize; // 0x10
        public int maxAtlasSize; // 0x14
        public int maxSubTextureSize; // 0x18
        public 0x6B114060 activeFilters; // 0x1C
        public UnityEngine.UIElements.DynamicAtlasCustomFilter defaultFilters; // 0x20

        // ── Methods ──
        public void get_minAtlasSize(){} // RVA: 0x7FFAC2F6E5C0
        public void set_minAtlasSize(){} // RVA: 0x7FFAC2F240C0
        public void get_maxAtlasSize(){} // RVA: 0x7FFAC33D5A20
        public void set_maxAtlasSize(){} // RVA: 0x7FFAC33D4990
        public void get_maxSubTextureSize(){} // RVA: 0x7FFAC3157800
        public void set_maxSubTextureSize(){} // RVA: 0x7FFAC392CD10
        public void get_activeFilters(){} // RVA: 0x7FFAC44357F0
        public void set_activeFilters(){} // RVA: 0x7FFAC44474D0
        public void get_defaultFilters(){} // RVA: 0x7FFAC8D97D00
        public void get_customFilter(){} // RVA: 0x7FFAC2F4F0C0
        public void set_customFilter(){} // RVA: 0x7FFAC2F4F0D0
        public void get_defaults(){} // RVA: 0x7FFAC9B95680
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class DynamicHeightVirtualizationController`1 : VerticalVirtualizationController`1
    {
        public int defaultExpectedHeight;
        public System.Collections.Generic.Dictionary`2<int,float> contentPadding;
        public System.Collections.Generic.Dictionary`2<int,ContentHeightCacheInfo<T>> contentHeight;
        public System.Collections.Generic.HashSet`1<int> anchoredIndex;
        public int anchorOffset;
        public int viewportMaxOffset;
        public bool alwaysRebindOnRefresh;
        public 0x6B114BB8<T> m_LastChange;
        public 0x6B114C10<T> m_ScrollDirection;
        public UnityEngine.Vector2 m_DelayedScrollOffset;
        public float m_AccumulatedHeight;
        public float m_MinimumItemHeight;
        public System.Action m_FillCallback;
        public System.Action m_ScrollCallback;
        public System.Action m_ScrollResetCallback;
        public System.Action`1<UnityEngine.UIElements.ReusableCollectionItem> m_GeometryChangedCallback;
        public UnityEngine.UIElements.IVisualElementScheduledItem m_ScheduledItem;
        public UnityEngine.UIElements.IVisualElementScheduledItem m_ScrollScheduledItem;
        public UnityEngine.UIElements.IVisualElementScheduledItem m_ScrollResetScheduledItem;
        public System.Predicate`1<int> m_IndexOutOfBoundsPredicate;

        // ── Methods ──
        public void get_defaultExpectedHeight(){} // RVA: 0x7FFAC2C6D880
        public void get_contentPadding(){} // RVA: 0x7FFAC2C6D880
        public void set_contentPadding(){} // RVA: 0x7FFAC2C7E480
        public void get_contentHeight(){} // RVA: 0x7FFAC2C6D880
        public void set_contentHeight(){} // RVA: 0x7FFAC2C7E480
        public void get_anchoredIndex(){} // RVA: 0x7FFAC2C59960
        public void set_anchoredIndex(){} // RVA: 0x7FFAC2C70ED0
        public void get_anchorOffset(){} // RVA: 0x7FFAC2C6D880
        public void set_anchorOffset(){} // RVA: 0x7FFAC2C7E480
        public void get_viewportMaxOffset(){} // RVA: 0x7FFAC2C6D880
        public void get_alwaysRebindOnRefresh(){} // RVA: 0x7FFAC2C59D00
        public void .ctor(){} // RVA: 0x7FFAC2C70A40
        public void Refresh(){} // RVA: 0x7FFAC2C71060
        public void ScrollToItem(){} // RVA: 0x7FFAC2C70ED0
        public void Resize(){} // RVA: 0x7FFAC2C7F3E0
        public void OnScroll(){} // RVA: 0x7FFAC2C7F3E0
        public void OnScrollUpdate(){} // RVA: 0x7FFAC2C70980
        public void CycleItems(){} // RVA: 0x7FFAC2C70ED0
        public void NeedsFill(){} // RVA: 0x7FFAC2C59D00
        public void Fill(){} // RVA: 0x7FFAC2C70980
        public void UpdateScrollViewContainer(){}
        public void ApplyScrollViewUpdate(){} // RVA: 0x7FFAC2C71060
        public void UpdateAnchor(){} // RVA: 0x7FFAC2C70980
        public void ScheduleFill(){} // RVA: 0x7FFAC2C70980
        public void ScheduleScroll(){} // RVA: 0x7FFAC2C70980
        public void ScheduleScrollDirectionReset(){} // RVA: 0x7FFAC2C70980
        public void ResetScroll(){} // RVA: 0x7FFAC2C70980
        public void GetIndexFromPosition(){}
        public void GetExpectedItemHeight(){} // RVA: 0x7FFAC2C6DC30
        public void GetFirstVisibleItem(){}
        public void GetExpectedContentHeight(){} // RVA: 0x7FFAC2C6D880
        public void GetContentHeightForIndex(){} // RVA: 0x7FFAC2C6DC30
        public void GetCachedContentHeight(){} // RVA: 0x7FFAC2E8DC40
        public void RegisterItemHeight(){} // RVA: 0x7FFAC2C74400
        public void UnregisterItemHeight(){} // RVA: 0x7FFAC2C70ED0
        public void CleanItemHeightCache(){} // RVA: 0x7FFAC2C70980
        public void OnRecycledItemGeometryChanged(){} // RVA: 0x7FFAC2C70A40
        public void UpdateRegisteredHeight(){} // RVA: 0x7FFAC2C59F60
        public void GetOrMakeItemAtIndex(){} // RVA: 0x7FFAC2E8DC40
        public void ReleaseItem(){} // RVA: 0x7FFAC2C70ED0
        public void StartDragItem(){} // RVA: 0x7FFAC2C70A40
        public void EndDrag(){} // RVA: 0x7FFAC2C70ED0
        public void HideItem(){} // RVA: 0x7FFAC2C70ED0
        public void MarkWaitingForLayout(){} // RVA: 0x7FFAC2E8DC40
        public void IsIndexOutOfBounds(){} // RVA: 0x7FFAC2C5A310
    }

}