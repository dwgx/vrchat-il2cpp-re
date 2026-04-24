// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.EventSystems
// Classes: 40
// Methods: 417

namespace ThirdParty.Unity.UnityEngine.EventSystems
{
    public class AbstractEventData : Object
    {
        // ── Original Methods ──
        public void Reset(){} // RVA: 0x7ffaa97393e0
        public void Use(){} // RVA: 0x7ffaa8c586c0
        public void get_used(){} // RVA: 0x7ffaa89fc5e0
        public void .ctor(){} // RVA: 0x7ffaa8932310
    }

    public class AxisEventData : BaseEventData
    {
        // ── Original Methods ──
        public void get_moveVector(){} // RVA: 0x7ffaa91376a0
        public void set_moveVector(){} // RVA: 0x7ffaa9137320
        public void get_moveDir(){} // RVA: 0x7ffaa8d14570
        public void set_moveDir(){} // RVA: 0x7ffaa90c0cd0
        public void .ctor(){} // RVA: 0x7ffaaf69c630
    }

    public class BaseEventData : AbstractEventData
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8998e80
        public void get_currentInputModule(){} // RVA: 0x7ffaae225b70
        public void get_selectedObject(){} // RVA: 0x7ffaae225bd0
        public void set_selectedObject(){} // RVA: 0x7ffaaf69c6d0
    }

    public class BaseInput : UIBehaviour
    {
        // ── Original Methods ──
        public void get_compositionString(){} // RVA: 0x7ffaaf3624f0
        public void get_imeCompositionMode(){} // RVA: 0x7ffaaf362450
        public void set_imeCompositionMode(){} // RVA: 0x7ffaaf6a3d00
        public void get_compositionCursorPos(){} // RVA: 0x7ffaaf6a3d50
        public void set_compositionCursorPos(){} // RVA: 0x7ffaaf6a3db0
        public void get_mousePresent(){} // RVA: 0x7ffaaf362640
        public void get_mousePosition(){} // RVA: 0x7ffaaf6a3e50
        public void get_mouseScrollDelta(){} // RVA: 0x7ffaaf6a3ec0
        public void get_touchSupported(){} // RVA: 0x7ffaa99c5840
        public void get_touchCount(){} // RVA: 0x7ffaaf362690
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        // ── Binary Analysis Named ──
        public void GetMouseButtonDown(){} // RVA: 0x7ffaaf5902b0
        public void GetMouseButtonUp(){} // RVA: 0x7ffaaf590300
        public void GetMouseButton(){} // RVA: 0x7ffaaf6a3e00
        public void GetTouch(){} // RVA: 0x7ffaaf590200
        public void GetAxisRaw(){} // RVA: 0x7ffaaf6a3f20
        public void GetButtonDown(){} // RVA: 0x7ffaa8951020
    }

    public class BaseInputModule : UIBehaviour
    {
        public object m_AxisEventData; // 0x33348E60
        public object m_InputOverride; // 0x33348E60

        // ── Original Methods ──
        public void get_sendPointerHoverToParent(){} // RVA: 0x7ffaa8b0edb0
        public void set_sendPointerHoverToParent(){} // RVA: 0x7ffaa96574d0
        public void get_input(){} // RVA: 0x7ffaaf6a3f70
        public void get_inputOverride(){} // RVA: 0x7ffaa89ad730
        public void set_inputOverride(){} // RVA: 0x7ffaa89ad740
        public void get_eventSystem(){} // RVA: 0x7ffaa8bf45b0
        public void OnEnable(){} // RVA: 0x7ffaaf6a4330
        public void OnDisable(){} // RVA: 0x7ffaaf6a43d0
        public void Process(){} // RVA: 0x7ffaa8660cc0
        public void FindFirstRaycast(){} // RVA: 0x7ffaaf6a43f0
        public void DetermineMoveDirection(){} // RVA: 0x7ffaaf6a4600
        public void DetermineMoveDirection(){} // RVA: 0x7ffaaf6a4600
        public void FindCommonRoot(){} // RVA: 0x7ffaaf6a4680
        public void HandlePointerExitAndEnter(){} // RVA: 0x7ffaaf6a4a60
        public void IsPointerOverGameObject(){} // RVA: 0x7ffaa8932320
        public void ShouldActivateModule(){} // RVA: 0x7ffaaf6a5d30
        public void DeactivateModule(){} // RVA: 0x7ffaa8932310
        public void ActivateModule(){} // RVA: 0x7ffaa8932310
        public void UpdateModule(){} // RVA: 0x7ffaa8932310
        public void IsModuleSupported(){} // RVA: 0x7ffaa8a17850
        public void ConvertUIToolkitPointerId(){} // RVA: 0x7ffaaf6a5e20
        public void .ctor(){} // RVA: 0x7ffaaf6a5ec0
        // ── Binary Analysis Named ──
        public void GetAxisEventData(){} // RVA: 0x7ffaaf6a5ac0
        public void GetBaseEventData(){} // RVA: 0x7ffaaf6a5c00
    }

    public class BaseRaycaster : UIBehaviour
    {
        // ── Original Methods ──
        public void Raycast(){} // RVA: 0x7ffaa8669e70
        public void get_eventCamera(){} // RVA: 0x7ffaa86491d0
        public void get_priority(){} // RVA: 0x7ffaa8f22da0
        public void get_sortOrderPriority(){} // RVA: 0x7ffaaf6ad550
        public void get_renderOrderPriority(){} // RVA: 0x7ffaaf6ad550
        public void get_rootRaycaster(){} // RVA: 0x7ffaaf6ad560
        public void ToString(){} // RVA: 0x7ffaaf6ad6e0
        public void OnEnable(){} // RVA: 0x7ffaaf6ad9f0
        public void OnDisable(){} // RVA: 0x7ffaaf6adb40
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7ffaadc0f630
        public void OnTransformParentChanged(){} // RVA: 0x7ffaadc0f630
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

    public class EventSystem : UIBehaviour
    {
        public object m_EventSystems; // 0x3385D6C0
        public object m_DragThreshold; // 0x3385D6C0
        public object m_SelectionGuard; // 0x3385D6C0
        public object s_UIToolkitOverride; // 0x3385D6C0
        public object activeEventSystem; // 0x817FE5C0

        // ── Original Methods ──
        public void get_current(){} // RVA: 0x7ffaaf69ddf0
        public void set_current(){} // RVA: 0x7ffaaf69ded0
        public void get_sendNavigationEvents(){} // RVA: 0x7ffaa8bfcc70
        public void set_sendNavigationEvents(){} // RVA: 0x7ffaa8bfbbe0
        public void get_pixelDragThreshold(){} // RVA: 0x7ffaa8de7460
        public void set_pixelDragThreshold(){} // RVA: 0x7ffaaa1eabc0
        public void get_currentInputModule(){} // RVA: 0x7ffaa8960130
        public void get_firstSelectedGameObject(){} // RVA: 0x7ffaa8bfcc80
        public void set_firstSelectedGameObject(){} // RVA: 0x7ffaa8960890
        public void get_currentSelectedGameObject(){} // RVA: 0x7ffaa89af740
        public void get_lastSelectedGameObject(){} // RVA: 0x7ffaa8f22da0
        public void get_isFocused(){} // RVA: 0x7ffaa89e9d30
        public void .ctor(){} // RVA: 0x7ffaaf69e0a0
        public void UpdateModules(){} // RVA: 0x7ffaaf69e1b0
        public void get_alreadySelecting(){} // RVA: 0x7ffaa983cba0
        public void get_baseEventDataCache(){} // RVA: 0x7ffaaf69e6d0
        public void RaycastComparer(){} // RVA: 0x7ffaaf69e8f0
        public void RaycastAll(){} // RVA: 0x7ffaaf69f030
        public void IsPointerOverGameObject(){} // RVA: 0x7ffaaf69f450
        public void IsPointerOverGameObject(){} // RVA: 0x7ffaaf69f450
        public void get_isUIToolkitActiveEventSystem(){} // RVA: 0x7ffaaf69f560
        public void get_sendUIToolkitEvents(){} // RVA: 0x7ffaaf69f780
        public void get_createUIToolkitPanelGameObjectsOnStart(){} // RVA: 0x7ffaaf69f7f0
        public void StartTrackingUIToolkitPanels(){} // RVA: 0x7ffaaf69fb80
        public void StopTrackingUIToolkitPanels(){} // RVA: 0x7ffaaf69ffa0
        public void CreateUIToolkitPanelGameObject(){} // RVA: 0x7ffaaf6a01b0
        public void Start(){} // RVA: 0x7ffaaf6a0590
        public void OnEnable(){} // RVA: 0x7ffaaf6a05a0
        public void OnDisable(){} // RVA: 0x7ffaaf6a0710
        public void TickModules(){} // RVA: 0x7ffaaf6a08f0
        public void OnApplicationFocus(){} // RVA: 0x7ffaaf6a0a90
        public void Update(){} // RVA: 0x7ffaaf6a0aa0
        public void ChangeEventModule(){} // RVA: 0x7ffaaf6a0f40
        public void ToString(){} // RVA: 0x7ffaaf6a1210
        public void .cctor(){} // RVA: 0x7ffaaf6a1420
        // ── Binary Analysis Named ──
        public void SetSelectedGameObject(){} // RVA: 0x7ffaaf69e7d0
        public void SetSelectedGameObject(){} // RVA: 0x7ffaaf69e7d0
        public void SetUITookitEventSystemOverride(){} // RVA: 0x7ffaaf69f860
    }

    public class EventTrigger : MonoBehaviour
    {
        // ── Original Methods ──
        public void get_delegates(){} // RVA: 0x7ffaaf6a1700
        public void set_delegates(){} // RVA: 0x7ffaa89600d0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
        public void get_triggers(){} // RVA: 0x7ffaaf6a1710
        public void set_triggers(){} // RVA: 0x7ffaa89600d0
        public void Execute(){} // RVA: 0x7ffaaf6a17d0
        public void OnPointerEnter(){} // RVA: 0x7ffaaf6a18f0
        public void OnPointerExit(){} // RVA: 0x7ffaaf6a1900
        public void OnDrag(){} // RVA: 0x7ffaaf6a1910
        public void OnDrop(){} // RVA: 0x7ffaaf6a1920
        public void OnPointerDown(){} // RVA: 0x7ffaaf6a1930
        public void OnPointerUp(){} // RVA: 0x7ffaaf6a1940
        public void OnPointerClick(){} // RVA: 0x7ffaaf6a1950
        public void OnSelect(){} // RVA: 0x7ffaaf6a1960
        public void OnDeselect(){} // RVA: 0x7ffaaf6a1970
        public void OnScroll(){} // RVA: 0x7ffaaf6a1980
        public void OnMove(){} // RVA: 0x7ffaaf6a1990
        public void OnUpdateSelected(){} // RVA: 0x7ffaaf6a19a0
        public void OnInitializePotentialDrag(){} // RVA: 0x7ffaaf6a19b0
        public void OnBeginDrag(){} // RVA: 0x7ffaaf6a19c0
        public void OnEndDrag(){} // RVA: 0x7ffaaf6a19d0
        public void OnSubmit(){} // RVA: 0x7ffaaf6a19e0
        public void OnCancel(){} // RVA: 0x7ffaaf6a19f0
    }

    public class ExecuteEvents : Object
    {
        public object s_PointerExitHandler; // 0x30F57B40
        public object s_PointerClickHandler; // 0x30F57B40
        public object s_DragHandler; // 0x30F57B40
        public object s_ScrollHandler; // 0x30F57B40
        public object s_DeselectHandler; // 0x30F57B40
        public object s_CancelHandler; // 0x30F57B40

        // ── Original Methods ──
        public void ValidateEventData(){} // RVA: 0x7ffaa887e5c0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void get_pointerMoveHandler(){} // RVA: 0x7ffaaf6a25a0
        public void get_pointerEnterHandler(){} // RVA: 0x7ffaaf6a2600
        public void get_pointerExitHandler(){} // RVA: 0x7ffaaf6a2660
        public void get_pointerDownHandler(){} // RVA: 0x7ffaaf6a26c0
        public void get_pointerUpHandler(){} // RVA: 0x7ffaaf6a2720
        public void get_pointerClickHandler(){} // RVA: 0x7ffaaf6a2780
        public void get_initializePotentialDrag(){} // RVA: 0x7ffaaf6a27e0
        public void get_beginDragHandler(){} // RVA: 0x7ffaaf6a2840
        public void get_dragHandler(){} // RVA: 0x7ffaaf6a28a0
        public void get_endDragHandler(){} // RVA: 0x7ffaaf6a2900
        public void get_dropHandler(){} // RVA: 0x7ffaaf6a2960
        public void get_scrollHandler(){} // RVA: 0x7ffaaf6a29c0
        public void get_updateSelectedHandler(){} // RVA: 0x7ffaaf6a2a20
        public void get_selectHandler(){} // RVA: 0x7ffaaf6a2a80
        public void get_deselectHandler(){} // RVA: 0x7ffaaf6a2ae0
        public void get_moveHandler(){} // RVA: 0x7ffaaf6a2b40
        public void get_submitHandler(){} // RVA: 0x7ffaaf6a2ba0
        public void get_cancelHandler(){} // RVA: 0x7ffaaf6a2c00
        public void Execute(){} // RVA: 0x7ffaa864d8e0
        public void ExecuteHierarchy(){} // RVA: 0x7ffaa8659940
        public void ShouldSendToComponent(){} // RVA: 0x7ffaa864a120
        public void CanHandleEvent(){} // RVA: 0x7ffaa864a120
        public void .cctor(){} // RVA: 0x7ffaaf6a2f10
        // ── Binary Analysis Named ──
        public void GetEventChain(){} // RVA: 0x7ffaaf6a2c60
        public void GetEventList(){} // RVA: 0x7ffaa8660fc0
        public void GetEventHandler(){} // RVA: 0x7ffaa86492c0
    }

    public class IBeginDragHandler
    {
        // ── Original Methods ──
        public void OnBeginDrag(){} // RVA: 0x7ffaa8660d80
    }

    public class ICancelHandler
    {
        // ── Original Methods ──
        public void OnCancel(){} // RVA: 0x7ffaa8660d80
    }

    public class IDeselectHandler
    {
        // ── Original Methods ──
        public void OnDeselect(){} // RVA: 0x7ffaa8660d80
    }

    public class IDragHandler
    {
        // ── Original Methods ──
        public void OnDrag(){} // RVA: 0x7ffaa8660d80
    }

    public class IDropHandler
    {
        // ── Original Methods ──
        public void OnDrop(){} // RVA: 0x7ffaa8660d80
    }

    public class IEndDragHandler
    {
        // ── Original Methods ──
        public void OnEndDrag(){} // RVA: 0x7ffaa8660d80
    }

    public class IEventSystemHandler
    {
    }

    public class IInitializePotentialDragHandler
    {
        // ── Original Methods ──
        public void OnInitializePotentialDrag(){} // RVA: 0x7ffaa8660d80
    }

    public class IMoveHandler
    {
        // ── Original Methods ──
        public void OnMove(){} // RVA: 0x7ffaa8660d80
    }

    public class IPointerClickHandler
    {
        // ── Original Methods ──
        public void OnPointerClick(){} // RVA: 0x7ffaa8660d80
    }

    public class IPointerDownHandler
    {
        // ── Original Methods ──
        public void OnPointerDown(){} // RVA: 0x7ffaa8660d80
    }

    public class IPointerEnterHandler
    {
        // ── Original Methods ──
        public void OnPointerEnter(){} // RVA: 0x7ffaa8660d80
    }

    public class IPointerExitHandler
    {
        // ── Original Methods ──
        public void OnPointerExit(){} // RVA: 0x7ffaa8660d80
    }

    public class IPointerMoveHandler
    {
        // ── Original Methods ──
        public void OnPointerMove(){} // RVA: 0x7ffaa8660d80
    }

    public class IPointerUpHandler
    {
        // ── Original Methods ──
        public void OnPointerUp(){} // RVA: 0x7ffaa8660d80
    }

    public class IScrollHandler
    {
        // ── Original Methods ──
        public void OnScroll(){} // RVA: 0x7ffaa8660d80
    }

    public class ISelectHandler
    {
        // ── Original Methods ──
        public void OnSelect(){} // RVA: 0x7ffaa8660d80
    }

    public class ISubmitHandler
    {
        // ── Original Methods ──
        public void OnSubmit(){} // RVA: 0x7ffaa8660d80
    }

    public class IUpdateSelectedHandler
    {
        // ── Original Methods ──
        public void OnUpdateSelected(){} // RVA: 0x7ffaa8660d80
    }

    public class OVRInputModule : PointerInputModule
    {
        public object joyPadClickButton; // 0x3365A000
        public object useRightStickScroll; // 0x3365A000
        public object swipeDragThreshold; // 0x3365A000
        public object activeGraphicRaycaster; // 0x3365A000
        public object m_NextAction; // 0x3365A000
        public object m_HorizontalAxis; // 0x3365A000
        public object m_CancelButton; // 0x3365A000
        public object m_VRRayPointerData; // 0x3365A000

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3aa9b0
        public void get_inputMode(){} // RVA: 0x7ffaa8f22da0
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x7ffaae2e1d00
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x7ffaae3aad30
        public void get_inputActionsPerSecond(){} // RVA: 0x7ffaa8dfefb0
        public void set_inputActionsPerSecond(){} // RVA: 0x7ffaa8dfb6f0
        public void get_horizontalAxis(){} // RVA: 0x7ffaa899d120
        public void set_horizontalAxis(){} // RVA: 0x7ffaa899d130
        public void get_verticalAxis(){} // RVA: 0x7ffaa8a8a460
        public void set_verticalAxis(){} // RVA: 0x7ffaa8a8a470
        public void get_submitButton(){} // RVA: 0x7ffaa8a4f100
        public void set_submitButton(){} // RVA: 0x7ffaa8a4f110
        public void get_cancelButton(){} // RVA: 0x7ffaa8f6dbf0
        public void set_cancelButton(){} // RVA: 0x7ffaa89b38a0
        public void UpdateModule(){} // RVA: 0x7ffaae3aad40
        public void IsModuleSupported(){} // RVA: 0x7ffaae3aade0
        public void ShouldActivateModule(){} // RVA: 0x7ffaae3aae40
        public void ActivateModule(){} // RVA: 0x7ffaae3ab080
        public void DeactivateModule(){} // RVA: 0x7ffaae3ab280
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x7ffaae3ab290
        public void AllowMoveEventProcessing(){} // RVA: 0x7ffaae3ab520
        public void SendMoveEventToSelectedObject(){} // RVA: 0x7ffaae3ab7e0
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x7ffaae3aba20
        public void ProcessMousePress(){} // RVA: 0x7ffaae3abbb0
        public void ProcessMouseEvent(){} // RVA: 0x7ffaae3ac810
        public void Process(){} // RVA: 0x7ffaae3acca0
        public void UseMouse(){} // RVA: 0x7ffaae3acea0
        public void CopyFromTo(){} // RVA: 0x7ffaae3ad0f0
        public void CopyFromTo(){} // RVA: 0x7ffaae3ad0f0
        public void ClearSelection(){} // RVA: 0x7ffaae3ad3c0
        public void ShouldStartDrag(){} // RVA: 0x7ffaae3af3a0
        public void IsPointerMoving(){} // RVA: 0x7ffaae3af760
        public void SwipeAdjustedPosition(){} // RVA: 0x7ffaa98c2840
        public void ProcessDrag(){} // RVA: 0x7ffaae3af800
        // ── Binary Analysis Named ──
        public void GetRawMoveVector(){} // RVA: 0x7ffaae3ab600
        public void GetPointerData(){} // RVA: 0x7ffaae3ad260
        public void GetRectTransformNormal(){} // RVA: 0x7ffaae3ad870
        public void GetGazePointerData(){} // RVA: 0x7ffaae3adad0
        public void GetCanvasPointerData(){} // RVA: 0x7ffaae3aeac0
        public void GetGazeButtonState(){} // RVA: 0x7ffaae3afcc0
        public void GetExtraScrollDelta(){} // RVA: 0x7ffaae3afeb0
    }

    public class OVRPhysicsRaycaster : BaseRaycaster
    {
        public object sortOrder; // 0x33CD1480
        public object eventCamera; // 0x170001E9

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9518760
        public void get_eventCamera(){} // RVA: 0x7ffaae3affb0
        public void get_depth(){} // RVA: 0x7ffaae3b0020
        public void get_sortOrderPriority(){} // RVA: 0x7ffaa96cc980
        public void get_finalEventMask(){} // RVA: 0x7ffaae3b0180
        public void get_eventMask(){} // RVA: 0x7ffaa8d14570
        public void set_eventMask(){} // RVA: 0x7ffaa90c0cd0
        public void Raycast(){} // RVA: 0x7ffaae3b02e0
        public void Spherecast(){} // RVA: 0x7ffaae3b0a50
        // ── Binary Analysis Named ──
        public void GetScreenPos(){} // RVA: 0x7ffaae3b11e0
    }

    public class OVRPointerEventData : PointerEventData
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaae3b13a0
        public void ToString(){} // RVA: 0x7ffaae3b13b0
    }

    public class Physics2DRaycaster : PhysicsRaycaster
    {
        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9c8aaf0
        public void Raycast(){} // RVA: 0x7ffaaf6adc50
    }

    public class PhysicsRaycaster : BaseRaycaster
    {
        public object m_EventMask; // 0x33724760
        public object m_Hits; // 0x33724760
        public object eventCamera; // 0x170001F3
        public object depth; // 0x170001F4

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa9c8aaf0
        public void get_eventCamera(){} // RVA: 0x7ffaaf6ae700
        public void get_depth(){} // RVA: 0x7ffaaf6ae920
        public void get_finalEventMask(){} // RVA: 0x7ffaaf6aea80
        public void get_eventMask(){} // RVA: 0x7ffaa898dcd0
        public void set_eventMask(){} // RVA: 0x7ffaa898dce0
        public void get_maxRayIntersections(){} // RVA: 0x7ffaa950c6d0
        public void set_maxRayIntersections(){} // RVA: 0x7ffaa9b8cba0
        public void ComputeRayAndDistance(){} // RVA: 0x7ffaaf6aebe0
        public void Raycast(){} // RVA: 0x7ffaaf6af070
    }

    public class PointerEventData : BaseEventData
    {
        public object _lastPress; // 0x3379C1E0, was: <lastPress>k__BackingField
        public object _pointerClick; // 0x3379C1E0, was: <pointerClick>k__BackingField
        public object hovered; // 0x3379C1E0
        public object _pointerId; // 0x3379C1E0, was: <pointerId>k__BackingField
        public object _pressPosition; // 0x3379C1E0, was: <pressPosition>k__BackingField
        public object _clickTime; // 0x3379C1E0, was: <clickTime>k__BackingField
        public object _useDragThreshold; // 0x3379C1E0, was: <useDragThreshold>k__BackingFi
        public object _pressure; // 0x3379C1E0, was: <pressure>k__BackingField
        public object _azimuthAngle; // 0x3379C1E0, was: <azimuthAngle>k__BackingField
        public object _penStatus; // 0x3379C1E0, was: <penStatus>k__BackingField
        public object _fullyExited; // 0x3379C1E0, was: <fullyExited>k__BackingField
        public object _pointerEnter; // 0x334C49A0, was: ÌÏÌÎÌÍÎÎÎÎÌÌÏÍÏÍÏÍÎÏÍÍÏ

        // ── Original Methods ──
        public void get_pointerEnter(){} // RVA: 0x7ffaa89600c0
        public void set_pointerEnter(){} // RVA: 0x7ffaa89600d0
        public void get_lastPress(){} // RVA: 0x7ffaa8bfcc80
        public void set_lastPress(){} // RVA: 0x7ffaa8960890
        public void get_rawPointerPress(){} // RVA: 0x7ffaa8bf45b0
        public void set_rawPointerPress(){} // RVA: 0x7ffaa8bf45c0
        public void get_pointerDrag(){} // RVA: 0x7ffaa89af740
        public void set_pointerDrag(){} // RVA: 0x7ffaa895a200
        public void get_pointerClick(){} // RVA: 0x7ffaa89ad730
        public void set_pointerClick(){} // RVA: 0x7ffaa89ad740
        public void get_pointerCurrentRaycast(){} // RVA: 0x7ffaac525ed0
        public void set_pointerCurrentRaycast(){} // RVA: 0x7ffaaf69c700
        public void get_pointerPressRaycast(){} // RVA: 0x7ffaaf69c780
        public void set_pointerPressRaycast(){} // RVA: 0x7ffaaf69c7c0
        public void get_eligibleForClick(){} // RVA: 0x7ffaa96c75d0
        public void set_eligibleForClick(){} // RVA: 0x7ffaaf1d18c0
        public void get_displayIndex(){} // RVA: 0x7ffaa96c76b0
        public void set_displayIndex(){} // RVA: 0x7ffaaf1d1840
        public void get_pointerId(){} // RVA: 0x7ffaae6287e0
        public void set_pointerId(){} // RVA: 0x7ffaaf69c850
        public void get_position(){} // RVA: 0x7ffaaf69c860
        public void set_position(){} // RVA: 0x7ffaaf69c880
        public void get_delta(){} // RVA: 0x7ffaaf69c890
        public void set_delta(){} // RVA: 0x7ffaaf69c8b0
        public void get_pressPosition(){} // RVA: 0x7ffaaf69c8c0
        public void set_pressPosition(){} // RVA: 0x7ffaaf69c8e0
        public void get_worldPosition(){} // RVA: 0x7ffaaf69c8f0
        public void set_worldPosition(){} // RVA: 0x7ffaaf69c910
        public void get_worldNormal(){} // RVA: 0x7ffaaf69c930
        public void set_worldNormal(){} // RVA: 0x7ffaaf69c950
        public void get_clickTime(){} // RVA: 0x7ffaaf69c970
        public void set_clickTime(){} // RVA: 0x7ffaaf69c980
        public void get_clickCount(){} // RVA: 0x7ffaa96cb0d0
        public void set_clickCount(){} // RVA: 0x7ffaae2e8430
        public void get_scrollDelta(){} // RVA: 0x7ffaae432930
        public void set_scrollDelta(){} // RVA: 0x7ffaae432950
        public void get_useDragThreshold(){} // RVA: 0x7ffaa8de5d50
        public void set_useDragThreshold(){} // RVA: 0x7ffaaf69c990
        public void get_dragging(){} // RVA: 0x7ffaaf69c9a0
        public void set_dragging(){} // RVA: 0x7ffaaf69c9b0
        public void get_button(){} // RVA: 0x7ffaa9ad6700
        public void set_button(){} // RVA: 0x7ffaa9abb370
        public void get_pressure(){} // RVA: 0x7ffaaf69c9c0
        public void set_pressure(){} // RVA: 0x7ffaaf69c9d0
        public void get_tangentialPressure(){} // RVA: 0x7ffaaf69c9e0
        public void set_tangentialPressure(){} // RVA: 0x7ffaaf69c9f0
        public void get_altitudeAngle(){} // RVA: 0x7ffaaf69ca00
        public void set_altitudeAngle(){} // RVA: 0x7ffaaf69ca10
        public void get_azimuthAngle(){} // RVA: 0x7ffaaf69ca20
        public void set_azimuthAngle(){} // RVA: 0x7ffaaf69ca30
        public void get_twist(){} // RVA: 0x7ffaaf1896d0
        public void set_twist(){} // RVA: 0x7ffaa96c5430
        public void get_tilt(){} // RVA: 0x7ffaaf69ca40
        public void set_tilt(){} // RVA: 0x7ffaaf69ca60
        public void get_penStatus(){} // RVA: 0x7ffaaf69ca70
        public void set_penStatus(){} // RVA: 0x7ffaaf69ca80
        public void get_radius(){} // RVA: 0x7ffaaf69ca90
        public void set_radius(){} // RVA: 0x7ffaaf69cab0
        public void get_radiusVariance(){} // RVA: 0x7ffaaf69cac0
        public void set_radiusVariance(){} // RVA: 0x7ffaaf69cae0
        public void get_fullyExited(){} // RVA: 0x7ffaaf69caf0
        public void set_fullyExited(){} // RVA: 0x7ffaaf69cb00
        public void get_reentered(){} // RVA: 0x7ffaa89c2510
        public void set_reentered(){} // RVA: 0x7ffaa89c2520
        public void .ctor(){} // RVA: 0x7ffaaf69cb10
        public void IsPointerMoving(){} // RVA: 0x7ffaaf69ce30
        public void IsScrolling(){} // RVA: 0x7ffaaf69ce60
        public void get_enterEventCamera(){} // RVA: 0x7ffaaf69ce90
        public void get_pressEventCamera(){} // RVA: 0x7ffaaf69cfb0
        public void get_pointerPress(){} // RVA: 0x7ffaa8960130
        public void set_pointerPress(){} // RVA: 0x7ffaaf69d0e0
        public void ToString(){} // RVA: 0x7ffaaf69d2b0
    }

    public class PointerInputModule : BaseInputModule
    {
        public object kMouseMiddleId; // 0x33560960
        public object m_MouseState; // 0x33560960
        public object 8؏f; // 0x66EEC337

        // ── Original Methods ──
        public void RemovePointerData(){} // RVA: 0x7ffaaf6a6120
        public void CopyFromTo(){} // RVA: 0x7ffaaf6a6630
        public void StateForMouseButton(){} // RVA: 0x7ffaaf6a6830
        public void ShouldStartDrag(){} // RVA: 0x7ffaaf6a71e0
        public void ProcessMove(){} // RVA: 0x7ffaaf6a7230
        public void ProcessDrag(){} // RVA: 0x7ffaaf6a72c0
        public void IsPointerOverGameObject(){} // RVA: 0x7ffaaf6a7670
        public void ClearSelection(){} // RVA: 0x7ffaaf6a7780
        public void ToString(){} // RVA: 0x7ffaaf6a7a10
        public void DeselectIfSelectionChanged(){} // RVA: 0x7ffaaf6a7d60
        public void .ctor(){} // RVA: 0x7ffaaf6a7f00
        // ── Binary Analysis Named ──
        public void GetPointerData(){} // RVA: 0x7ffaaf6a5fc0
        public void GetTouchPointerEventData(){} // RVA: 0x7ffaaf6a6190
        public void GetMousePointerEventData(){} // RVA: 0x7ffaaf6a68f0
        public void GetMousePointerEventData(){} // RVA: 0x7ffaaf6a68f0
        public void GetLastPointerEventData(){} // RVA: 0x7ffaaf6a71b0
    }

    public class RaycastResult : ValueType
    {
        public object distance; // 0x335E1320
        public object sortingGroupID; // 0x335E1320
        public object sortingOrder; // 0x335E1320
        public object screenPosition; // 0x335E1320
        public object consecutiveMoveCount; // 0x335E0030
        public object eventData; // 0x335E0030

        // ── Original Methods ──
        public void get_gameObject(){} // RVA: 0x7ffaa950bda0
        public void set_gameObject(){} // RVA: 0x7ffaa930eca0
        public void get_isValid(){} // RVA: 0x7ffaaf6af670
        public void Clear(){} // RVA: 0x7ffaaf6af7e0
        public void ToString(){} // RVA: 0x7ffaaf6af970
    }

    public class RaycasterManager : Object
    {
        // ── Original Methods ──
        public void AddRaycaster(){} // RVA: 0x7ffaaf6ad210
        public void RemoveRaycasters(){} // RVA: 0x7ffaaf6ad390
        public void .cctor(){} // RVA: 0x7ffaaf6ad470
        // ── Binary Analysis Named ──
        public void GetRaycasters(){} // RVA: 0x7ffaaf6ad330
    }

    public class StandaloneInputModule : PointerInputModule
    {
        public object m_ConsecutiveMoveCount; // 0x336D5940
        public object m_CurrentFocusedGameObject; // 0x336D5940
        public object m_HorizontalAxis; // 0x336D5940
        public object m_CancelButton; // 0x336D5940
        public object m_ForceModuleActive; // 0x336D5940
        public object inputMode; // 0x170001E3
        public object allowActivationOnMobileDevice; // 0x170001E4
        public object forceModuleActive; // 0x170001E5
        public object inputActionsPerSecond; // 0x170001E6
        public object repeatDelay; // 0x170001E7

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf6a8580
        public void get_inputMode(){} // RVA: 0x7ffaa8f22da0
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x7ffaa89534c0
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x7ffaa89534d0
        public void get_forceModuleActive(){} // RVA: 0x7ffaa89534c0
        public void set_forceModuleActive(){} // RVA: 0x7ffaa89534d0
        public void get_inputActionsPerSecond(){} // RVA: 0x7ffaaa1db1b0
        public void set_inputActionsPerSecond(){} // RVA: 0x7ffaaa1db1a0
        public void get_repeatDelay(){} // RVA: 0x7ffaaa1db190
        public void set_repeatDelay(){} // RVA: 0x7ffaaa1db180
        public void get_horizontalAxis(){} // RVA: 0x7ffaa8f75d20
        public void set_horizontalAxis(){} // RVA: 0x7ffaa8f7b0d0
        public void get_verticalAxis(){} // RVA: 0x7ffaa8f78170
        public void set_verticalAxis(){} // RVA: 0x7ffaa8f7b130
        public void get_submitButton(){} // RVA: 0x7ffaa8f74720
        public void set_submitButton(){} // RVA: 0x7ffaa8d71dc0
        public void get_cancelButton(){} // RVA: 0x7ffaa899d040
        public void set_cancelButton(){} // RVA: 0x7ffaa899d050
        public void ShouldIgnoreEventsOnNoFocus(){} // RVA: 0x7ffaa8a17850
        public void UpdateModule(){} // RVA: 0x7ffaaf6a8790
        public void ReleaseMouse(){} // RVA: 0x7ffaaf6a8990
        public void ShouldActivateModule(){} // RVA: 0x7ffaaf6a8fe0
        public void ActivateModule(){} // RVA: 0x7ffaaf6a91f0
        public void DeactivateModule(){} // RVA: 0x7ffaa9d2cf50
        public void Process(){} // RVA: 0x7ffaaf6a93c0
        public void ProcessTouchEvents(){} // RVA: 0x7ffaaf6a95e0
        public void ProcessTouchPress(){} // RVA: 0x7ffaaf6a97f0
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x7ffaaf6aa4b0
        public void SendMoveEventToSelectedObject(){} // RVA: 0x7ffaaf6aa870
        public void ProcessMouseEvent(){} // RVA: 0x7ffaaf6aabf0
        public void ForceAutoSelect(){} // RVA: 0x7ffaa8932320
        public void ProcessMouseEvent(){} // RVA: 0x7ffaaf6aabf0
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x7ffaaf6aaec0
        public void ProcessMousePress(){} // RVA: 0x7ffaaf6ab050
        // ── Binary Analysis Named ──
        public void GetRawMoveVector(){} // RVA: 0x7ffaaf6aa700
        public void GetCurrentFocusedGameObject(){} // RVA: 0x7ffaa8971010
    }

    public class TouchInputModule : PointerInputModule
    {
        public object m_InputPointerEvent; // 0x33560630

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaaf6ab7a0
        public void get_allowActivationOnStandalone(){} // RVA: 0x7ffaa8b680a0
        public void set_allowActivationOnStandalone(){} // RVA: 0x7ffaa8b70520
        public void get_forceModuleActive(){} // RVA: 0x7ffaa8b680a0
        public void set_forceModuleActive(){} // RVA: 0x7ffaa8b70520
        public void UpdateModule(){} // RVA: 0x7ffaaf6ab7b0
        public void IsModuleSupported(){} // RVA: 0x7ffaaf6ab9d0
        public void ShouldActivateModule(){} // RVA: 0x7ffaaf6aba20
        public void UseFakeInput(){} // RVA: 0x7ffaaf6abb20
        public void Process(){} // RVA: 0x7ffaaf6abb60
        public void FakeTouches(){} // RVA: 0x7ffaaf6abed0
        public void ProcessTouchEvents(){} // RVA: 0x7ffaaf6ac040
        public void ProcessTouchPress(){} // RVA: 0x7ffaaf6ac220
        public void DeactivateModule(){} // RVA: 0x7ffaa9d2cf50
        public void ToString(){} // RVA: 0x7ffaaf6ace40
    }

    public class UIBehaviour : MonoBehaviour
    {
        // ── Original Methods ──
        public void Awake(){} // RVA: 0x7ffaa8932310
        public void OnEnable(){} // RVA: 0x7ffaa8932310
        public void Start(){} // RVA: 0x7ffaa8932310
        public void OnDisable(){} // RVA: 0x7ffaa8932310
        public void OnDestroy(){} // RVA: 0x7ffaa8932310
        public void IsActive(){} // RVA: 0x7ffaaf2dcc50
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7ffaa8932310
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7ffaa8932310
        public void OnTransformParentChanged(){} // RVA: 0x7ffaa8932310
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7ffaa8932310
        public void OnCanvasGroupChanged(){} // RVA: 0x7ffaa8932310
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7ffaa8932310
        public void IsDestroyed(){} // RVA: 0x7ffaaf6afeb0
        public void .ctor(){} // RVA: 0x7ffaa8932d50
    }

}