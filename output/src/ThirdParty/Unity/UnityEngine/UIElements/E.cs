// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 25
// Methods: 205

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class EasingFunction : ValueType
    {
        public 0x6B121318 mode; // 0x10

        // ── Methods ──
        public void get_mode(){} // RVA: 0x7FFAC4420210
        public void .ctor(){} // RVA: 0x7FFAC336D8B0
        public void op_Implicit(){} // RVA: 0x7FFAC51FC020
        public void op_Equality(){} // RVA: 0x7FFAC98B7FA0
        public void Equals(){} // RVA: 0x7FFAC9BD8550 | overloaded x2
        public void ToString(){} // RVA: 0x7FFAC9BD85D0
        public void GetHashCode(){} // RVA: 0x7FFAC8F93F90
    }

    public class ElementUnderPointer : Object
    {
        public UnityEngine.UIElements.VisualElement[] m_PendingTopElementUnderPointer; // 0x10
        public UnityEngine.UIElements.VisualElement[] m_TopElementUnderPointer; // 0x18
        public UnityEngine.UIElements.IPointerEvent[] m_TriggerPointerEvent; // 0x20
        public UnityEngine.UIElements.IMouseEvent[] m_TriggerMouseEvent; // 0x28
        public UnityEngine.Vector2[] m_PickingPointerPositions; // 0x30
        public bool[] m_IsPickingPointerTemporaries; // 0x38

        // ── Methods ──
        public void GetTopElementUnderPointer(){} // RVA: 0x7FFAC926F060 | overloaded x2
        public void SetElementUnderPointer(){} // RVA: 0x7FFAC9B7E400 | overloaded x3
        public void GetEventPointerPosition(){} // RVA: 0x7FFAC9B7E2C0
        public void SetTemporaryElementUnderPointer(){} // RVA: 0x7FFAC9B7E3C0
        public void CommitElementUnderPointers(){} // RVA: 0x7FFAC9B7E780
        public void .ctor(){} // RVA: 0x7FFAC9B7F5B0
    }

    public class EnumField : BaseField`1
    {
        public System.Type includeObsoleteValues; // 0x440
        public bool m_IncludeObsoleteValues; // 0x448
        public UnityEngine.UIElements.TextElement m_TextElement; // 0x450
        public UnityEngine.UIElements.VisualElement m_ArrowElement; // 0x458
        public UnityEngine.EnumData m_EnumData; // 0x460
        public System.Func`1<UnityEngine.UIElements.IGenericMenu> createMenuCallback; // 0x4A0
        public string ussClassName;
        public string textUssClassName; // 0x8
        public string arrowUssClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20

        // ── Methods ──
        public void get_includeObsoleteValues(){} // RVA: 0x7FFAC9AADB00
        public void Initialize(){} // RVA: 0x7FFAC9AADB10
        public void .ctor(){} // RVA: 0x7FFAC9AADDF0 | overloaded x2
        public void Init(){} // RVA: 0x7FFAC9AAE210 | overloaded x2
        public void PopulateDataFromType(){} // RVA: 0x7FFAC9AAE330
        public void SetValueWithoutNotify(){} // RVA: 0x7FFAC9AAE4B0
        public void UpdateValueLabel(){} // RVA: 0x7FFAC9AAE590
        public void OnPointerDownEvent(){} // RVA: 0x7FFAC9AAE720
        public void OnPointerMoveEvent(){} // RVA: 0x7FFAC9AAE770
        public void ContainsPointer(){} // RVA: 0x7FFAC9AAE800
        public void ProcessPointerDown(){} // RVA: 0x7FFAC2C70A40
        public void OnNavigationSubmit(){} // RVA: 0x7FFAC9AAE890
        public void ShowMenu(){} // RVA: 0x7FFAC9AAE8C0
        public void ChangeValueFromMenu(){} // RVA: 0x7FFAC9AAEC50
        public void UpdateMixedValueContent(){} // RVA: 0x7FFAC9AAECF0
        public void .cctor(){} // RVA: 0x7FFAC9AAEE80
        public void <ShowMenu>b__33_0(){} // RVA: 0x7FFAC9AAEC50
    }

    public class EnumFieldHelpers : Object
    {
        public UnityEngine.UIElements.UxmlTypeAttributeDescription`1<System.Enum> type;
        public UnityEngine.UIElements.UxmlStringAttributeDescription value; // 0x8
        public UnityEngine.UIElements.UxmlBoolAttributeDescription includeObsoleteValues; // 0x10

        // ── Methods ──
        public void ExtractValue(){} // RVA: 0x7FFAC9AAD120
        public void .cctor(){} // RVA: 0x7FFAC9AAD770
    }

    public class EventBase : Object
    {
        public long eventTypeId;
        public 0x6B126A10 eventCategory; // 0x10
        public ulong timestamp; // 0x8
        public long eventId; // 0x18
        public ulong triggerEventId; // 0x20
        public ulong propagation; // 0x28
        public 0x6B11BAC0 path; // 0x30
        public UnityEngine.UIElements.PropagationPaths lifeCycleStatus; // 0x38
        public 0x6B11BB18 bubbles; // 0x40
        public UnityEngine.UIElements.IEventHandler tricklesDown; // 0x48
        public UnityEngine.UIElements.IEventHandler bubblesOrTricklesDown; // 0x50
        public System.Collections.Generic.List`1<UnityEngine.UIElements.IEventHandler> skipDisabledElements; // 0x58
        public 0x6B11C568 ignoreCompositeRoots; // 0x60
        public UnityEngine.UIElements.IEventHandler leafTarget; // 0x68
        public UnityEngine.Event target; // 0x70
        public UnityEngine.Vector2 skipElements; // 0x78

        // ── Methods ──
        public void RegisterEventType(){} // RVA: 0x7FFAC9B7F900
        public void get_eventTypeId(){} // RVA: 0x7FFAC47CC900
        public void get_eventCategory(){} // RVA: 0x7FFAC2F6E5C0
        public void get_timestamp(){} // RVA: 0x7FFAC2F247C0
        public void set_timestamp(){} // RVA: 0x7FFAC38920D0
        public void get_eventId(){} // RVA: 0x7FFAC2F4F0C0
        public void set_eventId(){} // RVA: 0x7FFAC370BEE0
        public void set_triggerEventId(){} // RVA: 0x7FFAC33D3BF0
        public void SetTriggerEventId(){} // RVA: 0x7FFAC33D3BF0
        public void get_propagation(){} // RVA: 0x7FFAC2F7CCD0
        public void set_propagation(){} // RVA: 0x7FFAC2F7CCE0
        public void get_path(){} // RVA: 0x7FFAC31D0140
        public void set_path(){} // RVA: 0x7FFAC31D0C20
        public void get_lifeCycleStatus(){} // RVA: 0x7FFAC2FC2080
        public void set_lifeCycleStatus(){} // RVA: 0x7FFAC2FC2090
        public void PreDispatch(){} // RVA: 0x7FFAC3EEA090 | overloaded x2
        public void PostDispatch(){} // RVA: 0x7FFAC9B7F950 | overloaded x2
        public void get_bubbles(){} // RVA: 0x7FFAC9B7F980
        public void get_tricklesDown(){} // RVA: 0x7FFAC9B7F990
        public void get_bubblesOrTricklesDown(){} // RVA: 0x7FFAC9B7F9A0
        public void get_skipDisabledElements(){} // RVA: 0x7FFAC9B7F9B0
        public void set_skipDisabledElements(){} // RVA: 0x7FFAC9B7F9C0
        public void get_ignoreCompositeRoots(){} // RVA: 0x7FFAC9B7F9E0
        public void set_ignoreCompositeRoots(){} // RVA: 0x7FFAC9B7F9F0
        public void get_leafTarget(){} // RVA: 0x7FFAC2F9C730
        public void set_leafTarget(){} // RVA: 0x7FFAC2F9C740
        public void get_target(){} // RVA: 0x7FFAC991F8D0
        public void set_target(){} // RVA: 0x7FFAC9B7FA10
        public void get_skipElements(){} // RVA: 0x7FFAC2FE9500
        public void Skip(){} // RVA: 0x7FFAC9B7FAD0
        public void get_isPropagationStopped(){} // RVA: 0x7FFAC9B7FB80
        public void set_isPropagationStopped(){} // RVA: 0x7FFAC9B7FB90
        public void StopPropagation(){} // RVA: 0x7FFAC9B7FBB0
        public void get_isImmediatePropagationStopped(){} // RVA: 0x7FFAC9B7FBC0
        public void set_isImmediatePropagationStopped(){} // RVA: 0x7FFAC9B7FBD0
        public void StopImmediatePropagation(){} // RVA: 0x7FFAC9B7FBF0
        public void get_isDefaultPrevented(){} // RVA: 0x7FFAC9B7FC00
        public void set_isDefaultPrevented(){} // RVA: 0x7FFAC9B7FC10
        public void PreventDefault(){} // RVA: 0x7FFAC9B7FC30
        public void get_propagationPhase(){} // RVA: 0x7FFAC3138C20
        public void set_propagationPhase(){} // RVA: 0x7FFAC3138C10
        public void get_currentTarget(){} // RVA: 0x7FFAC991FA20
        public void set_currentTarget(){} // RVA: 0x7FFAC9B7FC40
        public void get_dispatch(){} // RVA: 0x7FFAC9B7FDC0
        public void set_dispatch(){} // RVA: 0x7FFAC9B7FDD0
        public void MarkReceivedByDispatcher(){} // RVA: 0x7FFAC9B7FDF0
        public void get_dispatched(){} // RVA: 0x7FFAC9B7FE80
        public void set_dispatched(){} // RVA: 0x7FFAC9B7FE90
        public void get_processed(){} // RVA: 0x7FFAC9B7FEB0
        public void set_processed(){} // RVA: 0x7FFAC9B7FEC0
        public void get_processedByFocusController(){} // RVA: 0x7FFAC9B7FEE0
        public void set_processedByFocusController(){} // RVA: 0x7FFAC9B7FEF0
        public void get_stopDispatch(){} // RVA: 0x7FFAC9B7FF10
        public void set_stopDispatch(){} // RVA: 0x7FFAC9B7FF20
        public void get_propagateToIMGUI(){} // RVA: 0x7FFAC9B7FF40
        public void set_propagateToIMGUI(){} // RVA: 0x7FFAC9B7FF50
        public void get_imguiEventIsValid(){} // RVA: 0x7FFAC9B7FF70
        public void set_imguiEventIsValid(){} // RVA: 0x7FFAC9B7FF80
        public void get_imguiEvent(){} // RVA: 0x7FFAC9B7FFA0
        public void set_imguiEvent(){} // RVA: 0x7FFAC9B7FFB0
        public void get_originalMousePosition(){} // RVA: 0x7FFAC9B80160
        public void set_originalMousePosition(){} // RVA: 0x7FFAC8246500
        public void Init(){} // RVA: 0x7FFAC9B80180
        public void LocalInit(){} // RVA: 0x7FFAC9B80190
        public void .ctor(){} // RVA: 0x7FFAC9B80500
        public void get_pooled(){} // RVA: 0x7FFAC9B80640
        public void set_pooled(){} // RVA: 0x7FFAC9B80650
        public void Acquire(){} // RVA: 0x7FFAC2C70980
        public void Dispose(){} // RVA: 0x7FFAC2C70980
    }

    public class EventBase`1 : EventBase
    {
        public long eventTypeId;
        public UnityEngine.UIElements.ObjectPool`1<UnityEngine.UIElements.ChangeEvent`1<T>> s_Pool; // 0x8
        public int m_RefCount; // 0x80
        public 0x6B126A10 EventCategory; // 0x10

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7FFAC5C4BB80
        public void .ctor(){} // RVA: 0x7FFAC5C4BC80
        public void TypeId(){} // RVA: 0x7FFAC5C4BE10
        public void Init(){} // RVA: 0x7FFAC5C4BEB0
        public void GetPooled(){} // RVA: 0x7FFAC5C4C090 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x7FFAC5C4C130
        public void Acquire(){} // RVA: 0x7FFAC5C4C240
        public void Dispose(){} // RVA: 0x7FFAC5C4C250
        public void get_eventTypeId(){} // RVA: 0x7FFAC5C4C3E0
        public void .cctor(){} // RVA: 0x7FFAC5C4C460
    }

    public class EventCallbackFunctorBase : Object
    {
        public 0x6B11BE88 phase; // 0x10
        public 0x6B11BEE0 invokePolicy; // 0x14

        // ── Methods ──
        public void get_phase(){} // RVA: 0x7FFAC2F6E5C0
        public void get_invokePolicy(){} // RVA: 0x7FFAC33D5A20
        public void .ctor(){} // RVA: 0x7FFAC6CEC5A0
        public void Invoke(){} // RVA: 0x7FFAC2C77970
        public void IsEquivalentTo(){}
        public void PhaseMatches(){} // RVA: 0x7FFAC9B80670
    }

    public class EventCallbackFunctor`1 : EventCallbackFunctorBase
    {
        public UnityEngine.UIElements.EventCallback`1<U> m_Callback;
        public long m_EventTypeId;

        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2C77970
        public void IsEquivalentTo(){}
    }

    public class EventCallbackFunctor`2 : EventCallbackFunctorBase
    {
        public UnityEngine.UIElements.EventCallback`2<U,T> userArgs;
        public long m_EventTypeId;
        public T <userArgs>k__BackingField;

        // ── Methods ──
        public void get_userArgs(){} // RVA: 0x7FFAC2E8DC40
        public void set_userArgs(){} // RVA: 0x7FFAC2E8DC40
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void Invoke(){} // RVA: 0x7FFAC2C77970
        public void IsEquivalentTo(){}
    }

    public class EventCallbackList : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.EventCallbackFunctorBase> trickleDownCallbackCount; // 0x10
        public int bubbleUpCallbackCount; // 0x18
        public int Count; // 0x1C

        // ── Methods ──
        public void get_trickleDownCallbackCount(){} // RVA: 0x7FFAC3157800
        public void set_trickleDownCallbackCount(){} // RVA: 0x7FFAC392CD10
        public void get_bubbleUpCallbackCount(){} // RVA: 0x7FFAC44357F0
        public void set_bubbleUpCallbackCount(){} // RVA: 0x7FFAC44474D0
        public void .ctor(){} // RVA: 0x7FFAC9B80B40 | overloaded x2
        public void Contains(){} // RVA: 0x7FFAC9B80C20
        public void Find(){} // RVA: 0x7FFAC9B80C40
        public void Remove(){} // RVA: 0x7FFAC9B80D60
        public void Add(){} // RVA: 0x7FFAC9B80EC0
        public void AddRange(){} // RVA: 0x7FFAC9B80F80
        public void get_Count(){} // RVA: 0x7FFAC9B81130
        public void get_Item(){} // RVA: 0x7FFAC9B81180
        public void Clear(){} // RVA: 0x7FFAC9B81200
    }

    public class EventCallbackListPool : Object
    {
        public System.Collections.Generic.Stack`1<UnityEngine.UIElements.EventCallbackList> m_Stack; // 0x10

        // ── Methods ──
        public void Get(){} // RVA: 0x7FFAC9B806A0
        public void Release(){} // RVA: 0x7FFAC9B808F0
        public void .ctor(){} // RVA: 0x7FFAC9B809B0
    }

    public class EventCallbackRegistry : Object
    {
        public UnityEngine.UIElements.EventCallbackListPool s_ListPool;
        public UnityEngine.UIElements.EventCallbackList m_Callbacks; // 0x10
        public UnityEngine.UIElements.EventCallbackList m_TemporaryCallbacks; // 0x18
        public int m_IsInvoking; // 0x20

        // ── Methods ──
        public void GetCallbackList(){} // RVA: 0x7FFAC9B81270
        public void ReleaseCallbackList(){} // RVA: 0x7FFAC9B812E0
        public void .ctor(){} // RVA: 0x7FFAC99EE4A0
        public void GetCallbackListForWriting(){} // RVA: 0x7FFAC9B813F0
        public void GetCallbackListForReading(){} // RVA: 0x7FFAC9B81520
        public void UnregisterCallback(){} // RVA: 0x7FFAC2C5C920 | overloaded x2
        public void RegisterCallback(){} // RVA: 0x7FFAC2E8DC40 | overloaded x2
        public void InvokeCallbacks(){} // RVA: 0x7FFAC9B816B0
        public void HasTrickleDownHandlers(){} // RVA: 0x7FFAC9B81900
        public void HasBubbleHandlers(){} // RVA: 0x7FFAC9B81920
        public void .cctor(){} // RVA: 0x7FFAC9B81940
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class EventCallback`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFAC2E8DC40
    }

    public class EventCategoryAttribute : Attribute
    {
        public 0x6B126A10 category; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
    }

    public class EventDebugger : Object
    {
        // ── Methods ──
        public void LogPropagationPaths(){} // RVA: 0x7FFAC2F21310
    }

    public class EventDebuggerLogCall : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC2F21310
    }

    public class EventDebuggerLogExecuteDefaultAction : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC2F21310
    }

    public class EventDebuggerLogIMGUICall : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC2F21310
    }

    public class EventDispatchUtilities : Object
    {
        // ── Methods ──
        public void PropagateEvent(){} // RVA: 0x7FFAC9B82B80
        public void HandleEventAcrossPropagationPath(){} // RVA: 0x7FFAC9B82CF0
        public void PropagateToIMGUIContainer(){} // RVA: 0x7FFAC9B835C0
        public void ExecuteDefaultAction(){} // RVA: 0x7FFAC9B83A80
    }

    public class EventDispatcher : Object
    {
        public UnityEngine.UIElements.ClickDetector pointerState; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.IEventDispatchingStrategy> dispatchImmediately; // 0x18
        public UnityEngine.UIElements.ObjectPool`1<System.Collections.Generic.Queue`1<EventRecord>> processingEvents;
        public System.Collections.Generic.Queue`1<EventRecord> m_Queue; // 0x20
        public UnityEngine.UIElements.PointerDispatchState <pointerState>k__BackingField; // 0x28
        public uint m_GateCount; // 0x30
        public System.Collections.Generic.Stack`1<DispatchContext> m_DispatchContexts; // 0x38
        public UnityEngine.UIElements.IEventDispatchingStrategy[] s_EditorStrategies; // 0x8
        public bool m_Immediate; // 0x40
        public bool <processingEvents>k__BackingField; // 0x41

        // ── Methods ──
        public void get_pointerState(){} // RVA: 0x7FFAC2F4F130
        public void CreateForRuntime(){} // RVA: 0x7FFAC9B7B220
        public void .ctor(){} // RVA: 0x7FFAC9B7B280
        public void get_dispatchImmediately(){} // RVA: 0x7FFAC9B7B690
        public void set_processingEvents(){} // RVA: 0x7FFAC31D8A10
        public void Dispatch(){} // RVA: 0x7FFAC9B7B6B0
        public void CloseGate(){} // RVA: 0x7FFAC9B7B960
        public void OpenGate(){} // RVA: 0x7FFAC9B7B970
        public void ProcessEventQueue(){} // RVA: 0x7FFAC9B7B9F0
        public void ProcessEvent(){} // RVA: 0x7FFAC9B7BE30
        public void ApplyDispatchingStrategies(){} // RVA: 0x7FFAC9B7C4F0
        public void .cctor(){} // RVA: 0x7FFAC9B7C7D0
    }

    public class EventDispatcherGate : ValueType
    {
        public UnityEngine.UIElements.EventDispatcher m_Dispatcher; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC9B7AFF0
        public void Dispose(){} // RVA: 0x7FFAC9B7B0B0
        public void Equals(){} // RVA: 0x7FFAC9B7B140 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFAC9AC20E0
    }

    public class EventInterestAttribute : Attribute
    {
        public System.Type[] eventTypes; // 0x10
        public 0x6B126A68 categoryFlags; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC392CD10 | overloaded x2
    }

    public class EventInterestReflectionUtils : Object
    {
        public System.Collections.Generic.Dictionary`2<System.Type,DefaultEventInterests> s_DefaultEventInterests;
        public System.Collections.Generic.Dictionary`2<System.Type,0x6B126A10> s_EventCategories; // 0x8

        // ── Methods ──
        public void GetDefaultEventInterests(){} // RVA: 0x7FFAC9ABE740
        public void ComputeDefaultEventInterests(){} // RVA: 0x7FFAC9ABE9E0
        public void GetEventCategory(){} // RVA: 0x7FFAC9ABEC70
        public void .cctor(){} // RVA: 0x7FFAC9ABEF00
    }

    public class ExecuteCommandEvent : CommandEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFAC9B7DC30
        public void .ctor(){} // RVA: 0x7FFAC9B7DD20
    }

}