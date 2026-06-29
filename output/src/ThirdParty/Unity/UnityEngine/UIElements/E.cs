// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 92
// Methods: 848

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class EasingFunction : ValueType
    {
        // ── Methods ──
        public void get_mode(){} // RVA: 0x7A765F070
        public void .ctor(){} // RVA: 0x7A76134D0
        public void op_Implicit(){} // RVA: 0x7AA56E580
        public void op_Equality(){} // RVA: 0x7AEEFE800
        public void Equals(){} // RVA: 0x7A7F06870
        public void ToString(){} // RVA: 0x7A7F068F0
        public void GetHashCode(){} // RVA: 0x7A79EAED0
    }

    public class EasingFunction[] : Array
    {
        // ── Methods ──
        public void System.Collections.Generic.IList`1.Insert(){} // RVA: 0x7AA2E28D0
        public void System.Collections.Generic.IList`1.RemoveAt(){} // RVA: 0x7ADCBB890
        public void System.Collections.Generic.IList`1.IndexOf(){} // RVA: 0x7AA2D0BC0
        public void System.Collections.Generic.IList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IList`1.set_Item(){} // RVA: 0x7AA2E4410
        public void System.Collections.Generic.ICollection`1.get_Count(){} // RVA: 0x7ADCB85C0
        public void System.Collections.Generic.ICollection`1.get_IsReadOnly(){} // RVA: 0x7A81BD750
        public void System.Collections.Generic.ICollection`1.Clear(){} // RVA: 0x7ADCBB840
        public void System.Collections.Generic.ICollection`1.Add(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Remove(){} // RVA: 0x7AA250040
        public void System.Collections.Generic.ICollection`1.Contains(){} // RVA: 0x7AA27F870
        public void System.Collections.Generic.ICollection`1.CopyTo(){} // RVA: 0x7AA29DBF0
        public void System.Collections.Generic.IEnumerable`1.GetEnumerator(){} // RVA: 0x7AA29DC80
        public void System.Collections.Generic.IReadOnlyList`1.get_Item(){} // RVA: 0x7AA29EBF0
        public void System.Collections.Generic.IReadOnlyCollection`1.get_Count(){} // RVA: 0x7ADCB85C0
    }

    public class ElementUnderPointer : Object
    {
        // ── Methods ──
        public void GetTopElementUnderPointer(){} // RVA: 0x7AE8C8950
        public void SetElementUnderPointer(){} // RVA: 0x7AF1C5E30
        public void GetEventPointerPosition(){} // RVA: 0x7AF1C5CF0
        public void SetTemporaryElementUnderPointer(){} // RVA: 0x7AF1C5DF0
        public void CommitElementUnderPointers(){} // RVA: 0x7AF1C61B0
        public void .ctor(){} // RVA: 0x7AF1C6FD0
    }

    public class EnumField : BaseField`1
    {
        // ── Methods ──
        public void get_includeObsoleteValues(){} // RVA: 0x7AF0F6550
        public void Initialize(){} // RVA: 0x7AF0F6560
        public void .ctor(){} // RVA: 0x7AF0F6840
        public void Init(){} // RVA: 0x7AF0F6C60
        public void PopulateDataFromType(){} // RVA: 0x7AF0F6D80
        public void SetValueWithoutNotify(){} // RVA: 0x7AF0F6F00
        public void UpdateValueLabel(){} // RVA: 0x7AF0F6FE0
        public void OnPointerDownEvent(){} // RVA: 0x7AF0F7160
        public void OnPointerMoveEvent(){} // RVA: 0x7AF0F71B0
        public void ContainsPointer(){} // RVA: 0x7AF0F7240
        public void ProcessPointerDown(){} // RVA: 0x7A7E18800
        public void OnNavigationSubmit(){} // RVA: 0x7AF0F72D0
        public void ShowMenu(){} // RVA: 0x7AF0F7300
        public void ChangeValueFromMenu(){} // RVA: 0x7AF0F76B0
        public void UpdateMixedValueContent(){} // RVA: 0x7AF0F7750
        public void .cctor(){} // RVA: 0x7AF0F78E0
        public void <ShowMenu>b__33_0(){} // RVA: 0x7AF0F76B0
    }

    public class EnumFieldHelpers : Object
    {
        // ── Methods ──
        public void ExtractValue(){} // RVA: 0x7AF0F5980
        public void .cctor(){} // RVA: 0x7AF0F6010
    }

    public class EventBase : Object
    {
        // ── Methods ──
        public void RegisterEventType(){} // RVA: 0x7AF1C7320
        public void get_eventTypeId(){} // RVA: 0x7A9AA5820
        public void get_eventCategory(){} // RVA: 0x7A8124910
        public void get_timestamp(){} // RVA: 0x7A80DA7B0
        public void set_timestamp(){} // RVA: 0x7A8A224D0
        public void get_eventId(){} // RVA: 0x7A81052C0
        public void set_eventId(){} // RVA: 0x7A8884B10
        public void set_triggerEventId(){} // RVA: 0x7A8669350
        public void SetTriggerEventId(){} // RVA: 0x7A8669350
        public void get_propagation(){} // RVA: 0x7A8133100
        public void set_propagation(){} // RVA: 0x7A8133110
        public void get_path(){} // RVA: 0x7A8292C30
        public void set_path(){} // RVA: 0x7A8296DE0
        public void get_lifeCycleStatus(){} // RVA: 0x7A8178B30
        public void set_lifeCycleStatus(){} // RVA: 0x7A8178B40
        public void PreDispatch(){} // RVA: 0x7AE50A3E0
        public void PostDispatch(){} // RVA: 0x7AF1C7370
        public void get_bubbles(){} // RVA: 0x7AF1C73A0
        public void get_tricklesDown(){} // RVA: 0x7AF1C73B0
        public void get_bubblesOrTricklesDown(){} // RVA: 0x7AF1C73C0
        public void get_skipDisabledElements(){} // RVA: 0x7AF1C73D0
        public void set_skipDisabledElements(){} // RVA: 0x7AF1C73E0
        public void get_ignoreCompositeRoots(){} // RVA: 0x7AF1C7400
        public void set_ignoreCompositeRoots(){} // RVA: 0x7AF1C7410
        public void get_leafTarget(){} // RVA: 0x7A8152D80
        public void set_leafTarget(){} // RVA: 0x7A8152D90
        public void get_target(){} // RVA: 0x7AEF67190
        public void set_target(){} // RVA: 0x7AF1C7430
        public void get_skipElements(){} // RVA: 0x7A81A0050
        public void Skip(){} // RVA: 0x7AF1C74F0
        public void get_isPropagationStopped(){} // RVA: 0x7AF1C75A0
        public void set_isPropagationStopped(){} // RVA: 0x7AF1C75B0
        public void StopPropagation(){} // RVA: 0x7AF1C75D0
        public void get_isImmediatePropagationStopped(){} // RVA: 0x7AF1C75E0
        public void set_isImmediatePropagationStopped(){} // RVA: 0x7AF1C75F0
        public void StopImmediatePropagation(){} // RVA: 0x7AF1C7610
        public void get_isDefaultPrevented(){} // RVA: 0x7AF1C7620
        public void set_isDefaultPrevented(){} // RVA: 0x7AF1C7630
        public void PreventDefault(){} // RVA: 0x7AF1C7650
        public void get_propagationPhase(){} // RVA: 0x7A83562E0
        public void set_propagationPhase(){} // RVA: 0x7A8355940
        public void get_currentTarget(){} // RVA: 0x7AEF672E0
        public void set_currentTarget(){} // RVA: 0x7AF1C7660
        public void get_dispatch(){} // RVA: 0x7AF1C77E0
        public void set_dispatch(){} // RVA: 0x7AF1C77F0
        public void MarkReceivedByDispatcher(){} // RVA: 0x7AF1C7810
        public void get_dispatched(){} // RVA: 0x7AF1C78A0
        public void set_dispatched(){} // RVA: 0x7AF1C78B0
        public void get_processed(){} // RVA: 0x7AF1C78D0
        public void set_processed(){} // RVA: 0x7AF1C78E0
        public void get_processedByFocusController(){} // RVA: 0x7AF1C7900
        public void set_processedByFocusController(){} // RVA: 0x7AF1C7910
        public void get_stopDispatch(){} // RVA: 0x7AF1C7930
        public void set_stopDispatch(){} // RVA: 0x7AF1C7940
        public void get_propagateToIMGUI(){} // RVA: 0x7AF1C7960
        public void set_propagateToIMGUI(){} // RVA: 0x7AF1C7970
        public void get_imguiEventIsValid(){} // RVA: 0x7AF1C7990
        public void set_imguiEventIsValid(){} // RVA: 0x7AF1C79A0
        public void get_imguiEvent(){} // RVA: 0x7AF1C79C0
        public void set_imguiEvent(){} // RVA: 0x7AF1C79D0
        public void get_originalMousePosition(){} // RVA: 0x7AF1C7B80
        public void set_originalMousePosition(){} // RVA: 0x7AD89C580
        public void Init(){} // RVA: 0x7AF1C7BA0
        public void LocalInit(){} // RVA: 0x7AF1C7BB0
        public void .ctor(){} // RVA: 0x7AF1C7F20
        public void get_pooled(){} // RVA: 0x7AF1C8060
        public void set_pooled(){} // RVA: 0x7AF1C8070
        public void Acquire(){} // RVA: 0x7A7E18770
        public void Dispose(){} // RVA: 0x7A7E18770
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7A7E18830
        public void .ctor(){} // RVA: 0x7A7E18770
        public void TypeId(){} // RVA: 0x7A7E006B0
        public void Init(){} // RVA: 0x7A7E18770
        public void GetPooled(){} // RVA: 0x7A8051B10
        public void ReleasePooled(){} // RVA: 0x7A8051B10
        public void Acquire(){} // RVA: 0x7A7E18770
        public void Dispose(){} // RVA: 0x7A7E18770
        public void get_eventTypeId(){} // RVA: 0x7A7E00680
        public void .cctor(){} // RVA: 0x7A7E187D0
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventBase`1 : EventBase
    {
        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7AB0FDA70
        public void .ctor(){} // RVA: 0x7AB0FDB70
        public void TypeId(){} // RVA: 0x7AB0FDD00
        public void Init(){} // RVA: 0x7AB0FDDA0
        public void GetPooled(){} // RVA: 0x7AB0FDF80
        public void ReleasePooled(){} // RVA: 0x7AB0FE020
        public void Acquire(){} // RVA: 0x7AB0FE130
        public void Dispose(){} // RVA: 0x7AB0FE140
        public void get_eventTypeId(){} // RVA: 0x7AB0FE2D0
        public void .cctor(){} // RVA: 0x7AB0FE350
    }

    public class EventCallbackFunctorBase : Object
    {
        // ── Methods ──
        public void get_phase(){} // RVA: 0x7A8124910
        public void get_invokePolicy(){} // RVA: 0x7A8668BC0
        public void .ctor(){} // RVA: 0x7AC226C00
        public void Invoke(){} // RVA: 0x7A7E1D590
        public void IsEquivalentTo(){} // RVA: 0x7A7E03410
        public void PhaseMatches(){} // RVA: 0x7AF1C8090
    }

    public class EventCallbackFunctor`1 : EventCallbackFunctorBase
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1E220
        public void Invoke(){} // RVA: 0x7A7E1D590
        public void IsEquivalentTo(){} // RVA: 0x7A7E03410
    }

    public class EventCallbackFunctor`2 : EventCallbackFunctorBase
    {
        // ── Methods ──
        public void get_userArgs(){} // RVA: 0x7A8051B10
        public void set_userArgs(){} // RVA: 0x7A8051B10
        public void .ctor(){} // RVA: 0x7A8051B10
        public void Invoke(){} // RVA: 0x7A7E1D590
        public void IsEquivalentTo(){} // RVA: 0x7A7E03410
    }

    public class EventCallbackList : Object
    {
        // ── Methods ──
        public void get_trickleDownCallbackCount(){} // RVA: 0x7A83782A0
        public void set_trickleDownCallbackCount(){} // RVA: 0x7A84385B0
        public void get_bubbleUpCallbackCount(){} // RVA: 0x7A9739200
        public void set_bubbleUpCallbackCount(){} // RVA: 0x7A9746990
        public void .ctor(){} // RVA: 0x7AF1C8560
        public void Contains(){} // RVA: 0x7AF1C8640
        public void Find(){} // RVA: 0x7AF1C8660
        public void Remove(){} // RVA: 0x7AF1C8790
        public void Add(){} // RVA: 0x7AF1C88F0
        public void AddRange(){} // RVA: 0x7AF1C89B0
        public void get_Count(){} // RVA: 0x7AF1C8B70
        public void get_Item(){} // RVA: 0x7AF1C8BC0
        public void Clear(){} // RVA: 0x7AF1C8C40
    }

    public class EventCallbackListPool : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7AF1C80C0
        public void Release(){} // RVA: 0x7AF1C8310
        public void .ctor(){} // RVA: 0x7AF1C83D0
    }

    public class EventCallbackRegistry : Object
    {
        // ── Methods ──
        public void GetCallbackList(){} // RVA: 0x7AF1C8CB0
        public void ReleaseCallbackList(){} // RVA: 0x7AF1C8D20
        public void .ctor(){} // RVA: 0x7AF036640
        public void GetCallbackListForWriting(){} // RVA: 0x7AF1C8E30
        public void GetCallbackListForReading(){} // RVA: 0x7AF1C8F60
        public void UnregisterCallback(){} // RVA: 0x7A7E039E0
        public void RegisterCallback(){} // RVA: 0x7A8051B10
        public void InvokeCallbacks(){} // RVA: 0x7AF1C9100
        public void HasTrickleDownHandlers(){} // RVA: 0x7AF1C9330
        public void HasBubbleHandlers(){} // RVA: 0x7AF1C9350
        public void .cctor(){} // RVA: 0x7AF1C9370
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DFE0
        public void Invoke(){} // RVA: 0x7A8051B10
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81577F0
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A81577F0
    }

    public class EventCallback`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7E1DFE0
        public void Invoke(){} // RVA: 0x7A8051B10
    }

    public class EventCategoryAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
    }

    public class EventDebugger : Object
    {
        // ── Methods ──
        public void LogPropagationPaths(){} // RVA: 0x7A80D7310
    }

    public class EventDebuggerLogCall : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A75F4910
        public void Dispose(){} // RVA: 0x7A75F4910
    }

    public class EventDebuggerLogExecuteDefaultAction : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A75F4910
        public void Dispose(){} // RVA: 0x7A75F4910
    }

    public class EventDebuggerLogIMGUICall : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A75F4910
        public void Dispose(){} // RVA: 0x7A75F4910
    }

    public class EventDispatchUtilities : Object
    {
        // ── Methods ──
        public void PropagateEvent(){} // RVA: 0x7AF1CA570
        public void HandleEventAcrossPropagationPath(){} // RVA: 0x7AF1CA6D0
        public void PropagateToIMGUIContainer(){} // RVA: 0x7AF1CAFB0
        public void ExecuteDefaultAction(){} // RVA: 0x7AF1CB480
    }

    public class EventDispatcher : Object
    {
        // ── Methods ──
        public void get_pointerState(){} // RVA: 0x7A8105330
        public void CreateForRuntime(){} // RVA: 0x7AF1C2C90
        public void .ctor(){} // RVA: 0x7AF1C2CF0
        public void get_dispatchImmediately(){} // RVA: 0x7AF1C3100
        public void set_processingEvents(){} // RVA: 0x7A83F3AC0
        public void Dispatch(){} // RVA: 0x7AF1C3120
        public void CloseGate(){} // RVA: 0x7AF1C33F0
        public void OpenGate(){} // RVA: 0x7AF1C3400
        public void ProcessEventQueue(){} // RVA: 0x7AF1C3480
        public void ProcessEvent(){} // RVA: 0x7AF1C38A0
        public void ApplyDispatchingStrategies(){} // RVA: 0x7AF1C3F40
        public void .cctor(){} // RVA: 0x7AF1C4230
    }

    public class EventDispatcherGate : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A7F02200
        public void Dispose(){} // RVA: 0x7A7F022C0
        public void Equals(){} // RVA: 0x7A7F022D0
        public void GetHashCode(){} // RVA: 0x7A7EFE5B0
    }

    public class EventInterestAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A84385B0
    }

    public class EventInterestReflectionUtils : Object
    {
        // ── Methods ──
        public void GetDefaultEventInterests(){} // RVA: 0x7AF107090
        public void ComputeDefaultEventInterests(){} // RVA: 0x7AF107330
        public void GetEventCategory(){} // RVA: 0x7AF1075E0
        public void .cctor(){} // RVA: 0x7AF107870
    }

    public class ExecuteCommandEvent : CommandEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7AF1C5680
        public void .ctor(){} // RVA: 0x7AF1C5770
    }

}