// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 29
// Methods: 277

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class DataBinding : Binding
    {
        // ── Methods ──
        public void get_updateUIMethod(){} // RVA: 0x7E6B940
        public void CacheReflectionInfo(){} // RVA: 0x7E6B9F0
        public void get_dataSource(){} // RVA: 0xD05CA0
        public void set_dataSource(){} // RVA: 0xD09D70
        public void get_dataSourceType(){} // RVA: 0xBC1B30
        public void set_dataSourceType(){} // RVA: 0xB6A8C0
        public void get_dataSourcePath(){} // RVA: 0x7E6BC00
        public void set_dataSourcePath(){} // RVA: 0x7E6BC60
        public void get_bindingMode(){} // RVA: 0xFEAE90
        public void set_bindingMode(){} // RVA: 0x7E6BD10
        public void get_sourceToUiConverters(){} // RVA: 0x7E6BD20
        public void get_uiToSourceConverters(){} // RVA: 0x7E6BE00
        public void ApplyConverterGroupToSource(){} // RVA: 0x7E6BEE0
        public void ApplyConverterGroupToUI(){} // RVA: 0x7E6BF70
        public void UpdateUI(){} // RVA: 0x87C6B0
        public void UpdateSource(){} // RVA: 0x87C6B0
        public void GetSetValueErrorString(){} // RVA: 0xA94080
    }

    public class DataBindingManager : Object
    {
        // ── Methods ──
        public void get_logLevel(){} // RVA: 0x7E6C000
        public void set_logLevel(){} // RVA: 0x7E6C090
        public void ResetLogLevel(){} // RVA: 0x5A81B80
        public void .ctor(){} // RVA: 0x7E6C0F0
        public void GetTrackedDataSourcesCount(){} // RVA: 0x7E6C450
        public void TryGetLastVersion(){} // RVA: 0x7E6C4A0
        public void UpdateVersion(){} // RVA: 0x7E6C550
        public void CacheUIBindingResult(){} // RVA: 0x7E6C610
        public void TryGetLastUIBindingResult(){} // RVA: 0x7E6C730
        public void CacheSourceBindingResult(){} // RVA: 0x7E6C800
        public void TryGetLastSourceBindingResult(){} // RVA: 0x7E6C920
        public void GetResolvedDataSourceContext(){} // RVA: 0x7E6C9F0
        public void GetBoundElementsCount(){} // RVA: 0x7E6CB40
        public void GetBoundElements(){} // RVA: 0x7E6CB90
        public void IgnoreChangesScope(){} // RVA: 0x7E6CBB0
        public void GetChangedDetectedFromUI(){} // RVA: 0x7C7DF30
        public void GetChangedDetectedFromSource(){} // RVA: 0x7E6CD20
        public void ClearChangesFromSource(){} // RVA: 0x7E6CDC0
        public void GetBindingData(){} // RVA: 0x7E6CE70
        public void TryGetBindingData(){} // RVA: 0x7E6CF60
        public void RegisterBinding(){} // RVA: 0x7E6D0E0
        public void UnregisterBinding(){} // RVA: 0x7E6DDC0
        public void TransferBindingRequests(){} // RVA: 0x7E6E7E0
        public void InvalidateCachedDataSource(){} // RVA: 0x7E6E9D0
        public void Dispose(){} // RVA: 0x7E6E9F0
        public void CreateBindingRequest(){} // RVA: 0x7E6EA80
        public void ProcessBindingRequests(){} // RVA: 0x7E6EED0
        public void ClearAllBindings(){} // RVA: 0x7E6F500
        public void AnyPendingBindingRequests(){} // RVA: 0x7E6F7F0
        public void TryGetBindingRequest(){} // RVA: 0x7E6F8D0
        public void DirtyBindingOrder(){} // RVA: 0x7E6FC00
        public void TrackDataSource(){} // RVA: 0x7E6FC20
        public void ClearSourceCache(){} // RVA: 0x7E6FC70
        public void GetPooledBindingData(){} // RVA: 0x7E6FC90
        public void ReleasePoolBindingData(){} // RVA: 0x7E6FEC0
        public void .cctor(){} // RVA: 0x7E70060
    }

    public class DataBindingUtility : Object
    {
        // ── Methods ──
        public void TryGetBinding(){} // RVA: 0x7E77750
        public void .cctor(){} // RVA: 0x7E77C80
    }

    public class DataSourceContext : ValueType
    {
        // ── Methods ──
        public void get_dataSource(){} // RVA: 0x77900
        public void get_dataSourcePath(){} // RVA: 0x9920F0
        public void .ctor(){} // RVA: 0x992150
    }

    public class DataSourceContextChanged : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x992220
    }

    public class DefaultDragAndDropClient : DragAndDropData
    {
        // ── Methods ──
        public void get_source(){} // RVA: 0x8047310
        public void GetGenericData(){} // RVA: 0x8047360
        public void StartDrag(){} // RVA: 0x80473D0
        public void UpdateDrag(){} // RVA: 0x8047B70
        public void AcceptDrag(){} // RVA: 0xB43310
        public void SetVisualMode(){} // RVA: 0x13233D0
        public void DragCleanup(){} // RVA: 0x8047D50
        public void get_data(){} // RVA: 0x2303260
        public void .ctor(){} // RVA: 0x8047E00
    }

    public class DefaultEventSystem : Object
    {
        // ── Methods ──
        public void get_isAppFocused(){} // RVA: 0x803E5E0
        public void ShouldIgnoreEventsOnAppNotFocused(){} // RVA: 0x803E660
        public void get_focusedPanel(){} // RVA: 0xB5DBF0
        public void set_focusedPanel(){} // RVA: 0x803E6B0
        public void Update(){} // RVA: 0x803E740
        public void get_legacyInputProcessor(){} // RVA: 0x803E860
        public void get_inputForUIProcessor(){} // RVA: 0x803EA90
        public void set_isInputReady(){} // RVA: 0x803ECF0
        public void FocusBasedEventSequence(){} // RVA: 0x803EF70
        public void RemoveInputProcessor(){} // RVA: 0x803EFA0
        public void InitInputProcessor(){} // RVA: 0x803F0D0
        public void OnFocusEvent(){} // RVA: 0x803F220
        public void SendFocusBasedEvent(){} // RVA: 0xA94080
        public void SendPositionBasedEvent(){} // RVA: 0xA94080
        public void UpdateFocusedPanel(){} // RVA: 0x803F230
        public void MakeTouchEvent(){} // RVA: 0x803F2D0
        public void MakePenEvent(){} // RVA: 0x803F3D0
        public void Log(){} // RVA: 0x803F4C0
        public void LogWarning(){} // RVA: 0x803F570
        public void LogToGameScreen(){} // RVA: 0x803F630
        public void .ctor(){} // RVA: 0x803F9C0
        public void .cctor(){} // RVA: 0x803FA80
    }

    public class DefaultGroupManager : Object
    {
        // ── Methods ──
        public void Init(){} // RVA: 0xB70100
        public void OnOptionSelectionChanged(){} // RVA: 0x807B700
        public void RegisterOption(){} // RVA: 0x807B990
        public void UnregisterOption(){} // RVA: 0x807BAC0
        public void .ctor(){} // RVA: 0x807BB50
    }

    public class DefaultMultiColumnTreeViewController`1 : MultiColumnTreeViewController
    {
        // ── Methods ──
        public void get_treeDataController(){} // RVA: 0x87C0A0
        public void .ctor(){} // RVA: 0x8954D0
        public void get_itemsSource(){} // RVA: 0x87C0A0
        public void set_itemsSource(){} // RVA: 0x894320
        public void SetRootItems(){} // RVA: 0x894320
        public void GetItemForIndex(){} // RVA: 0x87C160
        public void <SetRootItems>b__7_0(){} // RVA: 0x881D60
        public void <SetRootItems>b__7_1(){} // RVA: 0x894810
    }

    public class DefaultTreeViewController`1 : TreeViewController
    {
        // ── Methods ──
        public void get_treeDataController(){} // RVA: 0x87C0A0
        public void get_itemsSource(){} // RVA: 0x87C0A0
        public void set_itemsSource(){} // RVA: 0x894320
        public void SetRootItems(){} // RVA: 0x894320
        public void GetItemForIndex(){} // RVA: 0x87C160
        public void .ctor(){} // RVA: 0x894290
        public void <SetRootItems>b__6_0(){} // RVA: 0x881D60
        public void <SetRootItems>b__6_1(){} // RVA: 0x894810
    }

    public class DetachFromPanelEvent : PanelChangedEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x80655C0
        public void .ctor(){} // RVA: 0x80656B0
    }

    public class DisposeHelper : Object
    {
        // ── Methods ──
        public void NotifyDisposedUsed(){} // RVA: 0x8046A60
    }

    public class DoubleField : TextValueField`1
    {
        // ── Methods ──
        public void get_doubleInput(){} // RVA: 0x7FDAE10
        public void ValueToString(){} // RVA: 0x7FDAEA0
        public void StringToValue(){} // RVA: 0x7FDB060
        public void .ctor(){} // RVA: 0x7FDB2E0
        public void CanTryParse(){} // RVA: 0x7FDB600
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FDB690
        public void .cctor(){} // RVA: 0x7FDB780
    }

    public class DragAndDropArgs : ValueType
    {
        // ── Methods ──
        public void set_target(){} // RVA: 0x47F10
        public void get_insertAtIndex(){} // RVA: 0x14790
        public void set_insertAtIndex(){} // RVA: 0x92DD0
        public void get_parentId(){} // RVA: 0x92DE0
        public void set_parentId(){} // RVA: 0x92DF0
        public void get_childIndex(){} // RVA: 0x8C7E0
        public void set_childIndex(){} // RVA: 0x8C7F0
        public void get_dragAndDropPosition(){} // RVA: 0xAFF50
        public void set_dragAndDropPosition(){} // RVA: 0xAFF60
        public void get_dragAndDropData(){} // RVA: 0x931A0
        public void set_dragAndDropData(){} // RVA: 0x93120
    }

    public class DragAndDropData : Object
    {
        // ── Methods ──
        public void GetGenericData(){} // RVA: 0x87C540
        public void get_source(){} // RVA: 0x87C0A0
        public void set_paths(){} // RVA: 0xB44D60
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DragAndDropUtility : Object
    {
        // ── Methods ──
        public void GetDragAndDrop(){} // RVA: 0x8047110
    }

    public class DragEventsProcessor : Object
    {
        // ── Methods ──
        public void get_supportsDragEvents(){} // RVA: 0xC2E4C0
        public void get_useDragEvents(){} // RVA: 0x8047EB0
        public void get_dragAndDrop(){} // RVA: 0x8047F10
        public void get_isEditorContext(){} // RVA: 0x8047F40
        public void .ctor(){} // RVA: 0x8048020
        public void RegisterCallbacksFromTarget(){} // RVA: 0x80481B0
        public void UnregisterCallbacksFromTarget(){} // RVA: 0x80485D0
        public void CanStartDrag(){} // RVA: 0x87D350
        public void StartDrag(){} // RVA: 0x87BF80
        public void UpdateDrag(){} // RVA: 0x894320
        public void OnDrop(){} // RVA: 0x894320
        public void ClearDragAndDropUI(){} // RVA: 0x894750
        public void OnPointerDownEvent(){} // RVA: 0x80491D0
        public void OnPointerOutEvent(){} // RVA: 0x80492A0
        public void OnPointerUpEvent(){} // RVA: 0x8049350
        public void OnPointerLeaveEvent(){} // RVA: 0x8049550
        public void OnPointerCancelEvent(){} // RVA: 0x8049570
        public void OnPointerCapturedOut(){} // RVA: 0x80495D0
        public void OnGeometryChanged(){} // RVA: 0x80495E0
        public void CancelDragAndDrop(){} // RVA: 0x8049660
        public void OnPointerMoveEvent(){} // RVA: 0x8049770
        public void GetDropTarget(){} // RVA: 0x8049AA0
    }

    public class DropdownField : PopupField`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FDBFC0
    }

    public class DropdownMenu : Object
    {
        // ── Methods ──
        public void get_Count(){} // RVA: 0x8052CC0
        public void MenuItems(){} // RVA: 0x3E42230
        public void AppendAction(){} // RVA: 0x8052EF0
        public void AppendSeparator(){} // RVA: 0x8053020
        public void InsertSeparator(){} // RVA: 0x80533D0
        public void PrepareForDisplay(){} // RVA: 0x8053580
        public void .ctor(){} // RVA: 0x80538D0
    }

    public class DropdownMenuAction : DropdownMenuItem
    {
        // ── Methods ──
        public void get_name(){} // RVA: 0xB5DBF0
        public void set_status(){} // RVA: 0x1033F40
        public void set_eventInfo(){} // RVA: 0xB70100
        public void set_userData(){} // RVA: 0xB44DC0
        public void AlwaysEnabled(){} // RVA: 0x8052AC0
        public void AlwaysDisabled(){} // RVA: 0x8052AD0
        public void .ctor(){} // RVA: 0x8052AE0
        public void UpdateActionStatus(){} // RVA: 0x8052C30
    }

    public class DropdownMenuEventInfo : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x8052880
    }

    public class DropdownMenuItem : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DropdownMenuSeparator : DropdownMenuItem
    {
        // ── Methods ──
        public void get_subMenuPath(){} // RVA: 0xB5DBF0
        public void .ctor(){} // RVA: 0xB44D60
    }

    public class DropdownUtility : Object
    {
        // ── Methods ──
        public void CreateDropdown(){} // RVA: 0x8053A30
    }

    public class DynamicAtlas : AtlasBase
    {
        // ── Methods ──
        public void get_isInitialized(){} // RVA: 0x7E4EE30
        public void OnAssignedToPanel(){} // RVA: 0x7E4EE50
        public void OnRemovedFromPanel(){} // RVA: 0x7E4EF50
        public void Reset(){} // RVA: 0x7E4EFF0
        public void InitPages(){} // RVA: 0x7E4F0E0
        public void DestroyPages(){} // RVA: 0x7E4F300
        public void TryGetAtlas(){} // RVA: 0x7E4F420
        public void ReturnAtlas(){} // RVA: 0x7E4F930
        public void OnUpdateDynamicTextures(){} // RVA: 0x7E4FC20
        public void IsTextureFormatSupported(){} // RVA: 0x7E4FCA0
        public void IsTextureValid(){} // RVA: 0x7E4FD30
        public void set_minAtlasSize(){} // RVA: 0x7E4FFA0
        public void set_maxAtlasSize(){} // RVA: 0x7E4FFC0
        public void get_defaultFilters(){} // RVA: 0x706F050
        public void set_activeFilters(){} // RVA: 0x7E4FFE0
        public void get_maxSubTextureSize(){} // RVA: 0x7D172B0
        public void set_maxSubTextureSize(){} // RVA: 0x7E50000
        public void set_customFilter(){} // RVA: 0x7E50020
        public void .ctor(){} // RVA: 0x7E500D0
    }

    public class DynamicAtlasCustomFilter : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x4F34F40
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class DynamicAtlasPage : Object
    {
        // ── Methods ──
        public void get_textureId(){} // RVA: 0xB8F8F0
        public void set_textureId(){} // RVA: 0xB460A0
        public void get_atlas(){} // RVA: 0xB465B0
        public void set_atlas(){} // RVA: 0xBA9BA0
        public void get_format(){} // RVA: 0xFEAE90
        public void get_filterMode(){} // RVA: 0x15AF000
        public void .ctor(){} // RVA: 0x80A5760
        public void get_disposed(){} // RVA: 0xE3F480
        public void set_disposed(){} // RVA: 0x1546550
        public void Dispose(){} // RVA: 0x80A5B60
        public void TryAdd(){} // RVA: 0x80A5DD0
        public void Update(){} // RVA: 0x80A5FC0
        public void Remove(){} // RVA: 0x80A62C0
        public void Commit(){} // RVA: 0x80A6390
        public void UpdateAtlasTexture(){} // RVA: 0x80A64C0
        public void CreateAtlasTexture(){} // RVA: 0x80A6B40
    }

    public class DynamicAtlasSettings : Object
    {
        // ── Methods ──
        public void get_minAtlasSize(){} // RVA: 0xB8F8F0
        public void set_minAtlasSize(){} // RVA: 0xB460A0
        public void get_maxAtlasSize(){} // RVA: 0x116A650
        public void set_maxAtlasSize(){} // RVA: 0x116BB10
        public void get_maxSubTextureSize(){} // RVA: 0xE62D00
        public void set_maxSubTextureSize(){} // RVA: 0x1033F40
        public void get_activeFilters(){} // RVA: 0x2244FB0
        public void set_activeFilters(){} // RVA: 0x22735B0
        public void get_defaultFilters(){} // RVA: 0x706F050
        public void get_customFilter(){} // RVA: 0xB700F0
        public void set_customFilter(){} // RVA: 0xB70100
        public void get_defaults(){} // RVA: 0x806FBE0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class DynamicHeightVirtualizationController`1 : VerticalVirtualizationController`1
    {
        // ── Methods ──
        public void get_defaultExpectedHeight(){} // RVA: 0x890F90
        public void get_contentPadding(){} // RVA: 0x890F90
        public void set_contentPadding(){} // RVA: 0x8A23A0
        public void get_contentHeight(){} // RVA: 0x890F90
        public void set_contentHeight(){} // RVA: 0x8A23A0
        public void get_anchoredIndex(){} // RVA: 0x87C130
        public void set_anchoredIndex(){} // RVA: 0x8944F0
        public void get_anchorOffset(){} // RVA: 0x890F90
        public void set_anchorOffset(){} // RVA: 0x8A23A0
        public void get_viewportMaxOffset(){} // RVA: 0x890F90
        public void get_alwaysRebindOnRefresh(){} // RVA: 0x87D280
        public void .ctor(){} // RVA: 0x894320
        public void OnGeometryChangedEvent(){} // RVA: 0x894320
        public void Refresh(){} // RVA: 0x894750
        public void ScrollToItem(){} // RVA: 0x8944F0
        public void Resize(){} // RVA: 0x895F20
        public void OnScroll(){} // RVA: 0x895F20
        public void OnDetachFromPanelEvent(){} // RVA: 0x894320
        public void OnScrollUpdate(){} // RVA: 0x894290
        public void CycleItems(){} // RVA: 0x8944F0
        public void NeedsFill(){} // RVA: 0x87D280
        public void Fill(){} // RVA: 0x894290
        public void UpdateScrollViewContainer(){} // RVA: 0x8A2920
        public void ApplyScrollViewUpdate(){} // RVA: 0x894750
        public void UpdateAnchor(){} // RVA: 0x894290
        public void ScheduleFill(){} // RVA: 0x894290
        public void ScheduleScrollDirectionReset(){} // RVA: 0x894290
        public void ResetScroll(){} // RVA: 0x894290
        public void GetIndexFromPosition(){} // RVA: 0x8833B0
        public void GetExpectedItemHeight(){} // RVA: 0x891330
        public void GetFirstVisibleItem(){} // RVA: 0x888E40
        public void GetExpectedContentHeight(){} // RVA: 0x890F90
        public void GetContentHeightForIndex(){} // RVA: 0x891330
        public void GetCachedContentHeight(){} // RVA: 0xA94080
        public void RegisterItemHeight(){} // RVA: 0x897DD0
        public void UnregisterItemHeight(){} // RVA: 0x8944F0
        public void CleanItemHeightCache(){} // RVA: 0x894290
        public void OnRecycledItemGeometryChanged(){} // RVA: 0x894320
        public void UpdateRegisteredHeight(){} // RVA: 0x87D350
        public void GetOrMakeItemAtIndex(){} // RVA: 0xA94080
        public void ReleaseItem(){} // RVA: 0x8944F0
        public void StartDragItem(){} // RVA: 0x894320
        public void EndDrag(){} // RVA: 0x8944F0
        public void HideItem(){} // RVA: 0x8944F0
        public void MarkWaitingForLayout(){} // RVA: 0xA94080
        public void IsIndexOutOfBounds(){} // RVA: 0x87DD20
        public void <GetContentHeightForIndex>g__GetContentHeightFromCachedHeight|66_0(){} // RVA: 0xA94080
    }

}