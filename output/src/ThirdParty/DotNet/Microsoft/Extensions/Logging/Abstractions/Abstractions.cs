// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging.Abstractions
// Classes: 3
// Methods: 18

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging.Abstractions
{
    public class LogEntry`1 : ValueType
    {
        public 0x66618CB8 LogLevel;
        public string Category;
        public Microsoft.Extensions.Logging.EventId EventId;
        public T State;
        public System.Exception Exception;
        public System.Func`3<T,System.Exception,string> Formatter;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD4E2ADC40
        public void get_LogLevel(){} // RVA: 0x7FFD4E079960
        public void get_Category(){} // RVA: 0x7FFD4E078E90
        public void get_EventId(){} // RVA: 0x7FFD4E2ADC40
        public void get_State(){} // RVA: 0x7FFD4E2ADC40
        public void get_Exception(){} // RVA: 0x7FFD4E078E90
        public void get_Formatter(){} // RVA: 0x7FFD4E078E90
    }

    public class NullLogger : Object
    {
        public Microsoft.Extensions.Logging.Abstractions.NullLogger Instance;

        // ── Methods ──
        public void get_Instance(){} // RVA: 0x7FFD53765490
        public void .ctor(){} // RVA: 0x7FFD4E341310
        public void BeginScope(){} // RVA: 0x7FFD4E2ADC40
        public void IsEnabled(){} // RVA: 0x7FFD4E341320
        public void Log(){} // RVA: 0x7FFD4E2ADC40
        public void .cctor(){} // RVA: 0x7FFD537654F0
    }

    public class NullLogger`1 : Object
    {
        public Microsoft.Extensions.Logging.Abstractions.NullLogger`1<T> Instance;

        // ── Methods ──
        public void BeginScope(){} // RVA: 0x7FFD4E2ADC40
        public void Log(){} // RVA: 0x7FFD4E2ADC40
        public void IsEnabled(){} // RVA: 0x7FFD4E07A310
        public void .ctor(){} // RVA: 0x7FFD4E090980
        public void .cctor(){} // RVA: 0x7FFD4E0909B0
    }

}