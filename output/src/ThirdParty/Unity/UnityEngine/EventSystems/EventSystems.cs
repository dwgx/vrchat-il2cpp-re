// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.EventSystems
// Classes: 51
// Methods: 563

namespace ThirdParty.Unity.UnityEngine.EventSystems
{
    public class AbstractEventData : Object
    {
        // ── Methods ──
        public void Reset(){} // RVA: 0x7A847A460
        public void Use(){} // RVA: 0x7A847A240
        public void get_used(){} // RVA: 0x7A81A2200
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class AxisEventData : BaseEventData
    {
        // ── Methods ──
        public void get_moveVector(){} // RVA: 0x7A8884B20
        public void set_moveVector(){} // RVA: 0x7A8884B10
        public void get_moveDir(){} // RVA: 0x7A854FDE0
        public void set_moveDir(){} // RVA: 0x7A8810F60
        public void .ctor(){} // RVA: 0x7AF2C2AF0
        public void <moveVector>k__BackingField(){} // RVA: 0x7B3F3AC28
    }

    public class BaseEventData : AbstractEventData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A813E420
        public void get_currentInputModule(){} // RVA: 0x7ADE59600
        public void get_selectedObject(){} // RVA: 0x7ADE59660
        public void set_selectedObject(){} // RVA: 0x7AF2C2B90
    }

    public class BaseInput : UIBehaviour
    {
        // ── Methods ──
        public void get_compositionString(){} // RVA: 0x7AEF88040
        public void get_imeCompositionMode(){} // RVA: 0x7AEF87FA0
        public void set_imeCompositionMode(){} // RVA: 0x7AF2CA3D0
        public void get_compositionCursorPos(){} // RVA: 0x7AF2CA420
        public void set_compositionCursorPos(){} // RVA: 0x7AF2CA480
        public void get_mousePresent(){} // RVA: 0x7AEF88190
        public void GetMouseButtonDown(){} // RVA: 0x7AF1B5E10
        public void GetMouseButtonUp(){} // RVA: 0x7AF1B5E60
        public void GetMouseButton(){} // RVA: 0x7AF2CA4D0
        public void get_mousePosition(){} // RVA: 0x7AF2CA520
        public void get_mouseScrollDelta(){} // RVA: 0x7AF2CA590
        public void get_touchSupported(){} // RVA: 0x7A92A45A0
        public void get_touchCount(){} // RVA: 0x7AEF881E0
        public void GetTouch(){} // RVA: 0x7AF1B5D60
        public void GetAxisRaw(){} // RVA: 0x7AF2CA5F0
        public void GetButtonDown(){} // RVA: 0x7A80F6210
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class BaseInputModule : UIBehaviour
    {
        // ── Methods ──
        public void get_sendPointerHoverToParent(){} // RVA: 0x7A84A5BD0
        public void set_sendPointerHoverToParent(){} // RVA: 0x7A84A5CD0
        public void get_input(){} // RVA: 0x7AF2CA640
        public void get_inputOverride(){} // RVA: 0x7A8152D80
        public void set_inputOverride(){} // RVA: 0x7A8152D90
        public void get_eventSystem(){} // RVA: 0x7A8292C30
        public void OnEnable(){} // RVA: 0x7AF2CAA10
        public void OnDisable(){} // RVA: 0x7AF2CAAB0
        public void Process(){} // RVA: 0x7A7E18770
        public void FindFirstRaycast(){} // RVA: 0x7AF2CAAD0
        public void DetermineMoveDirection(){} // RVA: 0x7AF2CAD10
        public void FindCommonRoot(){} // RVA: 0x7AF2CAD90
        public void HandlePointerExitAndEnter(){} // RVA: 0x7AF2CB170
        public void GetAxisEventData(){} // RVA: 0x7AF2CC1F0
        public void GetBaseEventData(){} // RVA: 0x7AF2CC330
        public void IsPointerOverGameObject(){} // RVA: 0x7A80D7320
        public void ShouldActivateModule(){} // RVA: 0x7AF2CC460
        public void DeactivateModule(){} // RVA: 0x7A80D7310
        public void ActivateModule(){} // RVA: 0x7A80D7310
        public void UpdateModule(){} // RVA: 0x7A80D7310
        public void IsModuleSupported(){} // RVA: 0x7A81BD750
        public void ConvertUIToolkitPointerId(){} // RVA: 0x7AF2CC550
        public void .ctor(){} // RVA: 0x7AF2CC5F0
    }

    public class BaseInputModule[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class BaseInput[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
    }

    public class BaseRaycaster : UIBehaviour
    {
        // ── Methods ──
        public void Raycast(){} // RVA: 0x7A7E18890
        public void get_eventCamera(){} // RVA: 0x7A7E00680
        public void get_priority(){} // RVA: 0x7A82D1450
        public void get_sortOrderPriority(){} // RVA: 0x7AF2D3CE0
        public void get_renderOrderPriority(){} // RVA: 0x7AF2D3CE0
        public void get_rootRaycaster(){} // RVA: 0x7AF2D3CF0
        public void ToString(){} // RVA: 0x7AF2D3E70
        public void OnEnable(){} // RVA: 0x7AF2D4180
        public void OnDisable(){} // RVA: 0x7AF2D42D0
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7AD8439E0
        public void OnTransformParentChanged(){} // RVA: 0x7AD8439E0
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class BaseRaycaster[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class EventSystem : UIBehaviour
    {
        // ── Methods ──
        public void get_current(){} // RVA: 0x7AF2C42A0
        public void set_current(){} // RVA: 0x7AF2C4380
        public void get_sendNavigationEvents(){} // RVA: 0x7A82A20A0
        public void set_sendNavigationEvents(){} // RVA: 0x7A82A2C90
        public void get_pixelDragThreshold(){} // RVA: 0x7A864E8D0
        public void set_pixelDragThreshold(){} // RVA: 0x7A9ABBD00
        public void get_currentInputModule(){} // RVA: 0x7A8105330
        public void get_firstSelectedGameObject(){} // RVA: 0x7A83F69F0
        public void set_firstSelectedGameObject(){} // RVA: 0x7A8105A90
        public void get_currentSelectedGameObject(){} // RVA: 0x7A8154D80
        public void get_lastSelectedGameObject(){} // RVA: 0x7A82D1450
        public void get_isFocused(){} // RVA: 0x7A818F850
        public void .ctor(){} // RVA: 0x7AF2C4550
        public void UpdateModules(){} // RVA: 0x7AF2C4660
        public void get_alreadySelecting(){} // RVA: 0x7A9107BC0
        public void SetSelectedGameObject(){} // RVA: 0x7AF2C4C90
        public void get_baseEventDataCache(){} // RVA: 0x7AF2C4B90
        public void RaycastComparer(){} // RVA: 0x7AF2C4DB0
        public void RaycastAll(){} // RVA: 0x7AF2C54E0
        public void IsPointerOverGameObject(){} // RVA: 0x7AF2C5920
        public void get_isUIToolkitActiveEventSystem(){} // RVA: 0x7AF2C5A30
        public void get_sendUIToolkitEvents(){} // RVA: 0x7AF2C5C50
        public void get_createUIToolkitPanelGameObjectsOnStart(){} // RVA: 0x7AF2C5CC0
        public void SetUITookitEventSystemOverride(){} // RVA: 0x7AF2C5D30
        public void StartTrackingUIToolkitPanels(){} // RVA: 0x7AF2C6050
        public void StopTrackingUIToolkitPanels(){} // RVA: 0x7AF2C6490
        public void CreateUIToolkitPanelGameObject(){} // RVA: 0x7AF2C6690
        public void Start(){} // RVA: 0x7AF2C6BF0
        public void OnEnable(){} // RVA: 0x7AF2C6C00
        public void OnDisable(){} // RVA: 0x7AF2C6D70
        public void TickModules(){} // RVA: 0x7AF2C6F50
        public void OnApplicationFocus(){} // RVA: 0x7AF2C7110
        public void Update(){} // RVA: 0x7AF2C7120
        public void ChangeEventModule(){} // RVA: 0x7AF2C7600
        public void ToString(){} // RVA: 0x7AF2C78D0
        public void .cctor(){} // RVA: 0x7AF2C7AE0
    }

    public class EventSystem[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class EventTrigger : MonoBehaviour
    {
        // ── Methods ──
        public void get_delegates(){} // RVA: 0x7AF2C7DD0
        public void set_delegates(){} // RVA: 0x7A81052D0
        public void .ctor(){} // RVA: 0x7A80D7D60
        public void get_triggers(){} // RVA: 0x7AF2C7DE0
        public void set_triggers(){} // RVA: 0x7A81052D0
        public void Execute(){} // RVA: 0x7AF2C7EA0
        public void OnPointerEnter(){} // RVA: 0x7AF2C7FC0
        public void OnPointerExit(){} // RVA: 0x7AF2C7FD0
        public void OnDrag(){} // RVA: 0x7AF2C7FE0
        public void OnDrop(){} // RVA: 0x7AF2C7FF0
        public void OnPointerDown(){} // RVA: 0x7AF2C8000
        public void OnPointerUp(){} // RVA: 0x7AF2C8010
        public void OnPointerClick(){} // RVA: 0x7AF2C8020
        public void OnSelect(){} // RVA: 0x7AF2C8030
        public void OnDeselect(){} // RVA: 0x7AF2C8040
        public void OnScroll(){} // RVA: 0x7AF2C8050
        public void OnMove(){} // RVA: 0x7AF2C8060
        public void OnUpdateSelected(){} // RVA: 0x7AF2C8070
        public void OnInitializePotentialDrag(){} // RVA: 0x7AF2C8080
        public void OnBeginDrag(){} // RVA: 0x7AF2C8090
        public void OnEndDrag(){} // RVA: 0x7AF2C80A0
        public void OnSubmit(){} // RVA: 0x7AF2C80B0
        public void OnCancel(){} // RVA: 0x7AF2C80C0
    }

    public class ExecuteEvents : Object
    {
        // ── Methods ──
        public void ValidateEventData(){} // RVA: 0x7AA4984B0
        public void Execute(){} // RVA: 0x7AA496A90
        public void get_pointerMoveHandler(){} // RVA: 0x7AF2C8C70
        public void get_pointerEnterHandler(){} // RVA: 0x7AF2C8CD0
        public void get_pointerExitHandler(){} // RVA: 0x7AF2C8D30
        public void get_pointerDownHandler(){} // RVA: 0x7AF2C8D90
        public void get_pointerUpHandler(){} // RVA: 0x7AF2C8DF0
        public void get_pointerClickHandler(){} // RVA: 0x7AF2C8E50
        public void get_initializePotentialDrag(){} // RVA: 0x7AF2C8EB0
        public void get_beginDragHandler(){} // RVA: 0x7AF2C8F10
        public void get_dragHandler(){} // RVA: 0x7AF2C8F70
        public void get_endDragHandler(){} // RVA: 0x7AF2C8FD0
        public void get_dropHandler(){} // RVA: 0x7AF2C9030
        public void get_scrollHandler(){} // RVA: 0x7AF2C9090
        public void get_updateSelectedHandler(){} // RVA: 0x7AF2C90F0
        public void get_selectHandler(){} // RVA: 0x7AF2C9150
        public void get_deselectHandler(){} // RVA: 0x7AF2C91B0
        public void get_moveHandler(){} // RVA: 0x7AF2C9210
        public void get_submitHandler(){} // RVA: 0x7AF2C9270
        public void get_cancelHandler(){} // RVA: 0x7AF2C92D0
        public void GetEventChain(){} // RVA: 0x7AF2C9330
        public void ExecuteHierarchy(){} // RVA: 0x7AA497270
        public void ShouldSendToComponent(){} // RVA: 0x7AA498300
        public void GetEventList(){} // RVA: 0x7AA497C20
        public void CanHandleEvent(){} // RVA: 0x7AA496890
        public void GetEventHandler(){} // RVA: 0x7AA497670
        public void .cctor(){} // RVA: 0x7AF2C95E0
    }

    public class IBeginDragHandler
    {
        // ── Methods ──
        public void OnBeginDrag(){} // RVA: 0x7A7E18800
    }

    public class ICancelHandler
    {
        // ── Methods ──
        public void OnCancel(){} // RVA: 0x7A7E18800
    }

    public class IDeselectHandler
    {
        // ── Methods ──
        public void OnDeselect(){} // RVA: 0x7A7E18800
    }

    public class IDragHandler
    {
        // ── Methods ──
        public void OnDrag(){} // RVA: 0x7A7E18800
    }

    public class IDragHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IDropHandler
    {
        // ── Methods ──
        public void OnDrop(){} // RVA: 0x7A7E18800
    }

    public class IEndDragHandler
    {
        // ── Methods ──
        public void OnEndDrag(){} // RVA: 0x7A7E18800
    }

    public class IEventSystemHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IInitializePotentialDragHandler
    {
        // ── Methods ──
        public void OnInitializePotentialDrag(){} // RVA: 0x7A7E18800
    }

    public class IMoveHandler
    {
        // ── Methods ──
        public void OnMove(){} // RVA: 0x7A7E18800
    }

    public class IPointerClickHandler
    {
        // ── Methods ──
        public void OnPointerClick(){} // RVA: 0x7A7E18800
    }

    public class IPointerClickHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IPointerDownHandler
    {
        // ── Methods ──
        public void OnPointerDown(){} // RVA: 0x7A7E18800
    }

    public class IPointerDownHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class IPointerEnterHandler
    {
        // ── Methods ──
        public void OnPointerEnter(){} // RVA: 0x7A7E18800
    }

    public class IPointerExitHandler
    {
        // ── Methods ──
        public void OnPointerExit(){} // RVA: 0x7A7E18800
    }

    public class IPointerMoveHandler
    {
        // ── Methods ──
        public void OnPointerMove(){} // RVA: 0x7A7E18800
    }

    public class IPointerUpHandler
    {
        // ── Methods ──
        public void OnPointerUp(){} // RVA: 0x7A7E18800
    }

    public class IScrollHandler
    {
        // ── Methods ──
        public void OnScroll(){} // RVA: 0x7A7E18800
    }

    public class IScrollHandler[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ISelectHandler
    {
        // ── Methods ──
        public void OnSelect(){} // RVA: 0x7A7E18800
    }

    public class ISubmitHandler
    {
        // ── Methods ──
        public void OnSubmit(){} // RVA: 0x7A7E18800
    }

    public class IUpdateSelectedHandler
    {
        // ── Methods ──
        public void OnUpdateSelected(){} // RVA: 0x7A7E18800
    }

    public class OVRInputModule : PointerInputModule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFDEDF0
        public void get_inputMode(){} // RVA: 0x7A82D1450
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x7ADF154F0
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x7ADFDF170
        public void get_inputActionsPerSecond(){} // RVA: 0x7A8664590
        public void set_inputActionsPerSecond(){} // RVA: 0x7A8664730
        public void get_horizontalAxis(){} // RVA: 0x7A81426F0
        public void set_horizontalAxis(){} // RVA: 0x7A8142700
        public void get_verticalAxis(){} // RVA: 0x7A82305B0
        public void set_verticalAxis(){} // RVA: 0x7A82305C0
        public void get_submitButton(){} // RVA: 0x7A81F50F0
        public void set_submitButton(){} // RVA: 0x7A81F5100
        public void get_cancelButton(){} // RVA: 0x7A8854870
        public void set_cancelButton(){} // RVA: 0x7A8158EF0
        public void UpdateModule(){} // RVA: 0x7ADFDF180
        public void IsModuleSupported(){} // RVA: 0x7ADFDF210
        public void ShouldActivateModule(){} // RVA: 0x7ADFDF270
        public void ActivateModule(){} // RVA: 0x7ADFDF4B0
        public void DeactivateModule(){} // RVA: 0x7ADFDF6B0
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x7ADFDF6C0
        public void AllowMoveEventProcessing(){} // RVA: 0x7ADFDF950
        public void GetRawMoveVector(){} // RVA: 0x7ADFDFA30
        public void SendMoveEventToSelectedObject(){} // RVA: 0x7ADFDFC10
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x7ADFDFE50
        public void ProcessMousePress(){} // RVA: 0x7ADFDFFE0
        public void ProcessMouseEvent(){} // RVA: 0x7ADFE0C30
        public void Process(){} // RVA: 0x7ADFE10F0
        public void UseMouse(){} // RVA: 0x7ADFE12F0
        public void CopyFromTo(){} // RVA: 0x7ADFE1540
        public void GetPointerData(){} // RVA: 0x7ADFE16B0
        public void ClearSelection(){} // RVA: 0x7ADFE1830
        public void GetRectTransformNormal(){} // RVA: 0x7ADFE1D00
        public void GetGazePointerData(){} // RVA: 0x7ADFE1F60
        public void GetCanvasPointerData(){} // RVA: 0x7ADFE2F10
        public void ShouldStartDrag(){} // RVA: 0x7ADFE37D0
        public void IsPointerMoving(){} // RVA: 0x7ADFE3B90
        public void SwipeAdjustedPosition(){} // RVA: 0x7A9194610
        public void ProcessDrag(){} // RVA: 0x7ADFE3C30
        public void GetGazeButtonState(){} // RVA: 0x7ADFE40F0
        public void GetExtraScrollDelta(){} // RVA: 0x7ADFE42E0
    }

    public class OVRPhysicsRaycaster : BaseRaycaster
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A8DF1590
        public void get_eventCamera(){} // RVA: 0x7ADFE43E0
        public void get_depth(){} // RVA: 0x7ADFE4450
        public void get_sortOrderPriority(){} // RVA: 0x7A8F9ACE0
        public void get_finalEventMask(){} // RVA: 0x7ADFE45B0
        public void get_eventMask(){} // RVA: 0x7A854FDE0
        public void set_eventMask(){} // RVA: 0x7A8810F60
        public void Raycast(){} // RVA: 0x7ADFE4710
        public void Spherecast(){} // RVA: 0x7ADFE4EB0
        public void GetScreenPos(){} // RVA: 0x7ADFE5660
    }

    public class OVRPointerEventData : PointerEventData
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADFE5820
        public void ToString(){} // RVA: 0x7ADFE5830
    }

    public class Physics2DRaycaster : PhysicsRaycaster
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A95703E0
        public void Raycast(){} // RVA: 0x7AF2D43E0
    }

    public class PhysicsRaycaster : BaseRaycaster
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A95703E0
        public void get_eventCamera(){} // RVA: 0x7AF2D4EA0
        public void get_depth(){} // RVA: 0x7AF2D50C0
        public void get_finalEventMask(){} // RVA: 0x7AF2D5220
        public void get_eventMask(){} // RVA: 0x7A8133100
        public void set_eventMask(){} // RVA: 0x7A8133110
        public void get_maxRayIntersections(){} // RVA: 0x7A82C2070
        public void set_maxRayIntersections(){} // RVA: 0x7A82C0430
        public void ComputeRayAndDistance(){} // RVA: 0x7AF2D5380
        public void Raycast(){} // RVA: 0x7AF2D5820
    }

    public class PointerEventData : BaseEventData
    {
        // ── Methods ──
        public void get_pointerEnter(){} // RVA: 0x7A81052C0
        public void set_pointerEnter(){} // RVA: 0x7A81052D0
        public void get_lastPress(){} // RVA: 0x7A83F69F0
        public void set_lastPress(){} // RVA: 0x7A8105A90
        public void get_rawPointerPress(){} // RVA: 0x7A8292C30
        public void set_rawPointerPress(){} // RVA: 0x7A8296DE0
        public void get_pointerDrag(){} // RVA: 0x7A8154D80
        public void set_pointerDrag(){} // RVA: 0x7A80FF440
        public void get_pointerClick(){} // RVA: 0x7A8152D80
        public void set_pointerClick(){} // RVA: 0x7A8152D90
        public void get_pointerCurrentRaycast(){} // RVA: 0x7AC022530
        public void set_pointerCurrentRaycast(){} // RVA: 0x7AF2C2BC0
        public void get_pointerPressRaycast(){} // RVA: 0x7AF2C2C40
        public void set_pointerPressRaycast(){} // RVA: 0x7AF2C2C80
        public void get_eligibleForClick(){} // RVA: 0x7A8F95560
        public void set_eligibleForClick(){} // RVA: 0x7AEDF5D50
        public void get_displayIndex(){} // RVA: 0x7A8F96260
        public void set_displayIndex(){} // RVA: 0x7AEDF5CD0
        public void get_pointerId(){} // RVA: 0x7AE25CAD0
        public void set_pointerId(){} // RVA: 0x7AF2C2D10
        public void get_position(){} // RVA: 0x7AF2C2D20
        public void set_position(){} // RVA: 0x7AF2C2D40
        public void get_delta(){} // RVA: 0x7AF2C2D50
        public void set_delta(){} // RVA: 0x7AF2C2D70
        public void get_pressPosition(){} // RVA: 0x7AF2C2D80
        public void set_pressPosition(){} // RVA: 0x7AF2C2DA0
        public void get_worldPosition(){} // RVA: 0x7AF2C2DB0
        public void set_worldPosition(){} // RVA: 0x7AF2C2DD0
        public void get_worldNormal(){} // RVA: 0x7AF2C2DF0
        public void set_worldNormal(){} // RVA: 0x7AF2C2E10
        public void get_clickTime(){} // RVA: 0x7AF2C2E30
        public void set_clickTime(){} // RVA: 0x7AF2C2E40
        public void get_clickCount(){} // RVA: 0x7A8F9BFE0
        public void set_clickCount(){} // RVA: 0x7ADF1BE10
        public void get_scrollDelta(){} // RVA: 0x7AE0661E0
        public void set_scrollDelta(){} // RVA: 0x7AE066200
        public void get_useDragThreshold(){} // RVA: 0x7A864CD00
        public void set_useDragThreshold(){} // RVA: 0x7A8FC2590
        public void get_dragging(){} // RVA: 0x7AF2C2E50
        public void set_dragging(){} // RVA: 0x7AF2C2E60
        public void get_button(){} // RVA: 0x7A93B3910
        public void set_button(){} // RVA: 0x7A9398450
        public void get_pressure(){} // RVA: 0x7AF2C2E70
        public void set_pressure(){} // RVA: 0x7AF2C2E80
        public void get_tangentialPressure(){} // RVA: 0x7AF2C2E90
        public void set_tangentialPressure(){} // RVA: 0x7AF2C2EA0
        public void get_altitudeAngle(){} // RVA: 0x7AF2C2EB0
        public void set_altitudeAngle(){} // RVA: 0x7AF2C2EC0
        public void get_azimuthAngle(){} // RVA: 0x7AF2C2ED0
        public void set_azimuthAngle(){} // RVA: 0x7AF2C2EE0
        public void get_twist(){} // RVA: 0x7AEDADC90
        public void set_twist(){} // RVA: 0x7A8F999C0
        public void get_tilt(){} // RVA: 0x7AF2C2EF0
        public void set_tilt(){} // RVA: 0x7AF2C2F10
        public void get_penStatus(){} // RVA: 0x7AF2C2F20
        public void set_penStatus(){} // RVA: 0x7AF2C2F30
        public void get_radius(){} // RVA: 0x7AF2C2F40
        public void set_radius(){} // RVA: 0x7AF2C2F60
        public void get_radiusVariance(){} // RVA: 0x7AF2C2F70
        public void set_radiusVariance(){} // RVA: 0x7AF2C2F90
        public void get_fullyExited(){} // RVA: 0x7AF2C2FA0
        public void set_fullyExited(){} // RVA: 0x7AF2C2FB0
        public void get_reentered(){} // RVA: 0x7A8167DE0
        public void set_reentered(){} // RVA: 0x7A8167DF0
        public void .ctor(){} // RVA: 0x7AF2C2FC0
        public void IsPointerMoving(){} // RVA: 0x7AF2C32E0
        public void IsScrolling(){} // RVA: 0x7AF2C3310
        public void get_enterEventCamera(){} // RVA: 0x7AF2C3340
        public void get_pressEventCamera(){} // RVA: 0x7AF2C3460
        public void get_pointerPress(){} // RVA: 0x7A8105330
        public void set_pointerPress(){} // RVA: 0x7AF2C3590
        public void ToString(){} // RVA: 0x7AF2C3760
    }

    public class PointerEventDataExtension : Object
    {
        // ── Methods ──
        public void IsVRPointer(){} // RVA: 0x7ADFE5D60
        public void GetRay(){} // RVA: 0x7ADFE5DE0
        public void GetSwipeStart(){} // RVA: 0x7ADFE5EA0
        public void SetSwipeStart(){} // RVA: 0x7ADFE5F50
    }

    public class PointerInputModule : BaseInputModule
    {
        // ── Methods ──
        public void GetPointerData(){} // RVA: 0x7AF2CC6F0
        public void RemovePointerData(){} // RVA: 0x7AF2CC860
        public void GetTouchPointerEventData(){} // RVA: 0x7AF2CC8D0
        public void CopyFromTo(){} // RVA: 0x7AF2CCD70
        public void StateForMouseButton(){} // RVA: 0x7AF2CCF60
        public void GetMousePointerEventData(){} // RVA: 0x7AF2CD020
        public void GetLastPointerEventData(){} // RVA: 0x7AF2CD8C0
        public void ShouldStartDrag(){} // RVA: 0x7AF2CD8F0
        public void ProcessMove(){} // RVA: 0x7AF2CD940
        public void ProcessDrag(){} // RVA: 0x7AF2CD9D0
        public void IsPointerOverGameObject(){} // RVA: 0x7AF2CDD80
        public void ClearSelection(){} // RVA: 0x7AF2CDE90
        public void ToString(){} // RVA: 0x7AF2CE130
        public void DeselectIfSelectionChanged(){} // RVA: 0x7AF2CE490
        public void .ctor(){} // RVA: 0x7AF2CE630
    }

    public class RaycastResult : ValueType
    {
        // ── Methods ──
        public void get_gameObject(){} // RVA: 0x7A765F710
        public void set_gameObject(){} // RVA: 0x7A7637E60
        public void get_isValid(){} // RVA: 0x7A7F0C4F0
        public void Clear(){} // RVA: 0x7A7F0C500
        public void ToString(){} // RVA: 0x7A7F0C690
    }

    public class RaycastResult[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2A27D0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29E600
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E3830
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA25C710
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29E600
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class RaycasterManager : Object
    {
        // ── Methods ──
        public void AddRaycaster(){} // RVA: 0x7AF2D39A0
        public void GetRaycasters(){} // RVA: 0x7AF2D3AC0
        public void RemoveRaycasters(){} // RVA: 0x7AF2D3B20
        public void .cctor(){} // RVA: 0x7AF2D3C00
    }

    public class StandaloneInputModule : PointerInputModule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF2CECE0
        public void get_inputMode(){} // RVA: 0x7A82D1450
        public void get_allowActivationOnMobileDevice(){} // RVA: 0x7A80F86D0
        public void set_allowActivationOnMobileDevice(){} // RVA: 0x7A80F86E0
        public void get_forceModuleActive(){} // RVA: 0x7A80F86D0
        public void set_forceModuleActive(){} // RVA: 0x7A80F86E0
        public void get_inputActionsPerSecond(){} // RVA: 0x7A9AAC220
        public void set_inputActionsPerSecond(){} // RVA: 0x7A9AAC210
        public void get_repeatDelay(){} // RVA: 0x7A9AAC200
        public void set_repeatDelay(){} // RVA: 0x7A9AAC1F0
        public void get_horizontalAxis(){} // RVA: 0x7A87D9C10
        public void set_horizontalAxis(){} // RVA: 0x7A8744720
        public void get_verticalAxis(){} // RVA: 0x7A87C5850
        public void set_verticalAxis(){} // RVA: 0x7A87446C0
        public void get_submitButton(){} // RVA: 0x7A87D9480
        public void set_submitButton(){} // RVA: 0x7A8881790
        public void get_cancelButton(){} // RVA: 0x7A8142610
        public void set_cancelButton(){} // RVA: 0x7A8142620
        public void ShouldIgnoreEventsOnNoFocus(){} // RVA: 0x7A81BD750
        public void UpdateModule(){} // RVA: 0x7AF2CEEF0
        public void ReleaseMouse(){} // RVA: 0x7AF2CF0F0
        public void ShouldActivateModule(){} // RVA: 0x7AF2CF740
        public void ActivateModule(){} // RVA: 0x7AF2CF950
        public void DeactivateModule(){} // RVA: 0x7A9620020
        public void Process(){} // RVA: 0x7AF2CFB20
        public void ProcessTouchEvents(){} // RVA: 0x7AF2CFD40
        public void ProcessTouchPress(){} // RVA: 0x7AF2CFF50
        public void SendSubmitEventToSelectedObject(){} // RVA: 0x7AF2D0C20
        public void GetRawMoveVector(){} // RVA: 0x7AF2D0E70
        public void SendMoveEventToSelectedObject(){} // RVA: 0x7AF2D0FE0
        public void ProcessMouseEvent(){} // RVA: 0x7AF2D1360
        public void ForceAutoSelect(){} // RVA: 0x7A80D7320
        public void SendUpdateEventToSelectedObject(){} // RVA: 0x7AF2D1630
        public void ProcessMousePress(){} // RVA: 0x7AF2D17C0
        public void GetCurrentFocusedGameObject(){} // RVA: 0x7A81163D0
    }

    public class TouchInputModule : PointerInputModule
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AF2D1F00
        public void get_allowActivationOnStandalone(){} // RVA: 0x7A8361EA0
        public void set_allowActivationOnStandalone(){} // RVA: 0x7A835F4F0
        public void get_forceModuleActive(){} // RVA: 0x7A8361EA0
        public void set_forceModuleActive(){} // RVA: 0x7A835F4F0
        public void UpdateModule(){} // RVA: 0x7AF2D1F10
        public void IsModuleSupported(){} // RVA: 0x7AF2D2130
        public void ShouldActivateModule(){} // RVA: 0x7AF2D2180
        public void UseFakeInput(){} // RVA: 0x7AF2D2280
        public void Process(){} // RVA: 0x7AF2D22C0
        public void FakeTouches(){} // RVA: 0x7AF2D2630
        public void ProcessTouchEvents(){} // RVA: 0x7AF2D27A0
        public void ProcessTouchPress(){} // RVA: 0x7AF2D2980
        public void DeactivateModule(){} // RVA: 0x7A9620020
        public void ToString(){} // RVA: 0x7AF2D35D0
    }

    public class UIBehaviour : MonoBehaviour
    {
        // ── Methods ──
        public void Awake(){} // RVA: 0x7A80D7310
        public void OnEnable(){} // RVA: 0x7A80D7310
        public void Start(){} // RVA: 0x7A80D7310
        public void OnDisable(){} // RVA: 0x7A80D7310
        public void OnDestroy(){} // RVA: 0x7A80D7310
        public void IsActive(){} // RVA: 0x7AEF01530
        public void OnRectTransformDimensionsChange(){} // RVA: 0x7A80D7310
        public void OnBeforeTransformParentChanged(){} // RVA: 0x7A80D7310
        public void OnTransformParentChanged(){} // RVA: 0x7A80D7310
        public void OnDidApplyAnimationProperties(){} // RVA: 0x7A80D7310
        public void OnCanvasGroupChanged(){} // RVA: 0x7A80D7310
        public void OnCanvasHierarchyChanged(){} // RVA: 0x7A80D7310
        public void IsDestroyed(){} // RVA: 0x7AF2D6690
        public void .ctor(){} // RVA: 0x7A80D7D60
    }

    public class UIBehaviour[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D6630
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E6BD0
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA2836C0
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29DE40
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

}