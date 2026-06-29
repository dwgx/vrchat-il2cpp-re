// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics.Tracing
// Classes: 6
// Methods: 27

namespace ThirdParty.DotNet.System.Diagnostics.Tracing
{
    public class EventAttribute : Attribute
    {
        public object _eventId;
        public object _level;
        public object _keywords;
        public object _opcode;
        public object _message;
        public object _task;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB460A0
        public void set_EventId(){} // RVA: 0xB460A0
        public void set_Level(){} // RVA: 0x116BB10
        public void set_Keywords(){} // RVA: 0x15428E0
        public void set_Opcode(){} // RVA: 0x1269760
        public void set_Message(){} // RVA: 0xB44DC0
        public void set_Task(){} // RVA: 0xB9E090
    }

    public class EventListener : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void EnableEvents(){} // RVA: 0xB43310
        public void OnEventSourceCreated(){} // RVA: 0xB43310
        public void OnEventWritten(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0xB43310
    }

    public class EventSource : Object
    {
        public object _name;
        public object _settings;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6871E00
        public void Finalize(){} // RVA: 0x6527310
        public void get_Guid(){} // RVA: 0x6871E60
        public void set_Name(){} // RVA: 0xB44D60
        public void set_Settings(){} // RVA: 0x1033F40
        public void IsEnabled(){} // RVA: 0xB43320
        public void Dispose(){} // RVA: 0xB43310
        public void WriteEvent(){} // RVA: 0x6872700
        public void WriteEventCore(){} // RVA: 0xB43310
    }

    public class EventSourceAttribute : Attribute
    {
        public object _guid;
        public object _name;

        // ── Methods ──
        public void set_Guid(){} // RVA: 0xB44D60
        public void set_Name(){} // RVA: 0xBA9BA0
        public void .ctor(){} // RVA: 0xB43310
    }

    public class EventWrittenEventArgs : EventArgs
    {
        public object _eventId;
        public object _payload;

        // ── Methods ──
        public void get_EventId(){} // RVA: 0xB8F8F0
        public void get_Payload(){} // RVA: 0xB465B0
    }

    public class NonEventAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
    }

}