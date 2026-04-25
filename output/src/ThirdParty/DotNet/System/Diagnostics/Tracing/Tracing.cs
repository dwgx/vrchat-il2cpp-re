// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics.Tracing
// Classes: 6
// Methods: 42

namespace ThirdParty.DotNet.System.Diagnostics.Tracing
{
    public class EventAttribute : Attribute
    {
        public int EventId; // 0x10
        public 0x6B0DCCF0 Level; // 0x14
        public 0x6B0DCDF8 Keywords; // 0x18
        public 0x6B0DCDA0 Opcode; // 0x20
        public string Message; // 0x28
        public 0x6B0DCD48 Task; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F240C0
        public void set_EventId(){} // RVA: 0x7FFAC2F240C0
        public void set_Level(){} // RVA: 0x7FFAC33D4990
        public void set_Keywords(){} // RVA: 0x7FFAC38920D0
        public void set_Opcode(){} // RVA: 0x7FFAC35DB7A0
        public void set_Message(){} // RVA: 0x7FFAC2F22E90
        public void set_Task(){} // RVA: 0x7FFAC2F7CCE0
    }

    public class EventListener : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void EnableEvents(){} // RVA: 0x7FFAC2F21310
        public void OnEventSourceCreated(){} // RVA: 0x7FFAC2F21310
        public void OnEventWritten(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC2F21310
    }

    public class EventSource : Object
    {
        public string Guid; // 0x10
        public 0x6B0DD008 Name; // 0x18

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC858F930 | overloaded x4
        public void Finalize(){} // RVA: 0x7FFAC8243E40
        public void get_Guid(){} // RVA: 0x7FFAC858F990
        public void set_Name(){} // RVA: 0x7FFAC2F22E30
        public void set_Settings(){} // RVA: 0x7FFAC392CD10
        public void IsEnabled(){} // RVA: 0x7FFAC2F21320 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFAC2F21310 | overloaded x2
        public void WriteEvent(){} // RVA: 0x7FFAC85902A0 | overloaded x11
        public void WriteEventCore(){} // RVA: 0x7FFAC2F21310
    }

    public class EventSourceAttribute : Attribute
    {
        public string Guid; // 0x10
        public string Name; // 0x18

        // ── Methods ──
        public void set_Guid(){} // RVA: 0x7FFAC2F22E30
        public void set_Name(){} // RVA: 0x7FFAC2F87E80
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

    public class EventWrittenEventArgs : EventArgs
    {
        public int EventId; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<object> Payload; // 0x18

        // ── Methods ──
        public void get_EventId(){} // RVA: 0x7FFAC2F6E5C0
        public void get_Payload(){} // RVA: 0x7FFAC2F247C0
    }

    public class NonEventAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
    }

}