// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry.Infrastructure
// Classes: 7
// Methods: 19

namespace ThirdParty.Sentry.Sentry.Infrastructure
{
    public class ConsoleAndTraceDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC469BCA0
        public void LogMessage(){} // RVA: 0x7FFAC8BD3900
    }

    public class ConsoleDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC469BCA0
        public void LogMessage(){} // RVA: 0x7FFAC8BD3990
    }

    public class DiagnosticLogger : Object
    {
        public 0x6B198C68 _minimalLevel; // 0x10

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC469BCA0
        public void IsEnabled(){} // RVA: 0x7FFAC8BD39E0
        public void Log(){} // RVA: 0x7FFAC8BD39F0
        public void LogMessage(){} // RVA: 0x7FFAC2C70A40
        public void ScrubNewlines(){} // RVA: 0x7FFAC8BD3CE0
    }

    public class FileDiagnosticLogger : DiagnosticLogger
    {
        public bool _alsoWriteToConsole; // 0x18
        public System.IO.StreamWriter _writer; // 0x20

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC8BD40B0 | overloaded x2
        public void LogMessage(){} // RVA: 0x7FFAC8BD4240
        public void <.ctor>b__3_0(){} // RVA: 0x7FFAC8BD42D0
    }

    public class ISystemClock
    {
        // ── Methods ──
        public void GetUtcNow(){} // RVA: 0x7FFAC2C588A0
    }

    public class SystemClock : Object
    {
        public Sentry.Infrastructure.SystemClock Clock;

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC2F21310
        public void GetUtcNow(){} // RVA: 0x7FFAC8BD4310
        public void .cctor(){} // RVA: 0x7FFAC8BD43C0
    }

    public class TraceDiagnosticLogger : DiagnosticLogger
    {
        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFAC469BCA0
        public void LogMessage(){} // RVA: 0x7FFAC8BD4460
    }

}