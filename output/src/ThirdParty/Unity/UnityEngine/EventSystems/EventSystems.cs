// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.EventSystems
// Classes: 41
// Methods: 421

namespace ThirdParty.Unity.UnityEngine.EventSystems
{
    public class AbstractEventData
    {
        public bool m_Used; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x6BDA00
        public void Use(){} // RVA: 0x6BD7E0
        public void get_used(){} // RVA: 0x3A75E0
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class AxisEventData
    {
        public UnityEngine.Vector2 <moveVector>k__BackingField; // 0x20
        public 0x6596C9E0 <moveDir>k__BackingField; // 0x28

        // ── Methods ──
        public void get_moveVector(){} // RVA: 0xAE83B0
        public void set_moveVector(){} // RVA: 0xAE83A0
        public void get_moveDir(){} // RVA: 0x791DC0
        public void set_moveDir(){} // RVA: 0xA53440
        public void .ctor(){} // RVA: 0x74E2D50
    }

    public class BaseEventData
    {
        public UnityEngine.EventSystems.EventSystem m_EventSystem; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x343E80
        public void get_currentInputModule(){} // RVA: 0x606D2B0
        public void get_selectedObject(){} // RVA: 0x606D310
        public void set_selectedObject(){} // RVA: 0x74E2DF0
    }

    public class BaseInput
    {
        // ── Methods ──
        public void get_compositionString(){} // RVA: 0x71A8C90
        public void get_imeCompositionMode(){} // RVA: 0x71A8BF0
        public void set_imeCompositionMode(){} // RVA: 0x74EA410
        public void get_compositionCursorPos(){} // RVA: 0x74EA460
        public void set_compositionCursorPos(){} // RVA: 0x74EA4C0
        public void get_mousePresent(){} // RVA: 0x71A8DE0
        public void GetMouseButtonDown(){} // RVA: 0x73D6A50
        public void GetMouseButtonUp(){} // RVA: 0x73D6AA0
        public void GetMouseButton(){} // RVA: 0x74EA510
        public void get_mousePosition(){} // RVA: 0x74EA560
        public void get_mouseScrollDelta(){} // RVA: 0x74EA5D0
        public void get_touchSupported(){} // RVA: 0x1510190
        public void get_touchCount(){} // RVA: 0x71A8E30
        public void GetTouch(){} // RVA: 0x73D69A0
        public void GetAxisRaw(){} // RVA: 0x74EA630
        public void GetButtonDown(){} // RVA: 0x2FC020
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class BaseInputModule
    {
        public System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult> m_RaycastResultCache; // 0x20
        public bool m_SendPointerHoverToParent; // 0x28
        public UnityEngine.EventSystems.AxisEventData m_AxisEventData; // 0x30
        public UnityEngine.EventSystems.EventSystem m_EventSystem; // 0x38

        // ── Methods ──
        public void get_sendPointerHoverToParent(){} // RVA: 0x6E8A80
        public void set_sendPointerHoverToParent(){} // RVA: 0x6E8B80
        public void get_input(){} // RVA: 0x74EA680
        public void get_inputOverride(){} // RVA: 0x358730
        public void set_inputOverride(){} // RVA: 0x358740
        public void get_eventSystem(){} // RVA: 0x4976A0
        public void OnEnable(){} // RVA: 0x74EAA40
        public void OnDisable(){} // RVA: 0x74EAAE0
        public void Process(){} // RVA: 0x24A50
        public void FindFirstRaycast(){} // RVA: 0x74EAB00
        public void DetermineMoveDirection(){} // RVA: 0x74EAD10 | overloaded x2
        public void FindCommonRoot(){} // RVA: 0x74EAD90
        public void HandlePointerExitAndEnter(){} // RVA: 0x74EB170
        public void GetAxisEventData(){} // RVA: 0x74EC1D0
        public void GetBaseEventData(){} // RVA: 0x74EC310
        public void IsPointerOverGameObject(){} // RVA: 0x2DD320
        public void ShouldActivateModule(){} // RVA: 0x74EC440
        public void DeactivateModule(){} // RVA: 0x2DD310
        public void ActivateModule(){} // RVA: 0x2DD310
        public void UpdateModule(){} // RVA: 0x2DD310
        public void IsModuleSupported(){} // RVA: 0x3C2850
        public void ConvertUIToolkitPointerId(){} // RVA: 0x74EC530
        public void .ctor(){} // RVA: 0x74EC5D0
    }

    public class BaseRaycaster
    {
        public UnityEngine.EventSystems.BaseRaycaster m_RootRaycaster; // 0x20

        // ── Methods ──
        public void Raycast(){} // RVA: 0x2DC60
        public void get_eventCamera(){} // RVA: 0xCD60
        public void get_priority(){} // RVA: 0x519240
        public void get_sortOrderPriority(){} // RVA: 0x74F3C60
        public void get_renderOrderPriority(){} // RVA: 0x74F3C60
        public void get_rootRaycaster(){} // RVA: 0x74F3C70
        public void ToString(){} // RVA: 0x74F3DF0
        public void OnEnable(){} // RVA: 0x74F4100
        public void OnDisable(){} // RVA: 0x74F4250
        public void OnCanvasHierarchyChanged(){} // RVA: 0x5A57060
        public void OnTransformParentChanged(){} // RVA: 0x5A57060
        public void .ctor(){} // RVA: 0x2DDD50
    }

    public class EventSystem
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
        public void get_current(){} // RVA: 0x74E4500
        public void set_current(){} // RVA: 0x74E45E0
        public void get_sendNavigationEvents(){} // RVA: 0x4A6500
        public void set_sendNavigationEvents(){} // RVA: 0x4A78C0
        public void get_pixelDragThreshold(){} // RVA: 0x891AF0
        public void set_pixelDragThreshold(){} // RVA: 0x1CB95F0
        public void get_currentInputModule(){} // RVA: 0x30B130
        public void get_firstSelectedGameObject(){} // RVA: 0x6374D0
        public void set_firstSelectedGameObject(){} // RVA: 0x30B890
        public void get_currentSelectedGameObject(){} // RVA: 0x35A740
        public void get_lastSelectedGameObject(){} // RVA: 0x519240
        public void get_isFocused(){} // RVA: 0x394D30
        public void .ctor(){} // RVA: 0x74E47B0
        public void UpdateModules(){} // RVA: 0x74E48C0
        public void get_alreadySelecting(){} // RVA: 0x1376F50
        public void SetSelectedGameObject(){} // RVA: 0x74E4EE0 | overloaded x2
        public void get_baseEventDataCache(){} // RVA: 0x74E4DE0
        public void RaycastComparer(){} // RVA: 0x74E5000
        public void RaycastAll(){} // RVA: 0x74E5740
        public void IsPointerOverGameObject(){} // RVA: 0x74E5B60 | overloaded x2
        public void get_isUIToolkitActiveEventSystem(){} // RVA: 0x74E5C70
        public void get_sendUIToolkitEvents(){} // RVA: 0x74E5E90
        public void get_createUIToolkitPanelGameObjectsOnStart(){} // RVA: 0x74E5F00
        public void SetUITookitEventSystemOverride(){} // RVA: 0x74E5F70
        public void StartTrackingUIToolkitPanels(){} // RVA: 0x74E6290
        public void StopTrackingUIToolkitPanels(){} // RVA: 0x74E66B0
        public void CreateUIToolkitPanelGameObject(){} // RVA: 0x74E68C0
        public void Start(){} // RVA: 0x74E6CA0
        public void OnEnable(){} // RVA: 0x74E6CB0
        public void OnDisable(){} // RVA: 0x74E6E20
        public void TickModules(){} // RVA: 0x74E7000
        public void OnApplicationFocus(){} // RVA: 0x74E71A0
        public void Update(){} // RVA: 0x74E71B0
        public void ChangeEventModule(){} // RVA: 0x74E7650
        public void ToString(){} // RVA: 0x74E7920
        public void .cctor(){} // RVA: 0x74E7B30
    }

    public class EventTrigger
    {
        public System.Collections.Generic.List`1<Entry> m_Delegates; // 0x20

        // ── Methods ──
        public void get_delegates(){} // RVA: 0x74E7E10
        public void set_delegates(){} // RVA: 0x30B0D0
        public void .ctor(){} // RVA: 0x2DDD50
        public void get_triggers(){} // RVA: 0x74E7E20
        public void set_triggers(){} // RVA: 0x30B0D0
        public void Execute(){} // RVA: 0x74E7EE0
        public void OnPointerEnter(){} // RVA: 0x74E8000
        public void OnPointerExit(){} // RVA: 0x74E8010
        public void OnDrag(){} // RVA: 0x74E8020
        public void OnDrop(){} // RVA: 0x74E8030
        public void OnPointerDown(){} // RVA: 0x74E8040
        public void OnPointerUp(){} // RVA: 0x74E8050
        public void OnPointerClick(){} // RVA: 0x74E8060
        public void OnSelect(){} // RVA: 0x74E8070
        public void OnDeselect(){} // RVA: 0x74E8080
        public void OnScroll(){} // RVA: 0x74E8090
        public void OnMove(){} // RVA: 0x74E80A0
        public void OnUpdateSelected(){} // RVA: 0x74E80B0
        public void OnInitializePotentialDrag(){} // RVA: 0x74E80C0
        public void OnBeginDrag(){} // RVA: 0x74E80D0
        public void OnEndDrag(){} // RVA: 0x74E80E0
        public void OnSubmit(){} // RVA: 0x74E80F0
        public void OnCancel(){} // RVA: 0x74E8100
    }

    public class ExecuteEvents
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
        public void ValidateEventData(){} // RVA: 0x283FA0
        public void Execute(){} // RVA: 0x114C0 | overloaded x19
        public void get_pointerMoveHandler(){} // RVA: 0x74E8CB0
        public void get_pointerEnterHandler(){} // RVA: 0x74E8D10
        public void get_pointerExitHandler(){} // RVA: 0x74E8D70
        public void get_pointerDownHandler(){} // RVA: 0x74E8DD0
        public void get_pointerUpHandler(){} // RVA: 0x74E8E30
        public void get_pointerClickHandler(){} // RVA: 0x74E8E90
        public void get_initializePotentialDrag(){} // RVA: 0x74E8EF0
        public void get_beginDragHandler(){} // RVA: 0x74E8F50
        public void get_dragHandler(){} // RVA: 0x74E8FB0
        public void get_endDragHandler(){} // RVA: 0x74E9010
        public void get_dropHandler(){} // RVA: 0x74E9070
        public void get_scrollHandler(){} // RVA: 0x74E90D0
        public void get_updateSelectedHandler(){} // RVA: 0x74E9130
        public void get_selectHandler(){} // RVA: 0x74E9190
        public void get_deselectHandler(){} // RVA: 0x74E91F0
        public void get_moveHandler(){} // RVA: 0x74E9250
        public void get_submitHandler(){} // RVA: 0x74E92B0
        public void get_cancelHandler(){} // RVA: 0x74E9310
        public void GetEventChain(){} // RVA: 0x74E9370
        public void ExecuteHierarchy(){} // RVA: 0x1D550
        public void ShouldSendToComponent(){} // RVA: 0xDCC0
        public void GetEventList(){} // RVA: 0x24D50
        public void CanHandleEvent(){} // RVA: 0xDCC0
        public void GetEventHandler(){} // RVA: 0xCE50
        public void .cctor(){} // RVA: 0x74E9620
    }

    public class IBeginDragHandler
    {
        // ── Methods ──
        public void OnBeginDrag(){} // RVA: 0x24B10
    }

    public class ICancelHandler
    {
        // ── Methods ──
        public void OnCancel(){} // RVA: 0x24B10
    }

    public class IDeselectHandler
    {
        // ── Methods ──
        public void OnDeselect(){} // RVA: 0x24B10
    }

    public class IDragHandler
    {
        // ── Methods ──
        public void OnDrag(){} // RVA: 0x24B10
    }

    public class IDropHandler
    {
        // ── Methods ──
        public void OnDrop(){} // RVA: 0x24B10
    }

    public class IEndDragHandler
    {
        // ── Methods ──
        public void OnEndDrag(){} // RVA: 0x24B10
    }

    public class IEventSystemHandler
    {
    }

    public class IInitializePotentialDragHandler
    {
        // ── Methods ──
        public void OnInitializePotentialDrag(){} // RVA: 0x24B10
    }

    public class IMoveHandler
    {
        // ── Methods ──
        public void OnMove(){} // RVA: 0x24B10
    }

    public class IPointerClickHandler
    {
        // ── Methods ──
        public void OnPointerClick(){} // RVA: 0x24B10
    }

    public class IPointerDownHandler
    {
        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x24B10
    }

    public class IPointerEnterHandler
    {
        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x24B10
    }

    public class IPointerExitHandler
    {
        // ── Methods ──
        public void OnPointerExit(){} // RVA: 0x24B10
    }

    public class IPointerMoveHandler
    {
        // ── Methods ──
        public void OnPointerMove(){} // RVA: 0x24B10
    }

    public class IPointerUpHandler
    {
        // ── Methods ──
        public void OnPointerUp(){} // RVA: 0x24B10
    }

    public class IScrollHandler
    {
        // ── Methods ──
        public void OnScroll(){} // RVA: 0x24B10
    }

    public class ISelectHandler
    {
        // ── Methods ──
        public void OnSelect(){} // RVA: 0x24B10
    }

    public class ISubmitHandler
    {
        // ── Methods ──
        public void OnSubmit(){} // RVA: 0x24B10
    }

    public class IUpdateSelectedHandler
    {
        // ── Methods ──
        public void OnUpdateSelected(){} // RVA: 0x24B10
    }

    public class OVRInputModule
    {
        public UnityEngine.Transform rayTransform; // 0x68
        public OVRCursor m_Cursor; // 0x70
        public 0x658C00E0 joyPadClickButton; // 0x78
        public 0x658991A8 gazeClickKey; // 0x7C
        public bool performSphereCastForGazepointer; // 0x80
        public bool useRightStickScroll; // 0x81
        public float rightStickDeadZone; // 0x84

        // ── Methods ──
        public void .ctor(){} // RVA: 0x61F1F90
        public void get_inputMode(){} // RVA: 0x519240
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x6129410
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x61F2310
        public void get_inputActionsPerSecond(){} // RVA: 0x8A7990
        public void set_inputActionsPerSecond(){} // RVA: 0x8A7B30
        public void get_horizontalAxis(){} // RVA: 0x348120
        public void set_horizontalAxis(){} // RVA: 0x348130
        public void get_verticalAxis(){} // RVA: 0x435460
        public void set_verticalAxis(){} // RVA: 0x435470
        public void get_submitButton(){} // RVA: 0x3FA100
        public void set_submitButton(){} // RVA: 0x3FA110
        public void get_cancelButton(){} // RVA: 0xA96D30
        public void set_cancelButton(){} // RVA: 0x35E8A0
        public void UpdateModule(){} // RVA: 0x61F2320
        public void IsModuleSupported(){} // RVA: 0x61F23C0
        public void ShouldActivateModule(){} // RVA: 0x61F2420
        public void ActivateModule(){} // RVA: 0x61F2660
        public void DeactivateModule(){} // RVA: 0x61F2860
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x61F2870
        public void AllowMoveEventProcessing(){} // RVA: 0x61F2B00
        public void GetRawMoveVector(){} // RVA: 0x61F2BE0
        public void SendMoveEventToSelectedObject(){} // RVA: 0x61F2DC0
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x61F3000
        public void ProcessMousePress(){} // RVA: 0x61F3190
        public void ProcessMouseEvent(){} // RVA: 0x61F3DF0
        public void Process(){} // RVA: 0x61F4280
        public void UseMouse(){} // RVA: 0x61F4480
        public void CopyFromTo(){} // RVA: 0x61F46D0 | overloaded x2
        public void GetPointerData(){} // RVA: 0x61F4840
        public void ClearSelection(){} // RVA: 0x61F49A0
        public void GetRectTransformNormal(){} // RVA: 0x61F4E50
        public void GetGazePointerData(){} // RVA: 0x61F50B0
        public void GetCanvasPointerData(){} // RVA: 0x61F60A0
        public void ShouldStartDrag(){} // RVA: 0x61F6980
        public void IsPointerMoving(){} // RVA: 0x61F6D40
        public void SwipeAdjustedPosition(){} // RVA: 0x13DCE00
        public void ProcessDrag(){} // RVA: 0x61F6DE0
        public void GetGazeButtonState(){} // RVA: 0x61F72A0
        public void GetExtraScrollDelta(){} // RVA: 0x61F7490
    }

    public class OVRPhysicsRaycaster
    {
        public int kNoEventMaskSet;
        public UnityEngine.LayerMask m_EventMask; // 0x28
        public int sortOrder; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x105A720
        public void get_eventCamera(){} // RVA: 0x61F7590
        public void get_depth(){} // RVA: 0x61F7600
        public void get_sortOrderPriority(){} // RVA: 0x1209F00
        public void get_finalEventMask(){} // RVA: 0x61F7760
        public void get_eventMask(){} // RVA: 0x791DC0
        public void set_eventMask(){} // RVA: 0xA53440
        public void Raycast(){} // RVA: 0x61F78C0
        public void Spherecast(){} // RVA: 0x61F8030
        public void GetScreenPos(){} // RVA: 0x61F87C0
    }

    public class OVRPointerEventData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x61F8980
        public void ToString(){} // RVA: 0x61F8990
    }

    public class Physics2DRaycaster
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x17B5070
        public void Raycast(){} // RVA: 0x74F4360
    }

    public class PhysicsRaycaster
    {
        public int kNoEventMaskSet;
        public UnityEngine.Camera m_EventCamera; // 0x28
        public UnityEngine.LayerMask m_EventMask; // 0x30
        public int m_MaxRayIntersections; // 0x34
        public int m_LastMaxRayIntersections; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x17B5070
        public void get_eventCamera(){} // RVA: 0x74F4E10
        public void get_depth(){} // RVA: 0x74F5030
        public void get_finalEventMask(){} // RVA: 0x74F5190
        public void get_eventMask(){} // RVA: 0x338CD0
        public void set_eventMask(){} // RVA: 0x338CE0
        public void get_maxRayIntersections(){} // RVA: 0x4C6670
        public void set_maxRayIntersections(){} // RVA: 0x4C5F20
        public void ComputeRayAndDistance(){} // RVA: 0x74F52F0
        public void Raycast(){} // RVA: 0x74F5780
    }

    public class PointerEventData
    {
        public UnityEngine.GameObject <pointerEnter>k__BackingField; // 0x20
        public UnityEngine.GameObject m_PointerPress; // 0x28
        public UnityEngine.GameObject <lastPress>k__BackingField; // 0x30
        public UnityEngine.GameObject <rawPointerPress>k__BackingField; // 0x38
        public UnityEngine.GameObject <pointerDrag>k__BackingField; // 0x40
        public UnityEngine.GameObject <pointerClick>k__BackingField; // 0x48
        public UnityEngine.EventSystems.RaycastResult <pointerCurrentRaycast>k__BackingField; // 0x50
        public UnityEngine.EventSystems.RaycastResult <pointerPressRaycast>k__BackingField; // 0xA0
        public System.Collections.Generic.List`1<UnityEngine.GameObject> hovered; // 0xF0
        public bool <eligibleForClick>k__BackingField; // 0xF8
        public int <displayIndex>k__BackingField; // 0xFC
        public int <pointerId>k__BackingField; // 0x100
        public UnityEngine.Vector2 <position>k__BackingField; // 0x104
        public UnityEngine.Vector2 <delta>k__BackingField; // 0x10C
        public UnityEngine.Vector2 <pressPosition>k__BackingField; // 0x114
        public UnityEngine.Vector3 <worldPosition>k__BackingField; // 0x11C
        public UnityEngine.Vector3 <worldNormal>k__BackingField; // 0x128
        public float <clickTime>k__BackingField; // 0x134
        public int <clickCount>k__BackingField; // 0x138
        public UnityEngine.Vector2 <scrollDelta>k__BackingField; // 0x13C
        public bool <useDragThreshold>k__BackingField; // 0x144
        public bool <dragging>k__BackingField; // 0x145
        public 0x6596BBC8 <button>k__BackingField; // 0x148
        public float <pressure>k__BackingField; // 0x14C
        public float <tangentialPressure>k__BackingField; // 0x150
        public float <altitudeAngle>k__BackingField; // 0x154
        public float <azimuthAngle>k__BackingField; // 0x158
        public float <twist>k__BackingField; // 0x15C
        public UnityEngine.Vector2 <tilt>k__BackingField; // 0x160
        public 0x659FBB98 <penStatus>k__BackingField; // 0x168
        public UnityEngine.Vector2 <radius>k__BackingField; // 0x16C
        public UnityEngine.Vector2 <radiusVariance>k__BackingField; // 0x174
        public bool <fullyExited>k__BackingField; // 0x17C
        public bool <reentered>k__BackingField; // 0x17D

        // ── Methods ──
        public void get_pointerEnter(){} // RVA: 0x30B0C0
        public void set_pointerEnter(){} // RVA: 0x30B0D0
        public void get_lastPress(){} // RVA: 0x6374D0
        public void set_lastPress(){} // RVA: 0x30B890
        public void get_rawPointerPress(){} // RVA: 0x4976A0
        public void set_rawPointerPress(){} // RVA: 0x49B830
        public void get_pointerDrag(){} // RVA: 0x35A740
        public void set_pointerDrag(){} // RVA: 0x305200
        public void get_pointerClick(){} // RVA: 0x358730
        public void set_pointerClick(){} // RVA: 0x358740
        public void get_pointerCurrentRaycast(){} // RVA: 0x4231650
        public void set_pointerCurrentRaycast(){} // RVA: 0x74E2E20
        public void get_pointerPressRaycast(){} // RVA: 0x74E2EA0
        public void set_pointerPressRaycast(){} // RVA: 0x74E2EE0
        public void get_eligibleForClick(){} // RVA: 0x1209D80
        public void set_eligibleForClick(){} // RVA: 0x7016FA0
        public void get_displayIndex(){} // RVA: 0x120BB40
        public void set_displayIndex(){} // RVA: 0x7016F20
        public void get_pointerId(){} // RVA: 0x646FCD0
        public void set_pointerId(){} // RVA: 0x74E2F70
        public void get_position(){} // RVA: 0x74E2F80
        public void set_position(){} // RVA: 0x74E2FA0
        public void get_delta(){} // RVA: 0x74E2FB0
        public void set_delta(){} // RVA: 0x74E2FD0
        public void get_pressPosition(){} // RVA: 0x74E2FE0
        public void set_pressPosition(){} // RVA: 0x74E3000
        public void get_worldPosition(){} // RVA: 0x74E3010
        public void set_worldPosition(){} // RVA: 0x74E3030
        public void get_worldNormal(){} // RVA: 0x74E3050
        public void set_worldNormal(){} // RVA: 0x74E3070
        public void get_clickTime(){} // RVA: 0x74E3090
        public void set_clickTime(){} // RVA: 0x74E30A0
        public void get_clickCount(){} // RVA: 0x120A360
        public void set_clickCount(){} // RVA: 0x612FB30
        public void get_scrollDelta(){} // RVA: 0x627A380
        public void set_scrollDelta(){} // RVA: 0x627A3A0
        public void get_useDragThreshold(){} // RVA: 0x88FF40
        public void set_useDragThreshold(){} // RVA: 0x11D7DD0
        public void get_dragging(){} // RVA: 0x74E30B0
        public void set_dragging(){} // RVA: 0x74E30C0
        public void get_button(){} // RVA: 0x15FA5E0
        public void set_button(){} // RVA: 0x15DF3A0
        public void get_pressure(){} // RVA: 0x74E30D0
        public void set_pressure(){} // RVA: 0x74E30E0
        public void get_tangentialPressure(){} // RVA: 0x74E30F0
        public void set_tangentialPressure(){} // RVA: 0x74E3100
        public void get_altitudeAngle(){} // RVA: 0x74E3110
        public void set_altitudeAngle(){} // RVA: 0x74E3120
        public void get_azimuthAngle(){} // RVA: 0x74E3130
        public void set_azimuthAngle(){} // RVA: 0x74E3140
        public void get_twist(){} // RVA: 0x6FCEDD0
        public void set_twist(){} // RVA: 0x120CD90
        public void get_tilt(){} // RVA: 0x74E3150
        public void set_tilt(){} // RVA: 0x74E3170
        public void get_penStatus(){} // RVA: 0x74E3180
        public void set_penStatus(){} // RVA: 0x74E3190
        public void get_radius(){} // RVA: 0x74E31A0
        public void set_radius(){} // RVA: 0x74E31C0
        public void get_radiusVariance(){} // RVA: 0x74E31D0
        public void set_radiusVariance(){} // RVA: 0x74E31F0
        public void get_fullyExited(){} // RVA: 0x74E3200
        public void set_fullyExited(){} // RVA: 0x74E3210
        public void get_reentered(){} // RVA: 0x36D510
        public void set_reentered(){} // RVA: 0x36D520
        public void .ctor(){} // RVA: 0x74E3220
        public void IsPointerMoving(){} // RVA: 0x74E3540
        public void IsScrolling(){} // RVA: 0x74E3570
        public void get_enterEventCamera(){} // RVA: 0x74E35A0
        public void get_pressEventCamera(){} // RVA: 0x74E36C0
        public void get_pointerPress(){} // RVA: 0x30B130
        public void set_pointerPress(){} // RVA: 0x74E37F0
        public void ToString(){} // RVA: 0x74E39C0
    }

    public class PointerEventDataExtension
    {
        // ── Methods ──
        public void IsVRPointer(){} // RVA: 0x61F8EC0
        public void GetRay(){} // RVA: 0x61F8F50
        public void GetSwipeStart(){} // RVA: 0x61F9000
        public void SetSwipeStart(){} // RVA: 0x61F90A0
    }

    public class PointerInputModule
    {
        // ── Methods ──
        public void GetPointerData(){} // RVA: 0x74EC6D0
        public void RemovePointerData(){} // RVA: 0x74EC830
        public void GetTouchPointerEventData(){} // RVA: 0x74EC8A0
        public void CopyFromTo(){} // RVA: 0x74ECD40
        public void StateForMouseButton(){} // RVA: 0x74ECF40
        public void GetMousePointerEventData(){} // RVA: 0x74ED000 | overloaded x2
        public void GetLastPointerEventData(){} // RVA: 0x74ED8C0
        public void ShouldStartDrag(){} // RVA: 0x74ED8F0
        public void ProcessMove(){} // RVA: 0x74ED940
        public void ProcessDrag(){} // RVA: 0x74ED9D0
        public void IsPointerOverGameObject(){} // RVA: 0x74EDD80
        public void ClearSelection(){} // RVA: 0x74EDE90
        public void ToString(){} // RVA: 0x74EE120
        public void DeselectIfSelectionChanged(){} // RVA: 0x74EE470
        public void .ctor(){} // RVA: 0x74EE610
    }

    public class RaycastResult
    {
        public UnityEngine.GameObject m_GameObject; // 0x10
        public UnityEngine.EventSystems.BaseRaycaster module; // 0x18

        // ── Methods ──
        public void get_gameObject(){} // RVA: 0x1AD4690
        public void set_gameObject(){} // RVA: 0x100A2F0
        public void get_isValid(){} // RVA: 0x74F5D80
        public void Clear(){} // RVA: 0x74F5EF0
        public void ToString(){} // RVA: 0x74F6080
    }

    public class RaycasterManager
    {
        // ── Methods ──
        public void AddRaycaster(){} // RVA: 0x74F3920
        public void GetRaycasters(){} // RVA: 0x74F3A40
        public void RemoveRaycasters(){} // RVA: 0x74F3AA0
        public void .cctor(){} // RVA: 0x74F3B80
    }

    public class StandaloneInputModule
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
        public void .ctor(){} // RVA: 0x74EEC90
        public void get_inputMode(){} // RVA: 0x519240
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x2FE4C0
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x2FE4D0
        public void get_forceModuleActive(){} // RVA: 0x2FE4C0
        public void set_forceModuleActive(){} // RVA: 0x2FE4D0
        public void get_inputActionsPerSecond(){} // RVA: 0x1CA9BD0
        public void set_inputActionsPerSecond(){} // RVA: 0x1CA9BC0
        public void get_repeatDelay(){} // RVA: 0x1CA9BB0
        public void set_repeatDelay(){} // RVA: 0x1CA9BA0
        public void get_horizontalAxis(){} // RVA: 0xA1C8C0
        public void set_horizontalAxis(){} // RVA: 0x9AA650
        public void get_verticalAxis(){} // RVA: 0xA085E0
        public void set_verticalAxis(){} // RVA: 0x9AA5F0
        public void get_submitButton(){} // RVA: 0xA1C130
        public void set_submitButton(){} // RVA: 0xAE5030
        public void get_cancelButton(){} // RVA: 0x348040
        public void set_cancelButton(){} // RVA: 0x348050
        public void ShouldIgnoreEventsOnNoFocus(){} // RVA: 0x3C2850
        public void UpdateModule(){} // RVA: 0x74EEEA0
        public void ReleaseMouse(){} // RVA: 0x74EF0A0
        public void ShouldActivateModule(){} // RVA: 0x74EF6F0
        public void ActivateModule(){} // RVA: 0x74EF900
        public void DeactivateModule(){} // RVA: 0x188A600
        public void Process(){} // RVA: 0x74EFAD0
        public void ProcessTouchEvents(){} // RVA: 0x74EFCF0
        public void ProcessTouchPress(){} // RVA: 0x74EFF00
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x74F0BC0
        public void GetRawMoveVector(){} // RVA: 0x74F0E10
        public void SendMoveEventToSelectedObject(){} // RVA: 0x74F0F80
        public void ProcessMouseEvent(){} // RVA: 0x74F1300 | overloaded x2
        public void ForceAutoSelect(){} // RVA: 0x2DD320
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x74F15D0
        public void ProcessMousePress(){} // RVA: 0x74F1760
        public void GetCurrentFocusedGameObject(){} // RVA: 0x31C010
    }

    public class TouchInputModule
    {
        public UnityEngine.Vector2 m_LastMousePosition; // 0x68
        public UnityEngine.Vector2 m_MousePosition; // 0x70

        // ── Methods ──
        public void .ctor(){} // RVA: 0x74F1EB0
        public void get_allowActivationOnStandalone(){} // RVA: 0x5A8B10
        public void set_allowActivationOnStandalone(){} // RVA: 0x5A6190
        public void get_forceModuleActive(){} // RVA: 0x5A8B10
        public void set_forceModuleActive(){} // RVA: 0x5A6190
        public void UpdateModule(){} // RVA: 0x74F1EC0
        public void IsModuleSupported(){} // RVA: 0x74F20E0
        public void ShouldActivateModule(){} // RVA: 0x74F2130
        public void UseFakeInput(){} // RVA: 0x74F2230
        public void Process(){} // RVA: 0x74F2270
        public void FakeTouches(){} // RVA: 0x74F25E0
        public void ProcessTouchEvents(){} // RVA: 0x74F2750
        public void ProcessTouchPress(){} // RVA: 0x74F2930
        public void DeactivateModule(){} // RVA: 0x188A600
        public void ToString(){} // RVA: 0x74F3550
    }

    public class UIBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x2DD310
        public void OnEnable(){} // RVA: 0x2DD310
        public void Start(){} // RVA: 0x2DD310
        public void OnDisable(){} // RVA: 0x2DD310
        public void OnDestroy(){} // RVA: 0x2DD310
        public void IsActive(){} // RVA: 0x7122760
        public void OnRectTransformDimensionsChange(){} // RVA: 0x2DD310
        public void OnBeforeTransformParentChanged(){} // RVA: 0x2DD310
        public void OnTransformParentChanged(){} // RVA: 0x2DD310
        public void OnDidApplyAnimationProperties(){} // RVA: 0x2DD310
        public void OnCanvasGroupChanged(){} // RVA: 0x2DD310
        public void OnCanvasHierarchyChanged(){} // RVA: 0x2DD310
        public void IsDestroyed(){} // RVA: 0x74F65C0
        public void .ctor(){} // RVA: 0x2DDD50
    }

}