// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 66
// Methods: 542

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class IBaseUxmlFactory
    {
        // ── Methods ──
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFE80E2E2E0
        public void get_uxmlType(){} // RVA: 0x7FFE80E2E2E0
        public void AcceptsAttributeBag(){}
    }

    public class IBaseUxmlObjectFactory
    {
    }

    public class IBindable
    {
        // ── Methods ──
        public void get_binding(){} // RVA: 0x7FFE80E2E2E0
        public void set_bindingPath(){} // RVA: 0x7FFE80E460A0
    }

    public class IBinding
    {
        // ── Methods ──
        public void PreUpdate(){} // RVA: 0x7FFE80E45FE0
        public void Update(){} // RVA: 0x7FFE80E45FE0
        public void Release(){} // RVA: 0x7FFE80E45FE0
    }

    public class IBindingRequest
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFE80E460A0
    }

    public class ICollectionDragAndDropController
    {
    }

    public class ICommandEvent
    {
    }

    public class ICursorManager
    {
        // ── Methods ──
        public void SetCursor(){}
        public void ResetCursor(){} // RVA: 0x7FFE80E45FE0
    }

    public class ICustomStyle
    {
        // ── Methods ──
        public void TryGetValue(){} // overloaded x7
    }

    public class IDragAndDrop
    {
        // ── Methods ──
        public void StartDrag(){}
        public void UpdateDrag(){} // RVA: 0x7FFE80E460A0
        public void AcceptDrag(){} // RVA: 0x7FFE80E45FE0
        public void DragCleanup(){} // RVA: 0x7FFE80E45FE0
        public void SetVisualMode(){} // RVA: 0x7FFE80E46530
        public void get_data(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IDragAndDropController`1
    {
        // ── Methods ──
        public void CanStartDrag(){} // RVA: 0x7FFE80E2F3B0
        public void SetupDragAndDrop(){}
        public void HandleDragAndDrop(){} // RVA: 0x7FFE810A1420
        public void OnDrop(){} // RVA: 0x7FFE810A1420
        public void DragCleanup(){} // RVA: 0x7FFE80E45FE0
        public void HandleAutoExpand(){}
        public void GetSortedSelectedIds(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IEditableElement
    {
        // ── Methods ──
        public void get_editingStarted(){} // RVA: 0x7FFE80E2E2E0
        public void get_editingEnded(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IEnumerableExtensions : Object
    {
        // ── Methods ──
        public void HasValues(){} // RVA: 0x7FFE87F46CB0
    }

    public class IEventDispatchingStrategy
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFE80E2F3B0
        public void DispatchEvent(){} // RVA: 0x7FFE80E4F230
    }

    public class IEventHandler
    {
        // ── Methods ──
        public void SendEvent(){} // RVA: 0x7FFE80E460A0
        public void HandleEvent(){} // RVA: 0x7FFE80E460A0
    }

    public class IExperimentalFeatures
    {
        // ── Methods ──
        public void get_animation(){} // RVA: 0x7FFE80E2E2E0
    }

    public class IFocusRing
    {
        // ── Methods ──
        public void GetFocusChangeDirection(){} // RVA: 0x7FFE80E3FC10
        public void GetNextFocusable(){} // RVA: 0x7FFE80E3FC10
    }

    public class IGenericMenu
    {
        // ── Methods ──
        public void AddItem(){} // RVA: 0x7FFE80E4C2D0 | overloaded x2
        public void DropDown(){}
    }

    public class IGroupBox
    {
        // ── Methods ──
        public void OnOptionAdded(){} // RVA: 0x7FFE80E460A0
        public void OnOptionRemoved(){} // RVA: 0x7FFE80E460A0
    }

    public class IGroupBoxOption
    {
        // ── Methods ──
        public void SetSelected(){} // RVA: 0x7FFE80E466C0
    }

    public class IGroupBox`1
    {
    }

    public class IGroupManager
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFE80E460A0
        public void OnOptionSelectionChanged(){} // RVA: 0x7FFE80E460A0
        public void RegisterOption(){} // RVA: 0x7FFE80E460A0
        public void UnregisterOption(){} // RVA: 0x7FFE80E460A0
    }

    public class IKeyboardEvent
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7FFE80E2EDB0
        public void get_character(){} // RVA: 0x7FFE80E2E210
        public void get_keyCode(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IListDragAndDropArgs
    {
        // ── Methods ──
        public void get_insertAtIndex(){} // RVA: 0x7FFE80E2EDB0
        public void get_parentId(){} // RVA: 0x7FFE80E2EDB0
        public void get_childIndex(){} // RVA: 0x7FFE80E2EDB0
        public void get_dragAndDropData(){} // RVA: 0x7FFE80E2E2E0
        public void get_dragAndDropPosition(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IMGUIContainer : VisualElement
    {
        public System.Action m_OnGUIHandler; // 0x3C8
        public UnityEngine.ObjectGUIState m_ObjectGUIState; // 0x3D0
        public bool useOwnerObjectGUIState; // 0x3D8
        public UnityEngine.Rect _lastWorldClip; // 0x3DC
        public bool m_CullingEnabled; // 0x3EC
        public bool m_IsFocusDelegated; // 0x3ED
        public bool m_RefreshCachedLayout; // 0x3EE
        public LayoutCache m_Cache; // 0x3F0
        public UnityEngine.Rect m_CachedClippingRect; // 0x3F8
        public UnityEngine.Matrix4x4 m_CachedTransform; // 0x408

        // ── Methods ──
        public void get_onGUIHandler(){} // RVA: 0x7FFE87F472F0
        public void set_onGUIHandler(){} // RVA: 0x7FFE87F47300
        public void get_guiState(){} // RVA: 0x7FFE87F47400
        public void get_lastWorldClip(){} // RVA: 0x7FFE87F47530
        public void set_lastWorldClip(){} // RVA: 0x7FFE87F47540
        public void get_cullingEnabled(){} // RVA: 0x7FFE87F47550
        public void get_cache(){} // RVA: 0x7FFE87F47560
        public void get_layoutMeasuredWidth(){} // RVA: 0x7FFE87F47620
        public void get_layoutMeasuredHeight(){} // RVA: 0x7FFE87F47650
        public void get_contextType(){} // RVA: 0x7FFE87F47680
        public void set_contextType(){} // RVA: 0x7FFE87F47690
        public void get_focusOnlyIfHasFocusableControls(){} // RVA: 0x7FFE87F476A0
        public void get_canGrabFocus(){} // RVA: 0x7FFE87F476B0
        public void .cctor(){} // RVA: 0x7FFE87F476E0
        public void .ctor(){} // RVA: 0x7FFE87F47F80 | overloaded x2
        public void OnGenerateVisualContent(){} // RVA: 0x7FFE87F48400
        public void SaveGlobals(){} // RVA: 0x7FFE87F48560
        public void RestoreGlobals(){} // RVA: 0x7FFE87F48940
        public void DoOnGUI(){} // RVA: 0x7FFE87F48D40
        public void MarkDirtyLayout(){} // RVA: 0x7FFE87F4A7E0
        public void ProcessEvent(){} // RVA: 0x7FFE87F4A820
        public void DoIMGUIRepaint(){} // RVA: 0x7FFE87F4A9D0
        public void SendEventToIMGUI(){} // RVA: 0x7FFE87F4AD40
        public void SendEventToIMGUIRaw(){} // RVA: 0x7FFE87F4B070
        public void VerifyBounds(){} // RVA: 0x7FFE87F4B130
        public void IsContainerCapturingTheMouse(){} // RVA: 0x7FFE87F4B390
        public void IsLocalEvent(){} // RVA: 0x7FFE87F4B460
        public void IsEventInsideLocalWindow(){} // RVA: 0x7FFE87F4B680
        public void IsDockAreaMouseUp(){} // RVA: 0x7FFE87F4B8D0
        public void HandleIMGUIEvent(){} // RVA: 0x7FFE87F4BD90 | overloaded x3
        public void ExecuteDefaultAction(){} // RVA: 0x7FFE87F4C330
        public void SetFoldoutDepthClass(){} // RVA: 0x7FFE87F4C6A0
        public void DoMeasure(){} // RVA: 0x7FFE87F4C860
        public void GetCurrentClipRect(){} // RVA: 0x7FFE87F4CD00
        public void GetCurrentTransformAndClip(){} // RVA: 0x7FFE87F4CD80
        public void Dispose(){} // RVA: 0x7FFE87F4D070 | overloaded x2
        public void <DoOnGUI>b__56_0(){} // RVA: 0x7FFE87F4D0F0
    }

    public class IMGUIEvent : EventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F3B4A0
        public void GetPooled(){} // RVA: 0x7FFE87F3B590
        public void Init(){} // RVA: 0x7FFE87F3B620
        public void LocalInit(){} // RVA: 0x7FFE87F300E0
        public void .ctor(){} // RVA: 0x7FFE87F3B6E0
    }

    public class IMGUIEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFE87F2C460
        public void DispatchEvent(){} // RVA: 0x7FFE87F2C4F0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class IManipulator
    {
        // ── Methods ──
        public void set_target(){} // RVA: 0x7FFE80E460A0
    }

    public class IMouseEvent
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7FFE80E2EDB0
        public void get_mousePosition(){} // RVA: 0x7FFE80E2E2E0
        public void get_localMousePosition(){} // RVA: 0x7FFE80E2E2E0
        public void get_mouseDelta(){} // RVA: 0x7FFE80E2E2E0
        public void get_clickCount(){} // RVA: 0x7FFE80E2EDB0
        public void get_button(){} // RVA: 0x7FFE80E2EDB0
        public void get_pressedButtons(){} // RVA: 0x7FFE80E2EDB0
        public void get_shiftKey(){} // RVA: 0x7FFE80E2F150
        public void get_ctrlKey(){} // RVA: 0x7FFE80E2F150
        public void get_commandKey(){} // RVA: 0x7FFE80E2F150
        public void get_altKey(){} // RVA: 0x7FFE80E2F150
    }

    public class IMouseEventInternal
    {
        // ── Methods ──
        public void get_triggeredByOS(){} // RVA: 0x7FFE80E2F150
        public void set_triggeredByOS(){} // RVA: 0x7FFE80E466C0
        public void get_recomputeTopElementUnderMouse(){} // RVA: 0x7FFE80E2F150
        public void set_recomputeTopElementUnderMouse(){} // RVA: 0x7FFE80E466C0
        public void get_sourcePointerEvent(){} // RVA: 0x7FFE80E2E2E0
        public void set_sourcePointerEvent(){} // RVA: 0x7FFE80E460A0
    }

    public class INavigationEvent
    {
        // ── Methods ──
        public void get_shiftKey(){} // RVA: 0x7FFE80E2F150
        public void get_altKey(){} // RVA: 0x7FFE80E2F150
    }

    public class INotifyValueChangedExtensions : Object
    {
        // ── Methods ──
        public void RegisterValueChangedCallback(){} // RVA: 0x7FFE80E2F7A0
        public void UnregisterValueChangedCallback(){} // RVA: 0x7FFE80E2F7A0
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE810A1420
        public void set_value(){} // RVA: 0x7FFE810A1420
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE810A1420
    }

    public class IPanel
    {
        // ── Methods ──
        public void get_visualTree(){} // RVA: 0x7FFE80E2E2E0
        public void get_dispatcher(){} // RVA: 0x7FFE80E2E2E0
        public void get_contextType(){} // RVA: 0x7FFE80E2EDB0
        public void get_focusController(){} // RVA: 0x7FFE80E2E2E0
        public void Pick(){}
    }

    public class IPointerCaptureEventInternal
    {
        // ── Methods ──
        public void get_pointerId(){} // RVA: 0x7FFE80E2EDB0
    }

    public class IPointerEvent
    {
        // ── Methods ──
        public void get_pointerId(){} // RVA: 0x7FFE80E2EDB0
        public void get_pointerType(){} // RVA: 0x7FFE80E2E2E0
        public void get_isPrimary(){} // RVA: 0x7FFE80E2F150
        public void get_button(){} // RVA: 0x7FFE80E2EDB0
        public void get_pressedButtons(){} // RVA: 0x7FFE80E2EDB0
        public void get_position(){} // RVA: 0x7FFE80E2DCF0
        public void get_localPosition(){} // RVA: 0x7FFE80E2DCF0
        public void get_deltaPosition(){} // RVA: 0x7FFE80E2DCF0
        public void get_deltaTime(){} // RVA: 0x7FFE80E42E10
        public void get_clickCount(){} // RVA: 0x7FFE80E2EDB0
        public void get_pressure(){} // RVA: 0x7FFE80E42E10
        public void get_tangentialPressure(){} // RVA: 0x7FFE80E42E10
        public void get_altitudeAngle(){} // RVA: 0x7FFE80E42E10
        public void get_azimuthAngle(){} // RVA: 0x7FFE80E42E10
        public void get_twist(){} // RVA: 0x7FFE80E42E10
        public void get_tilt(){} // RVA: 0x7FFE80E2E2E0
        public void get_penStatus(){} // RVA: 0x7FFE80E2EDB0
        public void get_radius(){} // RVA: 0x7FFE80E2E2E0
        public void get_radiusVariance(){} // RVA: 0x7FFE80E2E2E0
        public void get_modifiers(){} // RVA: 0x7FFE80E2EDB0
        public void get_shiftKey(){} // RVA: 0x7FFE80E2F150
        public void get_ctrlKey(){} // RVA: 0x7FFE80E2F150
        public void get_commandKey(){} // RVA: 0x7FFE80E2F150
        public void get_altKey(){} // RVA: 0x7FFE80E2F150
        public void get_actionKey(){} // RVA: 0x7FFE80E2F150
    }

    public class IPointerEventInternal
    {
        // ── Methods ──
        public void get_triggeredByOS(){} // RVA: 0x7FFE80E2F150
        public void set_triggeredByOS(){} // RVA: 0x7FFE80E466C0
        public void get_recomputeTopElementUnderPointer(){} // RVA: 0x7FFE80E2F150
        public void set_recomputeTopElementUnderPointer(){} // RVA: 0x7FFE80E466C0
    }

    public class IReorderable
    {
        // ── Methods ──
        public void get_enableReordering(){} // RVA: 0x7FFE80E2F150
        public void set_enableReordering(){} // RVA: 0x7FFE80E466C0
    }

    public class IResolvedStyle
    {
        // ── Methods ──
        public void get_backgroundColor(){} // RVA: 0x7FFE80E2DCF0
        public void get_borderBottomColor(){} // RVA: 0x7FFE80E2DCF0
        public void get_borderBottomLeftRadius(){} // RVA: 0x7FFE80E42E10
        public void get_borderBottomRightRadius(){} // RVA: 0x7FFE80E42E10
        public void get_borderBottomWidth(){} // RVA: 0x7FFE80E42E10
        public void get_borderLeftColor(){} // RVA: 0x7FFE80E2DCF0
        public void get_borderLeftWidth(){} // RVA: 0x7FFE80E42E10
        public void get_borderRightColor(){} // RVA: 0x7FFE80E2DCF0
        public void get_borderRightWidth(){} // RVA: 0x7FFE80E42E10
        public void get_borderTopColor(){} // RVA: 0x7FFE80E2DCF0
        public void get_borderTopLeftRadius(){} // RVA: 0x7FFE80E42E10
        public void get_borderTopRightRadius(){} // RVA: 0x7FFE80E42E10
        public void get_borderTopWidth(){} // RVA: 0x7FFE80E42E10
        public void get_bottom(){} // RVA: 0x7FFE80E42E10
        public void get_color(){} // RVA: 0x7FFE80E2DCF0
        public void get_display(){} // RVA: 0x7FFE80E2EDB0
        public void get_flexDirection(){} // RVA: 0x7FFE80E2EDB0
        public void get_flexGrow(){} // RVA: 0x7FFE80E42E10
        public void get_flexShrink(){} // RVA: 0x7FFE80E42E10
        public void get_height(){} // RVA: 0x7FFE80E42E10
        public void get_left(){} // RVA: 0x7FFE80E42E10
        public void get_marginBottom(){} // RVA: 0x7FFE80E42E10
        public void get_marginLeft(){} // RVA: 0x7FFE80E42E10
        public void get_marginRight(){} // RVA: 0x7FFE80E42E10
        public void get_marginTop(){} // RVA: 0x7FFE80E42E10
        public void get_minHeight(){}
        public void get_minWidth(){}
        public void get_opacity(){} // RVA: 0x7FFE80E42E10
        public void get_paddingBottom(){} // RVA: 0x7FFE80E42E10
        public void get_paddingLeft(){} // RVA: 0x7FFE80E42E10
        public void get_paddingRight(){} // RVA: 0x7FFE80E42E10
        public void get_paddingTop(){} // RVA: 0x7FFE80E42E10
        public void get_right(){} // RVA: 0x7FFE80E42E10
        public void get_scale(){}
        public void get_top(){} // RVA: 0x7FFE80E42E10
        public void get_transformOrigin(){} // RVA: 0x7FFE80E2DCF0
        public void get_translate(){} // RVA: 0x7FFE80E2DCF0
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x7FFE80E2DCF0
        public void get_unitySliceLeft(){} // RVA: 0x7FFE80E2EDB0
        public void get_unitySliceRight(){} // RVA: 0x7FFE80E2EDB0
        public void get_unitySliceScale(){} // RVA: 0x7FFE80E42E10
        public void get_unityTextOutlineColor(){} // RVA: 0x7FFE80E2DCF0
        public void get_unityTextOutlineWidth(){} // RVA: 0x7FFE80E42E10
        public void get_visibility(){} // RVA: 0x7FFE80E2EDB0
        public void get_width(){} // RVA: 0x7FFE80E42E10
    }

    public class IRuntimePanelComponent
    {
        // ── Methods ──
        public void set_panel(){} // RVA: 0x7FFE80E460A0
    }

    public class IScheduler
    {
        // ── Methods ──
        public void Unschedule(){} // RVA: 0x7FFE80E460A0
        public void Schedule(){} // RVA: 0x7FFE80E460A0
        public void UpdateScheduledEvents(){} // RVA: 0x7FFE80E45FE0
    }

    public class ISerializableJsonDictionary
    {
        // ── Methods ──
        public void Set(){} // RVA: 0x7FFE810A1420
        public void Get(){} // RVA: 0x7FFE810A1420
        public void Overwrite(){} // RVA: 0x7FFE80E4F230
        public void ContainsKey(){} // RVA: 0x7FFE80E2F3B0
    }

    public class IStyle
    {
        // ── Methods ──
        public void set_backgroundColor(){}
        public void get_backgroundSize(){}
        public void set_borderBottomColor(){}
        public void set_borderBottomLeftRadius(){}
        public void set_borderBottomRightRadius(){}
        public void set_borderBottomWidth(){}
        public void set_borderLeftColor(){}
        public void set_borderLeftWidth(){}
        public void set_borderRightColor(){}
        public void set_borderRightWidth(){}
        public void set_borderTopColor(){}
        public void set_borderTopLeftRadius(){}
        public void set_borderTopRightRadius(){}
        public void set_borderTopWidth(){}
        public void set_bottom(){}
        public void set_color(){}
        public void get_cursor(){}
        public void get_display(){}
        public void set_display(){}
        public void set_flexBasis(){}
        public void set_flexDirection(){}
        public void set_flexGrow(){}
        public void set_flexShrink(){}
        public void set_fontSize(){}
        public void set_height(){}
        public void set_left(){}
        public void set_marginBottom(){}
        public void set_marginLeft(){}
        public void set_marginRight(){}
        public void set_marginTop(){}
        public void set_maxHeight(){}
        public void set_maxWidth(){}
        public void set_minWidth(){}
        public void set_opacity(){}
        public void set_overflow(){}
        public void set_paddingBottom(){}
        public void set_paddingLeft(){}
        public void set_paddingRight(){}
        public void get_paddingTop(){}
        public void set_paddingTop(){}
        public void set_position(){}
        public void set_right(){}
        public void get_rotate(){}
        public void get_scale(){}
        public void get_textShadow(){}
        public void set_top(){}
        public void get_transformOrigin(){}
        public void get_translate(){}
        public void set_translate(){}
        public void set_unityBackgroundImageTintColor(){}
        public void set_unityFont(){}
        public void set_unityFontDefinition(){}
        public void set_visibility(){}
        public void get_width(){}
        public void set_width(){}
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFE810A1420
        public void CopyFrom(){} // RVA: 0x7FFE80E460A0
    }

    public class IStylePainter
    {
        // ── Methods ──
        public void DrawText(){} // RVA: 0x7FFE80E460A0
        public void DrawRectangle(){}
        public void DrawImmediate(){} // RVA: 0x7FFE80E4BC00
    }

    public class IStylePropertyAnimationSystem
    {
        // ── Methods ──
        public void StartTransition(){} // overloaded x15
        public void CancelAllAnimations(){} // RVA: 0x7FFE80E460A0 | overloaded x2
        public void CancelAnimation(){} // RVA: 0x7FFE80E4D070
        public void UpdateAnimation(){} // RVA: 0x7FFE80E4D070
        public void GetAllAnimations(){} // RVA: 0x7FFE80E4F230
        public void Update(){} // RVA: 0x7FFE80E45FE0
    }

    public class IStylePropertyAnimations
    {
        // ── Methods ──
        public void Start(){} // overloaded x15
        public void StartEnum(){}
        public void UpdateAnimation(){} // RVA: 0x7FFE80E46530
        public void GetAllAnimations(){} // RVA: 0x7FFE80E460A0
        public void CancelAnimation(){} // RVA: 0x7FFE80E46530
        public void CancelAllAnimations(){} // RVA: 0x7FFE80E45FE0
        public void get_runningAnimationCount(){} // RVA: 0x7FFE80E2EDB0
        public void set_runningAnimationCount(){} // RVA: 0x7FFE80E46530
        public void get_completedAnimationCount(){} // RVA: 0x7FFE80E2EDB0
        public void set_completedAnimationCount(){} // RVA: 0x7FFE80E46530
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE810A1420
        public void get_keyword(){} // RVA: 0x7FFE80E2EDB0
    }

    public class ITextEdition
    {
        // ── Methods ──
        public void get_multiline(){} // RVA: 0x7FFE80E2F150
        public void set_multiline(){} // RVA: 0x7FFE80E466C0
        public void get_isReadOnly(){} // RVA: 0x7FFE80E2F150
        public void set_isReadOnly(){} // RVA: 0x7FFE80E466C0
        public void get_maxLength(){} // RVA: 0x7FFE80E2EDB0
        public void set_maxLength(){} // RVA: 0x7FFE80E46530
        public void get_isDelayed(){} // RVA: 0x7FFE80E2F150
        public void set_isDelayed(){} // RVA: 0x7FFE80E466C0
        public void SaveValueAndText(){} // RVA: 0x7FFE80E45FE0
        public void RestoreValueAndText(){} // RVA: 0x7FFE80E45FE0
        public void get_AcceptCharacter(){} // RVA: 0x7FFE80E2E2E0
        public void set_AcceptCharacter(){} // RVA: 0x7FFE80E460A0
        public void get_UpdateScrollOffset(){} // RVA: 0x7FFE80E2E2E0
        public void set_UpdateScrollOffset(){} // RVA: 0x7FFE80E460A0
        public void get_UpdateValueFromText(){} // RVA: 0x7FFE80E2E2E0
        public void set_UpdateValueFromText(){} // RVA: 0x7FFE80E460A0
        public void get_UpdateTextFromValue(){} // RVA: 0x7FFE80E2E2E0
        public void set_UpdateTextFromValue(){} // RVA: 0x7FFE80E460A0
        public void get_MoveFocusToCompositeRoot(){} // RVA: 0x7FFE80E2E2E0
        public void set_MoveFocusToCompositeRoot(){} // RVA: 0x7FFE80E460A0
        public void UpdateText(){} // RVA: 0x7FFE80E460A0
        public void CullString(){} // RVA: 0x7FFE80E2E390
        public void set_maskChar(){} // RVA: 0x7FFE80E461D0
        public void get_isPassword(){} // RVA: 0x7FFE80E2F150
        public void set_isPassword(){} // RVA: 0x7FFE80E466C0
        public void get_autoCorrection(){} // RVA: 0x7FFE87FC3D20
        public void set_autoCorrection(){} // RVA: 0x7FFE87FC3DE0
        public void get_hideMobileInput(){} // RVA: 0x7FFE87FC3EA0
        public void set_hideMobileInput(){} // RVA: 0x7FFE87FC3F60
        public void get_keyboardType(){} // RVA: 0x7FFE87FC4020
        public void set_keyboardType(){} // RVA: 0x7FFE87FC40E0
    }

    public class ITextSelection
    {
        // ── Methods ──
        public void get_isSelectable(){} // RVA: 0x7FFE80E2F150
        public void set_isSelectable(){} // RVA: 0x7FFE80E466C0
        public void get_cursorColor(){} // RVA: 0x7FFE80E2DCF0
        public void set_cursorColor(){} // RVA: 0x7FFE80E460A0
        public void get_cursorIndex(){} // RVA: 0x7FFE80E2EDB0
        public void set_cursorIndex(){} // RVA: 0x7FFE80E46530
        public void get_doubleClickSelectsWord(){} // RVA: 0x7FFE80E2F150
        public void get_selectIndex(){} // RVA: 0x7FFE80E2EDB0
        public void set_selectIndex(){} // RVA: 0x7FFE80E46530
        public void get_selectionColor(){} // RVA: 0x7FFE80E2DCF0
        public void set_selectionColor(){} // RVA: 0x7FFE80E460A0
        public void get_tripleClickSelectsLine(){} // RVA: 0x7FFE80E2F150
        public void HasSelection(){} // RVA: 0x7FFE80E2F150
        public void SelectAll(){} // RVA: 0x7FFE80E45FE0
        public void SelectNone(){} // RVA: 0x7FFE80E45FE0
        public void get_selectAllOnFocus(){} // RVA: 0x7FFE80E2F150
        public void set_selectAllOnFocus(){} // RVA: 0x7FFE80E466C0
        public void get_selectAllOnMouseUp(){} // RVA: 0x7FFE80E2F150
        public void set_selectAllOnMouseUp(){} // RVA: 0x7FFE80E466C0
        public void get_cursorPosition(){} // RVA: 0x7FFE80E2E2E0
        public void get_lineHeightAtCursorPosition(){} // RVA: 0x7FFE80E42E10
        public void get_cursorWidth(){} // RVA: 0x7FFE80E42E10
    }

    public class ITransform
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFE80E2DCF0
        public void set_position(){} // RVA: 0x7FFE80E460A0
        public void get_scale(){} // RVA: 0x7FFE80E2DCF0
    }

    public class IUIElementsUtility
    {
        // ── Methods ──
        public void TakeCapture(){} // RVA: 0x7FFE80E2F150
        public void ReleaseCapture(){} // RVA: 0x7FFE80E2F150
        public void ProcessEvent(){}
        public void CleanupRoots(){} // RVA: 0x7FFE80E2F150
        public void EndContainerGUIFromException(){} // RVA: 0x7FFE80E2F3B0
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7FFE80E2F150
    }

    public class IUxmlAttributes
    {
        // ── Methods ──
        public void TryGetAttributeValue(){} // RVA: 0x7FFE80E32650
    }

    public class IUxmlFactory
    {
        // ── Methods ──
        public void Create(){}
    }

    public class IUxmlObjectFactory`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFE810A1420
    }

    public class IValueField`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFE810A1420
        public void set_value(){} // RVA: 0x7FFE810A1420
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE810A1420
        public void StartDragging(){} // RVA: 0x7FFE80E45FE0
        public void StopDragging(){} // RVA: 0x7FFE80E45FE0
    }

    public class IVisualElementPanelActivatable
    {
        // ── Methods ──
        public void get_element(){} // RVA: 0x7FFE80E2E2E0
        public void CanBeActivated(){} // RVA: 0x7FFE80E2F150
        public void OnPanelActivate(){} // RVA: 0x7FFE80E45FE0
        public void OnPanelDeactivate(){} // RVA: 0x7FFE80E45FE0
    }

    public class IVisualElementScheduledItem
    {
        // ── Methods ──
        public void Resume(){} // RVA: 0x7FFE80E45FE0
        public void Pause(){} // RVA: 0x7FFE80E45FE0
        public void ExecuteLater(){} // RVA: 0x7FFE80E46250
        public void StartingIn(){}
        public void Every(){}
    }

    public class IVisualElementScheduler
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFE80E2E390 | overloaded x2
    }

    public class IVisualTreeUpdater
    {
        // ── Methods ──
        public void set_panel(){} // RVA: 0x7FFE80E460A0
        public void get_profilerMarker(){}
        public void Update(){} // RVA: 0x7FFE80E45FE0
        public void OnVersionChanged(){} // RVA: 0x7FFE80E4D070
    }

    public class Image : VisualElement
    {
        public 0x6667968C m_ScaleMode; // 0x3C8
        public UnityEngine.Texture m_Image; // 0x3D0
        public UnityEngine.Sprite m_Sprite; // 0x3D8
        public UnityEngine.UIElements.VectorImage m_VectorImage; // 0x3E0
        public UnityEngine.Rect m_UV; // 0x3E8
        public UnityEngine.Color m_TintColor; // 0x3F8
        public bool m_ImageIsInline; // 0x408

        // ── Methods ──
        public void get_image(){} // RVA: 0x7FFE81B0DE50
        public void set_image(){} // RVA: 0x7FFE87E60F90
        public void get_sprite(){} // RVA: 0x7FFE81B0E4A0
        public void set_sprite(){} // RVA: 0x7FFE87E611A0
        public void get_vectorImage(){} // RVA: 0x7FFE81B2A270
        public void set_vectorImage(){} // RVA: 0x7FFE87E613B0
        public void get_sourceRect(){} // RVA: 0x7FFE87E615C0
        public void get_uv(){} // RVA: 0x7FFE87E615F0
        public void set_uv(){} // RVA: 0x7FFE87E61600
        public void get_scaleMode(){} // RVA: 0x7FFE87E61660
        public void get_tintColor(){} // RVA: 0x7FFE87E61670
        public void .ctor(){} // RVA: 0x7FFE87E61680
        public void GetTextureDisplaySize(){} // RVA: 0x7FFE87E61A20 | overloaded x2
        public void DoMeasure(){} // RVA: 0x7FFE87E61C60
        public void OnGenerateVisualContent(){} // RVA: 0x7FFE87E62110
        public void OnCustomStyleResolved(){} // RVA: 0x7FFE87E62930
        public void ReadCustomProperties(){} // RVA: 0x7FFE87E62970
        public void SetProperty(){} // RVA: 0x7FFE810A1420
        public void ClearProperty(){} // RVA: 0x7FFE87E62FB0
        public void SetScaleMode(){} // RVA: 0x7FFE87E63000
        public void SetTintColor(){} // RVA: 0x7FFE87E63050
        public void GetSourceRect(){} // RVA: 0x7FFE87E63100
        public void .cctor(){} // RVA: 0x7FFE87E633C0
    }

    public class ImmediateModeException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F4D1E0
    }

    public class InheritedData : ValueType
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFE87F9DF10
        public void CopyFrom(){} // RVA: 0x7FFE87F9DF60
        public void op_Equality(){} // RVA: 0x7FFE87F9E020
        public void Equals(){} // RVA: 0x7FFE87F9E7F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87F9E900
    }

    public class InlineStyleAccess : StyleValueCollection
    {
        public UnityEngine.UIElements.StyleSheets.StylePropertyReader s_StylePropertyReader;
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StyleValueManaged> m_ValuesManaged; // 0x18
        public UnityEngine.UIElements.VisualElement _ve; // 0x20
        public bool m_HasInlineCursor; // 0x28
        public UnityEngine.UIElements.StyleCursor m_InlineCursor; // 0x30
        public bool m_HasInlineTextShadow; // 0x50
        public UnityEngine.UIElements.StyleTextShadow m_InlineTextShadow; // 0x54
        public bool m_HasInlineTransformOrigin; // 0x74
        public UnityEngine.UIElements.StyleTransformOrigin m_InlineTransformOrigin; // 0x78
        public bool m_HasInlineTranslate; // 0x90
        public UnityEngine.UIElements.StyleTranslate m_InlineTranslateOperation; // 0x94
        public bool m_HasInlineRotate; // 0xB0
        public UnityEngine.UIElements.StyleRotate m_InlineRotateOperation; // 0xB4
        public bool m_HasInlineScale; // 0xD0
        public UnityEngine.UIElements.StyleScale m_InlineScale; // 0xD4
        public bool m_HasInlineBackgroundSize; // 0xE8
        public UnityEngine.UIElements.StyleBackgroundSize m_InlineBackgroundSize; // 0xEC
        public InlineRule m_InlineRule; // 0x108
        public UnityEngine.UIElements.Cursor m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x28
        public 0x6651B36C m_Keyword; // 0x10
        public UnityEngine.UIElements.TextShadow m_Value; // 0x14
        public UnityEngine.UIElements.TransformOrigin m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x24
        public UnityEngine.UIElements.Translate m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x28
        public UnityEngine.UIElements.Rotate m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x28
        public UnityEngine.UIElements.Scale m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x20
        public UnityEngine.UIElements.BackgroundSize m_Value; // 0x10
        public 0x6651B36C m_Keyword; // 0x24
        public UnityEngine.UIElements.StyleSheet sheet; // 0x10
        public UnityEngine.UIElements.StyleRule rule; // 0x18
        public 0x66522694[] propertyIds; // 0x20
        public object field_35; // 0x393
        public object field_36; // 0x394
        public object field_37; // 0x395
        public object field_38; // 0x396
        public object field_39; // 0x397
        public object field_40; // 0x398
        public object field_41; // 0x399
        public object field_42; // 0x39A
        public object field_43; // 0x39B
        public object field_44; // 0x39C
        public object field_45; // 0x39D
        public object field_46; // 0x39E
        public object field_47; // 0x39F
        public object field_48; // 0x3A0
        public object field_49; // 0x3A1
        public object field_50; // 0x3A2
        public object field_51; // 0x3A3

        // ── Methods ──
        public void UnityEngine.UIElements.IStyle.set_backgroundColor(){} // RVA: 0x7FFE87F818C0
        public void UnityEngine.UIElements.IStyle.set_borderBottomColor(){} // RVA: 0x7FFE87F81930
        public void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(){} // RVA: 0x7FFE87F819A0
        public void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(){} // RVA: 0x7FFE87F81A10
        public void UnityEngine.UIElements.IStyle.set_borderBottomWidth(){} // RVA: 0x7FFE87F81A80
        public void UnityEngine.UIElements.IStyle.set_borderLeftColor(){} // RVA: 0x7FFE87F81B40
        public void UnityEngine.UIElements.IStyle.set_borderLeftWidth(){} // RVA: 0x7FFE87F81BB0
        public void UnityEngine.UIElements.IStyle.set_borderRightColor(){} // RVA: 0x7FFE87F81C70
        public void UnityEngine.UIElements.IStyle.set_borderRightWidth(){} // RVA: 0x7FFE87F81CE0
        public void UnityEngine.UIElements.IStyle.set_borderTopColor(){} // RVA: 0x7FFE87F81DA0
        public void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(){} // RVA: 0x7FFE87F81E10
        public void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(){} // RVA: 0x7FFE87F81E80
        public void UnityEngine.UIElements.IStyle.set_borderTopWidth(){} // RVA: 0x7FFE87F81EF0
        public void UnityEngine.UIElements.IStyle.set_bottom(){} // RVA: 0x7FFE87F81FB0
        public void UnityEngine.UIElements.IStyle.set_color(){} // RVA: 0x7FFE87F82090
        public void UnityEngine.UIElements.IStyle.get_display(){} // RVA: 0x7FFE87F82100
        public void UnityEngine.UIElements.IStyle.set_display(){} // RVA: 0x7FFE87F821C0
        public void UnityEngine.UIElements.IStyle.set_flexBasis(){} // RVA: 0x7FFE87F822F0
        public void UnityEngine.UIElements.IStyle.set_flexDirection(){} // RVA: 0x7FFE87F823D0
        public void UnityEngine.UIElements.IStyle.set_flexGrow(){} // RVA: 0x7FFE87F82500
        public void UnityEngine.UIElements.IStyle.set_flexShrink(){} // RVA: 0x7FFE87F825C0
        public void UnityEngine.UIElements.IStyle.set_fontSize(){} // RVA: 0x7FFE87F82680
        public void UnityEngine.UIElements.IStyle.set_height(){} // RVA: 0x7FFE87F826F0
        public void UnityEngine.UIElements.IStyle.set_left(){} // RVA: 0x7FFE87F827D0
        public void UnityEngine.UIElements.IStyle.set_marginBottom(){} // RVA: 0x7FFE87F828B0
        public void UnityEngine.UIElements.IStyle.set_marginLeft(){} // RVA: 0x7FFE87F82990
        public void UnityEngine.UIElements.IStyle.set_marginRight(){} // RVA: 0x7FFE87F82A70
        public void UnityEngine.UIElements.IStyle.set_marginTop(){} // RVA: 0x7FFE87F82B50
        public void UnityEngine.UIElements.IStyle.set_maxHeight(){} // RVA: 0x7FFE87F82C40
        public void UnityEngine.UIElements.IStyle.set_maxWidth(){} // RVA: 0x7FFE87F82D20
        public void UnityEngine.UIElements.IStyle.set_minWidth(){} // RVA: 0x7FFE87F82E00
        public void UnityEngine.UIElements.IStyle.set_opacity(){} // RVA: 0x7FFE87F82EE0
        public void UnityEngine.UIElements.IStyle.set_overflow(){} // RVA: 0x7FFE87F82F40
        public void UnityEngine.UIElements.IStyle.set_paddingBottom(){} // RVA: 0x7FFE87F830C0
        public void UnityEngine.UIElements.IStyle.set_paddingLeft(){} // RVA: 0x7FFE87F831B0
        public void UnityEngine.UIElements.IStyle.set_paddingRight(){} // RVA: 0x7FFE87F83290
        public void UnityEngine.UIElements.IStyle.get_paddingTop(){} // RVA: 0x7FFE87F83380
        public void UnityEngine.UIElements.IStyle.set_paddingTop(){} // RVA: 0x7FFE87F83410
        public void UnityEngine.UIElements.IStyle.set_position(){} // RVA: 0x7FFE87F83500
        public void UnityEngine.UIElements.IStyle.set_right(){} // RVA: 0x7FFE87F83630
        public void UnityEngine.UIElements.IStyle.set_top(){} // RVA: 0x7FFE87F83720
        public void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(){} // RVA: 0x7FFE87F83810
        public void UnityEngine.UIElements.IStyle.set_unityFont(){} // RVA: 0x7FFE87F83880
        public void UnityEngine.UIElements.IStyle.set_unityFontDefinition(){} // RVA: 0x7FFE87F838F0
        public void UnityEngine.UIElements.IStyle.set_visibility(){} // RVA: 0x7FFE87F83970
        public void UnityEngine.UIElements.IStyle.get_width(){} // RVA: 0x7FFE87F83A00
        public void UnityEngine.UIElements.IStyle.set_width(){} // RVA: 0x7FFE87F83A90
        public void get_ve(){} // RVA: 0x7FFE811290C0
        public void set_ve(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE87F83B70
        public void Finalize(){} // RVA: 0x7FFE87F83BE0
        public void SetInlineRule(){} // RVA: 0x7FFE87F83D20
        public void IsValueSet(){} // RVA: 0x7FFE87F83F70
        public void ApplyInlineStyles(){} // RVA: 0x7FFE87F84350
        public void UnityEngine.UIElements.IStyle.get_cursor(){} // RVA: 0x7FFE87F85350
        public void UnityEngine.UIElements.IStyle.get_textShadow(){} // RVA: 0x7FFE87F85490
        public void UnityEngine.UIElements.IStyle.get_backgroundSize(){} // RVA: 0x7FFE87F85500
        public void UnityEngine.UIElements.IStyle.get_transformOrigin(){} // RVA: 0x7FFE87F85560
        public void UnityEngine.UIElements.IStyle.get_translate(){} // RVA: 0x7FFE87F855B0
        public void UnityEngine.UIElements.IStyle.set_translate(){} // RVA: 0x7FFE87F85610
        public void UnityEngine.UIElements.IStyle.get_rotate(){} // RVA: 0x7FFE87F85880
        public void UnityEngine.UIElements.IStyle.get_scale(){} // RVA: 0x7FFE87F858E0
        public void SetStyleValue(){} // RVA: 0x7FFE87F862E0 | overloaded x6
        public void SetInlineTranslate(){} // RVA: 0x7FFE87F865E0
        public void ApplyStyleTranslate(){} // RVA: 0x7FFE87F867A0
        public void ApplyStyleValue(){} // RVA: 0x7FFE87F86BD0
        public void RemoveInlineStyle(){} // RVA: 0x7FFE87F86EF0
        public void ApplyFromComputedStyle(){} // RVA: 0x7FFE87F87040
        public void TryGetInlineCursor(){} // RVA: 0x7FFE87F87250
        public void TryGetInlineTextShadow(){} // RVA: 0x7FFE87F872C0
        public void TryGetInlineTransformOrigin(){} // RVA: 0x7FFE87F872E0
        public void TryGetInlineTranslate(){} // RVA: 0x7FFE87F87300
        public void TryGetInlineRotate(){} // RVA: 0x7FFE87F87330
        public void TryGetInlineScale(){} // RVA: 0x7FFE87F87360
        public void TryGetInlineBackgroundSize(){} // RVA: 0x7FFE87F87390
        public void .cctor(){} // RVA: 0x7FFE87F873C0
    }

    public class InputEvent : EventBase`1
    {
        public string _previousData; // 0x88
        public string _newData; // 0x90

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F2C570
        public void set_previousData(){} // RVA: 0x7FFE81280F90
        public void set_newData(){} // RVA: 0x7FFE818CE320
        public void Init(){} // RVA: 0x7FFE87F2C660
        public void LocalInit(){} // RVA: 0x7FFE87F2C720
        public void GetPooled(){} // RVA: 0x7FFE87F2C7E0
        public void .ctor(){} // RVA: 0x7FFE87F2C910
    }

    public class IntegerField : TextValueField`1
    {
        public string ussClassName;

        // ── Methods ──
        public void get_integerInput(){} // RVA: 0x7FFE87EE5C50
        public void ValueToString(){} // RVA: 0x7FFE87EE5CE0
        public void StringToValue(){} // RVA: 0x7FFE87EE5EF0
        public void .ctor(){} // RVA: 0x7FFE87EE6040 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFE87EE6480
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFE87EE6550
        public void .cctor(){} // RVA: 0x7FFE87EE6640
    }

}