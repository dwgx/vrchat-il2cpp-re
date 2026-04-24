// VRChat IL2CPP Deobfuscated Source
// Namespace: ThirdParty.Unity.UnityEngine.Purchasing
// Classes: 4
// Methods: 19

namespace ThirdParty.Unity.UnityEngine.Purchasing
{
    public class MetricizedAppleStoreImpl : AppleStoreImpl
    {
        public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService; // 0xD0

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DF41C0
        public void RetrieveProducts(){} // RVA: 0x7FFD54DF4230
        public void Purchase(){} // RVA: 0x7FFD54DF4460
        public void <>n__6(){} // RVA: 0x7FFD54DF4700
        public void <>n__7(){} // RVA: 0x7FFD54DF4710
    }

    public class MetricizedGooglePlayStoreExtensions : GooglePlayStoreExtensions
    {
        public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService; // 0x38

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DE4A80
    }

    public class MetricizedGooglePlayStoreService : GooglePlayStoreService
    {
        public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService; // 0x80
        public UnityEngine.Purchasing.Telemetry.ITelemetryDiagnostics m_TelemetryDiagnostics; // 0x88

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DDF580
        public void DequeueQueryProducts(){} // RVA: 0x7FFD54DDF6D0
        public void DequeueFetchPurchases(){} // RVA: 0x7FFD54DDF8B0
        public void RetrieveProducts(){} // RVA: 0x7FFD54DDFA10
        public void Purchase(){} // RVA: 0x7FFD54DDFD00
        public void <>n__0(){} // RVA: 0x7FFD54DDFFA0
        public void <>n__1(){} // RVA: 0x7FFD54DD8C90
        public void <>n__2(){} // RVA: 0x7FFD54DDFFB0
    }

    public class MetricizedJsonStore : JSONStore
    {
        public UnityEngine.Purchasing.Telemetry.ITelemetryMetricsService m_TelemetryMetricsService; // 0x48

        // ── Methods ──
        public void .ctor(){} // RVA: 0x7FFD54DF52D0
        public void RetrieveProducts(){} // RVA: 0x7FFD54DF5340
        public void Purchase(){} // RVA: 0x7FFD54DF5570
        public void <>n__0(){} // RVA: 0x7FFD54DF4700
        public void <>n__1(){} // RVA: 0x7FFD54DF4710
    }

}