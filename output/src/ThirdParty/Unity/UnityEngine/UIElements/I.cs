// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 66
// Methods: 542

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class IBaseUxmlFactory
    {
        public object uxmlQualifiedName;
        public object uxmlType;

        // ── Methods ──
        public void get_uxmlQualifiedName(){} // RVA: 0x7FFAC2C58E90
        public void get_uxmlType(){} // RVA: 0x7FFAC2C58E90
        public void AcceptsAttributeBag(){}
    }

    public class IBaseUxmlObjectFactory
    {
    }

    public class IBindable
    {
        public object binding;
        public object bindingPath;

        // ── Methods ──
        public void get_binding(){} // RVA: 0x7FFAC2C58E90
        public void set_bindingPath(){} // RVA: 0x7FFAC2C70A40
    }

    public class IBinding
    {
        // ── Methods ──
        public void PreUpdate(){} // RVA: 0x7FFAC2C70980
        public void Update(){} // RVA: 0x7FFAC2C70980
        public void Release(){} // RVA: 0x7FFAC2C70980
    }

    public class IBindingRequest
    {
        // ── Methods ──
        public void Bind(){} // RVA: 0x7FFAC2C70A40
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
        public void ResetCursor(){} // RVA: 0x7FFAC2C70980
    }

    public class ICustomStyle
    {
        // ── Methods ──
        public void TryGetValue(){} // overloaded x7
    }

    public class IDragAndDrop
    {
        public object data;

        // ── Methods ──
        public void StartDrag(){}
        public void UpdateDrag(){} // RVA: 0x7FFAC2C70A40
        public void AcceptDrag(){} // RVA: 0x7FFAC2C70980
        public void DragCleanup(){} // RVA: 0x7FFAC2C70980
        public void SetVisualMode(){} // RVA: 0x7FFAC2C70ED0
        public void get_data(){} // RVA: 0x7FFAC2C58E90
    }

    public class IDragAndDropController`1
    {
        // ── Methods ──
        public void CanStartDrag(){} // RVA: 0x7FFAC2C59F60
        public void SetupDragAndDrop(){}
        public void HandleDragAndDrop(){} // RVA: 0x7FFAC2E8DC40
        public void OnDrop(){} // RVA: 0x7FFAC2E8DC40
        public void DragCleanup(){} // RVA: 0x7FFAC2C70980
        public void HandleAutoExpand(){}
        public void GetSortedSelectedIds(){} // RVA: 0x7FFAC2C58E90
    }

    public class IEditableElement
    {
        public object editingStarted;
        public object editingEnded;

        // ── Methods ──
        public void get_editingStarted(){} // RVA: 0x7FFAC2C58E90
        public void get_editingEnded(){} // RVA: 0x7FFAC2C58E90
    }

    public class IEnumerableExtensions : Object
    {
        // ── Methods ──
        public void HasValues(){} // RVA: 0x7FFAC9B9E400
    }

    public class IEventDispatchingStrategy
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFAC2C59F60
        public void DispatchEvent(){} // RVA: 0x7FFAC2C79B30
    }

    public class IEventHandler
    {
        // ── Methods ──
        public void SendEvent(){} // RVA: 0x7FFAC2C70A40
        public void HandleEvent(){} // RVA: 0x7FFAC2C70A40
    }

    public class IExperimentalFeatures
    {
        public object animation;

        // ── Methods ──
        public void get_animation(){} // RVA: 0x7FFAC2C58E90
    }

    public class IFocusRing
    {
        // ── Methods ──
        public void GetFocusChangeDirection(){} // RVA: 0x7FFAC2C6A6F0
        public void GetNextFocusable(){} // RVA: 0x7FFAC2C6A6F0
    }

    public class IGenericMenu
    {
        // ── Methods ──
        public void AddItem(){} // RVA: 0x7FFAC2C76BD0 | overloaded x2
        public void DropDown(){}
    }

    public class IGroupBox
    {
        // ── Methods ──
        public void OnOptionAdded(){} // RVA: 0x7FFAC2C70A40
        public void OnOptionRemoved(){} // RVA: 0x7FFAC2C70A40
    }

    public class IGroupBoxOption
    {
        // ── Methods ──
        public void SetSelected(){} // RVA: 0x7FFAC2C71060
    }

    public class IGroupBox`1
    {
    }

    public class IGroupManager
    {
        // ── Methods ──
        public void Init(){} // RVA: 0x7FFAC2C70A40
        public void OnOptionSelectionChanged(){} // RVA: 0x7FFAC2C70A40
        public void RegisterOption(){} // RVA: 0x7FFAC2C70A40
        public void UnregisterOption(){} // RVA: 0x7FFAC2C70A40
    }

    public class IKeyboardEvent
    {
        public object modifiers;
        public object character;
        public object keyCode;

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7FFAC2C59960
        public void get_character(){} // RVA: 0x7FFAC2C58DC0
        public void get_keyCode(){} // RVA: 0x7FFAC2C59960
    }

    public class IListDragAndDropArgs
    {
        public object insertAtIndex;
        public object parentId;
        public object childIndex;
        public object dragAndDropData;
        public object dragAndDropPosition;

        // ── Methods ──
        public void get_insertAtIndex(){} // RVA: 0x7FFAC2C59960
        public void get_parentId(){} // RVA: 0x7FFAC2C59960
        public void get_childIndex(){} // RVA: 0x7FFAC2C59960
        public void get_dragAndDropData(){} // RVA: 0x7FFAC2C58E90
        public void get_dragAndDropPosition(){} // RVA: 0x7FFAC2C59960
    }

    public class IMGUIContainer : VisualElement
    {
        public System.Action onGUIHandler; // 0x3C8
        public UnityEngine.ObjectGUIState guiState; // 0x3D0
        public bool lastWorldClip; // 0x3D8
        public UnityEngine.Rect cullingEnabled; // 0x3DC
        public bool cache; // 0x3EC
        public bool layoutMeasuredWidth; // 0x3ED
        public bool layoutMeasuredHeight; // 0x3EE
        public LayoutCache contextType; // 0x3F0
        public UnityEngine.Rect focusOnlyIfHasFocusableControls; // 0x3F8
        public UnityEngine.Matrix4x4 canGrabFocus; // 0x408
        public 0x6B11FED0 <contextType>k__BackingField; // 0x448
        public bool lostFocus; // 0x44C
        public bool receivedFocus; // 0x44D
        public UnityEngine.UIElements.FocusChangeDirection focusChangeDirection; // 0x450
        public bool hasFocusableControls; // 0x458
        public int newKeyboardFocusControlID; // 0x45C
        public bool <focusOnlyIfHasFocusableControls>k__BackingField; // 0x460
        public string ussClassName;
        public string ussFoldoutChildDepthClassName; // 0x8
        public System.Collections.Generic.List`1<string> ussFoldoutChildDepthClassNames; // 0x10
        public GUIGlobals m_GUIGlobals; // 0x464
        public Unity.Profiling.ProfilerMarker k_OnGUIMarker; // 0x18
        public Unity.Profiling.ProfilerMarker k_ImmediateCallbackMarker; // 0x20
        public UnityEngine.Event s_DefaultMeasureEvent; // 0x28
        public UnityEngine.Event s_MeasureEvent; // 0x30
        public UnityEngine.Event s_CurrentEvent; // 0x38

        // ── Methods ──
        public void get_onGUIHandler(){} // RVA: 0x7FFAC9B9EA40
        public void set_onGUIHandler(){} // RVA: 0x7FFAC9B9EA50
        public void get_guiState(){} // RVA: 0x7FFAC9B9EB50
        public void get_lastWorldClip(){} // RVA: 0x7FFAC9B9EC80
        public void set_lastWorldClip(){} // RVA: 0x7FFAC9B9EC90
        public void get_cullingEnabled(){} // RVA: 0x7FFAC9B9ECA0
        public void get_cache(){} // RVA: 0x7FFAC9B9ECB0
        public void get_layoutMeasuredWidth(){} // RVA: 0x7FFAC9B9ED70
        public void get_layoutMeasuredHeight(){} // RVA: 0x7FFAC9B9EDA0
        public void get_contextType(){} // RVA: 0x7FFAC9B9EDD0
        public void set_contextType(){} // RVA: 0x7FFAC9B9EDE0
        public void get_focusOnlyIfHasFocusableControls(){} // RVA: 0x7FFAC9B9EDF0
        public void get_canGrabFocus(){} // RVA: 0x7FFAC9B9EE00
        public void .cctor(){} // RVA: 0x7FFAC9B9EE30
        public void .ctor(){} // RVA: 0x7FFAC9B9F6D0 | overloaded x2
        public void OnGenerateVisualContent(){} // RVA: 0x7FFAC9B9FB50
        public void SaveGlobals(){} // RVA: 0x7FFAC9B9FCB0
        public void RestoreGlobals(){} // RVA: 0x7FFAC9BA0090
        public void DoOnGUI(){} // RVA: 0x7FFAC9BA0490
        public void MarkDirtyLayout(){} // RVA: 0x7FFAC9BA1F30
        public void ProcessEvent(){} // RVA: 0x7FFAC9BA1F70
        public void DoIMGUIRepaint(){} // RVA: 0x7FFAC9BA2120
        public void SendEventToIMGUI(){} // RVA: 0x7FFAC9BA2490
        public void SendEventToIMGUIRaw(){} // RVA: 0x7FFAC9BA27C0
        public void VerifyBounds(){} // RVA: 0x7FFAC9BA2880
        public void IsContainerCapturingTheMouse(){} // RVA: 0x7FFAC9BA2AE0
        public void IsLocalEvent(){} // RVA: 0x7FFAC9BA2BB0
        public void IsEventInsideLocalWindow(){} // RVA: 0x7FFAC9BA2DD0
        public void IsDockAreaMouseUp(){} // RVA: 0x7FFAC9BA3020
        public void HandleIMGUIEvent(){} // RVA: 0x7FFAC9BA34E0 | overloaded x3
        public void ExecuteDefaultAction(){} // RVA: 0x7FFAC9BA3A80
        public void SetFoldoutDepthClass(){} // RVA: 0x7FFAC9BA3DF0
        public void DoMeasure(){} // RVA: 0x7FFAC9BA3FB0
        public void GetCurrentClipRect(){} // RVA: 0x7FFAC9BA4450
        public void GetCurrentTransformAndClip(){} // RVA: 0x7FFAC9BA44D0
        public void Dispose(){} // RVA: 0x7FFAC9BA47C0 | overloaded x2
        public void <DoOnGUI>b__56_0(){} // RVA: 0x7FFAC9BA4840
    }

    public class IMGUIEvent : EventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B92BF0
        public void GetPooled(){} // RVA: 0x7FFAC9B92CE0
        public void Init(){} // RVA: 0x7FFAC9B92D70
        public void LocalInit(){} // RVA: 0x7FFAC9B87830
        public void .ctor(){} // RVA: 0x7FFAC9B92E30
    }

    public class IMGUIEventDispatchingStrategy : Object
    {
        // ── Methods ──
        public void CanDispatchEvent(){} // RVA: 0x7FFAC9B83BB0
        public void DispatchEvent(){} // RVA: 0x7FFAC9B83C40
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class IManipulator
    {
        public object target;

        // ── Methods ──
        public void set_target(){} // RVA: 0x7FFAC2C70A40
    }

    public class IMouseEvent
    {
        public object modifiers;
        public object mousePosition;
        public object localMousePosition;
        public object mouseDelta;
        public object clickCount;
        public object button;
        public object pressedButtons;
        public object shiftKey;
        public object ctrlKey;
        public object commandKey;
        public object altKey;

        // ── Methods ──
        public void get_modifiers(){} // RVA: 0x7FFAC2C59960
        public void get_mousePosition(){} // RVA: 0x7FFAC2C58E90
        public void get_localMousePosition(){} // RVA: 0x7FFAC2C58E90
        public void get_mouseDelta(){} // RVA: 0x7FFAC2C58E90
        public void get_clickCount(){} // RVA: 0x7FFAC2C59960
        public void get_button(){} // RVA: 0x7FFAC2C59960
        public void get_pressedButtons(){} // RVA: 0x7FFAC2C59960
        public void get_shiftKey(){} // RVA: 0x7FFAC2C59D00
        public void get_ctrlKey(){} // RVA: 0x7FFAC2C59D00
        public void get_commandKey(){} // RVA: 0x7FFAC2C59D00
        public void get_altKey(){} // RVA: 0x7FFAC2C59D00
    }

    public class IMouseEventInternal
    {
        public object triggeredByOS;
        public object recomputeTopElementUnderMouse;
        public object sourcePointerEvent;

        // ── Methods ──
        public void get_triggeredByOS(){} // RVA: 0x7FFAC2C59D00
        public void set_triggeredByOS(){} // RVA: 0x7FFAC2C71060
        public void get_recomputeTopElementUnderMouse(){} // RVA: 0x7FFAC2C59D00
        public void set_recomputeTopElementUnderMouse(){} // RVA: 0x7FFAC2C71060
        public void get_sourcePointerEvent(){} // RVA: 0x7FFAC2C58E90
        public void set_sourcePointerEvent(){} // RVA: 0x7FFAC2C70A40
    }

    public class INavigationEvent
    {
        public object shiftKey;
        public object altKey;

        // ── Methods ──
        public void get_shiftKey(){} // RVA: 0x7FFAC2C59D00
        public void get_altKey(){} // RVA: 0x7FFAC2C59D00
    }

    public class INotifyValueChangedExtensions : Object
    {
        // ── Methods ──
        public void RegisterValueChangedCallback(){} // RVA: 0x7FFAC2C5A350
        public void UnregisterValueChangedCallback(){} // RVA: 0x7FFAC2C5A350
    }

    public class INotifyValueChanged`1
    {
        public object value;

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC2E8DC40
        public void set_value(){} // RVA: 0x7FFAC2E8DC40
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IPanel
    {
        public object visualTree;
        public object dispatcher;
        public object contextType;
        public object focusController;

        // ── Methods ──
        public void get_visualTree(){} // RVA: 0x7FFAC2C58E90
        public void get_dispatcher(){} // RVA: 0x7FFAC2C58E90
        public void get_contextType(){} // RVA: 0x7FFAC2C59960
        public void get_focusController(){} // RVA: 0x7FFAC2C58E90
        public void Pick(){}
    }

    public class IPointerCaptureEventInternal
    {
        public object pointerId;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0x7FFAC2C59960
    }

    public class IPointerEvent
    {
        public object pointerId;
        public object pointerType;
        public object isPrimary;
        public object button;
        public object pressedButtons;
        public object position;
        public object localPosition;
        public object deltaPosition;
        public object deltaTime;
        public object clickCount;
        public object pressure;
        public object tangentialPressure;
        public object altitudeAngle;
        public object azimuthAngle;
        public object twist;
        public object tilt;
        public object penStatus;
        public object radius;
        public object radiusVariance;
        public object modifiers;
        public object shiftKey;
        public object ctrlKey;
        public object commandKey;
        public object altKey;
        public object actionKey;

        // ── Methods ──
        public void get_pointerId(){} // RVA: 0x7FFAC2C59960
        public void get_pointerType(){} // RVA: 0x7FFAC2C58E90
        public void get_isPrimary(){} // RVA: 0x7FFAC2C59D00
        public void get_button(){} // RVA: 0x7FFAC2C59960
        public void get_pressedButtons(){} // RVA: 0x7FFAC2C59960
        public void get_position(){} // RVA: 0x7FFAC2C588A0
        public void get_localPosition(){} // RVA: 0x7FFAC2C588A0
        public void get_deltaPosition(){} // RVA: 0x7FFAC2C588A0
        public void get_deltaTime(){} // RVA: 0x7FFAC2C6D880
        public void get_clickCount(){} // RVA: 0x7FFAC2C59960
        public void get_pressure(){} // RVA: 0x7FFAC2C6D880
        public void get_tangentialPressure(){} // RVA: 0x7FFAC2C6D880
        public void get_altitudeAngle(){} // RVA: 0x7FFAC2C6D880
        public void get_azimuthAngle(){} // RVA: 0x7FFAC2C6D880
        public void get_twist(){} // RVA: 0x7FFAC2C6D880
        public void get_tilt(){} // RVA: 0x7FFAC2C58E90
        public void get_penStatus(){} // RVA: 0x7FFAC2C59960
        public void get_radius(){} // RVA: 0x7FFAC2C58E90
        public void get_radiusVariance(){} // RVA: 0x7FFAC2C58E90
        public void get_modifiers(){} // RVA: 0x7FFAC2C59960
        public void get_shiftKey(){} // RVA: 0x7FFAC2C59D00
        public void get_ctrlKey(){} // RVA: 0x7FFAC2C59D00
        public void get_commandKey(){} // RVA: 0x7FFAC2C59D00
        public void get_altKey(){} // RVA: 0x7FFAC2C59D00
        public void get_actionKey(){} // RVA: 0x7FFAC2C59D00
    }

    public class IPointerEventInternal
    {
        public object triggeredByOS;
        public object recomputeTopElementUnderPointer;

        // ── Methods ──
        public void get_triggeredByOS(){} // RVA: 0x7FFAC2C59D00
        public void set_triggeredByOS(){} // RVA: 0x7FFAC2C71060
        public void get_recomputeTopElementUnderPointer(){} // RVA: 0x7FFAC2C59D00
        public void set_recomputeTopElementUnderPointer(){} // RVA: 0x7FFAC2C71060
    }

    public class IReorderable
    {
        public object enableReordering;

        // ── Methods ──
        public void get_enableReordering(){} // RVA: 0x7FFAC2C59D00
        public void set_enableReordering(){} // RVA: 0x7FFAC2C71060
    }

    public class IResolvedStyle
    {
        public object backgroundColor;
        public object borderBottomColor;
        public object borderBottomLeftRadius;
        public object borderBottomRightRadius;
        public object borderBottomWidth;
        public object borderLeftColor;
        public object borderLeftWidth;
        public object borderRightColor;
        public object borderRightWidth;
        public object borderTopColor;
        public object borderTopLeftRadius;
        public object borderTopRightRadius;
        public object borderTopWidth;
        public object bottom;
        public object color;
        public object display;
        public object flexDirection;
        public object flexGrow;
        public object flexShrink;
        public object height;
        public object left;
        public object marginBottom;
        public object marginLeft;
        public object marginRight;
        public object marginTop;
        public object minHeight;
        public object minWidth;
        public object opacity;
        public object paddingBottom;
        public object paddingLeft;
        public object paddingRight;
        public object paddingTop;
        public object right;
        public object scale;
        public object top;
        public object transformOrigin;
        public object translate;
        public object unityBackgroundImageTintColor;
        public object unitySliceLeft;
        public object unitySliceRight;
        public object unitySliceScale;
        public object unityTextOutlineColor;
        public object unityTextOutlineWidth;
        public object visibility;
        public object width;

        // ── Methods ──
        public void get_backgroundColor(){} // RVA: 0x7FFAC2C588A0
        public void get_borderBottomColor(){} // RVA: 0x7FFAC2C588A0
        public void get_borderBottomLeftRadius(){} // RVA: 0x7FFAC2C6D880
        public void get_borderBottomRightRadius(){} // RVA: 0x7FFAC2C6D880
        public void get_borderBottomWidth(){} // RVA: 0x7FFAC2C6D880
        public void get_borderLeftColor(){} // RVA: 0x7FFAC2C588A0
        public void get_borderLeftWidth(){} // RVA: 0x7FFAC2C6D880
        public void get_borderRightColor(){} // RVA: 0x7FFAC2C588A0
        public void get_borderRightWidth(){} // RVA: 0x7FFAC2C6D880
        public void get_borderTopColor(){} // RVA: 0x7FFAC2C588A0
        public void get_borderTopLeftRadius(){} // RVA: 0x7FFAC2C6D880
        public void get_borderTopRightRadius(){} // RVA: 0x7FFAC2C6D880
        public void get_borderTopWidth(){} // RVA: 0x7FFAC2C6D880
        public void get_bottom(){} // RVA: 0x7FFAC2C6D880
        public void get_color(){} // RVA: 0x7FFAC2C588A0
        public void get_display(){} // RVA: 0x7FFAC2C59960
        public void get_flexDirection(){} // RVA: 0x7FFAC2C59960
        public void get_flexGrow(){} // RVA: 0x7FFAC2C6D880
        public void get_flexShrink(){} // RVA: 0x7FFAC2C6D880
        public void get_height(){} // RVA: 0x7FFAC2C6D880
        public void get_left(){} // RVA: 0x7FFAC2C6D880
        public void get_marginBottom(){} // RVA: 0x7FFAC2C6D880
        public void get_marginLeft(){} // RVA: 0x7FFAC2C6D880
        public void get_marginRight(){} // RVA: 0x7FFAC2C6D880
        public void get_marginTop(){} // RVA: 0x7FFAC2C6D880
        public void get_minHeight(){}
        public void get_minWidth(){}
        public void get_opacity(){} // RVA: 0x7FFAC2C6D880
        public void get_paddingBottom(){} // RVA: 0x7FFAC2C6D880
        public void get_paddingLeft(){} // RVA: 0x7FFAC2C6D880
        public void get_paddingRight(){} // RVA: 0x7FFAC2C6D880
        public void get_paddingTop(){} // RVA: 0x7FFAC2C6D880
        public void get_right(){} // RVA: 0x7FFAC2C6D880
        public void get_scale(){}
        public void get_top(){} // RVA: 0x7FFAC2C6D880
        public void get_transformOrigin(){} // RVA: 0x7FFAC2C588A0
        public void get_translate(){} // RVA: 0x7FFAC2C588A0
        public void get_unityBackgroundImageTintColor(){} // RVA: 0x7FFAC2C588A0
        public void get_unitySliceLeft(){} // RVA: 0x7FFAC2C59960
        public void get_unitySliceRight(){} // RVA: 0x7FFAC2C59960
        public void get_unitySliceScale(){} // RVA: 0x7FFAC2C6D880
        public void get_unityTextOutlineColor(){} // RVA: 0x7FFAC2C588A0
        public void get_unityTextOutlineWidth(){} // RVA: 0x7FFAC2C6D880
        public void get_visibility(){} // RVA: 0x7FFAC2C59960
        public void get_width(){} // RVA: 0x7FFAC2C6D880
    }

    public class IRuntimePanelComponent
    {
        public object panel;

        // ── Methods ──
        public void set_panel(){} // RVA: 0x7FFAC2C70A40
    }

    public class IScheduler
    {
        // ── Methods ──
        public void Unschedule(){} // RVA: 0x7FFAC2C70A40
        public void Schedule(){} // RVA: 0x7FFAC2C70A40
        public void UpdateScheduledEvents(){} // RVA: 0x7FFAC2C70980
    }

    public class ISerializableJsonDictionary
    {
        // ── Methods ──
        public void Set(){} // RVA: 0x7FFAC2E8DC40
        public void Get(){} // RVA: 0x7FFAC2E8DC40
        public void Overwrite(){} // RVA: 0x7FFAC2C79B30
        public void ContainsKey(){} // RVA: 0x7FFAC2C59F60
    }

    public class IStyle
    {
        public object backgroundColor;
        public object backgroundSize;
        public object borderBottomColor;
        public object borderBottomLeftRadius;
        public object borderBottomRightRadius;
        public object borderBottomWidth;
        public object borderLeftColor;
        public object borderLeftWidth;
        public object borderRightColor;
        public object borderRightWidth;
        public object borderTopColor;
        public object borderTopLeftRadius;
        public object borderTopRightRadius;
        public object borderTopWidth;
        public object bottom;
        public object color;
        public object cursor;
        public object display;
        public object flexBasis;
        public object flexDirection;
        public object flexGrow;
        public object flexShrink;
        public object fontSize;
        public object height;
        public object left;
        public object marginBottom;
        public object marginLeft;
        public object marginRight;
        public object marginTop;
        public object maxHeight;
        public object maxWidth;
        public object minWidth;
        public object opacity;
        public object overflow;
        public object paddingBottom;
        public object paddingLeft;
        public object paddingRight;
        public object paddingTop;
        public object position;
        public object right;
        public object rotate;
        public object scale;
        public object textShadow;
        public object top;
        public object transformOrigin;
        public object translate;
        public object unityBackgroundImageTintColor;
        public object unityFont;
        public object unityFontDefinition;
        public object visibility;
        public object width;

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
        public void Copy(){} // RVA: 0x7FFAC2E8DC40
        public void CopyFrom(){} // RVA: 0x7FFAC2C70A40
    }

    public class IStylePainter
    {
        // ── Methods ──
        public void DrawText(){} // RVA: 0x7FFAC2C70A40
        public void DrawRectangle(){}
        public void DrawImmediate(){} // RVA: 0x7FFAC2C76500
    }

    public class IStylePropertyAnimationSystem
    {
        // ── Methods ──
        public void StartTransition(){} // overloaded x15
        public void CancelAllAnimations(){} // RVA: 0x7FFAC2C70A40 | overloaded x2
        public void CancelAnimation(){} // RVA: 0x7FFAC2C77970
        public void UpdateAnimation(){} // RVA: 0x7FFAC2C77970
        public void GetAllAnimations(){} // RVA: 0x7FFAC2C79B30
        public void Update(){} // RVA: 0x7FFAC2C70980
    }

    public class IStylePropertyAnimations
    {
        public object runningAnimationCount;
        public object completedAnimationCount;

        // ── Methods ──
        public void Start(){} // overloaded x15
        public void StartEnum(){}
        public void UpdateAnimation(){} // RVA: 0x7FFAC2C70ED0
        public void GetAllAnimations(){} // RVA: 0x7FFAC2C70A40
        public void CancelAnimation(){} // RVA: 0x7FFAC2C70ED0
        public void CancelAllAnimations(){} // RVA: 0x7FFAC2C70980
        public void get_runningAnimationCount(){} // RVA: 0x7FFAC2C59960
        public void set_runningAnimationCount(){} // RVA: 0x7FFAC2C70ED0
        public void get_completedAnimationCount(){} // RVA: 0x7FFAC2C59960
        public void set_completedAnimationCount(){} // RVA: 0x7FFAC2C70ED0
    }

    public class IStyleValue`1
    {
        public object value;
        public object keyword;

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC2E8DC40
        public void get_keyword(){} // RVA: 0x7FFAC2C59960
    }

    public class ITextEdition
    {
        public object multiline;
        public object isReadOnly;
        public object maxLength;
        public object isDelayed;
        public object AcceptCharacter;
        public object UpdateScrollOffset;
        public object UpdateValueFromText;
        public object UpdateTextFromValue;
        public object MoveFocusToCompositeRoot;
        public object maskChar;
        public object isPassword;
        public object autoCorrection;
        public object hideMobileInput;
        public object keyboardType;

        // ── Methods ──
        public void get_multiline(){} // RVA: 0x7FFAC2C59D00
        public void set_multiline(){} // RVA: 0x7FFAC2C71060
        public void get_isReadOnly(){} // RVA: 0x7FFAC2C59D00
        public void set_isReadOnly(){} // RVA: 0x7FFAC2C71060
        public void get_maxLength(){} // RVA: 0x7FFAC2C59960
        public void set_maxLength(){} // RVA: 0x7FFAC2C70ED0
        public void get_isDelayed(){} // RVA: 0x7FFAC2C59D00
        public void set_isDelayed(){} // RVA: 0x7FFAC2C71060
        public void SaveValueAndText(){} // RVA: 0x7FFAC2C70980
        public void RestoreValueAndText(){} // RVA: 0x7FFAC2C70980
        public void get_AcceptCharacter(){} // RVA: 0x7FFAC2C58E90
        public void set_AcceptCharacter(){} // RVA: 0x7FFAC2C70A40
        public void get_UpdateScrollOffset(){} // RVA: 0x7FFAC2C58E90
        public void set_UpdateScrollOffset(){} // RVA: 0x7FFAC2C70A40
        public void get_UpdateValueFromText(){} // RVA: 0x7FFAC2C58E90
        public void set_UpdateValueFromText(){} // RVA: 0x7FFAC2C70A40
        public void get_UpdateTextFromValue(){} // RVA: 0x7FFAC2C58E90
        public void set_UpdateTextFromValue(){} // RVA: 0x7FFAC2C70A40
        public void get_MoveFocusToCompositeRoot(){} // RVA: 0x7FFAC2C58E90
        public void set_MoveFocusToCompositeRoot(){} // RVA: 0x7FFAC2C70A40
        public void UpdateText(){} // RVA: 0x7FFAC2C70A40
        public void CullString(){} // RVA: 0x7FFAC2C58F40
        public void set_maskChar(){} // RVA: 0x7FFAC2C70B70
        public void get_isPassword(){} // RVA: 0x7FFAC2C59D00
        public void set_isPassword(){} // RVA: 0x7FFAC2C71060
        public void get_autoCorrection(){} // RVA: 0x7FFAC9C1B4D0
        public void set_autoCorrection(){} // RVA: 0x7FFAC9C1B590
        public void get_hideMobileInput(){} // RVA: 0x7FFAC9C1B650
        public void set_hideMobileInput(){} // RVA: 0x7FFAC9C1B710
        public void get_keyboardType(){} // RVA: 0x7FFAC9C1B7D0
        public void set_keyboardType(){} // RVA: 0x7FFAC9C1B890
    }

    public class ITextSelection
    {
        public object isSelectable;
        public object cursorColor;
        public object cursorIndex;
        public object doubleClickSelectsWord;
        public object selectIndex;
        public object selectionColor;
        public object tripleClickSelectsLine;
        public object selectAllOnFocus;
        public object selectAllOnMouseUp;
        public object cursorPosition;
        public object lineHeightAtCursorPosition;
        public object cursorWidth;

        // ── Methods ──
        public void get_isSelectable(){} // RVA: 0x7FFAC2C59D00
        public void set_isSelectable(){} // RVA: 0x7FFAC2C71060
        public void get_cursorColor(){} // RVA: 0x7FFAC2C588A0
        public void set_cursorColor(){} // RVA: 0x7FFAC2C70A40
        public void get_cursorIndex(){} // RVA: 0x7FFAC2C59960
        public void set_cursorIndex(){} // RVA: 0x7FFAC2C70ED0
        public void get_doubleClickSelectsWord(){} // RVA: 0x7FFAC2C59D00
        public void get_selectIndex(){} // RVA: 0x7FFAC2C59960
        public void set_selectIndex(){} // RVA: 0x7FFAC2C70ED0
        public void get_selectionColor(){} // RVA: 0x7FFAC2C588A0
        public void set_selectionColor(){} // RVA: 0x7FFAC2C70A40
        public void get_tripleClickSelectsLine(){} // RVA: 0x7FFAC2C59D00
        public void HasSelection(){} // RVA: 0x7FFAC2C59D00
        public void SelectAll(){} // RVA: 0x7FFAC2C70980
        public void SelectNone(){} // RVA: 0x7FFAC2C70980
        public void get_selectAllOnFocus(){} // RVA: 0x7FFAC2C59D00
        public void set_selectAllOnFocus(){} // RVA: 0x7FFAC2C71060
        public void get_selectAllOnMouseUp(){} // RVA: 0x7FFAC2C59D00
        public void set_selectAllOnMouseUp(){} // RVA: 0x7FFAC2C71060
        public void get_cursorPosition(){} // RVA: 0x7FFAC2C58E90
        public void get_lineHeightAtCursorPosition(){} // RVA: 0x7FFAC2C6D880
        public void get_cursorWidth(){} // RVA: 0x7FFAC2C6D880
    }

    public class ITransform
    {
        public object position;
        public object scale;

        // ── Methods ──
        public void get_position(){} // RVA: 0x7FFAC2C588A0
        public void set_position(){} // RVA: 0x7FFAC2C70A40
        public void get_scale(){} // RVA: 0x7FFAC2C588A0
    }

    public class IUIElementsUtility
    {
        // ── Methods ──
        public void TakeCapture(){} // RVA: 0x7FFAC2C59D00
        public void ReleaseCapture(){} // RVA: 0x7FFAC2C59D00
        public void ProcessEvent(){}
        public void CleanupRoots(){} // RVA: 0x7FFAC2C59D00
        public void EndContainerGUIFromException(){} // RVA: 0x7FFAC2C59F60
        public void MakeCurrentIMGUIContainerDirty(){} // RVA: 0x7FFAC2C59D00
    }

    public class IUxmlAttributes
    {
        // ── Methods ──
        public void TryGetAttributeValue(){} // RVA: 0x7FFAC2C5D200
    }

    public class IUxmlFactory
    {
        // ── Methods ──
        public void Create(){}
    }

    public class IUxmlObjectFactory`1
    {
        // ── Methods ──
        public void CreateObject(){} // RVA: 0x7FFAC2E8DC40
    }

    public class IValueField`1
    {
        public object value;

        // ── Methods ──
        public void get_value(){} // RVA: 0x7FFAC2E8DC40
        public void set_value(){} // RVA: 0x7FFAC2E8DC40
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC2E8DC40
        public void StartDragging(){} // RVA: 0x7FFAC2C70980
        public void StopDragging(){} // RVA: 0x7FFAC2C70980
    }

    public class IVisualElementPanelActivatable
    {
        public object element;

        // ── Methods ──
        public void get_element(){} // RVA: 0x7FFAC2C58E90
        public void CanBeActivated(){} // RVA: 0x7FFAC2C59D00
        public void OnPanelActivate(){} // RVA: 0x7FFAC2C70980
        public void OnPanelDeactivate(){} // RVA: 0x7FFAC2C70980
    }

    public class IVisualElementScheduledItem
    {
        // ── Methods ──
        public void Resume(){} // RVA: 0x7FFAC2C70980
        public void Pause(){} // RVA: 0x7FFAC2C70980
        public void ExecuteLater(){} // RVA: 0x7FFAC2C70BF0
        public void StartingIn(){}
        public void Every(){}
    }

    public class IVisualElementScheduler
    {
        // ── Methods ──
        public void Execute(){} // RVA: 0x7FFAC2C58F40 | overloaded x2
    }

    public class IVisualTreeUpdater
    {
        public object panel;
        public object profilerMarker;

        // ── Methods ──
        public void set_panel(){} // RVA: 0x7FFAC2C70A40
        public void get_profilerMarker(){}
        public void Update(){} // RVA: 0x7FFAC2C70980
        public void OnVersionChanged(){} // RVA: 0x7FFAC2C77970
    }

    public class Image : VisualElement
    {
        public 0x6B27F8A0 image; // 0x3C8
        public UnityEngine.Texture sprite; // 0x3D0
        public UnityEngine.Sprite vectorImage; // 0x3D8
        public UnityEngine.UIElements.VectorImage sourceRect; // 0x3E0
        public UnityEngine.Rect uv; // 0x3E8
        public UnityEngine.Color scaleMode; // 0x3F8
        public bool tintColor; // 0x408
        public bool m_ScaleModeIsInline; // 0x409
        public bool m_TintColorIsInline; // 0x40A
        public string ussClassName;
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Texture2D> s_ImageProperty; // 0x8
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Sprite> s_SpriteProperty; // 0x10
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.UIElements.VectorImage> s_VectorImageProperty; // 0x18
        public UnityEngine.UIElements.CustomStyleProperty`1<string> s_ScaleModeProperty; // 0x20
        public UnityEngine.UIElements.CustomStyleProperty`1<UnityEngine.Color> s_TintColorProperty; // 0x28

        // ── Methods ──
        public void get_image(){} // RVA: 0x7FFAC39C1CA0
        public void set_image(){} // RVA: 0x7FFAC9AB86F0
        public void get_sprite(){} // RVA: 0x7FFAC39AD490
        public void set_sprite(){} // RVA: 0x7FFAC9AB8900
        public void get_vectorImage(){} // RVA: 0x7FFAC39BF4D0
        public void set_vectorImage(){} // RVA: 0x7FFAC9AB8B10
        public void get_sourceRect(){} // RVA: 0x7FFAC9AB8D20
        public void get_uv(){} // RVA: 0x7FFAC9AB8D50
        public void set_uv(){} // RVA: 0x7FFAC9AB8D60
        public void get_scaleMode(){} // RVA: 0x7FFAC9AB8DC0
        public void get_tintColor(){} // RVA: 0x7FFAC9AB8DD0
        public void .ctor(){} // RVA: 0x7FFAC9AB8DE0
        public void GetTextureDisplaySize(){} // RVA: 0x7FFAC9AB9180 | overloaded x2
        public void DoMeasure(){} // RVA: 0x7FFAC9AB93C0
        public void OnGenerateVisualContent(){} // RVA: 0x7FFAC9AB9870
        public void OnCustomStyleResolved(){} // RVA: 0x7FFAC9ABA090
        public void ReadCustomProperties(){} // RVA: 0x7FFAC9ABA0D0
        public void SetProperty(){} // RVA: 0x7FFAC2E8DC40
        public void ClearProperty(){} // RVA: 0x7FFAC9ABA710
        public void SetScaleMode(){} // RVA: 0x7FFAC9ABA760
        public void SetTintColor(){} // RVA: 0x7FFAC9ABA7B0
        public void GetSourceRect(){} // RVA: 0x7FFAC9ABA860
        public void .cctor(){} // RVA: 0x7FFAC9ABAB20
    }

    public class ImmediateModeException : Exception
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9BA4930
    }

    public class InheritedData : ValueType
    {
        public UnityEngine.Color color; // 0x10
        public UnityEngine.UIElements.Length fontSize; // 0x20
        public UnityEngine.UIElements.Length letterSpacing; // 0x28
        public UnityEngine.UIElements.TextShadow textShadow; // 0x30
        public UnityEngine.Font unityFont; // 0x50
        public UnityEngine.UIElements.FontDefinition unityFontDefinition; // 0x58
        public 0x6B2D8AD8 unityFontStyleAndWeight; // 0x68
        public UnityEngine.UIElements.Length unityParagraphSpacing; // 0x6C
        public 0x6B2D8C90 unityTextAlign; // 0x74
        public UnityEngine.Color unityTextOutlineColor; // 0x78
        public float unityTextOutlineWidth; // 0x88
        public 0x6B122A20 visibility; // 0x8C
        public 0x6B122A78 whiteSpace; // 0x90
        public UnityEngine.UIElements.Length wordSpacing; // 0x94

        // ── Methods ──
        public void Copy(){} // RVA: 0x7FFAC9BF56C0
        public void CopyFrom(){} // RVA: 0x7FFAC9BF5710
        public void op_Equality(){} // RVA: 0x7FFAC9BF57D0
        public void Equals(){} // RVA: 0x7FFAC9BF5FA0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9BF60B0
    }

    public class InlineStyleAccess : StyleValueCollection
    {
        public UnityEngine.UIElements.StyleSheets.StylePropertyReader UnityEngine.UIElements.IStyle.backgroundColor;
        public System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.StyleValueManaged> UnityEngine.UIElements.IStyle.borderBottomColor; // 0x18
        public UnityEngine.UIElements.VisualElement UnityEngine.UIElements.IStyle.borderBottomLeftRadius; // 0x20
        public bool UnityEngine.UIElements.IStyle.borderBottomRightRadius; // 0x28
        public UnityEngine.UIElements.StyleCursor UnityEngine.UIElements.IStyle.borderBottomWidth; // 0x30
        public bool UnityEngine.UIElements.IStyle.borderLeftColor; // 0x50
        public UnityEngine.UIElements.StyleTextShadow UnityEngine.UIElements.IStyle.borderLeftWidth; // 0x54
        public bool UnityEngine.UIElements.IStyle.borderRightColor; // 0x74
        public UnityEngine.UIElements.StyleTransformOrigin UnityEngine.UIElements.IStyle.borderRightWidth; // 0x78
        public bool UnityEngine.UIElements.IStyle.borderTopColor; // 0x90
        public UnityEngine.UIElements.StyleTranslate UnityEngine.UIElements.IStyle.borderTopLeftRadius; // 0x94
        public bool UnityEngine.UIElements.IStyle.borderTopRightRadius; // 0xB0
        public UnityEngine.UIElements.StyleRotate UnityEngine.UIElements.IStyle.borderTopWidth; // 0xB4
        public bool UnityEngine.UIElements.IStyle.bottom; // 0xD0
        public UnityEngine.UIElements.StyleScale UnityEngine.UIElements.IStyle.color; // 0xD4
        public bool UnityEngine.UIElements.IStyle.display; // 0xE8
        public UnityEngine.UIElements.StyleBackgroundSize UnityEngine.UIElements.IStyle.flexBasis; // 0xEC
        public InlineRule UnityEngine.UIElements.IStyle.flexDirection; // 0x108

        // ── Methods ──
        public void UnityEngine.UIElements.IStyle.set_backgroundColor(){} // RVA: 0x7FFAC9BD9010
        public void UnityEngine.UIElements.IStyle.set_borderBottomColor(){} // RVA: 0x7FFAC9BD9080
        public void UnityEngine.UIElements.IStyle.set_borderBottomLeftRadius(){} // RVA: 0x7FFAC9BD90F0
        public void UnityEngine.UIElements.IStyle.set_borderBottomRightRadius(){} // RVA: 0x7FFAC9BD9160
        public void UnityEngine.UIElements.IStyle.set_borderBottomWidth(){} // RVA: 0x7FFAC9BD91D0
        public void UnityEngine.UIElements.IStyle.set_borderLeftColor(){} // RVA: 0x7FFAC9BD9290
        public void UnityEngine.UIElements.IStyle.set_borderLeftWidth(){} // RVA: 0x7FFAC9BD9300
        public void UnityEngine.UIElements.IStyle.set_borderRightColor(){} // RVA: 0x7FFAC9BD93C0
        public void UnityEngine.UIElements.IStyle.set_borderRightWidth(){} // RVA: 0x7FFAC9BD9430
        public void UnityEngine.UIElements.IStyle.set_borderTopColor(){} // RVA: 0x7FFAC9BD94F0
        public void UnityEngine.UIElements.IStyle.set_borderTopLeftRadius(){} // RVA: 0x7FFAC9BD9560
        public void UnityEngine.UIElements.IStyle.set_borderTopRightRadius(){} // RVA: 0x7FFAC9BD95D0
        public void UnityEngine.UIElements.IStyle.set_borderTopWidth(){} // RVA: 0x7FFAC9BD9640
        public void UnityEngine.UIElements.IStyle.set_bottom(){} // RVA: 0x7FFAC9BD9700
        public void UnityEngine.UIElements.IStyle.set_color(){} // RVA: 0x7FFAC9BD97E0
        public void UnityEngine.UIElements.IStyle.get_display(){} // RVA: 0x7FFAC9BD9850
        public void UnityEngine.UIElements.IStyle.set_display(){} // RVA: 0x7FFAC9BD9910
        public void UnityEngine.UIElements.IStyle.set_flexBasis(){} // RVA: 0x7FFAC9BD9A40
        public void UnityEngine.UIElements.IStyle.set_flexDirection(){} // RVA: 0x7FFAC9BD9B20
        public void UnityEngine.UIElements.IStyle.set_flexGrow(){} // RVA: 0x7FFAC9BD9C50
        public void UnityEngine.UIElements.IStyle.set_flexShrink(){} // RVA: 0x7FFAC9BD9D10
        public void UnityEngine.UIElements.IStyle.set_fontSize(){} // RVA: 0x7FFAC9BD9DD0
        public void UnityEngine.UIElements.IStyle.set_height(){} // RVA: 0x7FFAC9BD9E40
        public void UnityEngine.UIElements.IStyle.set_left(){} // RVA: 0x7FFAC9BD9F20
        public void UnityEngine.UIElements.IStyle.set_marginBottom(){} // RVA: 0x7FFAC9BDA000
        public void UnityEngine.UIElements.IStyle.set_marginLeft(){} // RVA: 0x7FFAC9BDA0E0
        public void UnityEngine.UIElements.IStyle.set_marginRight(){} // RVA: 0x7FFAC9BDA1C0
        public void UnityEngine.UIElements.IStyle.set_marginTop(){} // RVA: 0x7FFAC9BDA2A0
        public void UnityEngine.UIElements.IStyle.set_maxHeight(){} // RVA: 0x7FFAC9BDA390
        public void UnityEngine.UIElements.IStyle.set_maxWidth(){} // RVA: 0x7FFAC9BDA470
        public void UnityEngine.UIElements.IStyle.set_minWidth(){} // RVA: 0x7FFAC9BDA550
        public void UnityEngine.UIElements.IStyle.set_opacity(){} // RVA: 0x7FFAC9BDA630
        public void UnityEngine.UIElements.IStyle.set_overflow(){} // RVA: 0x7FFAC9BDA690
        public void UnityEngine.UIElements.IStyle.set_paddingBottom(){} // RVA: 0x7FFAC9BDA810
        public void UnityEngine.UIElements.IStyle.set_paddingLeft(){} // RVA: 0x7FFAC9BDA900
        public void UnityEngine.UIElements.IStyle.set_paddingRight(){} // RVA: 0x7FFAC9BDA9E0
        public void UnityEngine.UIElements.IStyle.get_paddingTop(){} // RVA: 0x7FFAC9BDAAD0
        public void UnityEngine.UIElements.IStyle.set_paddingTop(){} // RVA: 0x7FFAC9BDAB60
        public void UnityEngine.UIElements.IStyle.set_position(){} // RVA: 0x7FFAC9BDAC50
        public void UnityEngine.UIElements.IStyle.set_right(){} // RVA: 0x7FFAC9BDAD80
        public void UnityEngine.UIElements.IStyle.set_top(){} // RVA: 0x7FFAC9BDAE70
        public void UnityEngine.UIElements.IStyle.set_unityBackgroundImageTintColor(){} // RVA: 0x7FFAC9BDAF60
        public void UnityEngine.UIElements.IStyle.set_unityFont(){} // RVA: 0x7FFAC9BDAFD0
        public void UnityEngine.UIElements.IStyle.set_unityFontDefinition(){} // RVA: 0x7FFAC9BDB040
        public void UnityEngine.UIElements.IStyle.set_visibility(){} // RVA: 0x7FFAC9BDB0C0
        public void UnityEngine.UIElements.IStyle.get_width(){} // RVA: 0x7FFAC9BDB150
        public void UnityEngine.UIElements.IStyle.set_width(){} // RVA: 0x7FFAC9BDB1E0
        public void get_ve(){} // RVA: 0x7FFAC2F4F0C0
        public void set_ve(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC9BDB2C0
        public void Finalize(){} // RVA: 0x7FFAC9BDB330
        public void SetInlineRule(){} // RVA: 0x7FFAC9BDB470
        public void IsValueSet(){} // RVA: 0x7FFAC9BDB6C0
        public void ApplyInlineStyles(){} // RVA: 0x7FFAC9BDBAA0
        public void UnityEngine.UIElements.IStyle.get_cursor(){} // RVA: 0x7FFAC9BDCAA0
        public void UnityEngine.UIElements.IStyle.get_textShadow(){} // RVA: 0x7FFAC9BDCBE0
        public void UnityEngine.UIElements.IStyle.get_backgroundSize(){} // RVA: 0x7FFAC9BDCC50
        public void UnityEngine.UIElements.IStyle.get_transformOrigin(){} // RVA: 0x7FFAC9BDCCB0
        public void UnityEngine.UIElements.IStyle.get_translate(){} // RVA: 0x7FFAC9BDCD00
        public void UnityEngine.UIElements.IStyle.set_translate(){} // RVA: 0x7FFAC9BDCD60
        public void UnityEngine.UIElements.IStyle.get_rotate(){} // RVA: 0x7FFAC9BDCFD0
        public void UnityEngine.UIElements.IStyle.get_scale(){} // RVA: 0x7FFAC9BDD030
        public void SetStyleValue(){} // RVA: 0x7FFAC9BDDA30 | overloaded x6
        public void SetInlineTranslate(){} // RVA: 0x7FFAC9BDDD30
        public void ApplyStyleTranslate(){} // RVA: 0x7FFAC9BDDEF0
        public void ApplyStyleValue(){} // RVA: 0x7FFAC9BDE320
        public void RemoveInlineStyle(){} // RVA: 0x7FFAC9BDE640
        public void ApplyFromComputedStyle(){} // RVA: 0x7FFAC9BDE790
        public void TryGetInlineCursor(){} // RVA: 0x7FFAC9BDE9A0
        public void TryGetInlineTextShadow(){} // RVA: 0x7FFAC9BDEA10
        public void TryGetInlineTransformOrigin(){} // RVA: 0x7FFAC9BDEA30
        public void TryGetInlineTranslate(){} // RVA: 0x7FFAC9BDEA50
        public void TryGetInlineRotate(){} // RVA: 0x7FFAC9BDEA80
        public void TryGetInlineScale(){} // RVA: 0x7FFAC9BDEAB0
        public void TryGetInlineBackgroundSize(){} // RVA: 0x7FFAC9BDEAE0
        public void .cctor(){} // RVA: 0x7FFAC9BDEB10
    }

    public class InputEvent : EventBase`1
    {
        public string previousData; // 0x88
        public string newData; // 0x90

        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B83CC0
        public void set_previousData(){} // RVA: 0x7FFAC354E300
        public void set_newData(){} // RVA: 0x7FFAC354E360
        public void Init(){} // RVA: 0x7FFAC9B83DB0
        public void LocalInit(){} // RVA: 0x7FFAC9B83E70
        public void GetPooled(){} // RVA: 0x7FFAC9B83F30
        public void .ctor(){} // RVA: 0x7FFAC9B84060
    }

    public class IntegerField : TextValueField`1
    {
        public string integerInput;
        public string labelUssClassName; // 0x8
        public string inputUssClassName; // 0x10

        // ── Methods ──
        public void get_integerInput(){} // RVA: 0x7FFAC9B3D3B0
        public void ValueToString(){} // RVA: 0x7FFAC9B3D440
        public void StringToValue(){} // RVA: 0x7FFAC9B3D650
        public void .ctor(){} // RVA: 0x7FFAC9B3D7A0 | overloaded x2
        public void CanTryParse(){} // RVA: 0x7FFAC9B3DBE0
        public void ApplyInputDeviceDelta(){} // RVA: 0x7FFAC9B3DCB0
        public void .cctor(){} // RVA: 0x7FFAC9B3DDA0
    }

}