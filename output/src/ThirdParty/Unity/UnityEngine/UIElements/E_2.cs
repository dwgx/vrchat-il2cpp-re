// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.UIElements
// Classes: 11
// Methods: 37

namespace ThirdParty.Unity.UnityEngine.UIElements
{
    public class EventCategoryAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
    }

    public class EventDebugger
    {
        // ── Methods ──
        public void LogPropagationPaths(){} // RVA: 0x2DD310
    }

    public class EventDebuggerLogCall : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x2DD310
    }

    public class EventDebuggerLogExecuteDefaultAction : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x2DD310
    }

    public class EventDebuggerLogIMGUICall : `
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x2DD310
    }

    public class EventDispatchUtilities
    {
        // ── Methods ──
        public void PropagateEvent(){} // RVA: 0x73EB290
        public void HandleEventAcrossPropagationPath(){} // RVA: 0x73EB400
        public void PropagateToIMGUIContainer(){} // RVA: 0x73EBCD0
        public void ExecuteDefaultAction(){} // RVA: 0x73EC190
    }

    public class EventDispatcher
    {
        public UnityEngine.UIElements.ClickDetector m_ClickDetector; // 0x10
        public System.Collections.Generic.List`1<UnityEngine.UIElements.IEventDispatchingStrategy> m_DispatchingStrategies; // 0x18
        public UnityEngine.UIElements.ObjectPool`1<System.Collections.Generic.Queue`1<EventRecord>> k_EventQueuePool;

        // ── Methods ──
        public void get_pointerState(){} // RVA: 0x30B130
        public void CreateForRuntime(){} // RVA: 0x73E3930
        public void .ctor(){} // RVA: 0x73E3990
        public void get_dispatchImmediately(){} // RVA: 0x73E3DA0
        public void set_processingEvents(){} // RVA: 0x65EEB0
        public void Dispatch(){} // RVA: 0x73E3DC0
        public void CloseGate(){} // RVA: 0x73E4070
        public void OpenGate(){} // RVA: 0x73E4080
        public void ProcessEventQueue(){} // RVA: 0x73E4100
        public void ProcessEvent(){} // RVA: 0x73E4540
        public void ApplyDispatchingStrategies(){} // RVA: 0x73E4C00
        public void .cctor(){} // RVA: 0x73E4EE0
    }

    public class EventDispatcherGate
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x73E3700
        public void Dispose(){} // RVA: 0x73E37C0
        public void Equals(){} // RVA: 0x73E3850 | overloaded x2
        public void GetHashCode(){} // RVA: 0x732A800
    }

    public class EventInterestAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x6374E0 | overloaded x2
    }

    public class EventInterestReflectionUtils
    {
        // ── Methods ──
        public void GetDefaultEventInterests(){} // RVA: 0x7326E60
        public void ComputeDefaultEventInterests(){} // RVA: 0x7327100
        public void GetEventCategory(){} // RVA: 0x7327390
        public void .cctor(){} // RVA: 0x7327620
    }

    public class ExecuteCommandEvent
    {
        // ── Methods ──
        public void .cctor(){} // RVA: 0x73E6340
        public void .ctor(){} // RVA: 0x73E6430
    }

}