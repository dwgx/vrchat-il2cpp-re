// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.EventSystems
// Classes: 41
// Methods: 421

namespace ThirdParty.Unity.UnityEngine.EventSystems
{
    public class AbstractEventData : Object
    {
        public bool used; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFAC322C880
        public void Use(){} // RVA: 0x7FFAC322C870
        public void get_used(){} // RVA: 0x7FFAC2FEB5E0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class AxisEventData : BaseEventData
    {
        public UnityEngine.Vector2 moveVector; // 0x20
        public 0x6B24CCB0 moveDir; // 0x28

        // ── Methods ──
        public void get_moveVector(){} // RVA: 0x7FFAC370B780
        public void set_moveVector(){} // RVA: 0x7FFAC370BEE0
        public void get_moveDir(){} // RVA: 0x7FFAC32EC4C0
        public void set_moveDir(){} // RVA: 0x7FFAC369A6E0
        public void .ctor(){} // RVA: 0x7FFAC9C7A6C0
    }

    public class BaseEventData : AbstractEventData
    {
        public UnityEngine.EventSystems.EventSystem currentInputModule; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F87E80
        public void get_currentInputModule(){} // RVA: 0x7FFAC8804960
        public void get_selectedObject(){} // RVA: 0x7FFAC88049C0
        public void set_selectedObject(){} // RVA: 0x7FFAC9C7A760
    }

    public class BaseInput : UIBehaviour
    {
        public object compositionString;
        public object imeCompositionMode;
        public object compositionCursorPos;
        public object mousePresent;
        public object mousePosition;
        public object mouseScrollDelta;
        public object touchSupported;
        public object touchCount;

        // ── Methods ──
        public void get_compositionString(){} // RVA: 0x7FFAC9940590
        public void get_imeCompositionMode(){} // RVA: 0x7FFAC99404F0
        public void set_imeCompositionMode(){} // RVA: 0x7FFAC9C81D90
        public void get_compositionCursorPos(){} // RVA: 0x7FFAC9C81DE0
        public void set_compositionCursorPos(){} // RVA: 0x7FFAC9C81E40
        public void get_mousePresent(){} // RVA: 0x7FFAC99406E0
        public void GetMouseButtonDown(){} // RVA: 0x7FFAC9B6E350
        public void GetMouseButtonUp(){} // RVA: 0x7FFAC9B6E3A0
        public void GetMouseButton(){} // RVA: 0x7FFAC9C81E90
        public void get_mousePosition(){} // RVA: 0x7FFAC9C81EE0
        public void get_mouseScrollDelta(){} // RVA: 0x7FFAC9C81F50
        public void get_touchSupported(){} // RVA: 0x7FFAC3F9AEF0
        public void get_touchCount(){} // RVA: 0x7FFAC9940730
        public void GetTouch(){} // RVA: 0x7FFAC9B6E2A0
        public void GetAxisRaw(){} // RVA: 0x7FFAC9C81FB0
        public void GetButtonDown(){} // RVA: 0x7FFAC2F40020
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class BaseInputModule : UIBehaviour
    {
        public System.Collections.Generic.List`1<UnityEngine.EventSystems.RaycastResult> sendPointerHoverToParent; // 0x20
        public bool input; // 0x28
        public UnityEngine.EventSystems.AxisEventData inputOverride; // 0x30
        public UnityEngine.EventSystems.EventSystem eventSystem; // 0x38
        public UnityEngine.EventSystems.BaseEventData m_BaseEventData; // 0x40
        public UnityEngine.EventSystems.BaseInput m_InputOverride; // 0x48
        public UnityEngine.EventSystems.BaseInput m_DefaultInput; // 0x50

        // ── Methods ──
        public void get_sendPointerHoverToParent(){} // RVA: 0x7FFAC30F6BA0
        public void set_sendPointerHoverToParent(){} // RVA: 0x7FFAC3C24F40
        public void get_input(){} // RVA: 0x7FFAC9C82000
        public void get_inputOverride(){} // RVA: 0x7FFAC2F9C730
        public void set_inputOverride(){} // RVA: 0x7FFAC2F9C740
        public void get_eventSystem(){} // RVA: 0x7FFAC31D0140
        public void OnEnable(){} // RVA: 0x7FFAC9C823C0
        public void OnDisable(){} // RVA: 0x7FFAC9C82460
        public void Process(){} // RVA: 0x7FFAC2C70980
        public void FindFirstRaycast(){} // RVA: 0x7FFAC9C82480
        public void DetermineMoveDirection(){} // RVA: 0x7FFAC9C82690 | overloaded x2
        public void FindCommonRoot(){} // RVA: 0x7FFAC9C82710
        public void HandlePointerExitAndEnter(){} // RVA: 0x7FFAC9C82AF0
        public void GetAxisEventData(){} // RVA: 0x7FFAC9C83B50
        public void GetBaseEventData(){} // RVA: 0x7FFAC9C83C90
        public void IsPointerOverGameObject(){} // RVA: 0x7FFAC2F21320
        public void ShouldActivateModule(){} // RVA: 0x7FFAC9C83DC0
        public void DeactivateModule(){} // RVA: 0x7FFAC2F21310
        public void ActivateModule(){} // RVA: 0x7FFAC2F21310
        public void UpdateModule(){} // RVA: 0x7FFAC2F21310
        public void IsModuleSupported(){} // RVA: 0x7FFAC3006850
        public void ConvertUIToolkitPointerId(){} // RVA: 0x7FFAC9C83EB0
        public void .ctor(){} // RVA: 0x7FFAC9C83F50
    }

    public class BaseRaycaster : UIBehaviour
    {
        public UnityEngine.EventSystems.BaseRaycaster eventCamera; // 0x20

        // ── Methods ──
        public void Raycast(){} // RVA: 0x7FFAC2C79B30
        public void get_eventCamera(){} // RVA: 0x7FFAC2C58E90
        public void get_priority(){} // RVA: 0x7FFAC34F9180
        public void get_sortOrderPriority(){} // RVA: 0x7FFAC9C8B5E0
        public void get_renderOrderPriority(){} // RVA: 0x7FFAC9C8B5E0
        public void get_rootRaycaster(){} // RVA: 0x7FFAC9C8B5F0
        public void ToString(){} // RVA: 0x7FFAC9C8B770
        public void OnEnable(){} // RVA: 0x7FFAC9C8BA80
        public void OnDisable(){} // RVA: 0x7FFAC9C8BBD0
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFAC81EE480
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC81EE480
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

    public class EventSystem : UIBehaviour
    {
        public System.Collections.Generic.List`1<UnityEngine.EventSystems.BaseInputModule> current; // 0x20
        public UnityEngine.EventSystems.BaseInputModule sendNavigationEvents; // 0x28
        public System.Collections.Generic.List`1<UnityEngine.EventSystems.EventSystem> pixelDragThreshold;
        public UnityEngine.GameObject currentInputModule; // 0x30
        public bool firstSelectedGameObject; // 0x38
        public int currentSelectedGameObject; // 0x3C
        public UnityEngine.GameObject lastSelectedGameObject; // 0x40
        public bool isFocused; // 0x48
        public bool alreadySelecting; // 0x49
        public UnityEngine.EventSystems.BaseEventData baseEventDataCache; // 0x50
        public System.Comparison`1<UnityEngine.EventSystems.RaycastResult> isUIToolkitActiveEventSystem; // 0x8
        public UIToolkitOverrideConfig sendUIToolkitEvents; // 0x10
        public bool createUIToolkitPanelGameObjectsOnStart; // 0x58
        public bool m_IsTrackingUIToolkitPanels; // 0x59

        // ── Methods ──
        public void get_current(){} // RVA: 0x7FFAC9C7BE80
        public void set_current(){} // RVA: 0x7FFAC9C7BF60
        public void get_sendNavigationEvents(){} // RVA: 0x7FFAC31D95D0
        public void set_sendNavigationEvents(){} // RVA: 0x7FFAC31D95C0
        public void get_pixelDragThreshold(){} // RVA: 0x7FFAC33BD4A0
        public void set_pixelDragThreshold(){} // RVA: 0x7FFAC47E2CD0
        public void get_currentInputModule(){} // RVA: 0x7FFAC2F4F130
        public void get_firstSelectedGameObject(){} // RVA: 0x7FFAC31D95E0
        public void set_firstSelectedGameObject(){} // RVA: 0x7FFAC2F4F890
        public void get_currentSelectedGameObject(){} // RVA: 0x7FFAC2F9E740
        public void get_lastSelectedGameObject(){} // RVA: 0x7FFAC34F9180
        public void get_isFocused(){} // RVA: 0x7FFAC2FD8D30
        public void .ctor(){} // RVA: 0x7FFAC9C7C130
        public void UpdateModules(){} // RVA: 0x7FFAC9C7C240
        public void get_alreadySelecting(){} // RVA: 0x7FFAC3E0F350
        public void SetSelectedGameObject(){} // RVA: 0x7FFAC9C7C860 | overloaded x2
        public void get_baseEventDataCache(){} // RVA: 0x7FFAC9C7C760
        public void RaycastComparer(){} // RVA: 0x7FFAC9C7C980
        public void RaycastAll(){} // RVA: 0x7FFAC9C7D0C0
        public void IsPointerOverGameObject(){} // RVA: 0x7FFAC9C7D4E0 | overloaded x2
        public void get_isUIToolkitActiveEventSystem(){} // RVA: 0x7FFAC9C7D5F0
        public void get_sendUIToolkitEvents(){} // RVA: 0x7FFAC9C7D810
        public void get_createUIToolkitPanelGameObjectsOnStart(){} // RVA: 0x7FFAC9C7D880
        public void SetUITookitEventSystemOverride(){} // RVA: 0x7FFAC9C7D8F0
        public void StartTrackingUIToolkitPanels(){} // RVA: 0x7FFAC9C7DC10
        public void StopTrackingUIToolkitPanels(){} // RVA: 0x7FFAC9C7E030
        public void CreateUIToolkitPanelGameObject(){} // RVA: 0x7FFAC9C7E240
        public void Start(){} // RVA: 0x7FFAC9C7E620
        public void OnEnable(){} // RVA: 0x7FFAC9C7E630
        public void OnDisable(){} // RVA: 0x7FFAC9C7E7A0
        public void TickModules(){} // RVA: 0x7FFAC9C7E980
        public void OnApplicationFocus(){} // RVA: 0x7FFAC9C7EB20
        public void Update(){} // RVA: 0x7FFAC9C7EB30
        public void ChangeEventModule(){} // RVA: 0x7FFAC9C7EFD0
        public void ToString(){} // RVA: 0x7FFAC9C7F2A0
        public void .cctor(){} // RVA: 0x7FFAC9C7F4B0
    }

    public class EventTrigger : MonoBehaviour
    {
        public System.Collections.Generic.List`1<Entry> delegates; // 0x20

        // ── Methods ──
        public void get_delegates(){} // RVA: 0x7FFAC9C7F790
        public void set_delegates(){} // RVA: 0x7FFAC2F4F0D0
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
        public void get_triggers(){} // RVA: 0x7FFAC9C7F7A0
        public void set_triggers(){} // RVA: 0x7FFAC2F4F0D0
        public void Execute(){} // RVA: 0x7FFAC9C7F860
        public void OnPointerEnter(){} // RVA: 0x7FFAC9C7F980
        public void OnPointerExit(){} // RVA: 0x7FFAC9C7F990
        public void OnDrag(){} // RVA: 0x7FFAC9C7F9A0
        public void OnDrop(){} // RVA: 0x7FFAC9C7F9B0
        public void OnPointerDown(){} // RVA: 0x7FFAC9C7F9C0
        public void OnPointerUp(){} // RVA: 0x7FFAC9C7F9D0
        public void OnPointerClick(){} // RVA: 0x7FFAC9C7F9E0
        public void OnSelect(){} // RVA: 0x7FFAC9C7F9F0
        public void OnDeselect(){} // RVA: 0x7FFAC9C7FA00
        public void OnScroll(){} // RVA: 0x7FFAC9C7FA10
        public void OnMove(){} // RVA: 0x7FFAC9C7FA20
        public void OnUpdateSelected(){} // RVA: 0x7FFAC9C7FA30
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFAC9C7FA40
        public void OnBeginDrag(){} // RVA: 0x7FFAC9C7FA50
        public void OnEndDrag(){} // RVA: 0x7FFAC9C7FA60
        public void OnSubmit(){} // RVA: 0x7FFAC9C7FA70
        public void OnCancel(){} // RVA: 0x7FFAC9C7FA80
    }

    public class ExecuteEvents : Object
    {
        public EventFunction`1<UnityEngine.EventSystems.IPointerMoveHandler> pointerMoveHandler;
        public EventFunction`1<UnityEngine.EventSystems.IPointerEnterHandler> pointerEnterHandler; // 0x8
        public EventFunction`1<UnityEngine.EventSystems.IPointerExitHandler> pointerExitHandler; // 0x10
        public EventFunction`1<UnityEngine.EventSystems.IPointerDownHandler> pointerDownHandler; // 0x18
        public EventFunction`1<UnityEngine.EventSystems.IPointerUpHandler> pointerUpHandler; // 0x20
        public EventFunction`1<UnityEngine.EventSystems.IPointerClickHandler> pointerClickHandler; // 0x28
        public EventFunction`1<UnityEngine.EventSystems.IInitializePotentialDragHandler> initializePotentialDrag; // 0x30
        public EventFunction`1<UnityEngine.EventSystems.IBeginDragHandler> beginDragHandler; // 0x38
        public EventFunction`1<UnityEngine.EventSystems.IDragHandler> dragHandler; // 0x40
        public EventFunction`1<UnityEngine.EventSystems.IEndDragHandler> endDragHandler; // 0x48
        public EventFunction`1<UnityEngine.EventSystems.IDropHandler> dropHandler; // 0x50
        public EventFunction`1<UnityEngine.EventSystems.IScrollHandler> scrollHandler; // 0x58
        public EventFunction`1<UnityEngine.EventSystems.IUpdateSelectedHandler> updateSelectedHandler; // 0x60
        public EventFunction`1<UnityEngine.EventSystems.ISelectHandler> selectHandler; // 0x68
        public EventFunction`1<UnityEngine.EventSystems.IDeselectHandler> deselectHandler; // 0x70
        public EventFunction`1<UnityEngine.EventSystems.IMoveHandler> moveHandler; // 0x78
        public EventFunction`1<UnityEngine.EventSystems.ISubmitHandler> submitHandler; // 0x80
        public EventFunction`1<UnityEngine.EventSystems.ICancelHandler> cancelHandler; // 0x88
        public System.Collections.Generic.List`1<UnityEngine.Transform> s_InternalTransformList; // 0x90

        // ── Methods ──
        public void ValidateEventData(){} // RVA: 0x7FFAC2E8DC40
        public void Execute(){} // RVA: 0x7FFAC2C5D5A0 | overloaded x19
        public void get_pointerMoveHandler(){} // RVA: 0x7FFAC9C80630
        public void get_pointerEnterHandler(){} // RVA: 0x7FFAC9C80690
        public void get_pointerExitHandler(){} // RVA: 0x7FFAC9C806F0
        public void get_pointerDownHandler(){} // RVA: 0x7FFAC9C80750
        public void get_pointerUpHandler(){} // RVA: 0x7FFAC9C807B0
        public void get_pointerClickHandler(){} // RVA: 0x7FFAC9C80810
        public void get_initializePotentialDrag(){} // RVA: 0x7FFAC9C80870
        public void get_beginDragHandler(){} // RVA: 0x7FFAC9C808D0
        public void get_dragHandler(){} // RVA: 0x7FFAC9C80930
        public void get_endDragHandler(){} // RVA: 0x7FFAC9C80990
        public void get_dropHandler(){} // RVA: 0x7FFAC9C809F0
        public void get_scrollHandler(){} // RVA: 0x7FFAC9C80A50
        public void get_updateSelectedHandler(){} // RVA: 0x7FFAC9C80AB0
        public void get_selectHandler(){} // RVA: 0x7FFAC9C80B10
        public void get_deselectHandler(){} // RVA: 0x7FFAC9C80B70
        public void get_moveHandler(){} // RVA: 0x7FFAC9C80BD0
        public void get_submitHandler(){} // RVA: 0x7FFAC9C80C30
        public void get_cancelHandler(){} // RVA: 0x7FFAC9C80C90
        public void GetEventChain(){} // RVA: 0x7FFAC9C80CF0
        public void ExecuteHierarchy(){} // RVA: 0x7FFAC2C69600
        public void ShouldSendToComponent(){} // RVA: 0x7FFAC2C59DE0
        public void GetEventList(){} // RVA: 0x7FFAC2C70C80
        public void CanHandleEvent(){} // RVA: 0x7FFAC2C59DE0
        public void GetEventHandler(){} // RVA: 0x7FFAC2C58F80
        public void .cctor(){} // RVA: 0x7FFAC9C80FA0
    }

    public class IBeginDragHandler
    {
        // ── Methods ──
        public void OnBeginDrag(){} // RVA: 0x7FFAC2C70A40
    }

    public class ICancelHandler
    {
        // ── Methods ──
        public void OnCancel(){} // RVA: 0x7FFAC2C70A40
    }

    public class IDeselectHandler
    {
        // ── Methods ──
        public void OnDeselect(){} // RVA: 0x7FFAC2C70A40
    }

    public class IDragHandler
    {
        // ── Methods ──
        public void OnDrag(){} // RVA: 0x7FFAC2C70A40
    }

    public class IDropHandler
    {
        // ── Methods ──
        public void OnDrop(){} // RVA: 0x7FFAC2C70A40
    }

    public class IEndDragHandler
    {
        // ── Methods ──
        public void OnEndDrag(){} // RVA: 0x7FFAC2C70A40
    }

    public class IEventSystemHandler
    {
    }

    public class IInitializePotentialDragHandler
    {
        // ── Methods ──
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFAC2C70A40
    }

    public class IMoveHandler
    {
        // ── Methods ──
        public void OnMove(){} // RVA: 0x7FFAC2C70A40
    }

    public class IPointerClickHandler
    {
        // ── Methods ──
        public void OnPointerClick(){} // RVA: 0x7FFAC2C70A40
    }

    public class IPointerDownHandler
    {
        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x7FFAC2C70A40
    }

    public class IPointerEnterHandler
    {
        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x7FFAC2C70A40
    }

    public class IPointerExitHandler
    {
        // ── Methods ──
        public void OnPointerExit(){} // RVA: 0x7FFAC2C70A40
    }

    public class IPointerMoveHandler
    {
        // ── Methods ──
        public void OnPointerMove(){} // RVA: 0x7FFAC2C70A40
    }

    public class IPointerUpHandler
    {
        // ── Methods ──
        public void OnPointerUp(){} // RVA: 0x7FFAC2C70A40
    }

    public class IScrollHandler
    {
        // ── Methods ──
        public void OnScroll(){} // RVA: 0x7FFAC2C70A40
    }

    public class ISelectHandler
    {
        // ── Methods ──
        public void OnSelect(){} // RVA: 0x7FFAC2C70A40
    }

    public class ISubmitHandler
    {
        // ── Methods ──
        public void OnSubmit(){} // RVA: 0x7FFAC2C70A40
    }

    public class IUpdateSelectedHandler
    {
        // ── Methods ──
        public void OnUpdateSelected(){} // RVA: 0x7FFAC2C70A40
    }

    public class OVRInputModule : PointerInputModule
    {
        public UnityEngine.Transform inputMode; // 0x68
        public OVRCursor allowActivationOnMobileDevice; // 0x70
        public 0x6B1A3F28 inputActionsPerSecond; // 0x78
        public 0x6B17D1A8 horizontalAxis; // 0x7C
        public bool verticalAxis; // 0x80
        public bool submitButton; // 0x81
        public float cancelButton; // 0x84
        public bool useSwipeScroll; // 0x88
        public float swipeDragThreshold; // 0x8C
        public float swipeDragScale; // 0x90
        public bool InvertSwipeXAxis; // 0x94
        public OVRRaycaster activeGraphicRaycaster; // 0x98
        public float angleDragThreshold; // 0xA0
        public float m_SpherecastRadius; // 0xA4
        public float m_NextAction; // 0xA8
        public UnityEngine.Vector2 m_LastMousePosition; // 0xAC
        public UnityEngine.Vector2 m_MousePosition; // 0xB4
        public string m_HorizontalAxis; // 0xC0
        public string m_VerticalAxis; // 0xC8
        public string m_SubmitButton; // 0xD0
        public string m_CancelButton; // 0xD8
        public float m_InputActionsPerSecond; // 0xE0
        public bool m_AllowActivationOnMobileDevice; // 0xE4
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.EventSystems.OVRPointerEventData> m_VRRayPointerData; // 0xE8
        public MouseState m_MouseState; // 0xF0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC89897A0
        public void get_inputMode(){} // RVA: 0x7FFAC34F9180
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x7FFAC88C0AF0
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x7FFAC8989B20
        public void get_inputActionsPerSecond(){} // RVA: 0x7FFAC33D0800
        public void set_inputActionsPerSecond(){} // RVA: 0x7FFAC33CAE10
        public void get_horizontalAxis(){} // RVA: 0x7FFAC2F8C120
        public void set_horizontalAxis(){} // RVA: 0x7FFAC2F8C130
        public void get_verticalAxis(){} // RVA: 0x7FFAC3079460
        public void set_verticalAxis(){} // RVA: 0x7FFAC3079470
        public void get_submitButton(){} // RVA: 0x7FFAC303E100
        public void set_submitButton(){} // RVA: 0x7FFAC303E110
        public void get_cancelButton(){} // RVA: 0x7FFAC3540F70
        public void set_cancelButton(){} // RVA: 0x7FFAC2FA28A0
        public void UpdateModule(){} // RVA: 0x7FFAC8989B30
        public void IsModuleSupported(){} // RVA: 0x7FFAC8989BD0
        public void ShouldActivateModule(){} // RVA: 0x7FFAC8989C30
        public void ActivateModule(){} // RVA: 0x7FFAC8989E70
        public void DeactivateModule(){} // RVA: 0x7FFAC898A070
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x7FFAC898A080
        public void AllowMoveEventProcessing(){} // RVA: 0x7FFAC898A310
        public void GetRawMoveVector(){} // RVA: 0x7FFAC898A3F0
        public void SendMoveEventToSelectedObject(){} // RVA: 0x7FFAC898A5D0
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x7FFAC898A810
        public void ProcessMousePress(){} // RVA: 0x7FFAC898A9A0
        public void ProcessMouseEvent(){} // RVA: 0x7FFAC898B600
        public void Process(){} // RVA: 0x7FFAC898BA90
        public void UseMouse(){} // RVA: 0x7FFAC898BC90
        public void CopyFromTo(){} // RVA: 0x7FFAC898BEE0 | overloaded x2
        public void GetPointerData(){} // RVA: 0x7FFAC898C050
        public void ClearSelection(){} // RVA: 0x7FFAC898C1B0
        public void GetRectTransformNormal(){} // RVA: 0x7FFAC898C660
        public void GetGazePointerData(){} // RVA: 0x7FFAC898C8C0
        public void GetCanvasPointerData(){} // RVA: 0x7FFAC898D8B0
        public void ShouldStartDrag(){} // RVA: 0x7FFAC898E190
        public void IsPointerMoving(){} // RVA: 0x7FFAC898E550
        public void SwipeAdjustedPosition(){} // RVA: 0x7FFAC3E92FB0
        public void ProcessDrag(){} // RVA: 0x7FFAC898E5F0
        public void GetGazeButtonState(){} // RVA: 0x7FFAC898EAB0
        public void GetExtraScrollDelta(){} // RVA: 0x7FFAC898ECA0
    }

    public class OVRPhysicsRaycaster : BaseRaycaster
    {
        public int eventCamera;
        public UnityEngine.LayerMask depth; // 0x28
        public int sortOrderPriority; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC3B184B0
        public void get_eventCamera(){} // RVA: 0x7FFAC898EDA0
        public void get_depth(){} // RVA: 0x7FFAC898EE10
        public void get_sortOrderPriority(){} // RVA: 0x7FFAC3C891D0
        public void get_finalEventMask(){} // RVA: 0x7FFAC898EF70
        public void get_eventMask(){} // RVA: 0x7FFAC32EC4C0
        public void set_eventMask(){} // RVA: 0x7FFAC369A6E0
        public void Raycast(){} // RVA: 0x7FFAC898F0D0
        public void Spherecast(){} // RVA: 0x7FFAC898F840
        public void GetScreenPos(){} // RVA: 0x7FFAC898FFD0
    }

    public class OVRPointerEventData : PointerEventData
    {
        public UnityEngine.Ray worldSpaceRay; // 0x180
        public UnityEngine.Vector2 swipeStart; // 0x198

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8990190
        public void ToString(){} // RVA: 0x7FFAC89901A0
    }

    public class Physics2DRaycaster : PhysicsRaycaster
    {
        public UnityEngine.RaycastHit2D[] m_Hits; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4269B50
        public void Raycast(){} // RVA: 0x7FFAC9C8BCE0
    }

    public class PhysicsRaycaster : BaseRaycaster
    {
        public int eventCamera;
        public UnityEngine.Camera depth; // 0x28
        public UnityEngine.LayerMask finalEventMask; // 0x30
        public int eventMask; // 0x34
        public int maxRayIntersections; // 0x38
        public UnityEngine.RaycastHit[] m_Hits; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC4269B50
        public void get_eventCamera(){} // RVA: 0x7FFAC9C8C790
        public void get_depth(){} // RVA: 0x7FFAC9C8C9B0
        public void get_finalEventMask(){} // RVA: 0x7FFAC9C8CB10
        public void get_eventMask(){} // RVA: 0x7FFAC2F7CCD0
        public void set_eventMask(){} // RVA: 0x7FFAC2F7CCE0
        public void get_maxRayIntersections(){} // RVA: 0x7FFAC3ADEDC0
        public void set_maxRayIntersections(){} // RVA: 0x7FFAC416A6E0
        public void ComputeRayAndDistance(){} // RVA: 0x7FFAC9C8CC70
        public void Raycast(){} // RVA: 0x7FFAC9C8D100
    }

    public class PointerEventData : BaseEventData
    {
        public UnityEngine.GameObject pointerEnter; // 0x20
        public UnityEngine.GameObject lastPress; // 0x28
        public UnityEngine.GameObject rawPointerPress; // 0x30
        public UnityEngine.GameObject pointerDrag; // 0x38
        public UnityEngine.GameObject pointerClick; // 0x40
        public UnityEngine.GameObject pointerCurrentRaycast; // 0x48
        public UnityEngine.EventSystems.RaycastResult pointerPressRaycast; // 0x50
        public UnityEngine.EventSystems.RaycastResult eligibleForClick; // 0xA0
        public System.Collections.Generic.List`1<UnityEngine.GameObject> displayIndex; // 0xF0
        public bool pointerId; // 0xF8
        public int position; // 0xFC
        public int delta; // 0x100
        public UnityEngine.Vector2 pressPosition; // 0x104
        public UnityEngine.Vector2 worldPosition; // 0x10C
        public UnityEngine.Vector2 worldNormal; // 0x114
        public UnityEngine.Vector3 clickTime; // 0x11C
        public UnityEngine.Vector3 clickCount; // 0x128
        public float scrollDelta; // 0x134
        public int useDragThreshold; // 0x138
        public UnityEngine.Vector2 dragging; // 0x13C
        public bool button; // 0x144
        public bool pressure; // 0x145
        public 0x6B24BE98 tangentialPressure; // 0x148
        public float altitudeAngle; // 0x14C
        public float azimuthAngle; // 0x150
        public float twist; // 0x154
        public float tilt; // 0x158
        public float penStatus; // 0x15C
        public UnityEngine.Vector2 radius; // 0x160
        public 0x6B2D9160 radiusVariance; // 0x168
        public UnityEngine.Vector2 fullyExited; // 0x16C
        public UnityEngine.Vector2 reentered; // 0x174
        public bool enterEventCamera; // 0x17C
        public bool pressEventCamera; // 0x17D

        // ── Methods ──
        public void get_pointerEnter(){} // RVA: 0x7FFAC2F4F0C0
        public void set_pointerEnter(){} // RVA: 0x7FFAC2F4F0D0
        public void get_lastPress(){} // RVA: 0x7FFAC31D95E0
        public void set_lastPress(){} // RVA: 0x7FFAC2F4F890
        public void get_rawPointerPress(){} // RVA: 0x7FFAC31D0140
        public void set_rawPointerPress(){} // RVA: 0x7FFAC31D0C20
        public void get_pointerDrag(){} // RVA: 0x7FFAC2F9E740
        public void set_pointerDrag(){} // RVA: 0x7FFAC2F49200
        public void get_pointerClick(){} // RVA: 0x7FFAC2F9C730
        public void set_pointerClick(){} // RVA: 0x7FFAC2F9C740
        public void get_pointerCurrentRaycast(){} // RVA: 0x7FFAC6B14810
        public void set_pointerCurrentRaycast(){} // RVA: 0x7FFAC9C7A790
        public void get_pointerPressRaycast(){} // RVA: 0x7FFAC9C7A810
        public void set_pointerPressRaycast(){} // RVA: 0x7FFAC9C7A850
        public void get_eligibleForClick(){} // RVA: 0x7FFAC3C8E090
        public void set_eligibleForClick(){} // RVA: 0x7FFAC97AF8F0
        public void get_displayIndex(){} // RVA: 0x7FFAC3C8BB20
        public void set_displayIndex(){} // RVA: 0x7FFAC97AF870
        public void get_pointerId(){} // RVA: 0x7FFAC8C068C0
        public void set_pointerId(){} // RVA: 0x7FFAC9C7A8E0
        public void get_position(){} // RVA: 0x7FFAC9C7A8F0
        public void set_position(){} // RVA: 0x7FFAC9C7A910
        public void get_delta(){} // RVA: 0x7FFAC9C7A920
        public void set_delta(){} // RVA: 0x7FFAC9C7A940
        public void get_pressPosition(){} // RVA: 0x7FFAC9C7A950
        public void set_pressPosition(){} // RVA: 0x7FFAC9C7A970
        public void get_worldPosition(){} // RVA: 0x7FFAC9C7A980
        public void set_worldPosition(){} // RVA: 0x7FFAC9C7A9A0
        public void get_worldNormal(){} // RVA: 0x7FFAC9C7A9C0
        public void set_worldNormal(){} // RVA: 0x7FFAC9C7A9E0
        public void get_clickTime(){} // RVA: 0x7FFAC9C7AA00
        public void set_clickTime(){} // RVA: 0x7FFAC9C7AA10
        public void get_clickCount(){} // RVA: 0x7FFAC3C8EC30
        public void set_clickCount(){} // RVA: 0x7FFAC88C7220
        public void get_scrollDelta(){} // RVA: 0x7FFAC8A11730
        public void set_scrollDelta(){} // RVA: 0x7FFAC8A11750
        public void get_useDragThreshold(){} // RVA: 0x7FFAC33B8570
        public void set_useDragThreshold(){} // RVA: 0x7FFAC9C7AA20
        public void get_dragging(){} // RVA: 0x7FFAC9C7AA30
        public void set_dragging(){} // RVA: 0x7FFAC9C7AA40
        public void get_button(){} // RVA: 0x7FFAC4090620
        public void set_button(){} // RVA: 0x7FFAC409EA20
        public void get_pressure(){} // RVA: 0x7FFAC9C7AA50
        public void set_pressure(){} // RVA: 0x7FFAC9C7AA60
        public void get_tangentialPressure(){} // RVA: 0x7FFAC9C7AA70
        public void set_tangentialPressure(){} // RVA: 0x7FFAC9C7AA80
        public void get_altitudeAngle(){} // RVA: 0x7FFAC9C7AA90
        public void set_altitudeAngle(){} // RVA: 0x7FFAC9C7AAA0
        public void get_azimuthAngle(){} // RVA: 0x7FFAC9C7AAB0
        public void set_azimuthAngle(){} // RVA: 0x7FFAC9C7AAC0
        public void get_twist(){} // RVA: 0x7FFAC97676F0
        public void set_twist(){} // RVA: 0x7FFAC3C88D30
        public void get_tilt(){} // RVA: 0x7FFAC9C7AAD0
        public void set_tilt(){} // RVA: 0x7FFAC9C7AAF0
        public void get_penStatus(){} // RVA: 0x7FFAC9C7AB00
        public void set_penStatus(){} // RVA: 0x7FFAC9C7AB10
        public void get_radius(){} // RVA: 0x7FFAC9C7AB20
        public void set_radius(){} // RVA: 0x7FFAC9C7AB40
        public void get_radiusVariance(){} // RVA: 0x7FFAC9C7AB50
        public void set_radiusVariance(){} // RVA: 0x7FFAC9C7AB70
        public void get_fullyExited(){} // RVA: 0x7FFAC9C7AB80
        public void set_fullyExited(){} // RVA: 0x7FFAC9C7AB90
        public void get_reentered(){} // RVA: 0x7FFAC2FB1510
        public void set_reentered(){} // RVA: 0x7FFAC2FB1520
        public void .ctor(){} // RVA: 0x7FFAC9C7ABA0
        public void IsPointerMoving(){} // RVA: 0x7FFAC9C7AEC0
        public void IsScrolling(){} // RVA: 0x7FFAC9C7AEF0
        public void get_enterEventCamera(){} // RVA: 0x7FFAC9C7AF20
        public void get_pressEventCamera(){} // RVA: 0x7FFAC9C7B040
        public void get_pointerPress(){} // RVA: 0x7FFAC2F4F130
        public void set_pointerPress(){} // RVA: 0x7FFAC9C7B170
        public void ToString(){} // RVA: 0x7FFAC9C7B340
    }

    public class PointerEventDataExtension : Object
    {
        // ── Methods ──
        public void IsVRPointer(){} // RVA: 0x7FFAC89906D0
        public void GetRay(){} // RVA: 0x7FFAC8990760
        public void GetSwipeStart(){} // RVA: 0x7FFAC8990810
        public void SetSwipeStart(){} // RVA: 0x7FFAC89908B0
    }

    public class PointerInputModule : BaseInputModule
    {
        public int kMouseLeftId;
        public int kMouseRightId;
        public int kMouseMiddleId;
        public int kFakeTouchesId;
        public System.Collections.Generic.Dictionary`2<int,UnityEngine.EventSystems.PointerEventData> m_PointerData; // 0x58
        public MouseState m_MouseState; // 0x60

        // ── Methods ──
        public void GetPointerData(){} // RVA: 0x7FFAC9C84050
        public void RemovePointerData(){} // RVA: 0x7FFAC9C841B0
        public void GetTouchPointerEventData(){} // RVA: 0x7FFAC9C84220
        public void CopyFromTo(){} // RVA: 0x7FFAC9C846C0
        public void StateForMouseButton(){} // RVA: 0x7FFAC9C848C0
        public void GetMousePointerEventData(){} // RVA: 0x7FFAC9C84980 | overloaded x2
        public void GetLastPointerEventData(){} // RVA: 0x7FFAC9C85240
        public void ShouldStartDrag(){} // RVA: 0x7FFAC9C85270
        public void ProcessMove(){} // RVA: 0x7FFAC9C852C0
        public void ProcessDrag(){} // RVA: 0x7FFAC9C85350
        public void IsPointerOverGameObject(){} // RVA: 0x7FFAC9C85700
        public void ClearSelection(){} // RVA: 0x7FFAC9C85810
        public void ToString(){} // RVA: 0x7FFAC9C85AA0
        public void DeselectIfSelectionChanged(){} // RVA: 0x7FFAC9C85DF0
        public void .ctor(){} // RVA: 0x7FFAC9C85F90
    }

    public class RaycastResult : ValueType
    {
        public UnityEngine.GameObject gameObject; // 0x10
        public UnityEngine.EventSystems.BaseRaycaster isValid; // 0x18
        public float distance; // 0x20
        public float index; // 0x24
        public int depth; // 0x28
        public int sortingGroupID; // 0x2C
        public int sortingGroupOrder; // 0x30
        public int sortingLayer; // 0x34
        public int sortingOrder; // 0x38
        public UnityEngine.Vector3 worldPosition; // 0x3C
        public UnityEngine.Vector3 worldNormal; // 0x48
        public UnityEngine.Vector2 screenPosition; // 0x54
        public int displayIndex; // 0x5C

        // ── Methods ──
        public void get_gameObject(){} // RVA: 0x7FFAC3AD9F60
        public void set_gameObject(){} // RVA: 0x7FFAC38DFE40
        public void get_isValid(){} // RVA: 0x7FFAC9C8D700
        public void Clear(){} // RVA: 0x7FFAC9C8D870
        public void ToString(){} // RVA: 0x7FFAC9C8DA00
    }

    public class RaycasterManager : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.EventSystems.BaseRaycaster> s_Raycasters;

        // ── Methods ──
        public void AddRaycaster(){} // RVA: 0x7FFAC9C8B2A0
        public void GetRaycasters(){} // RVA: 0x7FFAC9C8B3C0
        public void RemoveRaycasters(){} // RVA: 0x7FFAC9C8B420
        public void .cctor(){} // RVA: 0x7FFAC9C8B500
    }

    public class StandaloneInputModule : PointerInputModule
    {
        public float inputMode; // 0x68
        public UnityEngine.Vector2 allowActivationOnMobileDevice; // 0x6C
        public int forceModuleActive; // 0x74
        public UnityEngine.Vector2 inputActionsPerSecond; // 0x78
        public UnityEngine.Vector2 repeatDelay; // 0x80
        public UnityEngine.GameObject horizontalAxis; // 0x88
        public UnityEngine.EventSystems.PointerEventData verticalAxis; // 0x90
        public float submitButton;
        public string cancelButton; // 0x98
        public string m_VerticalAxis; // 0xA0
        public string m_SubmitButton; // 0xA8
        public string m_CancelButton; // 0xB0
        public float m_InputActionsPerSecond; // 0xB8
        public float m_RepeatDelay; // 0xBC
        public bool m_ForceModuleActive; // 0xC0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C86610
        public void get_inputMode(){} // RVA: 0x7FFAC34F9180
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x7FFAC2F424C0
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x7FFAC2F424D0
        public void get_forceModuleActive(){} // RVA: 0x7FFAC2F424C0
        public void set_forceModuleActive(){} // RVA: 0x7FFAC2F424D0
        public void get_inputActionsPerSecond(){} // RVA: 0x7FFAC47D32C0
        public void set_inputActionsPerSecond(){} // RVA: 0x7FFAC47D32B0
        public void get_repeatDelay(){} // RVA: 0x7FFAC47D32A0
        public void set_repeatDelay(){} // RVA: 0x7FFAC47D3290
        public void get_horizontalAxis(){} // RVA: 0x7FFAC354DFB0
        public void set_horizontalAxis(){} // RVA: 0x7FFAC354E3C0
        public void get_verticalAxis(){} // RVA: 0x7FFAC3543900
        public void set_verticalAxis(){} // RVA: 0x7FFAC354E420
        public void get_submitButton(){} // RVA: 0x7FFAC354B1A0
        public void set_submitButton(){} // RVA: 0x7FFAC334B370
        public void get_cancelButton(){} // RVA: 0x7FFAC2F8C040
        public void set_cancelButton(){} // RVA: 0x7FFAC2F8C050
        public void ShouldIgnoreEventsOnNoFocus(){} // RVA: 0x7FFAC3006850
        public void UpdateModule(){} // RVA: 0x7FFAC9C86820
        public void ReleaseMouse(){} // RVA: 0x7FFAC9C86A20
        public void ShouldActivateModule(){} // RVA: 0x7FFAC9C87070
        public void ActivateModule(){} // RVA: 0x7FFAC9C87280
        public void DeactivateModule(){} // RVA: 0x7FFAC43083D0
        public void Process(){} // RVA: 0x7FFAC9C87450
        public void ProcessTouchEvents(){} // RVA: 0x7FFAC9C87670
        public void ProcessTouchPress(){} // RVA: 0x7FFAC9C87880
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x7FFAC9C88540
        public void GetRawMoveVector(){} // RVA: 0x7FFAC9C88790
        public void SendMoveEventToSelectedObject(){} // RVA: 0x7FFAC9C88900
        public void ProcessMouseEvent(){} // RVA: 0x7FFAC9C88C80 | overloaded x2
        public void ForceAutoSelect(){} // RVA: 0x7FFAC2F21320
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x7FFAC9C88F50
        public void ProcessMousePress(){} // RVA: 0x7FFAC9C890E0
        public void GetCurrentFocusedGameObject(){} // RVA: 0x7FFAC2F60010
    }

    public class TouchInputModule : PointerInputModule
    {
        public UnityEngine.Vector2 allowActivationOnStandalone; // 0x68
        public UnityEngine.Vector2 forceModuleActive; // 0x70
        public UnityEngine.EventSystems.PointerEventData m_InputPointerEvent; // 0x78
        public bool m_ForceModuleActive; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9C89830
        public void get_allowActivationOnStandalone(){} // RVA: 0x7FFAC313E620
        public void set_allowActivationOnStandalone(){} // RVA: 0x7FFAC313D3B0
        public void get_forceModuleActive(){} // RVA: 0x7FFAC313E620
        public void set_forceModuleActive(){} // RVA: 0x7FFAC313D3B0
        public void UpdateModule(){} // RVA: 0x7FFAC9C89840
        public void IsModuleSupported(){} // RVA: 0x7FFAC9C89A60
        public void ShouldActivateModule(){} // RVA: 0x7FFAC9C89AB0
        public void UseFakeInput(){} // RVA: 0x7FFAC9C89BB0
        public void Process(){} // RVA: 0x7FFAC9C89BF0
        public void FakeTouches(){} // RVA: 0x7FFAC9C89F60
        public void ProcessTouchEvents(){} // RVA: 0x7FFAC9C8A0D0
        public void ProcessTouchPress(){} // RVA: 0x7FFAC9C8A2B0
        public void DeactivateModule(){} // RVA: 0x7FFAC43083D0
        public void ToString(){} // RVA: 0x7FFAC9C8AED0
    }

    public class UIBehaviour : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFAC2F21310
        public void OnEnable(){} // RVA: 0x7FFAC2F21310
        public void Start(){} // RVA: 0x7FFAC2F21310
        public void OnDisable(){} // RVA: 0x7FFAC2F21310
        public void OnDestroy(){} // RVA: 0x7FFAC2F21310
        public void IsActive(){} // RVA: 0x7FFAC98BACF0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFAC2F21310
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7FFAC2F21310
        public void OnTransformParentChanged(){} // RVA: 0x7FFAC2F21310
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFAC2F21310
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFAC2F21310
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFAC2F21310
        public void IsDestroyed(){} // RVA: 0x7FFAC9C8DF40
        public void .ctor(){} // RVA: 0x7FFAC2F21D50
    }

}