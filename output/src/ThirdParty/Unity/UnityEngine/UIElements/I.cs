// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 66
// Methods: 542

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

    public class IUIElementsUtility
    {
        // ── Methods ──
        public void TakeCapture(){} // RVA: 0xDBE0
        public void ReleaseCapture(){} // RVA: 0xDBE0
        public void ProcessEvent(){}
        public void CleanupRoots(){} // RVA: 0xDBE0
        public void EndContainerGUIFromException(){} // RVA: 0xDE40
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0xDBE0
    }

    public class IUxmlAttributes
    {
        // ── Methods ──
        public void TryGetAttributeValue(){} // RVA: 0x11120
    }

    public class IUxmlFactory
    {
        // ── Methods ──
        public void Create(){}
    }

    public class IUxmlObjectFactory`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x283FA0
    }

    public class IValueField`1
    {
        // ── Methods ──
        public void get_value(){} // RVA: 0x283FA0
        public void set_value(){} // RVA: 0x283FA0
        public void ApplyInputDeviceDelta(){} // RVA: 0x283FA0
        public void StartDragging(){} // RVA: 0x24A50
        public void StopDragging(){} // RVA: 0x24A50
    }

    public class IVisualElementPanelActivatable
    {
        // ── Methods ──
        public void get_element(){} // RVA: 0xCD60
        public void CanBeActivated(){} // RVA: 0xDBE0
        public void OnPanelActivate(){} // RVA: 0x24A50
        public void OnPanelDeactivate(){} // RVA: 0x24A50
    }

    public class IVisualElementScheduledItem
    {
        // ── Methods ──
        public void Resume(){} // RVA: 0x24A50
        public void Pause(){} // RVA: 0x24A50
        public void ExecuteLater(){} // RVA: 0x24CC0
        public void StartingIn(){}
        public void Every(){}
    }

    public class IVisualElementScheduler
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0xCE10 | overloaded x2
    }

    public class IVisualTreeUpdater
    {
        // ── Methods ──
        public void set_panel(){} // RVA: 0x24B10
        public void get_profilerMarker(){}
        public void Update(){} // RVA: 0x24A50
        public void OnVersionChanged(){} // RVA: 0x2BAA0
    }

    public class Image
    {
        // ── Methods ──
        public void get_image(){} // RVA: 0xD8F1C0
        public void set_image(){} // RVA: 0x7320E10
        public void get_sprite(){} // RVA: 0xDA0010
        public void set_sprite(){} // RVA: 0x7321020
        public void get_vectorImage(){} // RVA: 0xD98840
        public void set_vectorImage(){} // RVA: 0x7321230
        public void get_sourceRect(){} // RVA: 0x7321440
        public void get_uv(){} // RVA: 0x7321470
        public void set_uv(){} // RVA: 0x7321480
        public void get_scaleMode(){} // RVA: 0x73214E0
        public void get_tintColor(){} // RVA: 0x73214F0
        public void .ctor(){} // RVA: 0x7321500
        public void GetTextureDisplaySize(){} // RVA: 0x73218A0 | overloaded x2
        public void DoMeasure(){} // RVA: 0x7321AE0
        public void OnGenerateVisualContent(){} // RVA: 0x7321F90
        public void OnCustomStyleResolved(){} // RVA: 0x73227B0
        public void ReadCustomProperties(){} // RVA: 0x73227F0
        public void SetProperty(){} // RVA: 0x283FA0
        public void ClearProperty(){} // RVA: 0x7322E30
        public void SetScaleMode(){} // RVA: 0x7322E80
        public void SetTintColor(){} // RVA: 0x7322ED0
        public void GetSourceRect(){} // RVA: 0x7322F80
        public void .cctor(){} // RVA: 0x7323240
    }

    public class ImmediateModeException
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x740D040
    }

    public class InheritedData
    {
        // ── Methods ──
        public void Copy(){} // RVA: 0x745DD70
        public void CopyFrom(){} // RVA: 0x745DDC0
        public void op_Equality(){} // RVA: 0x745DE80
        public void Equals(){} // RVA: 0x745E650 | overloaded x2
        public void GetHashCode(){} // RVA: 0x745E760
    }

    public class InlineStyleAccess : GetStyleLength
    {
        // ── Methods ──
        public void UnityEngine.UIElements.IStyle.set_backgroundColor(){} // RVA: 0x7441720
        public void UnityEngine.UIElements.IStyle.set_borderBottomColor(){} // RVA: 0x7441790
        public void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(){} // RVA: 0x7441800
        public void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(){} // RVA: 0x7441870
        public void UnityEngine.UIElements.IStyle.set_borderBottomWidth(){} // RVA: 0x74418E0
        public void UnityEngine.UIElements.IStyle.set_borderLeftColor(){} // RVA: 0x74419A0
        public void UnityEngine.UIElements.IStyle.set_borderLeftWidth(){} // RVA: 0x7441A10
        public void UnityEngine.UIElements.IStyle.set_borderRightColor(){} // RVA: 0x7441AD0
        public void UnityEngine.UIElements.IStyle.set_borderRightWidth(){} // RVA: 0x7441B40
        public void UnityEngine.UIElements.IStyle.set_borderTopColor(){} // RVA: 0x7441C00
        public void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(){} // RVA: 0x7441C70
        public void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(){} // RVA: 0x7441CE0
        public void UnityEngine.UIElements.IStyle.set_borderTopWidth(){} // RVA: 0x7441D50
        public void UnityEngine.UIElements.IStyle.set_bottom(){} // RVA: 0x7441E10
        public void UnityEngine.UIElements.IStyle.set_color(){} // RVA: 0x7441EF0
        public void UnityEngine.UIElements.IStyle.get_display(){} // RVA: 0x7441F60
        public void UnityEngine.UIElements.IStyle.set_display(){} // RVA: 0x7442020
        public void UnityEngine.UIElements.IStyle.set_flexBasis(){} // RVA: 0x7442150
        public void UnityEngine.UIElements.IStyle.set_flexDirection(){} // RVA: 0x7442230
        public void UnityEngine.UIElements.IStyle.set_flexGrow(){} // RVA: 0x7442360
        public void UnityEngine.UIElements.IStyle.set_flexShrink(){} // RVA: 0x7442420
        public void UnityEngine.UIElements.IStyle.set_fontSize(){} // RVA: 0x74424E0
        public void UnityEngine.UIElements.IStyle.set_height(){} // RVA: 0x7442550
        public void UnityEngine.UIElements.IStyle.set_left(){} // RVA: 0x7442630
        public void UnityEngine.UIElements.IStyle.set_marginBottom(){} // RVA: 0x7442710
        public void UnityEngine.UIElements.IStyle.set_marginLeft(){} // RVA: 0x74427F0
        public void UnityEngine.UIElements.IStyle.set_marginRight(){} // RVA: 0x74428D0
        public void UnityEngine.UIElements.IStyle.set_marginTop(){} // RVA: 0x74429B0
        public void UnityEngine.UIElements.IStyle.set_maxHeight(){} // RVA: 0x7442AA0
        public void UnityEngine.UIElements.IStyle.set_maxWidth(){} // RVA: 0x7442B80
        public void UnityEngine.UIElements.IStyle.set_minWidth(){} // RVA: 0x7442C60
        public void UnityEngine.UIElements.IStyle.set_opacity(){} // RVA: 0x7442D40
        public void UnityEngine.UIElements.IStyle.set_overflow(){} // RVA: 0x7442DA0
        public void UnityEngine.UIElements.IStyle.set_paddingBottom(){} // RVA: 0x7442F20
        public void UnityEngine.UIElements.IStyle.set_paddingLeft(){} // RVA: 0x7443010
        public void UnityEngine.UIElements.IStyle.set_paddingRight(){} // RVA: 0x74430F0
        public void UnityEngine.UIElements.IStyle.get_paddingTop(){} // RVA: 0x74431E0
        public void UnityEngine.UIElements.IStyle.set_paddingTop(){} // RVA: 0x7443270
        public void UnityEngine.UIElements.IStyle.set_position(){} // RVA: 0x7443360
        public void UnityEngine.UIElements.IStyle.set_right(){} // RVA: 0x7443490
        public void UnityEngine.UIElements.IStyle.set_top(){} // RVA: 0x7443580
        public void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(){} // RVA: 0x7443670
        public void UnityEngine.UIElements.IStyle.set_unityFont(){} // RVA: 0x74436E0
        public void UnityEngine.UIElements.IStyle.set_unityFontDefinition(){} // RVA: 0x7443750
        public void UnityEngine.UIElements.IStyle.set_visibility(){} // RVA: 0x74437D0
        public void UnityEngine.UIElements.IStyle.get_width(){} // RVA: 0x7443860
        public void UnityEngine.UIElements.IStyle.set_width(){} // RVA: 0x74438F0
        public void get_ve(){} // RVA: 0x30B0C0
        public void set_ve(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x74439D0
        public void Finalize(){} // RVA: 0x7443A40
        public void SetInlineRule(){} // RVA: 0x7443B80
        public void IsValueSet(){} // RVA: 0x7443DD0
        public void ApplyInlineStyles(){} // RVA: 0x74441B0
        public void UnityEngine.UIElements.IStyle.get_cursor(){} // RVA: 0x74451B0
        public void UnityEngine.UIElements.IStyle.get_textShadow(){} // RVA: 0x74452F0
        public void UnityEngine.UIElements.IStyle.get_backgroundSize(){} // RVA: 0x7445360
        public void UnityEngine.UIElements.IStyle.get_transformOrigin(){} // RVA: 0x74453C0
        public void UnityEngine.UIElements.IStyle.get_translate(){} // RVA: 0x7445410
        public void UnityEngine.UIElements.IStyle.set_translate(){} // RVA: 0x7445470
        public void UnityEngine.UIElements.IStyle.get_rotate(){} // RVA: 0x74456E0
        public void UnityEngine.UIElements.IStyle.get_scale(){} // RVA: 0x7445740
        public void SetStyleValue(){} // RVA: 0x7446140 | overloaded x6
        public void SetInlineTranslate(){} // RVA: 0x7446440
        public void ApplyStyleTranslate(){} // RVA: 0x7446600
        public void ApplyStyleValue(){} // RVA: 0x7446A30
        public void RemoveInlineStyle(){} // RVA: 0x7446D50
        public void ApplyFromComputedStyle(){} // RVA: 0x7446EA0
        public void TryGetInlineCursor(){} // RVA: 0x74470B0
        public void TryGetInlineTextShadow(){} // RVA: 0x7447120
        public void TryGetInlineTransformOrigin(){} // RVA: 0x7447140
        public void TryGetInlineTranslate(){} // RVA: 0x7447160
        public void TryGetInlineRotate(){} // RVA: 0x7447190
        public void TryGetInlineScale(){} // RVA: 0x74471C0
        public void TryGetInlineBackgroundSize(){} // RVA: 0x74471F0
        public void .cctor(){} // RVA: 0x7447220
    }

    public class InputEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73EC3D0
        public void set_previousData(){} // RVA: 0x463060
        public void set_newData(){} // RVA: 0xB54600
        public void Init(){} // RVA: 0x73EC4C0
        public void LocalInit(){} // RVA: 0x73EC580
        public void GetPooled(){} // RVA: 0x73EC640
        public void .ctor(){} // RVA: 0x73EC770
    }

    public class IntegerField
    {
        // ── Methods ──
        public void get_integerInput(){} // RVA: 0x73A5AD0
        public void ValueToString(){} // RVA: 0x73A5B60
        public void StringToValue(){} // RVA: 0x73A5D70
        public void .ctor(){} // RVA: 0x73A5EC0 | overloaded x2
        public void CanTryParse(){} // RVA: 0x73A6300
        public void ApplyInputDeviceDelta(){} // RVA: 0x73A63D0
        public void .cctor(){} // RVA: 0x73A64C0
    }

}