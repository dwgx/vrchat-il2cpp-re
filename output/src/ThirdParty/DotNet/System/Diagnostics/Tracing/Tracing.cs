// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics.Tracing
// Classes: 6
// Methods: 42

namespace ThirdParty.DotNet.System.Diagnostics.Tracing
{
    public class EventAttribute
    {
        public int <EventId>k__BackingField; // 0x10
        public 0x657F7C70 <Level>k__BackingField; // 0x14
        public 0x657F7D78 <Keywords>k__BackingField; // 0x18
        public 0x657F7D20 <Opcode>k__BackingField; // 0x20
        public string <Message>k__BackingField; // 0x28
        public 0x657F7CC8 <Task>k__BackingField; // 0x30

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
        public string <Name>k__BackingField; // 0x10
        public 0x657F7F88 <Settings>k__BackingField; // 0x18

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
        public string <Guid>k__BackingField; // 0x10
        public string <Name>k__BackingField; // 0x18

        // ── Methods ──
        public void set_Guid(){} // RVA: 0x2DEE30
        public void set_Name(){} // RVA: 0x343E80
        public void .ctor(){} // RVA: 0x2DD310
    }

    public class EventWrittenEventArgs
    {
        public int <EventId>k__BackingField; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<object> <Payload>k__BackingField; // 0x18

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