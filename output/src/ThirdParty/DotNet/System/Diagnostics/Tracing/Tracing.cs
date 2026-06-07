// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics.Tracing
// Classes: 6
// Methods: 42

namespace ThirdParty.DotNet.System.Diagnostics.Tracing
{
    public class EventAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2E00C0
        public void set_EventId(){} // RVA: 0x2E00C0
        public void set_Level(){} // RVA: 0x8AC660
        public void set_Keywords(){} // RVA: 0xC5BE60
        public void set_Opcode(){} // RVA: 0x99E0D0
        public void set_Message(){} // RVA: 0x2DEE90
        public void set_Task(){} // RVA: 0x338CE0
    }

    public class EventListener
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void EnableEvents(){} // RVA: 0x2DD310
        public void OnEventSourceCreated(){} // RVA: 0x2DD310
        public void OnEventWritten(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x2DD310
    }

    public class EventSource
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x5DF8300 | overloaded x4
        public void Finalize(){} // RVA: 0x5AAC950
        public void get_Guid(){} // RVA: 0x5DF8360
        public void set_Name(){} // RVA: 0x2DEE30
        public void set_Settings(){} // RVA: 0x6374E0
        public void IsEnabled(){} // RVA: 0x2DD320 | overloaded x2
        public void Dispose(){} // RVA: 0x2DD310 | overloaded x2
        public void WriteEvent(){} // RVA: 0x5DF8C70 | overloaded x11
        public void WriteEventCore(){} // RVA: 0x2DD310
    }

    public class EventSourceAttribute
    {
        // ── Methods ──
        public void set_Guid(){} // RVA: 0x2DEE30
        public void set_Name(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EventWrittenEventArgs
    {
        // ── Methods ──
        public void get_EventId(){} // RVA: 0x32A5C0
        public void get_Payload(){} // RVA: 0x2E07C0
    }

    public class NonEventAttribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
    }

}