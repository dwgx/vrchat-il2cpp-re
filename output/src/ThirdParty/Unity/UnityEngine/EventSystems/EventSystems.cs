// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.EventSystems
// Classes: 40
// Methods: 417

namespace ThirdParty.Unity.UnityEngine.EventSystems
{
    public class AbstractEventData : Object
    {
        public bool used; // 0x10

        // ── Methods ──
        public void Reset(){} // RVA: 0x7FFD4E64C880
        public void Use(){} // RVA: 0x7FFD4E64C870
        public void get_used(){} // RVA: 0x7FFD4E40B5E0
        public void .ctor(){} // RVA: 0x7FFD4E341310
    }

    public class AxisEventData : BaseEventData
    {
        public tionX moveVector; // 0x20
        public moryFailure.in moveDir; // 0x28

        // ── Methods ──
        public void get_moveVector(){} // RVA: 0x7FFD4EB2B780
        public void set_moveVector(){} // RVA: 0x7FFD4EB2BEE0
        public void get_moveDir(){} // RVA: 0x7FFD4E70C4C0
        public void set_moveDir(){} // RVA: 0x7FFD4EABA6E0
        public void .ctor(){} // RVA: 0x7FFD5509A6C0
    }

    public class BaseEventData : AbstractEventData
    {
        public moryFailure.CanvasElementForLayoutRebuild currentInputModule; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E3A7E80
        public void get_currentInputModule(){} // RVA: 0x7FFD53C24960
        public void get_selectedObject(){} // RVA: 0x7FFD53C249C0
        public void set_selectedObject(){} // RVA: 0x7FFD5509A760
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
        public void get_compositionString(){} // RVA: 0x7FFD54D60590
        public void get_imeCompositionMode(){} // RVA: 0x7FFD54D604F0
        public void set_imeCompositionMode(){} // RVA: 0x7FFD550A1D90
        public void get_compositionCursorPos(){} // RVA: 0x7FFD550A1DE0
        public void set_compositionCursorPos(){} // RVA: 0x7FFD550A1E40
        public void get_mousePresent(){} // RVA: 0x7FFD54D606E0
        public void GetMouseButtonDown(){} // RVA: 0x7FFD54F8E350
        public void GetMouseButtonUp(){} // RVA: 0x7FFD54F8E3A0
        public void GetMouseButton(){} // RVA: 0x7FFD550A1E90
        public void get_mousePosition(){} // RVA: 0x7FFD550A1EE0
        public void get_mouseScrollDelta(){} // RVA: 0x7FFD550A1F50
        public void get_touchSupported(){} // RVA: 0x7FFD4F3BAEF0
        public void get_touchCount(){} // RVA: 0x7FFD54D60730
        public void GetTouch(){} // RVA: 0x7FFD54F8E2A0
        public void GetAxisRaw(){} // RVA: 0x7FFD550A1FB0
        public void GetButtonDown(){} // RVA: 0x7FFD4E360020
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class BaseInputModule : UIBehaviour
    {
        public URA.woDigitYearMax<moryFailure.priteMesh> sendPointerHoverToParent; // 0x20
        public bool input; // 0x28
        public moryFailure.en>>.Remove inputOverride; // 0x30
        public moryFailure.CanvasElementForLayoutRebuild eventSystem; // 0x38
        public moryFailure..Newtonsoft.Json.Linq.JToken>.Values m_BaseEventData; // 0x40
        public moryFailure._BackingField m_InputOverride; // 0x48
        public moryFailure._BackingField m_DefaultInput; // 0x50

        // ── Methods ──
        public void get_sendPointerHoverToParent(){} // RVA: 0x7FFD4E516BA0
        public void set_sendPointerHoverToParent(){} // RVA: 0x7FFD4F044F40
        public void get_input(){} // RVA: 0x7FFD550A2000
        public void get_inputOverride(){} // RVA: 0x7FFD4E3BC730
        public void set_inputOverride(){} // RVA: 0x7FFD4E3BC740
        public void get_eventSystem(){} // RVA: 0x7FFD4E5F0140
        public void OnEnable(){} // RVA: 0x7FFD550A23C0
        public void OnDisable(){} // RVA: 0x7FFD550A2460
        public void Process(){} // RVA: 0x7FFD4E090980
        public void FindFirstRaycast(){} // RVA: 0x7FFD550A2480
        public void DetermineMoveDirection(){} // RVA: 0x7FFD550A2690 | overloaded x2
        public void FindCommonRoot(){} // RVA: 0x7FFD550A2710
        public void HandlePointerExitAndEnter(){} // RVA: 0x7FFD550A2AF0
        public void GetAxisEventData(){} // RVA: 0x7FFD550A3B50
        public void GetBaseEventData(){} // RVA: 0x7FFD550A3C90
        public void IsPointerOverGameObject(){} // RVA: 0x7FFD4E341320
        public void ShouldActivateModule(){} // RVA: 0x7FFD550A3DC0
        public void DeactivateModule(){} // RVA: 0x7FFD4E341310
        public void ActivateModule(){} // RVA: 0x7FFD4E341310
        public void UpdateModule(){} // RVA: 0x7FFD4E341310
        public void IsModuleSupported(){} // RVA: 0x7FFD4E426850
        public void ConvertUIToolkitPointerId(){} // RVA: 0x7FFD550A3EB0
        public void .ctor(){} // RVA: 0x7FFD550A3F50
    }

    public class BaseRaycaster : UIBehaviour
    {
        public moryFailure.in eventCamera; // 0x20

        // ── Methods ──
        public void Raycast(){} // RVA: 0x7FFD4E099B30
        public void get_eventCamera(){} // RVA: 0x7FFD4E078E90
        public void get_priority(){} // RVA: 0x7FFD4E919180
        public void get_sortOrderPriority(){} // RVA: 0x7FFD550AB5E0
        public void get_renderOrderPriority(){} // RVA: 0x7FFD550AB5E0
        public void get_rootRaycaster(){} // RVA: 0x7FFD550AB5F0
        public void ToString(){} // RVA: 0x7FFD550AB770
        public void OnEnable(){} // RVA: 0x7FFD550ABA80
        public void OnDisable(){} // RVA: 0x7FFD550ABBD0
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFD5360E480
        public void OnTransformParentChanged(){} // RVA: 0x7FFD5360E480
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

    public class EventSystem : UIBehaviour
    {
        public URA.woDigitYearMax<moryFailure.jects> current; // 0x20
        public moryFailure.jects sendNavigationEvents; // 0x28
        public URA.woDigitYearMax<moryFailure.CanvasElementForLayoutRebuild> pixelDragThreshold;
        public BuffersImpl currentInputModule; // 0x30
        public bool firstSelectedGameObject; // 0x38
        public int currentSelectedGameObject; // 0x3C
        public BuffersImpl lastSelectedGameObject; // 0x40
        public bool isFocused; // 0x48
        public bool alreadySelecting; // 0x49
        public moryFailure..Newtonsoft.Json.Linq.JToken>.Values baseEventDataCache; // 0x50
        public ation<moryFailure.priteMesh> isUIToolkitActiveEventSystem; // 0x8
        public mentSize sendUIToolkitEvents; // 0x10
        public bool createUIToolkitPanelGameObjectsOnStart; // 0x58
        public bool m_IsTrackingUIToolkitPanels; // 0x59

        // ── Methods ──
        public void get_current(){} // RVA: 0x7FFD5509BE80
        public void set_current(){} // RVA: 0x7FFD5509BF60
        public void get_sendNavigationEvents(){} // RVA: 0x7FFD4E5F95D0
        public void set_sendNavigationEvents(){} // RVA: 0x7FFD4E5F95C0
        public void get_pixelDragThreshold(){} // RVA: 0x7FFD4E7DD4A0
        public void set_pixelDragThreshold(){} // RVA: 0x7FFD4FC02CD0
        public void get_currentInputModule(){} // RVA: 0x7FFD4E36F130
        public void get_firstSelectedGameObject(){} // RVA: 0x7FFD4E5F95E0
        public void set_firstSelectedGameObject(){} // RVA: 0x7FFD4E36F890
        public void get_currentSelectedGameObject(){} // RVA: 0x7FFD4E3BE740
        public void get_lastSelectedGameObject(){} // RVA: 0x7FFD4E919180
        public void get_isFocused(){} // RVA: 0x7FFD4E3F8D30
        public void .ctor(){} // RVA: 0x7FFD5509C130
        public void UpdateModules(){} // RVA: 0x7FFD5509C240
        public void get_alreadySelecting(){} // RVA: 0x7FFD4F22F350
        public void SetSelectedGameObject(){} // RVA: 0x7FFD5509C860 | overloaded x2
        public void get_baseEventDataCache(){} // RVA: 0x7FFD5509C760
        public void RaycastComparer(){} // RVA: 0x7FFD5509C980
        public void RaycastAll(){} // RVA: 0x7FFD5509D0C0
        public void IsPointerOverGameObject(){} // RVA: 0x7FFD5509D4E0 | overloaded x2
        public void get_isUIToolkitActiveEventSystem(){} // RVA: 0x7FFD5509D5F0
        public void get_sendUIToolkitEvents(){} // RVA: 0x7FFD5509D810
        public void get_createUIToolkitPanelGameObjectsOnStart(){} // RVA: 0x7FFD5509D880
        public void SetUITookitEventSystemOverride(){} // RVA: 0x7FFD5509D8F0
        public void StartTrackingUIToolkitPanels(){} // RVA: 0x7FFD5509DC10
        public void StopTrackingUIToolkitPanels(){} // RVA: 0x7FFD5509E030
        public void CreateUIToolkitPanelGameObject(){} // RVA: 0x7FFD5509E240
        public void Start(){} // RVA: 0x7FFD5509E620
        public void OnEnable(){} // RVA: 0x7FFD5509E630
        public void OnDisable(){} // RVA: 0x7FFD5509E7A0
        public void TickModules(){} // RVA: 0x7FFD5509E980
        public void OnApplicationFocus(){} // RVA: 0x7FFD5509EB20
        public void Update(){} // RVA: 0x7FFD5509EB30
        public void ChangeEventModule(){} // RVA: 0x7FFD5509EFD0
        public void ToString(){} // RVA: 0x7FFD5509F2A0
        public void .cctor(){} // RVA: 0x7FFD5509F4B0
    }

    public class EventTrigger : MonoBehaviour
    {
        public URA.woDigitYearMax<?> delegates; // 0x20

        // ── Methods ──
        public void get_delegates(){} // RVA: 0x7FFD5509F790
        public void set_delegates(){} // RVA: 0x7FFD4E36F0D0
        public void .ctor(){} // RVA: 0x7FFD4E341D50
        public void get_triggers(){} // RVA: 0x7FFD5509F7A0
        public void set_triggers(){} // RVA: 0x7FFD4E36F0D0
        public void Execute(){} // RVA: 0x7FFD5509F860
        public void OnPointerEnter(){} // RVA: 0x7FFD5509F980
        public void OnPointerExit(){} // RVA: 0x7FFD5509F990
        public void OnDrag(){} // RVA: 0x7FFD5509F9A0
        public void OnDrop(){} // RVA: 0x7FFD5509F9B0
        public void OnPointerDown(){} // RVA: 0x7FFD5509F9C0
        public void OnPointerUp(){} // RVA: 0x7FFD5509F9D0
        public void OnPointerClick(){} // RVA: 0x7FFD5509F9E0
        public void OnSelect(){} // RVA: 0x7FFD5509F9F0
        public void OnDeselect(){} // RVA: 0x7FFD5509FA00
        public void OnScroll(){} // RVA: 0x7FFD5509FA10
        public void OnMove(){} // RVA: 0x7FFD5509FA20
        public void OnUpdateSelected(){} // RVA: 0x7FFD5509FA30
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFD5509FA40
        public void OnBeginDrag(){} // RVA: 0x7FFD5509FA50
        public void OnEndDrag(){} // RVA: 0x7FFD5509FA60
        public void OnSubmit(){} // RVA: 0x7FFD5509FA70
        public void OnCancel(){} // RVA: 0x7FFD5509FA80
    }

    public class ExecuteEvents : Object
    {
        public eshGeneration>k__BackingField<moryFailure.et_onClick> pointerMoveHandler;
        public eshGeneration>k__BackingField<moryFailure.ubmit> pointerEnterHandler; // 0x8
        public eshGeneration>k__BackingField<moryFailure.ck> pointerExitHandler; // 0x10
        public eshGeneration>k__BackingField<moryFailure.t> pointerDownHandler; // 0x18
        public eshGeneration>k__BackingField<moryFailure._9> pointerUpHandler; // 0x20
        public eshGeneration>k__BackingField<moryFailure.<elapsedTime>5__3> pointerClickHandler; // 0x28
        public eshGeneration>k__BackingField<moryFailure.t> initializePotentialDrag; // 0x30
        public eshGeneration>k__BackingField<moryFailure.vasUpdate> beginDragHandler; // 0x38
        public eshGeneration>k__BackingField<moryFailure.nder> dragHandler; // 0x40
        public eshGeneration>k__BackingField<moryFailure.eValue> endDragHandler; // 0x48
        public eshGeneration>k__BackingField<moryFailure.ement> dropHandler; // 0x50
        public eshGeneration>k__BackingField<moryFailure.ng> scrollHandler; // 0x58
        public eshGeneration>k__BackingField<moryFailure.CanvasUpdateRegistry> updateSelectedHandler; // 0x60
        public eshGeneration>k__BackingField<moryFailure.jectValidForUpdate> selectHandler; // 0x68
        public eshGeneration>k__BackingField<moryFailure.ate> deselectHandler; // 0x70
        public eshGeneration>k__BackingField<moryFailure.tems> moveHandler; // 0x78
        public eshGeneration>k__BackingField<moryFailure.unt> submitHandler; // 0x80
        public eshGeneration>k__BackingField<moryFailure.ist> cancelHandler; // 0x88
        public URA.woDigitYearMax<?> s_InternalTransformList; // 0x90

        // ── Methods ──
        public void ValidateEventData(){} // RVA: 0x7FFD4E2ADC40
        public void Execute(){} // RVA: 0x7FFD4E07D5A0 | overloaded x19
        public void get_pointerMoveHandler(){} // RVA: 0x7FFD550A0630
        public void get_pointerEnterHandler(){} // RVA: 0x7FFD550A0690
        public void get_pointerExitHandler(){} // RVA: 0x7FFD550A06F0
        public void get_pointerDownHandler(){} // RVA: 0x7FFD550A0750
        public void get_pointerUpHandler(){} // RVA: 0x7FFD550A07B0
        public void get_pointerClickHandler(){} // RVA: 0x7FFD550A0810
        public void get_initializePotentialDrag(){} // RVA: 0x7FFD550A0870
        public void get_beginDragHandler(){} // RVA: 0x7FFD550A08D0
        public void get_dragHandler(){} // RVA: 0x7FFD550A0930
        public void get_endDragHandler(){} // RVA: 0x7FFD550A0990
        public void get_dropHandler(){} // RVA: 0x7FFD550A09F0
        public void get_scrollHandler(){} // RVA: 0x7FFD550A0A50
        public void get_updateSelectedHandler(){} // RVA: 0x7FFD550A0AB0
        public void get_selectHandler(){} // RVA: 0x7FFD550A0B10
        public void get_deselectHandler(){} // RVA: 0x7FFD550A0B70
        public void get_moveHandler(){} // RVA: 0x7FFD550A0BD0
        public void get_submitHandler(){} // RVA: 0x7FFD550A0C30
        public void get_cancelHandler(){} // RVA: 0x7FFD550A0C90
        public void GetEventChain(){} // RVA: 0x7FFD550A0CF0
        public void ExecuteHierarchy(){} // RVA: 0x7FFD4E089600
        public void ShouldSendToComponent(){} // RVA: 0x7FFD4E079DE0
        public void GetEventList(){} // RVA: 0x7FFD4E090C80
        public void CanHandleEvent(){} // RVA: 0x7FFD4E079DE0
        public void GetEventHandler(){} // RVA: 0x7FFD4E078F80
        public void .cctor(){} // RVA: 0x7FFD550A0FA0
    }

    public class IBeginDragHandler
    {
        // ── Methods ──
        public void OnBeginDrag(){} // RVA: 0x7FFD4E090A40
    }

    public class ICancelHandler
    {
        // ── Methods ──
        public void OnCancel(){} // RVA: 0x7FFD4E090A40
    }

    public class IDeselectHandler
    {
        // ── Methods ──
        public void OnDeselect(){} // RVA: 0x7FFD4E090A40
    }

    public class IDragHandler
    {
        // ── Methods ──
        public void OnDrag(){} // RVA: 0x7FFD4E090A40
    }

    public class IDropHandler
    {
        // ── Methods ──
        public void OnDrop(){} // RVA: 0x7FFD4E090A40
    }

    public class IEndDragHandler
    {
        // ── Methods ──
        public void OnEndDrag(){} // RVA: 0x7FFD4E090A40
    }

    public class IEventSystemHandler
    {
    }

    public class IInitializePotentialDragHandler
    {
        // ── Methods ──
        public void OnInitializePotentialDrag(){} // RVA: 0x7FFD4E090A40
    }

    public class IMoveHandler
    {
        // ── Methods ──
        public void OnMove(){} // RVA: 0x7FFD4E090A40
    }

    public class IPointerClickHandler
    {
        // ── Methods ──
        public void OnPointerClick(){} // RVA: 0x7FFD4E090A40
    }

    public class IPointerDownHandler
    {
        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x7FFD4E090A40
    }

    public class IPointerEnterHandler
    {
        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x7FFD4E090A40
    }

    public class IPointerExitHandler
    {
        // ── Methods ──
        public void OnPointerExit(){} // RVA: 0x7FFD4E090A40
    }

    public class IPointerMoveHandler
    {
        // ── Methods ──
        public void OnPointerMove(){} // RVA: 0x7FFD4E090A40
    }

    public class IPointerUpHandler
    {
        // ── Methods ──
        public void OnPointerUp(){} // RVA: 0x7FFD4E090A40
    }

    public class IScrollHandler
    {
        // ── Methods ──
        public void OnScroll(){} // RVA: 0x7FFD4E090A40
    }

    public class ISelectHandler
    {
        // ── Methods ──
        public void OnSelect(){} // RVA: 0x7FFD4E090A40
    }

    public class ISubmitHandler
    {
        // ── Methods ──
        public void OnSubmit(){} // RVA: 0x7FFD4E090A40
    }

    public class IUpdateSelectedHandler
    {
        // ── Methods ──
        public void OnUpdateSelected(){} // RVA: 0x7FFD4E090A40
    }

    public class OVRInputModule : PointerInputModule
    {
        public object inputMode; // 0x68
        public t_R allowActivationOnMobileDevice; // 0x70
        public object inputActionsPerSecond; // 0x78
        public Flag horizontalAxis; // 0x7C
        public bool verticalAxis; // 0x80
        public bool submitButton; // 0x81
        public float cancelButton; // 0x84
        public bool useSwipeScroll; // 0x88
        public float swipeDragThreshold; // 0x8C
        public float swipeDragScale; // 0x90
        public bool InvertSwipeXAxis; // 0x94
        public gTransformRawPose activeGraphicRaycaster; // 0x98
        public float angleDragThreshold; // 0xA0
        public float m_SpherecastRadius; // 0xA4
        public float m_NextAction; // 0xA8
        public tionX m_LastMousePosition; // 0xAC
        public tionX m_MousePosition; // 0xB4
        public string m_HorizontalAxis; // 0xC0
        public string m_VerticalAxis; // 0xC8
        public string m_SubmitButton; // 0xD0
        public string m_CancelButton; // 0xD8
        public float m_InputActionsPerSecond; // 0xE0
        public bool m_AllowActivationOnMobileDevice; // 0xE4
        public URA.DateTime<int,moryFailure.onTransition_WaitingForExternalLaunch> m_VRRayPointerData; // 0xE8
        public evicePaired m_MouseState; // 0xF0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DA97A0
        public void get_inputMode(){} // RVA: 0x7FFD4E919180
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x7FFD53CE0AF0
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x7FFD53DA9B20
        public void get_inputActionsPerSecond(){} // RVA: 0x7FFD4E7F0800
        public void set_inputActionsPerSecond(){} // RVA: 0x7FFD4E7EAE10
        public void get_horizontalAxis(){} // RVA: 0x7FFD4E3AC120
        public void set_horizontalAxis(){} // RVA: 0x7FFD4E3AC130
        public void get_verticalAxis(){} // RVA: 0x7FFD4E499460
        public void set_verticalAxis(){} // RVA: 0x7FFD4E499470
        public void get_submitButton(){} // RVA: 0x7FFD4E45E100
        public void set_submitButton(){} // RVA: 0x7FFD4E45E110
        public void get_cancelButton(){} // RVA: 0x7FFD4E960F70
        public void set_cancelButton(){} // RVA: 0x7FFD4E3C28A0
        public void UpdateModule(){} // RVA: 0x7FFD53DA9B30
        public void IsModuleSupported(){} // RVA: 0x7FFD53DA9BD0
        public void ShouldActivateModule(){} // RVA: 0x7FFD53DA9C30
        public void ActivateModule(){} // RVA: 0x7FFD53DA9E70
        public void DeactivateModule(){} // RVA: 0x7FFD53DAA070
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x7FFD53DAA080
        public void AllowMoveEventProcessing(){} // RVA: 0x7FFD53DAA310
        public void GetRawMoveVector(){} // RVA: 0x7FFD53DAA3F0
        public void SendMoveEventToSelectedObject(){} // RVA: 0x7FFD53DAA5D0
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x7FFD53DAA810
        public void ProcessMousePress(){} // RVA: 0x7FFD53DAA9A0
        public void ProcessMouseEvent(){} // RVA: 0x7FFD53DAB600
        public void Process(){} // RVA: 0x7FFD53DABA90
        public void UseMouse(){} // RVA: 0x7FFD53DABC90
        public void CopyFromTo(){} // RVA: 0x7FFD53DABEE0 | overloaded x2
        public void GetPointerData(){} // RVA: 0x7FFD53DAC050
        public void ClearSelection(){} // RVA: 0x7FFD53DAC1B0
        public void GetRectTransformNormal(){} // RVA: 0x7FFD53DAC660
        public void GetGazePointerData(){} // RVA: 0x7FFD53DAC8C0
        public void GetCanvasPointerData(){} // RVA: 0x7FFD53DAD8B0
        public void ShouldStartDrag(){} // RVA: 0x7FFD53DAE190
        public void IsPointerMoving(){} // RVA: 0x7FFD53DAE550
        public void SwipeAdjustedPosition(){} // RVA: 0x7FFD4F2B2FB0
        public void ProcessDrag(){} // RVA: 0x7FFD53DAE5F0
        public void GetGazeButtonState(){} // RVA: 0x7FFD53DAEAB0
        public void GetExtraScrollDelta(){} // RVA: 0x7FFD53DAECA0
    }

    public class OVRPhysicsRaycaster : BaseRaycaster
    {
        public int eventCamera;
        public object depth; // 0x28
        public int sortOrderPriority; // 0x2C

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4EF384B0
        public void get_eventCamera(){} // RVA: 0x7FFD53DAEDA0
        public void get_depth(){} // RVA: 0x7FFD53DAEE10
        public void get_sortOrderPriority(){} // RVA: 0x7FFD4F0A91D0
        public void get_finalEventMask(){} // RVA: 0x7FFD53DAEF70
        public void get_eventMask(){} // RVA: 0x7FFD4E70C4C0
        public void set_eventMask(){} // RVA: 0x7FFD4EABA6E0
        public void Raycast(){} // RVA: 0x7FFD53DAF0D0
        public void Spherecast(){} // RVA: 0x7FFD53DAF840
        public void GetScreenPos(){} // RVA: 0x7FFD53DAFFD0
    }

    public class OVRPointerEventData : PointerEventData
    {
        public ed worldSpaceRay; // 0x180
        public tionX swipeStart; // 0x198

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD53DB0190
        public void ToString(){} // RVA: 0x7FFD53DB01A0
    }

    public class Physics2DRaycaster : PhysicsRaycaster
    {
        public Rate[] m_Hits; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F689B50
        public void Raycast(){} // RVA: 0x7FFD550ABCE0
    }

    public class PhysicsRaycaster : BaseRaycaster
    {
        public int eventCamera;
        public ÌÎÌÏÍÏÌÏÌÌÌÌÏÌÌÌÌÎÎÎÍ depth; // 0x28
        public object finalEventMask; // 0x30
        public int eventMask; // 0x34
        public int maxRayIntersections; // 0x38
        public ColorScaleAndOffset[] m_Hits; // 0x40

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4F689B50
        public void get_eventCamera(){} // RVA: 0x7FFD550AC790
        public void get_depth(){} // RVA: 0x7FFD550AC9B0
        public void get_finalEventMask(){} // RVA: 0x7FFD550ACB10
        public void get_eventMask(){} // RVA: 0x7FFD4E39CCD0
        public void set_eventMask(){} // RVA: 0x7FFD4E39CCE0
        public void get_maxRayIntersections(){} // RVA: 0x7FFD4EEFEDC0
        public void set_maxRayIntersections(){} // RVA: 0x7FFD4F58A6E0
        public void ComputeRayAndDistance(){} // RVA: 0x7FFD550ACC70
        public void Raycast(){} // RVA: 0x7FFD550AD100
    }

    public class PointerEventData : BaseEventData
    {
        public BuffersImpl pointerEnter; // 0x20
        public BuffersImpl lastPress; // 0x28
        public BuffersImpl rawPointerPress; // 0x30
        public BuffersImpl pointerDrag; // 0x38
        public BuffersImpl pointerClick; // 0x40
        public BuffersImpl pointerCurrentRaycast; // 0x48
        public moryFailure.priteMesh pointerPressRaycast; // 0x50
        public moryFailure.priteMesh eligibleForClick; // 0xA0
        public URA.woDigitYearMax<BuffersImpl> displayIndex; // 0xF0
        public bool pointerId; // 0xF8
        public int position; // 0xFC
        public int delta; // 0x100
        public tionX pressPosition; // 0x104
        public tionX worldPosition; // 0x10C
        public tionX worldNormal; // 0x114
        public amut clickTime; // 0x11C
        public amut clickCount; // 0x128
        public float scrollDelta; // 0x134
        public int useDragThreshold; // 0x138
        public tionX dragging; // 0x13C
        public bool button; // 0x144
        public bool pressure; // 0x145
        public ighlightedTrigger tangentialPressure; // 0x148
        public float altitudeAngle; // 0x14C
        public float azimuthAngle; // 0x150
        public float twist; // 0x154
        public float tilt; // 0x158
        public float penStatus; // 0x15C
        public tionX radius; // 0x160
        public aycast.PopulateRaycastCommand radiusVariance; // 0x168
        public tionX fullyExited; // 0x16C
        public tionX reentered; // 0x174
        public bool enterEventCamera; // 0x17C
        public bool pressEventCamera; // 0x17D

        // ── Methods ──
        public void get_pointerEnter(){} // RVA: 0x7FFD4E36F0C0
        public void set_pointerEnter(){} // RVA: 0x7FFD4E36F0D0
        public void get_lastPress(){} // RVA: 0x7FFD4E5F95E0
        public void set_lastPress(){} // RVA: 0x7FFD4E36F890
        public void get_rawPointerPress(){} // RVA: 0x7FFD4E5F0140
        public void set_rawPointerPress(){} // RVA: 0x7FFD4E5F0C20
        public void get_pointerDrag(){} // RVA: 0x7FFD4E3BE740
        public void set_pointerDrag(){} // RVA: 0x7FFD4E369200
        public void get_pointerClick(){} // RVA: 0x7FFD4E3BC730
        public void set_pointerClick(){} // RVA: 0x7FFD4E3BC740
        public void get_pointerCurrentRaycast(){} // RVA: 0x7FFD51F34810
        public void set_pointerCurrentRaycast(){} // RVA: 0x7FFD5509A790
        public void get_pointerPressRaycast(){} // RVA: 0x7FFD5509A810
        public void set_pointerPressRaycast(){} // RVA: 0x7FFD5509A850
        public void get_eligibleForClick(){} // RVA: 0x7FFD4F0AE090
        public void set_eligibleForClick(){} // RVA: 0x7FFD54BCF8F0
        public void get_displayIndex(){} // RVA: 0x7FFD4F0ABB20
        public void set_displayIndex(){} // RVA: 0x7FFD54BCF870
        public void get_pointerId(){} // RVA: 0x7FFD540268C0
        public void set_pointerId(){} // RVA: 0x7FFD5509A8E0
        public void get_position(){} // RVA: 0x7FFD5509A8F0
        public void set_position(){} // RVA: 0x7FFD5509A910
        public void get_delta(){} // RVA: 0x7FFD5509A920
        public void set_delta(){} // RVA: 0x7FFD5509A940
        public void get_pressPosition(){} // RVA: 0x7FFD5509A950
        public void set_pressPosition(){} // RVA: 0x7FFD5509A970
        public void get_worldPosition(){} // RVA: 0x7FFD5509A980
        public void set_worldPosition(){} // RVA: 0x7FFD5509A9A0
        public void get_worldNormal(){} // RVA: 0x7FFD5509A9C0
        public void set_worldNormal(){} // RVA: 0x7FFD5509A9E0
        public void get_clickTime(){} // RVA: 0x7FFD5509AA00
        public void set_clickTime(){} // RVA: 0x7FFD5509AA10
        public void get_clickCount(){} // RVA: 0x7FFD4F0AEC30
        public void set_clickCount(){} // RVA: 0x7FFD53CE7220
        public void get_scrollDelta(){} // RVA: 0x7FFD53E31730
        public void set_scrollDelta(){} // RVA: 0x7FFD53E31750
        public void get_useDragThreshold(){} // RVA: 0x7FFD4E7D8570
        public void set_useDragThreshold(){} // RVA: 0x7FFD5509AA20
        public void get_dragging(){} // RVA: 0x7FFD5509AA30
        public void set_dragging(){} // RVA: 0x7FFD5509AA40
        public void get_button(){} // RVA: 0x7FFD4F4B0620
        public void set_button(){} // RVA: 0x7FFD4F4BEA20
        public void get_pressure(){} // RVA: 0x7FFD5509AA50
        public void set_pressure(){} // RVA: 0x7FFD5509AA60
        public void get_tangentialPressure(){} // RVA: 0x7FFD5509AA70
        public void set_tangentialPressure(){} // RVA: 0x7FFD5509AA80
        public void get_altitudeAngle(){} // RVA: 0x7FFD5509AA90
        public void set_altitudeAngle(){} // RVA: 0x7FFD5509AAA0
        public void get_azimuthAngle(){} // RVA: 0x7FFD5509AAB0
        public void set_azimuthAngle(){} // RVA: 0x7FFD5509AAC0
        public void get_twist(){} // RVA: 0x7FFD54B876F0
        public void set_twist(){} // RVA: 0x7FFD4F0A8D30
        public void get_tilt(){} // RVA: 0x7FFD5509AAD0
        public void set_tilt(){} // RVA: 0x7FFD5509AAF0
        public void get_penStatus(){} // RVA: 0x7FFD5509AB00
        public void set_penStatus(){} // RVA: 0x7FFD5509AB10
        public void get_radius(){} // RVA: 0x7FFD5509AB20
        public void set_radius(){} // RVA: 0x7FFD5509AB40
        public void get_radiusVariance(){} // RVA: 0x7FFD5509AB50
        public void set_radiusVariance(){} // RVA: 0x7FFD5509AB70
        public void get_fullyExited(){} // RVA: 0x7FFD5509AB80
        public void set_fullyExited(){} // RVA: 0x7FFD5509AB90
        public void get_reentered(){} // RVA: 0x7FFD4E3D1510
        public void set_reentered(){} // RVA: 0x7FFD4E3D1520
        public void .ctor(){} // RVA: 0x7FFD5509ABA0
        public void IsPointerMoving(){} // RVA: 0x7FFD5509AEC0
        public void IsScrolling(){} // RVA: 0x7FFD5509AEF0
        public void get_enterEventCamera(){} // RVA: 0x7FFD5509AF20
        public void get_pressEventCamera(){} // RVA: 0x7FFD5509B040
        public void get_pointerPress(){} // RVA: 0x7FFD4E36F130
        public void set_pointerPress(){} // RVA: 0x7FFD5509B170
        public void ToString(){} // RVA: 0x7FFD5509B340
    }

    public class PointerInputModule : BaseInputModule
    {
        public int kMouseLeftId;
        public int kMouseRightId;
        public int kMouseMiddleId;
        public int kFakeTouchesId;
        public URA.DateTime<int,moryFailure.String,Valve.Newtonsoft.Json.Linq.JToken>>.IsReadOnly> m_PointerData; // 0x58
        public evicePaired m_MouseState; // 0x60

        // ── Methods ──
        public void GetPointerData(){} // RVA: 0x7FFD550A4050
        public void RemovePointerData(){} // RVA: 0x7FFD550A41B0
        public void GetTouchPointerEventData(){} // RVA: 0x7FFD550A4220
        public void CopyFromTo(){} // RVA: 0x7FFD550A46C0
        public void StateForMouseButton(){} // RVA: 0x7FFD550A48C0
        public void GetMousePointerEventData(){} // RVA: 0x7FFD550A4980 | overloaded x2
        public void GetLastPointerEventData(){} // RVA: 0x7FFD550A5240
        public void ShouldStartDrag(){} // RVA: 0x7FFD550A5270
        public void ProcessMove(){} // RVA: 0x7FFD550A52C0
        public void ProcessDrag(){} // RVA: 0x7FFD550A5350
        public void IsPointerOverGameObject(){} // RVA: 0x7FFD550A5700
        public void ClearSelection(){} // RVA: 0x7FFD550A5810
        public void ToString(){} // RVA: 0x7FFD550A5AA0
        public void DeselectIfSelectionChanged(){} // RVA: 0x7FFD550A5DF0
        public void .ctor(){} // RVA: 0x7FFD550A5F90
    }

    public class RaycastResult : ValueType
    {
        public BuffersImpl gameObject; // 0x10
        public moryFailure.in isValid; // 0x18
        public float distance; // 0x20
        public float index; // 0x24
        public int depth; // 0x28
        public int sortingGroupID; // 0x2C
        public int sortingGroupOrder; // 0x30
        public int sortingLayer; // 0x34
        public int sortingOrder; // 0x38
        public amut worldPosition; // 0x3C
        public amut worldNormal; // 0x48
        public tionX screenPosition; // 0x54
        public int displayIndex; // 0x5C

        // ── Methods ──
        public void get_gameObject(){} // RVA: 0x7FFD4EEF9F60
        public void set_gameObject(){} // RVA: 0x7FFD4ECFFE40
        public void get_isValid(){} // RVA: 0x7FFD550AD700
        public void Clear(){} // RVA: 0x7FFD550AD870
        public void ToString(){} // RVA: 0x7FFD550ADA00
    }

    public class RaycasterManager : Object
    {
        public URA.woDigitYearMax<moryFailure.in> s_Raycasters;

        // ── Methods ──
        public void AddRaycaster(){} // RVA: 0x7FFD550AB2A0
        public void GetRaycasters(){} // RVA: 0x7FFD550AB3C0
        public void RemoveRaycasters(){} // RVA: 0x7FFD550AB420
        public void .cctor(){} // RVA: 0x7FFD550AB500
    }

    public class StandaloneInputModule : PointerInputModule
    {
        public float inputMode; // 0x68
        public tionX allowActivationOnMobileDevice; // 0x6C
        public int forceModuleActive; // 0x74
        public tionX inputActionsPerSecond; // 0x78
        public tionX repeatDelay; // 0x80
        public BuffersImpl horizontalAxis; // 0x88
        public moryFailure.String,Valve.Newtonsoft.Json.Linq.JToken>>.IsReadOnly verticalAxis; // 0x90
        public float submitButton;
        public string cancelButton; // 0x98
        public string m_VerticalAxis; // 0xA0
        public string m_SubmitButton; // 0xA8
        public string m_CancelButton; // 0xB0
        public float m_InputActionsPerSecond; // 0xB8
        public float m_RepeatDelay; // 0xBC
        public bool m_ForceModuleActive; // 0xC0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD550A6610
        public void get_inputMode(){} // RVA: 0x7FFD4E919180
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x7FFD4E3624C0
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x7FFD4E3624D0
        public void get_forceModuleActive(){} // RVA: 0x7FFD4E3624C0
        public void set_forceModuleActive(){} // RVA: 0x7FFD4E3624D0
        public void get_inputActionsPerSecond(){} // RVA: 0x7FFD4FBF32C0
        public void set_inputActionsPerSecond(){} // RVA: 0x7FFD4FBF32B0
        public void get_repeatDelay(){} // RVA: 0x7FFD4FBF32A0
        public void set_repeatDelay(){} // RVA: 0x7FFD4FBF3290
        public void get_horizontalAxis(){} // RVA: 0x7FFD4E96DFB0
        public void set_horizontalAxis(){} // RVA: 0x7FFD4E96E3C0
        public void get_verticalAxis(){} // RVA: 0x7FFD4E963900
        public void set_verticalAxis(){} // RVA: 0x7FFD4E96E420
        public void get_submitButton(){} // RVA: 0x7FFD4E96B1A0
        public void set_submitButton(){} // RVA: 0x7FFD4E76B370
        public void get_cancelButton(){} // RVA: 0x7FFD4E3AC040
        public void set_cancelButton(){} // RVA: 0x7FFD4E3AC050
        public void ShouldIgnoreEventsOnNoFocus(){} // RVA: 0x7FFD4E426850
        public void UpdateModule(){} // RVA: 0x7FFD550A6820
        public void ReleaseMouse(){} // RVA: 0x7FFD550A6A20
        public void ShouldActivateModule(){} // RVA: 0x7FFD550A7070
        public void ActivateModule(){} // RVA: 0x7FFD550A7280
        public void DeactivateModule(){} // RVA: 0x7FFD4F7283D0
        public void Process(){} // RVA: 0x7FFD550A7450
        public void ProcessTouchEvents(){} // RVA: 0x7FFD550A7670
        public void ProcessTouchPress(){} // RVA: 0x7FFD550A7880
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x7FFD550A8540
        public void GetRawMoveVector(){} // RVA: 0x7FFD550A8790
        public void SendMoveEventToSelectedObject(){} // RVA: 0x7FFD550A8900
        public void ProcessMouseEvent(){} // RVA: 0x7FFD550A8C80 | overloaded x2
        public void ForceAutoSelect(){} // RVA: 0x7FFD4E341320
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x7FFD550A8F50
        public void ProcessMousePress(){} // RVA: 0x7FFD550A90E0
        public void GetCurrentFocusedGameObject(){} // RVA: 0x7FFD4E380010
    }

    public class TouchInputModule : PointerInputModule
    {
        public tionX allowActivationOnStandalone; // 0x68
        public tionX forceModuleActive; // 0x70
        public moryFailure.String,Valve.Newtonsoft.Json.Linq.JToken>>.IsReadOnly m_InputPointerEvent; // 0x78
        public bool m_ForceModuleActive; // 0x80

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD550A9830
        public void get_allowActivationOnStandalone(){} // RVA: 0x7FFD4E55E620
        public void set_allowActivationOnStandalone(){} // RVA: 0x7FFD4E55D3B0
        public void get_forceModuleActive(){} // RVA: 0x7FFD4E55E620
        public void set_forceModuleActive(){} // RVA: 0x7FFD4E55D3B0
        public void UpdateModule(){} // RVA: 0x7FFD550A9840
        public void IsModuleSupported(){} // RVA: 0x7FFD550A9A60
        public void ShouldActivateModule(){} // RVA: 0x7FFD550A9AB0
        public void UseFakeInput(){} // RVA: 0x7FFD550A9BB0
        public void Process(){} // RVA: 0x7FFD550A9BF0
        public void FakeTouches(){} // RVA: 0x7FFD550A9F60
        public void ProcessTouchEvents(){} // RVA: 0x7FFD550AA0D0
        public void ProcessTouchPress(){} // RVA: 0x7FFD550AA2B0
        public void DeactivateModule(){} // RVA: 0x7FFD4F7283D0
        public void ToString(){} // RVA: 0x7FFD550AAED0
    }

    public class UIBehaviour : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7FFD4E341310
        public void OnEnable(){} // RVA: 0x7FFD4E341310
        public void Start(){} // RVA: 0x7FFD4E341310
        public void OnDisable(){} // RVA: 0x7FFD4E341310
        public void OnDestroy(){} // RVA: 0x7FFD4E341310
        public void IsActive(){} // RVA: 0x7FFD54CDACF0
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7FFD4E341310
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7FFD4E341310
        public void OnTransformParentChanged(){} // RVA: 0x7FFD4E341310
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7FFD4E341310
        public void OnCanvasGroupChanged(){} // RVA: 0x7FFD4E341310
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7FFD4E341310
        public void IsDestroyed(){} // RVA: 0x7FFD550ADF40
        public void .ctor(){} // RVA: 0x7FFD4E341D50
    }

}