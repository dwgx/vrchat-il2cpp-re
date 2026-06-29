// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Infrastructure
// Classes: 7
// Methods: 18

namespace ThirdParty.Sentry.Sentry.Infrastructure
{
    public class ConsoleAndTraceDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A99CDAA0
        public void LogMessage(){} // RVA: 0x7AE22A520
    }

    public class ConsoleDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A99CDAA0
        public void LogMessage(){} // RVA: 0x7AE22A5B0
    }

    public class DiagnosticLogger : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A99CDAA0
        public void IsEnabled(){} // RVA: 0x7AE22A600
        public void Log(){} // RVA: 0x7AE22A610
        public void LogMessage(){} // RVA: 0x7A7E18800
        public void ScrubNewlines(){} // RVA: 0x7AE22A900
    }

    public class FileDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7AE22ACD0
        public void LogMessage(){} // RVA: 0x7AE22AE60
        public void <.ctor>b__3_0(){} // RVA: 0x7AE22AEF0
    }

    public class ISystemClock
    {
        // ── Methods ──
        public void GetUtcNow(){} // RVA: 0x7A7E00490
    }

    public class SystemClock : Object
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A80D7310
        public void GetUtcNow(){} // RVA: 0x7AE22AF30
        public void .cctor(){} // RVA: 0x7AE22AFE0
    }

    public class TraceDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7A99CDAA0
        public void LogMessage(){} // RVA: 0x7AE22B080
    }

}