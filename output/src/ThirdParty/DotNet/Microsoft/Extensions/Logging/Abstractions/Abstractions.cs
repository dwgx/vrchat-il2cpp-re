// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging.Abstractions
// Classes: 6
// Methods: 33

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging.Abstractions
{
    public class LogEntry`1 : ValueType
    {
        public object _logLevel;
        public object _category;
        public object _eventId;
        public object _state;
        public object _exception;
        public object _formatter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xA94080
        public void get_LogLevel(){} // RVA: 0x87C130
        public void get_Category(){} // RVA: 0x87C0A0
        public void get_EventId(){} // RVA: 0xA94080
        public void get_State(){} // RVA: 0xA94080
        public void get_Exception(){} // RVA: 0x87C0A0
        public void get_Formatter(){} // RVA: 0x87C0A0
    }

    public class NullLogger : Object
    {
        public object _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6626CC0
        public void .ctor(){} // RVA: 0xB43310
        public void BeginScope(){} // RVA: 0xA94080
        public void IsEnabled(){} // RVA: 0xB43320
        public void Log(){} // RVA: 0xA94080
        public void .cctor(){} // RVA: 0x6626D20
    }

    public class NullLoggerFactory : Object
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void CreateLogger(){} // RVA: 0x6626DC0
        public void AddProvider(){} // RVA: 0xB43310
        public void Dispose(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6626E60
    }

    public class NullLoggerProvider : Object
    {
        public object _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x6626F00
        public void .ctor(){} // RVA: 0xB43310
        public void CreateLogger(){} // RVA: 0x6626F60
        public void Dispose(){} // RVA: 0xB43310
        public void .cctor(){} // RVA: 0x6627000
    }

    public class NullLogger`1 : Object
    {
        public object Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void BeginScope(){} // RVA: 0xA94080
        public void Log(){} // RVA: 0xA94080
        public void IsEnabled(){} // RVA: 0xB43320
        public void .cctor(){} // RVA: 0x31C0C90
    }

    public class NullLogger`1 : Object
    {
        public object Instance;

        // ── Methods ──
        public void BeginScope(){} // RVA: 0xA94080
        public void Log(){} // RVA: 0xA94080
        public void IsEnabled(){} // RVA: 0x87DD20
        public void .ctor(){} // RVA: 0x894290
        public void .cctor(){} // RVA: 0x8942F0
    }

}