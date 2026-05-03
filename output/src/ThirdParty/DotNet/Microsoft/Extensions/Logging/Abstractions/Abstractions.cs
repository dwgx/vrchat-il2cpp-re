// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging.Abstractions
// Classes: 5
// Methods: 28

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging.Abstractions
{
    public class LogEntry`1 : ValueType
    {
        public 0x666B1D94 _logLevel;
        public string _category;
        public Microsoft.Extensions.Logging.EventId _eventId;
        public T _state;
        public System.Exception _exception;
        public System.Func`3<T,System.Exception,string> _formatter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810A1420
        public void get_LogLevel(){} // RVA: 0x7FFE80E2EDB0
        public void get_Category(){} // RVA: 0x7FFE80E2E2E0
        public void get_EventId(){} // RVA: 0x7FFE810A1420
        public void get_State(){} // RVA: 0x7FFE810A1420
        public void get_Exception(){} // RVA: 0x7FFE80E2E2E0
        public void get_Formatter(){} // RVA: 0x7FFE80E2E2E0
    }

    public class NullLogger : Object
    {
        public Microsoft.Extensions.Logging.Abstractions.NullLogger _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE866EED90
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void BeginScope(){} // RVA: 0x7FFE810A1420
        public void IsEnabled(){} // RVA: 0x7FFE810FB320
        public void Log(){} // RVA: 0x7FFE810A1420
        public void .cctor(){} // RVA: 0x7FFE866EEDF0
    }

    public class NullLoggerFactory : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CreateLogger(){} // RVA: 0x7FFE866EEE90
        public void AddProvider(){} // RVA: 0x7FFE810FB310
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE866EEF30
    }

    public class NullLoggerProvider : Object
    {
        public Microsoft.Extensions.Logging.Abstractions.NullLoggerProvider _instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFE866EEFD0
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void CreateLogger(){} // RVA: 0x7FFE866EF030
        public void Dispose(){} // RVA: 0x7FFE810FB310
        public void .cctor(){} // RVA: 0x7FFE866EF0D0
    }

    public class NullLogger`1 : Object
    {
        // ── Methods ──
        public void BeginScope(){} // RVA: 0x7FFE810A1420
        public void Log(){} // RVA: 0x7FFE810A1420
        public void IsEnabled(){} // RVA: 0x7FFE80E2F760
        public void .ctor(){} // RVA: 0x7FFE80E45FE0
        public void .cctor(){} // RVA: 0x7FFE80E46010
    }

}