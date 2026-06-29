// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 100
// Methods: 662

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class IBindable
    {
        // ── Methods ──
        public void get_binding(){} // RVA: 0x87C0A0
        public void set_bindingPath(){} // RVA: 0x894320
    }

    public class IBinding
    {
        // ── Methods ──
        public void PreUpdate(){} // RVA: 0x894290
        public void Update(){} // RVA: 0x894290
        public void Release(){} // RVA: 0x894290
    }

    public class IBindingRequest
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x894320
    }

    public class ICursorManager
    {
        // ── Methods ──
        public void SetCursor(){} // RVA: 0x894320
        public void ResetCursor(){} // RVA: 0x894290
    }

    public class IDataSourceProvider
    {
        // ── Methods ──
        public void get_dataSource(){} // RVA: 0x87C0A0
        public void get_dataSourcePath(){} // RVA: 0x87BEB0
    }

    public class IDataSourceViewHashProvider
    {
        // ── Methods ──
        public void GetViewHashCode(){} // RVA: 0x87C0A0
    }

    public class IDelayedField
    {
        // ── Methods ──
        public void get_isDelayed(){} // RVA: 0x87D280
    }

    public class IDragAndDrop
    {
        // ── Methods ──
        public void StartDrag(){} // RVA: 0x8943B0
        public void UpdateDrag(){} // RVA: 0x894320
        public void AcceptDrag(){} // RVA: 0x894290
        public void DragCleanup(){} // RVA: 0x894290
        public void SetVisualMode(){} // RVA: 0x8944F0
        public void get_data(){} // RVA: 0x87C0A0
    }

    public class IDragAndDropController`1
    {
        // ── Methods ──
        public void CanStartDrag(){} // RVA: 0x87D350
        public void SetupDragAndDrop(){} // RVA: 0x87C9A0
        public void HandleDragAndDrop(){} // RVA: 0xA94080
        public void OnDrop(){} // RVA: 0xA94080
        public void DragCleanup(){} // RVA: 0x894290
        public void HandleAutoExpand(){} // RVA: 0x8A1F70
        public void GetSortedSelectedIds(){} // RVA: 0x87C0A0
    }

    public class IEditableElement
    {
        // ── Methods ──
        public void get_editingStarted(){} // RVA: 0x87C0A0
        public void get_editingEnded(){} // RVA: 0x87C0A0
    }

    public class IEventHandler
    {
        // ── Methods ──
        public void SendEvent(){} // RVA: 0x894320
    }

    public class IFocusRing
    {
        // ── Methods ──
        public void GetFocusChangeDirection(){} // RVA: 0x87C5F0
        public void GetNextFocusable(){} // RVA: 0x87C5F0
    }

    public class IGenericMenu
    {
        // ── Methods ──
        public void AddItem(){} // RVA: 0x89A710
        public void DropDown(){} // RVA: 0x89AA50
    }

    public class IKeyboardEvent
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x87C130
        public void get_character(){} // RVA: 0x87C100
        public void get_keyCode(){} // RVA: 0x87C130
    }

    public class IListDragAndDropArgs
    {
        // ── Methods ──
        public void get_insertAtIndex(){} // RVA: 0x87C130
        public void get_parentId(){} // RVA: 0x87C130
        public void get_childIndex(){} // RVA: 0x87C130
        public void get_dragAndDropData(){} // RVA: 0x87C0A0
        public void get_dragAndDropPosition(){} // RVA: 0x87C130
    }

    public class IMEEvent : EventBase`1
    {
        // ── Methods ──
        public void set_compositionString(){} // RVA: 0xBBFFA0
        public void .cctor(){} // RVA: 0x805DE70
        public void GetPooled(){} // RVA: 0x805DF60
        public void Init(){} // RVA: 0x805E020
        public void LocalInit(){} // RVA: 0x805E120
        public void .ctor(){} // RVA: 0x805E180
    }

    public class IMGUIContainer : VisualElement
    {
        // ── Methods ──
        public void get_onGUIHandler(){} // RVA: 0x807BC10
        public void set_onGUIHandler(){} // RVA: 0x807BC20
        public void get_guiState(){} // RVA: 0x807BD20
        public void get_lastWorldClip(){} // RVA: 0x807BE70
        public void set_lastWorldClip(){} // RVA: 0x807BE80
        public void get_cullingEnabled(){} // RVA: 0x807BE90
        public void set_cullingEnabled(){} // RVA: 0x807BEA0
        public void get_cache(){} // RVA: 0x807BF50
        public void get_layoutMeasuredWidth(){} // RVA: 0x807C010
        public void get_layoutMeasuredHeight(){} // RVA: 0x807C040
        public void get_contextType(){} // RVA: 0x8026780
        public void set_contextType(){} // RVA: 0x807C070
        public void get_focusOnlyIfHasFocusableControls(){} // RVA: 0x7FDD160
        public void get_canGrabFocus(){} // RVA: 0x807C100
        public void .cctor(){} // RVA: 0x807C130
        public void .ctor(){} // RVA: 0x807CC60
        public void OnGenerateVisualContent(){} // RVA: 0x807D150
        public void SaveGlobals(){} // RVA: 0x807D360
        public void RestoreGlobals(){} // RVA: 0x807D7D0
        public void DoOnGUI(){} // RVA: 0x807DC70
        public void MarkDirtyLayout(){} // RVA: 0x807FAE0
        public void DoIMGUIRepaint(){} // RVA: 0x807FB20
        public void SendEventToIMGUI(){} // RVA: 0x8080030
        public void SendEventToIMGUIRaw(){} // RVA: 0x8080400
        public void VerifyBounds(){} // RVA: 0x80804C0
        public void IsContainerCapturingTheMouse(){} // RVA: 0x80806C0
        public void IsLocalEvent(){} // RVA: 0x8080790
        public void IsEventInsideLocalWindow(){} // RVA: 0x80809B0
        public void IsDockAreaMouseUp(){} // RVA: 0x8080C00
        public void HandleIMGUIEvent(){} // RVA: 0x80810A0
        public void HandleEventBubbleUpDisabled(){} // RVA: 0x4B52F00
        public void HandleEventBubbleUp(){} // RVA: 0x8081780
        public void SetFoldoutDepthClass(){} // RVA: 0x8081C80
        public void DoMeasure(){} // RVA: 0x8081E50
        public void GetCurrentClipRect(){} // RVA: 0x8082350
        public void GetCurrentTransformAndClip(){} // RVA: 0x80823D0
        public void Dispose(){} // RVA: 0x80826D0
        public void <DoOnGUI>b__59_0(){} // RVA: 0x8082750
    }

    public class IMGUIContainer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IMGUIEvent : EventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x806BC50
        public void GetPooled(){} // RVA: 0x806BD40
        public void Init(){} // RVA: 0x806BDD0
        public void LocalInit(){} // RVA: 0x7FA9B20
        public void .ctor(){} // RVA: 0x806BE80
        public void Dispatch(){} // RVA: 0x805C9E0
    }

    public class IMouseEvent
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x87C130
        public void get_mousePosition(){} // RVA: 0x87C0A0
        public void get_localMousePosition(){} // RVA: 0x87C0A0
        public void get_mouseDelta(){} // RVA: 0x87C0A0
        public void get_clickCount(){} // RVA: 0x87C130
        public void get_button(){} // RVA: 0x87C130
        public void get_pressedButtons(){} // RVA: 0x87C130
    }

    public class IMouseEventInternal
    {
        // ── Methods ──
        public void get_triggeredByOS(){} // RVA: 0x87D280
        public void set_triggeredByOS(){} // RVA: 0x894750
        public void get_sourcePointerEvent(){} // RVA: 0x87C0A0
        public void set_sourcePointerEvent(){} // RVA: 0x894320
    }

    public class INavigationEvent
    {
        // ── Methods ──
        public void get_shiftKey(){} // RVA: 0x87D280
        public void get_altKey(){} // RVA: 0x87D280
    }

    public class INotifyBindablePropertyChanged
    {
        // ── Methods ──
        public void add_propertyChanged(){} // RVA: 0x894320
        public void remove_propertyChanged(){} // RVA: 0x894320
    }

    public class INotifyValueChangedExtensions : Object
    {
        // ── Methods ──
        public void RegisterValueChangedCallback(){} // RVA: 0x30EB1A0
        public void UnregisterValueChangedCallback(){} // RVA: 0x87D880
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0xA94080
        public void set_value(){} // RVA: 0xA94080
        public void SetValueWithoutNotify(){} // RVA: 0xA94080
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x895980
        public void get_value(){} // RVA: 0x8820E0
        public void set_value(){} // RVA: 0x895980
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x8A23A0
        public void get_value(){} // RVA: 0x890F90
        public void set_value(){} // RVA: 0x8A23A0
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x894320
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x894320
        public void get_value(){} // RVA: 0x87C0A0
        public void set_value(){} // RVA: 0x894320
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x8944F0
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x8943F0
        public void get_value(){} // RVA: 0x87C0A0
        public void set_value(){} // RVA: 0x8943F0
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x894750
        public void get_value(){} // RVA: 0x87D280
        public void set_value(){} // RVA: 0x894750
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x8944F0
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x8943F0
        public void get_value(){} // RVA: 0x87C0A0
        public void set_value(){} // RVA: 0x8943F0
    }

    public class IPanelRenderer
    {
        // ── Methods ──
        public void get_forceGammaRendering(){} // RVA: 0x87D280
        public void set_forceGammaRendering(){} // RVA: 0x894750
        public void get_vertexBudget(){} // RVA: 0x87C130
        public void set_vertexBudget(){} // RVA: 0x8944F0
        public void Reset(){} // RVA: 0x894290
        public void Render(){} // RVA: 0x894290
    }

    public class IPointerEvent
    {
        // ── Methods ──
        public void get_pointerId(){} // RVA: 0x87C130
        public void get_pointerType(){} // RVA: 0x87C0A0
        public void get_isPrimary(){} // RVA: 0x87D280
        public void get_button(){} // RVA: 0x87C130
        public void get_pressedButtons(){} // RVA: 0x87C130
        public void get_position(){} // RVA: 0x87BEB0
        public void get_localPosition(){} // RVA: 0x87BEB0
        public void get_deltaPosition(){} // RVA: 0x87BEB0
        public void get_deltaTime(){} // RVA: 0x890F90
        public void get_clickCount(){} // RVA: 0x87C130
        public void get_pressure(){} // RVA: 0x890F90
        public void get_tangentialPressure(){} // RVA: 0x890F90
        public void get_altitudeAngle(){} // RVA: 0x890F90
        public void get_azimuthAngle(){} // RVA: 0x890F90
        public void get_twist(){} // RVA: 0x890F90
        public void get_tilt(){} // RVA: 0x87C0A0
        public void get_penStatus(){} // RVA: 0x87C130
        public void get_radius(){} // RVA: 0x87C0A0
        public void get_radiusVariance(){} // RVA: 0x87C0A0
        public void get_modifiers(){} // RVA: 0x87C130
        public void get_shiftKey(){} // RVA: 0x87D280
        public void get_ctrlKey(){} // RVA: 0x87D280
        public void get_commandKey(){} // RVA: 0x87D280
        public void get_altKey(){} // RVA: 0x87D280
        public void get_actionKey(){} // RVA: 0x87D280
    }

    public class IPointerEventInternal
    {
        // ── Methods ──
        public void get_triggeredByOS(){} // RVA: 0x87D280
        public void set_triggeredByOS(){} // RVA: 0x894750
        public void get_compatibilityMouseEvent(){} // RVA: 0x87C0A0
        public void set_compatibilityMouseEvent(){} // RVA: 0x894320
        public void set_displayIndex(){} // RVA: 0x8944F0
    }

    public class IPointerOrMouseEvent
    {
        // ── Methods ──
        public void get_pointerId(){} // RVA: 0x87C130
        public void get_position(){} // RVA: 0x87BEB0
    }

    public class IReorderable
    {
        // ── Methods ──
        public void get_enableReordering(){} // RVA: 0x87D280
        public void set_enableReordering(){} // RVA: 0x894750
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0xA94080
        public void CopyFrom(){} // RVA: 0x894320
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x894320
        public void Copy(){} // RVA: 0xA94080
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x894320
        public void Copy(){} // RVA: 0xA94080
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x894320
        public void Copy(){} // RVA: 0xA94080
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x894320
        public void Copy(){} // RVA: 0xA94080
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x894320
        public void Copy(){} // RVA: 0xA94080
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x894320
        public void Copy(){} // RVA: 0xA94080
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x894320
        public void Copy(){} // RVA: 0xA94080
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0xA94080
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0xA94080
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87BEB0
        public void set_value(){} // RVA: 0x894320
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87BEB0
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87BEB0
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C0A0
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87BEB0
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C0A0
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x890F90
        public void set_value(){} // RVA: 0x8A23A0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87BEB0
        public void set_value(){} // RVA: 0x894320
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87BEB0
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87BEB0
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87BEB0
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87BEB0
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C0A0
        public void set_value(){} // RVA: 0x894320
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C0A0
        public void set_value(){} // RVA: 0x894320
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C0A0
        public void set_value(){} // RVA: 0x894320
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87BEB0
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C0A0
        public void set_value(){} // RVA: 0x894320
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87BEB0
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0xA94080
        public void set_value(){} // RVA: 0xA94080
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_keyword(){} // RVA: 0x87C130
        public void get_value(){} // RVA: 0xA94080
        public void set_value(){} // RVA: 0xA94080
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x87C130
        public void set_value(){} // RVA: 0x8944F0
        public void get_keyword(){} // RVA: 0x87C130
        public void set_keyword(){} // RVA: 0x8944F0
    }

    public class IUIElementsUtility
    {
        // ── Methods ──
        public void TakeCapture(){} // RVA: 0x87D280
        public void ReleaseCapture(){} // RVA: 0x87D280
        public void ProcessEvent(){} // RVA: 0x87E7B0
        public void CleanupRoots(){} // RVA: 0x87D280
        public void EndContainerGUIFromException(){} // RVA: 0x87D350
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0x87D280
    }

    public class IUIElementsUtility[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IValueField`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0xA94080
        public void set_value(){} // RVA: 0xA94080
        public void ApplyInputDeviceDelta(){} // RVA: 0xA94080
        public void StartDragging(){} // RVA: 0x894290
        public void StopDragging(){} // RVA: 0x894290
    }

    public class Image : VisualElement
    {
        // ── Methods ──
        public void get_image(){} // RVA: 0x166C430
        public void set_image(){} // RVA: 0x7FEA0B0
        public void get_sprite(){} // RVA: 0x16686F0
        public void set_sprite(){} // RVA: 0x7FEA380
        public void get_vectorImage(){} // RVA: 0x1653580
        public void set_vectorImage(){} // RVA: 0x7FEA670
        public void get_sourceRect(){} // RVA: 0x7FEA960
        public void set_sourceRect(){} // RVA: 0x7FEA990
        public void get_uv(){} // RVA: 0x7FEAB80
        public void set_uv(){} // RVA: 0x7FEAB90
        public void get_scaleMode(){} // RVA: 0x7FEAC60
        public void set_scaleMode(){} // RVA: 0x7FEAC70
        public void get_tintColor(){} // RVA: 0x7FEACA0
        public void set_tintColor(){} // RVA: 0x7FEACB0
        public void .ctor(){} // RVA: 0x7FEAD50
        public void GetTextureDisplaySize(){} // RVA: 0x7FEB0E0
        public void DoMeasure(){} // RVA: 0x7FEB300
        public void OnGenerateVisualContent(){} // RVA: 0x7FEB7B0
        public void OnCustomStyleResolved(){} // RVA: 0x7FEBFF0
        public void ReadCustomProperties(){} // RVA: 0x7FEC030
        public void SetProperty(){} // RVA: 0xA94080
        public void ClearProperty(){} // RVA: 0x7FEC810
        public void SetScaleMode(){} // RVA: 0x7FEC860
        public void SetTintColor(){} // RVA: 0x7FEC910
        public void CalculateUV(){} // RVA: 0x7FECA30
        public void GetSourceRect(){} // RVA: 0x7FECCE0
        public void .cctor(){} // RVA: 0x7FECFA0
    }

    public class InheritedData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x46D8D0
        public void CopyFrom(){} // RVA: 0x995F20
        public void op_Equality(){} // RVA: 0x7ECED70
        public void Equals(){} // RVA: 0x995FA0
        public void GetHashCode(){} // RVA: 0x9960B0
    }

    public class InlineStyleAccess : StyleValueCollection
    {
        // ── Methods ──
        public void UnityEngine.UIElements.IStyle.get_alignContent(){} // RVA: 0x80B8620
        public void UnityEngine.UIElements.IStyle.set_alignContent(){} // RVA: 0x80B8680
        public void UnityEngine.UIElements.IStyle.get_alignItems(){} // RVA: 0x80B8790
        public void UnityEngine.UIElements.IStyle.set_alignItems(){} // RVA: 0x80B87F0
        public void UnityEngine.UIElements.IStyle.get_alignSelf(){} // RVA: 0x80B8900
        public void UnityEngine.UIElements.IStyle.set_alignSelf(){} // RVA: 0x80B8960
        public void UnityEngine.UIElements.IStyle.get_backgroundColor(){} // RVA: 0x80B8A70
        public void UnityEngine.UIElements.IStyle.set_backgroundColor(){} // RVA: 0x80B8AE0
        public void UnityEngine.UIElements.IStyle.get_backgroundImage(){} // RVA: 0x80B8B50
        public void UnityEngine.UIElements.IStyle.set_backgroundImage(){} // RVA: 0x80B8BA0
        public void UnityEngine.UIElements.IStyle.get_backgroundPositionX(){} // RVA: 0x80B8C20
        public void UnityEngine.UIElements.IStyle.set_backgroundPositionX(){} // RVA: 0x80B8CA0
        public void UnityEngine.UIElements.IStyle.get_backgroundPositionY(){} // RVA: 0x80B8D10
        public void UnityEngine.UIElements.IStyle.set_backgroundPositionY(){} // RVA: 0x80B8D90
        public void UnityEngine.UIElements.IStyle.get_backgroundRepeat(){} // RVA: 0x80B8E00
        public void UnityEngine.UIElements.IStyle.set_backgroundRepeat(){} // RVA: 0x80B8E70
        public void UnityEngine.UIElements.IStyle.get_borderBottomColor(){} // RVA: 0x80B8FC0
        public void UnityEngine.UIElements.IStyle.set_borderBottomColor(){} // RVA: 0x80B9030
        public void UnityEngine.UIElements.IStyle.get_borderBottomLeftRadius(){} // RVA: 0x80B90A0
        public void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(){} // RVA: 0x80B9140
        public void UnityEngine.UIElements.IStyle.get_borderBottomRightRadius(){} // RVA: 0x80B91B0
        public void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(){} // RVA: 0x80B9250
        public void UnityEngine.UIElements.IStyle.get_borderBottomWidth(){} // RVA: 0x80B92C0
        public void UnityEngine.UIElements.IStyle.set_borderBottomWidth(){} // RVA: 0x80B9330
        public void UnityEngine.UIElements.IStyle.get_borderLeftColor(){} // RVA: 0x80B9430
        public void UnityEngine.UIElements.IStyle.set_borderLeftColor(){} // RVA: 0x80B94A0
        public void UnityEngine.UIElements.IStyle.get_borderLeftWidth(){} // RVA: 0x80B9510
        public void UnityEngine.UIElements.IStyle.set_borderLeftWidth(){} // RVA: 0x80B9580
        public void UnityEngine.UIElements.IStyle.get_borderRightColor(){} // RVA: 0x80B9680
        public void UnityEngine.UIElements.IStyle.set_borderRightColor(){} // RVA: 0x80B96F0
        public void UnityEngine.UIElements.IStyle.get_borderRightWidth(){} // RVA: 0x80B9760
        public void UnityEngine.UIElements.IStyle.set_borderRightWidth(){} // RVA: 0x80B97D0
        public void UnityEngine.UIElements.IStyle.get_borderTopColor(){} // RVA: 0x80B98D0
        public void UnityEngine.UIElements.IStyle.set_borderTopColor(){} // RVA: 0x80B9940
        public void UnityEngine.UIElements.IStyle.get_borderTopLeftRadius(){} // RVA: 0x80B99B0
        public void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(){} // RVA: 0x80B9A50
        public void UnityEngine.UIElements.IStyle.get_borderTopRightRadius(){} // RVA: 0x80B9AC0
        public void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(){} // RVA: 0x80B9B60
        public void UnityEngine.UIElements.IStyle.get_borderTopWidth(){} // RVA: 0x80B9BD0
        public void UnityEngine.UIElements.IStyle.set_borderTopWidth(){} // RVA: 0x80B9C40
        public void UnityEngine.UIElements.IStyle.get_bottom(){} // RVA: 0x80B9D40
        public void UnityEngine.UIElements.IStyle.set_bottom(){} // RVA: 0x80B9DE0
        public void UnityEngine.UIElements.IStyle.get_color(){} // RVA: 0x80B9EC0
        public void UnityEngine.UIElements.IStyle.set_color(){} // RVA: 0x80B9F30
        public void UnityEngine.UIElements.IStyle.get_display(){} // RVA: 0x80B9FA0
        public void UnityEngine.UIElements.IStyle.set_display(){} // RVA: 0x80BA000
        public void UnityEngine.UIElements.IStyle.get_flexBasis(){} // RVA: 0x80BA110
        public void UnityEngine.UIElements.IStyle.set_flexBasis(){} // RVA: 0x80BA1B0
        public void UnityEngine.UIElements.IStyle.get_flexDirection(){} // RVA: 0x80BA2A0
        public void UnityEngine.UIElements.IStyle.set_flexDirection(){} // RVA: 0x80BA300
        public void UnityEngine.UIElements.IStyle.get_flexGrow(){} // RVA: 0x80BA410
        public void UnityEngine.UIElements.IStyle.set_flexGrow(){} // RVA: 0x80BA480
        public void UnityEngine.UIElements.IStyle.get_flexShrink(){} // RVA: 0x80BA580
        public void UnityEngine.UIElements.IStyle.set_flexShrink(){} // RVA: 0x80BA5F0
        public void UnityEngine.UIElements.IStyle.get_flexWrap(){} // RVA: 0x80BA6F0
        public void UnityEngine.UIElements.IStyle.set_flexWrap(){} // RVA: 0x80BA750
        public void UnityEngine.UIElements.IStyle.get_fontSize(){} // RVA: 0x80BA860
        public void UnityEngine.UIElements.IStyle.set_fontSize(){} // RVA: 0x80BA900
        public void UnityEngine.UIElements.IStyle.get_height(){} // RVA: 0x80BA970
        public void UnityEngine.UIElements.IStyle.set_height(){} // RVA: 0x80BAA10
        public void UnityEngine.UIElements.IStyle.get_justifyContent(){} // RVA: 0x80BAB20
        public void UnityEngine.UIElements.IStyle.set_justifyContent(){} // RVA: 0x80BAB80
        public void UnityEngine.UIElements.IStyle.get_left(){} // RVA: 0x80BAC90
        public void UnityEngine.UIElements.IStyle.set_left(){} // RVA: 0x80BAD30
        public void UnityEngine.UIElements.IStyle.get_letterSpacing(){} // RVA: 0x80BAE10
        public void UnityEngine.UIElements.IStyle.set_letterSpacing(){} // RVA: 0x80BAEB0
        public void UnityEngine.UIElements.IStyle.get_marginBottom(){} // RVA: 0x80BAF20
        public void UnityEngine.UIElements.IStyle.set_marginBottom(){} // RVA: 0x80BAFC0
        public void UnityEngine.UIElements.IStyle.get_marginLeft(){} // RVA: 0x80BB0A0
        public void UnityEngine.UIElements.IStyle.set_marginLeft(){} // RVA: 0x80BB140
        public void UnityEngine.UIElements.IStyle.get_marginRight(){} // RVA: 0x80BB220
        public void UnityEngine.UIElements.IStyle.set_marginRight(){} // RVA: 0x80BB2C0
        public void UnityEngine.UIElements.IStyle.get_marginTop(){} // RVA: 0x80BB3A0
        public void UnityEngine.UIElements.IStyle.set_marginTop(){} // RVA: 0x80BB440
        public void UnityEngine.UIElements.IStyle.get_maxHeight(){} // RVA: 0x80BB520
        public void UnityEngine.UIElements.IStyle.set_maxHeight(){} // RVA: 0x80BB5C0
        public void UnityEngine.UIElements.IStyle.get_maxWidth(){} // RVA: 0x80BB6E0
        public void UnityEngine.UIElements.IStyle.set_maxWidth(){} // RVA: 0x80BB780
        public void UnityEngine.UIElements.IStyle.get_minHeight(){} // RVA: 0x80BB8A0
        public void UnityEngine.UIElements.IStyle.set_minHeight(){} // RVA: 0x80BB940
        public void UnityEngine.UIElements.IStyle.get_minWidth(){} // RVA: 0x80BBA60
        public void UnityEngine.UIElements.IStyle.set_minWidth(){} // RVA: 0x80BBB00
        public void UnityEngine.UIElements.IStyle.get_opacity(){} // RVA: 0x80BBC20
        public void UnityEngine.UIElements.IStyle.set_opacity(){} // RVA: 0x80BBC90
        public void UnityEngine.UIElements.IStyle.get_overflow(){} // RVA: 0x80BBCF0
        public void UnityEngine.UIElements.IStyle.set_overflow(){} // RVA: 0x80BBD50
        public void UnityEngine.UIElements.IStyle.get_paddingBottom(){} // RVA: 0x80BBEB0
        public void UnityEngine.UIElements.IStyle.set_paddingBottom(){} // RVA: 0x80BBF50
        public void UnityEngine.UIElements.IStyle.get_paddingLeft(){} // RVA: 0x80BC030
        public void UnityEngine.UIElements.IStyle.set_paddingLeft(){} // RVA: 0x80BC0D0
        public void UnityEngine.UIElements.IStyle.get_paddingRight(){} // RVA: 0x80BC1B0
        public void UnityEngine.UIElements.IStyle.set_paddingRight(){} // RVA: 0x80BC250
        public void UnityEngine.UIElements.IStyle.get_paddingTop(){} // RVA: 0x80BC330
        public void UnityEngine.UIElements.IStyle.set_paddingTop(){} // RVA: 0x80BC3D0
        public void UnityEngine.UIElements.IStyle.get_position(){} // RVA: 0x80BC4B0
        public void UnityEngine.UIElements.IStyle.set_position(){} // RVA: 0x80BC510
        public void UnityEngine.UIElements.IStyle.get_right(){} // RVA: 0x80BC620
        public void UnityEngine.UIElements.IStyle.set_right(){} // RVA: 0x80BC6C0
        public void UnityEngine.UIElements.IStyle.get_textOverflow(){} // RVA: 0x80BC7A0
        public void UnityEngine.UIElements.IStyle.set_textOverflow(){} // RVA: 0x80BC800
        public void UnityEngine.UIElements.IStyle.get_top(){} // RVA: 0x80BC890
        public void UnityEngine.UIElements.IStyle.set_top(){} // RVA: 0x80BC930
        public void UnityEngine.UIElements.IStyle.get_transitionDelay(){} // RVA: 0x80BCA10
        public void UnityEngine.UIElements.IStyle.set_transitionDelay(){} // RVA: 0x80BCA80
        public void UnityEngine.UIElements.IStyle.get_transitionDuration(){} // RVA: 0x80BCB20
        public void UnityEngine.UIElements.IStyle.set_transitionDuration(){} // RVA: 0x80BCB90
        public void UnityEngine.UIElements.IStyle.get_transitionProperty(){} // RVA: 0x80BCC30
        public void UnityEngine.UIElements.IStyle.set_transitionProperty(){} // RVA: 0x80BCCA0
        public void UnityEngine.UIElements.IStyle.get_transitionTimingFunction(){} // RVA: 0x80BCD40
        public void UnityEngine.UIElements.IStyle.set_transitionTimingFunction(){} // RVA: 0x80BCDB0
        public void UnityEngine.UIElements.IStyle.get_unityBackgroundImageTintColor(){} // RVA: 0x80BCE50
        public void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(){} // RVA: 0x80BCEC0
        public void UnityEngine.UIElements.IStyle.get_unityEditorTextRenderingMode(){} // RVA: 0x80BCF30
        public void UnityEngine.UIElements.IStyle.set_unityEditorTextRenderingMode(){} // RVA: 0x80BCF90
        public void UnityEngine.UIElements.IStyle.get_unityFont(){} // RVA: 0x80BD020
        public void UnityEngine.UIElements.IStyle.set_unityFont(){} // RVA: 0x80BD1B0
        public void UnityEngine.UIElements.IStyle.get_unityFontDefinition(){} // RVA: 0x80BD220
        public void UnityEngine.UIElements.IStyle.set_unityFontDefinition(){} // RVA: 0x80BD390
        public void UnityEngine.UIElements.IStyle.get_unityFontStyleAndWeight(){} // RVA: 0x80BD410
        public void UnityEngine.UIElements.IStyle.set_unityFontStyleAndWeight(){} // RVA: 0x80BD470
        public void UnityEngine.UIElements.IStyle.get_unityOverflowClipBox(){} // RVA: 0x80BD500
        public void UnityEngine.UIElements.IStyle.set_unityOverflowClipBox(){} // RVA: 0x80BD560
        public void UnityEngine.UIElements.IStyle.get_unityParagraphSpacing(){} // RVA: 0x80BD5F0
        public void UnityEngine.UIElements.IStyle.set_unityParagraphSpacing(){} // RVA: 0x80BD690
        public void UnityEngine.UIElements.IStyle.get_unitySliceBottom(){} // RVA: 0x80BD700
        public void UnityEngine.UIElements.IStyle.set_unitySliceBottom(){} // RVA: 0x80BD710
        public void UnityEngine.UIElements.IStyle.get_unitySliceLeft(){} // RVA: 0x80BD770
        public void UnityEngine.UIElements.IStyle.set_unitySliceLeft(){} // RVA: 0x80BD780
        public void UnityEngine.UIElements.IStyle.get_unitySliceRight(){} // RVA: 0x80BD7E0
        public void UnityEngine.UIElements.IStyle.set_unitySliceRight(){} // RVA: 0x80BD7F0
        public void UnityEngine.UIElements.IStyle.get_unitySliceScale(){} // RVA: 0x80BD850
        public void UnityEngine.UIElements.IStyle.set_unitySliceScale(){} // RVA: 0x80BD8C0
        public void UnityEngine.UIElements.IStyle.get_unitySliceTop(){} // RVA: 0x80BD920
        public void UnityEngine.UIElements.IStyle.set_unitySliceTop(){} // RVA: 0x80BD930
        public void UnityEngine.UIElements.IStyle.get_unitySliceType(){} // RVA: 0x80BD990
        public void UnityEngine.UIElements.IStyle.set_unitySliceType(){} // RVA: 0x80BD9F0
        public void UnityEngine.UIElements.IStyle.get_unityTextAlign(){} // RVA: 0x80BDA80
        public void UnityEngine.UIElements.IStyle.set_unityTextAlign(){} // RVA: 0x80BDAE0
        public void UnityEngine.UIElements.IStyle.get_unityTextGenerator(){} // RVA: 0x80BDB70
        public void UnityEngine.UIElements.IStyle.set_unityTextGenerator(){} // RVA: 0x80BDBD0
        public void UnityEngine.UIElements.IStyle.get_unityTextOutlineColor(){} // RVA: 0x80BDC60
        public void UnityEngine.UIElements.IStyle.set_unityTextOutlineColor(){} // RVA: 0x80BDCD0
        public void UnityEngine.UIElements.IStyle.get_unityTextOutlineWidth(){} // RVA: 0x80BDD40
        public void UnityEngine.UIElements.IStyle.set_unityTextOutlineWidth(){} // RVA: 0x80BDDB0
        public void UnityEngine.UIElements.IStyle.get_unityTextOverflowPosition(){} // RVA: 0x80BDE10
        public void UnityEngine.UIElements.IStyle.set_unityTextOverflowPosition(){} // RVA: 0x80BDE70
        public void UnityEngine.UIElements.IStyle.get_visibility(){} // RVA: 0x80BDF00
        public void UnityEngine.UIElements.IStyle.set_visibility(){} // RVA: 0x80BDF60
        public void UnityEngine.UIElements.IStyle.get_whiteSpace(){} // RVA: 0x80BDFF0
        public void UnityEngine.UIElements.IStyle.set_whiteSpace(){} // RVA: 0x80BE050
        public void UnityEngine.UIElements.IStyle.get_width(){} // RVA: 0x80BE0E0
        public void UnityEngine.UIElements.IStyle.set_width(){} // RVA: 0x80BE180
        public void UnityEngine.UIElements.IStyle.get_wordSpacing(){} // RVA: 0x80BE2A0
        public void UnityEngine.UIElements.IStyle.set_wordSpacing(){} // RVA: 0x80BE340
        public void get_ve(){} // RVA: 0xB700F0
        public void set_ve(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0x80BE3B0
        public void Finalize(){} // RVA: 0x80BE420
        public void SetInlineRule(){} // RVA: 0x80BE560
        public void IsValueSet(){} // RVA: 0x80BE7B0
        public void ApplyInlineStyles(){} // RVA: 0x80BEB90
        public void UnityEngine.UIElements.IStyle.get_cursor(){} // RVA: 0x80BF940
        public void UnityEngine.UIElements.IStyle.set_cursor(){} // RVA: 0x80BFA80
        public void UnityEngine.UIElements.IStyle.get_textShadow(){} // RVA: 0x80BFAF0
        public void UnityEngine.UIElements.IStyle.set_textShadow(){} // RVA: 0x80BFB60
        public void UnityEngine.UIElements.IStyle.get_backgroundSize(){} // RVA: 0x80BFBD0
        public void UnityEngine.UIElements.IStyle.set_backgroundSize(){} // RVA: 0x80BFC30
        public void GetStyleList(){} // RVA: 0xA94080
        public void SetStyleValueManaged(){} // RVA: 0x80BFDE0
        public void TryGetStyleValueManaged(){} // RVA: 0x80BFFC0
        public void UnityEngine.UIElements.IStyle.get_transformOrigin(){} // RVA: 0x80C0130
        public void UnityEngine.UIElements.IStyle.set_transformOrigin(){} // RVA: 0x80C0180
        public void UnityEngine.UIElements.IStyle.get_translate(){} // RVA: 0x80C0320
        public void UnityEngine.UIElements.IStyle.set_translate(){} // RVA: 0x80C0380
        public void UnityEngine.UIElements.IStyle.get_rotate(){} // RVA: 0x80C05F0
        public void UnityEngine.UIElements.IStyle.set_rotate(){} // RVA: 0x80C0650
        public void UnityEngine.UIElements.IStyle.get_scale(){} // RVA: 0x80C08F0
        public void UnityEngine.UIElements.IStyle.set_scale(){} // RVA: 0x80C0930
        public void SetStyleValue(){} // RVA: 0xA94080
        public void SetInlineCursor(){} // RVA: 0x80C2470
        public void ApplyStyleCursor(){} // RVA: 0x80C2740
        public void SetInlineTextShadow(){} // RVA: 0x80C2950
        public void ApplyStyleTextShadow(){} // RVA: 0x80C2B20
        public void SetInlineTransformOrigin(){} // RVA: 0x80C2F00
        public void ApplyStyleTransformOrigin(){} // RVA: 0x80C3080
        public void SetInlineTranslate(){} // RVA: 0x80C3410
        public void ApplyStyleTranslate(){} // RVA: 0x80C35D0
        public void SetInlineScale(){} // RVA: 0x80C39E0
        public void ApplyStyleScale(){} // RVA: 0x80C3B30
        public void SetInlineRotate(){} // RVA: 0x80C3D50
        public void ApplyStyleRotate(){} // RVA: 0x80C3F10
        public void SetInlineBackgroundSize(){} // RVA: 0x80C43D0
        public void ApplyStyleBackgroundSize(){} // RVA: 0x80C4540
        public void ApplyStyleValue(){} // RVA: 0x80C4BD0
        public void RemoveInlineStyle(){} // RVA: 0x80C4CD0
        public void ApplyFromComputedStyle(){} // RVA: 0x80C4E10
        public void TryGetInlineCursor(){} // RVA: 0x80C5020
        public void TryGetInlineTextShadow(){} // RVA: 0x80C5090
        public void TryGetInlineTransformOrigin(){} // RVA: 0x80C50B0
        public void TryGetInlineTranslate(){} // RVA: 0x80C50D0
        public void TryGetInlineRotate(){} // RVA: 0x80C5100
        public void TryGetInlineScale(){} // RVA: 0x80C5130
        public void TryGetInlineBackgroundSize(){} // RVA: 0x80C5160
        public void .cctor(){} // RVA: 0x80C5190
    }

    public class InlineStyleAccessPropertyBag : PropertyBag`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7E9A640
        public void AddProperty(){} // RVA: 0x30F4440
        public void GetProperties(){} // RVA: 0x7E9D330
        public void TryGetProperty(){} // RVA: 0x7E9D3A0
    }

    public class InputEvent : EventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x805E3D0
        public void set_previousData(){} // RVA: 0xBBFFA0
        public void set_newData(){} // RVA: 0xC10060
        public void Init(){} // RVA: 0x805E4C0
        public void LocalInit(){} // RVA: 0x805E570
        public void GetPooled(){} // RVA: 0x805E630
        public void .ctor(){} // RVA: 0x805E760
    }

    public class IntegerField : TextValueField`1
    {
        // ── Methods ──
        public void get_integerInput(){} // RVA: 0x7FF2200
        public void ValueToString(){} // RVA: 0x7FF2290
        public void StringToValue(){} // RVA: 0x7FF24A0
        public void .ctor(){} // RVA: 0x7FF2780
        public void CanTryParse(){} // RVA: 0x7FF2AA0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FF2B70
        public void .cctor(){} // RVA: 0x7FF2C60
    }

}