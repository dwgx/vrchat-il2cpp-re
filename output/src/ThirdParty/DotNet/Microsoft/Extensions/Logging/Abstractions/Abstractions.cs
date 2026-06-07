// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.DotNet.Microsoft.Extensions.Logging.Abstractions
// Classes: 5
// Methods: 28

namespace ThirdParty.DotNet.Microsoft.Extensions.Logging.Abstractions
{
    public class LogEntry`1
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x283FA0
        public void get_LogLevel(){} // RVA: 0xD840
        public void get_Category(){} // RVA: 0xCD60
        public void get_EventId(){} // RVA: 0x283FA0
        public void get_State(){} // RVA: 0x283FA0
        public void get_Exception(){} // RVA: 0xCD60
        public void get_Formatter(){} // RVA: 0xCD60
    }

    public class NullLogger : Instance
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x5BADF40
        public void .ctor(){} // RVA: 0x2DD310
        public void BeginScope(){} // RVA: 0x283FA0
        public void IsEnabled(){} // RVA: 0x2DD320
        public void Log(){} // RVA: 0x283FA0
        public void .cctor(){} // RVA: 0x5BADFA0
    }

    public class NullLoggerFactory : .ctor
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x2DD310
        public void CreateLogger(){} // RVA: 0x5BAE040
        public void AddProvider(){} // RVA: 0x2DD310
        public void Dispose(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5BAE0E0
    }

    public class NullLoggerProvider : get_Instance
    {
        // ── Methods ──
        public void get_Instance(){} // RVA: 0x5BAE180
        public void .ctor(){} // RVA: 0x2DD310
        public void CreateLogger(){} // RVA: 0x5BAE1E0
        public void Dispose(){} // RVA: 0x2DD310
        public void .cctor(){} // RVA: 0x5BAE280
    }

    public class NullLogger`1
    {
        // ── Methods ──
        public void BeginScope(){} // RVA: 0x283FA0
        public void Log(){} // RVA: 0x283FA0
        public void IsEnabled(){} // RVA: 0xE1F0
        public void .ctor(){} // RVA: 0x24A50
        public void .cctor(){} // RVA: 0x24A80
    }

}