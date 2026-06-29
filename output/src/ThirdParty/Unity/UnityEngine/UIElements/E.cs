// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 99
// Methods: 885

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class EasingFunction : ValueType
    {
        public object m_Mode;

        // ── Methods ──
        public void get_mode(){} // RVA: 0x77E60
        public void set_mode(){} // RVA: 0x29580
        public void .ctor(){} // RVA: 0x29580
        public void op_Implicit(){} // RVA: 0x2996070
        public void op_Equality(){} // RVA: 0x7BF2630
        public void Equals(){} // RVA: 0x9AA3A0
        public void ToString(){} // RVA: 0x9AA420
        public void GetHashCode(){} // RVA: 0x454FE0
    }

    public class EasingFunction[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x2EC3B20
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x6945450
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x2EAEF00
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x2EC5B20
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x6942190
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0xC2E4C0
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x6945400
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x2E07DB0
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x2E6B100
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x2E7A410
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x2E7A4A0
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x2E7B630
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x6942190
    }

    public class EditorPanelRootElement : PanelRootElement
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x80A2080
        public void OnEventCompletedAtAnyTarget(){} // RVA: 0x80A22A0
    }

    public class ElementUnderPointer : Object
    {
        public object m_PendingTopElementUnderPointer;
        public object m_TopElementUnderPointer;
        public object m_TriggerEvent;
        public object m_PickingPointerPositions;
        public object m_IsPickingPointerTemporaries;

        // ── Methods ──
        public void GetTopElementUnderPointer(){} // RVA: 0x753C8F0
        public void SetElementUnderPointer(){} // RVA: 0x80567A0
        public void GetEventPointerPosition(){} // RVA: 0x8056660
        public void SetTemporaryElementUnderPointer(){} // RVA: 0x8056760
        public void CommitElementUnderPointers(){} // RVA: 0x8056A60
        public void .ctor(){} // RVA: 0x8057870
    }

    public class EnumField : BaseField`1
    {
        public object textProperty;
        public object m_EnumType;
        public object m_IncludeObsoleteValues;
        public object m_TextElement;
        public object m_ArrowElement;
        public object m_EnumData;
        public object createMenuCallback;
        public object ussClassName;
        public object textUssClassName;
        public object arrowUssClassName;
        public object labelUssClassName;
        public object inputUssClassName;

        // ── Methods ──
        public void get_includeObsoleteValues(){} // RVA: 0x7FDD160
        public void get_text(){} // RVA: 0x7FDD170
        public void Initialize(){} // RVA: 0x7FDD1A0
        public void .ctor(){} // RVA: 0x7FDD430
        public void Init(){} // RVA: 0x7FDD850
        public void PopulateDataFromType(){} // RVA: 0x7FDD970
        public void SetValueWithoutNotify(){} // RVA: 0x7FDDB30
        public void UpdateValueLabel(){} // RVA: 0x7FDDC00
        public void OnPointerDownEvent(){} // RVA: 0x7FDDD70
        public void OnPointerMoveEvent(){} // RVA: 0x7FDDDC0
        public void ContainsPointer(){} // RVA: 0x7FDDE50
        public void ProcessPointerDown(){} // RVA: 0x894320
        public void OnNavigationSubmit(){} // RVA: 0x7FDDEF0
        public void ShowMenu(){} // RVA: 0x7FDDF20
        public void ChangeValueFromMenu(){} // RVA: 0x7FDE280
        public void UpdateMixedValueContent(){} // RVA: 0x7FDE2E0
        public void .cctor(){} // RVA: 0x7FDE480
        public void <ShowMenu>b__42_0(){} // RVA: 0x7FDE280
    }

    public class EnumFieldHelpers : Object
    {
        public object type;
        public object value;
        public object includeObsoleteValues;

        // ── Methods ──
        public void ExtractValue(){} // RVA: 0x7FDC5A0
        public void .cctor(){} // RVA: 0x7FDCC20
    }

    public class EventBase : Object
    {
        public object s_LastTypeId;
        public object _eventCategories;
        public object s_NextEventId;
        public object _timestamp;
        public object _eventId;
        public object _triggerEventId;
        public object _propagation;
        public object _lifeCycleStatus;
        public object _elementTarget;
        public object _propagationPhase;
        public object m_CurrentTarget;
        public object m_ImguiEvent;
        public object _originalMousePosition;

        // ── Methods ──
        public void RegisterEventType(){} // RVA: 0x8057B40
        public void get_eventTypeId(){} // RVA: 0x2551610
        public void get_eventCategories(){} // RVA: 0xB8F8F0
        public void get_timestamp(){} // RVA: 0xB465B0
        public void set_timestamp(){} // RVA: 0x15428E0
        public void get_eventId(){} // RVA: 0xB700F0
        public void set_eventId(){} // RVA: 0x13B3F80
        public void set_triggerEventId(){} // RVA: 0x116B360
        public void SetTriggerEventId(){} // RVA: 0x116B360
        public void get_propagation(){} // RVA: 0xB9E080
        public void set_propagation(){} // RVA: 0xB9E090
        public void get_lifeCycleStatus(){} // RVA: 0xE9CE60
        public void set_lifeCycleStatus(){} // RVA: 0xEA1260
        public void PreDispatch(){} // RVA: 0x7183E10
        public void PostDispatch(){} // RVA: 0x8057B90
        public void Dispatch(){} // RVA: 0x8057BC0
        public void get_bubbles(){} // RVA: 0x8057C00
        public void set_bubbles(){} // RVA: 0x8057C10
        public void get_tricklesDown(){} // RVA: 0x8057C30
        public void set_tricklesDown(){} // RVA: 0x8057C40
        public void get_skipDisabledElements(){} // RVA: 0x8057C60
        public void set_skipDisabledElements(){} // RVA: 0x8057C70
        public void get_bubblesOrTricklesDown(){} // RVA: 0x8057C90
        public void get_elementTarget(){} // RVA: 0xD05CA0
        public void set_elementTarget(){} // RVA: 0xD09D70
        public void get_target(){} // RVA: 0xD05CA0
        public void set_target(){} // RVA: 0x8057CA0
        public void get_isPropagationStopped(){} // RVA: 0x8057D70
        public void set_isPropagationStopped(){} // RVA: 0x8057D80
        public void StopPropagation(){} // RVA: 0x8057DA0
        public void get_isImmediatePropagationStopped(){} // RVA: 0x8057DB0
        public void set_isImmediatePropagationStopped(){} // RVA: 0x8057DC0
        public void StopImmediatePropagation(){} // RVA: 0x8057DE0
        public void set_propagationPhase(){} // RVA: 0xBE5860
        public void get_currentTarget(){} // RVA: 0x7C7E010
        public void set_currentTarget(){} // RVA: 0x8057DF0
        public void get_dispatch(){} // RVA: 0x8058000
        public void set_dispatch(){} // RVA: 0x8058010
        public void MarkReceivedByDispatcher(){} // RVA: 0x8058030
        public void get_dispatched(){} // RVA: 0x80580B0
        public void set_dispatched(){} // RVA: 0x80580C0
        public void get_processed(){} // RVA: 0x80580E0
        public void set_processed(){} // RVA: 0x80580F0
        public void get_processedByFocusController(){} // RVA: 0x8058110
        public void set_processedByFocusController(){} // RVA: 0x8058120
        public void get_propagateToIMGUI(){} // RVA: 0x8058140
        public void set_propagateToIMGUI(){} // RVA: 0x8058150
        public void get_imguiEventIsValid(){} // RVA: 0x8058170
        public void set_imguiEventIsValid(){} // RVA: 0x8058180
        public void get_imguiEvent(){} // RVA: 0x80581A0
        public void set_imguiEvent(){} // RVA: 0x80581B0
        public void get_originalMousePosition(){} // RVA: 0x253A460
        public void set_originalMousePosition(){} // RVA: 0xEA1CE0
        public void Init(){} // RVA: 0x80583D0
        public void LocalInit(){} // RVA: 0x80583E0
        public void .ctor(){} // RVA: 0x8058610
        public void get_pooled(){} // RVA: 0x8058680
        public void set_pooled(){} // RVA: 0x8058690
        public void Acquire(){} // RVA: 0x894290
        public void Dispose(){} // RVA: 0x894290
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x894350
        public void .ctor(){} // RVA: 0x894290
        public void TypeId(){} // RVA: 0x87C0D0
        public void Init(){} // RVA: 0x894290
        public void GetPooled(){} // RVA: 0xA94080
        public void ReleasePooled(){} // RVA: 0xA94080
        public void Acquire(){} // RVA: 0x894290
        public void Dispose(){} // RVA: 0x894290
        public void get_eventTypeId(){} // RVA: 0x87C0A0
        public void .cctor(){} // RVA: 0x8942F0
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventBase`1 : EventBase
    {
        public object s_TypeId;
        public object s_Pool;
        public object m_RefCount;
        public object EventCategory;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3DB7A40
        public void .ctor(){} // RVA: 0x3DB7B40
        public void TypeId(){} // RVA: 0x3DB7BD0
        public void Init(){} // RVA: 0x3DB7C70
        public void GetPooled(){} // RVA: 0x3DB7E50
        public void ReleasePooled(){} // RVA: 0x3DB7EF0
        public void Acquire(){} // RVA: 0x3DB8000
        public void Dispose(){} // RVA: 0x3DB8010
        public void get_eventTypeId(){} // RVA: 0x3DB81A0
        public void .cctor(){} // RVA: 0x3DB8220
    }

    public class EventCallbackFunctorBase : Object
    {
        public object eventTypeId;
        public object invokePolicy;

        // ── Methods ──
        public void Invoke(){} // RVA: 0x894320
        public void UnregisterCallback(){} // RVA: 0x899290
        public void Dispose(){} // RVA: 0x894290
        public void IsEquivalentTo(){} // RVA: 0x87D450
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EventCallbackFunctorBase[] : Array
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

    public class EventCallbackFunctor`1 : EventCallbackFunctorBase
    {
        public object m_Callback;

        // ── Methods ──
        public void GetPooled(){} // RVA: 0xA94080
        public void Dispose(){} // RVA: 0x894290
        public void Invoke(){} // RVA: 0x894320
        public void UnregisterCallback(){} // RVA: 0x899290
        public void IsEquivalentTo(){} // RVA: 0x87D450
        public void .ctor(){} // RVA: 0x894290
    }

    public class EventCallbackFunctor`2 : EventCallbackFunctorBase
    {
        public object m_Callback;
        public object _userArgs;

        // ── Methods ──
        public void get_userArgs(){} // RVA: 0xA94080
        public void set_userArgs(){} // RVA: 0xA94080
        public void GetPooled(){} // RVA: 0xA94080
        public void Dispose(){} // RVA: 0x894290
        public void Invoke(){} // RVA: 0x894320
        public void UnregisterCallback(){} // RVA: 0x899290
        public void IsEquivalentTo(){} // RVA: 0x87D450
        public void .ctor(){} // RVA: 0x894290
    }

    public class EventCallbackList : Object
    {
        public object EmptyList;
        public object EmptyArray;
        public object m_Array;
        public object m_Count;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x8058A30
        public void Find(){} // RVA: 0x8058C10
        public void Remove(){} // RVA: 0x8058CC0
        public void Add(){} // RVA: 0x8058E20
        public void AddRange(){} // RVA: 0x8058F10
        public void get_Span(){} // RVA: 0x8058FE0
        public void Clear(){} // RVA: 0x698B9A0
        public void .cctor(){} // RVA: 0x8059050
    }

    public class EventCallbackListPool : Object
    {
        public object m_Stack;

        // ── Methods ──
        public void Get(){} // RVA: 0x80586B0
        public void Release(){} // RVA: 0x8058840
        public void .ctor(){} // RVA: 0x80588C0
    }

    public class EventCallbackRegistry : Object
    {
        public object s_ListPool;
        public object m_TrickleDownCallbacks;
        public object m_BubbleUpCallbacks;

        // ── Methods ──
        public void GetCallbackList(){} // RVA: 0x8059190
        public void ReleaseCallbackList(){} // RVA: 0x8059370
        public void GetDynamicCallbackList(){} // RVA: 0x8059440
        public void RegisterCallback(){} // RVA: 0xA94080
        public void UnregisterCallback(){} // RVA: 0x87FE70
        public void .ctor(){} // RVA: 0x8059460
        public void .cctor(){} // RVA: 0x8059570
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0xA94080
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xBC4530
    }

    public class EventCallback`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x899C90
        public void Invoke(){} // RVA: 0xA94080
    }

    public class EventCallback`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DB94B0
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class EventCallback`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x3DB94B0
        public void Invoke(){} // RVA: 0xCA8BF0
    }

    public class EventCategoryAttribute : Attribute
    {
        public object category;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
    }

    public class EventDispatchUtilities : Object
    {
        // ── Methods ──
        public void PropagateEvent(){} // RVA: 0x805A2F0
        public void HandleEventAtTargetAndDefaultPhase(){} // RVA: 0x805A3F0
        public void HandleEventAcrossPropagationPath(){} // RVA: 0x805A840
        public void HandleEventAcrossPropagationPathWithCompatibilityEvent(){} // RVA: 0x805B010
        public void HandleEvent_DefaultActionAtTarget(){} // RVA: 0x805BDC0
        public void HandleEvent_DefaultAction(){} // RVA: 0x805BE40
        public void HandleEvent_TrickleDownCallbacks(){} // RVA: 0x805BEC0
        public void HandleEvent_BubbleUpCallbacks(){} // RVA: 0x805BF00
        public void HandleEvent_TrickleDownHandleEvent(){} // RVA: 0x805BF40
        public void HandleEvent_BubbleUpHandleEvent(){} // RVA: 0x805BFA0
        public void HandleEvent_BubbleUpAllDefaultActions(){} // RVA: 0x805C000
        public void Disabled(){} // RVA: 0x805C0E0
        public void DispatchToFocusedElementOrPanelRoot(){} // RVA: 0x805C120
        public void DispatchToElementUnderPointerOrPanelRoot(){} // RVA: 0x805C440
        public void DispatchToCachedElementUnderPointerOrPanelRoot(){} // RVA: 0x805C590
        public void DispatchToAssignedTarget(){} // RVA: 0x805C700
        public void DefaultDispatch(){} // RVA: 0x8057BC0
        public void DispatchToCapturingElementOrElementUnderPointer(){} // RVA: 0x805C7A0
        public void DispatchToCapturingElement(){} // RVA: 0x805C830
        public void DispatchToPanelRoot(){} // RVA: 0x805C9E0
        public void PropagateToRemainingIMGUIContainers(){} // RVA: 0x805CA90
        public void PropagateToRemainingIMGUIContainerRecursive(){} // RVA: 0x805CB00
    }

    public class EventDispatcher : Object
    {
        public object m_ClickDetector;
        public object k_EventQueuePool;
        public object m_Queue;
        public object _pointerState;
        public object m_GateCount;
        public object m_GateDepth;
        public object k_MaxGateDepth;
        public object k_NumberOfEventsWithStackInfo;
        public object k_NumberOfEventsWithEventInfo;
        public object m_DispatchStackFrame;
        public object m_CurrentEvent;
        public object m_DispatchContexts;
        public object m_Immediate;
        public object _processingEvents;

        // ── Methods ──
        public void get_pointerState(){} // RVA: 0xB700F0
        public void CreateDefault(){} // RVA: 0x8053C80
        public void .ctor(){} // RVA: 0x8053CD0
        public void get_dispatchImmediately(){} // RVA: 0x8054040
        public void set_processingEvents(){} // RVA: 0x1C58C90
        public void Dispatch(){} // RVA: 0x8054060
        public void HandleRecursiveState(){} // RVA: 0x8054350
        public void CloseGate(){} // RVA: 0x8054840
        public void OpenGate(){} // RVA: 0x8054850
        public void ProcessEventQueue(){} // RVA: 0x80549C0
        public void ProcessEvent(){} // RVA: 0x8054DE0
        public void .cctor(){} // RVA: 0x80551F0
    }

    public class EventDispatcherGate : ValueType
    {
        public object m_Dispatcher;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x9A50C0
        public void Dispose(){} // RVA: 0x9A5180
        public void Equals(){} // RVA: 0x9A51A0
        public void GetHashCode(){} // RVA: 0x995E30
    }

    public class EventInterestAttribute : Attribute
    {
        public object eventTypes;
        public object categoryFlags;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x1033F40
    }

    public class EventInterestReflectionUtils : Object
    {
        public object s_DefaultEventInterests;
        public object s_EventCategories;

        // ── Methods ──
        public void GetDefaultEventInterests(){} // RVA: 0x7F2DD60
        public void ComputeDefaultEventInterests(){} // RVA: 0x7F2E0E0
        public void GetEventCategory(){} // RVA: 0x7F2E3B0
        public void .cctor(){} // RVA: 0x7F2E650
    }

    public class ExecuteCommandEvent : CommandEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x8056250
        public void .ctor(){} // RVA: 0x8056340
    }

}