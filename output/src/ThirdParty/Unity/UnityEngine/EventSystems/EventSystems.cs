// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.EventSystems
// Classes: 41
// Methods: 421

namespace ThirdParty.Unity.UnityEngine.EventSystems
{
    public class AbstractEventData : Object
    {
        public bool m_Used; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFE81FCAC70
        public void Use(){} // RVA: 0x7FFE814B8390
        public void get_used(){} // RVA: 0x7FFE811C55E0
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class AxisEventData : BaseEventData
    {
        public UnityEngine.Vector2 _moveVector; // 0x20
        public 0x6664667C _moveDir; // 0x28

        // ── Methods ──
        public void get_moveVector(){} // RVA: 0x7FFE8185A8B0
        public void set_moveVector(){} // RVA: 0x7FFE81859C50
        public void get_moveDir(){} // RVA: 0x7FFE81549710
        public void set_moveDir(){} // RVA: 0x7FFE817E4800
        public void .ctor(){} // RVA: 0x7FFE88022F10
    }

    public class BaseEventData : AbstractEventData
    {
        public UnityEngine.EventSystems.EventSystem m_EventSystem; // 0x18
        public UnityEngine.GameObject _pointerEnter; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81161E80
        public void get_currentInputModule(){} // RVA: 0x7FFE86BAE080
        public void get_selectedObject(){} // RVA: 0x7FFE86BAE0E0
        public void set_selectedObject(){} // RVA: 0x7FFE88022FB0
    }

    public class BaseInput : UIBehaviour
    {
        // ── Methods ──
        public void get_compositionString(){} // RVA: 0x7FFE87CE8E30
        public void get_imeCompositionMode(){} // RVA: 0x7FFE87CE8D90
        public void set_imeCompositionMode(){} // RVA: 0x7FFE8802A5E0
        public void get_compositionCursorPos(){} // RVA: 0x7FFE8802A630
        public void set_compositionCursorPos(){} // RVA: 0x7FFE8802A690
        public void get_mousePresent(){} // RVA: 0x7FFE87CE8F80
        public void GetMouseButtonDown(){} // RVA: 0x7FFE87F16BF0
        public void GetMouseButtonUp(){} // RVA: 0x7FFE87F16C40
        public void GetMouseButton(){} // RVA: 0x7FFE8802A6E0
        public void get_mousePosition(){} // RVA: 0x7FFE8802A730
        public void get_mouseScrollDelta(){} // RVA: 0x7FFE8802A7A0
        public void get_touchSupported(){} // RVA: 0x7FFE822B5720
        public void get_touchCount(){} // RVA: 0x7FFE87CE8FD0
        public void GetTouch(){} // RVA: 0x7FFE87F16B40
        public void GetAxisRaw(){} // RVA: 0x7FFE8802A800
        public void GetButtonDown(){} // RVA: 0x7FFE8111A020
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class BaseInputModule : UIBehaviour
    {
        public System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult> m_RaycastResultCache; // 0x20
        public bool m_SendPointerHoverToParent; // 0x28
        public UnityEngine.EventSystems.AxisEventData m_AxisEventData; // 0x30
        public UnityEngine.EventSystems.EventSystem m_EventSystem; // 0x38

        // ── Methods ──
        public void get_sendPointerHoverToParent(){} // RVA: 0x7FFE815F1380
        public void set_sendPointerHoverToParent(){} // RVA: 0x7FFE81C15740
        public void get_input(){} // RVA: 0x7FFE8802A850
        public void get_inputOverride(){} // RVA: 0x7FFE81176730
        public void set_inputOverride(){} // RVA: 0x7FFE81176740
        public void get_eventSystem(){} // RVA: 0x7FFE8143BA80
        public void OnEnable(){} // RVA: 0x7FFE8802AC10
        public void OnDisable(){} // RVA: 0x7FFE8802ACB0
        public void Process(){} // RVA: 0x7FFE80E45FE0
        public void FindFirstRaycast(){} // RVA: 0x7FFE8802ACD0
        public void DetermineMoveDirection(){} // RVA: 0x7FFE8802AEE0 | overloaded x2
        public void FindCommonRoot(){} // RVA: 0x7FFE8802AF60
        public void HandlePointerExitAndEnter(){} // RVA: 0x7FFE8802B340
        public void GetAxisEventData(){} // RVA: 0x7FFE8802C3A0
        public void GetBaseEventData(){} // RVA: 0x7FFE8802C4E0
        public void IsPointerOverGameObject(){} // RVA: 0x7FFE810FB320
        public void ShouldActivateModule(){} // RVA: 0x7FFE8802C610
        public void DeactivateModule(){} // RVA: 0x7FFE810FB310
        public void ActivateModule(){} // RVA: 0x7FFE810FB310
        public void UpdateModule(){} // RVA: 0x7FFE810FB310
        public void IsModuleSupported(){} // RVA: 0x7FFE811E0850
        public void ConvertUIToolkitPointerId(){} // RVA: 0x7FFE8802C700
        public void .ctor(){} // RVA: 0x7FFE8802C7A0
    }

    public class BaseRaycaster : UIBehaviour
    {
        public UnityEngine.EventSystems.BaseRaycaster m_RootRaycaster; // 0x20
        public object field_1; // 0x1EE
        public object field_2; // 0x1EF
        public object field_3; // 0x1F0
        public object field_4; // 0x1F1

        // ── Methods ──
        public void Raycast(){} // RVA: 0x7FFE80E4F230
        public void get_eventCamera(){} // RVA: 0x7FFE80E2E2E0
        public void get_priority(){} // RVA: 0x7FFE813240E0
        public void get_sortOrderPriority(){} // RVA: 0x7FFE88033E30
        public void get_renderOrderPriority(){} // RVA: 0x7FFE88033E30
        public void get_rootRaycaster(){} // RVA: 0x7FFE88033E40
        public void ToString(){} // RVA: 0x7FFE88033FC0
        public void OnEnable(){} // RVA: 0x7FFE880342D0
        public void OnDisable(){} // RVA: 0x7FFE88034420
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFE86597DC0
        public void OnTransformParentChanged(){} // RVA: 0x7FFE86597DC0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

    public class EventSystem : UIBehaviour
    {
        public System.Collections.Generic.List`1<UnityEngine.EventSystems.BaseInputModule> m_SystemInputModules; // 0x20
        public UnityEngine.EventSystems.BaseInputModule m_CurrentInputModule; // 0x28
        public System.Collections.Generic.List`1<UnityEngine.EventSystems.EventSystem> m_EventSystems;
        public UnityEngine.GameObject m_FirstSelected; // 0x30
        public bool m_sendNavigationEvents; // 0x38
        public int m_DragThreshold; // 0x3C
        public UnityEngine.GameObject m_CurrentSelected; // 0x40
        public bool m_HasFocus; // 0x48
        public bool m_SelectionGuard; // 0x49
        public UnityEngine.EventSystems.BaseEventData m_DummyData; // 0x50
        public System.Comparison`1<UnityEngine.EventSystems.RaycastResult> s_RaycastComparer; // 0x8
        public UIToolkitOverrideConfig s_UIToolkitOverride; // 0x10
        public bool m_Started; // 0x58

        // ── Methods ──
        public void get_current(){} // RVA: 0x7FFE880246D0
        public void set_current(){} // RVA: 0x7FFE880247B0
        public void get_sendNavigationEvents(){} // RVA: 0x7FFE812CF770
        public void set_sendNavigationEvents(){} // RVA: 0x7FFE812D0010
        public void get_pixelDragThreshold(){} // RVA: 0x7FFE816311C0
        public void set_pixelDragThreshold(){} // RVA: 0x7FFE82A4B070
        public void get_currentInputModule(){} // RVA: 0x7FFE81129130
        public void get_firstSelectedGameObject(){} // RVA: 0x7FFE8144E200
        public void set_firstSelectedGameObject(){} // RVA: 0x7FFE81129890
        public void get_currentSelectedGameObject(){} // RVA: 0x7FFE81178740
        public void get_lastSelectedGameObject(){} // RVA: 0x7FFE813240E0
        public void get_isFocused(){} // RVA: 0x7FFE811B2D30
        public void .ctor(){} // RVA: 0x7FFE88024980
        public void UpdateModules(){} // RVA: 0x7FFE88024A90
        public void get_alreadySelecting(){} // RVA: 0x7FFE820ED800
        public void SetSelectedGameObject(){} // RVA: 0x7FFE880250B0 | overloaded x2
        public void get_baseEventDataCache(){} // RVA: 0x7FFE88024FB0
        public void RaycastComparer(){} // RVA: 0x7FFE880251D0
        public void RaycastAll(){} // RVA: 0x7FFE88025910
        public void IsPointerOverGameObject(){} // RVA: 0x7FFE88025D30 | overloaded x2
        public void get_isUIToolkitActiveEventSystem(){} // RVA: 0x7FFE88025E40
        public void get_sendUIToolkitEvents(){} // RVA: 0x7FFE88026060
        public void get_createUIToolkitPanelGameObjectsOnStart(){} // RVA: 0x7FFE880260D0
        public void SetUITookitEventSystemOverride(){} // RVA: 0x7FFE88026140
        public void StartTrackingUIToolkitPanels(){} // RVA: 0x7FFE88026460
        public void StopTrackingUIToolkitPanels(){} // RVA: 0x7FFE88026880
        public void CreateUIToolkitPanelGameObject(){} // RVA: 0x7FFE88026A90
        public void Start(){} // RVA: 0x7FFE88026E70
        public void OnEnable(){} // RVA: 0x7FFE88026E80
        public void OnDisable(){} // RVA: 0x7FFE88026FF0
        public void TickModules(){} // RVA: 0x7FFE880271D0
        public void OnApplicationFocus(){} // RVA: 0x7FFE88027370
        public void Update(){} // RVA: 0x7FFE88027380
        public void ChangeEventModule(){} // RVA: 0x7FFE88027820
        public void ToString(){} // RVA: 0x7FFE88027AF0
        public void .cctor(){} // RVA: 0x7FFE88027D00
    }

    public class EventTrigger : MonoBehaviour
    {
        public System.Collections.Generic.List`1<Entry> m_Delegates; // 0x20
        public object field_1; // 0x1C1

        // ── Methods ──
        public void get_delegates(){} // RVA: 0x7FFE88027FE0
        public void set_delegates(){} // RVA: 0x7FFE811290D0
        public void .ctor(){} // RVA: 0x7FFE810FBD50
        public void get_triggers(){} // RVA: 0x7FFE88027FF0
        public void set_triggers(){} // RVA: 0x7FFE811290D0
        public void Execute(){} // RVA: 0x7FFE880280B0
        public void OnPointerEnter(){} // RVA: 0x7FFE880281D0
        public void OnPointerExit(){} // RVA: 0x7FFE880281E0
        public void OnDrag(){} // RVA: 0x7FFE880281F0
        public void OnDrop(){} // RVA: 0x7FFE88028200
        public void OnPointerDown(){} // RVA: 0x7FFE88028210
        public void OnPointerUp(){} // RVA: 0x7FFE88028220
        public void OnPointerClick(){} // RVA: 0x7FFE88028230
        public void OnSelect(){} // RVA: 0x7FFE88028240
        public void OnDeselect(){} // RVA: 0x7FFE88028250
        public void OnScroll(){} // RVA: 0x7FFE88028260
        public void OnMove(){} // RVA: 0x7FFE88028270
        public void OnUpdateSelected(){} // RVA: 0x7FFE88028280
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFE88028290
        public void OnBeginDrag(){} // RVA: 0x7FFE880282A0
        public void OnEndDrag(){} // RVA: 0x7FFE880282B0
        public void OnSubmit(){} // RVA: 0x7FFE880282C0
        public void OnCancel(){} // RVA: 0x7FFE880282D0
    }

    public class ExecuteEvents : Object
    {
        public EventFunction`1<UnityEngine.EventSystems.IPointerMoveHandler> s_PointerMoveHandler;
        public EventFunction`1<UnityEngine.EventSystems.IPointerEnterHandler> s_PointerEnterHandler; // 0x8
        public EventFunction`1<UnityEngine.EventSystems.IPointerExitHandler> s_PointerExitHandler; // 0x10
        public EventFunction`1<UnityEngine.EventSystems.IPointerDownHandler> s_PointerDownHandler; // 0x18
        public EventFunction`1<UnityEngine.EventSystems.IPointerUpHandler> s_PointerUpHandler; // 0x20
        public EventFunction`1<UnityEngine.EventSystems.IPointerClickHandler> s_PointerClickHandler; // 0x28
        public EventFunction`1<UnityEngine.EventSystems.IInitializePotentialDragHandler> s_InitializePotentialDragHandler; // 0x30
        public EventFunction`1<UnityEngine.EventSystems.IBeginDragHandler> s_BeginDragHandler; // 0x38
        public EventFunction`1<UnityEngine.EventSystems.IDragHandler> s_DragHandler; // 0x40
        public EventFunction`1<UnityEngine.EventSystems.IEndDragHandler> s_EndDragHandler; // 0x48
        public EventFunction`1<UnityEngine.EventSystems.IDropHandler> s_DropHandler; // 0x50
        public EventFunction`1<UnityEngine.EventSystems.IScrollHandler> s_ScrollHandler; // 0x58
        public EventFunction`1<UnityEngine.EventSystems.IUpdateSelectedHandler> s_UpdateSelectedHandler; // 0x60
        public EventFunction`1<UnityEngine.EventSystems.ISelectHandler> s_SelectHandler; // 0x68
        public EventFunction`1<UnityEngine.EventSystems.IDeselectHandler> s_DeselectHandler; // 0x70
        public EventFunction`1<UnityEngine.EventSystems.IMoveHandler> s_MoveHandler; // 0x78
        public EventFunction`1<UnityEngine.EventSystems.ISubmitHandler> s_SubmitHandler; // 0x80
        public EventFunction`1<UnityEngine.EventSystems.ICancelHandler> s_CancelHandler; // 0x88

        // ── Methods ──
        public void ValidateEventData(){} // RVA: 0x7FFE810A1420
        public void Execute(){} // RVA: 0x7FFE80E329F0 | overloaded x19
        public void get_pointerMoveHandler(){} // RVA: 0x7FFE88028E80
        public void get_pointerEnterHandler(){} // RVA: 0x7FFE88028EE0
        public void get_pointerExitHandler(){} // RVA: 0x7FFE88028F40
        public void get_pointerDownHandler(){} // RVA: 0x7FFE88028FA0
        public void get_pointerUpHandler(){} // RVA: 0x7FFE88029000
        public void get_pointerClickHandler(){} // RVA: 0x7FFE88029060
        public void get_initializePotentialDrag(){} // RVA: 0x7FFE880290C0
        public void get_beginDragHandler(){} // RVA: 0x7FFE88029120
        public void get_dragHandler(){} // RVA: 0x7FFE88029180
        public void get_endDragHandler(){} // RVA: 0x7FFE880291E0
        public void get_dropHandler(){} // RVA: 0x7FFE88029240
        public void get_scrollHandler(){} // RVA: 0x7FFE880292A0
        public void get_updateSelectedHandler(){} // RVA: 0x7FFE88029300
        public void get_selectHandler(){} // RVA: 0x7FFE88029360
        public void get_deselectHandler(){} // RVA: 0x7FFE880293C0
        public void get_moveHandler(){} // RVA: 0x7FFE88029420
        public void get_submitHandler(){} // RVA: 0x7FFE88029480
        public void get_cancelHandler(){} // RVA: 0x7FFE880294E0
        public void GetEventChain(){} // RVA: 0x7FFE88029540
        public void ExecuteHierarchy(){} // RVA: 0x7FFE80E3EAC0
        public void ShouldSendToComponent(){} // RVA: 0x7FFE80E2F230
        public void GetEventList(){} // RVA: 0x7FFE80E462E0
        public void CanHandleEvent(){} // RVA: 0x7FFE80E2F230
        public void GetEventHandler(){} // RVA: 0x7FFE80E2E3D0
        public void .cctor(){} // RVA: 0x7FFE880297F0
    }

    public class IBeginDragHandler
    {
        // ── Methods ──
        public void OnBeginDrag(){} // RVA: 0x7FFE80E460A0
    }

    public class ICancelHandler
    {
        // ── Methods ──
        public void OnCancel(){} // RVA: 0x7FFE80E460A0
    }

    public class IDeselectHandler
    {
        // ── Methods ──
        public void OnDeselect(){} // RVA: 0x7FFE80E460A0
    }

    public class IDragHandler
    {
        // ── Methods ──
        public void OnDrag(){} // RVA: 0x7FFE80E460A0
    }

    public class IDropHandler
    {
        // ── Methods ──
        public void OnDrop(){} // RVA: 0x7FFE80E460A0
    }

    public class IEndDragHandler
    {
        // ── Methods ──
        public void OnEndDrag(){} // RVA: 0x7FFE80E460A0
    }

    public class IEventSystemHandler
    {
    }

    public class IInitializePotentialDragHandler
    {
        // ── Methods ──
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFE80E460A0
    }

    public class IMoveHandler
    {
        // ── Methods ──
        public void OnMove(){} // RVA: 0x7FFE80E460A0
    }

    public class IPointerClickHandler
    {
        // ── Methods ──
        public void OnPointerClick(){} // RVA: 0x7FFE80E460A0
    }

    public class IPointerDownHandler
    {
        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x7FFE80E460A0
    }

    public class IPointerEnterHandler
    {
        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x7FFE80E460A0
    }

    public class IPointerExitHandler
    {
        // ── Methods ──
        public void OnPointerExit(){} // RVA: 0x7FFE80E460A0
    }

    public class IPointerMoveHandler
    {
        // ── Methods ──
        public void OnPointerMove(){} // RVA: 0x7FFE80E460A0
    }

    public class IPointerUpHandler
    {
        // ── Methods ──
        public void OnPointerUp(){} // RVA: 0x7FFE80E460A0
    }

    public class IScrollHandler
    {
        // ── Methods ──
        public void OnScroll(){} // RVA: 0x7FFE80E460A0
    }

    public class ISelectHandler
    {
        // ── Methods ──
        public void OnSelect(){} // RVA: 0x7FFE80E460A0
    }

    public class ISubmitHandler
    {
        // ── Methods ──
        public void OnSubmit(){} // RVA: 0x7FFE80E460A0
    }

    public class IUpdateSelectedHandler
    {
        // ── Methods ──
        public void OnUpdateSelected(){} // RVA: 0x7FFE80E460A0
    }

    public class OVRInputModule : PointerInputModule
    {
        public UnityEngine.Transform rayTransform; // 0x68
        public OVRCursor m_Cursor; // 0x70
        public dFixup.clipRectConstants joyPadClickButton; // 0x78
        public 0x66576A14 gazeClickKey; // 0x7C
        public bool performSphereCastForGazepointer; // 0x80
        public bool useRightStickScroll; // 0x81
        public float rightStickDeadZone; // 0x84

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D32E30
        public void get_inputMode(){} // RVA: 0x7FFE813240E0
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x7FFE86C6A1E0
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x7FFE86D331B0
        public void get_inputActionsPerSecond(){} // RVA: 0x7FFE81643980
        public void set_inputActionsPerSecond(){} // RVA: 0x7FFE81641180
        public void get_horizontalAxis(){} // RVA: 0x7FFE81166120
        public void set_horizontalAxis(){} // RVA: 0x7FFE81166130
        public void get_verticalAxis(){} // RVA: 0x7FFE81253460
        public void set_verticalAxis(){} // RVA: 0x7FFE81253470
        public void get_submitButton(){} // RVA: 0x7FFE81218100
        public void set_submitButton(){} // RVA: 0x7FFE81218110
        public void get_cancelButton(){} // RVA: 0x7FFE8181EA80
        public void set_cancelButton(){} // RVA: 0x7FFE8117C8A0
        public void UpdateModule(){} // RVA: 0x7FFE86D331C0
        public void IsModuleSupported(){} // RVA: 0x7FFE86D33260
        public void ShouldActivateModule(){} // RVA: 0x7FFE86D332C0
        public void ActivateModule(){} // RVA: 0x7FFE86D33500
        public void DeactivateModule(){} // RVA: 0x7FFE86D33700
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x7FFE86D33710
        public void AllowMoveEventProcessing(){} // RVA: 0x7FFE86D339A0
        public void GetRawMoveVector(){} // RVA: 0x7FFE86D33A80
        public void SendMoveEventToSelectedObject(){} // RVA: 0x7FFE86D33C60
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x7FFE86D33EA0
        public void ProcessMousePress(){} // RVA: 0x7FFE86D34030
        public void ProcessMouseEvent(){} // RVA: 0x7FFE86D34C90
        public void Process(){} // RVA: 0x7FFE86D35120
        public void UseMouse(){} // RVA: 0x7FFE86D35320
        public void CopyFromTo(){} // RVA: 0x7FFE86D35570 | overloaded x2
        public void GetPointerData(){} // RVA: 0x7FFE86D356E0
        public void ClearSelection(){} // RVA: 0x7FFE86D35840
        public void GetRectTransformNormal(){} // RVA: 0x7FFE86D35CF0
        public void GetGazePointerData(){} // RVA: 0x7FFE86D35F50
        public void GetCanvasPointerData(){} // RVA: 0x7FFE86D36F40
        public void ShouldStartDrag(){} // RVA: 0x7FFE86D37820
        public void IsPointerMoving(){} // RVA: 0x7FFE86D37BE0
        public void SwipeAdjustedPosition(){} // RVA: 0x7FFE82153650
        public void ProcessDrag(){} // RVA: 0x7FFE86D37C80
        public void GetGazeButtonState(){} // RVA: 0x7FFE86D38140
        public void GetExtraScrollDelta(){} // RVA: 0x7FFE86D38330
    }

    public class OVRPhysicsRaycaster : BaseRaycaster
    {
        public int kNoEventMaskSet;
        public UnityEngine.LayerMask m_EventMask; // 0x28
        public int sortOrder; // 0x2C
        public object field_3; // 0x1E9
        public object field_4; // 0x1EA

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE81DAE280
        public void get_eventCamera(){} // RVA: 0x7FFE86D38430
        public void get_depth(){} // RVA: 0x7FFE86D384A0
        public void get_sortOrderPriority(){} // RVA: 0x7FFE81F84A50
        public void get_finalEventMask(){} // RVA: 0x7FFE86D38600
        public void get_eventMask(){} // RVA: 0x7FFE81549710
        public void set_eventMask(){} // RVA: 0x7FFE817E4800
        public void Raycast(){} // RVA: 0x7FFE86D38760
        public void Spherecast(){} // RVA: 0x7FFE86D38ED0
        public void GetScreenPos(){} // RVA: 0x7FFE86D39660
    }

    public class OVRPointerEventData : PointerEventData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86D39820
        public void ToString(){} // RVA: 0x7FFE86D39830
    }

    public class Physics2DRaycaster : PhysicsRaycaster
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8251FF40
        public void Raycast(){} // RVA: 0x7FFE88034530
    }

    public class PhysicsRaycaster : BaseRaycaster
    {
        public int kNoEventMaskSet;
        public UnityEngine.Camera m_EventCamera; // 0x28
        public UnityEngine.LayerMask m_EventMask; // 0x30
        public int m_MaxRayIntersections; // 0x34
        public int m_LastMaxRayIntersections; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8251FF40
        public void get_eventCamera(){} // RVA: 0x7FFE88034FE0
        public void get_depth(){} // RVA: 0x7FFE88035200
        public void get_finalEventMask(){} // RVA: 0x7FFE88035360
        public void get_eventMask(){} // RVA: 0x7FFE81156CD0
        public void set_eventMask(){} // RVA: 0x7FFE81156CE0
        public void get_maxRayIntersections(){} // RVA: 0x7FFE82447220
        public void set_maxRayIntersections(){} // RVA: 0x7FFE82443340
        public void ComputeRayAndDistance(){} // RVA: 0x7FFE880354C0
        public void Raycast(){} // RVA: 0x7FFE88035950
    }

    public class PointerEventData : BaseEventData
    {
        public UnityEngine.GameObject _pointerEnter; // 0x20
        public UnityEngine.GameObject m_PointerPress; // 0x28
        public UnityEngine.GameObject _lastPress; // 0x30
        public UnityEngine.GameObject _rawPointerPress; // 0x38
        public UnityEngine.GameObject _pointerDrag; // 0x40
        public UnityEngine.GameObject _pointerClick; // 0x48
        public UnityEngine.EventSystems.RaycastResult _pointerCurrentRaycast; // 0x50
        public UnityEngine.EventSystems.RaycastResult _pointerPressRaycast; // 0xA0
        public System.Collections.Generic.List`1<UnityEngine.GameObject> hovered; // 0xF0
        public bool _eligibleForClick; // 0xF8
        public int _displayIndex; // 0xFC
        public int _pointerId; // 0x100
        public UnityEngine.Vector2 _position; // 0x104
        public UnityEngine.Vector2 _delta; // 0x10C
        public UnityEngine.Vector2 _pressPosition; // 0x114
        public UnityEngine.Vector3 _worldPosition; // 0x11C
        public UnityEngine.Vector3 _worldNormal; // 0x128
        public float _clickTime; // 0x134
        public int _clickCount; // 0x138
        public UnityEngine.Vector2 _scrollDelta; // 0x13C
        public bool _useDragThreshold; // 0x144
        public bool _dragging; // 0x145
        public 0x66645864 _button; // 0x148
        public float _pressure; // 0x14C
        public float _tangentialPressure; // 0x150
        public float _altitudeAngle; // 0x154
        public float _azimuthAngle; // 0x158
        public float _twist; // 0x15C
        public UnityEngine.Vector2 _tilt; // 0x160
        public 0x666D362C _penStatus; // 0x168
        public UnityEngine.Vector2 _radius; // 0x16C
        public UnityEngine.Vector2 _radiusVariance; // 0x174
        public bool _fullyExited; // 0x17C
        public bool _reentered; // 0x17D
        public object field_34; // 0xEDEE

        // ── Methods ──
        public void get_pointerEnter(){} // RVA: 0x7FFE811290C0
        public void set_pointerEnter(){} // RVA: 0x7FFE811290D0
        public void get_lastPress(){} // RVA: 0x7FFE8144E200
        public void set_lastPress(){} // RVA: 0x7FFE81129890
        public void get_rawPointerPress(){} // RVA: 0x7FFE8143BA80
        public void set_rawPointerPress(){} // RVA: 0x7FFE81437330
        public void get_pointerDrag(){} // RVA: 0x7FFE81178740
        public void set_pointerDrag(){} // RVA: 0x7FFE81123200
        public void get_pointerClick(){} // RVA: 0x7FFE81176730
        public void set_pointerClick(){} // RVA: 0x7FFE81176740
        public void get_pointerCurrentRaycast(){} // RVA: 0x7FFE84E85A50
        public void set_pointerCurrentRaycast(){} // RVA: 0x7FFE88022FE0
        public void get_pointerPressRaycast(){} // RVA: 0x7FFE88023060
        public void set_pointerPressRaycast(){} // RVA: 0x7FFE880230A0
        public void get_eligibleForClick(){} // RVA: 0x7FFE81F84060
        public void set_eligibleForClick(){} // RVA: 0x7FFE87B57E70
        public void get_displayIndex(){} // RVA: 0x7FFE81F82930
        public void set_displayIndex(){} // RVA: 0x7FFE87B57DF0
        public void get_pointerId(){} // RVA: 0x7FFE86FAEB50
        public void set_pointerId(){} // RVA: 0x7FFE88023130
        public void get_position(){} // RVA: 0x7FFE88023140
        public void set_position(){} // RVA: 0x7FFE88023160
        public void get_delta(){} // RVA: 0x7FFE88023170
        public void set_delta(){} // RVA: 0x7FFE88023190
        public void get_pressPosition(){} // RVA: 0x7FFE880231A0
        public void set_pressPosition(){} // RVA: 0x7FFE880231C0
        public void get_worldPosition(){} // RVA: 0x7FFE880231D0
        public void set_worldPosition(){} // RVA: 0x7FFE880231F0
        public void get_worldNormal(){} // RVA: 0x7FFE88023210
        public void set_worldNormal(){} // RVA: 0x7FFE88023230
        public void get_clickTime(){} // RVA: 0x7FFE88023250
        public void set_clickTime(){} // RVA: 0x7FFE88023260
        public void get_clickCount(){} // RVA: 0x7FFE81F60BB0
        public void set_clickCount(){} // RVA: 0x7FFE86C70910
        public void get_scrollDelta(){} // RVA: 0x7FFE86DBADB0
        public void set_scrollDelta(){} // RVA: 0x7FFE86DBADD0
        public void get_useDragThreshold(){} // RVA: 0x7FFE81630220
        public void set_useDragThreshold(){} // RVA: 0x7FFE88023270
        public void get_dragging(){} // RVA: 0x7FFE88023280
        public void set_dragging(){} // RVA: 0x7FFE88023290
        public void get_button(){} // RVA: 0x7FFE823676C0
        public void set_button(){} // RVA: 0x7FFE8234C440
        public void get_pressure(){} // RVA: 0x7FFE880232A0
        public void set_pressure(){} // RVA: 0x7FFE880232B0
        public void get_tangentialPressure(){} // RVA: 0x7FFE880232C0
        public void set_tangentialPressure(){} // RVA: 0x7FFE880232D0
        public void get_altitudeAngle(){} // RVA: 0x7FFE880232E0
        public void set_altitudeAngle(){} // RVA: 0x7FFE880232F0
        public void get_azimuthAngle(){} // RVA: 0x7FFE88023300
        public void set_azimuthAngle(){} // RVA: 0x7FFE88023310
        public void get_twist(){} // RVA: 0x7FFE87B0FC60
        public void set_twist(){} // RVA: 0x7FFE81F7F380
        public void get_tilt(){} // RVA: 0x7FFE88023320
        public void set_tilt(){} // RVA: 0x7FFE88023340
        public void get_penStatus(){} // RVA: 0x7FFE88023350
        public void set_penStatus(){} // RVA: 0x7FFE88023360
        public void get_radius(){} // RVA: 0x7FFE88023370
        public void set_radius(){} // RVA: 0x7FFE88023390
        public void get_radiusVariance(){} // RVA: 0x7FFE880233A0
        public void set_radiusVariance(){} // RVA: 0x7FFE880233C0
        public void get_fullyExited(){} // RVA: 0x7FFE880233D0
        public void set_fullyExited(){} // RVA: 0x7FFE880233E0
        public void get_reentered(){} // RVA: 0x7FFE8118B510
        public void set_reentered(){} // RVA: 0x7FFE8118B520
        public void .ctor(){} // RVA: 0x7FFE880233F0
        public void IsPointerMoving(){} // RVA: 0x7FFE88023710
        public void IsScrolling(){} // RVA: 0x7FFE88023740
        public void get_enterEventCamera(){} // RVA: 0x7FFE88023770
        public void get_pressEventCamera(){} // RVA: 0x7FFE88023890
        public void get_pointerPress(){} // RVA: 0x7FFE81129130
        public void set_pointerPress(){} // RVA: 0x7FFE880239C0
        public void ToString(){} // RVA: 0x7FFE88023B90
    }

    public class PointerEventDataExtension : Object
    {
        // ── Methods ──
        public void IsVRPointer(){} // RVA: 0x7FFE86D39D60
        public void GetRay(){} // RVA: 0x7FFE86D39DF0
        public void GetSwipeStart(){} // RVA: 0x7FFE86D39EA0
        public void SetSwipeStart(){} // RVA: 0x7FFE86D39F40
    }

    public class PointerInputModule : BaseInputModule
    {
        // ── Methods ──
        public void GetPointerData(){} // RVA: 0x7FFE8802C8A0
        public void RemovePointerData(){} // RVA: 0x7FFE8802CA00
        public void GetTouchPointerEventData(){} // RVA: 0x7FFE8802CA70
        public void CopyFromTo(){} // RVA: 0x7FFE8802CF10
        public void StateForMouseButton(){} // RVA: 0x7FFE8802D110
        public void GetMousePointerEventData(){} // RVA: 0x7FFE8802D1D0 | overloaded x2
        public void GetLastPointerEventData(){} // RVA: 0x7FFE8802DA90
        public void ShouldStartDrag(){} // RVA: 0x7FFE8802DAC0
        public void ProcessMove(){} // RVA: 0x7FFE8802DB10
        public void ProcessDrag(){} // RVA: 0x7FFE8802DBA0
        public void IsPointerOverGameObject(){} // RVA: 0x7FFE8802DF50
        public void ClearSelection(){} // RVA: 0x7FFE8802E060
        public void ToString(){} // RVA: 0x7FFE8802E2F0
        public void DeselectIfSelectionChanged(){} // RVA: 0x7FFE8802E640
        public void .ctor(){} // RVA: 0x7FFE8802E7E0
    }

    public class RaycastResult : ValueType
    {
        public UnityEngine.GameObject m_GameObject; // 0x10
        public UnityEngine.EventSystems.BaseRaycaster module; // 0x18

        // ── Methods ──
        public void get_gameObject(){} // RVA: 0x7FFE8284EF60
        public void set_gameObject(){} // RVA: 0x7FFE81D7E9E0
        public void get_isValid(){} // RVA: 0x7FFE88035F50
        public void Clear(){} // RVA: 0x7FFE880360C0
        public void ToString(){} // RVA: 0x7FFE88036250
    }

    public class RaycasterManager : Object
    {
        // ── Methods ──
        public void AddRaycaster(){} // RVA: 0x7FFE88033AF0
        public void GetRaycasters(){} // RVA: 0x7FFE88033C10
        public void RemoveRaycasters(){} // RVA: 0x7FFE88033C70
        public void .cctor(){} // RVA: 0x7FFE88033D50
    }

    public class StandaloneInputModule : PointerInputModule
    {
        public float m_PrevActionTime; // 0x68
        public UnityEngine.Vector2 m_LastMoveVector; // 0x6C
        public int m_ConsecutiveMoveCount; // 0x74
        public UnityEngine.Vector2 m_LastMousePosition; // 0x78
        public UnityEngine.Vector2 m_MousePosition; // 0x80
        public UnityEngine.GameObject m_CurrentFocusedGameObject; // 0x88
        public UnityEngine.EventSystems.PointerEventData m_InputPointerEvent; // 0x90
        public float doubleClickTime;
        public string m_HorizontalAxis; // 0x98

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8802EE60
        public void get_inputMode(){} // RVA: 0x7FFE813240E0
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x7FFE8111C4C0
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x7FFE8111C4D0
        public void get_forceModuleActive(){} // RVA: 0x7FFE8111C4C0
        public void set_forceModuleActive(){} // RVA: 0x7FFE8111C4D0
        public void get_inputActionsPerSecond(){} // RVA: 0x7FFE82A3B660
        public void set_inputActionsPerSecond(){} // RVA: 0x7FFE82A3B650
        public void get_repeatDelay(){} // RVA: 0x7FFE82A3B640
        public void set_repeatDelay(){} // RVA: 0x7FFE82A3B630
        public void get_horizontalAxis(){} // RVA: 0x7FFE817AE360
        public void set_horizontalAxis(){} // RVA: 0x7FFE8171B470
        public void get_verticalAxis(){} // RVA: 0x7FFE8179C860
        public void set_verticalAxis(){} // RVA: 0x7FFE8171B4D0
        public void get_submitButton(){} // RVA: 0x7FFE817AB5E0
        public void set_submitButton(){} // RVA: 0x7FFE81857260
        public void get_cancelButton(){} // RVA: 0x7FFE81166040
        public void set_cancelButton(){} // RVA: 0x7FFE81166050
        public void ShouldIgnoreEventsOnNoFocus(){} // RVA: 0x7FFE811E0850
        public void UpdateModule(){} // RVA: 0x7FFE8802F070
        public void ReleaseMouse(){} // RVA: 0x7FFE8802F270
        public void ShouldActivateModule(){} // RVA: 0x7FFE8802F8C0
        public void ActivateModule(){} // RVA: 0x7FFE8802FAD0
        public void DeactivateModule(){} // RVA: 0x7FFE825FB450
        public void Process(){} // RVA: 0x7FFE8802FCA0
        public void ProcessTouchEvents(){} // RVA: 0x7FFE8802FEC0
        public void ProcessTouchPress(){} // RVA: 0x7FFE880300D0
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x7FFE88030D90
        public void GetRawMoveVector(){} // RVA: 0x7FFE88030FE0
        public void SendMoveEventToSelectedObject(){} // RVA: 0x7FFE88031150
        public void ProcessMouseEvent(){} // RVA: 0x7FFE880314D0 | overloaded x2
        public void ForceAutoSelect(){} // RVA: 0x7FFE810FB320
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x7FFE880317A0
        public void ProcessMousePress(){} // RVA: 0x7FFE88031930
        public void GetCurrentFocusedGameObject(){} // RVA: 0x7FFE8113A010
    }

    public class TouchInputModule : PointerInputModule
    {
        public UnityEngine.Vector2 m_LastMousePosition; // 0x68
        public UnityEngine.Vector2 m_MousePosition; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE88032080
        public void get_allowActivationOnStandalone(){} // RVA: 0x7FFE813A1130
        public void set_allowActivationOnStandalone(){} // RVA: 0x7FFE813A2040
        public void get_forceModuleActive(){} // RVA: 0x7FFE813A1130
        public void set_forceModuleActive(){} // RVA: 0x7FFE813A2040
        public void UpdateModule(){} // RVA: 0x7FFE88032090
        public void IsModuleSupported(){} // RVA: 0x7FFE880322B0
        public void ShouldActivateModule(){} // RVA: 0x7FFE88032300
        public void UseFakeInput(){} // RVA: 0x7FFE88032400
        public void Process(){} // RVA: 0x7FFE88032440
        public void FakeTouches(){} // RVA: 0x7FFE880327B0
        public void ProcessTouchEvents(){} // RVA: 0x7FFE88032920
        public void ProcessTouchPress(){} // RVA: 0x7FFE88032B00
        public void DeactivateModule(){} // RVA: 0x7FFE825FB450
        public void ToString(){} // RVA: 0x7FFE88033720
    }

    public class UIBehaviour : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFE810FB310
        public void OnEnable(){} // RVA: 0x7FFE810FB310
        public void Start(){} // RVA: 0x7FFE810FB310
        public void OnDisable(){} // RVA: 0x7FFE810FB310
        public void OnDestroy(){} // RVA: 0x7FFE810FB310
        public void IsActive(){} // RVA: 0x7FFE87C63420
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFE810FB310
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7FFE810FB310
        public void OnTransformParentChanged(){} // RVA: 0x7FFE810FB310
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFE810FB310
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFE810FB310
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFE810FB310
        public void IsDestroyed(){} // RVA: 0x7FFE88036790
        public void .ctor(){} // RVA: 0x7FFE810FBD50
    }

}