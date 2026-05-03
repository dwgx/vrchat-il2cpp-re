// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 2
// Methods: 13

namespace ThirdParty.Sentry.Sentry
{
    public class EventLikeExtensions : Object
    {
        // ── Methods ──
        public void AddBreadcrumb(){} // RVA: 0x7FFE86DEA950 | overloaded x3
        public void HasUser(){} // RVA: 0x7FFE86DEAA50
        public void SetFingerprint(){} // RVA: 0x7FFE86DEAC30 | overloaded x2
    }

    public class ExperimentalMetricsOptions : Object
    {
        public bool _enableCodeLocations; // 0x10
        public System.Collections.Generic.IList`1<Sentry.SubstringOrRegexPattern> _captureSystemDiagnosticsInstruments; // 0x18
        public System.Collections.Generic.IList`1<Sentry.SubstringOrRegexPattern> _captureSystemDiagnosticsMeters; // 0x20

        // ── Methods ──
        public void get_EnableCodeLocations(){} // RVA: 0x7FFE811C55E0
        public void set_EnableCodeLocations(){} // RVA: 0x7FFE811C55F0
        public void get_CaptureSystemDiagnosticsInstruments(){} // RVA: 0x7FFE810FE7C0
        public void set_CaptureSystemDiagnosticsInstruments(){} // RVA: 0x7FFE86DE31C0
        public void get_CaptureSystemDiagnosticsMeters(){} // RVA: 0x7FFE811290C0
        public void set_CaptureSystemDiagnosticsMeters(){} // RVA: 0x7FFE86DE3260
        public void .ctor(){} // RVA: 0x7FFE86DE3300
    }

}