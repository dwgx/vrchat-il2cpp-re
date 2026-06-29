// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Infrastructure
// Classes: 7
// Methods: 18

namespace ThirdParty.Sentry.Sentry.Infrastructure
{
    public class ConsoleAndTraceDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24EAB10
        public void LogMessage(){} // RVA: 0x6EACFE0
    }

    public class ConsoleDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24EAB10
        public void LogMessage(){} // RVA: 0x6EAD070
    }

    public class DiagnosticLogger : Object
    {
        public object _minimalLevel;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x24EAB10
        public void IsEnabled(){} // RVA: 0x6EAD0C0
        public void Log(){} // RVA: 0x6EAD0D0
        public void LogMessage(){} // RVA: 0x894320
        public void ScrubNewlines(){} // RVA: 0x6EAD3C0
    }

    public class FileDiagnosticLogger : DiagnosticLogger
    {
        public object _alsoWriteToConsole;
        public object _writer;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x6EAD790
        public void LogMessage(){} // RVA: 0x6EAD920
        public void <.ctor>b__3_0(){} // RVA: 0x6EAD9B0
    }

    public class ISystemClock
    {
        // ── Methods ──
        public void GetUtcNow(){} // RVA: 0x87BEB0
    }

    public class SystemClock : Object
    {
        public object Clock;

        // ── Methods ──
        public void .ctor(){} // RVA: 0xB43310
        public void GetUtcNow(){} // RVA: 0x6EAD9F0
        public void .cctor(){} // RVA: 0x6EADAA0
    }

    public class TraceDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x24EAB10
        public void LogMessage(){} // RVA: 0x6EADB40
    }

}