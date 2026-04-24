// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 9
// Methods: 132

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class EnumField : BaseField`1
    {
        public object includeObsoleteValues; // 0x440
        public bool m_IncludeObsoleteValues; // 0x448
        public ÎÏÌÎÎÎÌÌÌ.yle.get_minWidth m_TextElement; // 0x450
        public ÎÏÌÎÎÎÌÌÌ.omLeftRadius m_ArrowElement; // 0x458
        public oseCount m_EnumData; // 0x460
        public ormation<ÎÏÌÎÎÎÌÌÌ.op> createMenuCallback; // 0x4A0
        public string ussClassName;
        public string textUssClassName; // 0x8
        public string arrowUssClassName; // 0x10
        public string labelUssClassName; // 0x18
        public string inputUssClassName; // 0x20

        // ── Methods ──
        public void get_includeObsoleteValues(){} // RVA: 0x7FFD54ECDB00
        public void Initialize(){} // RVA: 0x7FFD54ECDB10
        public void .ctor(){} // RVA: 0x7FFD54ECDDF0 | overloaded x2
        public void Init(){} // RVA: 0x7FFD54ECE210 | overloaded x2
        public void PopulateDataFromType(){} // RVA: 0x7FFD54ECE330
        public void SetValueWithoutNotify(){} // RVA: 0x7FFD54ECE4B0
        public void UpdateValueLabel(){} // RVA: 0x7FFD54ECE590
        public void OnPointerDownEvent(){} // RVA: 0x7FFD54ECE720
        public void OnPointerMoveEvent(){} // RVA: 0x7FFD54ECE770
        public void ContainsPointer(){} // RVA: 0x7FFD54ECE800
        public void ProcessPointerDown(){} // RVA: 0x7FFD4E090A40
        public void OnNavigationSubmit(){} // RVA: 0x7FFD54ECE890
        public void ShowMenu(){} // RVA: 0x7FFD54ECE8C0
        public void ChangeValueFromMenu(){} // RVA: 0x7FFD54ECEC50
        public void UpdateMixedValueContent(){} // RVA: 0x7FFD54ECECF0
        public void .cctor(){} // RVA: 0x7FFD54ECEE80
        public void <ShowMenu>b__33_0(){} // RVA: 0x7FFD54ECEC50
    }

    public class EventBase : Object
    {
        public long eventTypeId;
        public ÎÏÌÎÎÎÌÌÌ.onal eventCategory; // 0x10
        public ulong timestamp; // 0x8
        public long eventId; // 0x18
        public ulong triggerEventId; // 0x20
        public ulong propagation; // 0x28
        public tifyChange path; // 0x30
        public ÎÏÌÎÎÎÌÌÌ.lassName lifeCycleStatus; // 0x38
        public esiredWidth bubbles; // 0x40
        public ÎÏÌÎÎÎÌÌÌ.lumnsWidth tricklesDown; // 0x48
        public ÎÏÌÎÎÎÌÌÌ.lumnsWidth bubblesOrTricklesDown; // 0x50
        public URA.woDigitYearMax<ÎÏÌÎÎÎÌÌÌ.lumnsWidth> skipDisabledElements; // 0x58
        public ÎÏÌÎÎÎÌÌÌ.lumnChanged ignoreCompositeRoots; // 0x60
        public ÎÏÌÎÎÎÌÌÌ.lumnsWidth leafTarget; // 0x68
        public 5EC78E8E02279FB1266932E3468A575B0EB9818985DBE9468B991CCE target; // 0x70
        public tionX skipElements; // 0x78

        // ── Methods ──
        public void RegisterEventType(){} // RVA: 0x7FFD54F9F900
        public void get_eventTypeId(){} // RVA: 0x7FFD4FBEC900
        public void get_eventCategory(){} // RVA: 0x7FFD4E38E5C0
        public void get_timestamp(){} // RVA: 0x7FFD4E3447C0
        public void set_timestamp(){} // RVA: 0x7FFD4ECB20D0
        public void get_eventId(){} // RVA: 0x7FFD4E36F0C0
        public void set_eventId(){} // RVA: 0x7FFD4EB2BEE0
        public void set_triggerEventId(){} // RVA: 0x7FFD4E7F3BF0
        public void SetTriggerEventId(){} // RVA: 0x7FFD4E7F3BF0
        public void get_propagation(){} // RVA: 0x7FFD4E39CCD0
        public void set_propagation(){} // RVA: 0x7FFD4E39CCE0
        public void get_path(){} // RVA: 0x7FFD4E5F0140
        public void set_path(){} // RVA: 0x7FFD4E5F0C20
        public void get_lifeCycleStatus(){} // RVA: 0x7FFD4E3E2080
        public void set_lifeCycleStatus(){} // RVA: 0x7FFD4E3E2090
        public void PreDispatch(){} // RVA: 0x7FFD4F30A090 | overloaded x2
        public void PostDispatch(){} // RVA: 0x7FFD54F9F950 | overloaded x2
        public void get_bubbles(){} // RVA: 0x7FFD54F9F980
        public void get_tricklesDown(){} // RVA: 0x7FFD54F9F990
        public void get_bubblesOrTricklesDown(){} // RVA: 0x7FFD54F9F9A0
        public void get_skipDisabledElements(){} // RVA: 0x7FFD54F9F9B0
        public void set_skipDisabledElements(){} // RVA: 0x7FFD54F9F9C0
        public void get_ignoreCompositeRoots(){} // RVA: 0x7FFD54F9F9E0
        public void set_ignoreCompositeRoots(){} // RVA: 0x7FFD54F9F9F0
        public void get_leafTarget(){} // RVA: 0x7FFD4E3BC730
        public void set_leafTarget(){} // RVA: 0x7FFD4E3BC740
        public void get_target(){} // RVA: 0x7FFD54D3F8D0
        public void set_target(){} // RVA: 0x7FFD54F9FA10
        public void get_skipElements(){} // RVA: 0x7FFD4E409500
        public void Skip(){} // RVA: 0x7FFD54F9FAD0
        public void get_isPropagationStopped(){} // RVA: 0x7FFD54F9FB80
        public void set_isPropagationStopped(){} // RVA: 0x7FFD54F9FB90
        public void StopPropagation(){} // RVA: 0x7FFD54F9FBB0
        public void get_isImmediatePropagationStopped(){} // RVA: 0x7FFD54F9FBC0
        public void set_isImmediatePropagationStopped(){} // RVA: 0x7FFD54F9FBD0
        public void StopImmediatePropagation(){} // RVA: 0x7FFD54F9FBF0
        public void get_isDefaultPrevented(){} // RVA: 0x7FFD54F9FC00
        public void set_isDefaultPrevented(){} // RVA: 0x7FFD54F9FC10
        public void PreventDefault(){} // RVA: 0x7FFD54F9FC30
        public void get_propagationPhase(){} // RVA: 0x7FFD4E558C20
        public void set_propagationPhase(){} // RVA: 0x7FFD4E558C10
        public void get_currentTarget(){} // RVA: 0x7FFD54D3FA20
        public void set_currentTarget(){} // RVA: 0x7FFD54F9FC40
        public void get_dispatch(){} // RVA: 0x7FFD54F9FDC0
        public void set_dispatch(){} // RVA: 0x7FFD54F9FDD0
        public void MarkReceivedByDispatcher(){} // RVA: 0x7FFD54F9FDF0
        public void get_dispatched(){} // RVA: 0x7FFD54F9FE80
        public void set_dispatched(){} // RVA: 0x7FFD54F9FE90
        public void get_processed(){} // RVA: 0x7FFD54F9FEB0
        public void set_processed(){} // RVA: 0x7FFD54F9FEC0
        public void get_processedByFocusController(){} // RVA: 0x7FFD54F9FEE0
        public void set_processedByFocusController(){} // RVA: 0x7FFD54F9FEF0
        public void get_stopDispatch(){} // RVA: 0x7FFD54F9FF10
        public void set_stopDispatch(){} // RVA: 0x7FFD54F9FF20
        public void get_propagateToIMGUI(){} // RVA: 0x7FFD54F9FF40
        public void set_propagateToIMGUI(){} // RVA: 0x7FFD54F9FF50
        public void get_imguiEventIsValid(){} // RVA: 0x7FFD54F9FF70
        public void set_imguiEventIsValid(){} // RVA: 0x7FFD54F9FF80
        public void get_imguiEvent(){} // RVA: 0x7FFD54F9FFA0
        public void set_imguiEvent(){} // RVA: 0x7FFD54F9FFB0
        public void get_originalMousePosition(){} // RVA: 0x7FFD54FA0160
        public void set_originalMousePosition(){} // RVA: 0x7FFD53666500
        public void Init(){} // RVA: 0x7FFD54FA0180
        public void LocalInit(){} // RVA: 0x7FFD54FA0190
        public void .ctor(){} // RVA: 0x7FFD54FA0500
        public void get_pooled(){} // RVA: 0x7FFD54FA0640
        public void set_pooled(){} // RVA: 0x7FFD54FA0650
        public void Acquire(){} // RVA: 0x7FFD4E090980
        public void Dispose(){} // RVA: 0x7FFD4E090980
    }

    public class EventBase`1 : EventBase
    {
        public long eventTypeId;
        public ÎÏÌÎÎÎÌÌÌ.gContentId<T1717595984> s_Pool; // 0x8
        public int m_RefCount; // 0x80
        public ÎÏÌÎÎÎÌÌÌ.onal EventCategory; // 0x10

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x7FFD5106BB80
        public void .ctor(){} // RVA: 0x7FFD5106BC80
        public void TypeId(){} // RVA: 0x7FFD5106BE10
        public void Init(){} // RVA: 0x7FFD5106BEB0
        public void GetPooled(){} // RVA: 0x7FFD5106C090 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x7FFD5106C130
        public void Acquire(){} // RVA: 0x7FFD5106C240
        public void Dispose(){} // RVA: 0x7FFD5106C250
        public void get_eventTypeId(){} // RVA: 0x7FFD5106C3E0
        public void .cctor(){} // RVA: 0x7FFD5106C460
    }

    public class EventCallbackFunctorBase : Object
    {
        public ÎÏÌÎÎÎÌÌÌ.StretchableColumns phase; // 0x10
        public ÎÏÌÎÎÎÌÌÌ.equested invokePolicy; // 0x14

        // ── Methods ──
        public void get_phase(){} // RVA: 0x7FFD4E38E5C0
        public void get_invokePolicy(){} // RVA: 0x7FFD4E7F5A20
        public void .ctor(){} // RVA: 0x7FFD5210C5A0
        public void Invoke(){} // RVA: 0x7FFD4E097970
        public void IsEquivalentTo(){}
        public void PhaseMatches(){} // RVA: 0x7FFD54FA0670
    }

    public class EventCallbackFunctor`1 : EventCallbackFunctorBase
    {
        public ÎÏÌÎÎÎÌÌÌ.Header<T1717595616> m_Callback;
        public long m_EventTypeId;

        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E097970
        public void IsEquivalentTo(){}
    }

    public class EventCallbackFunctor`2 : EventCallbackFunctorBase
    {
        public ÎÏÌÎÎÎÌÌÌ.der<T1717595632,T1717595648> userArgs;
        public long m_EventTypeId;
        public T1717595648 <userArgs>k__BackingField;

        // ── Methods ──
        public void get_userArgs(){} // RVA: 0x7FFD4E2ADC40
        public void set_userArgs(){} // RVA: 0x7FFD4E2ADC40
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void Invoke(){} // RVA: 0x7FFD4E097970
        public void IsEquivalentTo(){}
    }

    public class EventCallbackRegistry : Object
    {
        public ÎÏÌÎÎÎÌÌÌ.mnRemoved s_ListPool;
        public ÎÏÌÎÎÎÌÌÌ.quiresLayoutUpdate m_Callbacks; // 0x10
        public ÎÏÌÎÎÎÌÌÌ.quiresLayoutUpdate m_TemporaryCallbacks; // 0x18
        public int m_IsInvoking; // 0x20

        // ── Methods ──
        public void GetCallbackList(){} // RVA: 0x7FFD54FA1270
        public void ReleaseCallbackList(){} // RVA: 0x7FFD54FA12E0
        public void .ctor(){} // RVA: 0x7FFD54E0E4A0
        public void GetCallbackListForWriting(){} // RVA: 0x7FFD54FA13F0
        public void GetCallbackListForReading(){} // RVA: 0x7FFD54FA1520
        public void UnregisterCallback(){} // RVA: 0x7FFD4E07C920 | overloaded x2
        public void RegisterCallback(){} // RVA: 0x7FFD4E2ADC40 | overloaded x2
        public void InvokeCallbacks(){} // RVA: 0x7FFD54FA16B0
        public void HasTrickleDownHandlers(){} // RVA: 0x7FFD54FA1900
        public void HasBubbleHandlers(){} // RVA: 0x7FFD54FA1920
        public void .cctor(){} // RVA: 0x7FFD54FA1940
    }

    public class EventCallback`1 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

    public class EventCallback`2 : MulticastDelegate
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x7FFD4E2ADC40
    }

}