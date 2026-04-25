// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Sentry.Sentry
// Classes: 2
// Methods: 13

namespace ThirdParty.Sentry.Sentry
{
    public class EventLikeExtensions : Object
    {
        // ── Methods ──
        public void AddBreadcrumb(){} // RVA: 0x7FFAC8A412C0 | overloaded x3
        public void HasUser(){} // RVA: 0x7FFAC8A413C0
        public void SetFingerprint(){} // RVA: 0x7FFAC8A415A0 | overloaded x2
    }

    public class ExperimentalMetricsOptions : Object
    {
        public bool EnableCodeLocations; // 0x10
        public System.Collections.Generic.IList`1<Sentry.SubstringOrRegexPattern> CaptureSystemDiagnosticsInstruments; // 0x18
        public System.Collections.Generic.IList`1<Sentry.SubstringOrRegexPattern> CaptureSystemDiagnosticsMeters; // 0x20

        // ── Methods ──
        public void get_EnableCodeLocations(){} // RVA: 0x7FFAC2FEB5E0
        public void set_EnableCodeLocations(){} // RVA: 0x7FFAC2FEB5F0
        public void get_CaptureSystemDiagnosticsInstruments(){} // RVA: 0x7FFAC2F247C0
        public void set_CaptureSystemDiagnosticsInstruments(){} // RVA: 0x7FFAC8A39B30
        public void get_CaptureSystemDiagnosticsMeters(){} // RVA: 0x7FFAC2F4F0C0
        public void set_CaptureSystemDiagnosticsMeters(){} // RVA: 0x7FFAC8A39BD0
        public void .ctor(){} // RVA: 0x7FFAC8A39C70
    }

}