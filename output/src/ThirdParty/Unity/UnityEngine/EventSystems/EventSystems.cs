// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.EventSystems
// Classes: 41
// Methods: 421

namespace ThirdParty.Unity.UnityEngine.EventSystems
{
    public class AbstractEventData
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAF316DA00
        public void Use(){} // RVA: 0x7FFAF316D7E0
        public void get_used(){} // RVA: 0x7FFAF2E575E0
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class AxisEventData
    {
        // ── Methods ──
        public void get_moveVector(){} // RVA: 0x7FFAF35983B0
        public void set_moveVector(){} // RVA: 0x7FFAF35983A0
        public void get_moveDir(){} // RVA: 0x7FFAF3241DC0
        public void set_moveDir(){} // RVA: 0x7FFAF3503440
        public void .ctor(){} // RVA: 0x7FFAF9F92D50
    }

    public class BaseEventData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2DF3E80
        public void get_currentInputModule(){} // RVA: 0x7FFAF8B1D2B0
        public void get_selectedObject(){} // RVA: 0x7FFAF8B1D310
        public void set_selectedObject(){} // RVA: 0x7FFAF9F92DF0
    }

    public class BaseInput
    {
        // ── Methods ──
        public void get_compositionString(){} // RVA: 0x7FFAF9C58C90
        public void get_imeCompositionMode(){} // RVA: 0x7FFAF9C58BF0
        public void set_imeCompositionMode(){} // RVA: 0x7FFAF9F9A410
        public void get_compositionCursorPos(){} // RVA: 0x7FFAF9F9A460
        public void set_compositionCursorPos(){} // RVA: 0x7FFAF9F9A4C0
        public void get_mousePresent(){} // RVA: 0x7FFAF9C58DE0
        public void GetMouseButtonDown(){} // RVA: 0x7FFAF9E86A50
        public void GetMouseButtonUp(){} // RVA: 0x7FFAF9E86AA0
        public void GetMouseButton(){} // RVA: 0x7FFAF9F9A510
        public void get_mousePosition(){} // RVA: 0x7FFAF9F9A560
        public void get_mouseScrollDelta(){} // RVA: 0x7FFAF9F9A5D0
        public void get_touchSupported(){} // RVA: 0x7FFAF3FC0190
        public void get_touchCount(){} // RVA: 0x7FFAF9C58E30
        public void GetTouch(){} // RVA: 0x7FFAF9E869A0
        public void GetAxisRaw(){} // RVA: 0x7FFAF9F9A630
        public void GetButtonDown(){} // RVA: 0x7FFAF2DAC020
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class BaseInputModule
    {
        // ── Methods ──
        public void get_sendPointerHoverToParent(){} // RVA: 0x7FFAF3198A80
        public void set_sendPointerHoverToParent(){} // RVA: 0x7FFAF3198B80
        public void get_input(){} // RVA: 0x7FFAF9F9A680
        public void get_inputOverride(){} // RVA: 0x7FFAF2E08730
        public void set_inputOverride(){} // RVA: 0x7FFAF2E08740
        public void get_eventSystem(){} // RVA: 0x7FFAF2F476A0
        public void OnEnable(){} // RVA: 0x7FFAF9F9AA40
        public void OnDisable(){} // RVA: 0x7FFAF9F9AAE0
        public void Process(){} // RVA: 0x7FFAF2AD4A50
        public void FindFirstRaycast(){} // RVA: 0x7FFAF9F9AB00
        public void DetermineMoveDirection(){} // RVA: 0x7FFAF9F9AD10 | overloaded x2
        public void FindCommonRoot(){} // RVA: 0x7FFAF9F9AD90
        public void HandlePointerExitAndEnter(){} // RVA: 0x7FFAF9F9B170
        public void GetAxisEventData(){} // RVA: 0x7FFAF9F9C1D0
        public void GetBaseEventData(){} // RVA: 0x7FFAF9F9C310
        public void IsPointerOverGameObject(){} // RVA: 0x7FFAF2D8D320
        public void ShouldActivateModule(){} // RVA: 0x7FFAF9F9C440
        public void DeactivateModule(){} // RVA: 0x7FFAF2D8D310
        public void ActivateModule(){} // RVA: 0x7FFAF2D8D310
        public void UpdateModule(){} // RVA: 0x7FFAF2D8D310
        public void IsModuleSupported(){} // RVA: 0x7FFAF2E72850
        public void ConvertUIToolkitPointerId(){} // RVA: 0x7FFAF9F9C530
        public void .ctor(){} // RVA: 0x7FFAF9F9C5D0
    }

    public class BaseRaycaster
    {
        // ── Methods ──
        public void Raycast(){} // RVA: 0x7FFAF2ADDC60
        public void get_eventCamera(){} // RVA: 0x7FFAF2ABCD60
        public void get_priority(){} // RVA: 0x7FFAF2FC9240
        public void get_sortOrderPriority(){} // RVA: 0x7FFAF9FA3C60
        public void get_renderOrderPriority(){} // RVA: 0x7FFAF9FA3C60
        public void get_rootRaycaster(){} // RVA: 0x7FFAF9FA3C70
        public void ToString(){} // RVA: 0x7FFAF9FA3DF0
        public void OnEnable(){} // RVA: 0x7FFAF9FA4100
        public void OnDisable(){} // RVA: 0x7FFAF9FA4250
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFAF8507060
        public void OnTransformParentChanged(){} // RVA: 0x7FFAF8507060
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

    public class EventSystem
    {
        // ── Methods ──
        public void get_current(){} // RVA: 0x7FFAF9F94500
        public void set_current(){} // RVA: 0x7FFAF9F945E0
        public void get_sendNavigationEvents(){} // RVA: 0x7FFAF2F56500
        public void set_sendNavigationEvents(){} // RVA: 0x7FFAF2F578C0
        public void get_pixelDragThreshold(){} // RVA: 0x7FFAF3341AF0
        public void set_pixelDragThreshold(){} // RVA: 0x7FFAF47695F0
        public void get_currentInputModule(){} // RVA: 0x7FFAF2DBB130
        public void get_firstSelectedGameObject(){} // RVA: 0x7FFAF30E74D0
        public void set_firstSelectedGameObject(){} // RVA: 0x7FFAF2DBB890
        public void get_currentSelectedGameObject(){} // RVA: 0x7FFAF2E0A740
        public void get_lastSelectedGameObject(){} // RVA: 0x7FFAF2FC9240
        public void get_isFocused(){} // RVA: 0x7FFAF2E44D30
        public void .ctor(){} // RVA: 0x7FFAF9F947B0
        public void UpdateModules(){} // RVA: 0x7FFAF9F948C0
        public void get_alreadySelecting(){} // RVA: 0x7FFAF3E26F50
        public void SetSelectedGameObject(){} // RVA: 0x7FFAF9F94EE0 | overloaded x2
        public void get_baseEventDataCache(){} // RVA: 0x7FFAF9F94DE0
        public void RaycastComparer(){} // RVA: 0x7FFAF9F95000
        public void RaycastAll(){} // RVA: 0x7FFAF9F95740
        public void IsPointerOverGameObject(){} // RVA: 0x7FFAF9F95B60 | overloaded x2
        public void get_isUIToolkitActiveEventSystem(){} // RVA: 0x7FFAF9F95C70
        public void get_sendUIToolkitEvents(){} // RVA: 0x7FFAF9F95E90
        public void get_createUIToolkitPanelGameObjectsOnStart(){} // RVA: 0x7FFAF9F95F00
        public void SetUITookitEventSystemOverride(){} // RVA: 0x7FFAF9F95F70
        public void StartTrackingUIToolkitPanels(){} // RVA: 0x7FFAF9F96290
        public void StopTrackingUIToolkitPanels(){} // RVA: 0x7FFAF9F966B0
        public void CreateUIToolkitPanelGameObject(){} // RVA: 0x7FFAF9F968C0
        public void Start(){} // RVA: 0x7FFAF9F96CA0
        public void OnEnable(){} // RVA: 0x7FFAF9F96CB0
        public void OnDisable(){} // RVA: 0x7FFAF9F96E20
        public void TickModules(){} // RVA: 0x7FFAF9F97000
        public void OnApplicationFocus(){} // RVA: 0x7FFAF9F971A0
        public void Update(){} // RVA: 0x7FFAF9F971B0
        public void ChangeEventModule(){} // RVA: 0x7FFAF9F97650
        public void ToString(){} // RVA: 0x7FFAF9F97920
        public void .cctor(){} // RVA: 0x7FFAF9F97B30
    }

    public class EventTrigger
    {
        // ── Methods ──
        public void get_delegates(){} // RVA: 0x7FFAF9F97E10
        public void set_delegates(){} // RVA: 0x7FFAF2DBB0D0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
        public void get_triggers(){} // RVA: 0x7FFAF9F97E20
        public void set_triggers(){} // RVA: 0x7FFAF2DBB0D0
        public void Execute(){} // RVA: 0x7FFAF9F97EE0
        public void OnPointerEnter(){} // RVA: 0x7FFAF9F98000
        public void OnPointerExit(){} // RVA: 0x7FFAF9F98010
        public void OnDrag(){} // RVA: 0x7FFAF9F98020
        public void OnDrop(){} // RVA: 0x7FFAF9F98030
        public void OnPointerDown(){} // RVA: 0x7FFAF9F98040
        public void OnPointerUp(){} // RVA: 0x7FFAF9F98050
        public void OnPointerClick(){} // RVA: 0x7FFAF9F98060
        public void OnSelect(){} // RVA: 0x7FFAF9F98070
        public void OnDeselect(){} // RVA: 0x7FFAF9F98080
        public void OnScroll(){} // RVA: 0x7FFAF9F98090
        public void OnMove(){} // RVA: 0x7FFAF9F980A0
        public void OnUpdateSelected(){} // RVA: 0x7FFAF9F980B0
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFAF9F980C0
        public void OnBeginDrag(){} // RVA: 0x7FFAF9F980D0
        public void OnEndDrag(){} // RVA: 0x7FFAF9F980E0
        public void OnSubmit(){} // RVA: 0x7FFAF9F980F0
        public void OnCancel(){} // RVA: 0x7FFAF9F98100
    }

    public class ExecuteEvents
    {
        // ── Methods ──
        public void ValidateEventData(){} // RVA: 0x7FFAF2D33FA0
        public void Execute(){} // RVA: 0x7FFAF2AC14C0 | overloaded x19
        public void get_pointerMoveHandler(){} // RVA: 0x7FFAF9F98CB0
        public void get_pointerEnterHandler(){} // RVA: 0x7FFAF9F98D10
        public void get_pointerExitHandler(){} // RVA: 0x7FFAF9F98D70
        public void get_pointerDownHandler(){} // RVA: 0x7FFAF9F98DD0
        public void get_pointerUpHandler(){} // RVA: 0x7FFAF9F98E30
        public void get_pointerClickHandler(){} // RVA: 0x7FFAF9F98E90
        public void get_initializePotentialDrag(){} // RVA: 0x7FFAF9F98EF0
        public void get_beginDragHandler(){} // RVA: 0x7FFAF9F98F50
        public void get_dragHandler(){} // RVA: 0x7FFAF9F98FB0
        public void get_endDragHandler(){} // RVA: 0x7FFAF9F99010
        public void get_dropHandler(){} // RVA: 0x7FFAF9F99070
        public void get_scrollHandler(){} // RVA: 0x7FFAF9F990D0
        public void get_updateSelectedHandler(){} // RVA: 0x7FFAF9F99130
        public void get_selectHandler(){} // RVA: 0x7FFAF9F99190
        public void get_deselectHandler(){} // RVA: 0x7FFAF9F991F0
        public void get_moveHandler(){} // RVA: 0x7FFAF9F99250
        public void get_submitHandler(){} // RVA: 0x7FFAF9F992B0
        public void get_cancelHandler(){} // RVA: 0x7FFAF9F99310
        public void GetEventChain(){} // RVA: 0x7FFAF9F99370
        public void ExecuteHierarchy(){} // RVA: 0x7FFAF2ACD550
        public void ShouldSendToComponent(){} // RVA: 0x7FFAF2ABDCC0
        public void GetEventList(){} // RVA: 0x7FFAF2AD4D50
        public void CanHandleEvent(){} // RVA: 0x7FFAF2ABDCC0
        public void GetEventHandler(){} // RVA: 0x7FFAF2ABCE50
        public void .cctor(){} // RVA: 0x7FFAF9F99620
    }

    public class IBeginDragHandler
    {
        // ── Methods ──
        public void OnBeginDrag(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ICancelHandler
    {
        // ── Methods ──
        public void OnCancel(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IDeselectHandler
    {
        // ── Methods ──
        public void OnDeselect(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IDragHandler
    {
        // ── Methods ──
        public void OnDrag(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IDropHandler
    {
        // ── Methods ──
        public void OnDrop(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IEndDragHandler
    {
        // ── Methods ──
        public void OnEndDrag(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IEventSystemHandler
    {
    }

    public class IInitializePotentialDragHandler
    {
        // ── Methods ──
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IMoveHandler
    {
        // ── Methods ──
        public void OnMove(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IPointerClickHandler
    {
        // ── Methods ──
        public void OnPointerClick(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IPointerDownHandler
    {
        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IPointerEnterHandler
    {
        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IPointerExitHandler
    {
        // ── Methods ──
        public void OnPointerExit(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IPointerMoveHandler
    {
        // ── Methods ──
        public void OnPointerMove(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IPointerUpHandler
    {
        // ── Methods ──
        public void OnPointerUp(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IScrollHandler
    {
        // ── Methods ──
        public void OnScroll(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ISelectHandler
    {
        // ── Methods ──
        public void OnSelect(){} // RVA: 0x7FFAF2AD4B10
    }

    public class ISubmitHandler
    {
        // ── Methods ──
        public void OnSubmit(){} // RVA: 0x7FFAF2AD4B10
    }

    public class IUpdateSelectedHandler
    {
        // ── Methods ──
        public void OnUpdateSelected(){} // RVA: 0x7FFAF2AD4B10
    }

    public class OVRInputModule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CA1F90
        public void get_inputMode(){} // RVA: 0x7FFAF2FC9240
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x7FFAF8BD9410
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x7FFAF8CA2310
        public void get_inputActionsPerSecond(){} // RVA: 0x7FFAF3357990
        public void set_inputActionsPerSecond(){} // RVA: 0x7FFAF3357B30
        public void get_horizontalAxis(){} // RVA: 0x7FFAF2DF8120
        public void set_horizontalAxis(){} // RVA: 0x7FFAF2DF8130
        public void get_verticalAxis(){} // RVA: 0x7FFAF2EE5460
        public void set_verticalAxis(){} // RVA: 0x7FFAF2EE5470
        public void get_submitButton(){} // RVA: 0x7FFAF2EAA100
        public void set_submitButton(){} // RVA: 0x7FFAF2EAA110
        public void get_cancelButton(){} // RVA: 0x7FFAF3546D30
        public void set_cancelButton(){} // RVA: 0x7FFAF2E0E8A0
        public void UpdateModule(){} // RVA: 0x7FFAF8CA2320
        public void IsModuleSupported(){} // RVA: 0x7FFAF8CA23C0
        public void ShouldActivateModule(){} // RVA: 0x7FFAF8CA2420
        public void ActivateModule(){} // RVA: 0x7FFAF8CA2660
        public void DeactivateModule(){} // RVA: 0x7FFAF8CA2860
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x7FFAF8CA2870
        public void AllowMoveEventProcessing(){} // RVA: 0x7FFAF8CA2B00
        public void GetRawMoveVector(){} // RVA: 0x7FFAF8CA2BE0
        public void SendMoveEventToSelectedObject(){} // RVA: 0x7FFAF8CA2DC0
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x7FFAF8CA3000
        public void ProcessMousePress(){} // RVA: 0x7FFAF8CA3190
        public void ProcessMouseEvent(){} // RVA: 0x7FFAF8CA3DF0
        public void Process(){} // RVA: 0x7FFAF8CA4280
        public void UseMouse(){} // RVA: 0x7FFAF8CA4480
        public void CopyFromTo(){} // RVA: 0x7FFAF8CA46D0 | overloaded x2
        public void GetPointerData(){} // RVA: 0x7FFAF8CA4840
        public void ClearSelection(){} // RVA: 0x7FFAF8CA49A0
        public void GetRectTransformNormal(){} // RVA: 0x7FFAF8CA4E50
        public void GetGazePointerData(){} // RVA: 0x7FFAF8CA50B0
        public void GetCanvasPointerData(){} // RVA: 0x7FFAF8CA60A0
        public void ShouldStartDrag(){} // RVA: 0x7FFAF8CA6980
        public void IsPointerMoving(){} // RVA: 0x7FFAF8CA6D40
        public void SwipeAdjustedPosition(){} // RVA: 0x7FFAF3E8CE00
        public void ProcessDrag(){} // RVA: 0x7FFAF8CA6DE0
        public void GetGazeButtonState(){} // RVA: 0x7FFAF8CA72A0
        public void GetExtraScrollDelta(){} // RVA: 0x7FFAF8CA7490
    }

    public class OVRPhysicsRaycaster
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF3B0A720
        public void get_eventCamera(){} // RVA: 0x7FFAF8CA7590
        public void get_depth(){} // RVA: 0x7FFAF8CA7600
        public void get_sortOrderPriority(){} // RVA: 0x7FFAF3CB9F00
        public void get_finalEventMask(){} // RVA: 0x7FFAF8CA7760
        public void get_eventMask(){} // RVA: 0x7FFAF3241DC0
        public void set_eventMask(){} // RVA: 0x7FFAF3503440
        public void Raycast(){} // RVA: 0x7FFAF8CA78C0
        public void Spherecast(){} // RVA: 0x7FFAF8CA8030
        public void GetScreenPos(){} // RVA: 0x7FFAF8CA87C0
    }

    public class OVRPointerEventData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF8CA8980
        public void ToString(){} // RVA: 0x7FFAF8CA8990
    }

    public class Physics2DRaycaster
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4265070
        public void Raycast(){} // RVA: 0x7FFAF9FA4360
    }

    public class PhysicsRaycaster
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF4265070
        public void get_eventCamera(){} // RVA: 0x7FFAF9FA4E10
        public void get_depth(){} // RVA: 0x7FFAF9FA5030
        public void get_finalEventMask(){} // RVA: 0x7FFAF9FA5190
        public void get_eventMask(){} // RVA: 0x7FFAF2DE8CD0
        public void set_eventMask(){} // RVA: 0x7FFAF2DE8CE0
        public void get_maxRayIntersections(){} // RVA: 0x7FFAF2F76670
        public void set_maxRayIntersections(){} // RVA: 0x7FFAF2F75F20
        public void ComputeRayAndDistance(){} // RVA: 0x7FFAF9FA52F0
        public void Raycast(){} // RVA: 0x7FFAF9FA5780
    }

    public class PointerEventData
    {
        // ── Methods ──
        public void get_pointerEnter(){} // RVA: 0x7FFAF2DBB0C0
        public void set_pointerEnter(){} // RVA: 0x7FFAF2DBB0D0
        public void get_lastPress(){} // RVA: 0x7FFAF30E74D0
        public void set_lastPress(){} // RVA: 0x7FFAF2DBB890
        public void get_rawPointerPress(){} // RVA: 0x7FFAF2F476A0
        public void set_rawPointerPress(){} // RVA: 0x7FFAF2F4B830
        public void get_pointerDrag(){} // RVA: 0x7FFAF2E0A740
        public void set_pointerDrag(){} // RVA: 0x7FFAF2DB5200
        public void get_pointerClick(){} // RVA: 0x7FFAF2E08730
        public void set_pointerClick(){} // RVA: 0x7FFAF2E08740
        public void get_pointerCurrentRaycast(){} // RVA: 0x7FFAF6CE1650
        public void set_pointerCurrentRaycast(){} // RVA: 0x7FFAF9F92E20
        public void get_pointerPressRaycast(){} // RVA: 0x7FFAF9F92EA0
        public void set_pointerPressRaycast(){} // RVA: 0x7FFAF9F92EE0
        public void get_eligibleForClick(){} // RVA: 0x7FFAF3CB9D80
        public void set_eligibleForClick(){} // RVA: 0x7FFAF9AC6FA0
        public void get_displayIndex(){} // RVA: 0x7FFAF3CBBB40
        public void set_displayIndex(){} // RVA: 0x7FFAF9AC6F20
        public void get_pointerId(){} // RVA: 0x7FFAF8F1FCD0
        public void set_pointerId(){} // RVA: 0x7FFAF9F92F70
        public void get_position(){} // RVA: 0x7FFAF9F92F80
        public void set_position(){} // RVA: 0x7FFAF9F92FA0
        public void get_delta(){} // RVA: 0x7FFAF9F92FB0
        public void set_delta(){} // RVA: 0x7FFAF9F92FD0
        public void get_pressPosition(){} // RVA: 0x7FFAF9F92FE0
        public void set_pressPosition(){} // RVA: 0x7FFAF9F93000
        public void get_worldPosition(){} // RVA: 0x7FFAF9F93010
        public void set_worldPosition(){} // RVA: 0x7FFAF9F93030
        public void get_worldNormal(){} // RVA: 0x7FFAF9F93050
        public void set_worldNormal(){} // RVA: 0x7FFAF9F93070
        public void get_clickTime(){} // RVA: 0x7FFAF9F93090
        public void set_clickTime(){} // RVA: 0x7FFAF9F930A0
        public void get_clickCount(){} // RVA: 0x7FFAF3CBA360
        public void set_clickCount(){} // RVA: 0x7FFAF8BDFB30
        public void get_scrollDelta(){} // RVA: 0x7FFAF8D2A380
        public void set_scrollDelta(){} // RVA: 0x7FFAF8D2A3A0
        public void get_useDragThreshold(){} // RVA: 0x7FFAF333FF40
        public void set_useDragThreshold(){} // RVA: 0x7FFAF3C87DD0
        public void get_dragging(){} // RVA: 0x7FFAF9F930B0
        public void set_dragging(){} // RVA: 0x7FFAF9F930C0
        public void get_button(){} // RVA: 0x7FFAF40AA5E0
        public void set_button(){} // RVA: 0x7FFAF408F3A0
        public void get_pressure(){} // RVA: 0x7FFAF9F930D0
        public void set_pressure(){} // RVA: 0x7FFAF9F930E0
        public void get_tangentialPressure(){} // RVA: 0x7FFAF9F930F0
        public void set_tangentialPressure(){} // RVA: 0x7FFAF9F93100
        public void get_altitudeAngle(){} // RVA: 0x7FFAF9F93110
        public void set_altitudeAngle(){} // RVA: 0x7FFAF9F93120
        public void get_azimuthAngle(){} // RVA: 0x7FFAF9F93130
        public void set_azimuthAngle(){} // RVA: 0x7FFAF9F93140
        public void get_twist(){} // RVA: 0x7FFAF9A7EDD0
        public void set_twist(){} // RVA: 0x7FFAF3CBCD90
        public void get_tilt(){} // RVA: 0x7FFAF9F93150
        public void set_tilt(){} // RVA: 0x7FFAF9F93170
        public void get_penStatus(){} // RVA: 0x7FFAF9F93180
        public void set_penStatus(){} // RVA: 0x7FFAF9F93190
        public void get_radius(){} // RVA: 0x7FFAF9F931A0
        public void set_radius(){} // RVA: 0x7FFAF9F931C0
        public void get_radiusVariance(){} // RVA: 0x7FFAF9F931D0
        public void set_radiusVariance(){} // RVA: 0x7FFAF9F931F0
        public void get_fullyExited(){} // RVA: 0x7FFAF9F93200
        public void set_fullyExited(){} // RVA: 0x7FFAF9F93210
        public void get_reentered(){} // RVA: 0x7FFAF2E1D510
        public void set_reentered(){} // RVA: 0x7FFAF2E1D520
        public void .ctor(){} // RVA: 0x7FFAF9F93220
        public void IsPointerMoving(){} // RVA: 0x7FFAF9F93540
        public void IsScrolling(){} // RVA: 0x7FFAF9F93570
        public void get_enterEventCamera(){} // RVA: 0x7FFAF9F935A0
        public void get_pressEventCamera(){} // RVA: 0x7FFAF9F936C0
        public void get_pointerPress(){} // RVA: 0x7FFAF2DBB130
        public void set_pointerPress(){} // RVA: 0x7FFAF9F937F0
        public void ToString(){} // RVA: 0x7FFAF9F939C0
    }

    public class PointerEventDataExtension
    {
        // ── Methods ──
        public void IsVRPointer(){} // RVA: 0x7FFAF8CA8EC0
        public void GetRay(){} // RVA: 0x7FFAF8CA8F50
        public void GetSwipeStart(){} // RVA: 0x7FFAF8CA9000
        public void SetSwipeStart(){} // RVA: 0x7FFAF8CA90A0
    }

    public class PointerInputModule
    {
        // ── Methods ──
        public void GetPointerData(){} // RVA: 0x7FFAF9F9C6D0
        public void RemovePointerData(){} // RVA: 0x7FFAF9F9C830
        public void GetTouchPointerEventData(){} // RVA: 0x7FFAF9F9C8A0
        public void CopyFromTo(){} // RVA: 0x7FFAF9F9CD40
        public void StateForMouseButton(){} // RVA: 0x7FFAF9F9CF40
        public void GetMousePointerEventData(){} // RVA: 0x7FFAF9F9D000 | overloaded x2
        public void GetLastPointerEventData(){} // RVA: 0x7FFAF9F9D8C0
        public void ShouldStartDrag(){} // RVA: 0x7FFAF9F9D8F0
        public void ProcessMove(){} // RVA: 0x7FFAF9F9D940
        public void ProcessDrag(){} // RVA: 0x7FFAF9F9D9D0
        public void IsPointerOverGameObject(){} // RVA: 0x7FFAF9F9DD80
        public void ClearSelection(){} // RVA: 0x7FFAF9F9DE90
        public void ToString(){} // RVA: 0x7FFAF9F9E120
        public void DeselectIfSelectionChanged(){} // RVA: 0x7FFAF9F9E470
        public void .ctor(){} // RVA: 0x7FFAF9F9E610
    }

    public class RaycastResult
    {
        // ── Methods ──
        public void get_gameObject(){} // RVA: 0x7FFAF4584690
        public void set_gameObject(){} // RVA: 0x7FFAF3ABA2F0
        public void get_isValid(){} // RVA: 0x7FFAF9FA5D80
        public void Clear(){} // RVA: 0x7FFAF9FA5EF0
        public void ToString(){} // RVA: 0x7FFAF9FA6080
    }

    public class RaycasterManager
    {
        // ── Methods ──
        public void AddRaycaster(){} // RVA: 0x7FFAF9FA3920
        public void GetRaycasters(){} // RVA: 0x7FFAF9FA3A40
        public void RemoveRaycasters(){} // RVA: 0x7FFAF9FA3AA0
        public void .cctor(){} // RVA: 0x7FFAF9FA3B80
    }

    public class StandaloneInputModule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9F9EC90
        public void get_inputMode(){} // RVA: 0x7FFAF2FC9240
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x7FFAF2DAE4C0
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x7FFAF2DAE4D0
        public void get_forceModuleActive(){} // RVA: 0x7FFAF2DAE4C0
        public void set_forceModuleActive(){} // RVA: 0x7FFAF2DAE4D0
        public void get_inputActionsPerSecond(){} // RVA: 0x7FFAF4759BD0
        public void set_inputActionsPerSecond(){} // RVA: 0x7FFAF4759BC0
        public void get_repeatDelay(){} // RVA: 0x7FFAF4759BB0
        public void set_repeatDelay(){} // RVA: 0x7FFAF4759BA0
        public void get_horizontalAxis(){} // RVA: 0x7FFAF34CC8C0
        public void set_horizontalAxis(){} // RVA: 0x7FFAF345A650
        public void get_verticalAxis(){} // RVA: 0x7FFAF34B85E0
        public void set_verticalAxis(){} // RVA: 0x7FFAF345A5F0
        public void get_submitButton(){} // RVA: 0x7FFAF34CC130
        public void set_submitButton(){} // RVA: 0x7FFAF3595030
        public void get_cancelButton(){} // RVA: 0x7FFAF2DF8040
        public void set_cancelButton(){} // RVA: 0x7FFAF2DF8050
        public void ShouldIgnoreEventsOnNoFocus(){} // RVA: 0x7FFAF2E72850
        public void UpdateModule(){} // RVA: 0x7FFAF9F9EEA0
        public void ReleaseMouse(){} // RVA: 0x7FFAF9F9F0A0
        public void ShouldActivateModule(){} // RVA: 0x7FFAF9F9F6F0
        public void ActivateModule(){} // RVA: 0x7FFAF9F9F900
        public void DeactivateModule(){} // RVA: 0x7FFAF433A600
        public void Process(){} // RVA: 0x7FFAF9F9FAD0
        public void ProcessTouchEvents(){} // RVA: 0x7FFAF9F9FCF0
        public void ProcessTouchPress(){} // RVA: 0x7FFAF9F9FF00
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x7FFAF9FA0BC0
        public void GetRawMoveVector(){} // RVA: 0x7FFAF9FA0E10
        public void SendMoveEventToSelectedObject(){} // RVA: 0x7FFAF9FA0F80
        public void ProcessMouseEvent(){} // RVA: 0x7FFAF9FA1300 | overloaded x2
        public void ForceAutoSelect(){} // RVA: 0x7FFAF2D8D320
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x7FFAF9FA15D0
        public void ProcessMousePress(){} // RVA: 0x7FFAF9FA1760
        public void GetCurrentFocusedGameObject(){} // RVA: 0x7FFAF2DCC010
    }

    public class TouchInputModule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF9FA1EB0
        public void get_allowActivationOnStandalone(){} // RVA: 0x7FFAF3058B10
        public void set_allowActivationOnStandalone(){} // RVA: 0x7FFAF3056190
        public void get_forceModuleActive(){} // RVA: 0x7FFAF3058B10
        public void set_forceModuleActive(){} // RVA: 0x7FFAF3056190
        public void UpdateModule(){} // RVA: 0x7FFAF9FA1EC0
        public void IsModuleSupported(){} // RVA: 0x7FFAF9FA20E0
        public void ShouldActivateModule(){} // RVA: 0x7FFAF9FA2130
        public void UseFakeInput(){} // RVA: 0x7FFAF9FA2230
        public void Process(){} // RVA: 0x7FFAF9FA2270
        public void FakeTouches(){} // RVA: 0x7FFAF9FA25E0
        public void ProcessTouchEvents(){} // RVA: 0x7FFAF9FA2750
        public void ProcessTouchPress(){} // RVA: 0x7FFAF9FA2930
        public void DeactivateModule(){} // RVA: 0x7FFAF433A600
        public void ToString(){} // RVA: 0x7FFAF9FA3550
    }

    public class UIBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAF2D8D310
        public void OnEnable(){} // RVA: 0x7FFAF2D8D310
        public void Start(){} // RVA: 0x7FFAF2D8D310
        public void OnDisable(){} // RVA: 0x7FFAF2D8D310
        public void OnDestroy(){} // RVA: 0x7FFAF2D8D310
        public void IsActive(){} // RVA: 0x7FFAF9BD2760
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFAF2D8D310
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7FFAF2D8D310
        public void OnTransformParentChanged(){} // RVA: 0x7FFAF2D8D310
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAF2D8D310
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFAF2D8D310
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFAF2D8D310
        public void IsDestroyed(){} // RVA: 0x7FFAF9FA65C0
        public void .ctor(){} // RVA: 0x7FFAF2D8DD50
    }

}