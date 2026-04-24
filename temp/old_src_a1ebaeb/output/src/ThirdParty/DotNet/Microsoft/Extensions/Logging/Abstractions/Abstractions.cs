// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging.Abstractions
// Classes: 3
// Methods: 18

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging.Abstractions
{
    public class LogEntry`1 : ValueType
    {
        public object _eventId; // 0x31228480, was: <EventId>k__BackingField
        public object _formatter; // 0x31228480, was: <Formatter>k__BackingField
        public object LogLevel; // 0x17000048
        public object Category; // 0x17000049

        // ── Original Methods ──
        public void .ctor(){} // RVA: 0x7ffaa887e5c0
        public void get_LogLevel(){} // RVA: 0x7ffaa8649ca0
        public void get_Category(){} // RVA: 0x7ffaa86491d0
        public void get_EventId(){} // RVA: 0x7ffaa887e5c0
        public void get_State(){} // RVA: 0x7ffaa887e5c0
        public void get_Exception(){} // RVA: 0x7ffaa86491d0
        public void get_Formatter(){} // RVA: 0x7ffaa86491d0
    }

    public class NullLogger : Object
    {
        // ── Original Methods ──
        public void get_Instance(){} // RVA: 0x7ffaadd66640
        public void .ctor(){} // RVA: 0x7ffaa8932310
        public void IsEnabled(){} // RVA: 0x7ffaa8932320
        public void Log(){} // RVA: 0x7ffaa887e5c0
        public void .cctor(){} // RVA: 0x7ffaadd666a0
        // ── Binary Analysis Named ──
        public void BeginScope(){} // RVA: 0x7ffaa887e5c0
    }

    public class NullLogger`1 : Object
    {
        // ── Original Methods ──
        public void Log(){} // RVA: 0x7ffaa887e5c0
        public void IsEnabled(){} // RVA: 0x7ffaa864a650
        public void .ctor(){} // RVA: 0x7ffaa8660cc0
        public void .cctor(){} // RVA: 0x7ffaa8660cf0
        // ── Binary Analysis Named ──
        public void BeginScope(){} // RVA: 0x7ffaa887e5c0
    }

}