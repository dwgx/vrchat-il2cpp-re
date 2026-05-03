// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 25
// Methods: 205

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class EasingFunction : ValueType
    {
        public 0x6651A23C m_Mode; // 0x10

        // ── Methods ──
        public void get_mode(){} // RVA: 0x7FFE826F4220
        public void .ctor(){} // RVA: 0x7FFE815BF990
        public void op_Implicit(){} // RVA: 0x7FFE834AD820
        public void op_Equality(){} // RVA: 0x7FFE87C606D0
        public void Equals(){} // RVA: 0x7FFE87F80E00 | overloaded x2
        public void ToString(){} // RVA: 0x7FFE87F80E80
        public void GetHashCode(){} // RVA: 0x7FFE8733C3B0
    }

    public class ElementUnderPointer : Object
    {
        // ── Methods ──
        public void GetTopElementUnderPointer(){} // RVA: 0x7FFE876177D0 | overloaded x2
        public void SetElementUnderPointer(){} // RVA: 0x7FFE87F26CB0 | overloaded x3
        public void GetEventPointerPosition(){} // RVA: 0x7FFE87F26B70
        public void SetTemporaryElementUnderPointer(){} // RVA: 0x7FFE87F26C70
        public void CommitElementUnderPointers(){} // RVA: 0x7FFE87F27030
        public void .ctor(){} // RVA: 0x7FFE87F27E60
    }

    public class EnumField : BaseField`1
    {
        public System.Type m_EnumType; // 0x440

        // ── Methods ──
        public void get_includeObsoleteValues(){} // RVA: 0x7FFE87E563A0
        public void Initialize(){} // RVA: 0x7FFE87E563B0
        public void .ctor(){} // RVA: 0x7FFE87E56690 | overloaded x2
        public void Init(){} // RVA: 0x7FFE87E56AB0 | overloaded x2
        public void PopulateDataFromType(){} // RVA: 0x7FFE87E56BD0
        public void SetValueWithoutNotify(){} // RVA: 0x7FFE87E56D50
        public void UpdateValueLabel(){} // RVA: 0x7FFE87E56E30
        public void OnPointerDownEvent(){} // RVA: 0x7FFE87E56FC0
        public void OnPointerMoveEvent(){} // RVA: 0x7FFE87E57010
        public void ContainsPointer(){} // RVA: 0x7FFE87E570A0
        public void ProcessPointerDown(){} // RVA: 0x7FFE80E460A0
        public void OnNavigationSubmit(){} // RVA: 0x7FFE87E57130
        public void ShowMenu(){} // RVA: 0x7FFE87E57160
        public void ChangeValueFromMenu(){} // RVA: 0x7FFE87E574F0
        public void UpdateMixedValueContent(){} // RVA: 0x7FFE87E57590
        public void .cctor(){} // RVA: 0x7FFE87E57720
        public void <ShowMenu>b__33_0(){} // RVA: 0x7FFE87E574F0
    }

    public class EnumFieldHelpers : Object
    {
        // ── Methods ──
        public void ExtractValue(){} // RVA: 0x7FFE87E559C0
        public void .cctor(){} // RVA: 0x7FFE87E56010
    }

    public class EventBase : Object
    {
        public long s_LastTypeId;
        public 0x6651F934 _eventCategory; // 0x10
        public ulong s_NextEventId; // 0x8
        public long _timestamp; // 0x18
        public ulong _eventId; // 0x20
        public ulong _triggerEventId; // 0x28
        public 0x665149E4 _propagation; // 0x30
        public UnityEngine.UIElements.PropagationPaths _path; // 0x38
        public 0x66514A3C _lifeCycleStatus; // 0x40
        public UnityEngine.UIElements.IEventHandler _leafTarget; // 0x48
        public UnityEngine.UIElements.IEventHandler m_Target; // 0x50
        public System.Collections.Generic.List`1<UnityEngine.UIElements.IEventHandler> _skipElements; // 0x58
        public 0x6651548C _propagationPhase; // 0x60
        public UnityEngine.UIElements.IEventHandler m_CurrentTarget; // 0x68
        public UnityEngine.Event m_ImguiEvent; // 0x70
        public UnityEngine.Vector2 _originalMousePosition; // 0x78
        public long s_TypeId;
        public UnityEngine.UIElements.ObjectPool`1<T> s_Pool;
        public int m_RefCount;
        public 0x6651F934 EventCategory;
        public long s_TypeId;
        public UnityEngine.UIElements.ObjectPool`1<UnityEngine.UIElements.ChangeEvent`1<bool>> s_Pool; // 0x8
        public int m_RefCount; // 0x80
        public 0x6651F934 EventCategory; // 0x10
        public object field_24; // 0x598
        public object field_25; // 0x599
        public object field_26; // 0x59A
        public object field_27; // 0x59B
        public object field_28; // 0xBECB
        public object field_29; // 0xBEEA
        public object field_30; // 0xBECB

        // ── Methods ──
        public void RegisterEventType(){} // RVA: 0x7FFE87F281B0
        public void get_eventTypeId(){} // RVA: 0x7FFE82A34CA0
        public void get_eventCategory(){} // RVA: 0x7FFE811485C0
        public void get_timestamp(){} // RVA: 0x7FFE810FE7C0
        public void set_timestamp(){} // RVA: 0x7FFE819EA910
        public void get_eventId(){} // RVA: 0x7FFE811290C0
        public void set_eventId(){} // RVA: 0x7FFE81859C50
        public void set_triggerEventId(){} // RVA: 0x7FFE8164D390
        public void SetTriggerEventId(){} // RVA: 0x7FFE8164D390
        public void get_propagation(){} // RVA: 0x7FFE81156CD0
        public void set_propagation(){} // RVA: 0x7FFE81156CE0
        public void get_path(){} // RVA: 0x7FFE8143BA80
        public void set_path(){} // RVA: 0x7FFE81437330
        public void get_lifeCycleStatus(){} // RVA: 0x7FFE8119C080
        public void set_lifeCycleStatus(){} // RVA: 0x7FFE8119C090
        public void PreDispatch(){} // RVA: 0x7FFE8725AEB0 | overloaded x2
        public void PostDispatch(){} // RVA: 0x7FFE87F28200 | overloaded x2
        public void get_bubbles(){} // RVA: 0x7FFE87F28230
        public void get_tricklesDown(){} // RVA: 0x7FFE87F28240
        public void get_bubblesOrTricklesDown(){} // RVA: 0x7FFE87F28250
        public void get_skipDisabledElements(){} // RVA: 0x7FFE87F28260
        public void set_skipDisabledElements(){} // RVA: 0x7FFE87F28270
        public void get_ignoreCompositeRoots(){} // RVA: 0x7FFE87F28290
        public void set_ignoreCompositeRoots(){} // RVA: 0x7FFE87F282A0
        public void get_leafTarget(){} // RVA: 0x7FFE81176730
        public void set_leafTarget(){} // RVA: 0x7FFE81176740
        public void get_target(){} // RVA: 0x7FFE87CC8170
        public void set_target(){} // RVA: 0x7FFE87F282C0
        public void get_skipElements(){} // RVA: 0x7FFE811C3500
        public void Skip(){} // RVA: 0x7FFE87F28380
        public void get_isPropagationStopped(){} // RVA: 0x7FFE87F28430
        public void set_isPropagationStopped(){} // RVA: 0x7FFE87F28440
        public void StopPropagation(){} // RVA: 0x7FFE87F28460
        public void get_isImmediatePropagationStopped(){} // RVA: 0x7FFE87F28470
        public void set_isImmediatePropagationStopped(){} // RVA: 0x7FFE87F28480
        public void StopImmediatePropagation(){} // RVA: 0x7FFE87F284A0
        public void get_isDefaultPrevented(){} // RVA: 0x7FFE87F284B0
        public void set_isDefaultPrevented(){} // RVA: 0x7FFE87F284C0
        public void PreventDefault(){} // RVA: 0x7FFE87F284E0
        public void get_propagationPhase(){} // RVA: 0x7FFE8139EA30
        public void set_propagationPhase(){} // RVA: 0x7FFE8139E520
        public void get_currentTarget(){} // RVA: 0x7FFE87CC82C0
        public void set_currentTarget(){} // RVA: 0x7FFE87F284F0
        public void get_dispatch(){} // RVA: 0x7FFE87F28670
        public void set_dispatch(){} // RVA: 0x7FFE87F28680
        public void MarkReceivedByDispatcher(){} // RVA: 0x7FFE87F286A0
        public void get_dispatched(){} // RVA: 0x7FFE87F28730
        public void set_dispatched(){} // RVA: 0x7FFE87F28740
        public void get_processed(){} // RVA: 0x7FFE87F28760
        public void set_processed(){} // RVA: 0x7FFE87F28770
        public void get_processedByFocusController(){} // RVA: 0x7FFE87F28790
        public void set_processedByFocusController(){} // RVA: 0x7FFE87F287A0
        public void get_stopDispatch(){} // RVA: 0x7FFE87F287C0
        public void set_stopDispatch(){} // RVA: 0x7FFE87F287D0
        public void get_propagateToIMGUI(){} // RVA: 0x7FFE87F287F0
        public void set_propagateToIMGUI(){} // RVA: 0x7FFE87F28800
        public void get_imguiEventIsValid(){} // RVA: 0x7FFE87F28820
        public void set_imguiEventIsValid(){} // RVA: 0x7FFE87F28830
        public void get_imguiEvent(){} // RVA: 0x7FFE87F28850
        public void set_imguiEvent(){} // RVA: 0x7FFE87F28860
        public void get_originalMousePosition(){} // RVA: 0x7FFE87F28A10
        public void set_originalMousePosition(){} // RVA: 0x7FFE865EFE40
        public void Init(){} // RVA: 0x7FFE87F28A30
        public void LocalInit(){} // RVA: 0x7FFE87F28A40
        public void .ctor(){} // RVA: 0x7FFE87F28DB0
        public void get_pooled(){} // RVA: 0x7FFE87F28EF0
        public void set_pooled(){} // RVA: 0x7FFE87F28F00
        public void Acquire(){} // RVA: 0x7FFE80E45FE0
        public void Dispose(){} // RVA: 0x7FFE80E45FE0
    }

    public class EventBase`1 : EventBase
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7FFE83F83290
        public void .ctor(){} // RVA: 0x7FFE83F83390
        public void TypeId(){} // RVA: 0x7FFE83F83520
        public void Init(){} // RVA: 0x7FFE83F835C0
        public void GetPooled(){} // RVA: 0x7FFE83F837A0 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x7FFE83F83840
        public void Acquire(){} // RVA: 0x7FFE83F83950
        public void Dispose(){} // RVA: 0x7FFE83F83960
        public void get_eventTypeId(){} // RVA: 0x7FFE83F83AF0
        public void .cctor(){} // RVA: 0x7FFE83F83B70
    }

    public class EventCallbackFunctorBase : Object
    {
        public 0x66514DAC _phase; // 0x10
        public 0x66514E04 _invokePolicy; // 0x14

        // ── Methods ──
        public void get_phase(){} // RVA: 0x7FFE811485C0
        public void get_invokePolicy(){} // RVA: 0x7FFE8164B230
        public void .ctor(){} // RVA: 0x7FFE85072A80
        public void Invoke(){} // RVA: 0x7FFE80E4D070
        public void IsEquivalentTo(){}
        public void PhaseMatches(){} // RVA: 0x7FFE87F28F20
    }

    public class EventCallbackFunctor`1 : EventCallbackFunctorBase
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE80E4D070
        public void IsEquivalentTo(){}
    }

    public class EventCallbackFunctor`2 : EventCallbackFunctorBase
    {
        public UnityEngine.UIElements.EventCallback`2<U,T> m_Callback;

        // ── Methods ──
        public void get_userArgs(){} // RVA: 0x7FFE810A1420
        public void set_userArgs(){} // RVA: 0x7FFE810A1420
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void Invoke(){} // RVA: 0x7FFE80E4D070
        public void IsEquivalentTo(){}
    }

    public class EventCallbackList : Object
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.EventCallbackFunctorBase> m_List; // 0x10
        public int _trickleDownCallbackCount; // 0x18
        public int _bubbleUpCallbackCount; // 0x1C
        public object field_3; // 0x203

        // ── Methods ──
        public void get_trickleDownCallbackCount(){} // RVA: 0x7FFE813DB630
        public void set_trickleDownCallbackCount(){} // RVA: 0x7FFE8144DF00
        public void get_bubbleUpCallbackCount(){} // RVA: 0x7FFE82707EE0
        public void set_bubbleUpCallbackCount(){} // RVA: 0x7FFE82717690
        public void .ctor(){} // RVA: 0x7FFE87F293F0 | overloaded x2
        public void Contains(){} // RVA: 0x7FFE87F294D0
        public void Find(){} // RVA: 0x7FFE87F294F0
        public void Remove(){} // RVA: 0x7FFE87F29610
        public void Add(){} // RVA: 0x7FFE87F29770
        public void AddRange(){} // RVA: 0x7FFE87F29830
        public void get_Count(){} // RVA: 0x7FFE87F299E0
        public void get_Item(){} // RVA: 0x7FFE87F29A30
        public void Clear(){} // RVA: 0x7FFE87F29AB0
    }

    public class EventCallbackListPool : Object
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x7FFE87F28F50
        public void Release(){} // RVA: 0x7FFE87F291A0
        public void .ctor(){} // RVA: 0x7FFE87F29260
    }

    public class EventCallbackRegistry : Object
    {
        // ── Methods ──
        public void GetCallbackList(){} // RVA: 0x7FFE87F29B20
        public void ReleaseCallbackList(){} // RVA: 0x7FFE87F29B90
        public void .ctor(){} // RVA: 0x7FFE87D96D40
        public void GetCallbackListForWriting(){} // RVA: 0x7FFE87F29CA0
        public void GetCallbackListForReading(){} // RVA: 0x7FFE87F29DD0
        public void UnregisterCallback(){} // RVA: 0x7FFE80E31D70 | overloaded x2
        public void RegisterCallback(){} // RVA: 0x7FFE810A1420 | overloaded x2
        public void InvokeCallbacks(){} // RVA: 0x7FFE87F29F60
        public void HasTrickleDownHandlers(){} // RVA: 0x7FFE87F2A1B0
        public void HasBubbleHandlers(){} // RVA: 0x7FFE87F2A1D0
        public void .cctor(){} // RVA: 0x7FFE87F2A1F0
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class EventCallback`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFE810A1420
    }

    public class EventCategoryAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
    }

    public class EventDebugger : Object
    {
        // ── Methods ──
        public void LogPropagationPaths(){} // RVA: 0x7FFE810FB310
    }

    public class EventDebuggerLogCall : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE810FB310
    }

    public class EventDebuggerLogExecuteDefaultAction : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE810FB310
    }

    public class EventDebuggerLogIMGUICall : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE810FB310
    }

    public class EventDispatchUtilities : Object
    {
        // ── Methods ──
        public void PropagateEvent(){} // RVA: 0x7FFE87F2B430
        public void HandleEventAcrossPropagationPath(){} // RVA: 0x7FFE87F2B5A0
        public void PropagateToIMGUIContainer(){} // RVA: 0x7FFE87F2BE70
        public void ExecuteDefaultAction(){} // RVA: 0x7FFE87F2C330
    }

    public class EventDispatcher : Object
    {
        public UnityEngine.UIElements.ClickDetector m_ClickDetector; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.IEventDispatchingStrategy> m_DispatchingStrategies; // 0x18
        public UnityEngine.UIElements.ObjectPool`1<System.Collections.Generic.Queue`1<EventRecord>> k_EventQueuePool;

        // ── Methods ──
        public void get_pointerState(){} // RVA: 0x7FFE81129130
        public void CreateForRuntime(){} // RVA: 0x7FFE87F23AD0
        public void .ctor(){} // RVA: 0x7FFE87F23B30
        public void get_dispatchImmediately(){} // RVA: 0x7FFE87F23F40
        public void set_processingEvents(){} // RVA: 0x7FFE814641E0
        public void Dispatch(){} // RVA: 0x7FFE87F23F60
        public void CloseGate(){} // RVA: 0x7FFE87F24210
        public void OpenGate(){} // RVA: 0x7FFE87F24220
        public void ProcessEventQueue(){} // RVA: 0x7FFE87F242A0
        public void ProcessEvent(){} // RVA: 0x7FFE87F246E0
        public void ApplyDispatchingStrategies(){} // RVA: 0x7FFE87F24DA0
        public void .cctor(){} // RVA: 0x7FFE87F25080
    }

    public class EventDispatcherGate : ValueType
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE87F238A0
        public void Dispose(){} // RVA: 0x7FFE87F23960
        public void Equals(){} // RVA: 0x7FFE87F239F0 | overloaded x2
        public void GetHashCode(){} // RVA: 0x7FFE87E6A980
    }

    public class EventInterestAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8144DF00 | overloaded x2
    }

    public class EventInterestReflectionUtils : Object
    {
        // ── Methods ──
        public void GetDefaultEventInterests(){} // RVA: 0x7FFE87E66FE0
        public void ComputeDefaultEventInterests(){} // RVA: 0x7FFE87E67280
        public void GetEventCategory(){} // RVA: 0x7FFE87E67510
        public void .cctor(){} // RVA: 0x7FFE87E677A0
    }

    public class ExecuteCommandEvent : CommandEventBase`1
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x7FFE87F264E0
        public void .ctor(){} // RVA: 0x7FFE87F265D0
    }

}