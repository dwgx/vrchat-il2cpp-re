// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 100
// Methods: 872

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class EasingFunction
    {
        public 0x6583C298 m_Mode; // 0x10

        // ── Methods ──
        public void get_mode(){} // RVA: 0x19689B0
        public void .ctor(){} // RVA: 0x833580
        public void op_Implicit(){} // RVA: 0x275CDE0
        public void op_Equality(){} // RVA: 0x711FA10
        public void Equals(){} // RVA: 0x7440C60 | overloaded x2
        public void ToString(){} // RVA: 0x7440CE0
        public void GetHashCode(){} // RVA: 0x67FD0D0
    }

    public class ElementUnderPointer
    {
        // ── Methods ──
        public void GetTopElementUnderPointer(){} // RVA: 0x6AD84E0 | overloaded x2
        public void SetElementUnderPointer(){} // RVA: 0x73E6B10 | overloaded x3
        public void GetEventPointerPosition(){} // RVA: 0x73E69D0
        public void SetTemporaryElementUnderPointer(){} // RVA: 0x73E6AD0
        public void CommitElementUnderPointers(){} // RVA: 0x73E6E90
        public void .ctor(){} // RVA: 0x73E7CC0
    }

    public class EnumField
    {
        public System.Type m_EnumType; // 0x440

        // ── Methods ──
        public void get_includeObsoleteValues(){} // RVA: 0x7316220
        public void Initialize(){} // RVA: 0x7316230
        public void .ctor(){} // RVA: 0x7316510 | overloaded x2
        public void Init(){} // RVA: 0x7316930 | overloaded x2
        public void PopulateDataFromType(){} // RVA: 0x7316A50
        public void SetValueWithoutNotify(){} // RVA: 0x7316BD0
        public void UpdateValueLabel(){} // RVA: 0x7316CB0
        public void OnPointerDownEvent(){} // RVA: 0x7316E40
        public void OnPointerMoveEvent(){} // RVA: 0x7316E90
        public void ContainsPointer(){} // RVA: 0x7316F20
        public void ProcessPointerDown(){} // RVA: 0x24B10
        public void OnNavigationSubmit(){} // RVA: 0x7316FB0
        public void ShowMenu(){} // RVA: 0x7316FE0
        public void ChangeValueFromMenu(){} // RVA: 0x7317370
        public void UpdateMixedValueContent(){} // RVA: 0x7317410
        public void .cctor(){} // RVA: 0x73175A0
        public void <ShowMenu>b__33_0(){} // RVA: 0x7317370
    }

    public class EnumFieldHelpers
    {
        // ── Methods ──
        public void ExtractValue(){} // RVA: 0x7315840
        public void .cctor(){} // RVA: 0x7315E90
    }

    public class EventBase
    {
        public long s_LastTypeId;
        public 0x65841990 <eventCategory>k__BackingField; // 0x10
        public ulong s_NextEventId; // 0x8
        public long <timestamp>k__BackingField; // 0x18
        public ulong <eventId>k__BackingField; // 0x20
        public ulong <triggerEventId>k__BackingField; // 0x28
        public 0x65836A40 <propagation>k__BackingField; // 0x30
        public UnityEngine.UIElements.PropagationPaths <path>k__BackingField; // 0x38
        public 0x65836A98 <lifeCycleStatus>k__BackingField; // 0x40
        public UnityEngine.UIElements.IEventHandler <leafTarget>k__BackingField; // 0x48
        public UnityEngine.UIElements.IEventHandler m_Target; // 0x50
        public System.Collections.Generic.List`1<UnityEngine.UIElements.IEventHandler> <skipElements>k__BackingField; // 0x58
        public 0x658374E8 <propagationPhase>k__BackingField; // 0x60
        public UnityEngine.UIElements.IEventHandler m_CurrentTarget; // 0x68
        public UnityEngine.Event m_ImguiEvent; // 0x70
        public UnityEngine.Vector2 <originalMousePosition>k__BackingField; // 0x78

        // ── Methods ──
        public void RegisterEventType(){} // RVA: 0x73E8010
        public void get_eventTypeId(){} // RVA: 0x1CA3200
        public void get_eventCategory(){} // RVA: 0x32A5C0
        public void get_timestamp(){} // RVA: 0x2E07C0
        public void set_timestamp(){} // RVA: 0xC5BE60
        public void get_eventId(){} // RVA: 0x30B0C0
        public void set_eventId(){} // RVA: 0xAE83A0
        public void set_triggerEventId(){} // RVA: 0x8AC650
        public void SetTriggerEventId(){} // RVA: 0x8AC650
        public void get_propagation(){} // RVA: 0x338CD0
        public void set_propagation(){} // RVA: 0x338CE0
        public void get_path(){} // RVA: 0x4976A0
        public void set_path(){} // RVA: 0x49B830
        public void get_lifeCycleStatus(){} // RVA: 0x37E080
        public void set_lifeCycleStatus(){} // RVA: 0x37E090
        public void PreDispatch(){} // RVA: 0x671BFB0 | overloaded x2
        public void PostDispatch(){} // RVA: 0x73E8060 | overloaded x2
        public void get_bubbles(){} // RVA: 0x73E8090
        public void get_tricklesDown(){} // RVA: 0x73E80A0
        public void get_bubblesOrTricklesDown(){} // RVA: 0x73E80B0
        public void get_skipDisabledElements(){} // RVA: 0x73E80C0
        public void set_skipDisabledElements(){} // RVA: 0x73E80D0
        public void get_ignoreCompositeRoots(){} // RVA: 0x73E80F0
        public void set_ignoreCompositeRoots(){} // RVA: 0x73E8100
        public void get_leafTarget(){} // RVA: 0x358730
        public void set_leafTarget(){} // RVA: 0x358740
        public void get_target(){} // RVA: 0x7187FD0
        public void set_target(){} // RVA: 0x73E8120
        public void get_skipElements(){} // RVA: 0x3A5500
        public void Skip(){} // RVA: 0x73E81E0
        public void get_isPropagationStopped(){} // RVA: 0x73E8290
        public void set_isPropagationStopped(){} // RVA: 0x73E82A0
        public void StopPropagation(){} // RVA: 0x73E82C0
        public void get_isImmediatePropagationStopped(){} // RVA: 0x73E82D0
        public void set_isImmediatePropagationStopped(){} // RVA: 0x73E82E0
        public void StopImmediatePropagation(){} // RVA: 0x73E8300
        public void get_isDefaultPrevented(){} // RVA: 0x73E8310
        public void set_isDefaultPrevented(){} // RVA: 0x73E8320
        public void PreventDefault(){} // RVA: 0x73E8340
        public void get_propagationPhase(){} // RVA: 0x59CEC0
        public void set_propagationPhase(){} // RVA: 0x59C530
        public void get_currentTarget(){} // RVA: 0x7188120
        public void set_currentTarget(){} // RVA: 0x73E8350
        public void get_dispatch(){} // RVA: 0x73E84D0
        public void set_dispatch(){} // RVA: 0x73E84E0
        public void MarkReceivedByDispatcher(){} // RVA: 0x73E8500
        public void get_dispatched(){} // RVA: 0x73E8590
        public void set_dispatched(){} // RVA: 0x73E85A0
        public void get_processed(){} // RVA: 0x73E85C0
        public void set_processed(){} // RVA: 0x73E85D0
        public void get_processedByFocusController(){} // RVA: 0x73E85F0
        public void set_processedByFocusController(){} // RVA: 0x73E8600
        public void get_stopDispatch(){} // RVA: 0x73E8620
        public void set_stopDispatch(){} // RVA: 0x73E8630
        public void get_propagateToIMGUI(){} // RVA: 0x73E8650
        public void set_propagateToIMGUI(){} // RVA: 0x73E8660
        public void get_imguiEventIsValid(){} // RVA: 0x73E8680
        public void set_imguiEventIsValid(){} // RVA: 0x73E8690
        public void get_imguiEvent(){} // RVA: 0x73E86B0
        public void set_imguiEvent(){} // RVA: 0x73E86C0
        public void get_originalMousePosition(){} // RVA: 0x73E8870
        public void set_originalMousePosition(){} // RVA: 0x5AAF010
        public void Init(){} // RVA: 0x73E8890
        public void LocalInit(){} // RVA: 0x73E88A0
        public void .ctor(){} // RVA: 0x73E8C10
        public void get_pooled(){} // RVA: 0x73E8D50
        public void set_pooled(){} // RVA: 0x73E8D60
        public void Acquire(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x24A50
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x24AE0
        public void .ctor(){} // RVA: 0x24A50
        public void TypeId(){} // RVA: 0xC960
        public void Init(){} // RVA: 0x24A50
        public void GetPooled(){} // RVA: 0x283FA0 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x283FA0
        public void Acquire(){} // RVA: 0x24A50
        public void Dispose(){} // RVA: 0x24A50
        public void get_eventTypeId(){} // RVA: 0xCD60
        public void .cctor(){} // RVA: 0x24A80
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;

        // ── Methods ──
        public void SetCreateFunction(){} // RVA: 0x3305D00
        public void .ctor(){} // RVA: 0x3305E00
        public void TypeId(){} // RVA: 0x3305F90
        public void Init(){} // RVA: 0x3306030
        public void GetPooled(){} // RVA: 0x3306210 | overloaded x2
        public void ReleasePooled(){} // RVA: 0x33062B0
        public void Acquire(){} // RVA: 0x33063C0
        public void Dispose(){} // RVA: 0x33063D0
        public void get_eventTypeId(){} // RVA: 0x3306560
        public void .cctor(){} // RVA: 0x33065E0
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventBase`1
    {
        public long s_TypeId;
    }

    public class EventCallbackFunctorBase
    {
        public 0x65836E08 <phase>k__BackingField; // 0x10
        public 0x65836E60 <invokePolicy>k__BackingField; // 0x14

        // ── Methods ──
        public void get_phase(){} // RVA: 0x32A5C0
        public void get_invokePolicy(){} // RVA: 0x8ABED0
        public void .ctor(){} // RVA: 0x4438000
        public void Invoke(){} // RVA: 0x2BAA0
        public void IsEquivalentTo(){}
        public void PhaseMatches(){} // RVA: 0x73E8D80
    }

    public class EventCallbackFunctor`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x2BAA0
        public void IsEquivalentTo(){}
    }

    public class EventCallbackFunctor`2
    {
        public UnityEngine.UIElements.EventCallback`2<U,T> m_Callback;

        // ── Methods ──
        public void get_userArgs(){} // RVA: 0x283FA0
        public void set_userArgs(){} // RVA: 0x283FA0
        public void .ctor(){} // RVA: 0x283FA0
        public void Invoke(){} // RVA: 0x2BAA0
        public void IsEquivalentTo(){}
    }

    public class EventCallbackList
    {
        public System.Collections.Generic.List`1<UnityEngine.UIElements.EventCallbackFunctorBase> m_List; // 0x10
        public int <trickleDownCallbackCount>k__BackingField; // 0x18
        public int <bubbleUpCallbackCount>k__BackingField; // 0x1C

        // ── Methods ──
        public void get_trickleDownCallbackCount(){} // RVA: 0x5BED50
        public void set_trickleDownCallbackCount(){} // RVA: 0x6374E0
        public void get_bubbleUpCallbackCount(){} // RVA: 0x197C3B0
        public void set_bubbleUpCallbackCount(){} // RVA: 0x1989FD0
        public void .ctor(){} // RVA: 0x73E9250 | overloaded x2
        public void Contains(){} // RVA: 0x73E9330
        public void Find(){} // RVA: 0x73E9350
        public void Remove(){} // RVA: 0x73E9470
        public void Add(){} // RVA: 0x73E95D0
        public void AddRange(){} // RVA: 0x73E9690
        public void get_Count(){} // RVA: 0x73E9840
        public void get_Item(){} // RVA: 0x73E9890
        public void Clear(){} // RVA: 0x73E9910
    }

    public class EventCallbackListPool
    {
        // ── Methods ──
        public void Get(){} // RVA: 0x73E8DB0
        public void Release(){} // RVA: 0x73E9000
        public void .ctor(){} // RVA: 0x73E90C0
    }

    public class EventCallbackRegistry
    {
        // ── Methods ──
        public void GetCallbackList(){} // RVA: 0x73E9980
        public void ReleaseCallbackList(){} // RVA: 0x73E99F0
        public void .ctor(){} // RVA: 0x7256BA0
        public void GetCallbackListForWriting(){} // RVA: 0x73E9B00
        public void GetCallbackListForReading(){} // RVA: 0x73E9C30
        public void UnregisterCallback(){} // RVA: 0x10840 | overloaded x2
        public void RegisterCallback(){} // RVA: 0x283FA0 | overloaded x2
        public void InvokeCallbacks(){} // RVA: 0x73E9DC0
        public void HasTrickleDownHandlers(){} // RVA: 0x73EA010
        public void HasBubbleHandlers(){} // RVA: 0x73EA030
        public void .cctor(){} // RVA: 0x73EA050
    }

    public class EventCallback`1
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x283FA0
    }

    public class EventCallback`1
    {
    }

    public class EventCallback`1
    {
    }

    public class EventCallback`2
    {
        // ── Methods ──
        public void .ctor(){}
        public void Invoke(){} // RVA: 0x283FA0
    }

}