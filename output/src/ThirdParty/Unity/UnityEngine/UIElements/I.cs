// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 83
// Methods: 594

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class IBaseUxmlFactory
    {
        // ── Methods ──
        public void get_uxmlQualifiedName(){} // RVA: 0x7A7E00680
        public void get_uxmlType(){} // RVA: 0x7A7E00680
        public void AcceptsAttributeBag(){} // RVA: 0x7A7E01A40
    }

    public class IBindable
    {
        // ── Methods ──
        public void get_binding(){} // RVA: 0x7A7E00680
        public void set_bindingPath(){} // RVA: 0x7A7E18800
    }

    public class IBinding
    {
        // ── Methods ──
        public void PreUpdate(){} // RVA: 0x7A7E18770
        public void Update(){} // RVA: 0x7A7E18770
        public void Release(){} // RVA: 0x7A7E18770
    }

    public class IBindingRequest
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7A7E18800
    }

    public class ICursorManager
    {
        // ── Methods ──
        public void SetCursor(){} // RVA: 0x7A7E18800
        public void ResetCursor(){} // RVA: 0x7A7E18770
    }

    public class ICustomStyle
    {
        // ── Methods ──
        public void TryGetValue(){} // RVA: 0x7A7E01AD0
    }

    public class IDragAndDrop
    {
        // ── Methods ──
        public void StartDrag(){} // RVA: 0x7A7E18890
        public void UpdateDrag(){} // RVA: 0x7A7E18800
        public void AcceptDrag(){} // RVA: 0x7A7E18770
        public void DragCleanup(){} // RVA: 0x7A7E18770
        public void SetVisualMode(){} // RVA: 0x7A7E189D0
        public void get_data(){} // RVA: 0x7A7E00680
    }

    public class IDragAndDropController`1
    {
        // ── Methods ──
        public void CanStartDrag(){} // RVA: 0x7A7E019D0
        public void SetupDragAndDrop(){} // RVA: 0x7A7E00F20
        public void HandleDragAndDrop(){} // RVA: 0x7A8051B10
        public void OnDrop(){} // RVA: 0x7A8051B10
        public void DragCleanup(){} // RVA: 0x7A7E18770
        public void HandleAutoExpand(){} // RVA: 0x7A7E25F50
        public void GetSortedSelectedIds(){} // RVA: 0x7A7E00680
    }

    public class IEditableElement
    {
        // ── Methods ──
        public void get_editingStarted(){} // RVA: 0x7A7E00680
        public void get_editingEnded(){} // RVA: 0x7A7E00680
    }

    public class IEnumerableExtensions : Object
    {
        // ── Methods ──
        public void HasValues(){} // RVA: 0x7AF1E5C40
    }

    public class IEventDispatchingStrategy
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7A7E019D0
        public void DispatchEvent(){} // RVA: 0x7A7E18890
    }

    public class IEventHandler
    {
        // ── Methods ──
        public void SendEvent(){} // RVA: 0x7A7E18800
        public void HandleEvent(){} // RVA: 0x7A7E18800
    }

    public class IExperimentalFeatures
    {
        // ── Methods ──
        public void get_animation(){} // RVA: 0x7A7E00680
    }

    public class IFocusRing
    {
        // ── Methods ──
        public void GetFocusChangeDirection(){} // RVA: 0x7A7E00BD0
        public void GetNextFocusable(){} // RVA: 0x7A7E00BD0
    }

    public class IGenericMenu
    {
        // ── Methods ──
        public void AddItem(){} // RVA: 0x7A7E1EB40
        public void DropDown(){} // RVA: 0x7A7E1EE20
    }

    public class IGroupBox
    {
        // ── Methods ──
        public void OnOptionAdded(){} // RVA: 0x7A7E18800
        public void OnOptionRemoved(){} // RVA: 0x7A7E18800
    }

    public class IGroupBoxOption
    {
        // ── Methods ──
        public void SetSelected(){} // RVA: 0x7A7E18C30
    }

    public class IGroupManager
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7A7E18800
        public void OnOptionSelectionChanged(){} // RVA: 0x7A7E18800
        public void RegisterOption(){} // RVA: 0x7A7E18800
        public void UnregisterOption(){} // RVA: 0x7A7E18800
    }

    public class IKeyboardEvent
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A7E00710
        public void get_character(){} // RVA: 0x7A7E006E0
        public void get_keyCode(){} // RVA: 0x7A7E00710
    }

    public class IListDragAndDropArgs
    {
        // ── Methods ──
        public void get_insertAtIndex(){} // RVA: 0x7A7E00710
        public void get_parentId(){} // RVA: 0x7A7E00710
        public void get_childIndex(){} // RVA: 0x7A7E00710
        public void get_dragAndDropData(){} // RVA: 0x7A7E00680
        public void get_dragAndDropPosition(){} // RVA: 0x7A7E00710
    }

    public class IMGUIContainer : VisualElement
    {
        // ── Methods ──
        public void get_onGUIHandler(){} // RVA: 0x7AF1E62A0
        public void set_onGUIHandler(){} // RVA: 0x7AF1E62B0
        public void get_guiState(){} // RVA: 0x7AF1E63B0
        public void get_lastWorldClip(){} // RVA: 0x7AF1E64E0
        public void set_lastWorldClip(){} // RVA: 0x7AF1E64F0
        public void get_cullingEnabled(){} // RVA: 0x7AF1E6500
        public void get_cache(){} // RVA: 0x7AF1E6510
        public void get_layoutMeasuredWidth(){} // RVA: 0x7AF1E65D0
        public void get_layoutMeasuredHeight(){} // RVA: 0x7AF1E6600
        public void get_contextType(){} // RVA: 0x7AF1E6630
        public void set_contextType(){} // RVA: 0x7AF1E6640
        public void get_focusOnlyIfHasFocusableControls(){} // RVA: 0x7AF1E6650
        public void get_canGrabFocus(){} // RVA: 0x7AF1E6660
        public void .cctor(){} // RVA: 0x7AF1E6690
        public void .ctor(){} // RVA: 0x7AF1E6F30
        public void OnGenerateVisualContent(){} // RVA: 0x7AF1E73C0
        public void SaveGlobals(){} // RVA: 0x7AF1E7520
        public void RestoreGlobals(){} // RVA: 0x7AF1E7900
        public void DoOnGUI(){} // RVA: 0x7AF1E7D00
        public void MarkDirtyLayout(){} // RVA: 0x7AF1E9760
        public void ProcessEvent(){} // RVA: 0x7AF1E97A0
        public void DoIMGUIRepaint(){} // RVA: 0x7AF1E9950
        public void SendEventToIMGUI(){} // RVA: 0x7AF1E9CD0
        public void SendEventToIMGUIRaw(){} // RVA: 0x7AF1EA000
        public void VerifyBounds(){} // RVA: 0x7AF1EA0C0
        public void IsContainerCapturingTheMouse(){} // RVA: 0x7AF1EA300
        public void IsLocalEvent(){} // RVA: 0x7AF1EA3D0
        public void IsEventInsideLocalWindow(){} // RVA: 0x7AF1EA5F0
        public void IsDockAreaMouseUp(){} // RVA: 0x7AF1EA840
        public void HandleIMGUIEvent(){} // RVA: 0x7AF1EACE0
        public void ExecuteDefaultAction(){} // RVA: 0x7AF1EB250
        public void SetFoldoutDepthClass(){} // RVA: 0x7AF1EB5C0
        public void DoMeasure(){} // RVA: 0x7AF1EB780
        public void GetCurrentClipRect(){} // RVA: 0x7AF1EBC20
        public void GetCurrentTransformAndClip(){} // RVA: 0x7AF1EBCA0
        public void Dispose(){} // RVA: 0x7AF1EBF90
        public void <DoOnGUI>b__56_0(){} // RVA: 0x7AF1EC010
    }

    public class IMGUIContainer[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IMGUIEvent : EventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1DA4A0
        public void GetPooled(){} // RVA: 0x7AF1DA590
        public void Init(){} // RVA: 0x7AF1DA620
        public void LocalInit(){} // RVA: 0x7AF1CF180
        public void .ctor(){} // RVA: 0x7AF1DA6E0
    }

    public class IMGUIEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7AF1CB5A0
        public void DispatchEvent(){} // RVA: 0x7AF1CB620
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class IManipulator
    {
        // ── Methods ──
        public void set_target(){} // RVA: 0x7A7E18800
    }

    public class IMouseEvent
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7A7E00710
        public void get_mousePosition(){} // RVA: 0x7A7E00680
        public void get_localMousePosition(){} // RVA: 0x7A7E00680
        public void get_mouseDelta(){} // RVA: 0x7A7E00680
        public void get_clickCount(){} // RVA: 0x7A7E00710
        public void get_button(){} // RVA: 0x7A7E00710
        public void get_pressedButtons(){} // RVA: 0x7A7E00710
        public void get_shiftKey(){} // RVA: 0x7A7E01900
        public void get_ctrlKey(){} // RVA: 0x7A7E01900
        public void get_commandKey(){} // RVA: 0x7A7E01900
        public void get_altKey(){} // RVA: 0x7A7E01900
    }

    public class IMouseEventInternal
    {
        // ── Methods ──
        public void get_triggeredByOS(){} // RVA: 0x7A7E01900
        public void set_triggeredByOS(){} // RVA: 0x7A7E18C30
        public void get_recomputeTopElementUnderMouse(){} // RVA: 0x7A7E01900
        public void set_recomputeTopElementUnderMouse(){} // RVA: 0x7A7E18C30
        public void get_sourcePointerEvent(){} // RVA: 0x7A7E00680
        public void set_sourcePointerEvent(){} // RVA: 0x7A7E18800
    }

    public class IMouseEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class INavigationEvent
    {
        // ── Methods ──
        public void get_shiftKey(){} // RVA: 0x7A7E01900
        public void get_altKey(){} // RVA: 0x7A7E01900
    }

    public class INotifyValueChangedExtensions : Object
    {
        // ── Methods ──
        public void RegisterValueChangedCallback(){} // RVA: 0x7AA4BE100
        public void UnregisterValueChangedCallback(){} // RVA: 0x7A7E01F80
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A8051B10
        public void set_value(){} // RVA: 0x7A8051B10
        public void SetValueWithoutNotify(){} // RVA: 0x7A8051B10
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x7A7E19E10
        public void get_value(){} // RVA: 0x7A7E06760
        public void set_value(){} // RVA: 0x7A7E19E10
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x7A7E262C0
        public void get_value(){} // RVA: 0x7A7E155B0
        public void set_value(){} // RVA: 0x7A7E262C0
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x7A7E18800
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x7A7E18800
        public void get_value(){} // RVA: 0x7A7E00680
        public void set_value(){} // RVA: 0x7A7E18800
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x7A7E189D0
        public void get_value(){} // RVA: 0x7A7E00710
        public void set_value(){} // RVA: 0x7A7E189D0
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x7A7E188D0
        public void get_value(){} // RVA: 0x7A7E00680
        public void set_value(){} // RVA: 0x7A7E188D0
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x7A7E18C30
        public void get_value(){} // RVA: 0x7A7E01900
        public void set_value(){} // RVA: 0x7A7E18C30
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x7A7E189D0
        public void get_value(){} // RVA: 0x7A7E00710
        public void set_value(){} // RVA: 0x7A7E189D0
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void SetValueWithoutNotify(){} // RVA: 0x7A7E188D0
        public void get_value(){} // RVA: 0x7A7E00680
        public void set_value(){} // RVA: 0x7A7E188D0
    }

    public class IPanel
    {
        // ── Methods ──
        public void get_visualTree(){} // RVA: 0x7A7E00680
        public void get_dispatcher(){} // RVA: 0x7A7E00680
        public void get_contextType(){} // RVA: 0x7A7E00710
        public void get_focusController(){} // RVA: 0x7A7E00680
        public void Pick(){} // RVA: 0x7A7E150A0
    }

    public class IPointerCaptureEventInternal
    {
        // ── Methods ──
        public void get_pointerId(){} // RVA: 0x7A7E00710
    }

    public class IPointerEvent
    {
        // ── Methods ──
        public void get_pointerId(){} // RVA: 0x7A7E00710
        public void get_pointerType(){} // RVA: 0x7A7E00680
        public void get_isPrimary(){} // RVA: 0x7A7E01900
        public void get_button(){} // RVA: 0x7A7E00710
        public void get_pressedButtons(){} // RVA: 0x7A7E00710
        public void get_position(){} // RVA: 0x7A7E00490
        public void get_localPosition(){} // RVA: 0x7A7E00490
        public void get_deltaPosition(){} // RVA: 0x7A7E00490
        public void get_deltaTime(){} // RVA: 0x7A7E155B0
        public void get_clickCount(){} // RVA: 0x7A7E00710
        public void get_pressure(){} // RVA: 0x7A7E155B0
        public void get_tangentialPressure(){} // RVA: 0x7A7E155B0
        public void get_altitudeAngle(){} // RVA: 0x7A7E155B0
        public void get_azimuthAngle(){} // RVA: 0x7A7E155B0
        public void get_twist(){} // RVA: 0x7A7E155B0
        public void get_tilt(){} // RVA: 0x7A7E00680
        public void get_penStatus(){} // RVA: 0x7A7E00710
        public void get_radius(){} // RVA: 0x7A7E00680
        public void get_radiusVariance(){} // RVA: 0x7A7E00680
        public void get_modifiers(){} // RVA: 0x7A7E00710
        public void get_shiftKey(){} // RVA: 0x7A7E01900
        public void get_ctrlKey(){} // RVA: 0x7A7E01900
        public void get_commandKey(){} // RVA: 0x7A7E01900
        public void get_altKey(){} // RVA: 0x7A7E01900
        public void get_actionKey(){} // RVA: 0x7A7E01900
    }

    public class IPointerEventInternal
    {
        // ── Methods ──
        public void get_triggeredByOS(){} // RVA: 0x7A7E01900
        public void set_triggeredByOS(){} // RVA: 0x7A7E18C30
        public void get_recomputeTopElementUnderPointer(){} // RVA: 0x7A7E01900
        public void set_recomputeTopElementUnderPointer(){} // RVA: 0x7A7E18C30
    }

    public class IPointerEvent[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IReorderable
    {
        // ── Methods ──
        public void get_enableReordering(){} // RVA: 0x7A7E01900
        public void set_enableReordering(){} // RVA: 0x7A7E18C30
    }

    public class IResolvedStyle
    {
        // ── Methods ──
        public void get_backgroundColor(){} // RVA: 0x7A7E00490
        public void get_borderBottomColor(){} // RVA: 0x7A7E00490
        public void get_borderBottomLeftRadius(){} // RVA: 0x7A7E155B0
        public void get_borderBottomRightRadius(){} // RVA: 0x7A7E155B0
        public void get_borderBottomWidth(){} // RVA: 0x7A7E155B0
        public void get_borderLeftColor(){} // RVA: 0x7A7E00490
        public void get_borderLeftWidth(){} // RVA: 0x7A7E155B0
        public void get_borderRightColor(){} // RVA: 0x7A7E00490
        public void get_borderRightWidth(){} // RVA: 0x7A7E155B0
        public void get_borderTopColor(){} // RVA: 0x7A7E00490
        public void get_borderTopLeftRadius(){} // RVA: 0x7A7E155B0
        public void get_borderTopRightRadius(){} // RVA: 0x7A7E155B0
        public void get_borderTopWidth(){} // RVA: 0x7A7E155B0
        public void get_bottom(){} // RVA: 0x7A7E155B0
        public void get_color(){} // RVA: 0x7A7E00490
        public void get_display(){} // RVA: 0x7A7E00710
        public void get_flexDirection(){} // RVA: 0x7A7E00710
        public void get_flexGrow(){} // RVA: 0x7A7E155B0
        public void get_flexShrink(){} // RVA: 0x7A7E155B0
        public void get_height(){} // RVA: 0x7A7E155B0
        public void get_left(){} // RVA: 0x7A7E155B0
        public void get_marginBottom(){} // RVA: 0x7A7E155B0
        public void get_marginLeft(){} // RVA: 0x7A7E155B0
        public void get_marginRight(){} // RVA: 0x7A7E155B0
        public void get_marginTop(){} // RVA: 0x7A7E155B0
        public void get_minHeight(){} // RVA: 0x7A7E00680
        public void get_minWidth(){} // RVA: 0x7A7E00680
        public void get_opacity(){} // RVA: 0x7A7E155B0
        public void get_paddingBottom(){} // RVA: 0x7A7E155B0
        public void get_paddingLeft(){} // RVA: 0x7A7E155B0
        public void get_paddingRight(){} // RVA: 0x7A7E155B0
        public void get_paddingTop(){} // RVA: 0x7A7E155B0
        public void get_right(){} // RVA: 0x7A7E155B0
        public void get_scale(){} // RVA: 0x7A7E00490
        public void get_top(){} // RVA: 0x7A7E155B0
        public void get_transformOrigin(){} // RVA: 0x7A7E00490
        public void get_translate(){} // RVA: 0x7A7E00490
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x7A7E00490
        public void get_unitySliceLeft(){} // RVA: 0x7A7E00710
        public void get_unitySliceRight(){} // RVA: 0x7A7E00710
        public void get_unitySliceScale(){} // RVA: 0x7A7E155B0
        public void get_unityTextOutlineColor(){} // RVA: 0x7A7E00490
        public void get_unityTextOutlineWidth(){} // RVA: 0x7A7E155B0
        public void get_visibility(){} // RVA: 0x7A7E00710
        public void get_width(){} // RVA: 0x7A7E155B0
    }

    public class IRuntimePanelComponent
    {
        // ── Methods ──
        public void set_panel(){} // RVA: 0x7A7E18800
    }

    public class IScheduler
    {
        // ── Methods ──
        public void Unschedule(){} // RVA: 0x7A7E18800
        public void Schedule(){} // RVA: 0x7A7E18800
        public void UpdateScheduledEvents(){} // RVA: 0x7A7E18770
    }

    public class ISerializableJsonDictionary
    {
        // ── Methods ──
        public void Set(){} // RVA: 0x7A8051B10
        public void Get(){} // RVA: 0x7A8051B10
        public void Overwrite(){} // RVA: 0x7A7E18890
        public void ContainsKey(){} // RVA: 0x7A7E019D0
    }

    public class IStyle
    {
        // ── Methods ──
        public void set_backgroundColor(){} // RVA: 0x7A7E18800
        public void get_backgroundSize(){} // RVA: 0x7A7E00490
        public void set_borderBottomColor(){} // RVA: 0x7A7E18800
        public void set_borderBottomLeftRadius(){} // RVA: 0x7A7E18800
        public void set_borderBottomRightRadius(){} // RVA: 0x7A7E18800
        public void set_borderBottomWidth(){} // RVA: 0x7A7E188D0
        public void set_borderLeftColor(){} // RVA: 0x7A7E18800
        public void set_borderLeftWidth(){} // RVA: 0x7A7E188D0
        public void set_borderRightColor(){} // RVA: 0x7A7E18800
        public void set_borderRightWidth(){} // RVA: 0x7A7E188D0
        public void set_borderTopColor(){} // RVA: 0x7A7E18800
        public void set_borderTopLeftRadius(){} // RVA: 0x7A7E18800
        public void set_borderTopRightRadius(){} // RVA: 0x7A7E18800
        public void set_borderTopWidth(){} // RVA: 0x7A7E188D0
        public void set_bottom(){} // RVA: 0x7A7E18800
        public void set_color(){} // RVA: 0x7A7E18800
        public void get_cursor(){} // RVA: 0x7A7E00490
        public void get_display(){} // RVA: 0x7A7E00680
        public void set_display(){} // RVA: 0x7A7E188D0
        public void set_flexBasis(){} // RVA: 0x7A7E18800
        public void set_flexDirection(){} // RVA: 0x7A7E188D0
        public void set_flexGrow(){} // RVA: 0x7A7E188D0
        public void set_flexShrink(){} // RVA: 0x7A7E188D0
        public void set_fontSize(){} // RVA: 0x7A7E18800
        public void set_height(){} // RVA: 0x7A7E18800
        public void set_left(){} // RVA: 0x7A7E18800
        public void set_marginBottom(){} // RVA: 0x7A7E18800
        public void set_marginLeft(){} // RVA: 0x7A7E18800
        public void set_marginRight(){} // RVA: 0x7A7E18800
        public void set_marginTop(){} // RVA: 0x7A7E18800
        public void set_maxHeight(){} // RVA: 0x7A7E18800
        public void set_maxWidth(){} // RVA: 0x7A7E18800
        public void set_minWidth(){} // RVA: 0x7A7E18800
        public void set_opacity(){} // RVA: 0x7A7E188D0
        public void set_overflow(){} // RVA: 0x7A7E188D0
        public void set_paddingBottom(){} // RVA: 0x7A7E18800
        public void set_paddingLeft(){} // RVA: 0x7A7E18800
        public void set_paddingRight(){} // RVA: 0x7A7E18800
        public void get_paddingTop(){} // RVA: 0x7A7E00490
        public void set_paddingTop(){} // RVA: 0x7A7E18800
        public void set_position(){} // RVA: 0x7A7E188D0
        public void set_right(){} // RVA: 0x7A7E18800
        public void get_rotate(){} // RVA: 0x7A7E00490
        public void get_scale(){} // RVA: 0x7A7E00490
        public void get_textShadow(){} // RVA: 0x7A7E00490
        public void set_top(){} // RVA: 0x7A7E18800
        public void get_transformOrigin(){} // RVA: 0x7A7E00490
        public void get_translate(){} // RVA: 0x7A7E00490
        public void set_translate(){} // RVA: 0x7A7E18800
        public void set_unityBackgroundImageTintColor(){} // RVA: 0x7A7E18800
        public void set_unityFont(){} // RVA: 0x7A7E18800
        public void set_unityFontDefinition(){} // RVA: 0x7A7E18800
        public void set_visibility(){} // RVA: 0x7A7E188D0
        public void get_width(){} // RVA: 0x7A7E00490
        public void set_width(){} // RVA: 0x7A7E18800
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7A8051B10
        public void CopyFrom(){} // RVA: 0x7A7E18800
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x7A7E18800
        public void Copy(){} // RVA: 0x7A80804D0
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x7A7E18800
        public void Copy(){} // RVA: 0x7A80804D0
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x7A7E18800
        public void Copy(){} // RVA: 0x7A80804D0
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x7A7E18800
        public void Copy(){} // RVA: 0x7A80804D0
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x7A7E18800
        public void Copy(){} // RVA: 0x7A80804D0
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x7A7E18800
        public void Copy(){} // RVA: 0x7A80804D0
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void CopyFrom(){} // RVA: 0x7A7E18800
        public void Copy(){} // RVA: 0x7A80804D0
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7A80804D0
        public void CopyFrom(){} // RVA: 0x7A7E18800
    }

    public class IStylePainter
    {
        // ── Methods ──
        public void DrawText(){} // RVA: 0x7A7E18800
        public void DrawRectangle(){} // RVA: 0x7A7E18800
        public void DrawImmediate(){} // RVA: 0x7A7E1D550
    }

    public class IStylePropertyAnimationSystem
    {
        // ── Methods ──
        public void StartTransition(){} // RVA: 0x7A7E045D0
        public void CancelAllAnimations(){} // RVA: 0x7A7E18800
        public void CancelAnimation(){} // RVA: 0x7A7E1D590
        public void UpdateAnimation(){} // RVA: 0x7A7E1D590
        public void GetAllAnimations(){} // RVA: 0x7A7E18890
        public void Update(){} // RVA: 0x7A7E18770
    }

    public class IStylePropertyAnimations
    {
        // ── Methods ──
        public void Start(){} // RVA: 0x7A7E02830
        public void StartEnum(){} // RVA: 0x7A7E02CB0
        public void UpdateAnimation(){} // RVA: 0x7A7E189D0
        public void GetAllAnimations(){} // RVA: 0x7A7E18800
        public void CancelAnimation(){} // RVA: 0x7A7E189D0
        public void CancelAllAnimations(){} // RVA: 0x7A7E18770
        public void get_runningAnimationCount(){} // RVA: 0x7A7E00710
        public void set_runningAnimationCount(){} // RVA: 0x7A7E189D0
        public void get_completedAnimationCount(){} // RVA: 0x7A7E00710
        public void set_completedAnimationCount(){} // RVA: 0x7A7E189D0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A8051B10
        public void get_keyword(){} // RVA: 0x7A7E00710
    }

    public class ITextEdition
    {
        // ── Methods ──
        public void get_multiline(){} // RVA: 0x7A7E01900
        public void set_multiline(){} // RVA: 0x7A7E18C30
        public void get_isReadOnly(){} // RVA: 0x7A7E01900
        public void set_isReadOnly(){} // RVA: 0x7A7E18C30
        public void get_maxLength(){} // RVA: 0x7A7E00710
        public void set_maxLength(){} // RVA: 0x7A7E189D0
        public void get_isDelayed(){} // RVA: 0x7A7E01900
        public void set_isDelayed(){} // RVA: 0x7A7E18C30
        public void SaveValueAndText(){} // RVA: 0x7A7E18770
        public void RestoreValueAndText(){} // RVA: 0x7A7E18770
        public void get_AcceptCharacter(){} // RVA: 0x7A7E00680
        public void set_AcceptCharacter(){} // RVA: 0x7A7E18800
        public void get_UpdateScrollOffset(){} // RVA: 0x7A7E00680
        public void set_UpdateScrollOffset(){} // RVA: 0x7A7E18800
        public void get_UpdateValueFromText(){} // RVA: 0x7A7E00680
        public void set_UpdateValueFromText(){} // RVA: 0x7A7E18800
        public void get_UpdateTextFromValue(){} // RVA: 0x7A7E00680
        public void set_UpdateTextFromValue(){} // RVA: 0x7A7E18800
        public void get_MoveFocusToCompositeRoot(){} // RVA: 0x7A7E00680
        public void set_MoveFocusToCompositeRoot(){} // RVA: 0x7A7E18800
        public void UpdateText(){} // RVA: 0x7A7E18800
        public void CullString(){} // RVA: 0x7A7E00B20
        public void set_maskChar(){} // RVA: 0x7A7E18950
        public void get_isPassword(){} // RVA: 0x7A7E01900
        public void set_isPassword(){} // RVA: 0x7A7E18C30
        public void get_autoCorrection(){} // RVA: 0x7AF2635E0
        public void set_autoCorrection(){} // RVA: 0x7AF2636A0
        public void get_hideMobileInput(){} // RVA: 0x7AF263760
        public void set_hideMobileInput(){} // RVA: 0x7AF263820
        public void get_keyboardType(){} // RVA: 0x7AF2638E0
        public void set_keyboardType(){} // RVA: 0x7AF2639A0
    }

    public class ITextSelection
    {
        // ── Methods ──
        public void get_isSelectable(){} // RVA: 0x7A7E01900
        public void set_isSelectable(){} // RVA: 0x7A7E18C30
        public void get_cursorColor(){} // RVA: 0x7A7E00490
        public void set_cursorColor(){} // RVA: 0x7A7E18800
        public void get_cursorIndex(){} // RVA: 0x7A7E00710
        public void set_cursorIndex(){} // RVA: 0x7A7E189D0
        public void get_doubleClickSelectsWord(){} // RVA: 0x7A7E01900
        public void get_selectIndex(){} // RVA: 0x7A7E00710
        public void set_selectIndex(){} // RVA: 0x7A7E189D0
        public void get_selectionColor(){} // RVA: 0x7A7E00490
        public void set_selectionColor(){} // RVA: 0x7A7E18800
        public void get_tripleClickSelectsLine(){} // RVA: 0x7A7E01900
        public void HasSelection(){} // RVA: 0x7A7E01900
        public void SelectAll(){} // RVA: 0x7A7E18770
        public void SelectNone(){} // RVA: 0x7A7E18770
        public void get_selectAllOnFocus(){} // RVA: 0x7A7E01900
        public void set_selectAllOnFocus(){} // RVA: 0x7A7E18C30
        public void get_selectAllOnMouseUp(){} // RVA: 0x7A7E01900
        public void set_selectAllOnMouseUp(){} // RVA: 0x7A7E18C30
        public void get_cursorPosition(){} // RVA: 0x7A7E00680
        public void get_lineHeightAtCursorPosition(){} // RVA: 0x7A7E155B0
        public void get_cursorWidth(){} // RVA: 0x7A7E155B0
    }

    public class ITransform
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x7A7E00490
        public void set_position(){} // RVA: 0x7A7E18800
        public void get_scale(){} // RVA: 0x7A7E00490
    }

    public class IUIElementsUtility
    {
        // ── Methods ──
        public void TakeCapture(){} // RVA: 0x7A7E01900
        public void ReleaseCapture(){} // RVA: 0x7A7E01900
        public void ProcessEvent(){} // RVA: 0x7A7E02E30
        public void CleanupRoots(){} // RVA: 0x7A7E01900
        public void EndContainerGUIFromException(){} // RVA: 0x7A7E019D0
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7A7E01900
    }

    public class IUIElementsUtility[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IUxmlAttributes
    {
        // ── Methods ──
        public void TryGetAttributeValue(){} // RVA: 0x7A7E01A40
    }

    public class IUxmlFactory
    {
        // ── Methods ──
        public void Create(){} // RVA: 0x7A7E00BD0
    }

    public class IUxmlObjectFactory`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7A8051B10
    }

    public class IValueField`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7A8051B10
        public void set_value(){} // RVA: 0x7A8051B10
        public void ApplyInputDeviceDelta(){} // RVA: 0x7A8051B10
        public void StartDragging(){} // RVA: 0x7A7E18770
        public void StopDragging(){} // RVA: 0x7A7E18770
    }

    public class IVisualElementPanelActivatable
    {
        // ── Methods ──
        public void get_element(){} // RVA: 0x7A7E00680
        public void CanBeActivated(){} // RVA: 0x7A7E01900
        public void OnPanelActivate(){} // RVA: 0x7A7E18770
        public void OnPanelDeactivate(){} // RVA: 0x7A7E18770
    }

    public class IVisualElementScheduledItem
    {
        // ── Methods ──
        public void Resume(){} // RVA: 0x7A7E18770
        public void Pause(){} // RVA: 0x7A7E18770
        public void ExecuteLater(){} // RVA: 0x7A7E188D0
        public void StartingIn(){} // RVA: 0x7A7E063E0
        public void Every(){} // RVA: 0x7A7E063E0
    }

    public class IVisualElementScheduler
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7A7E00B20
    }

    public class IVisualTreeUpdater
    {
        // ── Methods ──
        public void set_panel(){} // RVA: 0x7A7E18800
        public void get_profilerMarker(){} // RVA: 0x7A7E00680
        public void Update(){} // RVA: 0x7A7E18770
        public void OnVersionChanged(){} // RVA: 0x7A7E1D590
    }

    public class Image : VisualElement
    {
        // ── Methods ──
        public void get_image(){} // RVA: 0x7A8B52950
        public void set_image(){} // RVA: 0x7AF100FF0
        public void get_sprite(){} // RVA: 0x7A8B64520
        public void set_sprite(){} // RVA: 0x7AF101200
        public void get_vectorImage(){} // RVA: 0x7A8B5C760
        public void set_vectorImage(){} // RVA: 0x7AF101410
        public void get_sourceRect(){} // RVA: 0x7AF101620
        public void get_uv(){} // RVA: 0x7AF101650
        public void set_uv(){} // RVA: 0x7AF101660
        public void get_scaleMode(){} // RVA: 0x7AF1016C0
        public void get_tintColor(){} // RVA: 0x7AF1016D0
        public void .ctor(){} // RVA: 0x7AF1016E0
        public void GetTextureDisplaySize(){} // RVA: 0x7AF101A80
        public void DoMeasure(){} // RVA: 0x7AF101CC0
        public void OnGenerateVisualContent(){} // RVA: 0x7AF102170
        public void OnCustomStyleResolved(){} // RVA: 0x7AF102980
        public void ReadCustomProperties(){} // RVA: 0x7AF1029C0
        public void SetProperty(){} // RVA: 0x7A8051B10
        public void ClearProperty(){} // RVA: 0x7AF103020
        public void SetScaleMode(){} // RVA: 0x7AF103070
        public void SetTintColor(){} // RVA: 0x7AF1030C0
        public void GetSourceRect(){} // RVA: 0x7AF103180
        public void .cctor(){} // RVA: 0x7AF103440
    }

    public class ImmediateModeException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF1EC100
    }

    public class InheritedData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7A79FDE30
        public void CopyFrom(){} // RVA: 0x7A7F07340
        public void op_Equality(){} // RVA: 0x7AF23D470
        public void Equals(){} // RVA: 0x7A7F073C0
        public void GetHashCode(){} // RVA: 0x7A7F074D0
    }

    public class InlineStyleAccess : StyleValueCollection
    {
        // ── Methods ──
        public void UnityEngine.UIElements.IStyle.set_backgroundColor(){} // RVA: 0x7AF220C20
        public void UnityEngine.UIElements.IStyle.set_borderBottomColor(){} // RVA: 0x7AF220C90
        public void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(){} // RVA: 0x7AF220D00
        public void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(){} // RVA: 0x7AF220D70
        public void UnityEngine.UIElements.IStyle.set_borderBottomWidth(){} // RVA: 0x7AF220DE0
        public void UnityEngine.UIElements.IStyle.set_borderLeftColor(){} // RVA: 0x7AF220EA0
        public void UnityEngine.UIElements.IStyle.set_borderLeftWidth(){} // RVA: 0x7AF220F10
        public void UnityEngine.UIElements.IStyle.set_borderRightColor(){} // RVA: 0x7AF220FD0
        public void UnityEngine.UIElements.IStyle.set_borderRightWidth(){} // RVA: 0x7AF221040
        public void UnityEngine.UIElements.IStyle.set_borderTopColor(){} // RVA: 0x7AF221100
        public void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(){} // RVA: 0x7AF221170
        public void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(){} // RVA: 0x7AF2211E0
        public void UnityEngine.UIElements.IStyle.set_borderTopWidth(){} // RVA: 0x7AF221250
        public void UnityEngine.UIElements.IStyle.set_bottom(){} // RVA: 0x7AF221310
        public void UnityEngine.UIElements.IStyle.set_color(){} // RVA: 0x7AF2213F0
        public void UnityEngine.UIElements.IStyle.get_display(){} // RVA: 0x7AF221460
        public void UnityEngine.UIElements.IStyle.set_display(){} // RVA: 0x7AF221520
        public void UnityEngine.UIElements.IStyle.set_flexBasis(){} // RVA: 0x7AF221650
        public void UnityEngine.UIElements.IStyle.set_flexDirection(){} // RVA: 0x7AF221730
        public void UnityEngine.UIElements.IStyle.set_flexGrow(){} // RVA: 0x7AF221860
        public void UnityEngine.UIElements.IStyle.set_flexShrink(){} // RVA: 0x7AF221920
        public void UnityEngine.UIElements.IStyle.set_fontSize(){} // RVA: 0x7AF2219E0
        public void UnityEngine.UIElements.IStyle.set_height(){} // RVA: 0x7AF221A50
        public void UnityEngine.UIElements.IStyle.set_left(){} // RVA: 0x7AF221B30
        public void UnityEngine.UIElements.IStyle.set_marginBottom(){} // RVA: 0x7AF221C10
        public void UnityEngine.UIElements.IStyle.set_marginLeft(){} // RVA: 0x7AF221CF0
        public void UnityEngine.UIElements.IStyle.set_marginRight(){} // RVA: 0x7AF221DD0
        public void UnityEngine.UIElements.IStyle.set_marginTop(){} // RVA: 0x7AF221EB0
        public void UnityEngine.UIElements.IStyle.set_maxHeight(){} // RVA: 0x7AF221FA0
        public void UnityEngine.UIElements.IStyle.set_maxWidth(){} // RVA: 0x7AF222080
        public void UnityEngine.UIElements.IStyle.set_minWidth(){} // RVA: 0x7AF222160
        public void UnityEngine.UIElements.IStyle.set_opacity(){} // RVA: 0x7AF222240
        public void UnityEngine.UIElements.IStyle.set_overflow(){} // RVA: 0x7AF2222A0
        public void UnityEngine.UIElements.IStyle.set_paddingBottom(){} // RVA: 0x7AF222420
        public void UnityEngine.UIElements.IStyle.set_paddingLeft(){} // RVA: 0x7AF222510
        public void UnityEngine.UIElements.IStyle.set_paddingRight(){} // RVA: 0x7AF2225F0
        public void UnityEngine.UIElements.IStyle.get_paddingTop(){} // RVA: 0x7AF2226E0
        public void UnityEngine.UIElements.IStyle.set_paddingTop(){} // RVA: 0x7AF222780
        public void UnityEngine.UIElements.IStyle.set_position(){} // RVA: 0x7AF222870
        public void UnityEngine.UIElements.IStyle.set_right(){} // RVA: 0x7AF2229A0
        public void UnityEngine.UIElements.IStyle.set_top(){} // RVA: 0x7AF222A90
        public void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(){} // RVA: 0x7AF222B80
        public void UnityEngine.UIElements.IStyle.set_unityFont(){} // RVA: 0x7AF222BF0
        public void UnityEngine.UIElements.IStyle.set_unityFontDefinition(){} // RVA: 0x7AF222C60
        public void UnityEngine.UIElements.IStyle.set_visibility(){} // RVA: 0x7AF222CE0
        public void UnityEngine.UIElements.IStyle.get_width(){} // RVA: 0x7AF222D70
        public void UnityEngine.UIElements.IStyle.set_width(){} // RVA: 0x7AF222E10
        public void get_ve(){} // RVA: 0x7A81052C0
        public void set_ve(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7AF222EF0
        public void Finalize(){} // RVA: 0x7AF222F60
        public void SetInlineRule(){} // RVA: 0x7AF2230A0
        public void IsValueSet(){} // RVA: 0x7AF2232F0
        public void ApplyInlineStyles(){} // RVA: 0x7AF2236D0
        public void UnityEngine.UIElements.IStyle.get_cursor(){} // RVA: 0x7AF224700
        public void UnityEngine.UIElements.IStyle.get_textShadow(){} // RVA: 0x7AF224840
        public void UnityEngine.UIElements.IStyle.get_backgroundSize(){} // RVA: 0x7AF2248B0
        public void UnityEngine.UIElements.IStyle.get_transformOrigin(){} // RVA: 0x7AF224910
        public void UnityEngine.UIElements.IStyle.get_translate(){} // RVA: 0x7AF224960
        public void UnityEngine.UIElements.IStyle.set_translate(){} // RVA: 0x7AF2249C0
        public void UnityEngine.UIElements.IStyle.get_rotate(){} // RVA: 0x7AF224C30
        public void UnityEngine.UIElements.IStyle.get_scale(){} // RVA: 0x7AF224C90
        public void SetStyleValue(){} // RVA: 0x7AF225680
        public void SetInlineTranslate(){} // RVA: 0x7AF225980
        public void ApplyStyleTranslate(){} // RVA: 0x7AF225B40
        public void ApplyStyleValue(){} // RVA: 0x7AF225F50
        public void RemoveInlineStyle(){} // RVA: 0x7AF226270
        public void ApplyFromComputedStyle(){} // RVA: 0x7AF2263C0
        public void TryGetInlineCursor(){} // RVA: 0x7AF2265D0
        public void TryGetInlineTextShadow(){} // RVA: 0x7AF226640
        public void TryGetInlineTransformOrigin(){} // RVA: 0x7AF226660
        public void TryGetInlineTranslate(){} // RVA: 0x7AF226680
        public void TryGetInlineRotate(){} // RVA: 0x7AF2266B0
        public void TryGetInlineScale(){} // RVA: 0x7AF2266E0
        public void TryGetInlineBackgroundSize(){} // RVA: 0x7AF226710
        public void .cctor(){} // RVA: 0x7AF226740
    }

    public class InputEvent : EventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1CB6A0
        public void set_previousData(){} // RVA: 0x7A825E460
        public void set_newData(){} // RVA: 0x7A8919DE0
        public void Init(){} // RVA: 0x7AF1CB790
        public void LocalInit(){} // RVA: 0x7AF1CB850
        public void GetPooled(){} // RVA: 0x7AF1CB910
        public void .ctor(){} // RVA: 0x7AF1CBA40
    }

    public class IntegerField : TextValueField`1
    {
        // ── Methods ──
        public void get_integerInput(){} // RVA: 0x7AF184E40
        public void ValueToString(){} // RVA: 0x7AF184ED0
        public void StringToValue(){} // RVA: 0x7AF1850E0
        public void .ctor(){} // RVA: 0x7AF185230
        public void CanTryParse(){} // RVA: 0x7AF185530
        public void ApplyInputDeviceDelta(){} // RVA: 0x7AF185600
        public void .cctor(){} // RVA: 0x7AF1856F0
    }

}