// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics.Tracing
// Classes: 6
// Methods: 42

namespace ThirdParty.DotNet.System.Diagnostics.Tracing
{
    public class EventAttribute : Attribute
    {
        public int _eventId; // 0x10
        public 0x664D5C14 _level; // 0x14
        public 0x664D5D1C _keywords; // 0x18
        public 0x664D5CC4 _opcode; // 0x20
        public string _message; // 0x28
        public 0x664D5C6C _task; // 0x30

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FE0C0
        public void set_EventId(){} // RVA: 0x7FFE810FE0C0
        public void set_Level(){} // RVA: 0x7FFE8164E0F0
        public void set_Keywords(){} // RVA: 0x7FFE819EA910
        public void set_Opcode(){} // RVA: 0x7FFE8170B670
        public void set_Message(){} // RVA: 0x7FFE810FCE90
        public void set_Task(){} // RVA: 0x7FFE81156CE0
    }

    public class EventListener : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void EnableEvents(){} // RVA: 0x7FFE810FB310
        public void OnEventSourceCreated(){} // RVA: 0x7FFE810FB310
        public void OnEventWritten(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE810FB310
    }

    public class EventSource : Object
    {
        public string _name; // 0x10
        public 0x664D5F2C _settings; // 0x18
        public object field_2; // 0x7A1

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86939140 | overloaded x4
        public void Finalize(){} // RVA: 0x7FFE865ED780
        public void get_Guid(){} // RVA: 0x7FFE869391A0
        public void set_Name(){} // RVA: 0x7FFE810FCE30
        public void set_Settings(){} // RVA: 0x7FFE8144DF00
        public void IsEnabled(){} // RVA: 0x7FFE810FB320 | overloaded x2
        public void Dispose(){} // RVA: 0x7FFE810FB310 | overloaded x2
        public void WriteEvent(){} // RVA: 0x7FFE86939AB0 | overloaded x11
        public void WriteEventCore(){} // RVA: 0x7FFE810FB310
    }

    public class EventSourceAttribute : Attribute
    {
        public string _guid; // 0x10
        public string _name; // 0x18

        // ── Methods ──
        public void set_Guid(){} // RVA: 0x7FFE810FCE30
        public void set_Name(){} // RVA: 0x7FFE81161E80
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

    public class EventWrittenEventArgs : EventArgs
    {
        public int _eventId; // 0x10
        public System.Collections.ObjectModel.ReadOnlyCollection`1<object> _payload; // 0x18

        // ── Methods ──
        public void get_EventId(){} // RVA: 0x7FFE811485C0
        public void get_Payload(){} // RVA: 0x7FFE810FE7C0
    }

    public class NonEventAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
    }

}