// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.System.Diagnostics.Tracing
// Classes: 6
// Methods: 27

namespace ThirdParty.DotNet.System.Diagnostics.Tracing
{
    public class EventAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80DA0C0
        public void set_EventId(){} // RVA: 0x7A80DA0C0
        public void set_Level(){} // RVA: 0x7A8669360
        public void set_Keywords(){} // RVA: 0x7A8A224D0
        public void set_Opcode(){} // RVA: 0x7A8738180
        public void set_Message(){} // RVA: 0x7A80D8E80
        public void set_Task(){} // RVA: 0x7A8133110
    }

    public class EventListener : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void EnableEvents(){} // RVA: 0x7A80D7310
        public void OnEventSourceCreated(){} // RVA: 0x7A80D7310
        public void OnEventWritten(){} // RVA: 0x7A80D7310
        public void Dispose(){} // RVA: 0x7A80D7310
    }

    public class EventSource : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7ADBE6E10
        public void Finalize(){} // RVA: 0x7AD899E40
        public void get_Guid(){} // RVA: 0x7ADBE6E70
        public void set_Name(){} // RVA: 0x7A80D8E20
        public void set_Settings(){} // RVA: 0x7A84385B0
        public void IsEnabled(){} // RVA: 0x7A80D7320
        public void Dispose(){} // RVA: 0x7A80D7310
        public void WriteEvent(){} // RVA: 0x7ADBE7780
        public void WriteEventCore(){} // RVA: 0x7A80D7310
    }

    public class EventSourceAttribute : Attribute
    {
        // ── Methods ──
        public void set_Guid(){} // RVA: 0x7A80D8E20
        public void set_Name(){} // RVA: 0x7A813E420
        public void .ctor(){} // RVA: 0x7A80D7310
    }

    public class EventWrittenEventArgs : EventArgs
    {
        // ── Methods ──
        public void get_EventId(){} // RVA: 0x7A8124910
        public void get_Payload(){} // RVA: 0x7A80DA7B0
    }

    public class NonEventAttribute : Attribute
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
    }

}