// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 20
// Methods: 253

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class EnumField : BaseField`1
    {
        public object m_TextElement; // 0x31750030
        public object createMenuCallback; // 0x31750030
        public object arrowUssClassName; // 0x31750030
        public object values; // 0x83AEBD70
        public object names; // 0x83AEBD70

        // ── Original Methods ──
        public void get_includeObsoleteValues(){} // RVA: 0x7ffaaf4cfa60
        public void Initialize(){} // RVA: 0x7ffaaf4cfa70
        public void .ctor(){} // RVA: 0x7ffaaf4cfd50
        public void .ctor(){} // RVA: 0x7ffaaf4cfd50
        public void Init(){} // RVA: 0x7ffaaf4d0170
        public void Init(){} // RVA: 0x7ffaaf4d0170
        public void PopulateDataFromType(){} // RVA: 0x7ffaaf4d0290
        public void UpdateValueLabel(){} // RVA: 0x7ffaaf4d04f0
        public void OnPointerDownEvent(){} // RVA: 0x7ffaaf4d0680
        public void OnPointerMoveEvent(){} // RVA: 0x7ffaaf4d06d0
        public void ContainsPointer(){} // RVA: 0x7ffaaf4d0760
        public void ProcessPointerDown(){} // RVA: 0x7ffaa8660d80
        public void OnNavigationSubmit(){} // RVA: 0x7ffaaf4d07f0
        public void ShowMenu(){} // RVA: 0x7ffaaf4d0820
        public void ChangeValueFromMenu(){} // RVA: 0x7ffaaf4d0bb0
        public void UpdateMixedValueContent(){} // RVA: 0x7ffaaf4d0c50
        public void .cctor(){} // RVA: 0x7ffaaf4d0de0
        public void <ShowMenu>b__33_0(){} // RVA: 0x7ffaaf4d0bb0
        // ── Binary Analysis Named ──
        public void SetValueWithoutNotify(){} // RVA: 0x7ffaaf4d0410
    }

    public class EventBase : Object
    {
        public object s_NextEventId; // 0x30B29B60
        public object _triggerEventId; // 0x30B29B60, was: <triggerEventId>k__BackingFiel
        public object _lifeCycleStatus; // 0x30B29B60, was: <lifeCycleStatus>k__BackingFie
        public object _skipElements; // 0x30B29B60, was: <skipElements>k__BackingField
        public object m_ImguiEvent; // 0x30B29B60
        public object s_Pool; // 0x30B29930
        public object s_TypeId; // 0x83AFBD48
        public object EventCategory; // 0x83AFBD48

        // ── Original Methods ──
        public void RegisterEventType(){} // RVA: 0x7ffaaf5a1870
        public void get_eventTypeId(){} // RVA: 0x7ffaaa1d47f0
        public void get_eventCategory(){} // RVA: 0x7ffaa897f5c0
        public void get_timestamp(){} // RVA: 0x7ffaa89357c0
        public void set_timestamp(){} // RVA: 0x7ffaa92bb750
        public void get_eventId(){} // RVA: 0x7ffaa89600c0
        public void set_eventId(){} // RVA: 0x7ffaa9137320
        public void set_triggerEventId(){} // RVA: 0x7ffaa8e049c0
        public void get_propagation(){} // RVA: 0x7ffaa898dcd0
        public void set_propagation(){} // RVA: 0x7ffaa898dce0
        public void get_path(){} // RVA: 0x7ffaa8bf45b0
        public void set_path(){} // RVA: 0x7ffaa8bf45c0
        public void get_lifeCycleStatus(){} // RVA: 0x7ffaa89d3080
        public void set_lifeCycleStatus(){} // RVA: 0x7ffaa89d3090
        public void PreDispatch(){} // RVA: 0x7ffaae8d4a00
        public void PreDispatch(){} // RVA: 0x7ffaae8d4a00
        public void PostDispatch(){} // RVA: 0x7ffaaf5a18c0
        public void PostDispatch(){} // RVA: 0x7ffaaf5a18c0
        public void get_bubbles(){} // RVA: 0x7ffaaf5a18f0
        public void get_tricklesDown(){} // RVA: 0x7ffaaf5a1900
        public void get_bubblesOrTricklesDown(){} // RVA: 0x7ffaaf5a1910
        public void get_skipDisabledElements(){} // RVA: 0x7ffaaf5a1920
        public void set_skipDisabledElements(){} // RVA: 0x7ffaaf5a1930
        public void get_ignoreCompositeRoots(){} // RVA: 0x7ffaaf5a1950
        public void set_ignoreCompositeRoots(){} // RVA: 0x7ffaaf5a1960
        public void get_leafTarget(){} // RVA: 0x7ffaa89ad730
        public void set_leafTarget(){} // RVA: 0x7ffaa89ad740
        public void get_target(){} // RVA: 0x7ffaaf341830
        public void set_target(){} // RVA: 0x7ffaaf5a1980
        public void get_skipElements(){} // RVA: 0x7ffaa89fa500
        public void Skip(){} // RVA: 0x7ffaaf5a1a40
        public void get_isPropagationStopped(){} // RVA: 0x7ffaaf5a1af0
        public void set_isPropagationStopped(){} // RVA: 0x7ffaaf5a1b00
        public void StopPropagation(){} // RVA: 0x7ffaaf5a1b20
        public void get_isImmediatePropagationStopped(){} // RVA: 0x7ffaaf5a1b30
        public void set_isImmediatePropagationStopped(){} // RVA: 0x7ffaaf5a1b40
        public void StopImmediatePropagation(){} // RVA: 0x7ffaaf5a1b60
        public void get_isDefaultPrevented(){} // RVA: 0x7ffaaf5a1b70
        public void set_isDefaultPrevented(){} // RVA: 0x7ffaaf5a1b80
        public void PreventDefault(){} // RVA: 0x7ffaaf5a1ba0
        public void get_propagationPhase(){} // RVA: 0x7ffaa8b645f0
        public void set_propagationPhase(){} // RVA: 0x7ffaa8b64600
        public void get_currentTarget(){} // RVA: 0x7ffaaf341980
        public void set_currentTarget(){} // RVA: 0x7ffaaf5a1bb0
        public void get_dispatch(){} // RVA: 0x7ffaaf5a1d30
        public void set_dispatch(){} // RVA: 0x7ffaaf5a1d40
        public void MarkReceivedByDispatcher(){} // RVA: 0x7ffaaf5a1d60
        public void get_dispatched(){} // RVA: 0x7ffaaf5a1df0
        public void set_dispatched(){} // RVA: 0x7ffaaf5a1e00
        public void get_processed(){} // RVA: 0x7ffaaf5a1e20
        public void set_processed(){} // RVA: 0x7ffaaf5a1e30
        public void get_processedByFocusController(){} // RVA: 0x7ffaaf5a1e50
        public void set_processedByFocusController(){} // RVA: 0x7ffaaf5a1e60
        public void get_stopDispatch(){} // RVA: 0x7ffaaf5a1e80
        public void set_stopDispatch(){} // RVA: 0x7ffaaf5a1e90
        public void get_propagateToIMGUI(){} // RVA: 0x7ffaaf5a1eb0
        public void set_propagateToIMGUI(){} // RVA: 0x7ffaaf5a1ec0
        public void get_imguiEventIsValid(){} // RVA: 0x7ffaaf5a1ee0
        public void set_imguiEventIsValid(){} // RVA: 0x7ffaaf5a1ef0
        public void get_imguiEvent(){} // RVA: 0x7ffaaf5a1f10
        public void set_imguiEvent(){} // RVA: 0x7ffaaf5a1f20
        public void get_originalMousePosition(){} // RVA: 0x7ffaaf5a20d0
        public void set_originalMousePosition(){} // RVA: 0x7ffaadc676b0
        public void Init(){} // RVA: 0x7ffaaf5a20f0
        public void LocalInit(){} // RVA: 0x7ffaaf5a2100
        public void .ctor(){} // RVA: 0x7ffaaf5a2470
        public void get_pooled(){} // RVA: 0x7ffaaf5a25b0
        public void set_pooled(){} // RVA: 0x7ffaaf5a25c0
        public void Acquire(){} // RVA: 0x7ffaa8660cc0
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        // ── Binary Analysis Named ──
        public void SetTriggerEventId(){} // RVA: 0x7ffaa8e049c0
    }

    public class EventBase`1 : EventBase
    {
        public object m_RefCount; // 0x302ADC58

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6548b0
        public void TypeId(){} // RVA: 0x7ffaab654a40
        public void Init(){} // RVA: 0x7ffaab654ae0
        public void ReleasePooled(){} // RVA: 0x7ffaab654d60
        public void Acquire(){} // RVA: 0x7ffaab654e70
        public void Dispose(){} // RVA: 0x7ffaab654e80
        public void get_eventTypeId(){} // RVA: 0x7ffaab655010
        public void .cctor(){} // RVA: 0x7ffaab655090
        // ── Binary Analysis Named ──
        public void SetCreateFunction(){} // RVA: 0x7ffaab6547b0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
    }

    public class EventBase`1 : EventBase
    {
        public object m_RefCount; // 0x30B29930
        public object s_Pool; // 0x83AFBD48

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void TypeId(){} // RVA: 0x7ffaa8648dd0
        public void Init(){} // RVA: 0x7ffaa8660cc0
        public void ReleasePooled(){} // RVA: 0x7ffaa887e5c0
        public void Acquire(){} // RVA: 0x7ffaa8660cc0
        public void Dispose(){} // RVA: 0x7ffaa8660cc0
        public void get_eventTypeId(){} // RVA: 0x7ffaa86491d0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void SetCreateFunction(){} // RVA: 0x7ffaa8660d50
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
        public void GetPooled(){} // RVA: 0x7ffaa887e5c0
    }

    public class EventBase`1 : EventBase
    {
        public object m_RefCount; // 0x30D1A600
        public object eventTypeId; // 0x170001FF

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6548b0
        public void TypeId(){} // RVA: 0x7ffaab654a40
        public void Init(){} // RVA: 0x7ffaab654ae0
        public void ReleasePooled(){} // RVA: 0x7ffaab654d60
        public void Acquire(){} // RVA: 0x7ffaab654e70
        public void Dispose(){} // RVA: 0x7ffaab654e80
        public void get_eventTypeId(){} // RVA: 0x7ffaab655010
        public void .cctor(){} // RVA: 0x7ffaab655090
        // ── Binary Analysis Named ──
        public void SetCreateFunction(){} // RVA: 0x7ffaab6547b0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
    }

    public class EventBase`1 : EventBase
    {
        public object m_RefCount; // 0x30DDDAA0
        public object eventTypeId; // 0x170001FF

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6548b0
        public void TypeId(){} // RVA: 0x7ffaab654a40
        public void Init(){} // RVA: 0x7ffaab654ae0
        public void ReleasePooled(){} // RVA: 0x7ffaab654d60
        public void Acquire(){} // RVA: 0x7ffaab654e70
        public void Dispose(){} // RVA: 0x7ffaab654e80
        public void get_eventTypeId(){} // RVA: 0x7ffaab655010
        public void .cctor(){} // RVA: 0x7ffaab655090
        // ── Binary Analysis Named ──
        public void SetCreateFunction(){} // RVA: 0x7ffaab6547b0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
    }

    public class EventBase`1 : EventBase
    {
        public object m_RefCount; // 0x30FD1F08
        public object eventTypeId; // 0x170001FF

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6548b0
        public void TypeId(){} // RVA: 0x7ffaab654a40
        public void Init(){} // RVA: 0x7ffaab654ae0
        public void ReleasePooled(){} // RVA: 0x7ffaab654d60
        public void Acquire(){} // RVA: 0x7ffaab654e70
        public void Dispose(){} // RVA: 0x7ffaab654e80
        public void get_eventTypeId(){} // RVA: 0x7ffaab655010
        public void .cctor(){} // RVA: 0x7ffaab655090
        // ── Binary Analysis Named ──
        public void SetCreateFunction(){} // RVA: 0x7ffaab6547b0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
    }

    public class EventBase`1 : EventBase
    {
        public object m_RefCount; // 0x3113D400
        public object eventTypeId; // 0x170001FF

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6548b0
        public void TypeId(){} // RVA: 0x7ffaab654a40
        public void Init(){} // RVA: 0x7ffaab654ae0
        public void ReleasePooled(){} // RVA: 0x7ffaab654d60
        public void Acquire(){} // RVA: 0x7ffaab654e70
        public void Dispose(){} // RVA: 0x7ffaab654e80
        public void get_eventTypeId(){} // RVA: 0x7ffaab655010
        public void .cctor(){} // RVA: 0x7ffaab655090
        // ── Binary Analysis Named ──
        public void SetCreateFunction(){} // RVA: 0x7ffaab6547b0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
    }

    public class EventBase`1 : EventBase
    {
        public object m_RefCount; // 0x3123FE88
        public object eventTypeId; // 0x170001FF

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6548b0
        public void TypeId(){} // RVA: 0x7ffaab654a40
        public void Init(){} // RVA: 0x7ffaab654ae0
        public void ReleasePooled(){} // RVA: 0x7ffaab654d60
        public void Acquire(){} // RVA: 0x7ffaab654e70
        public void Dispose(){} // RVA: 0x7ffaab654e80
        public void get_eventTypeId(){} // RVA: 0x7ffaab655010
        public void .cctor(){} // RVA: 0x7ffaab655090
        // ── Binary Analysis Named ──
        public void SetCreateFunction(){} // RVA: 0x7ffaab6547b0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
    }

    public class EventBase`1 : EventBase
    {
        public object m_RefCount; // 0x312402F8
        public object eventTypeId; // 0x170001FF

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6548b0
        public void TypeId(){} // RVA: 0x7ffaab654a40
        public void Init(){} // RVA: 0x7ffaab654ae0
        public void ReleasePooled(){} // RVA: 0x7ffaab654d60
        public void Acquire(){} // RVA: 0x7ffaab654e70
        public void Dispose(){} // RVA: 0x7ffaab654e80
        public void get_eventTypeId(){} // RVA: 0x7ffaab655010
        public void .cctor(){} // RVA: 0x7ffaab655090
        // ── Binary Analysis Named ──
        public void SetCreateFunction(){} // RVA: 0x7ffaab6547b0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
    }

    public class EventBase`1 : EventBase
    {
        public object m_RefCount; // 0x312405E0
        public object eventTypeId; // 0x170001FF

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6548b0
        public void TypeId(){} // RVA: 0x7ffaab654a40
        public void Init(){} // RVA: 0x7ffaab654ae0
        public void ReleasePooled(){} // RVA: 0x7ffaab654d60
        public void Acquire(){} // RVA: 0x7ffaab654e70
        public void Dispose(){} // RVA: 0x7ffaab654e80
        public void get_eventTypeId(){} // RVA: 0x7ffaab655010
        public void .cctor(){} // RVA: 0x7ffaab655090
        // ── Binary Analysis Named ──
        public void SetCreateFunction(){} // RVA: 0x7ffaab6547b0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
    }

    public class EventBase`1 : EventBase
    {
        public object m_RefCount; // 0x31245160
        public object eventTypeId; // 0x170001FF

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6548b0
        public void TypeId(){} // RVA: 0x7ffaab654a40
        public void Init(){} // RVA: 0x7ffaab654ae0
        public void ReleasePooled(){} // RVA: 0x7ffaab654d60
        public void Acquire(){} // RVA: 0x7ffaab654e70
        public void Dispose(){} // RVA: 0x7ffaab654e80
        public void get_eventTypeId(){} // RVA: 0x7ffaab655010
        public void .cctor(){} // RVA: 0x7ffaab655090
        // ── Binary Analysis Named ──
        public void SetCreateFunction(){} // RVA: 0x7ffaab6547b0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
    }

    public class EventBase`1 : EventBase
    {
        public object m_RefCount; // 0x3129CEA0
        public object eventTypeId; // 0x170001FF

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6548b0
        public void TypeId(){} // RVA: 0x7ffaab654a40
        public void Init(){} // RVA: 0x7ffaab654ae0
        public void ReleasePooled(){} // RVA: 0x7ffaab654d60
        public void Acquire(){} // RVA: 0x7ffaab654e70
        public void Dispose(){} // RVA: 0x7ffaab654e80
        public void get_eventTypeId(){} // RVA: 0x7ffaab655010
        public void .cctor(){} // RVA: 0x7ffaab655090
        // ── Binary Analysis Named ──
        public void SetCreateFunction(){} // RVA: 0x7ffaab6547b0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
    }

    public class EventBase`1 : EventBase
    {
        public object m_RefCount; // 0x313DF598
        public object eventTypeId; // 0x170001FF

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaab6548b0
        public void TypeId(){} // RVA: 0x7ffaab654a40
        public void Init(){} // RVA: 0x7ffaab654ae0
        public void ReleasePooled(){} // RVA: 0x7ffaab654d60
        public void Acquire(){} // RVA: 0x7ffaab654e70
        public void Dispose(){} // RVA: 0x7ffaab654e80
        public void get_eventTypeId(){} // RVA: 0x7ffaab655010
        public void .cctor(){} // RVA: 0x7ffaab655090
        // ── Binary Analysis Named ──
        public void SetCreateFunction(){} // RVA: 0x7ffaab6547b0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
        public void GetPooled(){} // RVA: 0x7ffaab654cc0
    }

    public class EventCallbackFunctorBase : Object
    {
        // ── Original Methods ──
        public void get_phase(){} // RVA: 0x7ffaa897f5c0
        public void get_invokePolicy(){} // RVA: 0x7ffaa8e046c0
        public void .ctor(){} // RVA: 0x7ffaac6fd540
        public void Invoke(){} // RVA: 0x7ffaa8667cb0
        public void IsEquivalentTo(){}
        public void PhaseMatches(){} // RVA: 0x7ffaaf5a25e0
    }

    public class EventCallbackFunctor`1 : EventCallbackFunctorBase
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7ffaa8667cb0
        public void IsEquivalentTo(){}
    }

    public class EventCallbackFunctor`2 : EventCallbackFunctorBase
    {
        public object _userArgs; // 0x30F57540, was: <userArgs>k__BackingField
        public object userArgs; // 0x17000202

        // ── Original Methods ──
        public void get_userArgs(){} // RVA: 0x7ffaa887e5c0
        public void set_userArgs(){} // RVA: 0x7ffaa887e5c0
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void Invoke(){} // RVA: 0x7ffaa8667cb0
        public void IsEquivalentTo(){}
    }

    public class EventCallbackRegistry : Object
    {
        public object m_TemporaryCallbacks; // 0x31751360
        public object .ctor; // 0xB3F6FFF0

        // ── Original Methods ──
        public void ReleaseCallbackList(){} // RVA: 0x7ffaaf5a3250
        public void .ctor(){} // RVA: 0x7ffaaf410400
        public void UnregisterCallback(){} // RVA: 0x7ffaa864cc60
        public void RegisterCallback(){} // RVA: 0x7ffaa887e5c0
        public void RegisterCallback(){} // RVA: 0x7ffaa887e5c0
        public void UnregisterCallback(){} // RVA: 0x7ffaa864cc60
        public void InvokeCallbacks(){} // RVA: 0x7ffaaf5a3620
        public void HasTrickleDownHandlers(){} // RVA: 0x7ffaaf5a3870
        public void HasBubbleHandlers(){} // RVA: 0x7ffaaf5a3890
        public void .cctor(){} // RVA: 0x7ffaaf5a38b0
        // ── Binary Analysis Named ──
        public void GetCallbackList(){} // RVA: 0x7ffaaf5a31e0
        public void GetCallbackListForWriting(){} // RVA: 0x7ffaaf5a3360
        public void GetCallbackListForReading(){} // RVA: 0x7ffaaf5a3490
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7ffaa887e5c0
    }

    public class EventCallback`2 : MulticastDelegate
    {
        // ── Original Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7ffaa887e5c0
    }

}