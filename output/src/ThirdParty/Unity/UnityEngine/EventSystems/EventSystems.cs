// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.EventSystems
// Classes: 51
// Methods: 564

namespace ThirdParty.Unity.UnityEngine.EventSystems
{
    public class AbstractEventData : Object
    {
        public object m_Used;

        // ── Methods ──
        public void Reset(){} // RVA: 0xF48510
        public void Use(){} // RVA: 0xF482F0
        public void get_used(){} // RVA: 0xC120A0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class AxisEventData : BaseEventData
    {
        public object _moveVector;
        public object _moveDir;

        // ── Methods ──
        public void get_moveVector(){} // RVA: 0x13B3FB0
        public void set_moveVector(){} // RVA: 0x13B3F80
        public void get_moveDir(){} // RVA: 0x1065D50
        public void set_moveDir(){} // RVA: 0x13233D0
        public void .ctor(){} // RVA: 0x810FC60
    }

    public class BaseEventData : AbstractEventData
    {
        public object m_EventSystem;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xBA9BA0
        public void get_currentInputModule(){} // RVA: 0x6AE0B90
        public void get_selectedObject(){} // RVA: 0x6AE0BF0
        public void set_selectedObject(){} // RVA: 0x810FD00
    }

    public class BaseInput : UIBehaviour
    {
        // ── Methods ──
        public void get_compositionString(){} // RVA: 0x7CA80A0
        public void get_imeCompositionMode(){} // RVA: 0x7CA9A40
        public void set_imeCompositionMode(){} // RVA: 0x8117500
        public void get_compositionCursorPos(){} // RVA: 0x8117550
        public void set_compositionCursorPos(){} // RVA: 0x81175B0
        public void get_mousePresent(){} // RVA: 0x7CA82A0
        public void GetMouseButtonDown(){} // RVA: 0x7CA8300
        public void GetMouseButtonUp(){} // RVA: 0x7CA8350
        public void GetMouseButton(){} // RVA: 0x7CA82B0
        public void get_mousePosition(){} // RVA: 0x8117600
        public void get_mouseScrollDelta(){} // RVA: 0x7CA83A0
        public void get_mouseScrollDeltaPerTick(){} // RVA: 0x1DF51C0
        public void get_touchSupported(){} // RVA: 0x1DDDD10
        public void get_touchCount(){} // RVA: 0x7CA81A0
        public void GetTouch(){} // RVA: 0x7CA81F0
        public void GetAxisRaw(){} // RVA: 0x7CA8100
        public void GetButtonDown(){} // RVA: 0xB618B0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class BaseInputModule : UIBehaviour
    {
        public object m_RaycastResultCache;
        public object m_SendPointerHoverToParent;
        public object m_AxisEventData;
        public object m_EventSystem;
        public object m_BaseEventData;
        public object m_InputOverride;
        public object m_DefaultInput;

        // ── Methods ──
        public void get_sendPointerHoverToParent(){} // RVA: 0xF73960
        public void set_sendPointerHoverToParent(){} // RVA: 0xF73A60
        public void get_input(){} // RVA: 0x8117670
        public void get_inputOverride(){} // RVA: 0xBBF8F0
        public void set_inputOverride(){} // RVA: 0xBBF900
        public void get_eventSystem(){} // RVA: 0xD05CA0
        public void OnEnable(){} // RVA: 0x8117A50
        public void OnDisable(){} // RVA: 0x8117AF0
        public void Process(){} // RVA: 0x894290
        public void FindFirstRaycast(){} // RVA: 0x8117B10
        public void DetermineMoveDirection(){} // RVA: 0x8117D50
        public void FindCommonRoot(){} // RVA: 0x8117DD0
        public void HandlePointerExitAndEnter(){} // RVA: 0x8118140
        public void GetAxisEventData(){} // RVA: 0x8119230
        public void GetBaseEventData(){} // RVA: 0x8119370
        public void IsPointerOverGameObject(){} // RVA: 0xB43320
        public void ShouldActivateModule(){} // RVA: 0x81194A0
        public void DeactivateModule(){} // RVA: 0xB43310
        public void ActivateModule(){} // RVA: 0xB43310
        public void UpdateModule(){} // RVA: 0xB43310
        public void IsModuleSupported(){} // RVA: 0xC2E4C0
        public void ConvertUIToolkitPointerId(){} // RVA: 0x8119560
        public void ConvertPointerEventScrollDeltaToTicks(){} // RVA: 0x8119600
        public void .ctor(){} // RVA: 0x8119660
    }

    public class BaseInputModule[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class BaseInput[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
    }

    public class BaseRaycaster : UIBehaviour
    {
        public object m_RootRaycaster;

        // ── Methods ──
        public void Raycast(){} // RVA: 0x8943B0
        public void get_eventCamera(){} // RVA: 0x87C0A0
        public void get_priority(){} // RVA: 0xDAC980
        public void get_sortOrderPriority(){} // RVA: 0x8120D70
        public void get_renderOrderPriority(){} // RVA: 0x8120D70
        public void get_rootRaycaster(){} // RVA: 0x8120D80
        public void ToString(){} // RVA: 0x8120EE0
        public void OnEnable(){} // RVA: 0x81211B0
        public void OnDisable(){} // RVA: 0x8121300
        public void OnCanvasHierarchyChanged(){} // RVA: 0x64D1270
        public void OnTransformParentChanged(){} // RVA: 0x64D1270
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class BaseRaycaster[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class EventSystem : UIBehaviour
    {
        public object m_SystemInputModules;
        public object m_CurrentInputModule;
        public object m_EventSystems;
        public object m_FirstSelected;
        public object m_sendNavigationEvents;
        public object m_DragThreshold;
        public object m_CurrentSelected;
        public object m_HasFocus;
        public object m_SelectionGuard;
        public object m_DummyData;
        public object s_RaycastComparer;
        public object s_UIToolkitOverride;
        public object m_Started;
        public object m_IsTrackingUIToolkitPanels;

        // ── Methods ──
        public void get_current(){} // RVA: 0x81113E0
        public void set_current(){} // RVA: 0x81114C0
        public void get_sendNavigationEvents(){} // RVA: 0xD16660
        public void set_sendNavigationEvents(){} // RVA: 0xD14C10
        public void get_pixelDragThreshold(){} // RVA: 0x114DAD0
        public void set_pixelDragThreshold(){} // RVA: 0x25671C0
        public void get_currentInputModule(){} // RVA: 0xB70160
        public void get_firstSelectedGameObject(){} // RVA: 0xD33E60
        public void set_firstSelectedGameObject(){} // RVA: 0xB708C0
        public void get_currentSelectedGameObject(){} // RVA: 0xBC1B30
        public void get_lastSelectedGameObject(){} // RVA: 0xDAC980
        public void get_isFocused(){} // RVA: 0xBFDA40
        public void .ctor(){} // RVA: 0x8111690
        public void UpdateModules(){} // RVA: 0x81117A0
        public void get_alreadySelecting(){} // RVA: 0x1C58C80
        public void SetSelectedGameObject(){} // RVA: 0x8111DD0
        public void get_baseEventDataCache(){} // RVA: 0x8111CD0
        public void RaycastComparer(){} // RVA: 0x8111EF0
        public void RaycastAll(){} // RVA: 0x8112620
        public void IsPointerOverGameObject(){} // RVA: 0x8112A60
        public void get_isUIToolkitActiveEventSystem(){} // RVA: 0x8112B70
        public void get_sendUIToolkitEvents(){} // RVA: 0x8112D90
        public void get_createUIToolkitPanelGameObjectsOnStart(){} // RVA: 0x8112E00
        public void SetUITookitEventSystemOverride(){} // RVA: 0x8112E70
        public void StartTrackingUIToolkitPanels(){} // RVA: 0x8113160
        public void StopTrackingUIToolkitPanels(){} // RVA: 0x81135A0
        public void CreateUIToolkitPanelGameObject(){} // RVA: 0x81137A0
        public void Start(){} // RVA: 0x8113CC0
        public void OnEnable(){} // RVA: 0x8113CD0
        public void OnDisable(){} // RVA: 0x8113E40
        public void TickModules(){} // RVA: 0x8114020
        public void OnApplicationFocus(){} // RVA: 0x81141E0
        public void Update(){} // RVA: 0x81141F0
        public void ChangeEventModule(){} // RVA: 0x81146D0
        public void ToString(){} // RVA: 0x81149A0
        public void .cctor(){} // RVA: 0x8114BB0
    }

    public class EventSystem[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class EventTrigger : MonoBehaviour
    {
        public object m_Delegates;

        // ── Methods ──
        public void get_delegates(){} // RVA: 0x8114ED0
        public void set_delegates(){} // RVA: 0xB70100
        public void .ctor(){} // RVA: 0xB43D60
        public void get_triggers(){} // RVA: 0x8114EE0
        public void set_triggers(){} // RVA: 0xB70100
        public void Execute(){} // RVA: 0x8114FA0
        public void OnPointerEnter(){} // RVA: 0x81150C0
        public void OnPointerExit(){} // RVA: 0x81150D0
        public void OnDrag(){} // RVA: 0x81150E0
        public void OnDrop(){} // RVA: 0x81150F0
        public void OnPointerDown(){} // RVA: 0x8115100
        public void OnPointerUp(){} // RVA: 0x8115110
        public void OnPointerClick(){} // RVA: 0x8115120
        public void OnSelect(){} // RVA: 0x8115130
        public void OnDeselect(){} // RVA: 0x8115140
        public void OnScroll(){} // RVA: 0x8115150
        public void OnMove(){} // RVA: 0x8115160
        public void OnUpdateSelected(){} // RVA: 0x8115170
        public void OnInitializePotentialDrag(){} // RVA: 0x8115180
        public void OnBeginDrag(){} // RVA: 0x8115190
        public void OnEndDrag(){} // RVA: 0x81151A0
        public void OnSubmit(){} // RVA: 0x81151B0
        public void OnCancel(){} // RVA: 0x81151C0
    }

    public class ExecuteEvents : Object
    {
        public object s_PointerMoveHandler;
        public object s_PointerEnterHandler;
        public object s_PointerExitHandler;
        public object s_PointerDownHandler;
        public object s_PointerUpHandler;
        public object s_PointerClickHandler;
        public object s_InitializePotentialDragHandler;
        public object s_BeginDragHandler;
        public object s_DragHandler;
        public object s_EndDragHandler;
        public object s_DropHandler;
        public object s_ScrollHandler;
        public object s_UpdateSelectedHandler;
        public object s_SelectHandler;
        public object s_DeselectHandler;
        public object s_MoveHandler;
        public object s_SubmitHandler;
        public object s_CancelHandler;
        public object s_InternalTransformList;

        // ── Methods ──
        public void GetEventList(){} // RVA: 0x8945C0
        public void ShouldSendToComponent(){} // RVA: 0x87D390
        public void Execute(){} // RVA: 0x30C1470
        public void ExecuteHierarchy(){} // RVA: 0x88CCC0
        public void GetEventHandler(){} // RVA: 0x87C5C0
        public void ValidateEventData(){} // RVA: 0xA94080
        public void get_pointerMoveHandler(){} // RVA: 0x8115D70
        public void get_pointerEnterHandler(){} // RVA: 0x8115DD0
        public void get_pointerExitHandler(){} // RVA: 0x8115E30
        public void get_pointerDownHandler(){} // RVA: 0x8115E90
        public void get_pointerUpHandler(){} // RVA: 0x8115EF0
        public void get_pointerClickHandler(){} // RVA: 0x8115F50
        public void get_initializePotentialDrag(){} // RVA: 0x8115FB0
        public void get_beginDragHandler(){} // RVA: 0x8116010
        public void get_dragHandler(){} // RVA: 0x8116070
        public void get_endDragHandler(){} // RVA: 0x81160D0
        public void get_dropHandler(){} // RVA: 0x8116130
        public void get_scrollHandler(){} // RVA: 0x8116190
        public void get_updateSelectedHandler(){} // RVA: 0x81161F0
        public void get_selectHandler(){} // RVA: 0x8116250
        public void get_deselectHandler(){} // RVA: 0x81162B0
        public void get_moveHandler(){} // RVA: 0x8116310
        public void get_submitHandler(){} // RVA: 0x8116370
        public void get_cancelHandler(){} // RVA: 0x81163D0
        public void GetEventChain(){} // RVA: 0x8116430
        public void CanHandleEvent(){} // RVA: 0x87D390
        public void .cctor(){} // RVA: 0x8116710
    }

    public class IBeginDragHandler
    {
        // ── Methods ──
        public void OnBeginDrag(){} // RVA: 0x894320
    }

    public class ICancelHandler
    {
        // ── Methods ──
        public void OnCancel(){} // RVA: 0x894320
    }

    public class IDeselectHandler
    {
        // ── Methods ──
        public void OnDeselect(){} // RVA: 0x894320
    }

    public class IDragHandler
    {
        // ── Methods ──
        public void OnDrag(){} // RVA: 0x894320
    }

    public class IDragHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IDropHandler
    {
        // ── Methods ──
        public void OnDrop(){} // RVA: 0x894320
    }

    public class IEndDragHandler
    {
        // ── Methods ──
        public void OnEndDrag(){} // RVA: 0x894320
    }

    public class IEventSystemHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IInitializePotentialDragHandler
    {
        // ── Methods ──
        public void OnInitializePotentialDrag(){} // RVA: 0x894320
    }

    public class IMoveHandler
    {
        // ── Methods ──
        public void OnMove(){} // RVA: 0x894320
    }

    public class IPointerClickHandler
    {
        // ── Methods ──
        public void OnPointerClick(){} // RVA: 0x894320
    }

    public class IPointerClickHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IPointerDownHandler
    {
        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x894320
    }

    public class IPointerDownHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class IPointerEnterHandler
    {
        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x894320
    }

    public class IPointerExitHandler
    {
        // ── Methods ──
        public void OnPointerExit(){} // RVA: 0x894320
    }

    public class IPointerMoveHandler
    {
        // ── Methods ──
        public void OnPointerMove(){} // RVA: 0x894320
    }

    public class IPointerUpHandler
    {
        // ── Methods ──
        public void OnPointerUp(){} // RVA: 0x894320
    }

    public class IScrollHandler
    {
        // ── Methods ──
        public void OnScroll(){} // RVA: 0x894320
    }

    public class IScrollHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class ISelectHandler
    {
        // ── Methods ──
        public void OnSelect(){} // RVA: 0x894320
    }

    public class ISubmitHandler
    {
        // ── Methods ──
        public void OnSubmit(){} // RVA: 0x894320
    }

    public class IUpdateSelectedHandler
    {
        // ── Methods ──
        public void OnUpdateSelected(){} // RVA: 0x894320
    }

    public class OVRInputModule : PointerInputModule
    {
        public object rayTransform;
        public object m_Cursor;
        public object joyPadClickButton;
        public object gazeClickKey;
        public object performSphereCastForGazepointer;
        public object useRightStickScroll;
        public object rightStickDeadZone;
        public object useSwipeScroll;
        public object swipeDragThreshold;
        public object swipeDragScale;
        public object InvertSwipeXAxis;
        public object activeGraphicRaycaster;
        public object angleDragThreshold;
        public object m_SpherecastRadius;
        public object m_NextAction;
        public object m_LastMousePosition;
        public object m_MousePosition;
        public object m_HorizontalAxis;
        public object m_VerticalAxis;
        public object m_SubmitButton;
        public object m_CancelButton;
        public object m_InputActionsPerSecond;
        public object m_AllowActivationOnMobileDevice;
        public object m_VRRayPointerData;
        public object m_MouseState;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C60C50
        public void get_inputMode(){} // RVA: 0xDAC980
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x6B9C350
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x6C60FD0
        public void get_inputActionsPerSecond(){} // RVA: 0x6C60FE0
        public void set_inputActionsPerSecond(){} // RVA: 0x6C60FF0
        public void get_horizontalAxis(){} // RVA: 0xBAE420
        public void set_horizontalAxis(){} // RVA: 0xBAE430
        public void get_verticalAxis(){} // RVA: 0xCA4D80
        public void set_verticalAxis(){} // RVA: 0xCA4D90
        public void get_submitButton(){} // RVA: 0xC68EB0
        public void set_submitButton(){} // RVA: 0xC68EC0
        public void get_cancelButton(){} // RVA: 0x135D730
        public void set_cancelButton(){} // RVA: 0xBC5AD0
        public void UpdateModule(){} // RVA: 0x6C61000
        public void IsModuleSupported(){} // RVA: 0x6C61090
        public void ShouldActivateModule(){} // RVA: 0x6C610B0
        public void ActivateModule(){} // RVA: 0x6C61200
        public void DeactivateModule(){} // RVA: 0x6C61400
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x6C61410
        public void AllowMoveEventProcessing(){} // RVA: 0x6C61620
        public void GetRawMoveVector(){} // RVA: 0x6C61680
        public void SendMoveEventToSelectedObject(){} // RVA: 0x6C61760
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x6C61A00
        public void ProcessMousePress(){} // RVA: 0x6C61B90
        public void ProcessMouseEvent(){} // RVA: 0x6C627E0
        public void Process(){} // RVA: 0x6C62CA0
        public void UseMouse(){} // RVA: 0x6C62EA0
        public void CopyFromTo(){} // RVA: 0x6C630F0
        public void GetPointerData(){} // RVA: 0x6C63260
        public void ClearSelection(){} // RVA: 0x6C633E0
        public void GetRectTransformNormal(){} // RVA: 0x6C638B0
        public void GetGazePointerData(){} // RVA: 0x6C63B10
        public void GetCanvasPointerData(){} // RVA: 0x6C64BC0
        public void ShouldStartDrag(){} // RVA: 0x6C65480
        public void IsPointerMoving(){} // RVA: 0x6C65850
        public void SwipeAdjustedPosition(){} // RVA: 0x1CB3B00
        public void ProcessDrag(){} // RVA: 0x6C658F0
        public void GetGazeButtonState(){} // RVA: 0x6C65DB0
        public void GetExtraScrollDelta(){} // RVA: 0x6C65FA0
    }

    public class OVRPhysicsRaycaster : BaseRaycaster
    {
        public object kNoEventMaskSet;
        public object m_EventMask;
        public object sortOrder;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x192B9B0
        public void get_eventCamera(){} // RVA: 0x6C660A0
        public void get_depth(){} // RVA: 0x6C66110
        public void get_sortOrderPriority(){} // RVA: 0x1AE5AC0
        public void get_finalEventMask(){} // RVA: 0x6C66230
        public void get_eventMask(){} // RVA: 0x1065D50
        public void set_eventMask(){} // RVA: 0x13233D0
        public void Raycast(){} // RVA: 0x6C66360
        public void Spherecast(){} // RVA: 0x6C66AF0
        public void GetScreenPos(){} // RVA: 0x6C67290
    }

    public class OVRPointerEventData : PointerEventData
    {
        public object worldSpaceRay;
        public object swipeStart;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6C67490
        public void ToString(){} // RVA: 0x6C674A0
    }

    public class Physics2DRaycaster : PhysicsRaycaster
    {
        public object m_Hits;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2084DC0
        public void Raycast(){} // RVA: 0x8121410
    }

    public class PhysicsRaycaster : BaseRaycaster
    {
        public object kNoEventMaskSet;
        public object m_EventCamera;
        public object m_EventMask;
        public object m_MaxRayIntersections;
        public object m_LastMaxRayIntersections;
        public object m_Hits;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x2084DC0
        public void get_eventCamera(){} // RVA: 0x8121F00
        public void get_depth(){} // RVA: 0x81220F0
        public void get_finalEventMask(){} // RVA: 0x8122210
        public void get_eventMask(){} // RVA: 0xB9E080
        public void set_eventMask(){} // RVA: 0xB9E090
        public void get_maxRayIntersections(){} // RVA: 0xE9CE60
        public void set_maxRayIntersections(){} // RVA: 0xEA1260
        public void ComputeRayAndDistance(){} // RVA: 0x8122340
        public void Raycast(){} // RVA: 0x8122820
    }

    public class PointerEventData : BaseEventData
    {
        public object _pointerEnter;
        public object m_PointerPress;
        public object _lastPress;
        public object _rawPointerPress;
        public object _pointerDrag;
        public object _pointerClick;
        public object _pointerCurrentRaycast;
        public object _pointerPressRaycast;
        public object hovered;
        public object _eligibleForClick;
        public object _displayIndex;
        public object _pointerId;
        public object _position;
        public object _delta;
        public object _pressPosition;
        public object _worldPosition;
        public object _worldNormal;
        public object _clickTime;
        public object _clickCount;
        public object _scrollDelta;
        public object _useDragThreshold;
        public object _dragging;
        public object _button;
        public object _pressure;
        public object _tangentialPressure;
        public object _altitudeAngle;
        public object _azimuthAngle;
        public object _twist;
        public object _tilt;
        public object _penStatus;
        public object _radius;
        public object _radiusVariance;
        public object _fullyExited;
        public object _reentered;

        // ── Methods ──
        public void get_pointerEnter(){} // RVA: 0xB700F0
        public void set_pointerEnter(){} // RVA: 0xB70100
        public void get_lastPress(){} // RVA: 0xD33E60
        public void set_lastPress(){} // RVA: 0xB708C0
        public void get_rawPointerPress(){} // RVA: 0xD05CA0
        public void set_rawPointerPress(){} // RVA: 0xD09D70
        public void get_pointerDrag(){} // RVA: 0xBC1B30
        public void set_pointerDrag(){} // RVA: 0xB6A8C0
        public void get_pointerClick(){} // RVA: 0xBBF8F0
        public void set_pointerClick(){} // RVA: 0xBBF900
        public void get_pointerCurrentRaycast(){} // RVA: 0x4D15480
        public void set_pointerCurrentRaycast(){} // RVA: 0x810FD30
        public void get_pointerPressRaycast(){} // RVA: 0x810FDB0
        public void set_pointerPressRaycast(){} // RVA: 0x810FDF0
        public void get_eligibleForClick(){} // RVA: 0x1AE5AD0
        public void set_eligibleForClick(){} // RVA: 0x1AE3600
        public void get_displayIndex(){} // RVA: 0x25585C0
        public void set_displayIndex(){} // RVA: 0x7A7FE30
        public void get_pointerId(){} // RVA: 0x2643A30
        public void set_pointerId(){} // RVA: 0x2644F00
        public void get_position(){} // RVA: 0x810FE80
        public void set_position(){} // RVA: 0x810FEA0
        public void get_delta(){} // RVA: 0x810FEB0
        public void set_delta(){} // RVA: 0x810FED0
        public void get_pressPosition(){} // RVA: 0x810FEE0
        public void set_pressPosition(){} // RVA: 0x810FF00
        public void get_worldPosition(){} // RVA: 0x810FF10
        public void set_worldPosition(){} // RVA: 0x810FF30
        public void get_worldNormal(){} // RVA: 0x810FF50
        public void set_worldNormal(){} // RVA: 0x810FF70
        public void get_clickTime(){} // RVA: 0x810FF90
        public void set_clickTime(){} // RVA: 0x810FFA0
        public void get_clickCount(){} // RVA: 0x6BA2C40
        public void set_clickCount(){} // RVA: 0x6BA2C50
        public void get_scrollDelta(){} // RVA: 0x6CE7B80
        public void set_scrollDelta(){} // RVA: 0x6CE7BA0
        public void get_useDragThreshold(){} // RVA: 0x114AC40
        public void set_useDragThreshold(){} // RVA: 0x1A73430
        public void get_dragging(){} // RVA: 0x810FFB0
        public void set_dragging(){} // RVA: 0x810FFC0
        public void get_button(){} // RVA: 0x1EB2410
        public void set_button(){} // RVA: 0x1EABA10
        public void get_pressure(){} // RVA: 0x810FFD0
        public void set_pressure(){} // RVA: 0x810FFE0
        public void get_tangentialPressure(){} // RVA: 0x810FFF0
        public void set_tangentialPressure(){} // RVA: 0x8110000
        public void get_altitudeAngle(){} // RVA: 0x8110010
        public void set_altitudeAngle(){} // RVA: 0x8110020
        public void get_azimuthAngle(){} // RVA: 0x8110030
        public void set_azimuthAngle(){} // RVA: 0x8110040
        public void get_twist(){} // RVA: 0x8110050
        public void set_twist(){} // RVA: 0x8110060
        public void get_tilt(){} // RVA: 0x8110070
        public void set_tilt(){} // RVA: 0x1AE8DF0
        public void get_penStatus(){} // RVA: 0x79FAAD0
        public void set_penStatus(){} // RVA: 0x79FAAE0
        public void get_radius(){} // RVA: 0x8110090
        public void set_radius(){} // RVA: 0x81100B0
        public void get_radiusVariance(){} // RVA: 0x81100C0
        public void set_radiusVariance(){} // RVA: 0x81100E0
        public void get_fullyExited(){} // RVA: 0x81100F0
        public void set_fullyExited(){} // RVA: 0x8110100
        public void get_reentered(){} // RVA: 0xBD4A50
        public void set_reentered(){} // RVA: 0xBD4A60
        public void .ctor(){} // RVA: 0x8110110
        public void IsPointerMoving(){} // RVA: 0x8110430
        public void IsScrolling(){} // RVA: 0x8110460
        public void get_enterEventCamera(){} // RVA: 0x8110490
        public void get_pressEventCamera(){} // RVA: 0x81105B0
        public void get_pointerPress(){} // RVA: 0xB70160
        public void set_pointerPress(){} // RVA: 0x81106E0
        public void ToString(){} // RVA: 0x81108B0
    }

    public class PointerEventDataExtension : Object
    {
        // ── Methods ──
        public void IsVRPointer(){} // RVA: 0x6C679C0
        public void GetRay(){} // RVA: 0x6C67A40
        public void GetSwipeStart(){} // RVA: 0x6C67B00
        public void SetSwipeStart(){} // RVA: 0x6C67BB0
    }

    public class PointerInputModule : BaseInputModule
    {
        public object kMouseLeftId;
        public object kMouseRightId;
        public object kMouseMiddleId;
        public object kFakeTouchesId;
        public object m_PointerData;
        public object m_MouseState;

        // ── Methods ──
        public void GetPointerData(){} // RVA: 0x8119760
        public void RemovePointerData(){} // RVA: 0x81198D0
        public void GetTouchPointerEventData(){} // RVA: 0x8119940
        public void CopyFromTo(){} // RVA: 0x8119DE0
        public void StateForMouseButton(){} // RVA: 0x8119FD0
        public void GetMousePointerEventData(){} // RVA: 0x811A0B0
        public void GetLastPointerEventData(){} // RVA: 0x811A950
        public void ShouldStartDrag(){} // RVA: 0x811A980
        public void ProcessMove(){} // RVA: 0x811A9D0
        public void ProcessDrag(){} // RVA: 0x811AA60
        public void IsPointerOverGameObject(){} // RVA: 0x811AE10
        public void ClearSelection(){} // RVA: 0x811AF20
        public void ToString(){} // RVA: 0x811B1C0
        public void DeselectIfSelectionChanged(){} // RVA: 0x811B520
        public void .ctor(){} // RVA: 0x811B6C0
    }

    public class RaycastResult : ValueType
    {
        public object m_GameObject;
        public object module;
        public object distance;
        public object index;
        public object depth;
        public object sortingGroupID;
        public object sortingGroupOrder;
        public object sortingLayer;
        public object sortingOrder;
        public object worldPosition;
        public object worldNormal;
        public object screenPosition;
        public object displayIndex;

        // ── Methods ──
        public void get_gameObject(){} // RVA: 0x77900
        public void set_gameObject(){} // RVA: 0x47F10
        public void get_isValid(){} // RVA: 0x9ABC50
        public void Clear(){} // RVA: 0x9ABC60
        public void ToString(){} // RVA: 0x9ABDF0
    }

    public class RaycastResult[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2E7F4D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7AED0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC4C30
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E353E0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7AED0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class RaycasterManager : Object
    {
        public object s_Raycasters;

        // ── Methods ──
        public void AddRaycaster(){} // RVA: 0x8120A30
        public void GetRaycasters(){} // RVA: 0x8120B50
        public void RemoveRaycasters(){} // RVA: 0x8120BB0
        public void .cctor(){} // RVA: 0x8120C90
    }

    public class StandaloneInputModule : PointerInputModule
    {
        public object m_PrevActionTime;
        public object m_LastMoveVector;
        public object m_ConsecutiveMoveCount;
        public object m_LastMousePosition;
        public object m_MousePosition;
        public object m_CurrentFocusedGameObject;
        public object m_InputPointerEvent;
        public object doubleClickTime;
        public object m_HorizontalAxis;
        public object m_VerticalAxis;
        public object m_SubmitButton;
        public object m_CancelButton;
        public object m_InputActionsPerSecond;
        public object m_RepeatDelay;
        public object m_ForceModuleActive;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x811BD70
        public void get_inputMode(){} // RVA: 0xDAC980
        public void get_allowActivationOnMobileDevice(){} // RVA: 0xB63970
        public void set_allowActivationOnMobileDevice(){} // RVA: 0xB63980
        public void get_forceModuleActive(){} // RVA: 0xB63970
        public void set_forceModuleActive(){} // RVA: 0xB63980
        public void get_inputActionsPerSecond(){} // RVA: 0x6BA2BE0
        public void set_inputActionsPerSecond(){} // RVA: 0x6BA2BF0
        public void get_repeatDelay(){} // RVA: 0x25629A0
        public void set_repeatDelay(){} // RVA: 0x6C273B0
        public void get_horizontalAxis(){} // RVA: 0x106A7D0
        public void set_horizontalAxis(){} // RVA: 0xD5CC70
        public void get_verticalAxis(){} // RVA: 0x106A050
        public void set_verticalAxis(){} // RVA: 0xD5CCD0
        public void get_submitButton(){} // RVA: 0x12EB090
        public void set_submitButton(){} // RVA: 0x13B1040
        public void get_cancelButton(){} // RVA: 0xBAE340
        public void set_cancelButton(){} // RVA: 0xBAE350
        public void ShouldIgnoreEventsOnNoFocus(){} // RVA: 0xC2E4C0
        public void UpdateModule(){} // RVA: 0x811BF80
        public void ReleaseMouse(){} // RVA: 0x811C180
        public void ShouldActivateModule(){} // RVA: 0x811C7D0
        public void ActivateModule(){} // RVA: 0x811C9E0
        public void DeactivateModule(){} // RVA: 0x214C0E0
        public void Process(){} // RVA: 0x811CBB0
        public void ProcessTouchEvents(){} // RVA: 0x811CDD0
        public void ProcessTouchPress(){} // RVA: 0x811CFE0
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x811DCB0
        public void GetRawMoveVector(){} // RVA: 0x811DF00
        public void SendMoveEventToSelectedObject(){} // RVA: 0x811E070
        public void ProcessMouseEvent(){} // RVA: 0x811E3F0
        public void ForceAutoSelect(){} // RVA: 0xB43320
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x811E6C0
        public void ProcessMousePress(){} // RVA: 0x811E850
        public void GetCurrentFocusedGameObject(){} // RVA: 0xB813B0
    }

    public class TouchInputModule : PointerInputModule
    {
        public object m_LastMousePosition;
        public object m_MousePosition;
        public object m_InputPointerEvent;
        public object m_ForceModuleActive;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x811EF90
        public void get_allowActivationOnStandalone(){} // RVA: 0xE3F400
        public void set_allowActivationOnStandalone(){} // RVA: 0xE3CFC0
        public void get_forceModuleActive(){} // RVA: 0xE3F400
        public void set_forceModuleActive(){} // RVA: 0xE3CFC0
        public void UpdateModule(){} // RVA: 0x811EFA0
        public void IsModuleSupported(){} // RVA: 0x811F1C0
        public void ShouldActivateModule(){} // RVA: 0x811F210
        public void UseFakeInput(){} // RVA: 0x811F310
        public void Process(){} // RVA: 0x811F350
        public void FakeTouches(){} // RVA: 0x811F6C0
        public void ProcessTouchEvents(){} // RVA: 0x811F830
        public void ProcessTouchPress(){} // RVA: 0x811FA10
        public void DeactivateModule(){} // RVA: 0x214C0E0
        public void ToString(){} // RVA: 0x8120660
    }

    public class UIBehaviour : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0xB43310
        public void OnEnable(){} // RVA: 0xB43310
        public void Start(){} // RVA: 0xB43310
        public void OnDisable(){} // RVA: 0xB43310
        public void OnDestroy(){} // RVA: 0xB43310
        public void IsActive(){} // RVA: 0x7BF9CC0
        public void OnRectTransformDimensionsChange(){} // RVA: 0xB43310
        public void OnBeforeTransformParentChanged(){} // RVA: 0xB43310
        public void OnTransformParentChanged(){} // RVA: 0xB43310
        public void OnDidApplyAnimationProperties(){} // RVA: 0xB43310
        public void OnCanvasGroupChanged(){} // RVA: 0xB43310
        public void OnCanvasHierarchyChanged(){} // RVA: 0xB43310
        public void IsDestroyed(){} // RVA: 0x81236F0
        public void .ctor(){} // RVA: 0xB43D60
    }

    public class UIBehaviour[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EB5200
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC8810
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6F580
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7A660
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

}