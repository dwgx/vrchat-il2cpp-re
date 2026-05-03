// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Infrastructure
// Classes: 7
// Methods: 19

namespace ThirdParty.Sentry.Sentry.Infrastructure
{
    public class ConsoleAndTraceDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8299FB10
        public void LogMessage(){} // RVA: 0x7FFE86F7CF80
    }

    public class ConsoleDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8299FB10
        public void LogMessage(){} // RVA: 0x7FFE86F7D010
    }

    public class DiagnosticLogger : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8299FB10
        public void IsEnabled(){} // RVA: 0x7FFE86F7D060
        public void Log(){} // RVA: 0x7FFE86F7D070
        public void LogMessage(){} // RVA: 0x7FFE80E460A0
        public void ScrubNewlines(){} // RVA: 0x7FFE86F7D360
    }

    public class FileDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE86F7D720 | overloaded x2
        public void LogMessage(){} // RVA: 0x7FFE86F7D8A0
        public void <.ctor>b__3_0(){} // RVA: 0x7FFE86F7D930
    }

    public class ISystemClock
    {
        // ── Methods ──
        public void GetUtcNow(){} // RVA: 0x7FFE80E2DCF0
    }

    public class SystemClock : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE810FB310
        public void GetUtcNow(){} // RVA: 0x7FFE86F7D970
        public void .cctor(){} // RVA: 0x7FFE86F7DA20
    }

    public class TraceDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFE8299FB10
        public void LogMessage(){} // RVA: 0x7FFE86F7DAC0
    }

}