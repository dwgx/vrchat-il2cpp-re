// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging.Abstractions
// Classes: 5
// Methods: 28

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging.Abstractions
{
    public class LogEntry`1 : ValueType
    {
        public 0x6B2B8CB8 LogLevel;
        public string Category;
        public Microsoft.Extensions.Logging.EventId EventId;
        public T State;
        public System.Exception Exception;
        public System.Func`3<T,System.Exception,string> Formatter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2E8DC40
        public void get_LogLevel(){} // RVA: 0x7FFAC2C59960
        public void get_Category(){} // RVA: 0x7FFAC2C58E90
        public void get_EventId(){} // RVA: 0x7FFAC2E8DC40
        public void get_State(){} // RVA: 0x7FFAC2E8DC40
        public void get_Exception(){} // RVA: 0x7FFAC2C58E90
        public void get_Formatter(){} // RVA: 0x7FFAC2C58E90
    }

    public class NullLogger : Object
    {
        public Microsoft.Extensions.Logging.Abstractions.NullLogger Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC8345490
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void BeginScope(){} // RVA: 0x7FFAC2E8DC40
        public void IsEnabled(){} // RVA: 0x7FFAC2F21320
        public void Log(){} // RVA: 0x7FFAC2E8DC40
        public void .cctor(){} // RVA: 0x7FFAC83454F0
    }

    public class NullLoggerFactory : Object
    {
        public Microsoft.Extensions.Logging.Abstractions.NullLoggerFactory Instance;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreateLogger(){} // RVA: 0x7FFAC8345590
        public void AddProvider(){} // RVA: 0x7FFAC2F21310
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC8345630
    }

    public class NullLoggerProvider : Object
    {
        public Microsoft.Extensions.Logging.Abstractions.NullLoggerProvider Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFAC83456D0
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void CreateLogger(){} // RVA: 0x7FFAC8345730
        public void Dispose(){} // RVA: 0x7FFAC2F21310
        public void .cctor(){} // RVA: 0x7FFAC83457D0
    }

    public class NullLogger`1 : Object
    {
        public Microsoft.Extensions.Logging.Abstractions.NullLogger`1<T> Instance;

        // ── Methods ──
        public void BeginScope(){} // RVA: 0x7FFAC2E8DC40
        public void Log(){} // RVA: 0x7FFAC2E8DC40
        public void IsEnabled(){} // RVA: 0x7FFAC2C5A310
        public void .ctor(){} // RVA: 0x7FFAC2C70980
        public void .cctor(){} // RVA: 0x7FFAC2C709B0
    }

}