// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics.Tracing
// Classes: 6
// Methods: 42

namespace ThirdParty.DotNet.System.Diagnostics.Tracing
{
    public class EventAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D900C0
        public void set_EventId(){} // RVA: 0x7FFAF2D900C0
        public void set_Level(){} // RVA: 0x7FFAF335C660
        public void set_Keywords(){} // RVA: 0x7FFAF370BE60
        public void set_Opcode(){} // RVA: 0x7FFAF344E0D0
        public void set_Message(){} // RVA: 0x7FFAF2D8EE90
        public void set_Task(){} // RVA: 0x7FFAF2DE8CE0
    }

    public class EventListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
        public void EnableEvents(){} // RVA: 0x7FFAF2D8D310
        public void OnEventSourceCreated(){} // RVA: 0x7FFAF2D8D310
        public void OnEventWritten(){} // RVA: 0x7FFAF2D8D310
        public void Dispose(){} // RVA: 0x7FFAF2D8D310
    }

    public class EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF88A8300 | overloaded x4
        public void Finalize(){} // RVA: 0x7FFAF855C950
        public void get_Guid(){} // RVA: 0x7FFAF88A8360
        public void set_Name(){} // RVA: 0x7FFAF2D8EE30
        public void set_Settings(){} // RVA: 0x7FFAF30E74E0
        public void IsEnabled(){} // RVA: 0x7FFAF2D8D320 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAF2D8D310 | overloaded x2
        public void WriteEvent(){} // RVA: 0x7FFAF88A8C70 | overloaded x11
        public void WriteEventCore(){} // RVA: 0x7FFAF2D8D310
    }

    public class EventSourceAttribute
    {
        // ── Methods ──
        public void set_Guid(){} // RVA: 0x7FFAF2D8EE30
        public void set_Name(){} // RVA: 0x7FFAF2DF3E80
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

    public class EventWrittenEventArgs
    {
        // ── Methods ──
        public void get_EventId(){} // RVA: 0x7FFAF2DDA5C0
        public void get_Payload(){} // RVA: 0x7FFAF2D907C0
    }

    public class NonEventAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAF2D8D310
    }

}