// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 100
// Methods: 426

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class IBaseUxmlFactory
    {
        // ── Methods ──
        public void get_uxmlQualifiedName(){} // RVA: 0xCD60
        public void get_uxmlType(){} // RVA: 0xCD60
        public void AcceptsAttributeBag(){}
    }

    public class IBaseUxmlObjectFactory
    {
    }

    public class IBindable
    {
        // ── Methods ──
        public void get_binding(){} // RVA: 0xCD60
        public void set_bindingPath(){} // RVA: 0x24B10
    }

    public class IBinding
    {
        // ── Methods ──
        public void PreUpdate(){} // RVA: 0x24A50
        public void Update(){} // RVA: 0x24A50
        public void Release(){} // RVA: 0x24A50
    }

    public class IBindingRequest
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x24B10
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
        public void ResetCursor(){} // RVA: 0x24A50
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
        public void UpdateDrag(){} // RVA: 0x24B10
        public void AcceptDrag(){} // RVA: 0x24A50
        public void DragCleanup(){} // RVA: 0x24A50
        public void SetVisualMode(){} // RVA: 0x24FA0
        public void get_data(){} // RVA: 0xCD60
    }

    public class IDragAndDropController`1
    {
        // ── Methods ──
        public void CanStartDrag(){} // RVA: 0xDE40
        public void SetupDragAndDrop(){}
        public void HandleDragAndDrop(){} // RVA: 0x283FA0
        public void OnDrop(){} // RVA: 0x283FA0
        public void DragCleanup(){} // RVA: 0x24A50
        public void HandleAutoExpand(){}
        public void GetSortedSelectedIds(){} // RVA: 0xCD60
    }

    public class IDragAndDropController`1
    {
    }

    public class IEditableElement
    {
        // ── Methods ──
        public void get_editingStarted(){} // RVA: 0xCD60
        public void get_editingEnded(){} // RVA: 0xCD60
    }

    public class IEnumerableExtensions
    {
        // ── Methods ──
        public void HasValues(){} // RVA: 0x7406B10
    }

    public class IEventDispatchingStrategy
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0xDE40
        public void DispatchEvent(){} // RVA: 0x2DC60
    }

    public class IEventHandler
    {
        // ── Methods ──
        public void SendEvent(){} // RVA: 0x24B10
        public void HandleEvent(){} // RVA: 0x24B10
    }

    public class IExperimentalFeatures
    {
        // ── Methods ──
        public void get_animation(){} // RVA: 0xCD60
    }

    public class IFocusRing
    {
        // ── Methods ──
        public void GetFocusChangeDirection(){} // RVA: 0x1E6A0
        public void GetNextFocusable(){} // RVA: 0x1E6A0
    }

    public class IGenericMenu
    {
        // ── Methods ──
        public void AddItem(){} // RVA: 0x2AD00 | overloaded x2
        public void DropDown(){}
    }

    public class IGroupBox
    {
        // ── Methods ──
        public void OnOptionAdded(){} // RVA: 0x24B10
        public void OnOptionRemoved(){} // RVA: 0x24B10
    }

    public class IGroupBoxOption
    {
        // ── Methods ──
        public void SetSelected(){} // RVA: 0x25130
    }

    public class IGroupBox`1
    {
    }

    public class IGroupManager
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x24B10
        public void OnOptionSelectionChanged(){} // RVA: 0x24B10
        public void RegisterOption(){} // RVA: 0x24B10
        public void UnregisterOption(){} // RVA: 0x24B10
    }

    public class IKeyboardEvent
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xD840
        public void get_character(){} // RVA: 0xCC90
        public void get_keyCode(){} // RVA: 0xD840
    }

    public class IListDragAndDropArgs
    {
        // ── Methods ──
        public void get_insertAtIndex(){} // RVA: 0xD840
        public void get_parentId(){} // RVA: 0xD840
        public void get_childIndex(){} // RVA: 0xD840
        public void get_dragAndDropData(){} // RVA: 0xCD60
        public void get_dragAndDropPosition(){} // RVA: 0xD840
    }

    public class IMGUIContainer
    {
        public System.Action m_OnGUIHandler; // 0x3C8
        public UnityEngine.ObjectGUIState m_ObjectGUIState; // 0x3D0
        public bool useOwnerObjectGUIState; // 0x3D8
        public UnityEngine.Rect <lastWorldClip>k__BackingField; // 0x3DC
        public bool m_CullingEnabled; // 0x3EC
        public bool m_IsFocusDelegated; // 0x3ED
        public bool m_RefreshCachedLayout; // 0x3EE
        public LayoutCache m_Cache; // 0x3F0
        public UnityEngine.Rect m_CachedClippingRect; // 0x3F8
        public UnityEngine.Matrix4x4 m_CachedTransform; // 0x408

        // ── Methods ──
        public void get_onGUIHandler(){} // RVA: 0x7407150
        public void set_onGUIHandler(){} // RVA: 0x7407160
        public void get_guiState(){} // RVA: 0x7407260
        public void get_lastWorldClip(){} // RVA: 0x7407390
        public void set_lastWorldClip(){} // RVA: 0x74073A0
        public void get_cullingEnabled(){} // RVA: 0x74073B0
        public void get_cache(){} // RVA: 0x74073C0
        public void get_layoutMeasuredWidth(){} // RVA: 0x7407480
        public void get_layoutMeasuredHeight(){} // RVA: 0x74074B0
        public void get_contextType(){} // RVA: 0x74074E0
        public void set_contextType(){} // RVA: 0x74074F0
        public void get_focusOnlyIfHasFocusableControls(){} // RVA: 0x7407500
        public void get_canGrabFocus(){} // RVA: 0x7407510
        public void .cctor(){} // RVA: 0x7407540
        public void .ctor(){} // RVA: 0x7407DE0 | overloaded x2
        public void OnGenerateVisualContent(){} // RVA: 0x7408260
        public void SaveGlobals(){} // RVA: 0x74083C0
        public void RestoreGlobals(){} // RVA: 0x74087A0
        public void DoOnGUI(){} // RVA: 0x7408BA0
        public void MarkDirtyLayout(){} // RVA: 0x740A640
        public void ProcessEvent(){} // RVA: 0x740A680
        public void DoIMGUIRepaint(){} // RVA: 0x740A830
        public void SendEventToIMGUI(){} // RVA: 0x740ABA0
        public void SendEventToIMGUIRaw(){} // RVA: 0x740AED0
        public void VerifyBounds(){} // RVA: 0x740AF90
        public void IsContainerCapturingTheMouse(){} // RVA: 0x740B1F0
        public void IsLocalEvent(){} // RVA: 0x740B2C0
        public void IsEventInsideLocalWindow(){} // RVA: 0x740B4E0
        public void IsDockAreaMouseUp(){} // RVA: 0x740B730
        public void HandleIMGUIEvent(){} // RVA: 0x740BBF0 | overloaded x3
        public void ExecuteDefaultAction(){} // RVA: 0x740C190
        public void SetFoldoutDepthClass(){} // RVA: 0x740C500
        public void DoMeasure(){} // RVA: 0x740C6C0
        public void GetCurrentClipRect(){} // RVA: 0x740CB60
        public void GetCurrentTransformAndClip(){} // RVA: 0x740CBE0
        public void Dispose(){} // RVA: 0x740CED0 | overloaded x2
        public void <DoOnGUI>b__56_0(){} // RVA: 0x740CF50
    }

    public class IMGUIEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73FB300
        public void GetPooled(){} // RVA: 0x73FB3F0
        public void Init(){} // RVA: 0x73FB480
        public void LocalInit(){} // RVA: 0x73EFF40
        public void .ctor(){} // RVA: 0x73FB540
    }

    public class IMGUIEventDispatchingStrategy
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x73EC2C0
        public void DispatchEvent(){} // RVA: 0x73EC350
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class IManipulator
    {
        // ── Methods ──
        public void set_target(){} // RVA: 0x24B10
    }

    public class IMouseEvent
    {
        // ── Methods ──
        public void get_modifiers(){} // RVA: 0xD840
        public void get_mousePosition(){} // RVA: 0xCD60
        public void get_localMousePosition(){} // RVA: 0xCD60
        public void get_mouseDelta(){} // RVA: 0xCD60
        public void get_clickCount(){} // RVA: 0xD840
        public void get_button(){} // RVA: 0xD840
        public void get_pressedButtons(){} // RVA: 0xD840
        public void get_shiftKey(){} // RVA: 0xDBE0
        public void get_ctrlKey(){} // RVA: 0xDBE0
        public void get_commandKey(){} // RVA: 0xDBE0
        public void get_altKey(){} // RVA: 0xDBE0
    }

    public class IMouseEventInternal
    {
        // ── Methods ──
        public void get_triggeredByOS(){} // RVA: 0xDBE0
        public void set_triggeredByOS(){} // RVA: 0x25130
        public void get_recomputeTopElementUnderMouse(){} // RVA: 0xDBE0
        public void set_recomputeTopElementUnderMouse(){} // RVA: 0x25130
        public void get_sourcePointerEvent(){} // RVA: 0xCD60
        public void set_sourcePointerEvent(){} // RVA: 0x24B10
    }

    public class INavigationEvent
    {
        // ── Methods ──
        public void get_shiftKey(){} // RVA: 0xDBE0
        public void get_altKey(){} // RVA: 0xDBE0
    }

    public class INotifyValueChangedExtensions
    {
        // ── Methods ──
        public void RegisterValueChangedCallback(){} // RVA: 0xE230
        public void UnregisterValueChangedCallback(){} // RVA: 0xE230
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x283FA0
        public void set_value(){} // RVA: 0x283FA0
        public void SetValueWithoutNotify(){} // RVA: 0x283FA0
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0xCD60
        public void set_value(){} // RVA: 0x24B10
        public void SetValueWithoutNotify(){} // RVA: 0x24B10
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0xDBE0
        public void set_value(){} // RVA: 0x25130
        public void SetValueWithoutNotify(){} // RVA: 0x25130
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0xD840
        public void set_value(){} // RVA: 0x24FA0
        public void SetValueWithoutNotify(){} // RVA: 0x24FA0
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x21890
        public void set_value(){} // RVA: 0x325B0
        public void SetValueWithoutNotify(){} // RVA: 0x325B0
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x12A40
        public void set_value(){} // RVA: 0x26100
        public void SetValueWithoutNotify(){} // RVA: 0x26100
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0xCD60
        public void set_value(){} // RVA: 0x24CC0
        public void SetValueWithoutNotify(){} // RVA: 0x24CC0
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0xD840
        public void set_value(){} // RVA: 0x24FA0
        public void SetValueWithoutNotify(){} // RVA: 0x24FA0
    }

    public class INotifyValueChanged`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0xCD60
        public void set_value(){} // RVA: 0x24CC0
        public void SetValueWithoutNotify(){} // RVA: 0x24CC0
    }

    public class IPanel :  Ƀe
    {
        // ── Methods ──
        public void get_visualTree(){} // RVA: 0xCD60
        public void get_dispatcher(){} // RVA: 0xCD60
        public void get_contextType(){} // RVA: 0xD840
        public void get_focusController(){} // RVA: 0xCD60
        public void Pick(){}
    }

    public class IPointerCaptureEventInternal
    {
        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD840
    }

    public class IPointerEvent
    {
        // ── Methods ──
        public void get_pointerId(){} // RVA: 0xD840
        public void get_pointerType(){} // RVA: 0xCD60
        public void get_isPrimary(){} // RVA: 0xDBE0
        public void get_button(){} // RVA: 0xD840
        public void get_pressedButtons(){} // RVA: 0xD840
        public void get_position(){} // RVA: 0xC770
        public void get_localPosition(){} // RVA: 0xC770
        public void get_deltaPosition(){} // RVA: 0xC770
        public void get_deltaTime(){} // RVA: 0x21890
        public void get_clickCount(){} // RVA: 0xD840
        public void get_pressure(){} // RVA: 0x21890
        public void get_tangentialPressure(){} // RVA: 0x21890
        public void get_altitudeAngle(){} // RVA: 0x21890
        public void get_azimuthAngle(){} // RVA: 0x21890
        public void get_twist(){} // RVA: 0x21890
        public void get_tilt(){} // RVA: 0xCD60
        public void get_penStatus(){} // RVA: 0xD840
        public void get_radius(){} // RVA: 0xCD60
        public void get_radiusVariance(){} // RVA: 0xCD60
        public void get_modifiers(){} // RVA: 0xD840
        public void get_shiftKey(){} // RVA: 0xDBE0
        public void get_ctrlKey(){} // RVA: 0xDBE0
        public void get_commandKey(){} // RVA: 0xDBE0
        public void get_altKey(){} // RVA: 0xDBE0
        public void get_actionKey(){} // RVA: 0xDBE0
    }

    public class IPointerEventInternal
    {
        // ── Methods ──
        public void get_triggeredByOS(){} // RVA: 0xDBE0
        public void set_triggeredByOS(){} // RVA: 0x25130
        public void get_recomputeTopElementUnderPointer(){} // RVA: 0xDBE0
        public void set_recomputeTopElementUnderPointer(){} // RVA: 0x25130
    }

    public class IReorderable
    {
        // ── Methods ──
        public void get_enableReordering(){} // RVA: 0xDBE0
        public void set_enableReordering(){} // RVA: 0x25130
    }

    public class IResolvedStyle
    {
        // ── Methods ──
        public void get_backgroundColor(){} // RVA: 0xC770
        public void get_borderBottomColor(){} // RVA: 0xC770
        public void get_borderBottomLeftRadius(){} // RVA: 0x21890
        public void get_borderBottomRightRadius(){} // RVA: 0x21890
        public void get_borderBottomWidth(){} // RVA: 0x21890
        public void get_borderLeftColor(){} // RVA: 0xC770
        public void get_borderLeftWidth(){} // RVA: 0x21890
        public void get_borderRightColor(){} // RVA: 0xC770
        public void get_borderRightWidth(){} // RVA: 0x21890
        public void get_borderTopColor(){} // RVA: 0xC770
        public void get_borderTopLeftRadius(){} // RVA: 0x21890
        public void get_borderTopRightRadius(){} // RVA: 0x21890
        public void get_borderTopWidth(){} // RVA: 0x21890
        public void get_bottom(){} // RVA: 0x21890
        public void get_color(){} // RVA: 0xC770
        public void get_display(){} // RVA: 0xD840
        public void get_flexDirection(){} // RVA: 0xD840
        public void get_flexGrow(){} // RVA: 0x21890
        public void get_flexShrink(){} // RVA: 0x21890
        public void get_height(){} // RVA: 0x21890
        public void get_left(){} // RVA: 0x21890
        public void get_marginBottom(){} // RVA: 0x21890
        public void get_marginLeft(){} // RVA: 0x21890
        public void get_marginRight(){} // RVA: 0x21890
        public void get_marginTop(){} // RVA: 0x21890
        public void get_minHeight(){}
        public void get_minWidth(){}
        public void get_opacity(){} // RVA: 0x21890
        public void get_paddingBottom(){} // RVA: 0x21890
        public void get_paddingLeft(){} // RVA: 0x21890
        public void get_paddingRight(){} // RVA: 0x21890
        public void get_paddingTop(){} // RVA: 0x21890
        public void get_right(){} // RVA: 0x21890
        public void get_scale(){}
        public void get_top(){} // RVA: 0x21890
        public void get_transformOrigin(){} // RVA: 0xC770
        public void get_translate(){} // RVA: 0xC770
        public void get_unityBackgroundImageTintColor(){} // RVA: 0xC770
        public void get_unitySliceLeft(){} // RVA: 0xD840
        public void get_unitySliceRight(){} // RVA: 0xD840
        public void get_unitySliceScale(){} // RVA: 0x21890
        public void get_unityTextOutlineColor(){} // RVA: 0xC770
        public void get_unityTextOutlineWidth(){} // RVA: 0x21890
        public void get_visibility(){} // RVA: 0xD840
        public void get_width(){} // RVA: 0x21890
    }

    public class IRuntimePanelComponent
    {
        // ── Methods ──
        public void set_panel(){} // RVA: 0x24B10
    }

    public class IScheduler
    {
        // ── Methods ──
        public void Unschedule(){} // RVA: 0x24B10
        public void Schedule(){} // RVA: 0x24B10
        public void UpdateScheduledEvents(){} // RVA: 0x24A50
    }

    public class ISerializableJsonDictionary
    {
        // ── Methods ──
        public void Set(){} // RVA: 0x283FA0
        public void Get(){} // RVA: 0x283FA0
        public void Overwrite(){} // RVA: 0x2DC60
        public void ContainsKey(){} // RVA: 0xDE40
    }

    public class IStyle
    {
        public object 8̃e;
        public object .ctor;
        public object GetHashCode;
        public object IStyleValue`1;

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
        public void Copy(){} // RVA: 0x283FA0
        public void CopyFrom(){} // RVA: 0x24B10
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x263BC0
        public void CopyFrom(){} // RVA: 0x24B10
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x263BC0
        public void CopyFrom(){} // RVA: 0x24B10
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x263BC0
        public void CopyFrom(){} // RVA: 0x24B10
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x263BC0
        public void CopyFrom(){} // RVA: 0x24B10
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x263BC0
        public void CopyFrom(){} // RVA: 0x24B10
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x263BC0
        public void CopyFrom(){} // RVA: 0x24B10
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x263BC0
        public void CopyFrom(){} // RVA: 0x24B10
    }

    public class IStyleDataGroup`1
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x263BC0
        public void CopyFrom(){} // RVA: 0x24B10
    }

    public class IStylePainter
    {
        // ── Methods ──
        public void DrawText(){} // RVA: 0x24B10
        public void DrawRectangle(){}
        public void DrawImmediate(){} // RVA: 0x2A620
    }

    public class IStylePropertyAnimationSystem
    {
        // ── Methods ──
        public void StartTransition(){} // overloaded x15
        public void CancelAllAnimations(){} // RVA: 0x24B10 | overloaded x2
        public void CancelAnimation(){} // RVA: 0x2BAA0
        public void UpdateAnimation(){} // RVA: 0x2BAA0
        public void GetAllAnimations(){} // RVA: 0x2DC60
        public void Update(){} // RVA: 0x24A50
    }

    public class IStylePropertyAnimations
    {
        // ── Methods ──
        public void Start(){} // overloaded x15
        public void StartEnum(){}
        public void UpdateAnimation(){} // RVA: 0x24FA0
        public void GetAllAnimations(){} // RVA: 0x24B10
        public void CancelAnimation(){} // RVA: 0x24FA0
        public void CancelAllAnimations(){} // RVA: 0x24A50
        public void get_runningAnimationCount(){} // RVA: 0xD840
        public void set_runningAnimationCount(){} // RVA: 0x24FA0
        public void get_completedAnimationCount(){} // RVA: 0xD840
        public void set_completedAnimationCount(){} // RVA: 0x24FA0
    }

    public class IStyleValue`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x283FA0
        public void get_keyword(){} // RVA: 0xD840
    }

    public class IStyleValue`1
    {
    }

    public class IStyleValue`1
    {
    }

    public class IStyleValue`1
    {
    }

    public class IStyleValue`1
    {
    }

    public class IStyleValue`1
    {
    }

    public class IStyleValue`1
    {
    }

    public class IStyleValue`1
    {
    }

    public class IStyleValue`1
    {
    }

    public class IStyleValue`1
    {
    }

    public class IStyleValue`1
    {
    }

    public class IStyleValue`1
    {
    }

    public class IStyleValue`1
    {
    }

    public class IStyleValue`1
    {
    }

    public class IStyleValue`1
    {
    }

    public class ITextEdition
    {
        // ── Methods ──
        public void get_multiline(){} // RVA: 0xDBE0
        public void set_multiline(){} // RVA: 0x25130
        public void get_isReadOnly(){} // RVA: 0xDBE0
        public void set_isReadOnly(){} // RVA: 0x25130
        public void get_maxLength(){} // RVA: 0xD840
        public void set_maxLength(){} // RVA: 0x24FA0
        public void get_isDelayed(){} // RVA: 0xDBE0
        public void set_isDelayed(){} // RVA: 0x25130
        public void SaveValueAndText(){} // RVA: 0x24A50
        public void RestoreValueAndText(){} // RVA: 0x24A50
        public void get_AcceptCharacter(){} // RVA: 0xCD60
        public void set_AcceptCharacter(){} // RVA: 0x24B10
        public void get_UpdateScrollOffset(){} // RVA: 0xCD60
        public void set_UpdateScrollOffset(){} // RVA: 0x24B10
        public void get_UpdateValueFromText(){} // RVA: 0xCD60
        public void set_UpdateValueFromText(){} // RVA: 0x24B10
        public void get_UpdateTextFromValue(){} // RVA: 0xCD60
        public void set_UpdateTextFromValue(){} // RVA: 0x24B10
        public void get_MoveFocusToCompositeRoot(){} // RVA: 0xCD60
        public void set_MoveFocusToCompositeRoot(){} // RVA: 0x24B10
        public void UpdateText(){} // RVA: 0x24B10
        public void CullString(){} // RVA: 0xCE10
        public void set_maskChar(){} // RVA: 0x24C40
        public void get_isPassword(){} // RVA: 0xDBE0
        public void set_isPassword(){} // RVA: 0x25130
        public void get_autoCorrection(){} // RVA: 0x7483B80
        public void set_autoCorrection(){} // RVA: 0x7483C40
        public void get_hideMobileInput(){} // RVA: 0x7483D00
        public void set_hideMobileInput(){} // RVA: 0x7483DC0
        public void get_keyboardType(){} // RVA: 0x7483E80
        public void set_keyboardType(){} // RVA: 0x7483F40
    }

    public class ITextSelection
    {
        // ── Methods ──
        public void get_isSelectable(){} // RVA: 0xDBE0
        public void set_isSelectable(){} // RVA: 0x25130
        public void get_cursorColor(){} // RVA: 0xC770
        public void set_cursorColor(){} // RVA: 0x24B10
        public void get_cursorIndex(){} // RVA: 0xD840
        public void set_cursorIndex(){} // RVA: 0x24FA0
        public void get_doubleClickSelectsWord(){} // RVA: 0xDBE0
        public void get_selectIndex(){} // RVA: 0xD840
        public void set_selectIndex(){} // RVA: 0x24FA0
        public void get_selectionColor(){} // RVA: 0xC770
        public void set_selectionColor(){} // RVA: 0x24B10
        public void get_tripleClickSelectsLine(){} // RVA: 0xDBE0
        public void HasSelection(){} // RVA: 0xDBE0
        public void SelectAll(){} // RVA: 0x24A50
        public void SelectNone(){} // RVA: 0x24A50
        public void get_selectAllOnFocus(){} // RVA: 0xDBE0
        public void set_selectAllOnFocus(){} // RVA: 0x25130
        public void get_selectAllOnMouseUp(){} // RVA: 0xDBE0
        public void set_selectAllOnMouseUp(){} // RVA: 0x25130
        public void get_cursorPosition(){} // RVA: 0xCD60
        public void get_lineHeightAtCursorPosition(){} // RVA: 0x21890
        public void get_cursorWidth(){} // RVA: 0x21890
    }

    public class ITransform
    {
        // ── Methods ──
        public void get_position(){} // RVA: 0xC770
        public void set_position(){} // RVA: 0x24B10
        public void get_scale(){} // RVA: 0xC770
    }

}